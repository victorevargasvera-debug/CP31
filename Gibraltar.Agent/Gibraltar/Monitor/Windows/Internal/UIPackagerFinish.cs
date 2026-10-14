using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Gibraltar.Data;
using Gibraltar.Windows.UI;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001F3 RID: 499
	internal class UIPackagerFinish : global::System.Windows.Forms.UserControl, global::Gibraltar.Windows.UI.IUIWizardFinishPage, global::Gibraltar.Windows.UI.IUIWizardPage
	{
		// Token: 0x06001890 RID: 6288 RVA: 0x00054D94 File Offset: 0x00052F94
		public UIPackagerFinish(global::Gibraltar.Monitor.PackagerConfiguration configuration)
		{
			this.m_Configuration = configuration;
			this.InitializeComponent();
			global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(this);
		}

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x06001891 RID: 6289 RVA: 0x00054DB0 File Offset: 0x00052FB0
		// (remove) Token: 0x06001892 RID: 6290 RVA: 0x00054DEC File Offset: 0x00052FEC
		public event global::System.EventHandler IsValidChanged;

		// Token: 0x06001893 RID: 6291 RVA: 0x00054E28 File Offset: 0x00053028
		public void Initialize(object requestData)
		{
			this.m_Request = (global::Gibraltar.Monitor.Windows.Internal.PackagerRequest)requestData;
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x00054E38 File Offset: 0x00053038
		public string Title
		{
			get
			{
				return "Packaging and Sending Data";
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x00054E40 File Offset: 0x00053040
		public string Instructions
		{
			get
			{
				return this.m_Instructions;
			}
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00054E48 File Offset: 0x00053048
		public void OnEnter()
		{
			string arg;
			switch (this.m_Request.Transport)
			{
			case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.File:
				this.lblStaticMessage.Text = "Exporting sessions to file...";
				arg = "saved to the file you selected";
				break;
			case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.RemovableMedia:
				this.lblStaticMessage.Text = "Exporting sessions to removable media...";
				arg = "saved onto your removable media";
				break;
			case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.Email:
				this.lblStaticMessage.Text = "Thank you for submitting this important diagnostic information to us.";
				arg = "packaged and emailed";
				break;
			case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.Server:
				this.lblStaticMessage.Text = "Thank you for submitting this important diagnostic information to us.";
				arg = "sent to our server";
				break;
			default:
				throw new global::System.ArgumentOutOfRangeException();
			}
			string arg2;
			if ((this.m_Request.Criteria & global::Gibraltar.Data.SessionCriteria.NewSessions) == global::Gibraltar.Data.SessionCriteria.NewSessions)
			{
				arg2 = "unsent sessions are";
			}
			else if ((this.m_Request.Criteria & global::Gibraltar.Data.SessionCriteria.AllSessions) == global::Gibraltar.Data.SessionCriteria.AllSessions)
			{
				arg2 = "all sessions are";
			}
			else
			{
				arg2 = "the current session is";
			}
			this.m_Instructions = string.Format("Please wait while {0} {1}.  Depending on the amount of data this may take a few minutes.", arg2, arg);
			this.lblStatusMessage.Text = string.Empty;
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x00054F58 File Offset: 0x00053158
		public bool IsValid
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00054F5C File Offset: 0x0005315C
		public global::Gibraltar.AsyncTaskResultEventArgs Finish()
		{
			bool useWaitCursor = global::System.Windows.Forms.Application.UseWaitCursor;
			global::System.Windows.Forms.Application.UseWaitCursor = true;
			try
			{
				this.m_ProgressMonitors = new global::Gibraltar.ProgressMonitorStack("Packaging Sessions");
				this.lblStatusMessage.Text = string.Empty;
				this.m_ProgressMonitors.Canceled += this.Monitors_Canceled;
				this.m_ProgressMonitors.Completed += this.Monitors_Completed;
				this.m_ProgressMonitors.Updated += this.Monitors_Updated;
				global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this.AsyncPackagerRequest), null);
				while (!this.m_Completed)
				{
					global::System.Windows.Forms.Application.DoEvents();
					global::System.Threading.Thread.Sleep(16);
				}
			}
			finally
			{
				this.m_ProgressMonitors.Dispose();
				this.m_ProgressMonitors = null;
				global::System.Windows.Forms.Application.UseWaitCursor = useWaitCursor;
			}
			return this.m_FinalResults;
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x0005503C File Offset: 0x0005323C
		public bool AutoClose
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00055040 File Offset: 0x00053240
		private void AsyncPackagerRequest(object stateInfo)
		{
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Starting to execute send package request for user", null, new object[0]);
			}
			global::Gibraltar.Data.PackageSendEventArgs finalResults;
			try
			{
				global::Gibraltar.Data.Packager packager;
				if (string.IsNullOrEmpty(this.m_Request.ProductName))
				{
					packager = new global::Gibraltar.Data.Packager();
				}
				else
				{
					packager = new global::Gibraltar.Data.Packager(this.m_Request.ProductName, this.m_Request.ApplicationName);
				}
				switch (this.m_Request.Transport)
				{
				case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.File:
					finalResults = packager.SendToFile(this.m_Request.Criteria, true, this.m_Request.FileNamePath, this.m_ProgressMonitors);
					break;
				case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.RemovableMedia:
				{
					string fullFileNamePath = global::Gibraltar.Monitor.Windows.Internal.UIPackagerFinish.GenerateFileName(this.m_Request.FileNamePath, packager.ProductName, packager.ApplicationName);
					finalResults = packager.SendToFile(this.m_Request.Criteria, true, fullFileNamePath, this.m_ProgressMonitors);
					break;
				}
				case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.Email:
				{
					string text = this.m_Request.FromEmailAddress;
					if (string.IsNullOrEmpty(text))
					{
						text = this.m_Configuration.FromEmailAddress;
					}
					if (string.IsNullOrEmpty(text))
					{
						text = this.m_Request.DestinationEmailAddress;
					}
					if (string.IsNullOrEmpty(this.m_Request.EmailServer))
					{
						finalResults = packager.SendEmail(this.m_Request.Criteria, true, null, text, this.m_Request.DestinationEmailAddress, string.Empty, 0, null, string.Empty, string.Empty, this.m_ProgressMonitors);
					}
					else
					{
						finalResults = packager.SendEmail(this.m_Request.Criteria, true, null, text, this.m_Request.DestinationEmailAddress, this.m_Request.EmailServer, this.m_Request.ServerPort, new bool?(this.m_Request.UseSsl), this.m_Request.EmailServerUser, this.m_Request.EmailServerPassword, this.m_ProgressMonitors);
					}
					break;
				}
				case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.Server:
					finalResults = packager.SendToServer(this.m_Request.Criteria, true, false, false, false, null, null, 0, false, null, null, this.m_ProgressMonitors);
					break;
				default:
					throw new global::System.ArgumentOutOfRangeException();
				}
			}
			catch (global::System.Exception ex)
			{
				string message;
				switch (this.m_Request.Transport)
				{
				case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.File:
					message = string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "Unable to write sessions to disk.\r\nError: {0}", new object[]
					{
						ex.Message
					});
					break;
				case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.RemovableMedia:
					message = string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "Unable to write sessions to removable media.\r\nError: {0}", new object[]
					{
						ex.Message
					});
					break;
				case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.Email:
					message = string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "Unable to send sessions via email.\r\nError: {0}", new object[]
					{
						ex.Message
					});
					break;
				case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.Server:
					message = string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "Unable to send sessions to the server.\r\nError: {0}", new object[]
					{
						ex.Message
					});
					break;
				default:
					message = string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "Unable to write sessions to disk.\r\nError: {0}", new object[]
					{
						ex.Message
					});
					break;
				}
				finalResults = new global::Gibraltar.Data.PackageSendEventArgs(0, global::Gibraltar.AsyncTaskResult.Error, message, ex);
			}
			this.m_FinalResults = finalResults;
			this.m_Completed = true;
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Completed executing send package request for user.", "Final Status: {0}. Message: {1}", new object[]
				{
					this.m_FinalResults.Result,
					this.m_FinalResults.Message
				});
			}
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x000553D0 File Offset: 0x000535D0
		private void CancelProgress()
		{
			if (this.m_Completed)
			{
				return;
			}
			if (base.InvokeRequired)
			{
				global::System.Windows.Forms.MethodInvoker method = new global::System.Windows.Forms.MethodInvoker(this.CancelProgress);
				try
				{
					base.Invoke(method);
					return;
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
					return;
				}
			}
			if (this.m_ReadOnly)
			{
				return;
			}
			this.packageProgress.Value = this.packageProgress.Maximum;
			this.m_FinalResults = new global::Gibraltar.AsyncTaskResultEventArgs(global::Gibraltar.AsyncTaskResult.Canceled, "Wizard canceled, no information was sent.");
			this.m_ReadOnly = true;
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00055464 File Offset: 0x00053664
		private void CompleteProgress()
		{
			if (this.m_Completed)
			{
				return;
			}
			if (base.InvokeRequired)
			{
				global::System.Windows.Forms.MethodInvoker method = new global::System.Windows.Forms.MethodInvoker(this.CompleteProgress);
				try
				{
					base.Invoke(method);
					return;
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
					return;
				}
			}
			if (this.m_ReadOnly)
			{
				return;
			}
			this.packageProgress.Value = this.packageProgress.Maximum;
			this.m_ReadOnly = true;
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x000554E8 File Offset: 0x000536E8
		private void UpdateProgress(string labelCaption, int completedSteps, int maximumSteps)
		{
			if (this.m_Completed)
			{
				return;
			}
			if (this.lblStatusMessage.InvokeRequired)
			{
				global::Gibraltar.Monitor.Windows.Internal.UIPackagerFinish.UpdateProgressCallback method = new global::Gibraltar.Monitor.Windows.Internal.UIPackagerFinish.UpdateProgressCallback(this.UpdateProgress);
				try
				{
					base.Invoke(method, new object[]
					{
						labelCaption,
						completedSteps,
						maximumSteps
					});
					return;
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
					return;
				}
			}
			if (this.m_ReadOnly)
			{
				return;
			}
			if (maximumSteps == 0)
			{
				this.lblStatusMessage.Text = labelCaption;
				this.lblStatusMessage.Invalidate();
				this.packageProgress.Style = global::System.Windows.Forms.ProgressBarStyle.Marquee;
				return;
			}
			this.lblStatusMessage.Text = labelCaption;
			this.lblStatusMessage.Invalidate();
			this.packageProgress.Style = global::System.Windows.Forms.ProgressBarStyle.Continuous;
			this.packageProgress.Maximum = maximumSteps;
			this.packageProgress.Value = global::System.Math.Min(completedSteps, maximumSteps);
			this.packageProgress.Invalidate();
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000555E4 File Offset: 0x000537E4
		private static string GenerateFileName(string targetDirectory, string productName, string applicationName)
		{
			string text = global::System.DateTimeOffset.UtcNow.ToString("yyyy-MM-dd HH-mm-ss", global::System.Globalization.CultureInfo.InvariantCulture);
			string text2;
			if (string.IsNullOrEmpty(productName))
			{
				text2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0} {1}", new object[]
				{
					global::Gibraltar.Monitor.Log.SessionSummary.HostName,
					text
				});
			}
			else if (string.IsNullOrEmpty(applicationName))
			{
				text2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0} {1} {2}", new object[]
				{
					productName,
					global::Gibraltar.Monitor.Log.SessionSummary.HostName,
					text
				});
			}
			else
			{
				text2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0} {1} {2} {3}", new object[]
				{
					productName,
					applicationName,
					global::Gibraltar.Monitor.Log.SessionSummary.HostName,
					text
				});
			}
			text2 = global::Gibraltar.FileSystemTools.SanitizeFileName(text2 + ".glp");
			return global::Gibraltar.FileSystemTools.MakeFileNamePathUnique(global::System.IO.Path.Combine(targetDirectory, text2));
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x000556CC File Offset: 0x000538CC
		private void Monitors_Canceled(object sender, global::Gibraltar.ProgressMonitorStackEventArgs e)
		{
			this.CancelProgress();
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000556D4 File Offset: 0x000538D4
		private void Monitors_Completed(object sender, global::Gibraltar.ProgressMonitorStackEventArgs e)
		{
			this.CompleteProgress();
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x000556DC File Offset: 0x000538DC
		private void Monitors_Updated(object sender, global::Gibraltar.ProgressMonitorStackEventArgs e)
		{
			this.UpdateProgress(e.StatusMessage, e.CompletedSteps, e.MaximumSteps);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00055708 File Offset: 0x00053908
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00055730 File Offset: 0x00053930
		private void InitializeComponent()
		{
			this.packageProgress = new global::System.Windows.Forms.ProgressBar();
			this.lblStatusMessage = new global::System.Windows.Forms.Label();
			this.lblStaticMessage = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.packageProgress.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.packageProgress.Location = new global::System.Drawing.Point(46, 78);
			this.packageProgress.Name = "packageProgress";
			this.packageProgress.Size = new global::System.Drawing.Size(281, 20);
			this.packageProgress.TabIndex = 0;
			this.lblStatusMessage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblStatusMessage.AutoEllipsis = true;
			this.lblStatusMessage.Location = new global::System.Drawing.Point(46, 58);
			this.lblStatusMessage.Name = "lblStatusMessage";
			this.lblStatusMessage.Size = new global::System.Drawing.Size(281, 17);
			this.lblStatusMessage.TabIndex = 1;
			this.lblStatusMessage.Text = "Package Progress Status Message";
			this.lblStaticMessage.AutoSize = true;
			this.lblStaticMessage.Location = new global::System.Drawing.Point(9, 7);
			this.lblStaticMessage.Name = "lblStaticMessage";
			this.lblStaticMessage.Size = new global::System.Drawing.Size(61, 13);
			this.lblStaticMessage.TabIndex = 2;
			this.lblStaticMessage.Text = "Packaging ";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.lblStaticMessage);
			base.Controls.Add(this.lblStatusMessage);
			base.Controls.Add(this.packageProgress);
			base.Name = "UIPackagerFinish";
			base.Size = new global::System.Drawing.Size(381, 127);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00055904 File Offset: 0x00053B04
		string global::Gibraltar.Windows.UI.IUIWizardPage.get_Name()
		{
			return base.Name;
		}

		// Token: 0x040008BE RID: 2238
		private const string m_Title = "Packaging and Sending Data";

		// Token: 0x040008BF RID: 2239
		private readonly global::Gibraltar.Monitor.PackagerConfiguration m_Configuration;

		// Token: 0x040008C0 RID: 2240
		private global::Gibraltar.Monitor.Windows.Internal.PackagerRequest m_Request;

		// Token: 0x040008C1 RID: 2241
		private global::Gibraltar.ProgressMonitorStack m_ProgressMonitors;

		// Token: 0x040008C2 RID: 2242
		private bool m_ReadOnly;

		// Token: 0x040008C3 RID: 2243
		private string m_Instructions;

		// Token: 0x040008C4 RID: 2244
		private bool m_Completed;

		// Token: 0x040008C5 RID: 2245
		private global::Gibraltar.AsyncTaskResultEventArgs m_FinalResults;

		// Token: 0x040008C7 RID: 2247
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040008C8 RID: 2248
		private global::System.Windows.Forms.ProgressBar packageProgress;

		// Token: 0x040008C9 RID: 2249
		private global::System.Windows.Forms.Label lblStatusMessage;

		// Token: 0x040008CA RID: 2250
		private global::System.Windows.Forms.Label lblStaticMessage;

		// Token: 0x020004B5 RID: 1205
		// (Invoke) Token: 0x060033D6 RID: 13270
		private delegate void UpdateProgressCallback(string labelCaption, int completedSteps, int maximumSteps);
	}
}
