using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000117 RID: 279
	internal class ExportSourceRecordEnumerator
	{
		// Token: 0x060010DE RID: 4318 RVA: 0x0004B6A3 File Offset: 0x000498A3
		internal ExportSourceRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			this._levels = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator.Level>();
			this.StartLevel(recordManager);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0004B6C0 File Offset: 0x000498C0
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

		// Token: 0x060010E0 RID: 4320 RVA: 0x0004B7D0 File Offset: 0x000499D0
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

		// Token: 0x060010E1 RID: 4321 RVA: 0x0004B815 File Offset: 0x00049A15
		private void EndCurrentLevel()
		{
			this._levels.Pop();
			this._currentLevel = ((this._levels.Count > 0) ? this._levels.Peek() : null);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0004B848 File Offset: 0x00049A48
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

		// Token: 0x040006D5 RID: 1749
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator.Level> _levels;

		// Token: 0x040006D6 RID: 1750
		private global::Infragistics.Windows.DataPresenter.ExportSourceRecordEnumerator.Level _currentLevel;

		// Token: 0x02000118 RID: 280
		private class Level
		{
			// Token: 0x040006D7 RID: 1751
			internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManager;

			// Token: 0x040006D8 RID: 1752
			internal int Index;

			// Token: 0x040006D9 RID: 1753
			internal global::Infragistics.Windows.DataPresenter.DataRecord CurrentRecord;

			// Token: 0x040006DA RID: 1754
			internal int CurrentRecordChildIndex;
		}
	}
}
