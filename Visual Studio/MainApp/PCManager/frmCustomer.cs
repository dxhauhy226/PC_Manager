using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCManager
{
	public partial class frmCustomer : Form
	{
		DataTable tblCustomer;
		public frmCustomer()
		{
			InitializeComponent();
		}

		private void frmCustomer_Load(object sender, EventArgs e)
		{
			txtCustomerID.Enabled = false;
			btnSave.Enabled = false;
			btnSkip.Enabled = false;
			LoadDataGridView();
		}

		private void LoadDataGridView()
		{
			string sql;
			sql = "SELECT * from tblCustomer";
			tblCustomer = COMMON.GetDataToTable(sql); //Lấy dữ liệu từ bảng
			dgvCustomer.DataSource = tblCustomer; //Hiển thị vào dataGridView
			dgvCustomer.AllowUserToAddRows = false;
			dgvCustomer.EditMode = DataGridViewEditMode.EditProgrammatically;
		}

		private void dgvCustomer_Click(object sender, EventArgs e)
		{
			if (btnAdd.Enabled == false)
			{
				MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtCustomerID.Focus();
				return;
			}
			if (tblCustomer.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			txtCustomerID.Text = dgvCustomer.CurrentRow.Cells["Customer_ID"].Value.ToString();
			txtCustomerName.Text = dgvCustomer.CurrentRow.Cells["Customer_Name"].Value.ToString();
			txtAddr.Text = dgvCustomer.CurrentRow.Cells["Customer_Addr"].Value.ToString();
			txtPhone.Text = dgvCustomer.CurrentRow.Cells["Customer_Phone"].Value.ToString();
			btnEdit.Enabled = true;
			btnDelete.Enabled = true;
			btnSkip.Enabled = true;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
			btnSkip.Enabled = true;
			btnSave.Enabled = true;
			btnAdd.Enabled = false;
			ResetValues();
			txtCustomerID.Enabled = true;
			txtCustomerID.Focus();
		}

		private void ResetValues()
		{
			txtCustomerID.Text = "";
			txtCustomerName.Text = "";
			txtAddr.Text = "";
			txtPhone.Text = "";
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string sql, gt;
			if (txtCustomerID.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtCustomerID.Focus();
				return;
			}
			if (txtCustomerName.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtCustomerName.Focus();
				return;
			}
			if (txtAddr.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtAddr.Focus();
				return;
			}
			if (txtPhone.Text.Trim().Length == 0 || txtPhone.Text.Trim().Length < 10 || txtPhone.Text.Trim().Length > 10)
			{
				MessageBox.Show("Bạn phải nhập điện thoại có 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtPhone.Focus();
				return;
			}
			if (chkGender.Checked == true)
				gt = "Nam";
			else
				gt = "Nữ";
			//Kiểm tra đã tồn tại mã khách chưa
			sql = "SELECT Customer_ID FROM tblCustomer WHERE Customer_ID=N'" + txtCustomerID.Text.Trim() + "'";
			if (COMMON.CheckKey(sql))
			{
				MessageBox.Show("Mã khách hàng này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtCustomerID.Focus();
				return;
			}
			//Chèn thêm
			sql = "INSERT INTO tblCustomer VALUES (N'" + txtCustomerID.Text.Trim() + "',N'" + txtCustomerName.Text.Trim() +
				"',N'" + gt + "',N'" + txtAddr.Text.Trim() + "','" + txtPhone.Text + "')";
			COMMON.RunSQL(sql);
			LoadDataGridView();
			ResetValues();

			btnDelete.Enabled = true;
			btnAdd.Enabled = true;
			btnEdit.Enabled = true;
			btnSkip.Enabled = false;
			btnSave.Enabled = false;
			txtCustomerID.Enabled = false;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			string sql, gt;
			if (tblCustomer.Rows.Count == 0)
			{
				MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtCustomerID.Text == "")
			{
				MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtCustomerName.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtCustomerName.Focus();
				return;
			}
			if (txtAddr.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtAddr.Focus();
				return;
			}
			if (txtPhone.Text.Trim().Length == 0 || txtPhone.Text.Trim().Length < 10 || txtPhone.Text.Trim().Length > 10)
			{
				MessageBox.Show("Bạn phải nhập điện thoại có 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtPhone.Focus();
				return;
			}
			if (chkGender.Checked == true)
				gt = "Nam";
			else
				gt = "Nữ";
			sql = "UPDATE tblCustomer SET Customer_Name=N'" + txtCustomerName.Text.Trim().ToString() + "',Customer_Addr=N'" +
				txtAddr.Text.Trim().ToString() + "',Customer_Gender=N'" + gt + "',Customer_Phone='" + txtPhone.Text.ToString() +
				"' WHERE Customer_ID=N'" + txtCustomerID.Text + "'";
			COMMON.RunSQL(sql);
			LoadDataGridView();
			ResetValues();
			btnSkip.Enabled = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string sql;
			if (tblCustomer.Rows.Count == 0)
			{
				MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtCustomerID.Text.Trim() == "")
			{
				MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				sql = "DELETE tblCustomer WHERE Customer_ID=N'" + txtCustomerID.Text + "'";
				COMMON.RunSqlDel(sql);
				LoadDataGridView();
				ResetValues();
			}
		}

		private void btnSkip_Click(object sender, EventArgs e)
		{
			ResetValues();
			btnSkip.Enabled = false;
			btnAdd.Enabled = true;
			btnDelete.Enabled = true;
			btnEdit.Enabled = true;
			btnSave.Enabled = false;
			txtCustomerID.Enabled = false;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
