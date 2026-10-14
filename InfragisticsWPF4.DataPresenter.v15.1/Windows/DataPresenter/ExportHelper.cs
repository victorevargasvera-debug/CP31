using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200010E RID: 270
	internal class ExportHelper
	{
		// Token: 0x0600109B RID: 4251 RVA: 0x0004A203 File Offset: 0x00048403
		internal ExportHelper(global::Infragistics.Windows.DataPresenter.DataPresenterBase source)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(source, "source");
			this._source = source;
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x0004A21D File Offset: 0x0004841D
		internal global::Infragistics.Windows.DataPresenter.RecordExportStatusControl InternalStatusControl
		{
			get
			{
				return this._internalStatusControl;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0004A225 File Offset: 0x00048425
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x0004A22C File Offset: 0x0004842C
		private static int SynchronousExportCount
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.ExportHelper._synchronousExportCount;
			}
			set
			{
				if (value != global::Infragistics.Windows.DataPresenter.ExportHelper._synchronousExportCount)
				{
					if (global::Infragistics.Windows.DataPresenter.ExportHelper._synchronousExportCount == 0)
					{
						global::Infragistics.Windows.DataPresenter.ExportHelper.StopTimer();
					}
					global::Infragistics.Windows.DataPresenter.ExportHelper._synchronousExportCount = value;
					if (global::Infragistics.Windows.DataPresenter.ExportHelper._synchronousExportCount == 0)
					{
						global::Infragistics.Windows.DataPresenter.ExportHelper.StartTimer();
					}
				}
			}
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0004A254 File Offset: 0x00048454
		internal void AccessAllRecords()
		{
			global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator exportSourceRecordEnumerator = new global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator(this._source.RecordManager);
			while (exportSourceRecordEnumerator.MoveNext())
			{
			}
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0004A27A File Offset: 0x0004847A
		internal void AddStatusControl(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl ctrl)
		{
			if (this._statusControls == null)
			{
				this._statusControls = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.RecordExportStatusControl>();
			}
			this._statusControls.Add(ctrl);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0004A29C File Offset: 0x0004849C
		internal bool CancelExport(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter)
		{
			if (global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations != null)
			{
				for (int i = 0; i < global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest exportRequest = global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations[i];
					if (exportRequest != null && exportRequest.ExportHelper._source == dataPresenter)
					{
						global::Infragistics.Windows.DataPresenter.ExportHelper.CancelExport(exportRequest);
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0004A2EC File Offset: 0x000484EC
		internal void CancelExport(global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync exporter)
		{
			if (global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations != null)
			{
				for (int i = 0; i < global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest exportRequest = global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations[i];
					if (exportRequest != null && exportRequest.Exporter == exporter)
					{
						global::Infragistics.Windows.DataPresenter.ExportHelper.CancelExport(exportRequest);
						return;
					}
				}
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0004A334 File Offset: 0x00048534
		private static void CancelExport(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request)
		{
			if (global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations != null)
			{
				request.CancelRequested = true;
				if (request == global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(global::Infragistics.Windows.DataPresenter.ExportHelper._currentRequest))
				{
					if (global::Infragistics.Windows.DataPresenter.ExportHelper._isProcessingCurrentRequest)
					{
						return;
					}
					global::Infragistics.Windows.DataPresenter.ExportHelper._currentRequest = null;
					global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations.Remove(request);
					if (request.ExportHelper != null && request.ExportHelper._requestList != null)
					{
						request.ExportHelper._requestList.Remove(request);
					}
					global::Infragistics.Windows.DataPresenter.ExportHelper.StopTimer();
				}
				request.CancelExport(global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason.Cancelled, null);
				global::Infragistics.Windows.DataPresenter.ExportHelper.StartTimer();
			}
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0004A3B0 File Offset: 0x000485B0
		internal void Export(global::Infragistics.Windows.DataPresenter.IDataPresenterExporter exporter, global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(exporter, "exporter");
			global::Infragistics.CoreUtilities.ValidateNotNull(options, "options");
			this.ValidateCanExport();
			global::Infragistics.Windows.DataPresenter.DataPresenterExportControl dataPresenterExportControl = new global::Infragistics.Windows.DataPresenter.DataPresenterExportControl(this._source, exporter);
			try
			{
				global::Infragistics.Windows.DataPresenter.ExportHelper.SynchronousExportCount++;
				this._source.ExportStatus = global::Infragistics.Windows.DataPresenter.RecordExportStatus.Initializing;
				this.AccessAllRecords();
				this.InitializeExportControl(dataPresenterExportControl, options);
				this._source.ExportStatus = global::Infragistics.Windows.DataPresenter.RecordExportStatus.Exporting;
				exporter.BeginExport(dataPresenterExportControl, options);
				dataPresenterExportControl.BindToDataSource();
				bool cancelled = new global::Infragistics.Windows.DataPresenter.ExportRecordEnumerator(dataPresenterExportControl, dataPresenterExportControl.ViewableRecords, options).Process(null) == global::Infragistics.Windows.DataPresenter.ExportProcessResult.Cancelled;
				exporter.EndExport(cancelled);
			}
			finally
			{
				dataPresenterExportControl.IsExporting = false;
				dataPresenterExportControl.OnEndExport();
				this._source.ExportStatus = global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting;
				global::Infragistics.Windows.DataPresenter.ExportHelper.SynchronousExportCount--;
			}
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0004A484 File Offset: 0x00048684
		internal void ExportAsync(global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync exporter, global::Infragistics.Windows.DataPresenter.IExportOptions options, bool showExportStatus)
		{
			this.ExportAsync(exporter, options, showExportStatus, global::System.TimeSpan.FromMilliseconds(50.0), global::System.TimeSpan.FromMilliseconds(20.0));
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0004A4AC File Offset: 0x000486AC
		internal void ExportAsync(global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync exporter, global::Infragistics.Windows.DataPresenter.IExportOptions options, bool showExportStatus, global::System.TimeSpan duration, global::System.TimeSpan interval)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(exporter, "exporter");
			global::Infragistics.CoreUtilities.ValidateNotNull(options, "options");
			if (duration.Ticks <= 0L)
			{
				throw new global::System.ArgumentOutOfRangeException("duration");
			}
			if (interval.Ticks <= 0L)
			{
				throw new global::System.ArgumentOutOfRangeException("interval");
			}
			this.ValidateCanExport();
			global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request = new global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest(this, exporter, options, duration, interval, showExportStatus);
			global::Infragistics.Windows.DataPresenter.ExportHelper.AddAsyncExport(request);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0004A515 File Offset: 0x00048715
		internal void RemoveStatusControl(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl ctrl)
		{
			if (this._statusControls != null)
			{
				this._statusControls.Remove(ctrl);
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0004A52C File Offset: 0x0004872C
		private static void AddAsyncExport(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request)
		{
			if (global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations == null)
			{
				global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest>();
			}
			if (request.ExportHelper._requestList == null)
			{
				request.ExportHelper._requestList = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest>();
			}
			global::Infragistics.Windows.DataPresenter.ExportHelper exportHelper = request.ExportHelper;
			if (exportHelper._source.ExportStatus == global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting)
			{
				exportHelper.UpdateAsyncStatus(request, global::Infragistics.Windows.DataPresenter.RecordExportStatus.Pending);
			}
			global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations.Add(request);
			exportHelper._requestList.Add(request);
			global::Infragistics.Windows.DataPresenter.ExportHelper.StartTimer();
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0004A5A0 File Offset: 0x000487A0
		private void InitializeExportControl(global::Infragistics.Windows.DataPresenter.DataPresenterExportControl exportControl, global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			exportControl.BeginInit();
			exportControl.IsExporting = true;
			global::Infragistics.Windows.DataPresenter.ViewBase viewBase;
			if (exportControl.SourceDataPresenter.CurrentViewInternal is global::Infragistics.Windows.DataPresenter.GridViewBase)
			{
				viewBase = (global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase.CloneHelper(exportControl.SourceDataPresenter.CurrentViewInternal, false) as global::Infragistics.Windows.DataPresenter.ViewBase);
				global::Infragistics.Windows.DataPresenter.GridView gridView = viewBase as global::Infragistics.Windows.DataPresenter.GridView;
				if (gridView != null && gridView.ViewSettings != null)
				{
					gridView.ViewSettings.Orientation = global::System.Windows.Controls.Orientation.Vertical;
				}
			}
			else
			{
				viewBase = new global::Infragistics.Windows.DataPresenter.GridView();
			}
			viewBase.IsForExport = true;
			exportControl.CurrentViewInternal = viewBase;
			exportControl.CloneSourceDataPresenter(null, options);
			exportControl.EndInit();
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in exportControl.FieldLayouts)
			{
				fieldLayout.EnsureStyleGeneratorInitialized();
				fieldLayout.VerifyStyleGeneratorTemplates();
			}
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0004A66C File Offset: 0x0004886C
		private static void InitializeRequestEnumerator(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request)
		{
			request.ExportHelper.UpdateAsyncStatus(request, global::Infragistics.Windows.DataPresenter.RecordExportStatus.Exporting);
			request.InvokedBeginExport = true;
			request.Exporter.BeginExport(request.ExportControl, request.ExportOptions);
			request.ExportControl.BindToDataSource();
			request.ExportRecordEnumerator = new global::Infragistics.Windows.DataPresenter.ExportRecordEnumerator(request.ExportControl, request.ExportControl.ViewableRecords, request.ExportOptions);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0004A6D1 File Offset: 0x000488D1
		private static void InitializeRequestExportControl(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request)
		{
			request.ExportControl = new global::Infragistics.Windows.DataPresenter.DataPresenterExportControl(request.ExportHelper._source, request.Exporter);
			request.ExportHelper.InitializeExportControl(request.ExportControl, request.ExportOptions);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0004A706 File Offset: 0x00048906
		private static void InitializeRequestInfo(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request)
		{
			if (request.ExportControl == null)
			{
				global::Infragistics.Windows.DataPresenter.ExportHelper.InitializeRequestExportControl(request);
				return;
			}
			if (request.ExportRecordEnumerator == null)
			{
				global::Infragistics.Windows.DataPresenter.ExportHelper.InitializeRequestEnumerator(request);
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0004A725 File Offset: 0x00048925
		private static void OnAsyncTimerTick(object sender, global::System.EventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.ExportHelper.ProcessAsyncExportBlock();
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0004A768 File Offset: 0x00048968
		private static void ProcessAsyncExportBlock()
		{
			global::Infragistics.Windows.DataPresenter.ExportHelper.StopTimer();
			if (global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations != null)
			{
				global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest nextRequest = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(global::Infragistics.Windows.DataPresenter.ExportHelper._currentRequest) as global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest;
				if (nextRequest != null)
				{
					bool flag = false;
					try
					{
						global::Infragistics.Windows.DataPresenter.ExportHelper._isProcessingCurrentRequest = true;
						global::System.Threading.Tasks.Task task;
						bool continueExport = global::Infragistics.Windows.DataPresenter.ExportHelper.ProcessAsyncExportBlock(nextRequest, out task);
						if (task != null)
						{
							task.ContinueWith(delegate(global::System.Threading.Tasks.Task t)
							{
								global::Infragistics.Windows.DataPresenter.ExportHelper.AfterProcessAsyncExportBlock1(ref nextRequest, continueExport);
							}, global::System.Threading.CancellationToken.None, global::System.Threading.Tasks.TaskContinuationOptions.NotOnFaulted, global::Infragistics.Windows.DataPresenter.GridUtilities.GetCurrentTaskScheduler()).ContinueWith(delegate(global::System.Threading.Tasks.Task t)
							{
								global::Infragistics.Windows.DataPresenter.ExportHelper.AfterProcessAsyncExportBlock2();
							}, global::System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously).ContinueWith(delegate(global::System.Threading.Tasks.Task t)
							{
								global::Infragistics.Windows.DataPresenter.ExportHelper.AfterProcessAsyncExportBlock3(nextRequest);
							}, global::System.Threading.Tasks.TaskContinuationOptions.NotOnFaulted | global::System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously);
							task.Start();
							flag = true;
							return;
						}
						global::Infragistics.Windows.DataPresenter.ExportHelper.AfterProcessAsyncExportBlock1(ref nextRequest, continueExport);
					}
					finally
					{
						if (!flag)
						{
							global::Infragistics.Windows.DataPresenter.ExportHelper.AfterProcessAsyncExportBlock2();
						}
					}
				}
				global::Infragistics.Windows.DataPresenter.ExportHelper.AfterProcessAsyncExportBlock3(nextRequest);
			}
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0004A890 File Offset: 0x00048A90
		private static void AfterProcessAsyncExportBlock1(ref global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest nextRequest, bool continueExport)
		{
			if (!continueExport || nextRequest.CancelRequested)
			{
				global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations.Remove(nextRequest);
				if (nextRequest.ExportHelper != null && nextRequest.ExportHelper._requestList != null)
				{
					nextRequest.ExportHelper._requestList.Remove(nextRequest);
				}
				global::Infragistics.Windows.DataPresenter.ExportHelper._currentRequest = null;
				if (continueExport && nextRequest.CancelRequested)
				{
					nextRequest.CancelExport(global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason.Cancelled, null);
				}
				nextRequest = null;
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0004A8FF File Offset: 0x00048AFF
		private static void AfterProcessAsyncExportBlock2()
		{
			global::Infragistics.Windows.DataPresenter.ExportHelper._isProcessingCurrentRequest = false;
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0004A907 File Offset: 0x00048B07
		private static void AfterProcessAsyncExportBlock3(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest nextRequest)
		{
			if (nextRequest != null)
			{
				global::Infragistics.Windows.DataPresenter.ExportHelper.StartTimer(nextRequest.InterProcessDelay);
				return;
			}
			global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations.Compact();
			global::Infragistics.Windows.DataPresenter.ExportHelper.StartTimer();
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0004A928 File Offset: 0x00048B28
		private static bool ProcessAsyncExportBlock(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request, out global::System.Threading.Tasks.Task task)
		{
			task = null;
			bool result;
			try
			{
				if (request.PendingEndExportResult != null)
				{
					global::Infragistics.Windows.DataPresenter.ExportProcessResult value = request.PendingEndExportResult.Value;
					request.PendingEndExportResult = null;
					switch (value)
					{
					case global::Infragistics.Windows.DataPresenter.ExportProcessResult.Completed:
						task = request.EndExport();
						return false;
					case global::Infragistics.Windows.DataPresenter.ExportProcessResult.Cancelled:
						request.CancelExport(global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason.TerminateExport, null);
						return false;
					}
				}
				if (request.ExportRecordEnumerator != null)
				{
					global::Infragistics.Windows.DataPresenter.ExportProcessResult value2 = request.ExportRecordEnumerator.Process(new global::System.TimeSpan?(request.ProcessDuration));
					request.ExportHelper.UpdateRecordCount(request.ExportRecordEnumerator.ProcessedRecordCount);
					switch (value2)
					{
					case global::Infragistics.Windows.DataPresenter.ExportProcessResult.Completed:
					case global::Infragistics.Windows.DataPresenter.ExportProcessResult.Cancelled:
						request.PendingEndExportResult = new global::Infragistics.Windows.DataPresenter.ExportProcessResult?(value2);
						result = true;
						break;
					case global::Infragistics.Windows.DataPresenter.ExportProcessResult.Timeout:
						result = true;
						break;
					default:
						request.CancelExport(global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason.Cancelled, null);
						result = false;
						break;
					}
				}
				else if (!request.EnumeratedSourceRecords)
				{
					request.ExportHelper.UpdateAsyncStatus(request, global::Infragistics.Windows.DataPresenter.RecordExportStatus.Initializing);
					global::Infragistics.Windows.DataPresenter.ExportProcessResult exportProcessResult = request.SourceRecordEnumerator.Process(request.ProcessDuration);
					if (exportProcessResult == global::Infragistics.Windows.DataPresenter.ExportProcessResult.Timeout)
					{
						result = true;
					}
					else if (exportProcessResult == global::Infragistics.Windows.DataPresenter.ExportProcessResult.Cancelled)
					{
						request.CancelExport(global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason.Cancelled, null);
						result = false;
					}
					else
					{
						request.EnumeratedSourceRecords = true;
						result = true;
					}
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.ExportHelper.InitializeRequestInfo(request);
					result = true;
				}
			}
			catch (global::System.Exception exception)
			{
				request.CancelExport(global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason.Exception, exception);
				result = false;
			}
			return result;
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0004AA88 File Offset: 0x00048C88
		private void RemoveInternalStatusControl()
		{
			if (this._internalStatusControl != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordExportStatusControl internalStatusControl = this._internalStatusControl;
				this._internalStatusControl = null;
				this._source.RemoveStatusControl(internalStatusControl);
			}
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0004AAB8 File Offset: 0x00048CB8
		private void ShowInternalStatusControl(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request)
		{
			this.RemoveInternalStatusControl();
			global::Infragistics.Windows.DataPresenter.RecordExportStatusControl recordExportStatusControl = new global::Infragistics.Windows.DataPresenter.RecordExportStatusControl();
			recordExportStatusControl.DataPresenter = this._source;
			recordExportStatusControl.ExportInfo = request.Exporter.ExportInfo;
			this._internalStatusControl = recordExportStatusControl;
			this._source.AddStatusControl(recordExportStatusControl);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0004AB04 File Offset: 0x00048D04
		private static void StartTimer()
		{
			if (global::Infragistics.Windows.DataPresenter.ExportHelper._isProcessingCurrentRequest)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest exportRequest = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(global::Infragistics.Windows.DataPresenter.ExportHelper._currentRequest) as global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest;
			if (exportRequest != null && global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportTimer != null && global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportTimer.IsEnabled)
			{
				return;
			}
			if (global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations != null)
			{
				for (int i = 0; i < global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations.Count; i++)
				{
					exportRequest = global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations[i];
					if (exportRequest != null)
					{
						break;
					}
				}
			}
			global::Infragistics.Windows.DataPresenter.ExportHelper._currentRequest = ((exportRequest == null) ? null : new global::System.WeakReference(exportRequest));
			if (exportRequest == null)
			{
				global::Infragistics.Windows.DataPresenter.ExportHelper.StopTimer();
				return;
			}
			global::Infragistics.Windows.DataPresenter.ExportHelper.StartTimer(exportRequest.InterProcessDelay);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0004AB90 File Offset: 0x00048D90
		private static void StartTimer(global::System.TimeSpan interval)
		{
			if (global::Infragistics.Windows.DataPresenter.ExportHelper._synchronousExportCount > 0)
			{
				return;
			}
			if (interval.TotalMilliseconds > 2147483647.0)
			{
				interval = global::System.TimeSpan.FromMilliseconds(2147483647.0);
			}
			if (global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportTimer == null)
			{
				global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportTimer = new global::System.Windows.Threading.DispatcherTimer(interval, global::System.Windows.Threading.DispatcherPriority.Background, new global::System.EventHandler(global::Infragistics.Windows.DataPresenter.ExportHelper.OnAsyncTimerTick), global::System.Windows.Threading.Dispatcher.CurrentDispatcher);
			}
			global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportTimer.Interval = interval;
			global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportTimer.Start();
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0004AC01 File Offset: 0x00048E01
		private static void StopTimer()
		{
			if (global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportTimer != null)
			{
				global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportTimer.Stop();
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0004AC14 File Offset: 0x00048E14
		private void UpdateAsyncStatus(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request, global::Infragistics.Windows.DataPresenter.RecordExportStatus status)
		{
			this._source.ExportStatus = status;
			if (status != global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting && request.ShowExportStatus)
			{
				request.ShowExportStatus = false;
				this.ShowInternalStatusControl(request);
			}
			if (this._statusControls != null)
			{
				global::Infragistics.Windows.DataPresenter.ExportInfo exportInfo = (status == global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting) ? null : request.Exporter.ExportInfo;
				foreach (global::Infragistics.Windows.DataPresenter.RecordExportStatusControl recordExportStatusControl in this._statusControls)
				{
					if (recordExportStatusControl != null)
					{
						recordExportStatusControl.Status = status;
						recordExportStatusControl.ExportInfo = exportInfo;
					}
				}
			}
			if (status == global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting)
			{
				this.RemoveInternalStatusControl();
			}
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0004ACB4 File Offset: 0x00048EB4
		private void UpdateRecordCount(int processedRecordCount)
		{
			if (this._statusControls != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.RecordExportStatusControl recordExportStatusControl in this._statusControls)
				{
					if (recordExportStatusControl != null)
					{
						recordExportStatusControl.ExportedRecordCount = processedRecordCount;
					}
				}
			}
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0004AD0C File Offset: 0x00048F0C
		private void ValidateCanExport()
		{
			if (this._source.IsExporting)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("Export_CannotExportMultipleTimes"));
			}
		}

		// Token: 0x0400069B RID: 1691
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _source;

		// Token: 0x0400069C RID: 1692
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest> _requestList;

		// Token: 0x0400069D RID: 1693
		private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.RecordExportStatusControl> _statusControls;

		// Token: 0x0400069E RID: 1694
		private global::Infragistics.Windows.DataPresenter.RecordExportStatusControl _internalStatusControl;

		// Token: 0x0400069F RID: 1695
		[global::System.ThreadStatic]
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest> _asyncExportOperations;

		// Token: 0x040006A0 RID: 1696
		[global::System.ThreadStatic]
		private static global::System.Windows.Threading.DispatcherTimer _asyncExportTimer;

		// Token: 0x040006A1 RID: 1697
		[global::System.ThreadStatic]
		private static global::System.WeakReference _currentRequest;

		// Token: 0x040006A2 RID: 1698
		[global::System.ThreadStatic]
		private static bool _isProcessingCurrentRequest;

		// Token: 0x040006A3 RID: 1699
		[global::System.ThreadStatic]
		private static int _synchronousExportCount;

		// Token: 0x0200010F RID: 271
		private class ExportRequest
		{
			// Token: 0x060010BC RID: 4284 RVA: 0x0004AD2C File Offset: 0x00048F2C
			internal ExportRequest(global::Infragistics.Windows.DataPresenter.ExportHelper exportHelper, global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync exporter, global::Infragistics.Windows.DataPresenter.IExportOptions options, global::System.TimeSpan processDuration, global::System.TimeSpan interprocessDelay, bool showExportStatus)
			{
				this.ExportHelper = exportHelper;
				this.Exporter = exporter;
				this.ExportOptions = options;
				this.ProcessDuration = processDuration;
				this.InterProcessDelay = interprocessDelay;
				this.SourceRecordEnumerator = new global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator(exportHelper._source.RecordManager);
				this.ShowExportStatus = showExportStatus;
			}

			// Token: 0x060010BD RID: 4285 RVA: 0x0004AD82 File Offset: 0x00048F82
			internal void CancelExport(global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason reason, global::System.Exception exception)
			{
				this.Exporter.CancelExport(new global::Infragistics.Windows.DataPresenter.RecordExportCancellationInfo(reason, exception));
				this.EndExport(true).Start(global::Infragistics.Windows.DataPresenter.GridUtilities.GetCurrentTaskScheduler());
			}

			// Token: 0x060010BE RID: 4286 RVA: 0x0004ADA7 File Offset: 0x00048FA7
			internal global::System.Threading.Tasks.Task EndExport()
			{
				return this.EndExport(false);
			}

			// Token: 0x060010BF RID: 4287 RVA: 0x0004AE10 File Offset: 0x00049010
			private global::System.Threading.Tasks.Task EndExport(bool cancelled)
			{
				global::System.Threading.Tasks.Task task = this.Exporter.EndExportAsync(cancelled);
				task.ContinueWith(delegate(global::System.Threading.Tasks.Task t)
				{
					if (this.ExportControl != null)
					{
						this.ExportControl.IsExporting = false;
						this.ExportControl.OnEndExport();
					}
					this.ExportHelper.UpdateAsyncStatus(this, global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting);
				}, global::System.Threading.CancellationToken.None, global::System.Threading.Tasks.TaskContinuationOptions.None, global::Infragistics.Windows.DataPresenter.GridUtilities.GetCurrentTaskScheduler());
				return new global::System.Threading.Tasks.Task(delegate()
				{
					if (task.Status == global::System.Threading.Tasks.TaskStatus.Created)
					{
						task.Start(global::System.Threading.Tasks.TaskScheduler.Current);
					}
					task.Wait();
				});
			}

			// Token: 0x040006A5 RID: 1701
			internal readonly global::Infragistics.Windows.DataPresenter.ExportHelper ExportHelper;

			// Token: 0x040006A6 RID: 1702
			internal readonly global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync Exporter;

			// Token: 0x040006A7 RID: 1703
			internal readonly global::Infragistics.Windows.DataPresenter.IExportOptions ExportOptions;

			// Token: 0x040006A8 RID: 1704
			internal readonly global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator SourceRecordEnumerator;

			// Token: 0x040006A9 RID: 1705
			internal readonly global::System.TimeSpan ProcessDuration;

			// Token: 0x040006AA RID: 1706
			internal readonly global::System.TimeSpan InterProcessDelay;

			// Token: 0x040006AB RID: 1707
			internal global::Infragistics.Windows.DataPresenter.DataPresenterExportControl ExportControl;

			// Token: 0x040006AC RID: 1708
			internal global::Infragistics.Windows.DataPresenter.ExportRecordEnumerator ExportRecordEnumerator;

			// Token: 0x040006AD RID: 1709
			internal bool InvokedBeginExport;

			// Token: 0x040006AE RID: 1710
			internal bool EnumeratedSourceRecords;

			// Token: 0x040006AF RID: 1711
			internal bool CancelRequested;

			// Token: 0x040006B0 RID: 1712
			internal bool ShowExportStatus;

			// Token: 0x040006B1 RID: 1713
			internal global::Infragistics.Windows.DataPresenter.ExportProcessResult? PendingEndExportResult;
		}
	}
}
