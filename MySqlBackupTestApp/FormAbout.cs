using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySqlBackupTestApp.Properties;

namespace MySqlBackupTestApp
{
	// Token: 0x02000003 RID: 3
	public partial class FormAbout : Form
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002FCA File Offset: 0x000011CA
		public FormAbout()
		{
			this.InitializeComponent();
			Label label = this.lbVersion;
			label.Text += "\r\n\r\nCurrent Loaded MySqlBackup.DLL Version: " + this.ProductVersion;
		}
	}
}
