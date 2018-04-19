using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlBackupTestApp
{
	// Token: 0x0200000D RID: 13
	public partial class FormDatabaseInfo : Form
	{
		// Token: 0x06000066 RID: 102 RVA: 0x0000966C File Offset: 0x0000786C
		public FormDatabaseInfo()
		{
			this.timer1 = new Timer();
			this.timer1.Interval = 100;
			this.timer1.Tick += this.timer1_Tick;
			this.bw = new BackgroundWorker();
			this.bw.RunWorkerCompleted += this.bw_RunWorkerCompleted;
			this.bw.DoWork += this.bw_DoWork;
			this.InitializeComponent();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000096F0 File Offset: 0x000078F0
		private void bw_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				this.Start();
			}
			catch (Exception ex)
			{
				this.WriteError(ex.Message);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00009724 File Offset: 0x00007924
		private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.webBrowser1.DocumentText = this.sb.ToString();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000973C File Offset: 0x0000793C
		private void Start()
		{
			this.sb = new StringBuilder();
			this.sb.AppendLine("<html><head><style>h1 { line-height:160%; font-size: 20pt; } h2 { line-height:160%; font-size: 14pt; } body { font-family: \"Segoe UI\", Arial; line-height: 150%; } table { border: 1px solid #5C5C5C; border-collapse: collapse; } td { font-size: 10pt; padding: 4px; border: 1px solid #5C5C5C; } .code { font-family: \"Courier New\"; font-size: 10pt; line-height:110%; } </style></head>");
			this.sb.AppendLine("<body>");
			using (MySqlConnection mySqlConnection = new MySqlConnection(Program.ConnectionString))
			{
				try
				{
					mySqlConnection.Open();
					this.cmd = new MySqlCommand();
					this.cmd.Connection = mySqlConnection;
					this.myDatabase = new MySqlDatabase();
					this.myDatabase.GetDatabaseInfo(this.cmd, true);
					this.myServer = new MySqlServer();
					this.myServer.GetServerInfo(this.cmd);
					for (int i = 1; i < 13; i++)
					{
						try
						{
							switch (i)
							{
							case 1:
								this.LoadDatabase();
								break;
							case 2:
								this.LoadUser();
								break;
							case 3:
								this.LoadGlobalPrivilege();
								break;
							case 4:
								this.LoadViewPrivilege();
								break;
							case 5:
								this.LoadFunctionPrivilege();
								break;
							case 6:
								this.LoadVariables();
								break;
							case 7:
								this.LoadTables();
								break;
							case 8:
								this.LoadFunctions();
								break;
							case 9:
								this.LoadProcedures();
								break;
							case 10:
								this.LoadTriggers();
								break;
							case 11:
								this.LoadViews();
								break;
							case 12:
								this.LoadEvents();
								break;
							}
						}
						catch (Exception ex)
						{
							this.WriteError(ex.Message);
						}
					}
					mySqlConnection.Close();
				}
				catch (Exception ex2)
				{
					this.WriteError(ex2.Message);
				}
			}
			this.sb.Append("</body>");
			this.sb.Append("</html>");
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00009924 File Offset: 0x00007B24
		private void LoadDatabase()
		{
			this.WriteHead1("Database");
			this.WriteCodeBlock(this.myDatabase.CreateDatabaseSQL);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00009944 File Offset: 0x00007B44
		private void LoadUser()
		{
			this.WriteHead1("User");
			string text = "SELECT current_user;";
			this.WriteCodeBlock(text);
			this.WriteCodeBlock(this.myServer.CurrentUserClientHost);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000997C File Offset: 0x00007B7C
		private void LoadGlobalPrivilege()
		{
			this.WriteHead2("Global Privileges");
			string str = "";
			if (this.myServer.CurrentUser != "root")
			{
				str = this.myServer.CurrentUser;
			}
			else
			{
				this.WriteText("Current user is \"root\". All privileges are granted by default.");
			}
			string text = "SELECT * FROM mysql.db WHERE `user` = '" + str + "';";
			DataTable table = QueryExpress.GetTable(this.cmd, text);
			this.WriteCodeBlock(text);
			this.WriteTable(table);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000099F8 File Offset: 0x00007BF8
		private void LoadViewPrivilege()
		{
			this.WriteHead2("Privileges of View");
			string text = "SELECT  mv.host `Host`,  mv.user `User`,\r\nCONCAT(mv.Db, '.', mv.Table_name) `Views`,\r\nREPLACE(mv.Table_priv, ',', ', ') AS `Privileges`\r\nFROM  mysql.tables_priv mv\r\nWHERE mv.Db = '" + this.myDatabase.Name + "' \r\nand mv.Table_name IN  \r\n(SELECT  DISTINCT v.table_name `views` FROM information_schema.views AS v) \r\nORDER BY  mv.Host,  mv.User,  mv.Db,  mv.Table_name;";
			DataTable table = QueryExpress.GetTable(this.cmd, text);
			this.WriteCodeBlock(text);
			this.WriteTable(table);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00009A48 File Offset: 0x00007C48
		private void LoadProcedurePrivilege()
		{
			this.WriteHead2("Privileges of Procedure");
			string text = "SELECT  mp.host `Host`,  mp.user `User`,\r\nCONCAT(mp.Db, '.', mp.Routine_name) `Procedures`,\r\nREPLACE(mp.Proc_priv, ',', ', ') AS `Privileges`\r\nFROM  mysql.procs_priv mp\r\nWHERE mp.Db = '" + this.myDatabase.Name + "' \r\nand mp.Routine_type = 'PROCEDURE' \r\nORDER BY  mp.Host,  mp.User,  mp.Db,  mp.Routine_name;";
			DataTable table = QueryExpress.GetTable(this.cmd, text);
			this.WriteCodeBlock(text);
			this.WriteTable(table);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00009A98 File Offset: 0x00007C98
		private void LoadFunctionPrivilege()
		{
			this.WriteHead2("Privileges of Function");
			string text = "SELECT  mf.host `Host`,  mf.user `User`,\r\nCONCAT(mf.Db, '.', mf.Routine_name) `Procedures`,\r\nREPLACE(mf.Proc_priv, ',', ', ') AS `Privileges`\r\nFROM  mysql.procs_priv mf WHERE mf.Db = '" + this.myDatabase.Name + "'\r\nand mf.Routine_type = 'FUNCTION' \r\nORDER BY  mf.Host,  mf.User,  mf.Db,  mf.Routine_name;";
			DataTable table = QueryExpress.GetTable(this.cmd, text);
			this.WriteCodeBlock(text);
			this.WriteTable(table);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00009AE8 File Offset: 0x00007CE8
		private void LoadVariables()
		{
			this.WriteHead1("System Variables");
			string text = "SHOW variables;";
			DataTable table = QueryExpress.GetTable(this.cmd, text);
			this.WriteCodeBlock(text);
			this.WriteTable(table);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00009B24 File Offset: 0x00007D24
		private void LoadTables()
		{
			this.WriteHead1("Tables");
			this.WriteText("Note: Value of \"Rows\" shown below is not accurate. It is a cache value, it is not up to date. For accurate total rows count, please see the following next table.");
			string text = "SHOW TABLE STATUS;";
			DataTable table = QueryExpress.GetTable(this.cmd, text);
			this.WriteCodeBlock(text);
			this.WriteTable(table);
			this.WriteHead2("Actual Total Rows For Each Table");
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Table");
			dataTable.Columns.Add("Total Rows");
			foreach (MySqlTable mySqlTable in this.myDatabase.Tables)
			{
				dataTable.Rows.Add(new object[]
				{
					mySqlTable.Name,
					mySqlTable.TotalRows
				});
			}
			this.WriteTable(dataTable);
			foreach (MySqlTable mySqlTable2 in this.myDatabase.Tables)
			{
				this.WriteHead2(mySqlTable2.Name);
				this.WriteCodeBlock(mySqlTable2.Columns.SqlShowFullColumns);
				DataTable table2 = QueryExpress.GetTable(this.cmd, mySqlTable2.Columns.SqlShowFullColumns);
				this.WriteTable(table2);
				this.WriteText("Data Type in .NET Framework");
				DataTable dataTable2 = new DataTable();
				dataTable2.Columns.Add("Column Name");
				dataTable2.Columns.Add("MySQL Data Type");
				dataTable2.Columns.Add(".NET Data Type");
				foreach (MySqlColumn mySqlColumn in mySqlTable2.Columns)
				{
					dataTable2.Rows.Add(new object[]
					{
						mySqlColumn.Name,
						mySqlColumn.MySqlDataType,
						mySqlColumn.DataType.ToString()
					});
				}
				this.WriteTable(dataTable2);
				this.WriteCodeBlock("SHOW CREATE TABLE `" + mySqlTable2.Name + "`;");
				this.WriteCodeBlock(mySqlTable2.CreateTableSqlWithoutAutoIncrement);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00009D9C File Offset: 0x00007F9C
		private void LoadFunctions()
		{
			this.WriteHead1("Functions");
			this.WriteCodeBlock(this.myDatabase.Functions.SqlShowFunctions);
			DataTable table = QueryExpress.GetTable(this.cmd, this.myDatabase.Functions.SqlShowFunctions);
			this.WriteTable(table);
			this.WriteCodeBlock("SHOW CREATE FUNCTION `<name>`;");
			if (!this.myDatabase.Functions.AllowAccess)
			{
				this.WriteAccessDeniedErrMsg();
			}
			foreach (MySqlFunction mySqlFunction in this.myDatabase.Functions)
			{
				this.WriteHead2(mySqlFunction.Name);
				this.WriteCodeBlock(mySqlFunction.CreateFunctionSQLWithoutDefiner);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00009E68 File Offset: 0x00008068
		private void LoadProcedures()
		{
			this.WriteHead1("Procedures");
			this.WriteCodeBlock(this.myDatabase.Procedures.SqlShowProcedures);
			DataTable table = QueryExpress.GetTable(this.cmd, this.myDatabase.Procedures.SqlShowProcedures);
			this.WriteTable(table);
			this.WriteCodeBlock("SHOW CREATE PROCEDURE `<name>`;");
			if (!this.myDatabase.Procedures.AllowAccess)
			{
				this.WriteAccessDeniedErrMsg();
			}
			foreach (MySqlProcedure mySqlProcedure in this.myDatabase.Procedures)
			{
				this.WriteHead2(mySqlProcedure.Name);
				this.WriteCodeBlock(mySqlProcedure.CreateProcedureSQLWithoutDefiner);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00009F34 File Offset: 0x00008134
		private void LoadTriggers()
		{
			this.WriteHead1("Triggers");
			this.WriteCodeBlock(this.myDatabase.Triggers.SqlShowTriggers);
			DataTable table = QueryExpress.GetTable(this.cmd, this.myDatabase.Triggers.SqlShowTriggers);
			this.WriteTable(table);
			this.WriteCodeBlock("SHOW CREATE TRIGGER `<name>`;");
			if (!this.myDatabase.Triggers.AllowAccess)
			{
				this.WriteAccessDeniedErrMsg();
			}
			foreach (MySqlTrigger mySqlTrigger in this.myDatabase.Triggers)
			{
				this.WriteHead2(mySqlTrigger.Name);
				this.WriteCodeBlock(mySqlTrigger.CreateTriggerSQL);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000A000 File Offset: 0x00008200
		private void LoadViews()
		{
			this.WriteHead1("Views");
			this.WriteCodeBlock(this.myDatabase.Views.SqlShowViewList);
			DataTable table = QueryExpress.GetTable(this.cmd, this.myDatabase.Views.SqlShowViewList);
			this.WriteTable(table);
			this.WriteCodeBlock("SHOW CREATE VIEW `<name>`;");
			if (!this.myDatabase.Views.AllowAccess)
			{
				this.WriteAccessDeniedErrMsg();
			}
			foreach (MySqlView mySqlView in this.myDatabase.Views)
			{
				this.WriteHead2(mySqlView.Name);
				this.WriteCodeBlock(mySqlView.CreateViewSQL);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000A0CC File Offset: 0x000082CC
		private void LoadEvents()
		{
			this.WriteHead1("Events");
			this.WriteCodeBlock(this.myDatabase.Events.SqlShowEvent);
			DataTable table = QueryExpress.GetTable(this.cmd, this.myDatabase.Events.SqlShowEvent);
			this.WriteTable(table);
			this.WriteCodeBlock("SHOW CREATE EVENT `<name>`;");
			if (!this.myDatabase.Events.AllowAccess)
			{
				this.WriteAccessDeniedErrMsg();
			}
			foreach (MySqlEvent mySqlEvent in this.myDatabase.Events)
			{
				this.WriteHead2(mySqlEvent.Name);
				this.WriteCodeBlock(mySqlEvent.CreateEventSql);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000A198 File Offset: 0x00008398
		private void WriteHead1(string text)
		{
			this.sb.Append("<h1>");
			this.sb.Append(this.GetHtmlString(text.Trim()));
			this.sb.AppendLine("</h1>");
			this.sb.AppendLine("<hr />");
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000A1F0 File Offset: 0x000083F0
		private void WriteHead2(string text)
		{
			this.sb.Append("<h2>");
			this.sb.Append(this.GetHtmlString(text.Trim()));
			this.sb.AppendLine("</h2>");
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000A22C File Offset: 0x0000842C
		private void WriteText(string text)
		{
			this.sb.AppendLine("<p>");
			this.sb.AppendLine(this.GetHtmlString(text.Trim()));
			this.sb.AppendLine("</p>");
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000A268 File Offset: 0x00008468
		private void WriteCodeBlock(string text)
		{
			this.sb.AppendLine("<span class=\"code\">");
			this.sb.AppendLine(this.GetHtmlString(text.Trim()));
			this.sb.AppendLine("</span>");
			this.sb.AppendLine("<br /><br />");
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000A2C0 File Offset: 0x000084C0
		private void WriteTable(DataTable dt)
		{
			this.sb.AppendFormat(HtmlExpress.ConvertDataTableToHtmlTable(dt), Array.Empty<object>());
			this.sb.AppendLine("<br />");
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000A2EA File Offset: 0x000084EA
		private void WriteAccessDeniedErrMsg()
		{
			this.WriteError("Access denied for user " + this.myServer.CurrentUserClientHost);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000A308 File Offset: 0x00008508
		private void WriteError(string errMsg)
		{
			this.sb.AppendLine("<br />");
			this.sb.AppendLine("<div style=\"background-color: #FFE8E8; padding: 5px; border: 1px solid #FF0000;\">");
			this.sb.AppendLine("Error or Exception occured. Error message:<br />");
			this.sb.AppendLine(this.GetHtmlString(errMsg));
			this.sb.AppendLine("</div>");
			this.sb.AppendLine("<br />");
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000A380 File Offset: 0x00008580
		private string GetHtmlString(string input)
		{
			input = input.Replace("\r\n", "^||||^").Replace("\n", "^||||^").Replace("\r", "^||||^");
			StringBuilder stringBuilder = new StringBuilder();
			string text = input;
			int i = 0;
			while (i < text.Length)
			{
				char c = text[i];
				if (c <= '&')
				{
					if (c != '"')
					{
						if (c != '&')
						{
							goto IL_C8;
						}
						stringBuilder.AppendFormat("&amp;", Array.Empty<object>());
					}
					else
					{
						stringBuilder.AppendFormat("&quot;", Array.Empty<object>());
					}
				}
				else if (c != '\'')
				{
					if (c != '<')
					{
						if (c != '>')
						{
							goto IL_C8;
						}
						stringBuilder.AppendFormat("&gt;", Array.Empty<object>());
					}
					else
					{
						stringBuilder.AppendFormat("&lt;", Array.Empty<object>());
					}
				}
				else
				{
					stringBuilder.AppendFormat("&#39;", Array.Empty<object>());
				}
				IL_D0:
				i++;
				continue;
				IL_C8:
				stringBuilder.Append(c);
				goto IL_D0;
			}
			return stringBuilder.ToString().Replace("^||||^", "<br />");
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000A482 File Offset: 0x00008682
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.timer1.Stop();
			this.webBrowser1.DocumentText = "<h1>Database info is loading...<br />Please wait...</h1>";
			this.bw.RunWorkerAsync();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000A4AA File Offset: 0x000086AA
		private void FormDatabaseInfo_Load(object sender, EventArgs e)
		{
			this.timer1.Start();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000A4B8 File Offset: 0x000086B8
		private void btExport_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "HTML|*.html";
			saveFileDialog.FileName = this.myDatabase.Name + ".html";
			if (DialogResult.OK == saveFileDialog.ShowDialog())
			{
				File.WriteAllText(saveFileDialog.FileName, this.webBrowser1.DocumentText);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000A4AA File Offset: 0x000086AA
		private void btRefresh_Click(object sender, EventArgs e)
		{
			this.timer1.Start();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000A510 File Offset: 0x00008710
		private void btPrint_Click(object sender, EventArgs e)
		{
			this.webBrowser1.ShowPrintPreviewDialog();
		}

		// Token: 0x04000086 RID: 134
		private StringBuilder sb;

		// Token: 0x04000087 RID: 135
		private MySqlServer myServer;

		// Token: 0x04000088 RID: 136
		private MySqlDatabase myDatabase;

		// Token: 0x04000089 RID: 137
		private MySqlCommand cmd;

		// Token: 0x0400008A RID: 138
		private Timer timer1;

		// Token: 0x0400008B RID: 139
		private BackgroundWorker bw;
	}
}
