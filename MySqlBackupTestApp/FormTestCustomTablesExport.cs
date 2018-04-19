using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlBackupTestApp
{
	// Token: 0x02000008 RID: 8
	public partial class FormTestCustomTablesExport : Form
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00005824 File Offset: 0x00003A24
		public FormTestCustomTablesExport()
		{
			this.InitializeComponent();
			this.LoadData();
			this.dataGridView1.CellClick += this.dataGridView1_CellClick;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005850 File Offset: 0x00003A50
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == this.colnSelect.Index && e.RowIndex > -1)
			{
				this.dataGridView1.Rows[e.RowIndex].Cells[this.colnSelect.Index].Value = !Convert.ToBoolean(this.dataGridView1.Rows[e.RowIndex].Cells[this.colnSelect.Index].Value);
				this.dataGridView1.EndEdit();
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000058F5 File Offset: 0x00003AF5
		private void btRefresh_Click(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005900 File Offset: 0x00003B00
		private void LoadData()
		{
			DataTable dataTable = null;
			using (MySqlConnection mySqlConnection = new MySqlConnection(Program.ConnectionString))
			{
				using (MySqlCommand mySqlCommand = new MySqlCommand())
				{
					mySqlCommand.Connection = mySqlConnection;
					mySqlConnection.Open();
					string text = QueryExpress.ExecuteScalarStr(mySqlCommand, "SELECT DATABASE();");
					if (string.IsNullOrEmpty(text))
					{
						this.lbDb.Text = "Database: No database in use/selected.";
						return;
					}
					this.lbDb.Text = "Database: " + text;
					dataTable = QueryExpress.GetTable(mySqlCommand, "SHOW FULL TABLES WHERE `Table_type` = 'BASE TABLE';");
					mySqlConnection.Close();
				}
			}
			this.dataGridView1.Rows.Clear();
			this.dataGridView1.Rows.Add(dataTable.Rows.Count);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				string text2 = string.Concat(dataTable.Rows[i][0]);
				this.dataGridView1.Rows[i].Cells[this.colnSelect.Index].Value = 1;
				this.dataGridView1.Rows[i].Cells[this.colnTable.Index].Value = text2;
				string value = string.Format("SELECT * FROM `{0}`", text2);
				this.dataGridView1.Rows[i].Cells[this.colnSql.Index].Value = value;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005AB4 File Offset: 0x00003CB4
		private void btSelectNone_Click(object sender, EventArgs e)
		{
			foreach (object obj in ((IEnumerable)this.dataGridView1.Rows))
			{
				((DataGridViewRow)obj).Cells[0].Value = false;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005B20 File Offset: 0x00003D20
		private void btSelectAll_Click(object sender, EventArgs e)
		{
			foreach (object obj in ((IEnumerable)this.dataGridView1.Rows))
			{
				((DataGridViewRow)obj).Cells[0].Value = true;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005B8C File Offset: 0x00003D8C
		private void btExportDic_Click(object sender, EventArgs e)
		{
			if (!Program.TargetDirectoryIsValid())
			{
				return;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (object obj in ((IEnumerable)this.dataGridView1.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (Convert.ToBoolean(dataGridViewRow.Cells[this.colnSelect.Index].Value))
				{
					string key = string.Concat(dataGridViewRow.Cells[this.colnTable.Index].Value);
					string value = string.Concat(dataGridViewRow.Cells[this.colnSql.Index].Value);
					dictionary[key] = value;
				}
			}
			if (dictionary.Count == 0)
			{
				return;
			}
			try
			{
				using (MySqlConnection mySqlConnection = new MySqlConnection(Program.ConnectionString))
				{
					using (MySqlCommand mySqlCommand = new MySqlCommand())
					{
						using (MySqlBackup mySqlBackup = new MySqlBackup(mySqlCommand))
						{
							mySqlCommand.Connection = mySqlConnection;
							mySqlConnection.Open();
							mySqlBackup.ExportInfo.TablesToBeExportedDic = dictionary;
							mySqlBackup.ExportToFile(Program.TargetFile);
							mySqlConnection.Close();
						}
					}
				}
				MessageBox.Show("Done.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005D30 File Offset: 0x00003F30
		private void btExportList_Click(object sender, EventArgs e)
		{
			if (!Program.TargetDirectoryIsValid())
			{
				return;
			}
			List<string> list = new List<string>();
			foreach (object obj in ((IEnumerable)this.dataGridView1.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (Convert.ToBoolean(dataGridViewRow.Cells[this.colnSelect.Index].Value))
				{
					string item = string.Concat(dataGridViewRow.Cells[this.colnTable.Index].Value);
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				return;
			}
			try
			{
				using (MySqlConnection mySqlConnection = new MySqlConnection(Program.ConnectionString))
				{
					using (MySqlCommand mySqlCommand = new MySqlCommand())
					{
						using (MySqlBackup mySqlBackup = new MySqlBackup(mySqlCommand))
						{
							mySqlCommand.Connection = mySqlConnection;
							mySqlConnection.Open();
							mySqlBackup.ExportInfo.TablesToBeExportedList = list;
							mySqlBackup.ExportToFile(Program.TargetFile);
							mySqlConnection.Close();
						}
					}
				}
				MessageBox.Show("Done.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
