using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlBackupTestApp
{
	// Token: 0x02000015 RID: 21
	public partial class FormTestSimple : Form
	{
		// Token: 0x060000DA RID: 218 RVA: 0x0000F579 File Offset: 0x0000D779
		public FormTestSimple()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000F588 File Offset: 0x0000D788
		private void btImport_Click(object sender, EventArgs e)
		{
			if (!Program.SourceFileExists())
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
							mySqlBackup.ImportFromFile(Program.TargetFile);
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

		// Token: 0x060000DC RID: 220 RVA: 0x0000F648 File Offset: 0x0000D848
		private void btExport_Click(object sender, EventArgs e)
		{
			if (!Program.TargetDirectoryIsValid())
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

        private void btInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function is used to BACKUP and RESTORE the database currently listed in the connection string.\r\n\r\nInstructions:\r\n\r\n1. Fill in the connection string and select Auto-Save.\r\n2. Export into first dump file.\r\n3. Drop the database.\r\n4. Import from first dump file.\r\n5. Export again into second dump file.\r\n6. Compare the first and second dump by using this SHA256 checksum.\r\n7. If both checksums are match, this will prove that both EXPORT and IMPORT are working good.", "Info");
        }
    }
}
