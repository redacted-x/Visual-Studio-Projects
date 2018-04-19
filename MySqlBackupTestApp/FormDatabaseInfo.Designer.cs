namespace MySqlBackupTestApp
{
	// Token: 0x0200000D RID: 13
	public partial class FormDatabaseInfo : global::System.Windows.Forms.Form
	{
		// Token: 0x06000084 RID: 132 RVA: 0x0000A51D File Offset: 0x0000871D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000A53C File Offset: 0x0000873C
		private void InitializeComponent()
		{
			this.webBrowser1 = new global::System.Windows.Forms.WebBrowser();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.btRefresh = new global::System.Windows.Forms.Button();
			this.btExport = new global::System.Windows.Forms.Button();
			this.btPrint = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.webBrowser1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new global::System.Drawing.Point(3, 38);
			this.webBrowser1.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScriptErrorsSuppressed = true;
			this.webBrowser1.Size = new global::System.Drawing.Size(495, 245);
			this.webBrowser1.TabIndex = 0;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 1);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(501, 286);
			this.tableLayoutPanel1.TabIndex = 1;
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.btRefresh);
			this.flowLayoutPanel1.Controls.Add(this.btExport);
			this.flowLayoutPanel1.Controls.Add(this.btPrint);
			this.flowLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new global::System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new global::System.Drawing.Size(495, 29);
			this.flowLayoutPanel1.TabIndex = 2;
			this.btRefresh.Location = new global::System.Drawing.Point(3, 3);
			this.btRefresh.Name = "btRefresh";
			this.btRefresh.Size = new global::System.Drawing.Size(145, 23);
			this.btRefresh.TabIndex = 1;
			this.btRefresh.Text = "Refresh / Reload";
			this.btRefresh.UseVisualStyleBackColor = true;
			this.btRefresh.Click += new global::System.EventHandler(this.btRefresh_Click);
			this.btExport.Location = new global::System.Drawing.Point(154, 3);
			this.btExport.Name = "btExport";
			this.btExport.Size = new global::System.Drawing.Size(145, 23);
			this.btExport.TabIndex = 2;
			this.btExport.Text = "Save as HTML File";
			this.btExport.UseVisualStyleBackColor = true;
			this.btExport.Click += new global::System.EventHandler(this.btExport_Click);
			this.btPrint.Location = new global::System.Drawing.Point(305, 3);
			this.btPrint.Name = "btPrint";
			this.btPrint.Size = new global::System.Drawing.Size(75, 23);
			this.btPrint.TabIndex = 3;
			this.btPrint.Text = "Print";
			this.btPrint.UseVisualStyleBackColor = true;
			this.btPrint.Click += new global::System.EventHandler(this.btPrint_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(501, 286);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Name = "FormDatabaseInfo";
			this.Text = "FormDatabaseInfo";
			base.Load += new global::System.EventHandler(this.FormDatabaseInfo_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400008C RID: 140
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.WebBrowser webBrowser1;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Button btRefresh;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Button btExport;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Button btPrint;
	}
}
