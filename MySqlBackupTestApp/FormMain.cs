using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MySqlBackupTestApp
{
	// Token: 0x0200000E RID: 14
	public partial class FormMain : Form
	{
		// Token: 0x06000086 RID: 134 RVA: 0x0000A99C File Offset: 0x00008B9C
		public FormMain()
		{
			this.InitializeComponent();
			this.Text += ", Loaded MySqlBackup.DLL Version: 2.0.12";
			this.LoadSettings();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		private void FormMain_Load(object sender, EventArgs e)
		{
			this.OpenForm(typeof(FormTestSimple));
			this.stopWrite = false;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000AA14 File Offset: 0x00008C14
		private void FormMain_SizeChanged(object sender, EventArgs e)
		{
			base.SuspendLayout();
			for (int i = 0; i < this.lstForm.Count; i++)
			{
				this.lstForm[i].WindowState = FormWindowState.Normal;
				this.lstForm[i].WindowState = FormWindowState.Maximized;
			}
			base.ResumeLayout(true);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000AA68 File Offset: 0x00008C68
		private void OpenForm(Type formType)
		{
			base.SuspendLayout();
			try
			{
				for (int i = 0; i < this.lstForm.Count; i++)
				{
					this.lstForm[i].Close();
					this.lstForm[i].Dispose();
					this.lstForm[i] = null;
				}
				this.lstForm.Clear();
				Form form = (Form)Activator.CreateInstance(formType);
				form.WindowState = FormWindowState.Maximized;
				form.FormBorderStyle = FormBorderStyle.None;
				form.TopLevel = false;
				this.panel1.Controls.Add(form);
				form.Show();
				this.lstForm.Add(form);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			base.ResumeLayout(true);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000AB38 File Offset: 0x00008D38
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000AB40 File Offset: 0x00008D40
		private void button_ExportAs_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (Program.DefaultFolder != "")
			{
				saveFileDialog.InitialDirectory = Program.DefaultFolder;
			}
			saveFileDialog.Filter = "*.sql|*.sql|*.*|*.*";
			saveFileDialog.FileName = "TestDump " + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".sql";
			if (DialogResult.OK == saveFileDialog.ShowDialog())
			{
				this.textBox_File.Text = saveFileDialog.FileName;
				Program.DefaultFolder = Path.GetDirectoryName(this.textBox_File.Text);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000ABD0 File Offset: 0x00008DD0
		private void button_SelectFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (Program.DefaultFolder != "")
			{
				openFileDialog.InitialDirectory = Program.DefaultFolder;
			}
			if (DialogResult.OK == openFileDialog.ShowDialog())
			{
				this.textBox_File.Text = openFileDialog.FileName;
				Program.DefaultFolder = Path.GetDirectoryName(this.textBox_File.Text);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000AC30 File Offset: 0x00008E30
		private void button_View_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(FormDumpFileViewer));
			int i = 0;
			while (i < this.lstForm.Count)
			{
				if (this.lstForm[i].GetType() == typeof(FormDumpFileViewer))
				{
					if (!(Program.TargetFile == ""))
					{
						((FormDumpFileViewer)this.lstForm[i]).OpenTargetFile();
						return;
					}
					break;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000ACAD File Offset: 0x00008EAD
		private void textBox_Connection_TextChanged(object sender, EventArgs e)
		{
			Program.ConnectionString = this.textBox_Connection.Text;
			this.WriteSettings(false);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000ACC7 File Offset: 0x00008EC7
		private void textBox_File_TextChanged(object sender, EventArgs e)
		{
			Program.TargetFile = this.textBox_File.Text;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000ACEB File Offset: 0x00008EEB
		private void compareDumpFilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(FormCompareFile));
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000ACFD File Offset: 0x00008EFD
		private void databaseInfoViewerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(FormDatabaseInfo));
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000AD0F File Offset: 0x00008F0F
		private void dumpFileViewerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(FormDumpFileViewer));
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000AD57 File Offset: 0x00008F57
		private void testBasicWithDefaultSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(FormTestSimple));
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000AD69 File Offset: 0x00008F69
		private void queryBrowserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(FormQueryBrowser));
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000AD9F File Offset: 0x00008F9F
		private void testCustomExportOfTablesAndRowsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenForm(typeof(FormTestCustomTablesExport));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000ADB1 File Offset: 0x00008FB1
		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			new FormAbout().ShowDialog();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000AE18 File Offset: 0x00009018
		private void LoadSettings()
		{
			try
			{
				if (File.Exists(this.ConnectionSettingFile))
				{
					this.textBox_Connection.Text = File.ReadAllText(this.ConnectionSettingFile);
					this.cbAutosave.Checked = true;
				}
				else
				{
					this.cbAutosave.Checked = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000AE84 File Offset: 0x00009084
		private bool WriteSettings(bool forceSave)
		{
			bool result;
			try
			{
				if (this.stopWrite)
				{
					result = false;
				}
				else
				{
					if (forceSave)
					{
						File.WriteAllText(this.ConnectionSettingFile, this.textBox_Connection.Text);
					}
					else if (File.Exists(this.ConnectionSettingFile))
					{
						File.WriteAllText(this.ConnectionSettingFile, this.textBox_Connection.Text);
					}
					result = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000AF00 File Offset: 0x00009100
		private void cbAutosave_CheckedChanged(object sender, EventArgs e)
		{
			if (this.stopWrite)
			{
				return;
			}
			if (this.cbAutosave.Checked)
			{
				if (this.WriteSettings(true))
				{
					MessageBox.Show(string.Concat(new string[]
					{
						"Automatic save enabled.",
						Environment.NewLine,
						"Connection String saved at",
						Environment.NewLine,
						Environment.NewLine,
						this.ConnectionSettingFile
					}), "Saving Connection String");
					return;
				}
			}
			else
			{
				try
				{
					File.Delete(this.ConnectionSettingFile);
				}
				catch
				{
				}
			}
		}

		// Token: 0x04000093 RID: 147
		private string ConnectionSettingFile = Path.Combine(Environment.CurrentDirectory, "ConnectionSettings.txt");

		// Token: 0x04000094 RID: 148
		private List<Form> lstForm = new List<Form>();

		// Token: 0x04000095 RID: 149
		private bool stopWrite = true;
	}
}
