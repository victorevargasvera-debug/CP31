using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Windows.Reporting.Events;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x0200000D RID: 13
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_ProgressBar", Type = typeof(global::System.Windows.Controls.ProgressBar))]
	[global::System.Windows.TemplatePart(Name = "PART_Description", Type = typeof(global::System.Windows.Controls.ContentControl))]
	public class ReportProgressControl : global::System.Windows.Controls.Control
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00003364 File Offset: 0x00001564
		static ReportProgressControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Reporting.ReportProgressControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Reporting.ReportProgressControl)));
			global::System.Windows.Input.CommandManager.RegisterClassInputBinding(typeof(global::Infragistics.Windows.Reporting.ReportProgressControl), new global::System.Windows.Input.InputBinding(global::Infragistics.Windows.Reporting.ReportProgressControl.CancelCommand, new global::System.Windows.Input.MouseGesture(global::System.Windows.Input.MouseAction.LeftClick)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.Reporting.ReportProgressControl), new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.Reporting.ReportProgressControl.CancelCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.Reporting.ReportProgressControl.CancelCommandHandler)));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000033F6 File Offset: 0x000015F6
		public ReportProgressControl()
		{
			this._mustCancel = false;
			base.Unloaded += this.ProgressWindow_Unloaded;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003417 File Offset: 0x00001617
		private void ProgressWindow_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.UnSubscribe();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000341F File Offset: 0x0000161F
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._progressBar = (base.GetTemplateChild("PART_ProgressBar") as global::System.Windows.Controls.ProgressBar);
			this._description = (base.GetTemplateChild("PART_Description") as global::System.Windows.Controls.ContentControl);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000034CC File Offset: 0x000016CC
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00003454 File Offset: 0x00001654
		public global::Infragistics.Windows.Reporting.Report Report
		{
			get
			{
				return this._report;
			}
			set
			{
				if (this._report != value)
				{
					if (this._report != null)
					{
						this.UnSubscribe();
					}
					this._report = value;
					if (this._report != null)
					{
						this._report.PrintStart += this.Report_PrintStart;
						this._report.PrintProgress += this.Report_PrintProgress;
						this._report.PrintEnded += this.Report_PrintEnded;
					}
				}
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000034D4 File Offset: 0x000016D4
		internal void UnSubscribe()
		{
			if (this._report == null)
			{
				return;
			}
			this._report.PrintStart -= this.Report_PrintStart;
			this._report.PrintProgress -= this.Report_PrintProgress;
			this._report.PrintEnded -= this.Report_PrintEnded;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000352F File Offset: 0x0000172F
		private void Report_PrintStart(object sender, global::System.EventArgs e)
		{
			this._mustCancel = false;
			if (this._description != null)
			{
				this._description.ClearValue(global::System.Windows.Controls.ContentControl.ContentProperty);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003550 File Offset: 0x00001750
		private void Report_PrintProgress(object sender, global::Infragistics.Windows.Reporting.Events.PrintProgressEventArgs e)
		{
			global::System.Windows.Threading.DispatcherFrame dispatcherFrame = new global::System.Windows.Threading.DispatcherFrame();
			global::System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::Infragistics.Windows.Reporting.ReportProgressControl.SetUI(this.SetProgresBar), e, new object[]
			{
				dispatcherFrame
			});
			global::System.Windows.Threading.Dispatcher.PushFrame(dispatcherFrame);
			if (this._mustCancel)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000035A0 File Offset: 0x000017A0
		private void Report_PrintEnded(object sender, global::Infragistics.Windows.Reporting.Events.PrintEndedEventArgs e)
		{
			string description;
			if (e.Status == global::Infragistics.Windows.Reporting.PrintStatus.Canceled)
			{
				if (this._report != null && this._report.IsGeneratingPreview)
				{
					description = global::Infragistics.Windows.Reporting.XamReportPreview.GetString("ProgressCanceledDescription_Preview");
				}
				else
				{
					description = global::Infragistics.Windows.Reporting.XamReportPreview.GetString("ProgressCanceledDescription");
				}
			}
			else if (this._report != null && this._report.IsGeneratingPreview)
			{
				description = string.Format(global::Infragistics.Windows.Reporting.XamReportPreview.GetString("ProgressCompletedDescription_Preview", new object[]
				{
					e.TotalPrintedPages
				}), new object[0]);
			}
			else
			{
				description = string.Format(global::Infragistics.Windows.Reporting.XamReportPreview.GetString("ProgressCompletedDescription", new object[]
				{
					e.TotalPrintedPages
				}), new object[0]);
			}
			global::Infragistics.Windows.Reporting.Events.PrintProgressEventArgs arg = new global::Infragistics.Windows.Reporting.Events.PrintProgressEventArgs(e.TotalPrintedPages, description, 0.0);
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.Reporting.ReportProgressControl.SetUI(this.SetProgresBar), arg, null);
			this._mustCancel = false;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003694 File Offset: 0x00001894
		private void SetProgresBar(global::Infragistics.Windows.Reporting.Events.PrintProgressEventArgs args, object f)
		{
			if (this._progressBar != null)
			{
				this._progressBar.Value = args.PercentCompleted;
			}
			if (this._description != null)
			{
				this._description.Content = args.Description;
			}
			if (f != null)
			{
				((global::System.Windows.Threading.DispatcherFrame)f).Continue = false;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000036E4 File Offset: 0x000018E4
		private static void CancelCommandHandler(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.Reporting.ReportProgressControl reportProgressControl = sender as global::Infragistics.Windows.Reporting.ReportProgressControl;
			if (reportProgressControl != null)
			{
				reportProgressControl._mustCancel = true;
			}
		}

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Controls.ProgressBar _progressBar;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Controls.ContentControl _description;

		// Token: 0x04000027 RID: 39
		private global::Infragistics.Windows.Reporting.Report _report;

		// Token: 0x04000028 RID: 40
		private bool _mustCancel;

		// Token: 0x04000029 RID: 41
		public static global::System.Windows.Input.RoutedUICommand CancelCommand = new global::System.Windows.Input.RoutedUICommand("Cancel", "CancelCommand", typeof(global::Infragistics.Windows.Reporting.ReportProgressControl));

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000058 RID: 88
		private delegate void SetUI(global::Infragistics.Windows.Reporting.Events.PrintProgressEventArgs e, object frame);
	}
}
