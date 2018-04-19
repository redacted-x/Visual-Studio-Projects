using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySqlBackupTestApp.Properties;

namespace MySqlBackupTestApp
{
	// Token: 0x02000010 RID: 16
	public partial class FormDumpFileViewer : Form
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000C484 File Offset: 0x0000A684
		public FormDumpFileViewer()
		{
			this.InitializeComponent();
			this.textBox1.Text = "";
			this.tsFile.Text = "";
			this.tsStatus.Text = "(No file loaded)";
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000C4C2 File Offset: 0x0000A6C2
		public void OpenTargetFile()
		{
			this.OpenFile(Program.TargetFile);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		private void OpenFile(string file)
		{
			if (file == "")
			{
				this.textBox1.Text = "";
				this.tsFile.Text = "";
				this.tsStatus.Text = "(No file loaded)";
				return;
			}
			if (!File.Exists(file))
			{
				this.tsFile.Text = "";
				this.tsStatus.Text = "(File not exists)";
				MessageBox.Show("File not exists:\r\n" + file, "Open", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			try
			{
				this.tsStatus.Text = "(Please wait... File is loading...)";
				this.Refresh();
				base.SuspendLayout();
				this.textBox1.Text = File.ReadAllText(file);
				this.tsFile.Text = file;
				this.tsStatus.Text = "(File Loaded)";
				base.ResumeLayout(true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			this.tsStatus.Text = "(Editing)";
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
		private void tsOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (Program.DefaultFolder != "")
			{
				openFileDialog.InitialDirectory = Program.DefaultFolder;
			}
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.OpenFile(openFileDialog.FileName);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000C628 File Offset: 0x0000A828
		private void tsSave_Click(object sender, EventArgs e)
		{
			if (this.tsFile.Text == "")
			{
				MessageBox.Show("No file to save.");
				return;
			}
			File.WriteAllText(this.tsFile.Text, this.textBox1.Text, new UTF8Encoding(false));
			this.tsStatus.Text = "(Saved)";
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000C68C File Offset: 0x0000A88C
		private void tsSaveAs_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveFileDialog.FileName, this.textBox1.Text, new UTF8Encoding(false));
				this.tsStatus.Text = "(Saved)";
				this.tsFile.Text = saveFileDialog.FileName;
				Program.DefaultFolder = Path.GetDirectoryName(this.tsFile.Text);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000C6FA File Offset: 0x0000A8FA
		private void tsClose_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			this.tsStatus.Text = "(No file loaded)";
			this.tsFile.Text = "";
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000C72C File Offset: 0x0000A92C
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				this.textBox1.SelectAll();
				e.SuppressKeyPress = true;
			}
		}
	}
}
