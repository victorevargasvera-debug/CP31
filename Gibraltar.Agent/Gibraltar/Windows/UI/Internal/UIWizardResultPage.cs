using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Gibraltar.Monitor.Windows;

namespace Gibraltar.Windows.UI.Internal
{
	// Token: 0x02000172 RID: 370
	internal class UIWizardResultPage : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000F54 RID: 3924 RVA: 0x00028464 File Offset: 0x00026664
		public UIWizardResultPage(global::Gibraltar.AsyncTaskResultEventArgs results)
		{
			this.m_Results = results;
			this.InitializeComponent();
			global::Gibraltar.AsyncTaskResult result = this.m_Results.Result;
			if (result <= global::Gibraltar.AsyncTaskResult.Warning)
			{
				if (result == global::Gibraltar.AsyncTaskResult.Error)
				{
					this.statusPicture.Image = global::Gibraltar.Monitor.Windows.UIResources.error;
					goto IL_AD;
				}
				if (result == global::Gibraltar.AsyncTaskResult.Warning)
				{
					this.statusPicture.Image = global::Gibraltar.Monitor.Windows.UIResources.Warning;
					goto IL_AD;
				}
			}
			else
			{
				if (result == global::Gibraltar.AsyncTaskResult.Information)
				{
					this.statusPicture.Image = global::Gibraltar.Monitor.Windows.UIResources.info;
					goto IL_AD;
				}
				if (result == global::Gibraltar.AsyncTaskResult.Success)
				{
					this.statusPicture.Image = global::Gibraltar.Monitor.Windows.UIResources.info;
					goto IL_AD;
				}
			}
			this.statusPicture.Visible = false;
			IL_AD:
			this.lblErrorMessage.Text = this.m_Results.Message;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00028538 File Offset: 0x00026738
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00028560 File Offset: 0x00026760
		private void InitializeComponent()
		{
			this.lblErrorMessage = new global::System.Windows.Forms.Label();
			this.statusPicture = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.statusPicture).BeginInit();
			base.SuspendLayout();
			this.lblErrorMessage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblErrorMessage.Location = new global::System.Drawing.Point(54, 13);
			this.lblErrorMessage.Name = "lblErrorMessage";
			this.lblErrorMessage.Size = new global::System.Drawing.Size(298, 149);
			this.lblErrorMessage.TabIndex = 1;
			this.lblErrorMessage.Text = "label1";
			this.statusPicture.ErrorImage = null;
			this.statusPicture.InitialImage = null;
			this.statusPicture.Location = new global::System.Drawing.Point(0, 13);
			this.statusPicture.Name = "statusPicture";
			this.statusPicture.Size = new global::System.Drawing.Size(48, 48);
			this.statusPicture.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.statusPicture.TabIndex = 0;
			this.statusPicture.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.lblErrorMessage);
			base.Controls.Add(this.statusPicture);
			base.Name = "UIWizardResultPage";
			base.Size = new global::System.Drawing.Size(355, 162);
			((global::System.ComponentModel.ISupportInitialize)this.statusPicture).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400052C RID: 1324
		private readonly global::Gibraltar.AsyncTaskResultEventArgs m_Results;

		// Token: 0x0400052D RID: 1325
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400052E RID: 1326
		private global::System.Windows.Forms.PictureBox statusPicture;

		// Token: 0x0400052F RID: 1327
		private global::System.Windows.Forms.Label lblErrorMessage;
	}
}
