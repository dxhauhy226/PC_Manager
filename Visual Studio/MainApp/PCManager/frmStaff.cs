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
	public partial class frmStaff : Form
	{
		DataTable tblStaff;
		public frmStaff()
		{
			InitializeComponent();
		}

		private void frmStaff_Load(object sender, EventArgs e)
		{
			txtStaffID.Enabled = false;
			btnSave.Enabled = false;
			btnSkip.Enabled = false;
			LoadDataGridView();
		}

		public void LoadDataGridView()
		{
			string sql;
			sql = "SELECT * FROM tblStaff";
			tblStaff = COMMON.GetDataToTable(sql);
			dgvStaff.DataSource = tblStaff;
			dgvStaff.AllowUserToAddRows = false;
			dgvStaff.EditMode = DataGridViewEditMode.EditProgrammatically;
		}

		private void dgvStaff_Click(object sender, EventArgs e)
		{
			if (btnAdd.Enabled == false)
			{
				MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtStaffID.Focus();
				return;
			}
			if (tblStaff.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			txtStaffID.Text = dgvStaff.CurrentRow.Cells["Staff_ID"].Value.ToString();
			txtStaffName.Text = dgvStaff.CurrentRow.Cells["Staff_Name"].Value.ToString();
			if (dgvStaff.CurrentRow.Cells["Staff_Gender"].Value.ToString() == "Nam") chkGender.Checked = true;
			else chkGender.Checked = false;
			txtAddr.Text = dgvStaff.CurrentRow.Cells["Staff_Addr"].Value.ToString();
			txtPhone.Text = dgvStaff.CurrentRow.Cells["Staff_Phone"].Value.ToString();
			btnEdit.Enabled = true;
			btnDelete.Enabled = true;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
			btnSkip.Enabled = true;
			btnSave.Enabled = true;
			btnAdd.Enabled = false;
			ResetValues();
			txtStaffID.Enabled = true;
			txtStaffID.Focus();
		}

		private void ResetValues()
		{
			txtStaffID.Text = "";
			txtStaffName.Text = "";
			chkGender.Checked = false;
			txtAddr.Text = "";
			txtPhone.Text = "";
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string sql, gt;
			if (txtStaffID.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtStaffID.Focus();
				return;
			}
			if (txtStaffName.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtStaffName.Focus();
				return;
			}
			if (txtAddr.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtAddr.Focus();
				return;
			}
			if (txtPhone.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPhone.Focus();
				return;
			}
			if (chkGender.Checked == true)
				gt = "Nam";
			else
				gt = "Nữ";
			sql = "SELECT Staff_ID FROM tblStaff WHERE Staff_ID=N'" + txtStaffID.Text.Trim() + "'";
			if (COMMON.CheckKey(sql))
			{
				MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtStaffID.Focus();
				txtStaffID.Text = "";
				return;
			}
			sql = "INSERT INTO tblStaff VALUES (N'" + txtStaffID.Text.Trim() + "',N'" + txtStaffName.Text.Trim() + "'," +
				"N'" + gt + "',N'" + txtAddr.Text.Trim() + "','" + txtPhone.Text + "')";
			COMMON.RunSQL(sql);
			LoadDataGridView();
			ResetValues();
			btnDelete.Enabled = true;
			btnAdd.Enabled = true;
			btnEdit.Enabled = true;
			btnSkip.Enabled = false;
			btnSave.Enabled = false;
			txtStaffID.Enabled = false;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			string sql, gt;
			if (tblStaff.Rows.Count == 0)
			{
				MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtStaffID.Text == "")
			{
				MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtStaffName.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtStaffName.Focus();
				return;
			}
			if (txtAddr.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtAddr.Focus();
				return;
			}
			if (txtPhone.Text.Trim().Length == 0 || txtPhone.Text.Trim().Length < 10 || txtPhone.Text.Trim().Length > 10)
			{
				MessageBox.Show("Bạn phải nhập điện thoại có 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPhone.Focus();
				return;
			}
			if (chkGender.Checked == true)
				gt = "Nam";
			else
				gt = "Nữ";
			sql = "UPDATE tblStaff SET  Staff_Name=N'" + txtStaffName.Text.Trim().ToString() +
					"',Staff_Addr=N'" + txtAddr.Text.Trim().ToString() +
					"',Staff_Phone='" + txtPhone.Text.ToString() + "',Staff_Gender=N'" + gt +
					"' WHERE Staff_ID=N'" + txtStaffID.Text + "'";
			COMMON.RunSQL(sql);
			LoadDataGridView();
			ResetValues();
			btnSkip.Enabled = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string sql;
			if (tblStaff.Rows.Count == 0)
			{
				MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtStaffID.Text == "")
			{
				MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				sql = "DELETE tblStaff WHERE Staff_ID=N'" + txtStaffID.Text + "'";
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
			txtStaffID.Enabled = false;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
