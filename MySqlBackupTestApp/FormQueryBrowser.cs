using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlBackupTestApp
{
	// Token: 0x02000007 RID: 7
	public partial class FormQueryBrowser : Form
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00004E1A File Offset: 0x0000301A
		public FormQueryBrowser()
		{
			this.InitializeComponent();
			this.textBox1.Text = "SHOW TABLE STATUS;";
			this.ExecuteSQL(1);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004E4A File Offset: 0x0000304A
		private void btScript_Click(object sender, EventArgs e)
		{
			this.ExecuteSQL(2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004E53 File Offset: 0x00003053
		private void btSQL_Click(object sender, EventArgs e)
		{
			this.ExecuteSQL(1);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004E5C File Offset: 0x0000305C
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				this.textBox1.SelectAll();
				e.SuppressKeyPress = true;
				return;
			}
			if (e.Control && e.KeyCode == Keys.Return)
			{
				this.ExecuteSQL(1);
				e.SuppressKeyPress = true;
				return;
			}
			if (e.KeyCode == Keys.Escape)
			{
				this.textBox1.Clear();
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004ECC File Offset: 0x000030CC
		private void ExecuteSQL(int q)
		{
			try
			{
				using (MySqlConnection mySqlConnection = new MySqlConnection(Program.ConnectionString))
				{
					string text = this.textBox1.Text.Trim();
					if (q == 2)
					{
						int num = new MySqlScript(mySqlConnection)
						{
							Query = text
						}.Execute();
						this.dt = new DataTable();
						this.dt.Columns.Add("Result");
						this.dt.Rows.Add(new object[]
						{
							num + " statement(s) executed."
						});
						this.BindData();
					}
					else
					{
						if (text.StartsWith("select", StringComparison.OrdinalIgnoreCase) || text.StartsWith("show", StringComparison.OrdinalIgnoreCase))
						{
							if (text.StartsWith("select", StringComparison.OrdinalIgnoreCase) && !text.ToLower().Contains(" limit "))
							{
								if (text.EndsWith(";"))
								{
									text = text.Remove(text.Length - 1);
								}
								text += " LIMIT 0,3000;";
								this.textBox1.Text = text;
								this.textBox1.Refresh();
							}
							using (MySqlCommand mySqlCommand = new MySqlCommand())
							{
								mySqlCommand.Connection = mySqlConnection;
								mySqlConnection.Open();
								this.dt = QueryExpress.GetTable(mySqlCommand, text);
								this.BindData();
								goto IL_1C2;
							}
						}
						using (MySqlCommand mySqlCommand2 = new MySqlCommand())
						{
							mySqlCommand2.Connection = mySqlConnection;
							mySqlConnection.Open();
							mySqlCommand2.CommandText = text;
							int num2 = mySqlCommand2.ExecuteNonQuery();
							this.dt = new DataTable();
							this.dt.Columns.Add("Results");
							this.dt.Rows.Add(new object[]
							{
								num2 + " row(s) affected by the last command."
							});
							this.BindData();
						}
					}
					IL_1C2:;
				}
			}
			catch (Exception ex)
			{
				this.WriteError(ex);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000511C File Offset: 0x0000331C
		private void WriteError(Exception ex)
		{
			this.dt = new DataTable();
			this.dt.Columns.Add("Error");
			this.dt.Rows.Add(new object[]
			{
				ex.Message
			});
			this.BindData();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005170 File Offset: 0x00003370
		private void BindData()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<html><head><style>body { font-family: \"Segoe UI\", Arial; line-height: 150%; } table { border: 1px solid #5C5C5C; border-collapse: collapse; } td { font-size: 10pt; padding: 4px; border: 1px solid #5C5C5C; } </style></head>");
			stringBuilder.AppendLine("<body>");
			stringBuilder.AppendFormat(HtmlExpress.ConvertDataTableToHtmlTable(this.dt), Array.Empty<object>());
			stringBuilder.AppendLine("</body>");
			stringBuilder.AppendFormat("</html>", Array.Empty<object>());
			this.webBrowser1.DocumentText = stringBuilder.ToString();
		}

		// Token: 0x0400002A RID: 42
		private DataTable dt = new DataTable();
	}
}
