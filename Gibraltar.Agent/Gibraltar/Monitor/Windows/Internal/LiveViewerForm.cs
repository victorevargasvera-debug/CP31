using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Gibraltar.Messaging;
using Gibraltar.Windows.UI;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001EF RID: 495
	internal partial class LiveViewerForm : Form
	{
		// Token: 0x06001851 RID: 6225 RVA: 0x00053DE8 File Offset: 0x00051FE8
		public LiveViewerForm() : this(null)
		{
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00053DF4 File Offset: 0x00051FF4
		internal LiveViewerForm(LiveLogViewer viewer)
		{
			this.m_Viewer = viewer;
			this.InitializeComponent();
			FormTools.ApplyOSFont(this);
			this.ApplyConfigurationSettings();
			if (this.m_Viewer == null)
			{
				this.m_Viewer = new LiveLogViewer();
				this.m_LocalViewer = true;
			}
			base.Controls.Add(this.m_Viewer);
			this.m_Viewer.Dock = DockStyle.Fill;
			this.m_Viewer.Visible = true;
			this.m_Viewer.SetAutoScroll(true);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00053E78 File Offset: 0x00052078
		internal void RestoreToFront()
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				base.WindowState = FormWindowState.Normal;
			}
			if (!base.Visible && !this.m_LocalViewer && this.m_Viewer != null)
			{
				this.m_Viewer.SetAutoScroll(true);
			}
			base.TopMost = true;
			base.Show();
			base.TopMost = false;
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00053EE0 File Offset: 0x000520E0
		internal static bool ReasonIsAppExiting(CloseReason reason)
		{
			return reason == CloseReason.WindowsShutDown || reason == CloseReason.TaskManagerClosing || reason == CloseReason.ApplicationExitCall;
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00053EFC File Offset: 0x000520FC
		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			CloseReason closeReason = e.CloseReason;
			if (!this.m_LocalViewer && !LiveViewerForm.ReasonIsAppExiting(closeReason) && this.m_Viewer != null)
			{
				if (base.InvokeRequired)
				{
					base.Invoke(new MethodInvoker(this.DetachViewerControl));
				}
				else
				{
					this.DetachViewerControl();
				}
			}
			base.OnFormClosed(e);
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00053F68 File Offset: 0x00052168
		private void DetachViewerControl()
		{
			if (!this.m_LocalViewer && this.m_Viewer != null && base.Controls.Contains(this.m_Viewer))
			{
				this.m_Viewer.Visible = false;
				base.Controls.Remove(this.m_Viewer);
				this.m_Viewer.Dock = DockStyle.None;
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00053FD0 File Offset: 0x000521D0
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (this.m_Viewer != null && base.Controls.Contains(this.m_Viewer))
			{
				this.m_Viewer.Visible = base.Visible;
			}
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0005400C File Offset: 0x0005220C
		private void ApplyConfigurationSettings()
		{
			try
			{
				ViewerMessengerConfiguration viewer = Log.Configuration.Viewer;
				this.Text = viewer.FormTitleText;
			}
			catch
			{
			}
		}

		// Token: 0x04000894 RID: 2196
		private readonly LiveLogViewer m_Viewer;

		// Token: 0x04000895 RID: 2197
		private readonly bool m_LocalViewer;
	}
}
