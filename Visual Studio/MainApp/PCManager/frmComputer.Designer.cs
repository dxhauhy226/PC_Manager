namespace PCManager
{
	partial class frmComputer
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtComuterID = new System.Windows.Forms.TextBox();
			this.txtComputerName = new System.Windows.Forms.TextBox();
			this.cboManufacturer = new System.Windows.Forms.ComboBox();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.txtPriceIn = new System.Windows.Forms.TextBox();
			this.txtPriceOut = new System.Windows.Forms.TextBox();
			this.txtPicture = new System.Windows.Forms.TextBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.rtbDetail = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSkip = new System.Windows.Forms.Button();
			this.btnShow = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rtbDetail);
			this.groupBox1.Controls.Add(this.btnOpen);
			this.groupBox1.Controls.Add(this.txtPicture);
			this.groupBox1.Controls.Add(this.txtPriceOut);
			this.groupBox1.Controls.Add(this.txtPriceIn);
			this.groupBox1.Controls.Add(this.txtCount);
			this.groupBox1.Controls.Add(this.cboManufacturer);
			this.groupBox1.Controls.Add(this.txtComputerName);
			this.groupBox1.Controls.Add(this.txtComuterID);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(635, 190);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Computer Information";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Comuter ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Comuter Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Count";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Price In";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Manufacturer";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(17, 157);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Price Out";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(303, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Picture";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(303, 52);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(34, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Detail";
			// 
			// txtComuterID
			// 
			this.txtComuterID.Location = new System.Drawing.Point(107, 23);
			this.txtComuterID.Name = "txtComuterID";
			this.txtComuterID.Size = new System.Drawing.Size(150, 20);
			this.txtComuterID.TabIndex = 8;
			// 
			// txtComputerName
			// 
			this.txtComputerName.Location = new System.Drawing.Point(107, 49);
			this.txtComputerName.Name = "txtComputerName";
			this.txtComputerName.Size = new System.Drawing.Size(150, 20);
			this.txtComputerName.TabIndex = 9;
			// 
			// cboManufacturer
			// 
			this.cboManufacturer.FormattingEnabled = true;
			this.cboManufacturer.Location = new System.Drawing.Point(107, 75);
			this.cboManufacturer.Name = "cboManufacturer";
			this.cboManufacturer.Size = new System.Drawing.Size(150, 21);
			this.cboManufacturer.TabIndex = 10;
			// 
			// txtCount
			// 
			this.txtCount.Location = new System.Drawing.Point(107, 102);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(150, 20);
			this.txtCount.TabIndex = 11;
			// 
			// txtPriceIn
			// 
			this.txtPriceIn.Location = new System.Drawing.Point(107, 128);
			this.txtPriceIn.Name = "txtPriceIn";
			this.txtPriceIn.Size = new System.Drawing.Size(150, 20);
			this.txtPriceIn.TabIndex = 12;
			// 
			// txtPriceOut
			// 
			this.txtPriceOut.Location = new System.Drawing.Point(107, 154);
			this.txtPriceOut.Name = "txtPriceOut";
			this.txtPriceOut.Size = new System.Drawing.Size(150, 20);
			this.txtPriceOut.TabIndex = 13;
			// 
			// txtPicture
			// 
			this.txtPicture.Location = new System.Drawing.Point(370, 23);
			this.txtPicture.Name = "txtPicture";
			this.txtPicture.Size = new System.Drawing.Size(150, 20);
			this.txtPicture.TabIndex = 14;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(541, 21);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 15;
			this.btnOpen.Text = "Open...";
			this.btnOpen.UseVisualStyleBackColor = true;
			// 
			// rtbDetail
			// 
			this.rtbDetail.Location = new System.Drawing.Point(370, 49);
			this.rtbDetail.Name = "rtbDetail";
			this.rtbDetail.Size = new System.Drawing.Size(246, 125);
			this.rtbDetail.TabIndex = 16;
			this.rtbDetail.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pictureBox1);
			this.groupBox2.Location = new System.Drawing.Point(653, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(179, 190);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Picture";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(6, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(165, 165);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Location = new System.Drawing.Point(12, 208);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(821, 230);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Data";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 19);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(806, 205);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(255, 444);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 19;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(174, 444);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 18;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(93, 444);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 444);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 16;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(757, 444);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 21;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// btnSkip
			// 
			this.btnSkip.Location = new System.Drawing.Point(676, 444);
			this.btnSkip.Name = "btnSkip";
			this.btnSkip.Size = new System.Drawing.Size(75, 23);
			this.btnSkip.TabIndex = 20;
			this.btnSkip.Text = "Skip";
			this.btnSkip.UseVisualStyleBackColor = true;
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(595, 444);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(75, 23);
			this.btnShow.TabIndex = 23;
			this.btnShow.Text = "Show List";
			this.btnShow.UseVisualStyleBackColor = true;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(514, 444);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 22;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// frmComputer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 477);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSkip);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmComputer";
			this.Text = "Computer";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox rtbDetail;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.TextBox txtPicture;
		private System.Windows.Forms.TextBox txtPriceOut;
		private System.Windows.Forms.TextBox txtPriceIn;
		private System.Windows.Forms.TextBox txtCount;
		private System.Windows.Forms.ComboBox cboManufacturer;
		private System.Windows.Forms.TextBox txtComputerName;
		private System.Windows.Forms.TextBox txtComuterID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnSkip;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Button btnSearch;
	}
}