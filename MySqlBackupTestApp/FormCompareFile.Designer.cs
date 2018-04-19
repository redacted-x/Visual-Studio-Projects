namespace MySqlBackupTestApp
{
	// Token: 0x0200000C RID: 12
	public partial class FormCompareFile : global::System.Windows.Forms.Form
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00008FD4 File Offset: 0x000071D4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00008FF4 File Offset: 0x000071F4
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.button_OpenFile1 = new System.Windows.Forms.Button();
            this.button_OpenFile2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbFilePath1 = new System.Windows.Forms.Label();
            this.lbSHA1 = new System.Windows.Forms.Label();
            this.lbSHA2 = new System.Windows.Forms.Label();
            this.lbFilePath2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "SHA256 Checksum Dump Comparison";
            // 
            // button_OpenFile1
            // 
            this.button_OpenFile1.Location = new System.Drawing.Point(18, 39);
            this.button_OpenFile1.Name = "button_OpenFile1";
            this.button_OpenFile1.Size = new System.Drawing.Size(181, 27);
            this.button_OpenFile1.TabIndex = 4;
            this.button_OpenFile1.Text = "Open First Dump File";
            this.button_OpenFile1.UseVisualStyleBackColor = true;
            this.button_OpenFile1.Click += new System.EventHandler(this.button_OpenFile1_Click);
            // 
            // button_OpenFile2
            // 
            this.button_OpenFile2.Location = new System.Drawing.Point(19, 117);
            this.button_OpenFile2.Name = "button_OpenFile2";
            this.button_OpenFile2.Size = new System.Drawing.Size(181, 27);
            this.button_OpenFile2.TabIndex = 5;
            this.button_OpenFile2.Text = "Open Second Dump File";
            this.button_OpenFile2.UseVisualStyleBackColor = true;
            this.button_OpenFile2.Click += new System.EventHandler(this.button_OpenFile2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbResult);
            this.groupBox1.Location = new System.Drawing.Point(19, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(22, 37);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 24);
            this.lbResult.TabIndex = 0;
            // 
            // lbFilePath1
            // 
            this.lbFilePath1.AutoSize = true;
            this.lbFilePath1.Location = new System.Drawing.Point(30, 71);
            this.lbFilePath1.Name = "lbFilePath1";
            this.lbFilePath1.Size = new System.Drawing.Size(30, 15);
            this.lbFilePath1.TabIndex = 7;
            this.lbFilePath1.Text = "File:";
            // 
            // lbSHA1
            // 
            this.lbSHA1.AutoSize = true;
            this.lbSHA1.Location = new System.Drawing.Point(30, 94);
            this.lbSHA1.Name = "lbSHA1";
            this.lbSHA1.Size = new System.Drawing.Size(118, 15);
            this.lbSHA1.TabIndex = 8;
            this.lbSHA1.Text = "SHA256 Checksum:";
            // 
            // lbSHA2
            // 
            this.lbSHA2.AutoSize = true;
            this.lbSHA2.Location = new System.Drawing.Point(30, 177);
            this.lbSHA2.Name = "lbSHA2";
            this.lbSHA2.Size = new System.Drawing.Size(118, 15);
            this.lbSHA2.TabIndex = 10;
            this.lbSHA2.Text = "SHA256 Checksum:";
            // 
            // lbFilePath2
            // 
            this.lbFilePath2.AutoSize = true;
            this.lbFilePath2.Location = new System.Drawing.Point(30, 154);
            this.lbFilePath2.Name = "lbFilePath2";
            this.lbFilePath2.Size = new System.Drawing.Size(30, 15);
            this.lbFilePath2.TabIndex = 9;
            this.lbFilePath2.Text = "File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 60);
            this.label2.TabIndex = 11;
            this.label2.Text = "Note:\r\nDump the file with \"ExportInfo.RecordDumpTime = False\". \r\nThe \"Dump Time\" " +
    "will make the files different from each other.\r\nYou may manually the delete the " +
    "dump time info from the file.";
            // 
            // btInfo
            // 
            this.btInfo.Image = global::MySqlBackupTestApp.Properties.Resources.q2;
            this.btInfo.Location = new System.Drawing.Point(316, 12);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(35, 35);
            this.btInfo.TabIndex = 12;
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // FormCompareFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(557, 388);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSHA2);
            this.Controls.Add(this.lbFilePath2);
            this.Controls.Add(this.lbSHA1);
            this.Controls.Add(this.lbFilePath1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_OpenFile2);
            this.Controls.Add(this.button_OpenFile1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormCompareFile";
            this.Text = "FormCompareFile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400007A RID: 122
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Button button_OpenFile1;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Button button_OpenFile2;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Label lbResult;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.Label lbFilePath1;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label lbSHA1;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Label lbSHA2;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Label lbFilePath2;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Button btInfo;
	}
}
