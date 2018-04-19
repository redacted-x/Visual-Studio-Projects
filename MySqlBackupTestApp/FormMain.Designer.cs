namespace MySqlBackupTestApp
{
	// Token: 0x0200000E RID: 14
	public partial class FormMain : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x0000AFBC File Offset: 0x000091BC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000AFDC File Offset: 0x000091DC
		private void InitializeComponent()
		{
            this.textBox_Connection = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testBasicWithDefaultSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testCustomExportOfTablesAndRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareDumpFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseInfoViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpFileViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbAutosave = new System.Windows.Forms.CheckBox();
            this.textBox_File = new System.Windows.Forms.TextBox();
            this.button_ExportAs = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.button_SelectFile = new System.Windows.Forms.Button();
            this.ewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Connection
            // 
            this.textBox_Connection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Connection.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Connection.Location = new System.Drawing.Point(197, 8);
            this.textBox_Connection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Connection.Name = "textBox_Connection";
            this.textBox_Connection.Size = new System.Drawing.Size(552, 21);
            this.textBox_Connection.TabIndex = 0;
            this.textBox_Connection.TextChanged += new System.EventHandler(this.textBox_Connection_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 435);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testToolStripMenuItem1,
            this.testToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testBasicWithDefaultSettingsToolStripMenuItem,
            this.testCustomExportOfTablesAndRowsToolStripMenuItem});
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.testToolStripMenuItem1.Text = "Backup";
            // 
            // testBasicWithDefaultSettingsToolStripMenuItem
            // 
            this.testBasicWithDefaultSettingsToolStripMenuItem.Name = "testBasicWithDefaultSettingsToolStripMenuItem";
            this.testBasicWithDefaultSettingsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.testBasicWithDefaultSettingsToolStripMenuItem.Text = "Basic with Default Settings";
            this.testBasicWithDefaultSettingsToolStripMenuItem.Click += new System.EventHandler(this.testBasicWithDefaultSettingsToolStripMenuItem_Click);
            // 
            // testCustomExportOfTablesAndRowsToolStripMenuItem
            // 
            this.testCustomExportOfTablesAndRowsToolStripMenuItem.Name = "testCustomExportOfTablesAndRowsToolStripMenuItem";
            this.testCustomExportOfTablesAndRowsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.testCustomExportOfTablesAndRowsToolStripMenuItem.Text = "Custom Export of Tables and Rows";
            this.testCustomExportOfTablesAndRowsToolStripMenuItem.Click += new System.EventHandler(this.testCustomExportOfTablesAndRowsToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryBrowserToolStripMenuItem,
            this.compareDumpFilesToolStripMenuItem,
            this.databaseInfoViewerToolStripMenuItem,
            this.dumpFileViewerToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.testToolStripMenuItem.Text = "Tools";
            // 
            // queryBrowserToolStripMenuItem
            // 
            this.queryBrowserToolStripMenuItem.Name = "queryBrowserToolStripMenuItem";
            this.queryBrowserToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.queryBrowserToolStripMenuItem.Text = "Query Browser";
            this.queryBrowserToolStripMenuItem.Click += new System.EventHandler(this.queryBrowserToolStripMenuItem_Click);
            // 
            // compareDumpFilesToolStripMenuItem
            // 
            this.compareDumpFilesToolStripMenuItem.Name = "compareDumpFilesToolStripMenuItem";
            this.compareDumpFilesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.compareDumpFilesToolStripMenuItem.Text = "Compare Dump Files";
            this.compareDumpFilesToolStripMenuItem.Click += new System.EventHandler(this.compareDumpFilesToolStripMenuItem_Click);
            // 
            // databaseInfoViewerToolStripMenuItem
            // 
            this.databaseInfoViewerToolStripMenuItem.Name = "databaseInfoViewerToolStripMenuItem";
            this.databaseInfoViewerToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.databaseInfoViewerToolStripMenuItem.Text = "Database Info Viewer";
            this.databaseInfoViewerToolStripMenuItem.Click += new System.EventHandler(this.databaseInfoViewerToolStripMenuItem_Click);
            // 
            // dumpFileViewerToolStripMenuItem
            // 
            this.dumpFileViewerToolStripMenuItem.Name = "dumpFileViewerToolStripMenuItem";
            this.dumpFileViewerToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dumpFileViewerToolStripMenuItem.Text = "Dump File Viewer";
            this.dumpFileViewerToolStripMenuItem.Click += new System.EventHandler(this.dumpFileViewerToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbAutosave);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_File);
            this.splitContainer1.Panel1.Controls.Add(this.button_ExportAs);
            this.splitContainer1.Panel1.Controls.Add(this.button_View);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button_SelectFile);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Connection);
            this.splitContainer1.Panel1MinSize = 80;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(764, 518);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 5;
            // 
            // cbAutosave
            // 
            this.cbAutosave.AutoSize = true;
            this.cbAutosave.Location = new System.Drawing.Point(117, 10);
            this.cbAutosave.Name = "cbAutosave";
            this.cbAutosave.Size = new System.Drawing.Size(79, 19);
            this.cbAutosave.TabIndex = 5;
            this.cbAutosave.Text = "Auto Save";
            this.cbAutosave.UseVisualStyleBackColor = true;
            this.cbAutosave.CheckedChanged += new System.EventHandler(this.cbAutosave_CheckedChanged);
            // 
            // textBox_File
            // 
            this.textBox_File.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_File.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_File.Location = new System.Drawing.Point(182, 45);
            this.textBox_File.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_File.Name = "textBox_File";
            this.textBox_File.Size = new System.Drawing.Size(567, 21);
            this.textBox_File.TabIndex = 4;
            this.textBox_File.TextChanged += new System.EventHandler(this.textBox_File_TextChanged);
            // 
            // button_ExportAs
            // 
            this.button_ExportAs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExportAs.Location = new System.Drawing.Point(7, 36);
            this.button_ExportAs.Name = "button_ExportAs";
            this.button_ExportAs.Size = new System.Drawing.Size(48, 38);
            this.button_ExportAs.TabIndex = 3;
            this.button_ExportAs.Text = "Export As";
            this.button_ExportAs.UseVisualStyleBackColor = true;
            this.button_ExportAs.Click += new System.EventHandler(this.button_ExportAs_Click);
            // 
            // button_View
            // 
            this.button_View.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View.Location = new System.Drawing.Point(116, 36);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(59, 38);
            this.button_View.TabIndex = 2;
            this.button_View.Text = "View Content";
            this.button_View.UseVisualStyleBackColor = true;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // button_SelectFile
            // 
            this.button_SelectFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectFile.Location = new System.Drawing.Point(61, 36);
            this.button_SelectFile.Name = "button_SelectFile";
            this.button_SelectFile.Size = new System.Drawing.Size(49, 38);
            this.button_SelectFile.TabIndex = 0;
            this.button_SelectFile.Text = "Select File";
            this.button_SelectFile.UseVisualStyleBackColor = true;
            this.button_SelectFile.Click += new System.EventHandler(this.button_SelectFile_Click);
            // 
            // ewToolStripMenuItem
            // 
            this.ewToolStripMenuItem.Name = "ewToolStripMenuItem";
            this.ewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ewToolStripMenuItem.Text = "ew";
            // 
            // fewToolStripMenuItem
            // 
            this.fewToolStripMenuItem.Name = "fewToolStripMenuItem";
            this.fewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fewToolStripMenuItem.Text = "few";
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(764, 542);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Backup";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000096 RID: 150
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.TextBox textBox_Connection;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.TextBox textBox_File;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.Button button_ExportAs;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.Button button_View;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.Button button_SelectFile;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.ToolStripMenuItem compareDumpFilesToolStripMenuItem;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.ToolStripMenuItem databaseInfoViewerToolStripMenuItem;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.ToolStripMenuItem dumpFileViewerToolStripMenuItem;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.ToolStripMenuItem testBasicWithDefaultSettingsToolStripMenuItem;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.ToolStripMenuItem queryBrowserToolStripMenuItem;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.ToolStripMenuItem ewToolStripMenuItem;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.ToolStripMenuItem fewToolStripMenuItem;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.CheckBox cbAutosave;
        private System.Windows.Forms.ToolStripMenuItem testCustomExportOfTablesAndRowsToolStripMenuItem;
    }
}
