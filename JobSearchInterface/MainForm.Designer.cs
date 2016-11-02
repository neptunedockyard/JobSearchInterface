/*
 * Created by SharpDevelop.
 * User: Michal
 * Date: 11/1/2016
 * Time: 3:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace JobSearchInterface
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox searchQueryText;
		private System.Windows.Forms.ProgressBar searchProgress;
		private System.Windows.Forms.NumericUpDown numericPostAge;
		private System.Windows.Forms.ComboBox jobsiteCombo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabControl tabBox;
		private System.Windows.Forms.TabPage joblistTab;
		private System.Windows.Forms.TabPage debugTab;
		private System.Windows.Forms.ListView jobListBox;
		private System.Windows.Forms.TextBox debugText;
		private System.Windows.Forms.CheckBox debugCheck;
		private System.Windows.Forms.TabPage searchsettingsTab;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericSearchRadius;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox cityText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox countryCombo;
		private System.Windows.Forms.ComboBox sitetypeBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox jobtypeBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ColumnHeader jobTitleList;
		private System.Windows.Forms.ColumnHeader companyList;
		private System.Windows.Forms.ColumnHeader cityList;
		private System.Windows.Forms.ColumnHeader dateList;
		private System.Windows.Forms.ColumnHeader descList;
		private System.Windows.Forms.ColumnHeader urlList;
		private System.Windows.Forms.CheckBox emailCheck;
		private System.Windows.Forms.NumericUpDown numericLimit;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label resultsLabel;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.searchButton = new System.Windows.Forms.Button();
			this.searchQueryText = new System.Windows.Forms.TextBox();
			this.searchProgress = new System.Windows.Forms.ProgressBar();
			this.numericPostAge = new System.Windows.Forms.NumericUpDown();
			this.jobsiteCombo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tabBox = new System.Windows.Forms.TabControl();
			this.joblistTab = new System.Windows.Forms.TabPage();
			this.jobListBox = new System.Windows.Forms.ListView();
			this.jobTitleList = new System.Windows.Forms.ColumnHeader();
			this.companyList = new System.Windows.Forms.ColumnHeader();
			this.cityList = new System.Windows.Forms.ColumnHeader();
			this.dateList = new System.Windows.Forms.ColumnHeader();
			this.descList = new System.Windows.Forms.ColumnHeader();
			this.urlList = new System.Windows.Forms.ColumnHeader();
			this.searchsettingsTab = new System.Windows.Forms.TabPage();
			this.numericLimit = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.jobtypeBox = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.sitetypeBox = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.countryCombo = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.numericSearchRadius = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.cityText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.debugTab = new System.Windows.Forms.TabPage();
			this.debugText = new System.Windows.Forms.TextBox();
			this.debugCheck = new System.Windows.Forms.CheckBox();
			this.emailCheck = new System.Windows.Forms.CheckBox();
			this.resultsLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericPostAge)).BeginInit();
			this.tabBox.SuspendLayout();
			this.joblistTab.SuspendLayout();
			this.searchsettingsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericLimit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSearchRadius)).BeginInit();
			this.debugTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(13, 13);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 0;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
			// 
			// searchQueryText
			// 
			this.searchQueryText.Location = new System.Drawing.Point(12, 69);
			this.searchQueryText.Name = "searchQueryText";
			this.searchQueryText.Size = new System.Drawing.Size(120, 20);
			this.searchQueryText.TabIndex = 1;
			// 
			// searchProgress
			// 
			this.searchProgress.Location = new System.Drawing.Point(13, 306);
			this.searchProgress.Name = "searchProgress";
			this.searchProgress.Size = new System.Drawing.Size(100, 23);
			this.searchProgress.TabIndex = 2;
			// 
			// numericPostAge
			// 
			this.numericPostAge.Location = new System.Drawing.Point(6, 29);
			this.numericPostAge.Maximum = new decimal(new int[] {
			60,
			0,
			0,
			0});
			this.numericPostAge.Name = "numericPostAge";
			this.numericPostAge.Size = new System.Drawing.Size(120, 20);
			this.numericPostAge.TabIndex = 3;
			this.numericPostAge.Value = new decimal(new int[] {
			30,
			0,
			0,
			0});
			// 
			// jobsiteCombo
			// 
			this.jobsiteCombo.FormattingEnabled = true;
			this.jobsiteCombo.Items.AddRange(new object[] {
			"Indeed",
			"Monster",
			"SimplyHired",
			"Workopolis"});
			this.jobsiteCombo.Location = new System.Drawing.Point(11, 118);
			this.jobsiteCombo.Name = "jobsiteCombo";
			this.jobsiteCombo.Size = new System.Drawing.Size(121, 21);
			this.jobsiteCombo.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Search Term";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Days old";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Job site";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// tabBox
			// 
			this.tabBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tabBox.Controls.Add(this.joblistTab);
			this.tabBox.Controls.Add(this.searchsettingsTab);
			this.tabBox.Controls.Add(this.debugTab);
			this.tabBox.Location = new System.Drawing.Point(138, 12);
			this.tabBox.Name = "tabBox";
			this.tabBox.SelectedIndex = 0;
			this.tabBox.Size = new System.Drawing.Size(567, 317);
			this.tabBox.TabIndex = 1;
			// 
			// joblistTab
			// 
			this.joblistTab.Controls.Add(this.jobListBox);
			this.joblistTab.Location = new System.Drawing.Point(4, 22);
			this.joblistTab.Name = "joblistTab";
			this.joblistTab.Padding = new System.Windows.Forms.Padding(3);
			this.joblistTab.Size = new System.Drawing.Size(559, 291);
			this.joblistTab.TabIndex = 0;
			this.joblistTab.Text = "JobList";
			this.joblistTab.UseVisualStyleBackColor = true;
			// 
			// jobListBox
			// 
			this.jobListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.jobListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.jobTitleList,
			this.companyList,
			this.cityList,
			this.dateList,
			this.descList,
			this.urlList});
			this.jobListBox.FullRowSelect = true;
			this.jobListBox.GridLines = true;
			this.jobListBox.Location = new System.Drawing.Point(7, 7);
			this.jobListBox.Name = "jobListBox";
			this.jobListBox.Size = new System.Drawing.Size(546, 278);
			this.jobListBox.TabIndex = 0;
			this.jobListBox.UseCompatibleStateImageBehavior = false;
			this.jobListBox.View = System.Windows.Forms.View.Details;
			this.jobListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.JobListBoxMouseDoubleClick);
			// 
			// jobTitleList
			// 
			this.jobTitleList.Text = "Title";
			this.jobTitleList.Width = 145;
			// 
			// companyList
			// 
			this.companyList.Text = "Company";
			this.companyList.Width = 75;
			// 
			// cityList
			// 
			this.cityList.Text = "City";
			this.cityList.Width = 75;
			// 
			// dateList
			// 
			this.dateList.Text = "Date";
			// 
			// descList
			// 
			this.descList.Text = "Snippet";
			this.descList.Width = 250;
			// 
			// urlList
			// 
			this.urlList.Text = "URL";
			this.urlList.Width = 250;
			// 
			// searchsettingsTab
			// 
			this.searchsettingsTab.Controls.Add(this.numericLimit);
			this.searchsettingsTab.Controls.Add(this.label9);
			this.searchsettingsTab.Controls.Add(this.jobtypeBox);
			this.searchsettingsTab.Controls.Add(this.label8);
			this.searchsettingsTab.Controls.Add(this.sitetypeBox);
			this.searchsettingsTab.Controls.Add(this.label7);
			this.searchsettingsTab.Controls.Add(this.countryCombo);
			this.searchsettingsTab.Controls.Add(this.label6);
			this.searchsettingsTab.Controls.Add(this.numericSearchRadius);
			this.searchsettingsTab.Controls.Add(this.label5);
			this.searchsettingsTab.Controls.Add(this.cityText);
			this.searchsettingsTab.Controls.Add(this.label4);
			this.searchsettingsTab.Controls.Add(this.numericPostAge);
			this.searchsettingsTab.Controls.Add(this.label2);
			this.searchsettingsTab.Location = new System.Drawing.Point(4, 22);
			this.searchsettingsTab.Name = "searchsettingsTab";
			this.searchsettingsTab.Padding = new System.Windows.Forms.Padding(3);
			this.searchsettingsTab.Size = new System.Drawing.Size(559, 291);
			this.searchsettingsTab.TabIndex = 2;
			this.searchsettingsTab.Text = "Search Settings";
			this.searchsettingsTab.UseVisualStyleBackColor = true;
			// 
			// numericLimit
			// 
			this.numericLimit.Increment = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.numericLimit.Location = new System.Drawing.Point(7, 192);
			this.numericLimit.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.numericLimit.Name = "numericLimit";
			this.numericLimit.Size = new System.Drawing.Size(120, 20);
			this.numericLimit.TabIndex = 18;
			this.numericLimit.Value = new decimal(new int[] {
			100,
			0,
			0,
			0});
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(7, 165);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 17;
			this.label9.Text = "Limit";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// jobtypeBox
			// 
			this.jobtypeBox.FormattingEnabled = true;
			this.jobtypeBox.Items.AddRange(new object[] {
			"fulltime",
			"parttime",
			"contract",
			"internship",
			"temporary"});
			this.jobtypeBox.Location = new System.Drawing.Point(135, 137);
			this.jobtypeBox.Name = "jobtypeBox";
			this.jobtypeBox.Size = new System.Drawing.Size(121, 21);
			this.jobtypeBox.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(135, 109);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "Job type";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// sitetypeBox
			// 
			this.sitetypeBox.FormattingEnabled = true;
			this.sitetypeBox.Items.AddRange(new object[] {
			"jobsite",
			"employer"});
			this.sitetypeBox.Location = new System.Drawing.Point(7, 137);
			this.sitetypeBox.Name = "sitetypeBox";
			this.sitetypeBox.Size = new System.Drawing.Size(121, 21);
			this.sitetypeBox.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(7, 110);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Site type";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// countryCombo
			// 
			this.countryCombo.FormattingEnabled = true;
			this.countryCombo.Items.AddRange(new object[] {
			"Antarctica",
			"Argentina",
			"Australia",
			"Austria",
			"Bahrain",
			"Belgium",
			"Brazil",
			"Canada",
			"Chile",
			"China",
			"Colombia",
			"Costa Rica",
			"Czech Republic",
			"Denmark",
			"Ecuador",
			"Egypt",
			"Finland",
			"France",
			"Germany",
			"Greece",
			"Hong Kong",
			"Hungary",
			"India",
			"Indonesia",
			"Ireland",
			"Israel",
			"Italy",
			"Japan",
			"Kuwait",
			"Luxembourg",
			"Malaysia",
			"Mexico",
			"Morocco",
			"Netherlands",
			"New Zealand",
			"Nigeria",
			"Norway",
			"Oman",
			"Pakistan",
			"Panama",
			"Peru",
			"Philippines",
			"Poland",
			"Portugal",
			"Qatar",
			"Romania",
			"Russia",
			"Saudi Arabia",
			"Singapore",
			"South Africa",
			"South Korea",
			"Spain",
			"Sweden",
			"Switzerland",
			"Taiwan",
			"Thailand",
			"Turkey",
			"Ukraine",
			"United Arab Emirates",
			"United Kingdom",
			"United States",
			"Uruguay",
			"Venezuela",
			"Vietnam"});
			this.countryCombo.Location = new System.Drawing.Point(135, 83);
			this.countryCombo.Name = "countryCombo";
			this.countryCombo.Size = new System.Drawing.Size(121, 21);
			this.countryCombo.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(135, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Country";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// numericSearchRadius
			// 
			this.numericSearchRadius.Location = new System.Drawing.Point(135, 29);
			this.numericSearchRadius.Maximum = new decimal(new int[] {
			125,
			0,
			0,
			0});
			this.numericSearchRadius.Minimum = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.numericSearchRadius.Name = "numericSearchRadius";
			this.numericSearchRadius.Size = new System.Drawing.Size(120, 20);
			this.numericSearchRadius.TabIndex = 10;
			this.numericSearchRadius.Value = new decimal(new int[] {
			25,
			0,
			0,
			0});
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(135, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Radius";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// cityText
			// 
			this.cityText.Location = new System.Drawing.Point(7, 83);
			this.cityText.Name = "cityText";
			this.cityText.Size = new System.Drawing.Size(119, 20);
			this.cityText.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "City";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// debugTab
			// 
			this.debugTab.Controls.Add(this.debugText);
			this.debugTab.Location = new System.Drawing.Point(4, 22);
			this.debugTab.Name = "debugTab";
			this.debugTab.Padding = new System.Windows.Forms.Padding(3);
			this.debugTab.Size = new System.Drawing.Size(559, 291);
			this.debugTab.TabIndex = 1;
			this.debugTab.Text = "Debug";
			this.debugTab.UseVisualStyleBackColor = true;
			// 
			// debugText
			// 
			this.debugText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.debugText.Location = new System.Drawing.Point(6, 6);
			this.debugText.Multiline = true;
			this.debugText.Name = "debugText";
			this.debugText.Size = new System.Drawing.Size(547, 279);
			this.debugText.TabIndex = 0;
			// 
			// debugCheck
			// 
			this.debugCheck.Location = new System.Drawing.Point(13, 276);
			this.debugCheck.Name = "debugCheck";
			this.debugCheck.Size = new System.Drawing.Size(104, 24);
			this.debugCheck.TabIndex = 9;
			this.debugCheck.Text = "Debug?";
			this.debugCheck.UseVisualStyleBackColor = true;
			this.debugCheck.CheckedChanged += new System.EventHandler(this.DebugCheckCheckedChanged);
			// 
			// emailCheck
			// 
			this.emailCheck.Location = new System.Drawing.Point(13, 257);
			this.emailCheck.Name = "emailCheck";
			this.emailCheck.Size = new System.Drawing.Size(104, 24);
			this.emailCheck.TabIndex = 10;
			this.emailCheck.Text = "check for email";
			this.emailCheck.UseVisualStyleBackColor = true;
			// 
			// resultsLabel
			// 
			this.resultsLabel.Location = new System.Drawing.Point(11, 146);
			this.resultsLabel.Name = "resultsLabel";
			this.resultsLabel.Size = new System.Drawing.Size(100, 23);
			this.resultsLabel.TabIndex = 11;
			this.resultsLabel.Text = "Results";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 341);
			this.Controls.Add(this.resultsLabel);
			this.Controls.Add(this.emailCheck);
			this.Controls.Add(this.debugCheck);
			this.Controls.Add(this.tabBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.jobsiteCombo);
			this.Controls.Add(this.searchProgress);
			this.Controls.Add(this.searchQueryText);
			this.Controls.Add(this.searchButton);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(733, 380);
			this.Name = "MainForm";
			this.Text = "JobSearchInterface";
			((System.ComponentModel.ISupportInitialize)(this.numericPostAge)).EndInit();
			this.tabBox.ResumeLayout(false);
			this.joblistTab.ResumeLayout(false);
			this.searchsettingsTab.ResumeLayout(false);
			this.searchsettingsTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericLimit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSearchRadius)).EndInit();
			this.debugTab.ResumeLayout(false);
			this.debugTab.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
