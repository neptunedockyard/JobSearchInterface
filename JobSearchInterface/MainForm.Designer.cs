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
		private System.Windows.Forms.CheckBox emailCheck;
		private System.Windows.Forms.NumericUpDown numericLimit;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label resultsLabel;
		private System.Windows.Forms.ColumnHeader urlList;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem instructionsStripMenuItem;
		private System.Windows.Forms.ToolTip toolTip1;
		
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
			this.components = new System.ComponentModel.Container();
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
			this.searchsettingsTab = new System.Windows.Forms.TabPage();
			this.resultsLabel = new System.Windows.Forms.Label();
			this.numericLimit = new System.Windows.Forms.NumericUpDown();
			this.debugCheck = new System.Windows.Forms.CheckBox();
			this.emailCheck = new System.Windows.Forms.CheckBox();
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
			this.joblistTab = new System.Windows.Forms.TabPage();
			this.jobListBox = new System.Windows.Forms.ListView();
			this.jobTitleList = new System.Windows.Forms.ColumnHeader();
			this.companyList = new System.Windows.Forms.ColumnHeader();
			this.cityList = new System.Windows.Forms.ColumnHeader();
			this.dateList = new System.Windows.Forms.ColumnHeader();
			this.descList = new System.Windows.Forms.ColumnHeader();
			this.urlList = new System.Windows.Forms.ColumnHeader();
			this.debugTab = new System.Windows.Forms.TabPage();
			this.debugText = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.instructionsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numericPostAge)).BeginInit();
			this.tabBox.SuspendLayout();
			this.searchsettingsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericLimit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSearchRadius)).BeginInit();
			this.joblistTab.SuspendLayout();
			this.debugTab.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(7, 247);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 11;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
			this.searchButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendEnterKey);
			// 
			// searchQueryText
			// 
			this.searchQueryText.Location = new System.Drawing.Point(7, 29);
			this.searchQueryText.Name = "searchQueryText";
			this.searchQueryText.Size = new System.Drawing.Size(99, 20);
			this.searchQueryText.TabIndex = 0;
			this.toolTip1.SetToolTip(this.searchQueryText, "ex. physiotherapist");
			this.searchQueryText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendEnterKey);
			// 
			// searchProgress
			// 
			this.searchProgress.Location = new System.Drawing.Point(194, 247);
			this.searchProgress.Name = "searchProgress";
			this.searchProgress.Size = new System.Drawing.Size(302, 23);
			this.searchProgress.TabIndex = 2;
			// 
			// numericPostAge
			// 
			this.numericPostAge.Location = new System.Drawing.Point(266, 84);
			this.numericPostAge.Maximum = new decimal(new int[] {
			30,
			0,
			0,
			0});
			this.numericPostAge.Name = "numericPostAge";
			this.numericPostAge.Size = new System.Drawing.Size(100, 20);
			this.numericPostAge.TabIndex = 6;
			this.toolTip1.SetToolTip(this.numericPostAge, "how long ago the ad was posted");
			this.numericPostAge.Value = new decimal(new int[] {
			30,
			0,
			0,
			0});
			this.numericPostAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendEnterKey);
			// 
			// jobsiteCombo
			// 
			this.jobsiteCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.jobsiteCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.jobsiteCombo.FormattingEnabled = true;
			this.jobsiteCombo.Items.AddRange(new object[] {
			"Indeed"});
			this.jobsiteCombo.Location = new System.Drawing.Point(135, 29);
			this.jobsiteCombo.Name = "jobsiteCombo";
			this.jobsiteCombo.Size = new System.Drawing.Size(100, 21);
			this.jobsiteCombo.TabIndex = 1;
			this.toolTip1.SetToolTip(this.jobsiteCombo, "which job search resource?");
			this.jobsiteCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendEnterKey);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Search";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(266, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Ad age (days)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(135, 3);
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
			this.tabBox.Controls.Add(this.searchsettingsTab);
			this.tabBox.Controls.Add(this.joblistTab);
			this.tabBox.Controls.Add(this.debugTab);
			this.tabBox.Location = new System.Drawing.Point(12, 27);
			this.tabBox.Name = "tabBox";
			this.tabBox.SelectedIndex = 0;
			this.tabBox.Size = new System.Drawing.Size(693, 302);
			this.tabBox.TabIndex = 0;
			// 
			// searchsettingsTab
			// 
			this.searchsettingsTab.Controls.Add(this.resultsLabel);
			this.searchsettingsTab.Controls.Add(this.searchProgress);
			this.searchsettingsTab.Controls.Add(this.numericLimit);
			this.searchsettingsTab.Controls.Add(this.debugCheck);
			this.searchsettingsTab.Controls.Add(this.emailCheck);
			this.searchsettingsTab.Controls.Add(this.searchButton);
			this.searchsettingsTab.Controls.Add(this.label9);
			this.searchsettingsTab.Controls.Add(this.jobtypeBox);
			this.searchsettingsTab.Controls.Add(this.label8);
			this.searchsettingsTab.Controls.Add(this.jobsiteCombo);
			this.searchsettingsTab.Controls.Add(this.label3);
			this.searchsettingsTab.Controls.Add(this.sitetypeBox);
			this.searchsettingsTab.Controls.Add(this.label1);
			this.searchsettingsTab.Controls.Add(this.label7);
			this.searchsettingsTab.Controls.Add(this.countryCombo);
			this.searchsettingsTab.Controls.Add(this.label6);
			this.searchsettingsTab.Controls.Add(this.searchQueryText);
			this.searchsettingsTab.Controls.Add(this.numericSearchRadius);
			this.searchsettingsTab.Controls.Add(this.label5);
			this.searchsettingsTab.Controls.Add(this.cityText);
			this.searchsettingsTab.Controls.Add(this.label4);
			this.searchsettingsTab.Controls.Add(this.numericPostAge);
			this.searchsettingsTab.Controls.Add(this.label2);
			this.searchsettingsTab.Location = new System.Drawing.Point(4, 22);
			this.searchsettingsTab.Name = "searchsettingsTab";
			this.searchsettingsTab.Padding = new System.Windows.Forms.Padding(3);
			this.searchsettingsTab.Size = new System.Drawing.Size(685, 276);
			this.searchsettingsTab.TabIndex = 2;
			this.searchsettingsTab.Text = "Search Settings";
			this.searchsettingsTab.UseVisualStyleBackColor = true;
			// 
			// resultsLabel
			// 
			this.resultsLabel.Location = new System.Drawing.Point(88, 247);
			this.resultsLabel.Name = "resultsLabel";
			this.resultsLabel.Size = new System.Drawing.Size(100, 23);
			this.resultsLabel.TabIndex = 11;
			this.resultsLabel.Text = "Results: ";
			this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericLimit
			// 
			this.numericLimit.Increment = new decimal(new int[] {
			25,
			0,
			0,
			0});
			this.numericLimit.Location = new System.Drawing.Point(7, 138);
			this.numericLimit.Maximum = new decimal(new int[] {
			500,
			0,
			0,
			0});
			this.numericLimit.Name = "numericLimit";
			this.numericLimit.Size = new System.Drawing.Size(100, 20);
			this.numericLimit.TabIndex = 8;
			this.toolTip1.SetToolTip(this.numericLimit, "the number of ads shown");
			this.numericLimit.Value = new decimal(new int[] {
			100,
			0,
			0,
			0});
			this.numericLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendEnterKey);
			// 
			// debugCheck
			// 
			this.debugCheck.Location = new System.Drawing.Point(7, 194);
			this.debugCheck.Name = "debugCheck";
			this.debugCheck.Size = new System.Drawing.Size(104, 24);
			this.debugCheck.TabIndex = 10;
			this.debugCheck.Text = "Debug?";
			this.debugCheck.UseVisualStyleBackColor = true;
			this.debugCheck.CheckedChanged += new System.EventHandler(this.DebugCheckCheckedChanged);
			// 
			// emailCheck
			// 
			this.emailCheck.Location = new System.Drawing.Point(7, 164);
			this.emailCheck.Name = "emailCheck";
			this.emailCheck.Size = new System.Drawing.Size(104, 24);
			this.emailCheck.TabIndex = 9;
			this.emailCheck.Text = "check for email";
			this.toolTip1.SetToolTip(this.emailCheck, "scan postings for an email address for direct contact?");
			this.emailCheck.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(7, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 17;
			this.label9.Text = "Ad Limit";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// jobtypeBox
			// 
			this.jobtypeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.jobtypeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.jobtypeBox.FormattingEnabled = true;
			this.jobtypeBox.Items.AddRange(new object[] {
			"fulltime",
			"parttime",
			"contract",
			"internship",
			"temporary"});
			this.jobtypeBox.Location = new System.Drawing.Point(135, 84);
			this.jobtypeBox.Name = "jobtypeBox";
			this.jobtypeBox.Size = new System.Drawing.Size(100, 21);
			this.jobtypeBox.TabIndex = 5;
			this.toolTip1.SetToolTip(this.jobtypeBox, "fulltime, part time, contract, temporary, internship");
			this.jobtypeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendEnterKey);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(135, 58);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "Job type";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// sitetypeBox
			// 
			this.sitetypeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.sitetypeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.sitetypeBox.FormattingEnabled = true;
			this.sitetypeBox.Items.AddRange(new object[] {
			"jobsite",
			"employer"});
			this.sitetypeBox.Location = new System.Drawing.Point(7, 84);
			this.sitetypeBox.Name = "sitetypeBox";
			this.sitetypeBox.Size = new System.Drawing.Size(99, 21);
			this.sitetypeBox.TabIndex = 4;
			this.toolTip1.SetToolTip(this.sitetypeBox, "jobsite for job boards, employer for direct employers");
			this.sitetypeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendEnterKey);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 58);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Search by";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// countryCombo
			// 
			this.countryCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.countryCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
			this.countryCombo.Location = new System.Drawing.Point(396, 28);
			this.countryCombo.Name = "countryCombo";
			this.countryCombo.Size = new System.Drawing.Size(100, 21);
			this.countryCombo.TabIndex = 3;
			this.countryCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendEnterKey);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(396, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Country";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// numericSearchRadius
			// 
			this.numericSearchRadius.Location = new System.Drawing.Point(396, 84);
			this.numericSearchRadius.Maximum = new decimal(new int[] {
			250,
			0,
			0,
			0});
			this.numericSearchRadius.Minimum = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.numericSearchRadius.Name = "numericSearchRadius";
			this.numericSearchRadius.Size = new System.Drawing.Size(100, 20);
			this.numericSearchRadius.TabIndex = 7;
			this.toolTip1.SetToolTip(this.numericSearchRadius, "distance from your chosen location");
			this.numericSearchRadius.Value = new decimal(new int[] {
			25,
			0,
			0,
			0});
			this.numericSearchRadius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendEnterKey);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(396, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Radius (km)";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// cityText
			// 
			this.cityText.Location = new System.Drawing.Point(266, 29);
			this.cityText.Name = "cityText";
			this.cityText.Size = new System.Drawing.Size(100, 20);
			this.cityText.TabIndex = 2;
			this.cityText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendEnterKey);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(266, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "City";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// joblistTab
			// 
			this.joblistTab.Controls.Add(this.jobListBox);
			this.joblistTab.Location = new System.Drawing.Point(4, 22);
			this.joblistTab.Name = "joblistTab";
			this.joblistTab.Padding = new System.Windows.Forms.Padding(3);
			this.joblistTab.Size = new System.Drawing.Size(685, 276);
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
			this.jobListBox.ShowItemToolTips = true;
			this.jobListBox.Size = new System.Drawing.Size(672, 263);
			this.jobListBox.TabIndex = 0;
			this.jobListBox.UseCompatibleStateImageBehavior = false;
			this.jobListBox.View = System.Windows.Forms.View.Details;
			this.jobListBox.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listviewColumnSort);
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
			this.dateList.Text = "Ad age";
			// 
			// descList
			// 
			this.descList.Text = "Summary";
			this.descList.Width = 800;
			// 
			// urlList
			// 
			this.urlList.Text = "URL";
			this.urlList.Width = 50;
			// 
			// debugTab
			// 
			this.debugTab.Controls.Add(this.debugText);
			this.debugTab.Location = new System.Drawing.Point(4, 22);
			this.debugTab.Name = "debugTab";
			this.debugTab.Padding = new System.Windows.Forms.Padding(3);
			this.debugTab.Size = new System.Drawing.Size(685, 276);
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
			this.debugText.Size = new System.Drawing.Size(673, 264);
			this.debugText.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.editToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(12, 4);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(128, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newToolStripMenuItem,
			this.openToolStripMenuItem,
			this.toolStripSeparator,
			this.saveToolStripMenuItem,
			this.saveAsToolStripMenuItem,
			this.exportToolStripMenuItem,
			this.toolStripSeparator1,
			this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.newToolStripMenuItem.Text = "&New Search";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newQuery);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.openToolStripMenuItem.Text = "&Open Search";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openQuery);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(181, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Enabled = false;
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.saveToolStripMenuItem.Text = "&Save Search";
			this.saveToolStripMenuItem.Visible = false;
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveQuery);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.saveAsToolStripMenuItem.Text = "Save Search &As";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsQuery);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.exportToolStripMenuItem.Text = "Export as CSV";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToCSV);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.applicationClose);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.copyToolStripMenuItem,
			this.selectAllToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
			this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.copyToolStripMenuItem.Text = "&Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyallList);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.selectAllToolStripMenuItem.Text = "Select &All";
			this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllList);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.instructionsStripMenuItem,
			this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// instructionsStripMenuItem
			// 
			this.instructionsStripMenuItem.Name = "instructionsStripMenuItem";
			this.instructionsStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.instructionsStripMenuItem.Text = "How to use";
			this.instructionsStripMenuItem.Click += new System.EventHandler(this.howtouseHelp);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.showAboutBox);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 341);
			this.Controls.Add(this.tabBox);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(733, 380);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Jobula - Job Search Tool";
			((System.ComponentModel.ISupportInitialize)(this.numericPostAge)).EndInit();
			this.tabBox.ResumeLayout(false);
			this.searchsettingsTab.ResumeLayout(false);
			this.searchsettingsTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericLimit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSearchRadius)).EndInit();
			this.joblistTab.ResumeLayout(false);
			this.debugTab.ResumeLayout(false);
			this.debugTab.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
