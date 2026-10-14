using System;
using System.Collections.Generic;
using System.Text;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000069 RID: 105
	internal class DeleteRecordsAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x0600059D RID: 1437 RVA: 0x0001546C File Offset: 0x0001366C
		internal DeleteRecordsAction(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> records, bool displayPromptMessage) : base(dp)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(records, "records");
			this._dataItemToIndexMap = new global::System.Collections.Generic.Dictionary<object, int>();
			this._indexToDataItemMap = new global::System.Collections.Generic.Dictionary<int, object>();
			for (int i = 0; i < records.Count; i++)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = records[i] as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null)
				{
					object dataItem = dataRecord.DataItem;
					if (dataItem != null)
					{
						this._dataItemToIndexMap[dataItem] = i;
						this._indexToDataItemMap[i] = dataItem;
					}
				}
			}
			this._records = records;
			this._displayPrompt = displayPromptMessage;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000154F4 File Offset: 0x000136F4
		protected internal override void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
			foreach (global::Infragistics.Windows.DataPresenter.Record record in this._records)
			{
				descendantInfo.AddRecord(record);
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00015544 File Offset: 0x00013744
		protected internal override bool CanPerform(object context)
		{
			for (int i = 0; i < this._records.Count; i++)
			{
				if (this.CanDelete(i))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00015574 File Offset: 0x00013774
		protected internal override void OnRecordsUndeleted(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataTimeToRecords)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<object, int> keyValuePair in this._dataItemToIndexMap)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
				if (oldDataTimeToRecords.TryGetValue(keyValuePair.Key, out dataRecord))
				{
					this._records[keyValuePair.Value] = dataRecord;
					this._indexToDataItemMap[keyValuePair.Value] = dataRecord.DataItem;
				}
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000155FC File Offset: 0x000137FC
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			int num = 0;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			int i = 0;
			int count = this._records.Count;
			while (i < count)
			{
				if (this.CanDelete(i))
				{
					global::Infragistics.Windows.DataPresenter.DataRecord item = this._records[i] as global::Infragistics.Windows.DataPresenter.DataRecord;
					list.Add(item);
				}
				i++;
			}
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, object> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, object>();
			foreach (global::Infragistics.Windows.DataPresenter.Record record in list)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)record;
				dictionary[dataRecord] = dataRecord.DataItem;
			}
			global::Infragistics.Windows.DataPresenter.UndeleteRecordsAction undeleteRecordsAction;
			bool flag = dataPresenter.DeleteRecords(list, this._displayPrompt, true, out undeleteRecordsAction, out num);
			if (!flag || num == 0)
			{
				return null;
			}
			return undeleteRecordsAction ?? global::Infragistics.Windows.DataPresenter.CompletedAction.Instance;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x000156D8 File Offset: 0x000138D8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine("DeleteRecords:");
			foreach (global::Infragistics.Windows.DataPresenter.Record record in this._records)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)record;
				stringBuilder.AppendLine("\t" + dataRecord.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00015754 File Offset: 0x00013954
		private bool CanDelete(int index)
		{
			if (index < 0 || index >= this._records.Count)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._records[index] as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord == null || global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsDeleted(dataRecord))
			{
				return false;
			}
			if (dataRecord.IsAddRecordTemplate)
			{
				return false;
			}
			object dataItem = dataRecord.DataItem;
			if (dataItem == null)
			{
				return false;
			}
			object item = this._indexToDataItemMap[index];
			return global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsSameDataItem(dataItem, item);
		}

		// Token: 0x0400019E RID: 414
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> _records;

		// Token: 0x0400019F RID: 415
		private bool _displayPrompt;

		// Token: 0x040001A0 RID: 416
		private global::System.Collections.Generic.Dictionary<object, int> _dataItemToIndexMap;

		// Token: 0x040001A1 RID: 417
		private global::System.Collections.Generic.Dictionary<int, object> _indexToDataItemMap;
	}
}
