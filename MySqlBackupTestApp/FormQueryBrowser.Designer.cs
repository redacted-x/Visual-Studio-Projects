namespace MySqlBackupTestApp
{
	// Token: 0x02000007 RID: 7
	public partial class FormQueryBrowser : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003D RID: 61 RVA: 0x000051E0 File Offset: 0x000033E0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005200 File Offset: 0x00003400
		private void InitializeComponent()
		{
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.btSQL = new global::System.Windows.Forms.Button();
			this.btScript = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.webBrowser1 = new global::System.Windows.Forms.WebBrowser();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = global::System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
			this.splitContainer1.Size = new global::System.Drawing.Size(576, 475);
			this.splitContainer1.SplitterDistance = 138;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 0;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(576, 138);
			this.tableLayoutPanel1.TabIndex = 2;
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new global::System.Drawing.Font("Courier New", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.Location = new global::System.Drawing.Point(3, 42);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new global::System.Drawing.Size(570, 93);
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.btSQL);
			this.flowLayoutPanel1.Controls.Add(this.btScript);
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new global::System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new global::System.Drawing.Size(570, 33);
			this.flowLayoutPanel1.TabIndex = 2;
			this.btSQL.Location = new global::System.Drawing.Point(3, 3);
			this.btSQL.Name = "btSQL";
			this.btSQL.Size = new global::System.Drawing.Size(105, 27);
			this.btSQL.TabIndex = 0;
			this.btSQL.Text = "Execute SQL";
			this.btSQL.UseVisualStyleBackColor = true;
			this.btSQL.Click += new global::System.EventHandler(this.btSQL_Click);
			this.btScript.Location = new global::System.Drawing.Point(114, 3);
			this.btScript.Name = "btScript";
			this.btScript.Size = new global::System.Drawing.Size(105, 27);
			this.btScript.TabIndex = 1;
			this.btScript.Text = "Execute Script";
			this.btScript.UseVisualStyleBackColor = true;
			this.btScript.Click += new global::System.EventHandler(this.btScript_Click);
			this.label1.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(225, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(246, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "[Ctrl] + [Enter] = Execute SQL,  [ESC] = Clear";
			this.webBrowser1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new global::System.Drawing.Point(0, 0);
			this.webBrowser1.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new global::System.Drawing.Size(576, 310);
			this.webBrowser1.TabIndex = 1;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			base.ClientSize = new global::System.Drawing.Size(576, 475);
			base.Controls.Add(this.splitContainer1);
			this.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Name = "FormQueryBrowser";
			this.Text = "FormQueryBrowser";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400002B RID: 43
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Button btSQL;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Button btScript;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.WebBrowser webBrowser1;
	}
}
