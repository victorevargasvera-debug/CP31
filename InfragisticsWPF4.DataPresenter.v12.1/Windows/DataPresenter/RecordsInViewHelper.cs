using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000039 RID: 57
	internal class RecordsInViewHelper
	{
		// Token: 0x06000242 RID: 578 RVA: 0x00009323 File Offset: 0x00007523
		internal RecordsInViewHelper(global::Infragistics.Windows.DataPresenter.DataPresenterBase control)
		{
			this._control = control;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00009332 File Offset: 0x00007532
		internal global::Infragistics.Windows.DataPresenter.Record[] GetRecords()
		{
			if (this._recordsInView == null)
			{
				this.CacheRecordsInView();
			}
			return this._recordsInView;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00009348 File Offset: 0x00007548
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

		// Token: 0x06000245 RID: 581 RVA: 0x000093B8 File Offset: 0x000075B8
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

		// Token: 0x06000246 RID: 582 RVA: 0x000093FF File Offset: 0x000075FF
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> GetRecordPresentersInView()
		{
			if (this._recordPresentersInView == null)
			{
				this._recordPresentersInView = this._control.GetRecordPresentersInView(true, true);
			}
			return this._recordPresentersInView;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00009424 File Offset: 0x00007624
		private bool ShouldProcessRecordManager(global::Infragistics.Windows.DataPresenter.RecordManager rm, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.FieldInfo> fieldInfos)
		{
			bool result = false;
			if (this._visibleCells == null)
			{
				this._visibleCells = global::Infragistics.Windows.DataPresenter.VisibleDataBlock.Create(this.GetRecordPresentersInView());
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
								result = true;
								break;
							}
						}
						break;
					}
				}
				i++;
			}
			return result;
		}

		// Token: 0x0400007E RID: 126
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _control;

		// Token: 0x0400007F RID: 127
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> _recordPresentersInView;

		// Token: 0x04000080 RID: 128
		private global::Infragistics.Windows.DataPresenter.Record[] _recordsInView;

		// Token: 0x04000081 RID: 129
		private global::Infragistics.Windows.DataPresenter.RecordManager _lastRecordManager;

		// Token: 0x04000082 RID: 130
		private bool _lastShouldProcessResult;

		// Token: 0x04000083 RID: 131
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordManager, bool> _inViewRecordManagerTable;

		// Token: 0x04000084 RID: 132
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> _visibleCells;
	}
}
