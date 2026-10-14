using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Gibraltar.Monitor.Net;
using Gibraltar.Windows.UI;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001E6 RID: 486
	internal partial class AlertDialog : Form
	{
		// Token: 0x06001795 RID: 6037 RVA: 0x0004E390 File Offset: 0x0004C590
		public AlertDialog()
		{
			this.InitializeComponent();
			FormTools.ApplyOSFont(this);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0004E3BC File Offset: 0x0004C5BC
		internal void RestoreToFront()
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				base.WindowState = FormWindowState.Normal;
			}
			base.TopMost = true;
			base.Visible = true;
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0004E3E0 File Offset: 0x0004C5E0
		public void DisplayException(ExceptionDisplayRequest newRequest)
		{
			if (newRequest == null)
			{
				throw new ArgumentNullException("newRequest");
			}
			if (base.InvokeRequired)
			{
				AlertDialog.DisplayExceptionInvoker method = new AlertDialog.DisplayExceptionInvoker(this.DisplayException);
				base.Invoke(method, new object[]
				{
					newRequest
				});
				return;
			}
			this.ActionDisplayException(newRequest);
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x0004E434 File Offset: 0x0004C634
		public void InvokeApplicationExit()
		{
			Form form = Listener.ClientFormsActive();
			if (form == null)
			{
				form = this;
			}
			if (form.IsHandleCreated)
			{
				form.BeginInvoke(new MethodInvoker(Application.Exit));
				return;
			}
			Application.Exit();
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x0004E478 File Offset: 0x0004C678
		public void InvokeApplicationRestart()
		{
			Form form = Listener.ClientFormsActive();
			if (form == null)
			{
				form = this;
			}
			if (form.IsHandleCreated)
			{
				form.BeginInvoke(new MethodInvoker(Application.Restart));
				return;
			}
			Application.Restart();
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x0004E4BC File Offset: 0x0004C6BC
		protected override void OnVisibleChanged(EventArgs e)
		{
			if (!base.Visible)
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_Exceptions.Count > 0)
					{
						this.ActionHideDisplay(DialogResult.Cancel, false);
					}
				}
			}
			base.OnVisibleChanged(e);
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x0004E520 File Offset: 0x0004C720
		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			bool flag = false;
			try
			{
				if (base.InvokeRequired && base.IsHandleCreated)
				{
					flag = true;
					base.Invoke(new FormClosedEventHandler(this.DoFormClosed), new object[]
					{
						this,
						e
					});
				}
				else
				{
					this.DoFormClosed(this, e);
				}
			}
			catch (Exception ex)
			{
				if (!Log.SilentMode)
				{
					Log.Write(LogMessageSeverity.Warning, LogWriteMode.Queued, ex, "Gibraltar.Error Manager", null, "Error closing GEM: {0}\r\nAn error occurred while attempting to handle the FormClosed event in the Gibraltar Error Manager.  Handler call: {1}\r\nGEM Form state: {2}\r\n", new object[]
					{
						ex.Message,
						flag ? "Invoke" : "Direct",
						base.IsHandleCreated ? "Still Open" : "Closed"
					});
				}
			}
			base.OnFormClosed(e);
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0004E5F8 File Offset: 0x0004C7F8
		private void DoFormClosed(object sender, FormClosedEventArgs e)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Exceptions.Count > 0)
				{
					CloseReason closeReason = e.CloseReason;
					this.ActionHideDisplay(DialogResult.Cancel, LiveViewerForm.ReasonIsAppExiting(closeReason));
				}
				else
				{
					Listener.SuppressAlerts = this.m_IgnoreAllProblems;
				}
			}
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x0004E664 File Offset: 0x0004C864
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Icon icon = null;
			if (base.ParentForm == null)
			{
				using (IEnumerator enumerator = Application.OpenForms.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						Form form = (Form)obj;
						if (form.InvokeRequired && form.Icon != null)
						{
							try
							{
								icon = new Icon(form.Icon, form.Icon.Size);
							}
							catch
							{
							}
						}
						if (icon != null)
						{
							break;
						}
					}
					goto IL_A0;
				}
			}
			icon = base.ParentForm.Icon;
			IL_A0:
			if (icon == null)
			{
				try
				{
					icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
				}
				catch
				{
				}
			}
			base.Icon = (icon ?? SystemIcons.Exclamation);
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x0004E768 File Offset: 0x0004C968
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			int x = (this.messageFlowLayout.Left - SystemIcons.Error.Width) / 2;
			int num = this.messageFlowLayout.Top + this.lblMainInstruction.Height / 2 - SystemIcons.Error.Height / 2;
			num = Math.Min(this.messageFlowLayout.Top, num);
			this.m_MinimumHeaderHeight = num + SystemIcons.Error.Height;
			e.Graphics.DrawIcon(SystemIcons.Error, x, num);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0004E7F8 File Offset: 0x0004C9F8
		private void ActionDisplayException(ExceptionDisplayRequest newRequest)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_Exceptions.Add(newRequest);
				this.exceptionListViewer.AddException(newRequest);
				this.chkReportProblems.Checked = Log.SendSessionsOnExit;
				string empty = string.Empty;
				this.chkReportProblems.Visible = Log.CanSendSessionsOnExit(ref empty);
				this.m_HaveAnyCantContinueRequests = (this.m_HaveAnyCantContinueRequests || !newRequest.CanContinue);
				this.m_HaveAnyBlockingRequests = (this.m_HaveAnyBlockingRequests || newRequest.ThreadBlocked);
				if (this.m_Exceptions.Count == 1)
				{
					this.Text = Log.SessionSummary.Application;
					this.lblMainInstruction.Text = string.Format(FileSystemTools.UICultureFormat, "{0} has encountered an unexpected problem", new object[]
					{
						Log.SessionSummary.Application
					}) + (this.m_HaveAnyCantContinueRequests ? " and can't continue" : string.Empty);
					this.lblErrorSummary.Text = newRequest.Exception.Message;
				}
				else if (this.m_Exceptions.Count > 1)
				{
					this.lblMainInstruction.Text = string.Format(FileSystemTools.UICultureFormat, "{0} has encountered some unexpected problems", new object[]
					{
						Log.SessionSummary.Application
					}) + (this.m_HaveAnyCantContinueRequests ? " and can't continue" : string.Empty);
					this.lblErrorSummary.Text = string.Empty;
				}
				this.SizeControl();
				this.btnClose.Text = (this.m_HaveAnyCantContinueRequests ? "&Exit" : (this.m_HaveAnyBlockingRequests ? "&Continue" : "&Close"));
				if (!base.Visible)
				{
					base.Show();
				}
				else
				{
					base.TopMost = true;
					base.TopMost = (this.m_HaveAnyBlockingRequests || this.m_HaveAnyCantContinueRequests);
				}
			}
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0004EA28 File Offset: 0x0004CC28
		private void ActionHideDisplay(DialogResult result, bool appIsExiting)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				Listener.SuppressAlerts = this.m_IgnoreAllProblems;
				AlertDialog.g_AlertDialogPreviouslyClosed = true;
				foreach (ExceptionDisplayRequest exceptionDisplayRequest in this.m_Exceptions)
				{
					exceptionDisplayRequest.Result = result;
				}
				this.m_HaveAnyBlockingRequests = false;
				this.m_Exceptions.Clear();
				this.exceptionListViewer.Clear();
				if (!appIsExiting)
				{
					if (this.m_HaveAnyCantContinueRequests && !ExceptionListener.FatalExceptionHasOccurred)
					{
						Log.EndSession(SessionStatus.Crashed, null, "User Exiting Application after Exception");
						this.InvokeApplicationExit();
					}
					if (base.IsHandleCreated)
					{
						base.Close();
					}
				}
			}
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0004EB10 File Offset: 0x0004CD10
		private void ActionClose()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_HaveAnyCantContinueRequests)
				{
					Log.WriteMessage(LogMessageSeverity.Information, LogWriteMode.Queued, "Gibraltar", "Exception", null, null, null, null, "User Exiting Application after Exception", "The user has elected to close the alert dialog and exit the application.", new object[0]);
					Log.EndSession(SessionStatus.Crashed, null, "User Exiting Application after Exception");
				}
				else
				{
					Log.WriteMessage(LogMessageSeverity.Information, LogWriteMode.Queued, "Gibraltar", "Exception", null, null, null, null, "User Continuing Execution after Exception", "The user has elected to close the alert dialog and continue execution.", new object[0]);
				}
				this.ActionHideDisplay(DialogResult.Ignore, false);
			}
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0004EBB4 File Offset: 0x0004CDB4
		private void ActionRestart()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				Log.WriteMessage(LogMessageSeverity.Critical, LogWriteMode.Queued, "Gibraltar", "Exception", null, null, null, null, "User Restarting Application after Exception", "The user has elected to restart the application after viewing exceptions in the alert dialog.", new object[0]);
				Log.EndSession(SessionStatus.Crashed, null, "User Restarting Application after Exception");
				this.ActionHideDisplay(DialogResult.Abort, false);
				try
				{
					this.InvokeApplicationRestart();
				}
				catch (Exception exception)
				{
					Log.WriteMessage(LogMessageSeverity.Warning, LogWriteMode.Queued, "Gibraltar", "Exception", null, null, exception, null, "Unable to trigger application restart", "An internal framework exception has prevented the application restart from completing.", new object[0]);
				}
			}
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0004EC60 File Offset: 0x0004CE60
		private void SizeControl()
		{
			string empty = string.Empty;
			this.lblErrorSummary.Visible = !this.m_Expanded;
			this.chkReportProblems.Visible = (this.m_Expanded && Log.CanSendSessionsOnExit(ref empty));
			this.chkIgnoreAllProblems.Visible = (this.m_Expanded || AlertDialog.g_AlertDialogPreviouslyClosed);
			this.messageFlowLayout.PerformLayout();
			int height = this.messageFlowLayout.GetPreferredSize(new Size(this.messageFlowLayout.Width, 0)).Height;
			if (this.messageFlowLayout.Height != height)
			{
				this.messageFlowLayout.Height = height;
			}
			this.exceptionListViewer.Visible = this.m_Expanded;
			this.exceptionListViewer.Top = Math.Max(this.messageFlowLayout.Top + this.messageFlowLayout.Height + this.messageFlowLayout.Margin.Bottom, this.m_MinimumHeaderHeight) + this.exceptionListViewer.Margin.Top;
			Control control = this.exceptionListViewer.Visible ? this.exceptionListViewer : this.messageFlowLayout;
			int num = control.Top + control.Height + control.Margin.Bottom + this.chkIgnoreAllProblems.Margin.Top + this.chkIgnoreAllProblems.Height + this.chkIgnoreAllProblems.Margin.Bottom + this.buttonPanel.Height;
			if (this.chkReportProblems.Visible)
			{
				num += this.chkReportProblems.Margin.Top + this.chkReportProblems.Height + this.chkReportProblems.Margin.Bottom;
			}
			base.Size = this.SizeFromClientSize(new Size(base.ClientSize.Width, num));
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0004EE70 File Offset: 0x0004D070
		private void lblShowHideDetails_MouseEnter(object sender, EventArgs e)
		{
			this.lblShowHideDetails.ImageKey = (this.m_Expanded ? "arrow_up_color" : "arrow_down_color");
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0004EE98 File Offset: 0x0004D098
		private void lblShowHideDetails_MouseLeave(object sender, EventArgs e)
		{
			this.lblShowHideDetails.ImageKey = (this.m_Expanded ? "arrow_up_bw" : "arrow_down_bw");
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x0004EEC0 File Offset: 0x0004D0C0
		private void lblShowHideDetails_MouseUp(object sender, MouseEventArgs e)
		{
			this.lblShowHideDetails.ImageKey = (this.m_Expanded ? "arrow_up_color" : "arrow_down_color");
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x0004EEE8 File Offset: 0x0004D0E8
		private void lblShowHideDetails_MouseDown(object sender, MouseEventArgs e)
		{
			this.lblShowHideDetails.ImageKey = (this.m_Expanded ? "arrow_up_color_pressed" : "arrow_down_color_pressed");
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x0004EF10 File Offset: 0x0004D110
		private void lblShowHideDetails_Click(object sender, EventArgs e)
		{
			this.m_Expanded = !this.m_Expanded;
			this.lblShowHideDetails.Text = (this.m_Expanded ? "        Hide details" : "        Show details");
			this.SizeControl();
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x0004EF4C File Offset: 0x0004D14C
		private void btnRestart_Click(object sender, EventArgs e)
		{
			this.ActionRestart();
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x0004EF54 File Offset: 0x0004D154
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.ActionClose();
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0004EF5C File Offset: 0x0004D15C
		private void chkIgnoreAllProblems_CheckedChanged(object sender, EventArgs e)
		{
			this.m_IgnoreAllProblems = this.chkIgnoreAllProblems.Checked;
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0004EF70 File Offset: 0x0004D170
		private void chkReportProblems_CheckedChanged(object sender, EventArgs e)
		{
			Log.SendSessionsOnExit = this.chkReportProblems.Checked;
		}

		// Token: 0x04000818 RID: 2072
		private const string CloseAsContinueCaption = "&Continue";

		// Token: 0x04000819 RID: 2073
		private const string CloseAsCloseCaption = "&Close";

		// Token: 0x0400081A RID: 2074
		private const string CloseAsExitCaption = "&Exit";

		// Token: 0x0400081B RID: 2075
		private const string InstructionOneException = "{0} has encountered an unexpected problem";

		// Token: 0x0400081C RID: 2076
		private const string InstructionMultipleException = "{0} has encountered some unexpected problems";

		// Token: 0x0400081D RID: 2077
		private const string InstructionAddendumCantContinue = " and can't continue";

		// Token: 0x0400081E RID: 2078
		private readonly object m_Lock = new object();

		// Token: 0x0400081F RID: 2079
		private readonly List<ExceptionDisplayRequest> m_Exceptions = new List<ExceptionDisplayRequest>();

		// Token: 0x04000820 RID: 2080
		private int m_MinimumHeaderHeight;

		// Token: 0x04000821 RID: 2081
		private bool m_HaveAnyBlockingRequests;

		// Token: 0x04000822 RID: 2082
		private bool m_HaveAnyCantContinueRequests;

		// Token: 0x04000823 RID: 2083
		private bool m_Expanded;

		// Token: 0x04000824 RID: 2084
		private bool m_IgnoreAllProblems;

		// Token: 0x04000825 RID: 2085
		private static bool g_AlertDialogPreviouslyClosed;

		// Token: 0x020004AF RID: 1199
		// (Invoke) Token: 0x060033A5 RID: 13221
		private delegate void DisplayExceptionInvoker(ExceptionDisplayRequest newRequest);
	}
}
