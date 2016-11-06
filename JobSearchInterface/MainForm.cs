/*
 * Created by SharpDevelop.
 * User: Michal
 * Date: 11/1/2016
 * Time: 3:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Indeed.Models;
using Indeed;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace JobSearchInterface
{
	/// <summary>
	/// The form accepts inputs for search types, job description and looks for 
	/// an email address in the description. Job postings without emails are
	/// usually a waste of time and require you to either shotgun apply, which 
	/// is filtered and ignored, or apply on someone else's website, which is
	/// a complete waste of time again. Instead, look for the hiring manager's
	/// email address in the description, show it in the job details panel
	/// and allows user to email somone directly.
	/// </summary>
	public partial class MainForm : Form
	{
		private const string appVersion = "2.5.3";
		private bool developer_mode = false;
		private bool demo_mode = false;
		
		private static string[] countryListAbr = {
			"aq", "ar",	"au", "at", "bh", "be",	"br", "ca", "cl", "cn", "co", "cr",
			"cz", "dk", "ec", "eg", "fi", "fr", "de", "gr",	"hk", "hu", "in", "id",
			"ie", "il", "it", "jp",	"kw", "lu",	"my", "mx", "ma", "nl",	"nz", "ng",
			"no", "om",	"pk", "pa", "pe", "ph", "pl", "pt", "qa", "ro", "ru", "sa",
			"sg", "za", "kr", "es", "se", "ch", "tw", "th", "tr", "ua", "ae", "gb",
			"us", "uy", "ve", "vn"
		};
		
		private const string apiPublisherKey = "444457643170882";
		public IndeedQueryParameters qParameters = new IndeedQueryParameters();
		public List<IndeedSearchResult> indeedResponse = new List<IndeedSearchResult>();
		private SaveFileDialog savefileRemember = new SaveFileDialog();
		private ListViewItemComparer sorter;
		
		public MainForm()
		{
//			qParameters = new IndeedQueryParameters();
//			indeedResponse = new List<IndeedSearchResult>();
			InitializeComponent();
			
			//show version number
			this.Text += " v" + appVersion;
			
			//init boxes
			jobsiteCombo.SelectedIndex = 0;
			countryCombo.SelectedIndex = 7;
			sitetypeBox.SelectedIndex = 1;
			jobtypeBox.SelectedIndex = 0;
			
			//check for debug mode
			if(!developer_mode) {
				debugCheck.Visible = false;
				tabBox.TabPages.Remove(debugTab);
			}
			
			//check for demo mode
			if(demo_mode) {
				numericPostAge.Maximum = 5;
				numericLimit.Maximum = 10;
				numericSearchRadius.Maximum = 25;
				emailCheck.Enabled = false;
				this.Text += " Demo";
			}
			
			sorter = new ListViewItemComparer();
			jobListBox.ListViewItemSorter = sorter;
		}
		
		public IndeedQueryParameters collectParams(int start) {
			var pams = new IndeedQueryParameters();
			pams.Country = countryListAbr[countryCombo.SelectedIndex];
			pams.FromAge = numericPostAge.Value.ToString();
			pams.Location = cityText.Text;
			pams.JobQuery = searchQueryText.Text;
			pams.SearchRadius = numericSearchRadius.Value.ToString();
			pams.St = sitetypeBox.SelectedItem.ToString();
			pams.Jt = jobtypeBox.SelectedItem.ToString();
			
			//some defaults
			pams.Sort = "relevance";
			pams.Start = start.ToString();
			pams.Limit = numericLimit.Value.ToString();
			pams.Filter = "1";
			pams.LatitudeLongitude = "1";
			pams.Channel = "neptuneSearch";
			pams.UserIP = new System.Net.WebClient().DownloadString("https://api.ipify.org");
			pams.UserAgent = "Firefox/40.1";
			
			if(debugCheck.Checked) {
				debugText.Text += pams.Channel + " // ";
				debugText.Text += pams.Country + " // ";
				debugText.Text += pams.Filter + " // ";
				debugText.Text += pams.FromAge + " // ";
				debugText.Text += pams.JobQuery + " // ";
				debugText.Text += pams.Jt + " // ";
				debugText.Text += pams.LatitudeLongitude + " // ";
				debugText.Text += pams.Limit + " // ";
				debugText.Text += pams.Location + " // ";
				debugText.Text += pams.SearchRadius + " // ";
				debugText.Text += pams.Sort + " // ";
				debugText.Text += pams.St + " // ";
				debugText.Text += pams.Start + " // ";
				debugText.Text += pams.UserAgent + " // ";
				debugText.Text += pams.UserIP + "\r\n";
			}
			return pams;
		}
		
		void SearchButtonClick(object sender, EventArgs e)
		{
			/*
			 * First collect all the necessary information from all the input
			 * boxes. This includes the age of the postings, the specific title,
			 * the country, radius, etc.
			 */
			if(jobsiteCombo.SelectedIndex < 0) {
				MessageBox.Show("Please choose a search site");
				return;
			}
			if(countryCombo.SelectedIndex < 0) {
				MessageBox.Show("Please choose a country");
				return;
			}
			if(sitetypeBox.SelectedIndex < 0) {
				MessageBox.Show("Please choose all options");
				return;
			}
			if(jobtypeBox.SelectedIndex < 0) {
				MessageBox.Show("Please choose all options");
				return;
			}
			if(string.IsNullOrEmpty(cityText.Text)) {
				MessageBox.Show("Please enter city");
				return;
			}
			
			//disable search button to prevent multiple clicks
			searchButton.Enabled = false;
			
			searchProgress.Value = 0;
			jobListBox.Items.Clear();
			if(!debugCheck.Checked)
				debugText.Clear();
			
			int total = 0;
			int totalresponse = 0;
			
			if(jobsiteCombo.SelectedItem.ToString() == "Indeed") {
				try {
					for(int index = 0; index < numericLimit.Value; index+=25) {
						qParameters = collectParams(index);
						indeedResponse = IndeedSearch.GetSearchResults(qParameters, apiPublisherKey);
						int current = 0;
						totalresponse += indeedResponse.Count;
						
						jobListBox.BeginUpdate();
						foreach(var item in indeedResponse) {
							//TODO original row generator, ran into some issues with exporting where
							//natural commas will cause csv file to render wrong, so trying to 
							//eliminate commas with spaces
//							string[] row = {item.JobTitle, item.Company, item.FormattedLocationFull, item.FormattedRelativeTime, item.Snippet, item.URL};
							string[] row = {item.JobTitle.Replace(","," "), item.Company.Replace(","," "), item.FormattedLocationFull.Replace(","," "), item.FormattedRelativeTime.Replace(","," "), item.Snippet.Replace(","," "), item.URL};
							var listViewItem = new ListViewItem(row);
							if(emailCheck.Checked) {
								if(item.Snippet.Contains("@")) {
									listViewItem.BackColor = Color.LightSteelBlue;
								}
							}
							jobListBox.Items.Add(listViewItem);
							
							total++;
							current++;
							//searchProgress.Value = current / indeedResponse.Count * 100;
							searchProgress.Value = total / totalresponse * 100;
						}
						jobListBox.EndUpdate();
						resultsLabel.Text = "Results: " + total;
						if(indeedResponse.Count < 25) break;
					}
				} catch (Exception ex) {
	//				MessageBox.Show("error: " + ex.Message);
					MessageBox.Show("No results for this query");
					resultsLabel.Text = "Results: 0";
					//switch to tab
					tabBox.SelectTab(searchsettingsTab);
					return;
				}
			}
			
			searchButton.Enabled = true;
			tabBox.SelectTab(joblistTab);
		}
		
		void DebugCheckCheckedChanged(object sender, EventArgs e)
		{
			if(debugCheck.Checked) {
				debugText.Enabled = true;
			} else {
				debugText.Enabled = false;
			}
		}
		void JobListBoxMouseDoubleClick(object sender, MouseEventArgs e)
		{
			Process.Start(jobListBox.SelectedItems[0].SubItems[5].Text);
		}
		
		void exportToCSV(object sender, EventArgs e)
		{
			
			var savefile = new SaveFileDialog();
			var filename = searchQueryText.Text.Replace("\"",string.Empty);
			savefile.FileName = filename + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
			savefile.Filter = "CSV file (*.csv)|*.csv";
			if(savefile.ShowDialog() == DialogResult.OK) {
				using (var sw = new StreamWriter(savefile.FileName))
					for(int idx = 0; idx < jobListBox.Items.Count; idx++) {
//					sw.WriteLine(jobListBox.Items[idx].SubItems[0].Text.Replace(";",",")+";"+jobListBox.Items[idx].SubItems[1].Text.Replace(";",",")+";"+jobListBox.Items[idx].SubItems[2].Text.Replace(";",",")+";"+jobListBox.Items[idx].SubItems[3].Text.Replace(";",",")+";"+jobListBox.Items[idx].SubItems[4].Text.Replace(";",",")+";"+jobListBox.Items[idx].SubItems[5].Text.Replace(";",","));
					sw.WriteLine(jobListBox.Items[idx].SubItems[0].Text+","+jobListBox.Items[idx].SubItems[1].Text+","+jobListBox.Items[idx].SubItems[2].Text+","+jobListBox.Items[idx].SubItems[3].Text+","+jobListBox.Items[idx].SubItems[4].Text+","+"=HYPERLINK(\""+jobListBox.Items[idx].SubItems[5].Text+"\")");
				}
			} else {
				return;
			}
			var path = Path.GetFullPath(savefile.FileName);
			var pathDir = Path.GetDirectoryName(savefile.FileName);
			
			MessageBox.Show("Export complete");
		}
		
		void showAboutBox(object sender, EventArgs e)
		{
			MessageBox.Show("Jobula Search Tool\r\nVersion: 2.5.3\r\nAuthor: neptuneDockyard", "About");
		}
		
		void applicationClose(object sender, EventArgs e)
		{
			System.Environment.Exit(1);
		}
		
		void newQuery(object sender, EventArgs e)
		{
			jobsiteCombo.SelectedIndex = 0;
			searchQueryText.Text = "";
			cityText.Text = "";
			countryCombo.SelectedIndex = 7;
			numericPostAge.Value = 30;
			numericSearchRadius.Value = 25;
			sitetypeBox.SelectedIndex = 1;
			jobtypeBox.SelectedIndex = 0;
			
			//switch to tab
			tabBox.SelectTab(searchsettingsTab);
		}
		
		void openQuery(object sender, EventArgs e)
		{
			var openfile = new OpenFileDialog();
			openfile.Title = "Open query file";
			openfile.Filter = "Text file (*.txt)|*.txt";
			if(openfile.ShowDialog() == DialogResult.OK) {
				var filename = openfile.FileName;
				string filecontent = File.ReadAllText(filename);
				string[] splitcontent = filecontent.Split(';');
				if(splitcontent.Length == 9) {
					if(splitcontent[8].Contains("neptune")) {
						jobsiteCombo.SelectedItem = splitcontent[0];
						searchQueryText.Text = splitcontent[1];
						cityText.Text = splitcontent[2];
						countryCombo.SelectedItem = splitcontent[3];
						numericPostAge.Value = Int32.Parse(splitcontent[4]);
						numericSearchRadius.Value = Int32.Parse(splitcontent[5]);
						sitetypeBox.SelectedItem = splitcontent[6];
						jobtypeBox.SelectedItem = splitcontent[7];
					} else {
						MessageBox.Show("Error: invalid query file");
					}
				} else {
					MessageBox.Show("Error: invalid query file");
				}
			}
			
			//switch to tab
			tabBox.SelectTab(searchsettingsTab);
		}
		
		void saveQuery(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(savefileRemember.FileName))
			{
				var savefile = new SaveFileDialog();
				savefile.FileName = searchQueryText.Text + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
				savefile.Filter = "Text file (*.txt)|*.txt";
				if(savefile.ShowDialog() == DialogResult.OK) {
					savefileRemember = savefile;
					using (var sw = new StreamWriter(savefile.FileName)) {
						sw.WriteLine(jobsiteCombo.SelectedItem+";"+searchQueryText.Text+";"+cityText.Text+";"+countryCombo.SelectedItem+";"+numericPostAge.Value.ToString()+";"+numericSearchRadius.Value.ToString()+";"+sitetypeBox.SelectedItem.ToString()+";"+jobtypeBox.SelectedItem.ToString()+";"+"neptune");
					}
				} else {
					return;
				}
			} 
			else 
			{
			    using (StreamWriter sw = File.AppendText(Path.GetFullPath(savefileRemember.FileName))) 
			    {
					sw.WriteLine(jobsiteCombo.SelectedItem+";"+searchQueryText.Text+";"+cityText.Text+";"+countryCombo.SelectedItem+";"+numericPostAge.Value.ToString()+";"+numericSearchRadius.Value.ToString()+";"+sitetypeBox.SelectedItem.ToString()+";"+jobtypeBox.SelectedItem.ToString()+";"+"neptune");
			    }
			}
		}
		
		void saveAsQuery(object sender, EventArgs e)
		{
			var savefile = new SaveFileDialog();
			var filename = searchQueryText.Text.Replace("\"",string.Empty);
			savefile.FileName = filename + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
			savefile.Filter = "Text file (*.txt)|*.txt";
			if(savefile.ShowDialog() == DialogResult.OK) {
				savefileRemember = savefile;
				using (var sw = new StreamWriter(savefile.FileName)) {
					sw.WriteLine(jobsiteCombo.SelectedItem+";"+searchQueryText.Text+";"+cityText.Text+";"+countryCombo.SelectedItem+";"+numericPostAge.Value.ToString()+";"+numericSearchRadius.Value.ToString()+";"+sitetypeBox.SelectedItem.ToString()+";"+jobtypeBox.SelectedItem.ToString()+";"+"neptune");
				}
			} else {
				return;
			}
			var path = Path.GetFullPath(savefile.FileName);
			var pathDir = Path.GetDirectoryName(savefile.FileName);
			
			MessageBox.Show("Saved");
		}
		
		void selectAllList(object sender, EventArgs e)
		{
			jobListBox.BeginUpdate();
			tabBox.SelectTab(joblistTab);
			jobListBox.Focus();
			
			foreach(ListViewItem item in jobListBox.Items) {
				item.Selected = true;
			}
			
			jobListBox.EndUpdate();
			jobListBox.Focus();
		}
		
		void copyallList(object sender, EventArgs e)
		{
			tabBox.SelectTab(joblistTab);
			jobListBox.Focus();
			
			var builder = new StringBuilder();
			builder.AppendLine("");
	        foreach (ListViewItem item in jobListBox.SelectedItems)
	            //builder.AppendLine(item.SubItems[0].Text.Replace(";",",")+";"+item.SubItems[1].Text.Replace(";",",")+";"+item.SubItems[2].Text.Replace(";",",")+";"+item.SubItems[3].Text.Replace(";",",")+";"+item.SubItems[4].Text.Replace(";",",")+";"+item.SubItems[5].Text.Replace(";",","));
	        	builder.AppendLine(item.SubItems[0].Text+","+item.SubItems[1].Text+","+item.SubItems[2].Text+","+item.SubItems[3].Text+","+item.SubItems[4].Text+","+"=HYPERLINK(\""+item.SubItems[5].Text+"\")");
	        Clipboard.SetText(builder.ToString());
		}
		
		void listviewColumnSort(object sender, ColumnClickEventArgs e)
		{
			if (e.Column != sorter.SortColumn)
	        {
	            // Set the sort column to the new column.
	            sorter.SortColumn = e.Column;
	            // Set the sort order to ascending by default.
	            sorter.Order = SortOrder.Ascending;
	        } else {
	            // Determine what the last sort order was and change it.
	            if (sorter.Order == SortOrder.Ascending)
	                sorter.Order = SortOrder.Descending;
	            else
	                sorter.Order = SortOrder.Ascending;
	        }
			
	        // Call the sort method to manually sort.
	        jobListBox.Sort();
		}
		
		void sendEnterKey(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter) {
				searchButton.PerformClick();
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}
		
		void howtouseHelp(object sender, EventArgs e)
		{
			MessageBox.Show("This tool allows you to easily search popular job portals.\r\n" +
			                "For the best search results, the following can be used:\r\n" +
			                "specific strings: ex. \"civil engineer\"\r\n" +
			                "inclusive strings: ex. +technician\r\n" +
			                "exclusive strings: ex. -manager\r\n\r\n" +
			                "To expand an ad, double click it to open in a browser.",
			               "How to use this tool.");
		}
	}
	
    // This class is an implementation of the 'IComparer' interface.
	public class ListViewItemComparer : IComparer
	{
	    // Specifies the column to be sorted
	    private int ColumnToSort;
	
	    // Specifies the order in which to sort (i.e. 'Ascending').
	    private SortOrder OrderOfSort;
	
	    // Case insensitive comparer object
	    private CaseInsensitiveComparer ObjectCompare;
	
	    // Class constructor, initializes various elements
	    public ListViewItemComparer()
	    {
	        // Initialize the column to '0'
	        ColumnToSort = 0;
	
	        // Initialize the sort order to 'none'
	        OrderOfSort = SortOrder.None;
	
	        // Initialize the CaseInsensitiveComparer object
	        ObjectCompare = new CaseInsensitiveComparer();
	    }
	
	    // This method is inherited from the IComparer interface.
	    // It compares the two objects passed using a case
	    // insensitive comparison.
	    //
	    // x: First object to be compared
	    // y: Second object to be compared
	    //
	    // The result of the comparison. "0" if equal,
	    // negative if 'x' is less than 'y' and
	    // positive if 'x' is greater than 'y'
	    public int Compare(object x, object y)
	    {
	        int compareResult;
	        ListViewItem listviewX, listviewY;
	        var time_words = new Regex("hour|stunden|Stunden|heur|時間|小时|小時|horas");
	        
	        // regex for removing characters from numeric compare
	        var rgx = new Regex("[^0-9]");
	
	        // Cast the objects to be compared to ListViewItem objects
	        listviewX = (ListViewItem)x;
	        listviewY = (ListViewItem)y;
	
	        // Case insensitive Compare
	        if(ColumnToSort != 3) {
		        compareResult = ObjectCompare.Compare (
		            listviewX.SubItems[ColumnToSort].Text,
		            listviewY.SubItems[ColumnToSort].Text
		        );
        	} else {
	        	if(time_words.IsMatch(listviewX.SubItems[ColumnToSort].Text) && !time_words.IsMatch(listviewY.SubItems[ColumnToSort].Text)) {
	        		compareResult = ObjectCompare.Compare (
	        			(float)(Int32.Parse(rgx.Replace(listviewX.SubItems[ColumnToSort].Text,""))/100),
	        			(float)Int32.Parse(rgx.Replace(listviewY.SubItems[ColumnToSort].Text,""))
			        );
	        	} else if(time_words.IsMatch(listviewY.SubItems[ColumnToSort].Text) && !time_words.IsMatch(listviewX.SubItems[ColumnToSort].Text)) {
	        		compareResult = ObjectCompare.Compare (
	        			(float)Int32.Parse(rgx.Replace(listviewX.SubItems[ColumnToSort].Text,"")),
	        			(float)(Int32.Parse(rgx.Replace(listviewY.SubItems[ColumnToSort].Text,""))/100)
			        );
	        	} else if(time_words.IsMatch(listviewX.SubItems[ColumnToSort].Text) && time_words.IsMatch(listviewY.SubItems[ColumnToSort].Text)) {
	        		compareResult = ObjectCompare.Compare (
	        			Int32.Parse(rgx.Replace(listviewX.SubItems[ColumnToSort].Text,"")),
	        			Int32.Parse(rgx.Replace(listviewY.SubItems[ColumnToSort].Text,""))
			        );
	        	} else {
		        	compareResult = ObjectCompare.Compare (
		        		Int32.Parse(rgx.Replace(listviewX.SubItems[ColumnToSort].Text,"")),
		        		Int32.Parse(rgx.Replace(listviewY.SubItems[ColumnToSort].Text,""))
			        );
	        	}
	        }
	
	        // Calculate correct return value based on object comparison
	        if (OrderOfSort == SortOrder.Ascending) {
	            // Ascending sort is selected, return normal result of compare operation
	            return compareResult;
	        } else if (OrderOfSort == SortOrder.Descending) {
	            // Descending sort is selected, return negative result of compare operation
	            return (-compareResult);
	        } else {
	            // Return '0' to indicate they are equal
	            return 0;
	        }
	    }
	    
	    // Gets or sets the number of the column to which to
	    // apply the sorting operation (Defaults to '0').
	    public int SortColumn
	    {
	        set {
	            ColumnToSort = value;
	        }
	        get {
	            return ColumnToSort;
	        }
	    }
	
	    // Gets or sets the order of sorting to apply
	    // (for example, 'Ascending' or 'Descending').
	    public SortOrder Order
	    {
	        set {
	            OrderOfSort = value;
	        }
	        get {
	            return OrderOfSort;
	        }
	    }
	}
}
