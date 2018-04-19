namespace MySqlBackupTestApp
{
	// Token: 0x02000010 RID: 16
	public partial class FormDumpFileViewer : global::System.Windows.Forms.Form
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x0000C752 File Offset: 0x0000A952
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000C774 File Offset: 0x0000A974
		private void InitializeComponent()
		{
			this.toolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.tsOpen = new global::System.Windows.Forms.ToolStripButton();
			this.tsSave = new global::System.Windows.Forms.ToolStripButton();
			this.tsSaveAs = new global::System.Windows.Forms.ToolStripButton();
			this.tsClose = new global::System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.tsStatus = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.tsFile = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tsOpen,
				this.tsSave,
				this.tsSaveAs,
				this.tsClose
			});
			this.toolStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new global::System.Drawing.Size(331, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			this.tsOpen.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsOpen.Image = global::MySqlBackupTestApp.Properties.Resources.folder;
			this.tsOpen.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.tsOpen.Name = "tsOpen";
			this.tsOpen.Size = new global::System.Drawing.Size(23, 22);
			this.tsOpen.Text = "toolStripButton1";
			this.tsOpen.ToolTipText = "Open";
			this.tsOpen.Click += new global::System.EventHandler(this.tsOpen_Click);
			this.tsSave.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsSave.Image = global::MySqlBackupTestApp.Properties.Resources.disk;
			this.tsSave.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.tsSave.Name = "tsSave";
			this.tsSave.Size = new global::System.Drawing.Size(23, 22);
			this.tsSave.Text = "toolStripButton2";
			this.tsSave.ToolTipText = "Save";
			this.tsSave.Click += new global::System.EventHandler(this.tsSave_Click);
			this.tsSaveAs.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsSaveAs.Image = global::MySqlBackupTestApp.Properties.Resources.disk_edit;
			this.tsSaveAs.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.tsSaveAs.Name = "tsSaveAs";
			this.tsSaveAs.Size = new global::System.Drawing.Size(23, 22);
			this.tsSaveAs.Text = "toolStripButton3";
			this.tsSaveAs.ToolTipText = "Save As...";
			this.tsSaveAs.Click += new global::System.EventHandler(this.tsSaveAs_Click);
			this.tsClose.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsClose.Image = global::MySqlBackupTestApp.Properties.Resources.bullet_cross;
			this.tsClose.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.tsClose.Name = "tsClose";
			this.tsClose.Size = new global::System.Drawing.Size(23, 22);
			this.tsClose.Text = "toolStripButton4";
			this.tsClose.ToolTipText = "Close";
			this.tsClose.Click += new global::System.EventHandler(this.tsClose_Click);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tsStatus,
				this.tsFile
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 280);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(331, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			this.tsStatus.Name = "tsStatus";
			this.tsStatus.Size = new global::System.Drawing.Size(0, 17);
			this.tsFile.Name = "tsFile";
			this.tsFile.Size = new global::System.Drawing.Size(0, 17);
			this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new global::System.Drawing.Point(0, 25);
			this.textBox1.MaxLength = 0;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new global::System.Drawing.Size(331, 255);
			this.textBox1.TabIndex = 4;
			this.textBox1.WordWrap = false;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Times New Roman", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(28, 59);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(163, 81);
			this.label1.TabIndex = 5;
			this.label1.Text = "Please wait...\r\n\r\nFile is loading...";
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			base.ClientSize = new global::System.Drawing.Size(331, 302);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.toolStrip1);
			this.Font = new global::System.Drawing.Font("Courier New", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Name = "FormDumpFileViewer";
			this.Text = "FormDumpFileViewer";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000C2 RID: 194
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.ToolStrip toolStrip1;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.ToolStripButton tsOpen;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.ToolStripButton tsSave;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.ToolStripStatusLabel tsStatus;

		// Token: 0x040000C8 RID: 200
		public global::System.Windows.Forms.ToolStripStatusLabel tsFile;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.ToolStripButton tsSaveAs;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.ToolStripButton tsClose;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Label label1;
	}
}
