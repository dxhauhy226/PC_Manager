using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PCManager
{
	public class COMMON
	{
		public static SqlConnection sqlConnection;
		public static void Connect()
		{
			try
			{
				sqlConnection = new SqlConnection();
				sqlConnection.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=PCManager;Integrated Security=True";
				sqlConnection.Open();
				if (sqlConnection.State == ConnectionState.Open)
					MessageBox.Show("Connection To Database Successful","PC Manager",MessageBoxButtons.OK,MessageBoxIcon.Information);
				else MessageBox.Show("Unable To Connect To Database", "PC Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public static void Disconnect()
		{
			try
			{
				if (sqlConnection.State == ConnectionState.Open)
				{
					sqlConnection.Close();
					sqlConnection.Dispose();
					sqlConnection = null;
				}
			}
			catch(Exception ex )
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
