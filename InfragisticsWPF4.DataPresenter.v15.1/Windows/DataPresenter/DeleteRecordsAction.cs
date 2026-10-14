using System;
using System.Collections.Generic;
using System.Text;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200006E RID: 110
	internal class DeleteRecordsAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x06000618 RID: 1560 RVA: 0x0001781C File Offset: 0x00015A1C
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

		// Token: 0x06000619 RID: 1561 RVA: 0x000178A4 File Offset: 0x00015AA4
		protected internal override void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
			foreach (global::Infragistics.Windows.DataPresenter.Record record in this._records)
			{
				descendantInfo.AddRecord(record);
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000178F4 File Offset: 0x00015AF4
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

		// Token: 0x0600061B RID: 1563 RVA: 0x00017924 File Offset: 0x00015B24
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

		// Token: 0x0600061C RID: 1564 RVA: 0x000179AC File Offset: 0x00015BAC
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

		// Token: 0x0600061D RID: 1565 RVA: 0x00017A88 File Offset: 0x00015C88
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

		// Token: 0x0600061E RID: 1566 RVA: 0x00017B04 File Offset: 0x00015D04
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
			return global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsSameDataItem(dataItem, item, base.DataPresenter.DataItemEqualityComparerResolved);
		}

		// Token: 0x040001D6 RID: 470
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> _records;

		// Token: 0x040001D7 RID: 471
		private bool _displayPrompt;

		// Token: 0x040001D8 RID: 472
		private global::System.Collections.Generic.Dictionary<object, int> _dataItemToIndexMap;

		// Token: 0x040001D9 RID: 473
		private global::System.Collections.Generic.Dictionary<int, object> _indexToDataItemMap;
	}
}
