namespace PCManager
{
	partial class frmManufacturer
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
			this.txtManufacturerName = new System.Windows.Forms.TextBox();
			this.txtManufacturerID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvManufacturer = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSkip = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.Manufacturer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Manufacturer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvManufacturer)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtManufacturerName);
			this.groupBox1.Controls.Add(this.txtManufacturerID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(62, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(361, 103);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Manufacturer";
			// 
			// txtManufacturerName
			// 
			this.txtManufacturerName.Location = new System.Drawing.Point(142, 53);
			this.txtManufacturerName.Name = "txtManufacturerName";
			this.txtManufacturerName.Size = new System.Drawing.Size(200, 20);
			this.txtManufacturerName.TabIndex = 3;
			// 
			// txtManufacturerID
			// 
			this.txtManufacturerID.Location = new System.Drawing.Point(142, 22);
			this.txtManufacturerID.Name = "txtManufacturerID";
			this.txtManufacturerID.Size = new System.Drawing.Size(200, 20);
			this.txtManufacturerID.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Manufacturer Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Manufacturer ID";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvManufacturer);
			this.groupBox2.Location = new System.Drawing.Point(12, 121);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(480, 153);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Data";
			// 
			// dgvManufacturer
			// 
			this.dgvManufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvManufacturer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manufacturer_ID,
            this.Manufacturer_Name});
			this.dgvManufacturer.Location = new System.Drawing.Point(6, 19);
			this.dgvManufacturer.Name = "dgvManufacturer";
			this.dgvManufacturer.Size = new System.Drawing.Size(468, 128);
			this.dgvManufacturer.TabIndex = 0;
			this.dgvManufacturer.Click += new System.EventHandler(this.dgvManufacturer_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 280);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(93, 280);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(174, 280);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 4;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(255, 280);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnSkip
			// 
			this.btnSkip.Location = new System.Drawing.Point(336, 280);
			this.btnSkip.Name = "btnSkip";
			this.btnSkip.Size = new System.Drawing.Size(75, 23);
			this.btnSkip.TabIndex = 6;
			this.btnSkip.Text = "Skip";
			this.btnSkip.UseVisualStyleBackColor = true;
			this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(417, 280);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Manufacturer_ID
			// 
			this.Manufacturer_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Manufacturer_ID.DataPropertyName = "Manufacturer_ID";
			this.Manufacturer_ID.FillWeight = 70F;
			this.Manufacturer_ID.HeaderText = "Manufacturer ID";
			this.Manufacturer_ID.Name = "Manufacturer_ID";
			// 
			// Manufacturer_Name
			// 
			this.Manufacturer_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Manufacturer_Name.DataPropertyName = "Manufacturer_Name";
			this.Manufacturer_Name.HeaderText = "Manufacturer Name";
			this.Manufacturer_Name.Name = "Manufacturer_Name";
			// 
			// frmManufacturer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 316);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSkip);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmManufacturer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manufacturer";
			this.Load += new System.EventHandler(this.frmManufacturer_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvManufacturer)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtManufacturerName;
		private System.Windows.Forms.TextBox txtManufacturerID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgvManufacturer;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnSkip;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer_ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer_Name;
	}
}