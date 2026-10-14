namespace Gibraltar.Windows.UI
{
	// Token: 0x02000171 RID: 369
	internal partial class UIWizardDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000F52 RID: 3922 RVA: 0x00027BB0 File Offset: 0x00025DB0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00027BD8 File Offset: 0x00025DD8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.headerDisplayPanel = new global::System.Windows.Forms.Panel();
			this.pageHeaderPicture = new global::System.Windows.Forms.PictureBox();
			this.lblStepDescription = new global::System.Windows.Forms.Label();
			this.lblStepCaption = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnPrevious = new global::System.Windows.Forms.Button();
			this.btnNext = new global::System.Windows.Forms.Button();
			this.wizardDisplayPanel = new global::System.Windows.Forms.Panel();
			this.lblDivider = new global::System.Windows.Forms.Label();
			this.footerPanel = new global::System.Windows.Forms.Panel();
			this.lblDivider2 = new global::System.Windows.Forms.Label();
			this.tmrAutoClose = new global::System.Windows.Forms.Timer(this.components);
			this.headTableLayoutPanel = new global::System.Windows.Forms.TableLayoutPanel();
			this.headerDisplayPanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pageHeaderPicture).BeginInit();
			this.wizardDisplayPanel.SuspendLayout();
			this.footerPanel.SuspendLayout();
			this.headTableLayoutPanel.SuspendLayout();
			base.SuspendLayout();
			this.headerDisplayPanel.BackColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.headerDisplayPanel.Controls.Add(this.lblStepDescription);
			this.headerDisplayPanel.Controls.Add(this.lblStepCaption);
			this.headerDisplayPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.headerDisplayPanel.Location = new global::System.Drawing.Point(0, 0);
			this.headerDisplayPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.headerDisplayPanel.Name = "headerDisplayPanel";
			this.headerDisplayPanel.Padding = new global::System.Windows.Forms.Padding(10);
			this.headerDisplayPanel.Size = new global::System.Drawing.Size(430, 75);
			this.headerDisplayPanel.TabIndex = 5;
			this.pageHeaderPicture.Location = new global::System.Drawing.Point(433, 10);
			this.pageHeaderPicture.Margin = new global::System.Windows.Forms.Padding(3, 10, 3, 3);
			this.pageHeaderPicture.Name = "pageHeaderPicture";
			this.pageHeaderPicture.Size = new global::System.Drawing.Size(56, 56);
			this.pageHeaderPicture.TabIndex = 2;
			this.pageHeaderPicture.TabStop = false;
			this.lblStepDescription.Location = new global::System.Drawing.Point(30, 30);
			this.lblStepDescription.Name = "lblStepDescription";
			this.lblStepDescription.Size = new global::System.Drawing.Size(393, 30);
			this.lblStepDescription.TabIndex = 1;
			this.lblStepDescription.Text = "[Long Step Description Goes Here]";
			this.lblStepCaption.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblStepCaption.Location = new global::System.Drawing.Point(13, 13);
			this.lblStepCaption.Name = "lblStepCaption";
			this.lblStepCaption.Size = new global::System.Drawing.Size(410, 17);
			this.lblStepCaption.TabIndex = 0;
			this.lblStepCaption.Text = "[Step Caption Goes Here]";
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(418, 14);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(70, 22);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnPrevious.Location = new global::System.Drawing.Point(256, 14);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new global::System.Drawing.Size(70, 22);
			this.btnPrevious.TabIndex = 0;
			this.btnPrevious.Text = "< &Back";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new global::System.EventHandler(this.btnPrevious_Click);
			this.btnNext.Location = new global::System.Drawing.Point(332, 14);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new global::System.Drawing.Size(70, 22);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "&Next >";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new global::System.EventHandler(this.btnNext_Click);
			this.wizardDisplayPanel.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.wizardDisplayPanel.Controls.Add(this.lblDivider);
			this.wizardDisplayPanel.Location = new global::System.Drawing.Point(0, 75);
			this.wizardDisplayPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.wizardDisplayPanel.Name = "wizardDisplayPanel";
			this.wizardDisplayPanel.Padding = new global::System.Windows.Forms.Padding(30, 10, 30, 10);
			this.wizardDisplayPanel.Size = new global::System.Drawing.Size(500, 257);
			this.wizardDisplayPanel.TabIndex = 3;
			this.lblDivider.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDivider.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.lblDivider.Location = new global::System.Drawing.Point(0, 0);
			this.lblDivider.Name = "lblDivider";
			this.lblDivider.Size = new global::System.Drawing.Size(500, 2);
			this.lblDivider.TabIndex = 0;
			this.footerPanel.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.footerPanel.Controls.Add(this.lblDivider2);
			this.footerPanel.Controls.Add(this.btnCancel);
			this.footerPanel.Controls.Add(this.btnNext);
			this.footerPanel.Controls.Add(this.btnPrevious);
			this.footerPanel.Location = new global::System.Drawing.Point(0, 332);
			this.footerPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.footerPanel.Name = "footerPanel";
			this.footerPanel.Size = new global::System.Drawing.Size(500, 50);
			this.footerPanel.TabIndex = 6;
			this.lblDivider2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDivider2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.lblDivider2.Location = new global::System.Drawing.Point(0, 0);
			this.lblDivider2.Name = "lblDivider2";
			this.lblDivider2.Size = new global::System.Drawing.Size(500, 2);
			this.lblDivider2.TabIndex = 5;
			this.tmrAutoClose.Interval = 1200;
			this.tmrAutoClose.Tick += new global::System.EventHandler(this.tmrAutoClose_Tick);
			this.headTableLayoutPanel.BackColor = global::System.Drawing.Color.White;
			this.headTableLayoutPanel.ColumnCount = 2;
			this.headTableLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 86.37274f));
			this.headTableLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 13.62725f));
			this.headTableLayoutPanel.Controls.Add(this.headerDisplayPanel, 0, 0);
			this.headTableLayoutPanel.Controls.Add(this.pageHeaderPicture, 1, 0);
			this.headTableLayoutPanel.Location = new global::System.Drawing.Point(0, 0);
			this.headTableLayoutPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.headTableLayoutPanel.Name = "headTableLayoutPanel";
			this.headTableLayoutPanel.RowCount = 1;
			this.headTableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.headTableLayoutPanel.Size = new global::System.Drawing.Size(499, 75);
			this.headTableLayoutPanel.TabIndex = 1;
			base.AcceptButton = this.btnNext;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(500, 382);
			base.Controls.Add(this.headTableLayoutPanel);
			base.Controls.Add(this.footerPanel);
			base.Controls.Add(this.wizardDisplayPanel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UIWizardDialog";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Standard Wizard Dialog";
			base.TopMost = true;
			this.headerDisplayPanel.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pageHeaderPicture).EndInit();
			this.wizardDisplayPanel.ResumeLayout(false);
			this.footerPanel.ResumeLayout(false);
			this.headTableLayoutPanel.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400051E RID: 1310
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400051F RID: 1311
		private global::System.Windows.Forms.Button btnPrevious;

		// Token: 0x04000520 RID: 1312
		private global::System.Windows.Forms.Button btnNext;

		// Token: 0x04000521 RID: 1313
		private global::System.Windows.Forms.Panel wizardDisplayPanel;

		// Token: 0x04000522 RID: 1314
		private global::System.Windows.Forms.Panel headerDisplayPanel;

		// Token: 0x04000523 RID: 1315
		private global::System.Windows.Forms.Label lblStepDescription;

		// Token: 0x04000524 RID: 1316
		private global::System.Windows.Forms.Label lblStepCaption;

		// Token: 0x04000525 RID: 1317
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000526 RID: 1318
		private global::System.Windows.Forms.Panel footerPanel;

		// Token: 0x04000527 RID: 1319
		private global::System.Windows.Forms.Label lblDivider;

		// Token: 0x04000528 RID: 1320
		private global::System.Windows.Forms.Label lblDivider2;

		// Token: 0x04000529 RID: 1321
		private global::System.Windows.Forms.Timer tmrAutoClose;

		// Token: 0x0400052A RID: 1322
		protected global::System.Windows.Forms.PictureBox pageHeaderPicture;

		// Token: 0x0400052B RID: 1323
		private global::System.Windows.Forms.TableLayoutPanel headTableLayoutPanel;
	}
}
