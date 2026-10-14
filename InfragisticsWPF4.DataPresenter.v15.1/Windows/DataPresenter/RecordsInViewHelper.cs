using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000039 RID: 57
	internal class RecordsInViewHelper
	{
		// Token: 0x06000259 RID: 601 RVA: 0x00009C5B File Offset: 0x00007E5B
		internal RecordsInViewHelper(global::Infragistics.Windows.DataPresenter.DataPresenterBase control)
		{
			this._control = control;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00009C6A File Offset: 0x00007E6A
		internal global::Infragistics.Windows.DataPresenter.Record[] GetRecords()
		{
			if (this._recordsInView == null)
			{
				this.CacheRecordsInView();
			}
			return this._recordsInView;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00009C80 File Offset: 0x00007E80
		internal bool ShouldProcessInViewRecord(global::Infragistics.Windows.DataPresenter.Record record, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo> fieldInfos)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = record.RecordManager;
			if (recordManager != this._lastRecordManager)
			{
				if (this._inViewRecordManagerTable == null)
				{
					this._inViewRecordManagerTable = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordManager, bool>();
				}
				if (!this._inViewRecordManagerTable.TryGetValue(recordManager, out this._lastShouldProcessResult))
				{
					bool lastShouldProcessResult = this.ShouldProcessRecordManager(recordManager, fieldInfos);
					this._inViewRecordManagerTable[recordManager] = (this._lastShouldProcessResult = lastShouldProcessResult);
				}
				this._lastRecordManager = recordManager;
			}
			return this._lastShouldProcessResult;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00009CF0 File Offset: 0x00007EF0
		private void CacheRecordsInView()
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> recordPresentersInView = this.GetRecordPresentersInView();
			global::Infragistics.Windows.DataPresenter.Record[] array = new global::Infragistics.Windows.DataPresenter.Record[recordPresentersInView.Count];
			for (int i = 0; i < recordPresentersInView.Count; i++)
			{
				array[i] = recordPresentersInView[i].Record;
			}
			this._recordsInView = array;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00009D37 File Offset: 0x00007F37
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> GetRecordPresentersInView()
		{
			if (this._recordPresentersInView == null)
			{
				this._recordPresentersInView = this._control.GetRecordPresentersInView(true, true, false, true);
			}
			return this._recordPresentersInView;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00009D5C File Offset: 0x00007F5C
		private bool ShouldProcessRecordManager(global::Infragistics.Windows.DataPresenter.RecordManager rm, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo> fieldInfos)
		{
			bool flag = false;
			if (this._visibleCells == null)
			{
				this._visibleCells = global::Infragistics.Windows.DataPresenter.VisibleDataBlock.Create(this.GetRecordPresentersInView());
			}
			if (this._visibleCells.Count == 0)
			{
				return false;
			}
			int i = 0;
			int count = this._visibleCells.Count;
			while (i < count)
			{
				if (this._visibleCells[i].RecordManager == rm)
				{
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo> enumerator = fieldInfos.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo = enumerator.Current;
							if (this._visibleCells[i].Fields.Contains(fieldInfo.Field))
							{
								flag = true;
								break;
							}
						}
						break;
					}
				}
				i++;
			}
			if (flag)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._visibleCells[0].RecordManager.DataPresenter;
			if (dataPresenter == null || !dataPresenter.IsTreeView)
			{
				return false;
			}
			int j = 0;
			int count2 = this._visibleCells.Count;
			while (j < count2)
			{
				if (this._visibleCells[j].RecordManager == rm)
				{
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo> enumerator2 = fieldInfos.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo fieldInfo2 = enumerator2.Current;
							global::Infragistics.Windows.DataPresenter.Field mappedTreeField = fieldInfo2.Field.MappedTreeField;
							if (mappedTreeField != null && this._visibleCells[j].Fields.Contains(mappedTreeField))
							{
								flag = true;
								break;
							}
						}
						break;
					}
				}
				j++;
			}
			return flag;
		}

		// Token: 0x04000090 RID: 144
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _control;

		// Token: 0x04000091 RID: 145
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> _recordPresentersInView;

		// Token: 0x04000092 RID: 146
		private global::Infragistics.Windows.DataPresenter.Record[] _recordsInView;

		// Token: 0x04000093 RID: 147
		private global::Infragistics.Windows.DataPresenter.RecordManager _lastRecordManager;

		// Token: 0x04000094 RID: 148
		private bool _lastShouldProcessResult;

		// Token: 0x04000095 RID: 149
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordManager, bool> _inViewRecordManagerTable;

		// Token: 0x04000096 RID: 150
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> _visibleCells;
	}
}
