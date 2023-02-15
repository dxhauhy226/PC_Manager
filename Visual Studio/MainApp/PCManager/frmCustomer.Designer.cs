namespace PCManager
{
	partial class frmCustomer
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
			this.btnSave = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgvCustomer = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkGender = new System.Windows.Forms.CheckBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtAddr = new System.Windows.Forms.TextBox();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSkip = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Customer_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Customer_Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Customer_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(304, 317);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 13;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(174, 317);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 12;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(93, 317);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 11;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 317);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// dgvCustomer
			// 
			this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.Customer_Name,
            this.Customer_Gender,
            this.Customer_Addr,
            this.Customer_Phone});
			this.dgvCustomer.Location = new System.Drawing.Point(6, 19);
			this.dgvCustomer.Name = "dgvCustomer";
			this.dgvCustomer.Size = new System.Drawing.Size(517, 161);
			this.dgvCustomer.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvCustomer);
			this.groupBox2.Location = new System.Drawing.Point(12, 125);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(529, 186);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Data";
			// 
			// chkGender
			// 
			this.chkGender.AutoSize = true;
			this.chkGender.Location = new System.Drawing.Point(113, 79);
			this.chkGender.Name = "chkGender";
			this.chkGender.Size = new System.Drawing.Size(49, 17);
			this.chkGender.TabIndex = 9;
			this.chkGender.Text = "Male";
			this.chkGender.UseVisualStyleBackColor = true;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(350, 52);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(150, 20);
			this.txtPhone.TabIndex = 8;
			// 
			// txtAddr
			// 
			this.txtAddr.Location = new System.Drawing.Point(350, 26);
			this.txtAddr.Name = "txtAddr";
			this.txtAddr.Size = new System.Drawing.Size(150, 20);
			this.txtAddr.TabIndex = 7;
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(113, 52);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(150, 20);
			this.txtCustomerName.TabIndex = 6;
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Location = new System.Drawing.Point(113, 26);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.Size = new System.Drawing.Size(150, 20);
			this.txtCustomerID.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(278, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Address";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(278, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Phone";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Gender";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Customer Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer ID";
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(466, 317);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 15;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// btnSkip
			// 
			this.btnSkip.Location = new System.Drawing.Point(385, 317);
			this.btnSkip.Name = "btnSkip";
			this.btnSkip.Size = new System.Drawing.Size(75, 23);
			this.btnSkip.TabIndex = 14;
			this.btnSkip.Text = "Skip";
			this.btnSkip.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkGender);
			this.groupBox1.Controls.Add(this.txtPhone);
			this.groupBox1.Controls.Add(this.txtAddr);
			this.groupBox1.Controls.Add(this.txtCustomerName);
			this.groupBox1.Controls.Add(this.txtCustomerID);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(529, 107);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customer Information";
			// 
			// Customer_ID
			// 
			this.Customer_ID.FillWeight = 50F;
			this.Customer_ID.HeaderText = "Customer ID";
			this.Customer_ID.Name = "Customer_ID";
			// 
			// Customer_Name
			// 
			this.Customer_Name.HeaderText = "Customer Name";
			this.Customer_Name.Name = "Customer_Name";
			this.Customer_Name.Width = 150;
			// 
			// Customer_Gender
			// 
			this.Customer_Gender.HeaderText = "Gender";
			this.Customer_Gender.Name = "Customer_Gender";
			this.Customer_Gender.Width = 70;
			// 
			// Customer_Addr
			// 
			this.Customer_Addr.HeaderText = "Address";
			this.Customer_Addr.Name = "Customer_Addr";
			this.Customer_Addr.Width = 200;
			// 
			// Customer_Phone
			// 
			this.Customer_Phone.HeaderText = "Phone";
			this.Customer_Phone.Name = "Customer_Phone";
			// 
			// frmCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 355);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSkip);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmCustomer";
			this.Text = "Customer";
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView dgvCustomer;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkGender;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtAddr;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnSkip;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Addr;
		private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Phone;
	}
}