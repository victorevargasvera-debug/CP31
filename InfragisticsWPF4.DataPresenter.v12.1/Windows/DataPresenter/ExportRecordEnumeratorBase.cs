using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000F3 RID: 243
	internal abstract class ExportRecordEnumeratorBase
	{
		// Token: 0x06000D4F RID: 3407 RVA: 0x0003A303 File Offset: 0x00038503
		internal ExportRecordEnumeratorBase(global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase exportControl, global::Infragistics.Windows.DataPresenter.ViewableRecordCollection sourceRecords, global::Infragistics.Windows.DataPresenter.IExportOptions exportOptions)
		{
			this._exportControl = exportControl;
			this._rootCollection = sourceRecords;
			this._exportOptions = exportOptions;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0003A320 File Offset: 0x00038520
		internal global::Infragistics.Windows.DataPresenter.ExportProcessResult Process(global::System.TimeSpan? duration)
		{
			if (this._previousResult != null && this._previousResult.Value != global::Infragistics.Windows.DataPresenter.ExportProcessResult.Timeout)
			{
				return this._previousResult.Value;
			}
			int? num = (duration != null) ? new int?((int)global::System.Math.Round(duration.Value.TotalMilliseconds, global::System.MidpointRounding.AwayFromZero)) : null;
			int tickCount = global::System.Environment.TickCount;
			global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState state = (this._currentLevel == null) ? global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.InitializeLevel : this._currentLevel.State;
			global::Infragistics.Windows.DataPresenter.Record record = (this._currentLevel == null) ? null : this._currentLevel.Record;
			global::Infragistics.Windows.DataPresenter.ProcessRecordParams processRecordParams = (this._currentLevel == null) ? null : this._currentLevel.RecordParams;
			for (;;)
			{
				switch (state)
				{
				case global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.InitializeLevel:
					if (this._levels == null)
					{
						this._levels = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.LevelInfo>();
						this.StartLevel(this._rootCollection, null);
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded = record.ViewableChildRecordsIfNeeded;
						if (viewableChildRecordsIfNeeded == null || viewableChildRecordsIfNeeded.Count == 0)
						{
							state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingRecordAfter;
							continue;
						}
						this._currentLevel.State = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingRecordAfter;
						this.StartLevel(viewableChildRecordsIfNeeded, this._currentLevel.RecordManager);
					}
					record = null;
					processRecordParams = this._currentLevel.RecordParams;
					state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.EnumeratingRecords;
					goto IL_292;
				case global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.EnumeratingRecords:
					record = this._currentLevel.MoveNext();
					if (record != null)
					{
						if (record is global::Infragistics.Windows.DataPresenter.FilterRecord)
						{
							continue;
						}
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
						if (dataRecord == null || !dataRecord.IsAddRecord)
						{
							this.PrepareRecord(record);
							state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.InitializingRecordParams;
							goto IL_292;
						}
						continue;
					}
					else
					{
						if (!this.EndLevel(ref state, ref record, ref processRecordParams))
						{
							goto Block_13;
						}
						continue;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.InitializingRecordParams:
				{
					bool flag = this.InitializeRecordParams(record, processRecordParams);
					if (processRecordParams.TerminateExport)
					{
						goto Block_14;
					}
					if (!flag)
					{
						this._currentLevel.ProcessRecordAfterChildren = false;
					}
					if (!processRecordParams.SkipDescendants && !record.HasChildrenInternal)
					{
						processRecordParams.SkipDescendants = true;
					}
					if (flag && !this._currentLevel.ProcessRecordAfterChildren)
					{
						state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingRecordBefore;
						goto IL_292;
					}
					if (!processRecordParams.SkipDescendants)
					{
						state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.InitializeLevel;
						goto IL_292;
					}
					state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingRecordAfter;
					goto IL_292;
				}
				case global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingRecordBefore:
					this.ProcessRecord(record, processRecordParams);
					if (processRecordParams.TerminateExport)
					{
						goto Block_21;
					}
					if (!processRecordParams.SkipDescendants)
					{
						state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.InitializeLevel;
						goto IL_292;
					}
					state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingRecordAfter;
					goto IL_292;
				case global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingRecordAfter:
					if (this._currentLevel.ProcessRecordAfterChildren)
					{
						this.ProcessRecord(record, processRecordParams);
						if (processRecordParams.TerminateExport)
						{
							goto Block_24;
						}
					}
					if (processRecordParams.SkipSiblings)
					{
						if (!this.EndLevel(ref state, ref record, ref processRecordParams))
						{
							goto Block_26;
						}
						goto IL_292;
					}
					else
					{
						state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.EnumeratingRecords;
						if (!this._currentLevel.ProcessRecordAfterChildren)
						{
							continue;
						}
						goto IL_292;
					}
					break;
				}
				break;
				IL_292:
				if (num != null && global::System.Environment.TickCount - tickCount > num.Value)
				{
					goto Block_29;
				}
			}
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Cancelled);
			Block_13:
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Completed);
			Block_14:
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Cancelled);
			Block_21:
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Cancelled);
			Block_24:
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Cancelled);
			Block_26:
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Completed);
			Block_29:
			this._currentLevel.State = state;
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Timeout);
		}

		// Token: 0x06000D51 RID: 3409
		protected abstract bool InitializeRecordParams(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams recordParams);

		// Token: 0x06000D52 RID: 3410
		protected abstract void ProcessRecord(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams recordParams);

		// Token: 0x06000D53 RID: 3411 RVA: 0x0003A5F4 File Offset: 0x000387F4
		private bool EndLevel(ref global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState state, ref global::Infragistics.Windows.DataPresenter.Record currentRecord, ref global::Infragistics.Windows.DataPresenter.ProcessRecordParams currentRecordParams)
		{
			global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.LevelInfo item = this._levels.Pop();
			if (this._levels.Count == 0)
			{
				return false;
			}
			if (this._availableLevels == null)
			{
				this._availableLevels = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.LevelInfo>();
			}
			this._availableLevels.Add(item);
			this._currentLevel = this._levels.Peek();
			state = this._currentLevel.State;
			currentRecordParams = this._currentLevel.RecordParams;
			currentRecord = this._currentLevel.Record;
			return true;
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0003A674 File Offset: 0x00038874
		private void InitializeRecordManager(global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			if (recordManager != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager associatedRecordManager = recordManager.AssociatedRecordManager;
				if (associatedRecordManager != null && (this._exportOptions == null || !this._exportOptions.ExcludeRecordFilters) && !recordManager.IsRootManager && recordManager.RecordFilters.Count == 0 && associatedRecordManager.RecordFiltersIfAllocated != null)
				{
					recordManager.RecordFilters.CloneFrom(associatedRecordManager.RecordFilters);
				}
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = associatedRecordManager.ViewableRecords;
				if (viewableRecords != null && viewableRecords.CountOfFixedRecordsOnBottom + viewableRecords.CountOfFixedRecordsOnTop > 0)
				{
					recordManager.ViewableRecords.CloneFixedRecords(viewableRecords);
				}
			}
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0003A6F8 File Offset: 0x000388F8
		private void PrepareRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.Record associatedRecord = record.GetAssociatedRecord();
			if (associatedRecord != null)
			{
				record.CloneAssociatedRecordSettings(associatedRecord, this._exportOptions);
			}
			this._exportControl.BypassInitializeRecordEvent = false;
			this._exportControl.RaiseInitializeRecord(record, false, false);
			this._exportControl.BypassInitializeRecordEvent = true;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0003A744 File Offset: 0x00038944
		private void StartLevel(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection sourceRecords, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager2 = sourceRecords.RecordManager;
			if (recordManager2 != recordManager)
			{
				this.InitializeRecordManager(recordManager2);
				recordManager = recordManager2;
			}
			global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.LevelInfo levelInfo;
			if (this._availableLevels == null || this._availableLevels.Count == 0)
			{
				levelInfo = new global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.LevelInfo(sourceRecords, recordManager);
			}
			else
			{
				int index = this._availableLevels.Count - 1;
				levelInfo = this._availableLevels[index];
				this._availableLevels.RemoveAt(index);
				levelInfo.Initialize(sourceRecords, recordManager);
			}
			this._currentLevel = levelInfo;
			this._levels.Push(levelInfo);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0003A7C7 File Offset: 0x000389C7
		private global::Infragistics.Windows.DataPresenter.ExportProcessResult StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult result)
		{
			this._previousResult = new global::Infragistics.Windows.DataPresenter.ExportProcessResult?(result);
			return result;
		}

		// Token: 0x04000517 RID: 1303
		private global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase _exportControl;

		// Token: 0x04000518 RID: 1304
		private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _rootCollection;

		// Token: 0x04000519 RID: 1305
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.LevelInfo> _levels;

		// Token: 0x0400051A RID: 1306
		private global::Infragistics.Windows.DataPresenter.IExportOptions _exportOptions;

		// Token: 0x0400051B RID: 1307
		private global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.LevelInfo _currentLevel;

		// Token: 0x0400051C RID: 1308
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.LevelInfo> _availableLevels;

		// Token: 0x0400051D RID: 1309
		private global::Infragistics.Windows.DataPresenter.ExportProcessResult? _previousResult;

		// Token: 0x020000F4 RID: 244
		private enum CurrentState
		{
			// Token: 0x0400051F RID: 1311
			InitializeLevel,
			// Token: 0x04000520 RID: 1312
			EnumeratingRecords,
			// Token: 0x04000521 RID: 1313
			InitializingRecordParams,
			// Token: 0x04000522 RID: 1314
			ProcessingRecordBefore,
			// Token: 0x04000523 RID: 1315
			ProcessingRecordAfter
		}

		// Token: 0x020000F5 RID: 245
		private class LevelInfo
		{
			// Token: 0x06000D58 RID: 3416 RVA: 0x0003A7D6 File Offset: 0x000389D6
			internal LevelInfo(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection sourceRecords, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
			{
				this.Initialize(sourceRecords, recordManager);
			}

			// Token: 0x06000D59 RID: 3417 RVA: 0x0003A7E8 File Offset: 0x000389E8
			internal void Initialize(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection sourceRecords, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
			{
				this.SourceRecordCollection = sourceRecords;
				this.RecordManager = recordManager;
				this._recordList = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>(sourceRecords);
				this._recordListCount = this._recordList.Count;
				this.RecordParams = new global::Infragistics.Windows.DataPresenter.ProcessRecordParams();
				this._recordIndex = 0;
				this.Record = null;
			}

			// Token: 0x06000D5A RID: 3418 RVA: 0x0003A83C File Offset: 0x00038A3C
			internal global::Infragistics.Windows.DataPresenter.Record MoveNext()
			{
				if (this._recordIndex >= this._recordListCount)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.Record record = this._recordList[this._recordIndex++];
				this.Record = record;
				this.ProcessRecordAfterChildren = !record.AreChildrenAfterParent;
				this.RecordParams.Reset();
				return record;
			}

			// Token: 0x04000524 RID: 1316
			internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection SourceRecordCollection;

			// Token: 0x04000525 RID: 1317
			internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManager;

			// Token: 0x04000526 RID: 1318
			internal global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState State;

			// Token: 0x04000527 RID: 1319
			internal global::Infragistics.Windows.DataPresenter.Record Record;

			// Token: 0x04000528 RID: 1320
			internal bool ProcessRecordAfterChildren;

			// Token: 0x04000529 RID: 1321
			internal global::Infragistics.Windows.DataPresenter.ProcessRecordParams RecordParams;

			// Token: 0x0400052A RID: 1322
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _recordList;

			// Token: 0x0400052B RID: 1323
			private int _recordListCount;

			// Token: 0x0400052C RID: 1324
			private int _recordIndex;
		}
	}
}
