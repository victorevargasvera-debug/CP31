using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Gibraltar.Windows.UI;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001EC RID: 492
	internal class UIMessageDetails : global::System.Windows.Forms.UserControl
	{
		// Token: 0x0600182F RID: 6191 RVA: 0x00052C6C File Offset: 0x00050E6C
		public UIMessageDetails()
		{
			this.InitializeComponent();
			global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(this);
			this.messageTabControl.TabPages.Remove(this.sourceCodePanel);
			this.messageTabControl.TabPages.Remove(this.detailXmlPanel);
			this.messageTabControl.SelectedTab = this.detailPanel;
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x00052CCC File Offset: 0x00050ECC
		// (set) Token: 0x06001831 RID: 6193 RVA: 0x00052CD4 File Offset: 0x00050ED4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::Loupe.Extensibility.Data.ILogMessage LogMessage
		{
			get
			{
				return this.m_LogMessage;
			}
			set
			{
				this.SetDisplayMessage(value);
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x00052CE0 File Offset: 0x00050EE0
		// (set) Token: 0x06001833 RID: 6195 RVA: 0x00052CF0 File Offset: 0x00050EF0
		[global::System.ComponentModel.Description("Indicates if the description text area should use a fixed width font and suppress line wrap")]
		[global::System.ComponentModel.DefaultValue("false")]
		public bool ShowDescriptionPreformatted
		{
			get
			{
				return this.logMessage.ShowDescriptionPreformatted;
			}
			set
			{
				this.logMessage.ShowDescriptionPreformatted = value;
			}
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00052D00 File Offset: 0x00050F00
		private void DisposeLooseTabs(bool disposing)
		{
			if (disposing)
			{
				if (this.sourceCodePanel != null && !this.sourceCodePanel.IsDisposed && !this.messageTabControl.Controls.Contains(this.sourceCodePanel))
				{
					this.sourceCodePanel.Dispose();
				}
				if (this.detailXmlPanel != null && !this.detailXmlPanel.IsDisposed && !this.messageTabControl.Controls.Contains(this.detailXmlPanel))
				{
					this.detailXmlPanel.Dispose();
				}
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00052D9C File Offset: 0x00050F9C
		private void SetDisplayMessage(global::Loupe.Extensibility.Data.ILogMessage message)
		{
			this.m_LogMessage = message;
			if (this.m_LogMessage == null)
			{
				this.logMessage.LogMessage = null;
				this.exceptionDetail.ExceptionInfo = null;
				this.detailsXmlViewer.LogMessage = null;
				this.sourceCodeViewer.LogMessage = null;
				return;
			}
			bool flag = false;
			if (!this.m_AnyDetailsXmlSeen && !string.IsNullOrEmpty(this.m_LogMessage.Details))
			{
				this.messageTabControl.SuspendLayout();
				flag = true;
				this.m_AnyDetailsXmlSeen = true;
				this.messageTabControl.TabPages.Insert(2, this.detailXmlPanel);
			}
			if (!this.m_AnySourceCodeSeen && this.m_LogMessage.HasSourceLocation)
			{
				if (!flag)
				{
					this.messageTabControl.SuspendLayout();
					flag = true;
				}
				this.m_AnySourceCodeSeen = true;
				this.messageTabControl.TabPages.Add(this.sourceCodePanel);
			}
			if (flag)
			{
				this.messageTabControl.ResumeLayout(true);
			}
			this.logMessage.LogMessage = this.m_LogMessage;
			this.exceptionDetail.ExceptionInfo = this.m_LogMessage.Exception;
			this.detailsXmlViewer.LogMessage = this.m_LogMessage;
			this.sourceCodeViewer.LogMessage = this.m_LogMessage;
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00052EE4 File Offset: 0x000510E4
		private void exceptionDetail_TitleChanged(object sender, global::System.EventArgs e)
		{
			if (!this.messageTabControl.TabPages.Contains(this.exceptionPanel))
			{
				return;
			}
			this.exceptionPanel.Text = this.exceptionDetail.Title;
			if (this.exceptionDetail.ExceptionInfo != null)
			{
				this.exceptionPanel.ImageKey = "flag_red";
				return;
			}
			this.exceptionPanel.ImageKey = "flag_green";
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00052F58 File Offset: 0x00051158
		private void detailsXmlViewer_TitleChanged(object sender, global::System.EventArgs e)
		{
			if (this.messageTabControl.TabPages.Contains(this.detailXmlPanel))
			{
				this.detailXmlPanel.Text = this.detailsXmlViewer.Title;
			}
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00052F8C File Offset: 0x0005118C
		private void sourceCodeViewer_TitleChanged(object sender, global::System.EventArgs e)
		{
			if (this.messageTabControl.TabPages.Contains(this.sourceCodePanel))
			{
				this.sourceCodePanel.Text = this.sourceCodeViewer.Title;
			}
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00052FC0 File Offset: 0x000511C0
		private void messageTabControl_Selected(object sender, global::System.Windows.Forms.TabControlEventArgs e)
		{
			if (e.TabPage == this.sourceCodePanel)
			{
				this.sourceCodeViewer.Visible = true;
				return;
			}
			if (this.sourceCodeViewer.Visible)
			{
				this.sourceCodeViewer.Visible = false;
			}
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00052FFC File Offset: 0x000511FC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			this.DisposeLooseTabs(disposing);
			base.Dispose(disposing);
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00053028 File Offset: 0x00051228
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Gibraltar.Monitor.Windows.Internal.UIMessageDetails));
			this.messageTabControl = new global::System.Windows.Forms.TabControl();
			this.detailPanel = new global::System.Windows.Forms.TabPage();
			this.logMessage = new global::Gibraltar.Monitor.Windows.UILogMessage();
			this.exceptionPanel = new global::System.Windows.Forms.TabPage();
			this.exceptionDetail = new global::Gibraltar.Monitor.Windows.UIExceptionDetail();
			this.detailXmlPanel = new global::System.Windows.Forms.TabPage();
			this.detailsXmlViewer = new global::Gibraltar.Monitor.Windows.UILogMessageDetail();
			this.sourceCodePanel = new global::System.Windows.Forms.TabPage();
			this.sourceCodeViewer = new global::Gibraltar.Monitor.Windows.UISourceViewer();
			this.smallIconImages = new global::System.Windows.Forms.ImageList(this.components);
			this.messageTabControl.SuspendLayout();
			this.detailPanel.SuspendLayout();
			this.exceptionPanel.SuspendLayout();
			this.detailXmlPanel.SuspendLayout();
			this.sourceCodePanel.SuspendLayout();
			base.SuspendLayout();
			this.messageTabControl.Controls.Add(this.detailPanel);
			this.messageTabControl.Controls.Add(this.exceptionPanel);
			this.messageTabControl.Controls.Add(this.detailXmlPanel);
			this.messageTabControl.Controls.Add(this.sourceCodePanel);
			this.messageTabControl.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.messageTabControl.ImageList = this.smallIconImages;
			this.messageTabControl.Location = new global::System.Drawing.Point(0, 0);
			this.messageTabControl.Name = "messageTabControl";
			this.messageTabControl.SelectedIndex = 0;
			this.messageTabControl.Size = new global::System.Drawing.Size(742, 305);
			this.messageTabControl.TabIndex = 0;
			this.messageTabControl.Selected += this.messageTabControl_Selected;
			this.detailPanel.Controls.Add(this.logMessage);
			this.detailPanel.ImageKey = "details";
			this.detailPanel.Location = new global::System.Drawing.Point(4, 23);
			this.detailPanel.Name = "detailPanel";
			this.detailPanel.Size = new global::System.Drawing.Size(734, 278);
			this.detailPanel.TabIndex = 0;
			this.detailPanel.Text = "Log Message";
			this.detailPanel.UseVisualStyleBackColor = true;
			this.logMessage.BackColor = global::System.Drawing.SystemColors.Window;
			this.logMessage.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.logMessage.Location = new global::System.Drawing.Point(0, 0);
			this.logMessage.Margin = new global::System.Windows.Forms.Padding(0);
			this.logMessage.Name = "logMessage";
			this.logMessage.ShowDescriptionPreformatted = false;
			this.logMessage.ShowLocationInfo = true;
			this.logMessage.ShowThreadInfo = true;
			this.logMessage.Size = new global::System.Drawing.Size(734, 278);
			this.logMessage.TabIndex = 0;
			this.exceptionPanel.Controls.Add(this.exceptionDetail);
			this.exceptionPanel.ImageKey = "flag_blue";
			this.exceptionPanel.Location = new global::System.Drawing.Point(4, 23);
			this.exceptionPanel.Name = "exceptionPanel";
			this.exceptionPanel.Size = new global::System.Drawing.Size(734, 278);
			this.exceptionPanel.TabIndex = 1;
			this.exceptionPanel.Text = "Exceptions";
			this.exceptionPanel.UseVisualStyleBackColor = true;
			this.exceptionDetail.BackColor = global::System.Drawing.SystemColors.Window;
			this.exceptionDetail.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.exceptionDetail.Location = new global::System.Drawing.Point(0, 0);
			this.exceptionDetail.Margin = new global::System.Windows.Forms.Padding(0);
			this.exceptionDetail.Name = "exceptionDetail";
			this.exceptionDetail.Size = new global::System.Drawing.Size(734, 278);
			this.exceptionDetail.TabIndex = 0;
			this.exceptionDetail.TitleChanged += this.exceptionDetail_TitleChanged;
			this.detailXmlPanel.Controls.Add(this.detailsXmlViewer);
			this.detailXmlPanel.Location = new global::System.Drawing.Point(4, 23);
			this.detailXmlPanel.Name = "detailXmlPanel";
			this.detailXmlPanel.Size = new global::System.Drawing.Size(734, 278);
			this.detailXmlPanel.TabIndex = 2;
			this.detailXmlPanel.Text = "Details";
			this.detailXmlPanel.UseVisualStyleBackColor = true;
			this.detailsXmlViewer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.detailsXmlViewer.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.detailsXmlViewer.Location = new global::System.Drawing.Point(0, 0);
			this.detailsXmlViewer.Name = "detailsXmlViewer";
			this.detailsXmlViewer.Size = new global::System.Drawing.Size(734, 278);
			this.detailsXmlViewer.TabIndex = 0;
			this.detailsXmlViewer.TitleChanged += this.detailsXmlViewer_TitleChanged;
			this.sourceCodePanel.Controls.Add(this.sourceCodeViewer);
			this.sourceCodePanel.ImageKey = "source";
			this.sourceCodePanel.Location = new global::System.Drawing.Point(4, 23);
			this.sourceCodePanel.Name = "sourceCodePanel";
			this.sourceCodePanel.Size = new global::System.Drawing.Size(734, 278);
			this.sourceCodePanel.TabIndex = 3;
			this.sourceCodePanel.Text = "Source Code";
			this.sourceCodePanel.UseVisualStyleBackColor = true;
			this.sourceCodeViewer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.sourceCodeViewer.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.sourceCodeViewer.Location = new global::System.Drawing.Point(0, 0);
			this.sourceCodeViewer.Name = "sourceCodeViewer";
			this.sourceCodeViewer.Size = new global::System.Drawing.Size(734, 278);
			this.sourceCodeViewer.TabIndex = 0;
			this.sourceCodeViewer.TitleChanged += this.sourceCodeViewer_TitleChanged;
			this.smallIconImages.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("smallIconImages.ImageStream");
			this.smallIconImages.TransparentColor = global::System.Drawing.Color.Magenta;
			this.smallIconImages.Images.SetKeyName(0, "critical");
			this.smallIconImages.Images.SetKeyName(1, "error");
			this.smallIconImages.Images.SetKeyName(2, "warning");
			this.smallIconImages.Images.SetKeyName(3, "information");
			this.smallIconImages.Images.SetKeyName(4, "flag_blue");
			this.smallIconImages.Images.SetKeyName(5, "flag_green");
			this.smallIconImages.Images.SetKeyName(6, "flag_red");
			this.smallIconImages.Images.SetKeyName(7, "comment");
			this.smallIconImages.Images.SetKeyName(8, "details");
			this.smallIconImages.Images.SetKeyName(9, "source");
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Window;
			base.Controls.Add(this.messageTabControl);
			base.Name = "UIMessageDetails";
			base.Size = new global::System.Drawing.Size(742, 305);
			this.messageTabControl.ResumeLayout(false);
			this.detailPanel.ResumeLayout(false);
			this.exceptionPanel.ResumeLayout(false);
			this.detailXmlPanel.ResumeLayout(false);
			this.sourceCodePanel.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400087D RID: 2173
		private global::Loupe.Extensibility.Data.ILogMessage m_LogMessage;

		// Token: 0x0400087E RID: 2174
		private bool m_AnyDetailsXmlSeen;

		// Token: 0x0400087F RID: 2175
		private bool m_AnySourceCodeSeen;

		// Token: 0x04000880 RID: 2176
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000881 RID: 2177
		private global::System.Windows.Forms.TabControl messageTabControl;

		// Token: 0x04000882 RID: 2178
		private global::System.Windows.Forms.TabPage detailPanel;

		// Token: 0x04000883 RID: 2179
		private global::System.Windows.Forms.TabPage exceptionPanel;

		// Token: 0x04000884 RID: 2180
		private global::System.Windows.Forms.TabPage detailXmlPanel;

		// Token: 0x04000885 RID: 2181
		private global::System.Windows.Forms.TabPage sourceCodePanel;

		// Token: 0x04000886 RID: 2182
		private global::Gibraltar.Monitor.Windows.UIExceptionDetail exceptionDetail;

		// Token: 0x04000887 RID: 2183
		private global::Gibraltar.Monitor.Windows.UILogMessage logMessage;

		// Token: 0x04000888 RID: 2184
		private global::Gibraltar.Monitor.Windows.UILogMessageDetail detailsXmlViewer;

		// Token: 0x04000889 RID: 2185
		private global::Gibraltar.Monitor.Windows.UISourceViewer sourceCodeViewer;

		// Token: 0x0400088A RID: 2186
		private global::System.Windows.Forms.ImageList smallIconImages;
	}
}
