namespace MySqlBackupTestApp
{
	// Token: 0x02000015 RID: 21
	public partial class FormTestSimple : global::System.Windows.Forms.Form
	{
		// Token: 0x060000DD RID: 221 RVA: 0x0000F708 File Offset: 0x0000D908
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000F728 File Offset: 0x0000D928
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.btExport = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup / Restore\r\nExecute with Default Settings\r\n";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(34, 89);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(189, 31);
            this.btExport.TabIndex = 1;
            this.btExport.Text = "Backup / Export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(34, 139);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(189, 31);
            this.btImport.TabIndex = 2;
            this.btImport.Text = "Restore / Import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btInfo
            // 
            this.btInfo.Image = global::MySqlBackupTestApp.Properties.Resources.q2;
            this.btInfo.Location = new System.Drawing.Point(700, 12);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(36, 36);
            this.btInfo.TabIndex = 13;
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // FormTestSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 479);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTestSimple";
            this.Text = "FormTestSimple";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000111 RID: 273
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.Button btExport;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Button btInfo;
    }
}
