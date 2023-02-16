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
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			COMMON.Connect();
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			COMMON.Disconnect();
			this.Close();
		}

		private void mnuManufacturer_Click(object sender, EventArgs e)
		{
			frmManufacturer frmManufacturer = new frmManufacturer();
			frmManufacturer.ShowDialog();
		}

		private void mnuComputer_Click(object sender, EventArgs e)
		{
			frmComputer frmComputer = new frmComputer();
			frmComputer.ShowDialog();
		}

		private void mnuStaff_Click(object sender, EventArgs e)
		{
			frmStaff frmStaff = new frmStaff();
			frmStaff.ShowDialog();
		}

		private void mnuCustomer_Click(object sender, EventArgs e)
		{
			frmCustomer frmCustomer = new frmCustomer();
			frmCustomer.ShowDialog();
		}

		private void mnuBill_Click(object sender, EventArgs e)
		{
			frmBill frmBill = new frmBill();
			frmBill.ShowDialog();
		}
	}
}
