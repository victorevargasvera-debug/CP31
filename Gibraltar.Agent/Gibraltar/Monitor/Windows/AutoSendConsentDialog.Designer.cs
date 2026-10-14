namespace Gibraltar.Monitor.Windows
{
	// Token: 0x020001D9 RID: 473
	internal partial class AutoSendConsentDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06001697 RID: 5783 RVA: 0x00046D20 File Offset: 0x00044F20
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00046D48 File Offset: 0x00044F48
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Gibraltar.Monitor.Windows.AutoSendConsentDialog));
			this.buttonPanel = new global::System.Windows.Forms.Panel();
			this.lblButtonDivider = new global::System.Windows.Forms.Label();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.messageFlowLayout = new global::System.Windows.Forms.FlowLayoutPanel();
			this.lblCaption = new global::System.Windows.Forms.Label();
			this.lblDescription = new global::System.Windows.Forms.Label();
			this.linkPrivacyPolicy = new global::System.Windows.Forms.LinkLabel();
			this.optOptIn = new global::System.Windows.Forms.RadioButton();
			this.optOptOut = new global::System.Windows.Forms.RadioButton();
			this.buttonPanel.SuspendLayout();
			this.messageFlowLayout.SuspendLayout();
			base.SuspendLayout();
			this.buttonPanel.BackColor = global::System.Drawing.SystemColors.ButtonFace;
			this.buttonPanel.Controls.Add(this.lblButtonDivider);
			this.buttonPanel.Controls.Add(this.btnSave);
			this.buttonPanel.Controls.Add(this.btnCancel);
			this.buttonPanel.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.buttonPanel.Location = new global::System.Drawing.Point(0, 197);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.Size = new global::System.Drawing.Size(519, 50);
			this.buttonPanel.TabIndex = 1;
			this.lblButtonDivider.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblButtonDivider.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblButtonDivider.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.lblButtonDivider.Location = new global::System.Drawing.Point(0, 0);
			this.lblButtonDivider.Name = "lblButtonDivider";
			this.lblButtonDivider.Size = new global::System.Drawing.Size(519, 2);
			this.lblButtonDivider.TabIndex = 9;
			this.btnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSave.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new global::System.Drawing.Point(308, 9);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(117, 27);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save Changes";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(431, 9);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(76, 27);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.messageFlowLayout.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.messageFlowLayout.AutoSize = true;
			this.messageFlowLayout.Controls.Add(this.lblCaption);
			this.messageFlowLayout.Controls.Add(this.lblDescription);
			this.messageFlowLayout.Controls.Add(this.linkPrivacyPolicy);
			this.messageFlowLayout.Controls.Add(this.optOptIn);
			this.messageFlowLayout.Controls.Add(this.optOptOut);
			this.messageFlowLayout.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.messageFlowLayout.Location = new global::System.Drawing.Point(70, 12);
			this.messageFlowLayout.Margin = new global::System.Windows.Forms.Padding(12);
			this.messageFlowLayout.Name = "messageFlowLayout";
			this.messageFlowLayout.Size = new global::System.Drawing.Size(437, 171);
			this.messageFlowLayout.TabIndex = 4;
			this.messageFlowLayout.WrapContents = false;
			this.messageFlowLayout.Resize += new global::System.EventHandler(this.messageFlowLayout_Resize);
			this.lblCaption.AutoSize = true;
			this.lblCaption.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCaption.ForeColor = global::System.Drawing.SystemColors.HotTrack;
			this.lblCaption.Location = new global::System.Drawing.Point(0, 0);
			this.lblCaption.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 6);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new global::System.Drawing.Size(214, 20);
			this.lblCaption.TabIndex = 2;
			this.lblCaption.Text = "Help Improve {ProductName}";
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new global::System.Drawing.Point(0, 26);
			this.lblDescription.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 6);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new global::System.Drawing.Size(437, 52);
			this.lblDescription.TabIndex = 3;
			this.lblDescription.Text = componentResourceManager.GetString("lblDescription.Text");
			this.linkPrivacyPolicy.ActiveLinkColor = global::System.Drawing.Color.Black;
			this.linkPrivacyPolicy.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.linkPrivacyPolicy.AutoSize = true;
			this.linkPrivacyPolicy.LinkColor = global::System.Drawing.SystemColors.HotTrack;
			this.linkPrivacyPolicy.Location = new global::System.Drawing.Point(0, 93);
			this.linkPrivacyPolicy.Margin = new global::System.Windows.Forms.Padding(0, 9, 0, 0);
			this.linkPrivacyPolicy.Name = "linkPrivacyPolicy";
			this.linkPrivacyPolicy.Size = new global::System.Drawing.Size(437, 13);
			this.linkPrivacyPolicy.TabIndex = 9;
			this.linkPrivacyPolicy.TabStop = true;
			this.linkPrivacyPolicy.Text = "Read more about the {CeipName} online";
			this.linkPrivacyPolicy.VisitedLinkColor = global::System.Drawing.SystemColors.HotTrack;
			this.linkPrivacyPolicy.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrivacyPolicy_LinkClicked);
			this.optOptIn.AutoSize = true;
			this.optOptIn.Location = new global::System.Drawing.Point(21, 115);
			this.optOptIn.Margin = new global::System.Windows.Forms.Padding(21, 9, 0, 3);
			this.optOptIn.Name = "optOptIn";
			this.optOptIn.Size = new global::System.Drawing.Size(215, 17);
			this.optOptIn.TabIndex = 10;
			this.optOptIn.TabStop = true;
			this.optOptIn.Text = "Yes, I want to participate in the program.";
			this.optOptIn.UseVisualStyleBackColor = true;
			this.optOptIn.CheckedChanged += new global::System.EventHandler(this.optOptIn_CheckedChanged);
			this.optOptOut.AutoSize = true;
			this.optOptOut.Location = new global::System.Drawing.Point(21, 138);
			this.optOptOut.Margin = new global::System.Windows.Forms.Padding(21, 3, 0, 3);
			this.optOptOut.Name = "optOptOut";
			this.optOptOut.Size = new global::System.Drawing.Size(237, 17);
			this.optOptOut.TabIndex = 11;
			this.optOptOut.TabStop = true;
			this.optOptOut.Text = "No, I don't want to participate in the program.";
			this.optOptOut.UseVisualStyleBackColor = true;
			this.optOptOut.CheckedChanged += new global::System.EventHandler(this.optOptOut_CheckedChanged);
			base.AcceptButton = this.btnSave;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = global::System.Drawing.SystemColors.Window;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(519, 247);
			base.Controls.Add(this.messageFlowLayout);
			base.Controls.Add(this.buttonPanel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AutoSendConsentDialog";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "{CeipName}";
			this.buttonPanel.ResumeLayout(false);
			this.messageFlowLayout.ResumeLayout(false);
			this.messageFlowLayout.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400077C RID: 1916
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400077D RID: 1917
		private global::System.Windows.Forms.Panel buttonPanel;

		// Token: 0x0400077E RID: 1918
		private global::System.Windows.Forms.Label lblButtonDivider;

		// Token: 0x0400077F RID: 1919
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000780 RID: 1920
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000781 RID: 1921
		private global::System.Windows.Forms.FlowLayoutPanel messageFlowLayout;

		// Token: 0x04000782 RID: 1922
		private global::System.Windows.Forms.Label lblCaption;

		// Token: 0x04000783 RID: 1923
		private global::System.Windows.Forms.Label lblDescription;

		// Token: 0x04000784 RID: 1924
		private global::System.Windows.Forms.LinkLabel linkPrivacyPolicy;

		// Token: 0x04000785 RID: 1925
		private global::System.Windows.Forms.RadioButton optOptIn;

		// Token: 0x04000786 RID: 1926
		private global::System.Windows.Forms.RadioButton optOptOut;
	}
}
