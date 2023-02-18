using System;
using System.Data;
using System.Windows.Forms;

namespace PCManager
{
	public partial class frmManufacturer : Form
	{
		DataTable tblManufacturer;
		public frmManufacturer()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Close window
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Form load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmManufacturer_Load(object sender, EventArgs e)
		{
			txtManufacturerID.Enabled = false;
			btnSave.Enabled = false;
			btnSkip.Enabled = false;
			LoadDataGridView();
		}

		/// <summary>
		/// Load data from database to datagridview
		/// </summary>
		private void LoadDataGridView()
		{
			string sql;
			sql = "SELECT * FROM tblManufacturer";
			tblManufacturer = COMMON.GetDataToTable(sql);
			dgvManufacturer.DataSource = tblManufacturer;
			dgvManufacturer.AllowUserToAddRows = false;
			dgvManufacturer.EditMode = DataGridViewEditMode.EditProgrammatically;
		}

		/// <summary>
		/// Datagridview row click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvManufacturer_Click(object sender, EventArgs e)
		{
			if (btnAdd.Enabled == false)
			{
				MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtManufacturerID.Focus();
				return;
			}
			if (tblManufacturer.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			txtManufacturerID.Text = dgvManufacturer.CurrentRow.Cells["Manufacturer_ID"].Value.ToString();
			txtManufacturerName.Text = dgvManufacturer.CurrentRow.Cells["Manufacturer_Name"].Value.ToString();
			btnEdit.Enabled = true;
			btnSkip.Enabled = true;
			btnDelete.Enabled = true;
		}

		/// <summary>
		/// Event when button Add click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
			btnSkip.Enabled = true;
			btnSave.Enabled = true;
			btnAdd.Enabled = false;
			ResetValue();
			txtManufacturerID.Enabled = true;
			txtManufacturerID.Focus();
		}

		/// <summary>
		/// Reset value textbox
		/// </summary>
		private void ResetValue()
		{
			txtManufacturerID.Text = string.Empty;
			txtManufacturerName.Text = string.Empty;
		}

		/// <summary>
		/// Event when click button Save
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSave_Click(object sender, EventArgs e)
		{
			string sql;
			if (txtManufacturerID.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtManufacturerID.Focus();
				return;
			}
			if (txtManufacturerName.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn phải nhập tên hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtManufacturerName.Focus();
				return;
			}
			sql = "Select Manufacturer_ID From tblManufacturer where Manufacturer_ID = N'" + txtManufacturerID.Text.Trim() + "'";
			if (COMMON.CheckKey(sql))
			{
				MessageBox.Show("Mã hãng sản xuất này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtManufacturerID.Focus();
				return;
			}

			sql = "INSERT INTO tblManufacturer VALUES(N'" + txtManufacturerID.Text + "',N'" + txtManufacturerName.Text + "')";
			COMMON.RunSQL(sql);
			LoadDataGridView();
			ResetValue();
			btnDelete.Enabled = true;
			btnAdd.Enabled = true;
			btnEdit.Enabled = true;
			btnSkip.Enabled = false;
			btnSave.Enabled = false;
			txtManufacturerID.Enabled = false;
		}

		/// <summary>
		/// Event when click button Edit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnEdit_Click(object sender, EventArgs e)
		{
			string sql;
			if (tblManufacturer.Rows.Count == 0)
			{
				MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (String.IsNullOrEmpty(txtManufacturerID.Text))
			{
				MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtManufacturerName.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn chưa nhập tên hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			sql = "UPDATE tblManufacturer SET Manufacturer_Name = N'" + txtManufacturerName.Text.ToString() + "' WHERE Manufacturer_ID = N'" + txtManufacturerID.Text + "'";
			COMMON.RunSQL(sql);
			LoadDataGridView();
			ResetValue();

			btnSkip.Enabled = false;
		}

		/// <summary>
		/// Event when click button Delete
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			string sql;
			if (tblManufacturer.Rows.Count == 0)
			{
				MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (String.IsNullOrEmpty(txtManufacturerID.Text))
			{
				MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				sql = "DELETE tblManufacturer WHERE Manufacturer_ID = N'" + txtManufacturerID.Text + "'";
				COMMON.RunSqlDel(sql);
				LoadDataGridView();
				ResetValue();
			}
		}

		/// <summary>
		/// Event when click button Skip
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSkip_Click(object sender, EventArgs e)
		{
			ResetValue();
			btnSkip.Enabled = false;
			btnAdd.Enabled = true;
			btnDelete.Enabled = true;
			btnEdit.Enabled = true;
			btnSave.Enabled = false;
			txtManufacturerID.Enabled = false;
		}
	}
}
