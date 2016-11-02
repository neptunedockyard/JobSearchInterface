/*
 * Created by SharpDevelop.
 * User: Michal
 * Date: 11/1/2016
 * Time: 3:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Indeed.Models;
using Indeed;

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
		
		public MainForm()
		{
//			qParameters = new IndeedQueryParameters();
//			indeedResponse = new List<IndeedSearchResult>();
			InitializeComponent();
		}
		
		public IndeedQueryParameters collectParams() {
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
			pams.Start = "0";
			pams.Limit = "10";
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
			
			if(countryCombo.SelectedIndex < 0) {
				MessageBox.Show("Please choose all options");
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
			
			searchProgress.Value = 0;
			jobListBox.Items.Clear();
			if(!debugCheck.Checked)
				debugText.Clear();
			
			qParameters = collectParams();
			
			try {
				indeedResponse = IndeedSearch.GetSearchResults(qParameters, apiPublisherKey);
//				MessageBox.Show("running");
				int current = 0;
				
				foreach(var item in indeedResponse) {
					string[] row = {item.JobTitle, item.Company, item.FormattedLocationFull, item.FormattedRelativeTime, item.Snippet, item.URL};
					var listViewItem = new ListViewItem(row);
					jobListBox.Items.Add(listViewItem);
					current++;
					searchProgress.Value = current / indeedResponse.Count * 100;
				}
//				MessageBox.Show(indeedResponse.Count.ToString());
			} catch (Exception ex) {
				MessageBox.Show("error: " + ex.Message);
			}
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
//			MessageBox.Show("Clicked: " + jobListBox.SelectedItems[0].Text + " url: " + jobListBox.Items[0].SubItems[5].Text);
			System.Diagnostics.Process.Start(jobListBox.Items[0].SubItems[5].Text);
		}
	}
}
