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
					MessageBox.Show("Connect To Database Successful","PC Manager",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
		public static DataTable GetDataToTable(string sql)
		{
			SqlDataAdapter dap = new SqlDataAdapter(sql, sqlConnection);
			DataTable table = new DataTable();
			dap.Fill(table);
			return table;
		}
		public static bool CheckKey(string sql)
		{
			SqlDataAdapter dap = new SqlDataAdapter(sql, sqlConnection);
			DataTable table = new DataTable();
			dap.Fill(table);
			if (table.Rows.Count > 0)
				return true;
			else return false;
		}
		public static void RunSQL(string sql)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = sqlConnection;
			cmd.CommandText = sql;
			try
			{
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			cmd.Dispose();
		}
		public static void RunSqlDel(string sql)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = sqlConnection;
			cmd.CommandText = sql;
			try
			{
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			cmd.Dispose();
			cmd = null;
		}
	}
}
