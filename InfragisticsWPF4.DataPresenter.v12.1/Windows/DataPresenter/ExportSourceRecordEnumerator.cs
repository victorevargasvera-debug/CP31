using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000F9 RID: 249
	internal class ExportSourceRecordEnumerator
	{
		// Token: 0x06000D62 RID: 3426 RVA: 0x0003A93F File Offset: 0x00038B3F
		internal ExportSourceRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			this._levels = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator.Level>();
			this.StartLevel(recordManager);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0003A95C File Offset: 0x00038B5C
		internal bool MoveNext()
		{
			while (this._levels.Count > 0)
			{
				if (this._currentLevel.CurrentRecord == null)
				{
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord> unsorted = this._currentLevel.RecordManager.Unsorted;
					if (this._currentLevel.Index < unsorted.Count)
					{
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = unsorted[this._currentLevel.Index];
						if (dataRecord.FieldLayout.Fields.NotCollapsedExpandableFieldsCount > 0)
						{
							this._currentLevel.CurrentRecord = dataRecord;
						}
						this._currentLevel.Index++;
						return true;
					}
					this.EndCurrentLevel();
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection childRecords = this._currentLevel.CurrentRecord.ChildRecords;
					int i = this._currentLevel.CurrentRecordChildIndex;
					int count = childRecords.Count;
					while (i < count)
					{
						global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = childRecords[i];
						global::Infragistics.Windows.DataPresenter.RecordManager childRecordManager = expandableFieldRecord.ChildRecordManager;
						if (childRecordManager != null)
						{
							this._currentLevel.CurrentRecordChildIndex = i + 1;
							this.StartLevel(childRecordManager);
							return true;
						}
						i++;
					}
					this._currentLevel.CurrentRecord = null;
				}
			}
			return false;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0003AA6C File Offset: 0x00038C6C
		internal global::Infragistics.Windows.DataPresenter.ExportProcessResult Process(global::System.TimeSpan duration)
		{
			int num = (int)global::System.Math.Round(duration.TotalMilliseconds, global::System.MidpointRounding.AwayFromZero);
			int tickCount = global::System.Environment.TickCount;
			int num2 = 0;
			while (this.MoveNext())
			{
				num2++;
				if (num2 % 100 == 0 && global::System.Environment.TickCount - tickCount > num)
				{
					return global::Infragistics.Windows.DataPresenter.ExportProcessResult.Timeout;
				}
			}
			return global::Infragistics.Windows.DataPresenter.ExportProcessResult.Completed;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0003AAB1 File Offset: 0x00038CB1
		private void EndCurrentLevel()
		{
			this._levels.Pop();
			this._currentLevel = ((this._levels.Count > 0) ? this._levels.Peek() : null);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0003AAE4 File Offset: 0x00038CE4
		private void StartLevel(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator.Level level = new global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator.Level();
			level.RecordManager = rm;
			this._levels.Push(level);
			this._currentLevel = level;
			if (rm.IsResetPending)
			{
				rm.OnSourceCollectionReset();
			}
		}

		// Token: 0x04000534 RID: 1332
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator.Level> _levels;

		// Token: 0x04000535 RID: 1333
		private global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator.Level _currentLevel;

		// Token: 0x020000FA RID: 250
		private class Level
		{
			// Token: 0x04000536 RID: 1334
			internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManager;

			// Token: 0x04000537 RID: 1335
			internal int Index;

			// Token: 0x04000538 RID: 1336
			internal global::Infragistics.Windows.DataPresenter.DataRecord CurrentRecord;

			// Token: 0x04000539 RID: 1337
			internal int CurrentRecordChildIndex;
		}
	}
}
