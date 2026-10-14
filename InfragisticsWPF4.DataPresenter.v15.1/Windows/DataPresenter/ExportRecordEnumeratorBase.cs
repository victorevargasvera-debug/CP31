using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000111 RID: 273
	internal abstract class ExportRecordEnumeratorBase
	{
		// Token: 0x060010CB RID: 4299 RVA: 0x0004AF4C File Offset: 0x0004914C
		internal ExportRecordEnumeratorBase(global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase exportControl, global::Infragistics.Windows.DataPresenter.ViewableRecordCollection sourceRecords, global::Infragistics.Windows.DataPresenter.IExportOptions exportOptions)
		{
			this._exportControl = exportControl;
			this._rootCollection = sourceRecords;
			this._exportOptions = exportOptions;
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0004AF6C File Offset: 0x0004916C
		internal global::Infragistics.Windows.DataPresenter.ExportProcessResult Process(global::System.TimeSpan? duration)
		{
			if (this._previousResult != null && this._previousResult.Value != global::Infragistics.Windows.DataPresenter.ExportProcessResult.Timeout)
			{
				return this._previousResult.Value;
			}
			int? num = (duration != null) ? new int?((int)global::System.Math.Round(duration.Value.TotalMilliseconds, global::System.MidpointRounding.AwayFromZero)) : null;
			int tickCount = global::System.Environment.TickCount;
			global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState state = (this._currentLevel == null) ? global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingTreeFilter : this._currentLevel.State;
			global::Infragistics.Windows.DataPresenter.Record record = (this._currentLevel == null) ? null : this._currentLevel.Record;
			global::Infragistics.Windows.DataPresenter.ProcessRecordParams processRecordParams = (this._currentLevel == null) ? null : this._currentLevel.RecordParams;
			for (;;)
			{
				switch (state)
				{
				case global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.InitializeLevel:
					goto IL_18F;
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
							goto IL_385;
						}
						continue;
					}
					else
					{
						if (!this.EndLevel(ref state, ref record, ref processRecordParams))
						{
							goto Block_15;
						}
						continue;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.InitializingRecordParams:
				{
					bool flag = this.InitializeRecordParams(record, processRecordParams);
					if (processRecordParams.TerminateExport)
					{
						goto Block_16;
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
						goto IL_385;
					}
					if (!processRecordParams.SkipDescendants)
					{
						state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.InitializeLevel;
						goto IL_385;
					}
					state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingRecordAfter;
					goto IL_385;
				}
				case global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingRecordBefore:
					this.ProcessRecord(record, processRecordParams);
					if (processRecordParams.TerminateExport)
					{
						goto Block_23;
					}
					if (!processRecordParams.SkipDescendants)
					{
						state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.InitializeLevel;
						goto IL_385;
					}
					state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingRecordAfter;
					goto IL_385;
				case global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingRecordAfter:
					if (this._currentLevel.ProcessRecordAfterChildren)
					{
						this.ProcessRecord(record, processRecordParams);
						if (processRecordParams.TerminateExport)
						{
							goto Block_26;
						}
					}
					if (processRecordParams.SkipSiblings)
					{
						if (!this.EndLevel(ref state, ref record, ref processRecordParams))
						{
							goto Block_28;
						}
						goto IL_385;
					}
					else
					{
						state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.EnumeratingRecords;
						if (!this._currentLevel.ProcessRecordAfterChildren)
						{
							continue;
						}
						goto IL_385;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.ProcessingTreeFilter:
					if (!this._exportControl.SourceDataPresenter.ProcessPendingTreeViewFilterManager(num ?? 100000))
					{
						bool bypassInitializeRecordEvent = this._exportControl.BypassInitializeRecordEvent;
						this._exportControl.BypassInitializeRecordEvent = true;
						try
						{
							if (this._treeViewFilterManager == null)
							{
								this._treeViewFilterManager = new global::Infragistics.Windows.DataPresenter.GridUtilities.TreeViewFilterManager(this._exportControl);
								if (!this._exportControl.IsTreeView || !this._treeViewFilterManager.Start())
								{
									state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.InitializeLevel;
									continue;
								}
							}
							else if (!this._treeViewFilterManager.ProcessRecords(num ?? 100000))
							{
								state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.InitializeLevel;
								continue;
							}
							goto IL_385;
						}
						finally
						{
							this._exportControl.BypassInitializeRecordEvent = bypassInitializeRecordEvent;
						}
						goto IL_18F;
					}
					goto IL_385;
				}
				break;
				IL_18F:
				bool bypassInitializeRecordEvent2 = this._exportControl.BypassInitializeRecordEvent;
				this._exportControl.BypassInitializeRecordEvent = true;
				try
				{
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
				}
				finally
				{
					this._exportControl.BypassInitializeRecordEvent = bypassInitializeRecordEvent2;
				}
				record = null;
				processRecordParams = this._currentLevel.RecordParams;
				state = global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState.EnumeratingRecords;
				IL_385:
				if (num != null && global::System.Environment.TickCount - tickCount > num.Value)
				{
					goto Block_31;
				}
			}
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Cancelled);
			Block_15:
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Completed);
			Block_16:
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Cancelled);
			Block_23:
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Cancelled);
			Block_26:
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Cancelled);
			Block_28:
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Completed);
			Block_31:
			if (this._currentLevel != null)
			{
				this._currentLevel.State = state;
			}
			return this.StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult.Timeout);
		}

		// Token: 0x060010CD RID: 4301
		protected abstract bool InitializeRecordParams(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams recordParams);

		// Token: 0x060010CE RID: 4302
		protected abstract void ProcessRecord(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.ProcessRecordParams recordParams);

		// Token: 0x060010CF RID: 4303 RVA: 0x0004B354 File Offset: 0x00049554
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

		// Token: 0x060010D0 RID: 4304 RVA: 0x0004B3D4 File Offset: 0x000495D4
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

		// Token: 0x060010D1 RID: 4305 RVA: 0x0004B458 File Offset: 0x00049658
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

		// Token: 0x060010D2 RID: 4306 RVA: 0x0004B4A4 File Offset: 0x000496A4
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

		// Token: 0x060010D3 RID: 4307 RVA: 0x0004B527 File Offset: 0x00049727
		private global::Infragistics.Windows.DataPresenter.ExportProcessResult StorePreviousResult(global::Infragistics.Windows.DataPresenter.ExportProcessResult result)
		{
			this._previousResult = new global::Infragistics.Windows.DataPresenter.ExportProcessResult?(result);
			return result;
		}

		// Token: 0x040006B6 RID: 1718
		private global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase _exportControl;

		// Token: 0x040006B7 RID: 1719
		private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _rootCollection;

		// Token: 0x040006B8 RID: 1720
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.LevelInfo> _levels;

		// Token: 0x040006B9 RID: 1721
		private global::Infragistics.Windows.DataPresenter.IExportOptions _exportOptions;

		// Token: 0x040006BA RID: 1722
		private global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.LevelInfo _currentLevel;

		// Token: 0x040006BB RID: 1723
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.LevelInfo> _availableLevels;

		// Token: 0x040006BC RID: 1724
		private global::Infragistics.Windows.DataPresenter.ExportProcessResult? _previousResult;

		// Token: 0x040006BD RID: 1725
		private global::Infragistics.Windows.DataPresenter.GridUtilities.TreeViewFilterManager _treeViewFilterManager;

		// Token: 0x02000112 RID: 274
		private enum CurrentState
		{
			// Token: 0x040006BF RID: 1727
			InitializeLevel,
			// Token: 0x040006C0 RID: 1728
			EnumeratingRecords,
			// Token: 0x040006C1 RID: 1729
			InitializingRecordParams,
			// Token: 0x040006C2 RID: 1730
			ProcessingRecordBefore,
			// Token: 0x040006C3 RID: 1731
			ProcessingRecordAfter,
			// Token: 0x040006C4 RID: 1732
			ProcessingTreeFilter
		}

		// Token: 0x02000113 RID: 275
		private class LevelInfo
		{
			// Token: 0x060010D4 RID: 4308 RVA: 0x0004B536 File Offset: 0x00049736
			internal LevelInfo(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection sourceRecords, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
			{
				this.Initialize(sourceRecords, recordManager);
			}

			// Token: 0x060010D5 RID: 4309 RVA: 0x0004B548 File Offset: 0x00049748
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

			// Token: 0x060010D6 RID: 4310 RVA: 0x0004B59C File Offset: 0x0004979C
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

			// Token: 0x040006C5 RID: 1733
			internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection SourceRecordCollection;

			// Token: 0x040006C6 RID: 1734
			internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManager;

			// Token: 0x040006C7 RID: 1735
			internal global::Infragistics.Windows.DataPresenter.ExportRecordEnumeratorBase.CurrentState State;

			// Token: 0x040006C8 RID: 1736
			internal global::Infragistics.Windows.DataPresenter.Record Record;

			// Token: 0x040006C9 RID: 1737
			internal bool ProcessRecordAfterChildren;

			// Token: 0x040006CA RID: 1738
			internal global::Infragistics.Windows.DataPresenter.ProcessRecordParams RecordParams;

			// Token: 0x040006CB RID: 1739
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _recordList;

			// Token: 0x040006CC RID: 1740
			private int _recordListCount;

			// Token: 0x040006CD RID: 1741
			private int _recordIndex;
		}
	}
}
