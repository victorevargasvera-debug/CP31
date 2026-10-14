namespace DevAge.Windows.Forms
{
	// Token: 0x020002FB RID: 763
	internal partial class ErrorDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x0600247D RID: 9341 RVA: 0x0007F16C File Offset: 0x0007D36C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x0007F194 File Offset: 0x0007D394
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::DevAge.Windows.Forms.ErrorDialog));
			this.btOk = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.lblErrorMessage = new global::System.Windows.Forms.Label();
			this.linkDetails = new global::System.Windows.Forms.LinkLabel();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.btOk.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btOk.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.btOk.Location = new global::System.Drawing.Point(149, 59);
			this.btOk.Name = "btOk";
			this.btOk.Size = new global::System.Drawing.Size(75, 23);
			this.btOk.TabIndex = 0;
			this.btOk.Text = "OK";
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(7, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.lblErrorMessage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblErrorMessage.Location = new global::System.Drawing.Point(45, 8);
			this.lblErrorMessage.Name = "lblErrorMessage";
			this.lblErrorMessage.Size = new global::System.Drawing.Size(319, 48);
			this.lblErrorMessage.TabIndex = 2;
			this.lblErrorMessage.Text = "Message ....";
			this.lblErrorMessage.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.linkDetails.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.linkDetails.AutoSize = true;
			this.linkDetails.Location = new global::System.Drawing.Point(4, 64);
			this.linkDetails.Name = "linkDetails";
			this.linkDetails.Size = new global::System.Drawing.Size(48, 13);
			this.linkDetails.TabIndex = 3;
			this.linkDetails.TabStop = true;
			this.linkDetails.Text = "Details...";
			this.linkDetails.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDetails_LinkClicked);
			base.AcceptButton = this.btOk;
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.CancelButton = this.btOk;
			base.ClientSize = new global::System.Drawing.Size(372, 88);
			base.Controls.Add(this.linkDetails);
			base.Controls.Add(this.lblErrorMessage);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.btOk);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(378, 120);
			base.Name = "ErrorDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ErrorDialog";
			base.Load += new global::System.EventHandler(this.ErrorDialog_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000CD3 RID: 3283
		private global::System.Windows.Forms.Button btOk;

		// Token: 0x04000CD4 RID: 3284
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000CD5 RID: 3285
		private global::System.Windows.Forms.Label lblErrorMessage;

		// Token: 0x04000CD6 RID: 3286
		private global::System.Windows.Forms.LinkLabel linkDetails;

		// Token: 0x04000CD7 RID: 3287
		private global::System.ComponentModel.Container components;
	}
}
