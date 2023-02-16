namespace PCManager
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCategory = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuManufacturer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuComputer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuStaff = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuBill = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSearchBill = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSearchComputer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSearchCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuGetStarted = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuCategory,
            this.billToolStripMenuItem,
            this.mnuSearch,
            this.mnuHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(794, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(37, 20);
			this.mnuFile.Text = "File";
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(180, 22);
			this.mnuExit.Text = "Exit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuCategory
			// 
			this.mnuCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManufacturer,
            this.mnuComputer,
            this.mnuStaff,
            this.mnuCustomer});
			this.mnuCategory.Name = "mnuCategory";
			this.mnuCategory.Size = new System.Drawing.Size(67, 20);
			this.mnuCategory.Text = "Category";
			// 
			// mnuManufacturer
			// 
			this.mnuManufacturer.Name = "mnuManufacturer";
			this.mnuManufacturer.Size = new System.Drawing.Size(180, 22);
			this.mnuManufacturer.Text = "Manufacturer";
			this.mnuManufacturer.Click += new System.EventHandler(this.mnuManufacturer_Click);
			// 
			// mnuComputer
			// 
			this.mnuComputer.Name = "mnuComputer";
			this.mnuComputer.Size = new System.Drawing.Size(180, 22);
			this.mnuComputer.Text = "Computer";
			this.mnuComputer.Click += new System.EventHandler(this.mnuComputer_Click);
			// 
			// mnuStaff
			// 
			this.mnuStaff.Name = "mnuStaff";
			this.mnuStaff.Size = new System.Drawing.Size(180, 22);
			this.mnuStaff.Text = "Staff";
			this.mnuStaff.Click += new System.EventHandler(this.mnuStaff_Click);
			// 
			// mnuCustomer
			// 
			this.mnuCustomer.Name = "mnuCustomer";
			this.mnuCustomer.Size = new System.Drawing.Size(180, 22);
			this.mnuCustomer.Text = "Customer";
			this.mnuCustomer.Click += new System.EventHandler(this.mnuCustomer_Click);
			// 
			// billToolStripMenuItem
			// 
			this.billToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBill});
			this.billToolStripMenuItem.Name = "billToolStripMenuItem";
			this.billToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.billToolStripMenuItem.Text = "Bill";
			// 
			// mnuBill
			// 
			this.mnuBill.Name = "mnuBill";
			this.mnuBill.Size = new System.Drawing.Size(180, 22);
			this.mnuBill.Text = "Bill";
			this.mnuBill.Click += new System.EventHandler(this.mnuBill_Click);
			// 
			// mnuSearch
			// 
			this.mnuSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchBill,
            this.mnuSearchComputer,
            this.mnuSearchCustomer});
			this.mnuSearch.Name = "mnuSearch";
			this.mnuSearch.Size = new System.Drawing.Size(54, 20);
			this.mnuSearch.Text = "Search";
			// 
			// mnuSearchBill
			// 
			this.mnuSearchBill.Name = "mnuSearchBill";
			this.mnuSearchBill.Size = new System.Drawing.Size(128, 22);
			this.mnuSearchBill.Text = "Bill";
			// 
			// mnuSearchComputer
			// 
			this.mnuSearchComputer.Name = "mnuSearchComputer";
			this.mnuSearchComputer.Size = new System.Drawing.Size(128, 22);
			this.mnuSearchComputer.Text = "Computer";
			// 
			// mnuSearchCustomer
			// 
			this.mnuSearchCustomer.Name = "mnuSearchCustomer";
			this.mnuSearchCustomer.Size = new System.Drawing.Size(128, 22);
			this.mnuSearchCustomer.Text = "Customer";
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuGetStarted});
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(44, 20);
			this.mnuHelp.Text = "Help";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(132, 22);
			this.mnuAbout.Text = "About";
			// 
			// mnuGetStarted
			// 
			this.mnuGetStarted.Name = "mnuGetStarted";
			this.mnuGetStarted.Size = new System.Drawing.Size(132, 22);
			this.mnuGetStarted.Text = "Get Started";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 451);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PC Manager";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem mnuCategory;
		private System.Windows.Forms.ToolStripMenuItem mnuManufacturer;
		private System.Windows.Forms.ToolStripMenuItem mnuComputer;
		private System.Windows.Forms.ToolStripMenuItem mnuStaff;
		private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
		private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuBill;
		private System.Windows.Forms.ToolStripMenuItem mnuSearch;
		private System.Windows.Forms.ToolStripMenuItem mnuSearchBill;
		private System.Windows.Forms.ToolStripMenuItem mnuSearchComputer;
		private System.Windows.Forms.ToolStripMenuItem mnuSearchCustomer;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripMenuItem mnuGetStarted;
	}
}

