using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySqlBackupTestApp.Properties;

namespace MySqlBackupTestApp
{
	// Token: 0x0200000C RID: 12
	public partial class FormCompareFile : Form
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00008DD0 File Offset: 0x00006FD0
		public FormCompareFile()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00008E0C File Offset: 0x0000700C
		private void button_OpenFile1_Click(object sender, EventArgs e)
		{
			this.file1Opened = this.GetHash(ref this.file1, ref this.hash1);
			this.lbFilePath1.Text = "File: " + this.file1;
			this.lbSHA1.Text = "SHA256 Checksum: " + this.hash1;
			this.CompareFile();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00008E70 File Offset: 0x00007070
		private void button_OpenFile2_Click(object sender, EventArgs e)
		{
			this.file2Opened = this.GetHash(ref this.file2, ref this.hash2);
			this.lbFilePath2.Text = "File: " + this.file2;
			this.lbSHA2.Text = "SHA256 Checksum: " + this.hash2;
			this.CompareFile();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00008ED4 File Offset: 0x000070D4
		private bool GetHash(ref string file, ref string hash)
		{
			bool result;
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (DialogResult.OK == openFileDialog.ShowDialog())
				{
					file = openFileDialog.FileName;
					byte[] ba = File.ReadAllBytes(openFileDialog.FileName);
					hash = CryptoExpress.Sha256Hash(ba);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("File not valid.\r\n\r\n" + ex.ToString());
				result = false;
			}
			return result;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00008F40 File Offset: 0x00007140
		private void CompareFile()
		{
			if (!this.file1Opened || !this.file2Opened)
			{
				this.lbResult.Text = "";
				return;
			}
			if (this.hash1 == this.hash2)
			{
				this.lbResult.Text = "Match. 100% same content.";
				this.lbResult.ForeColor = Color.DarkGreen;
				return;
			}
			this.lbResult.Text = "Not match. Both files are not same.";
			this.lbResult.ForeColor = Color.Red;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00008FC2 File Offset: 0x000071C2
		private void btInfo_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This function can be used to find out both EXPORT and IMPORT are working as expected or not by comparing the results.\r\n\r\nInstructions:\r\n\r\n1. Build the database and fill some data.\r\n2. Export into first dump file.\r\n3. Drop the database.\r\n4. Import from first dump file.\r\n5. Export again into second dump file.\r\n6. Compare the first and second dump by using this SHA256 checksum.\r\n7. If both checksums are match, this will prove that both EXPORT and IMPORT are working good.", "Info");
		}

		// Token: 0x04000074 RID: 116
		private bool file1Opened;

		// Token: 0x04000075 RID: 117
		private bool file2Opened;

		// Token: 0x04000076 RID: 118
		private string hash1 = "";

		// Token: 0x04000077 RID: 119
		private string hash2 = "";

		// Token: 0x04000078 RID: 120
		private string file1 = "";

		// Token: 0x04000079 RID: 121
		private string file2 = "";
	}
}
