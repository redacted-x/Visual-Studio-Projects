using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace MySqlBackupTestApp
{
	// Token: 0x02000018 RID: 24
	public class HtmlExpress
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00012308 File Offset: 0x00010508
		public static string ConvertDataTableToHtmlTable(DataTable dt)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<table>");
			stringBuilder.AppendLine("<tr>");
			stringBuilder.AppendFormat("\t", Array.Empty<object>());
			foreach (object obj in dt.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj;
				stringBuilder.AppendFormat("<td>", Array.Empty<object>());
				stringBuilder.AppendFormat(HtmlExpress.EscapeForHtml(dataColumn.ColumnName), Array.Empty<object>());
				stringBuilder.AppendFormat("</td>", Array.Empty<object>());
			}
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("</tr>");
			foreach (object obj2 in dt.Rows)
			{
				DataRow dataRow = (DataRow)obj2;
				stringBuilder.AppendFormat("<tr>", Array.Empty<object>());
				foreach (object obj3 in dt.Columns)
				{
					DataColumn dataColumn2 = (DataColumn)obj3;
					stringBuilder.AppendFormat("<td>", Array.Empty<object>());
					string input = QueryExpress.ConvertToSqlFormat(dataRow[dataColumn2.ColumnName], false, false, null);
					stringBuilder.AppendFormat(HtmlExpress.EscapeForHtml(input), Array.Empty<object>());
					stringBuilder.AppendFormat("</td>", Array.Empty<object>());
				}
				stringBuilder.AppendLine("</tr>");
			}
			stringBuilder.AppendLine("</table>");
			return stringBuilder.ToString();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000124E0 File Offset: 0x000106E0
		public static string EscapeForHtml(string input)
		{
			input = input.Replace("\r\n", "^||||^").Replace("\n", "^||||^").Replace("\r", "^||||^");
			StringBuilder stringBuilder = new StringBuilder();
			string text = input;
			int i = 0;
			while (i < text.Length)
			{
				char c = text[i];
				if (c <= '"')
				{
					if (c != '\t')
					{
						if (c != ' ')
						{
							if (c != '"')
							{
								goto IL_10B;
							}
							stringBuilder.AppendFormat("&quot;", Array.Empty<object>());
						}
						else
						{
							stringBuilder.AppendFormat("&nbsp;", Array.Empty<object>());
						}
					}
					else
					{
						stringBuilder.AppendFormat("&nbsp;&nbsp;&nbsp;&nbsp;", Array.Empty<object>());
					}
				}
				else if (c <= '\'')
				{
					if (c != '&')
					{
						if (c != '\'')
						{
							goto IL_10B;
						}
						stringBuilder.AppendFormat("&#39;", Array.Empty<object>());
					}
					else
					{
						stringBuilder.AppendFormat("&amp;", Array.Empty<object>());
					}
				}
				else if (c != '<')
				{
					if (c != '>')
					{
						goto IL_10B;
					}
					stringBuilder.AppendFormat("&gt;", Array.Empty<object>());
				}
				else
				{
					stringBuilder.AppendFormat("&lt;", Array.Empty<object>());
				}
				IL_113:
				i++;
				continue;
				IL_10B:
				stringBuilder.Append(c);
				goto IL_113;
			}
			return stringBuilder.ToString().Replace("^||||^", "<br />");
		}
	}
}
