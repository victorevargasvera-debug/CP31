using System;
using System.Collections.Generic;
using System.Windows.Threading;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000F0 RID: 240
	internal class ExportHelper
	{
		// Token: 0x06000D26 RID: 3366 RVA: 0x0003983F File Offset: 0x00037A3F
		internal ExportHelper(global::Infragistics.Windows.DataPresenter.DataPresenterBase source)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(source, "source");
			this._source = source;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x00039859 File Offset: 0x00037A59
		internal global::Infragistics.Windows.DataPresenter.RecordExportStatusControl InternalStatusControl
		{
			get
			{
				return this._internalStatusControl;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x00039861 File Offset: 0x00037A61
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x00039868 File Offset: 0x00037A68
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

		// Token: 0x06000D2A RID: 3370 RVA: 0x00039890 File Offset: 0x00037A90
		internal void AccessAllRecords()
		{
			global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator exportSourceRecordEnumerator = new global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator(this._source.RecordManager);
			while (exportSourceRecordEnumerator.MoveNext())
			{
			}
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x000398B6 File Offset: 0x00037AB6
		internal void AddStatusControl(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl ctrl)
		{
			if (this._statusControls == null)
			{
				this._statusControls = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.RecordExportStatusControl>();
			}
			this._statusControls.Add(ctrl);
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x000398D8 File Offset: 0x00037AD8
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

		// Token: 0x06000D2D RID: 3373 RVA: 0x00039928 File Offset: 0x00037B28
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

		// Token: 0x06000D2E RID: 3374 RVA: 0x00039970 File Offset: 0x00037B70
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
					global::Infragistics.Windows.DataPresenter.ExportHelper.StopTimer();
				}
				request.CancelExport(global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason.Cancelled, null);
				global::Infragistics.Windows.DataPresenter.ExportHelper.StartTimer();
			}
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x000399C4 File Offset: 0x00037BC4
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

		// Token: 0x06000D30 RID: 3376 RVA: 0x00039A98 File Offset: 0x00037C98
		internal void ExportAsync(global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync exporter, global::Infragistics.Windows.DataPresenter.IExportOptions options, bool showExportStatus)
		{
			this.ExportAsync(exporter, options, showExportStatus, global::System.TimeSpan.FromMilliseconds(50.0), global::System.TimeSpan.FromMilliseconds(20.0));
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00039AC0 File Offset: 0x00037CC0
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

		// Token: 0x06000D32 RID: 3378 RVA: 0x00039B29 File Offset: 0x00037D29
		internal void RemoveStatusControl(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl ctrl)
		{
			if (this._statusControls != null)
			{
				this._statusControls.Remove(ctrl);
			}
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00039B40 File Offset: 0x00037D40
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

		// Token: 0x06000D34 RID: 3380 RVA: 0x00039BB4 File Offset: 0x00037DB4
		private void InitializeExportControl(global::Infragistics.Windows.DataPresenter.DataPresenterExportControl exportControl, global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			exportControl.BeginInit();
			exportControl.IsExporting = true;
			exportControl.CurrentViewInternal = new global::Infragistics.Windows.DataPresenter.ExportView();
			exportControl.CloneSourceDataPresenter(null, options);
			exportControl.EndInit();
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in exportControl.FieldLayouts)
			{
				fieldLayout.EnsureStyleGeneratorInitialized();
				fieldLayout.VerifyStyleGeneratorTemplates();
			}
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00039C2C File Offset: 0x00037E2C
		private static void InitializeRequestEnumerator(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request)
		{
			request.ExportHelper.UpdateAsyncStatus(request, global::Infragistics.Windows.DataPresenter.RecordExportStatus.Exporting);
			request.InvokedBeginExport = true;
			request.Exporter.BeginExport(request.ExportControl, request.ExportOptions);
			request.ExportControl.BindToDataSource();
			request.ExportRecordEnumerator = new global::Infragistics.Windows.DataPresenter.ExportRecordEnumerator(request.ExportControl, request.ExportControl.ViewableRecords, request.ExportOptions);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00039C91 File Offset: 0x00037E91
		private static void InitializeRequestExportControl(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request)
		{
			request.ExportControl = new global::Infragistics.Windows.DataPresenter.DataPresenterExportControl(request.ExportHelper._source, request.Exporter);
			request.ExportHelper.InitializeExportControl(request.ExportControl, request.ExportOptions);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00039CC6 File Offset: 0x00037EC6
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

		// Token: 0x06000D38 RID: 3384 RVA: 0x00039CE5 File Offset: 0x00037EE5
		private static void OnAsyncTimerTick(object sender, global::System.EventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.ExportHelper.ProcessAsyncExportBlock();
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00039CEC File Offset: 0x00037EEC
		private static void ProcessAsyncExportBlock()
		{
			global::Infragistics.Windows.DataPresenter.ExportHelper.StopTimer();
			if (global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations != null)
			{
				global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest exportRequest = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(global::Infragistics.Windows.DataPresenter.ExportHelper._currentRequest) as global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest;
				if (exportRequest != null)
				{
					try
					{
						global::Infragistics.Windows.DataPresenter.ExportHelper._isProcessingCurrentRequest = true;
						bool flag = global::Infragistics.Windows.DataPresenter.ExportHelper.ProcessAsyncExportBlock(exportRequest);
						if (!flag || exportRequest.CancelRequested)
						{
							global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations.Remove(exportRequest);
							global::Infragistics.Windows.DataPresenter.ExportHelper._currentRequest = null;
							if (flag && exportRequest.CancelRequested)
							{
								exportRequest.CancelExport(global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason.Cancelled, null);
							}
							exportRequest = null;
						}
					}
					finally
					{
						global::Infragistics.Windows.DataPresenter.ExportHelper._isProcessingCurrentRequest = false;
					}
				}
				if (exportRequest != null)
				{
					global::Infragistics.Windows.DataPresenter.ExportHelper.StartTimer(exportRequest.InterProcessDelay);
					return;
				}
				global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportOperations.Compact();
				global::Infragistics.Windows.DataPresenter.ExportHelper.StartTimer();
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00039D90 File Offset: 0x00037F90
		private static bool ProcessAsyncExportBlock(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request)
		{
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
						request.EndExport();
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

		// Token: 0x06000D3B RID: 3387 RVA: 0x00039EEC File Offset: 0x000380EC
		private void RemoveInternalStatusControl()
		{
			if (this._internalStatusControl != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordExportStatusControl internalStatusControl = this._internalStatusControl;
				this._internalStatusControl = null;
				this._source.RemoveStatusControl(internalStatusControl);
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00039F1C File Offset: 0x0003811C
		private void ShowInternalStatusControl(global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest request)
		{
			this.RemoveInternalStatusControl();
			global::Infragistics.Windows.DataPresenter.RecordExportStatusControl recordExportStatusControl = new global::Infragistics.Windows.DataPresenter.RecordExportStatusControl();
			recordExportStatusControl.DataPresenter = this._source;
			recordExportStatusControl.ExportInfo = request.Exporter.ExportInfo;
			this._internalStatusControl = recordExportStatusControl;
			this._source.AddStatusControl(recordExportStatusControl);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00039F68 File Offset: 0x00038168
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

		// Token: 0x06000D3E RID: 3390 RVA: 0x00039FF4 File Offset: 0x000381F4
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

		// Token: 0x06000D3F RID: 3391 RVA: 0x0003A065 File Offset: 0x00038265
		private static void StopTimer()
		{
			if (global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportTimer != null)
			{
				global::Infragistics.Windows.DataPresenter.ExportHelper._asyncExportTimer.Stop();
			}
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x0003A078 File Offset: 0x00038278
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

		// Token: 0x06000D41 RID: 3393 RVA: 0x0003A118 File Offset: 0x00038318
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

		// Token: 0x06000D42 RID: 3394 RVA: 0x0003A170 File Offset: 0x00038370
		private void ValidateCanExport()
		{
			if (this._source.IsExporting)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("Export_CannotExportMultipleTimes"));
			}
		}

		// Token: 0x040004FE RID: 1278
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _source;

		// Token: 0x040004FF RID: 1279
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest> _requestList;

		// Token: 0x04000500 RID: 1280
		private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.RecordExportStatusControl> _statusControls;

		// Token: 0x04000501 RID: 1281
		private global::Infragistics.Windows.DataPresenter.RecordExportStatusControl _internalStatusControl;

		// Token: 0x04000502 RID: 1282
		[global::System.ThreadStatic]
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.ExportHelper.ExportRequest> _asyncExportOperations;

		// Token: 0x04000503 RID: 1283
		[global::System.ThreadStatic]
		private static global::System.Windows.Threading.DispatcherTimer _asyncExportTimer;

		// Token: 0x04000504 RID: 1284
		[global::System.ThreadStatic]
		private static global::System.WeakReference _currentRequest;

		// Token: 0x04000505 RID: 1285
		[global::System.ThreadStatic]
		private static bool _isProcessingCurrentRequest;

		// Token: 0x04000506 RID: 1286
		[global::System.ThreadStatic]
		private static int _synchronousExportCount;

		// Token: 0x020000F1 RID: 241
		private class ExportRequest
		{
			// Token: 0x06000D43 RID: 3395 RVA: 0x0003A190 File Offset: 0x00038390
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

			// Token: 0x06000D44 RID: 3396 RVA: 0x0003A1E6 File Offset: 0x000383E6
			internal void CancelExport(global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason reason, global::System.Exception exception)
			{
				this.Exporter.CancelExport(new global::Infragistics.Windows.DataPresenter.RecordExportCancellationInfo(reason, exception));
				this.EndExport(true);
			}

			// Token: 0x06000D45 RID: 3397 RVA: 0x0003A201 File Offset: 0x00038401
			internal void EndExport()
			{
				this.EndExport(false);
			}

			// Token: 0x06000D46 RID: 3398 RVA: 0x0003A20A File Offset: 0x0003840A
			private void EndExport(bool cancelled)
			{
				this.Exporter.EndExport(cancelled);
				if (this.ExportControl != null)
				{
					this.ExportControl.IsExporting = false;
					this.ExportControl.OnEndExport();
				}
				this.ExportHelper.UpdateAsyncStatus(this, global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting);
			}

			// Token: 0x04000507 RID: 1287
			internal readonly global::Infragistics.Windows.DataPresenter.ExportHelper ExportHelper;

			// Token: 0x04000508 RID: 1288
			internal readonly global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync Exporter;

			// Token: 0x04000509 RID: 1289
			internal readonly global::Infragistics.Windows.DataPresenter.IExportOptions ExportOptions;

			// Token: 0x0400050A RID: 1290
			internal readonly global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator SourceRecordEnumerator;

			// Token: 0x0400050B RID: 1291
			internal readonly global::System.TimeSpan ProcessDuration;

			// Token: 0x0400050C RID: 1292
			internal readonly global::System.TimeSpan InterProcessDelay;

			// Token: 0x0400050D RID: 1293
			internal global::Infragistics.Windows.DataPresenter.DataPresenterExportControl ExportControl;

			// Token: 0x0400050E RID: 1294
			internal global::Infragistics.Windows.DataPresenter.ExportRecordEnumerator ExportRecordEnumerator;

			// Token: 0x0400050F RID: 1295
			internal bool InvokedBeginExport;

			// Token: 0x04000510 RID: 1296
			internal bool EnumeratedSourceRecords;

			// Token: 0x04000511 RID: 1297
			internal bool CancelRequested;

			// Token: 0x04000512 RID: 1298
			internal bool ShowExportStatus;

			// Token: 0x04000513 RID: 1299
			internal global::Infragistics.Windows.DataPresenter.ExportProcessResult? PendingEndExportResult;
		}
	}
}
