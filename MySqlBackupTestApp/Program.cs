using System;
using System.IO;
using System.Windows.Forms;

namespace MySqlBackupTestApp
{
	// Token: 0x02000019 RID: 25
	internal static class Program
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0001262D File Offset: 0x0001082D
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0001264B File Offset: 0x0001084B
		public static string ConnectionString
		{
			get
			{
				if (string.IsNullOrEmpty(Program._connectionString))
				{
					throw new Exception("Connection string is empty.");
				}
				return Program._connectionString;
			}
			set
			{
				Program._connectionString = value;
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00012653 File Offset: 0x00010853
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormMain());
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0001266C File Offset: 0x0001086C
		public static bool TargetDirectoryIsValid()
		{
			bool result;
			try
			{
				string directoryName = Path.GetDirectoryName(Program.TargetFile);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				result = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Specify path is not valid. Press [Export As] to specify a valid file path." + Environment.NewLine + Environment.NewLine + ex.Message, "Invalid Directory", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			return result;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000126D8 File Offset: 0x000108D8
		public static bool SourceFileExists()
		{
			if (!File.Exists(Program.TargetFile))
			{
				MessageBox.Show("File is not exists. Press [Select File] to choose a SQL Dump file." + Environment.NewLine + Environment.NewLine + Program.TargetFile, "Import", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return false;
			}
			return true;
		}

		// Token: 0x04000146 RID: 326
		private static string _connectionString = "";

		// Token: 0x04000147 RID: 327
		public static string DefaultFolder = "";

		// Token: 0x04000148 RID: 328
		public static string TargetFile = "";
	}
}
