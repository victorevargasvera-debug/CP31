using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200007A RID: 122
	internal class RecordExpansionAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x06000658 RID: 1624 RVA: 0x000199B0 File Offset: 0x00017BB0
		internal RecordExpansionAction(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> records, bool isExpanded) : base(records[0].DataPresenter)
		{
			this._records = global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.Record>(records);
			this._isExpanded = isExpanded;
			this._dataItems = new object[this._records.Length];
			for (int i = 0; i < this._records.Length; i++)
			{
				global::Infragistics.Windows.DataPresenter.Record record = this._records[i];
				this._dataItems[i] = global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(record);
				if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord)
				{
					this._dataItems[i] = global::Infragistics.Windows.DataPresenter.RecordExpansionAction.GroupByContext.Create((global::Infragistics.Windows.DataPresenter.GroupByRecord)record);
				}
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00019A3C File Offset: 0x00017C3C
		protected internal override void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
			for (int i = 0; i < this._records.Length; i++)
			{
				descendantInfo.AddRecord(this._records[i]);
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00019A6C File Offset: 0x00017C6C
		protected internal override bool CanPerform(object context)
		{
			this.VerifyGroupByRecords(null);
			if (!this._records[0].IsStillValid)
			{
				return false;
			}
			for (int i = 0; i < this._records.Length; i++)
			{
				if (this._records[i].IsExpanded != this._isExpanded)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00019ABC File Offset: 0x00017CBC
		protected internal override void OnRecordsUndeleted(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataTimeToRecords)
		{
			for (int i = 0; i < this._records.Length; i++)
			{
				global::Infragistics.Windows.DataPresenter.Record record = this._records[i];
				object obj = this._dataItems[i];
				if (!(obj is global::Infragistics.Windows.DataPresenter.RecordExpansionAction.GroupByContext) && global::Infragistics.Windows.DataPresenter.DataPresenterAction.ProcessRecordUndeleted(oldDataTimeToRecords, ref obj, ref record))
				{
					this._dataItems[i] = obj;
					this._records[i] = record;
				}
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00019B14 File Offset: 0x00017D14
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			if (!this.CanPerform(context))
			{
				return null;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
			if (!base.DataPresenter.OnRecordExpandStateChanged(this._records[0], this._isExpanded, list))
			{
				return null;
			}
			if (list == null || list.Count == 0)
			{
				return null;
			}
			for (int i = 1; i < this._records.Length; i++)
			{
				this._records[i].SetIsExpanded(this._isExpanded, null);
			}
			this._records[0].IsActive = true;
			return new global::Infragistics.Windows.DataPresenter.RecordExpansionAction(list, !this._isExpanded);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00019BA3 File Offset: 0x00017DA3
		internal void FixGroupByRecords(global::Infragistics.Windows.Helpers.HashSet fixedRecords)
		{
			this.VerifyGroupByRecords(fixedRecords);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00019BAC File Offset: 0x00017DAC
		private void VerifyGroupByRecords(global::Infragistics.Windows.Helpers.HashSet fixedRecords)
		{
			for (int i = 0; i < this._records.Length; i++)
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this._records[i] as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				if (groupByRecord != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordExpansionAction.GroupByContext groupByContext = this._dataItems[i] as global::Infragistics.Windows.DataPresenter.RecordExpansionAction.GroupByContext;
					this._records[i] = groupByContext.Validate(groupByRecord, !this._isExpanded, fixedRecords, true);
				}
			}
		}

		// Token: 0x040001FC RID: 508
		private global::Infragistics.Windows.DataPresenter.Record[] _records;

		// Token: 0x040001FD RID: 509
		private object[] _dataItems;

		// Token: 0x040001FE RID: 510
		private bool _isExpanded;

		// Token: 0x0200007B RID: 123
		private class GroupByContext
		{
			// Token: 0x0600065F RID: 1631 RVA: 0x00019C05 File Offset: 0x00017E05
			private GroupByContext()
			{
			}

			// Token: 0x06000660 RID: 1632 RVA: 0x00019C10 File Offset: 0x00017E10
			internal static global::Infragistics.Windows.DataPresenter.RecordExpansionAction.GroupByContext Create(global::Infragistics.Windows.DataPresenter.GroupByRecord record)
			{
				global::Infragistics.Windows.DataPresenter.RecordExpansionAction.GroupByContext groupByContext = new global::Infragistics.Windows.DataPresenter.RecordExpansionAction.GroupByContext();
				groupByContext._rm = record.RecordManager;
				global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
				while (record != null)
				{
					list2.Add(record.GroupByField);
					list.Add(record.Value);
					record = (record.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord);
				}
				list.Reverse();
				list2.Reverse();
				groupByContext._values = list.ToArray();
				groupByContext._fields = list2.ToArray();
				return groupByContext;
			}

			// Token: 0x06000661 RID: 1633 RVA: 0x00019C8C File Offset: 0x00017E8C
			internal global::Infragistics.Windows.DataPresenter.Record Validate(global::Infragistics.Windows.DataPresenter.GroupByRecord gbr, bool isExpanded, global::Infragistics.Windows.Helpers.HashSet fixedRecords, bool raiseEvents)
			{
				if (!gbr.IsStillValid && this._rm.HasGroups && this.HasSameGroupByFields(gbr))
				{
					global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = null;
					global::Infragistics.Windows.DataPresenter.RecordCollectionBase records = this._rm.Groups;
					for (int i = 0; i < this._values.Length; i++)
					{
						groupByRecord = global::Infragistics.Windows.DataPresenter.RecordExpansionAction.GroupByContext.GetRecord(records, this._values[i]);
						if (groupByRecord == null)
						{
							return gbr;
						}
						records = groupByRecord.ChildRecords;
					}
					gbr = groupByRecord;
					if (fixedRecords != null && !fixedRecords.Exists(gbr))
					{
						fixedRecords.Add(gbr);
						if (gbr.IsExpanded != isExpanded)
						{
							global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = raiseEvents ? gbr.DataPresenter : null;
							if (dataPresenterBase != null)
							{
								dataPresenterBase.OnRecordExpandStateChanged(gbr, isExpanded, null);
							}
							else
							{
								gbr.SetIsExpanded(isExpanded, null);
							}
						}
					}
				}
				return gbr;
			}

			// Token: 0x06000662 RID: 1634 RVA: 0x00019D44 File Offset: 0x00017F44
			private static global::Infragistics.Windows.DataPresenter.GroupByRecord GetRecord(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records, object value)
			{
				if (records.Count == 0 || !(records[0] is global::Infragistics.Windows.DataPresenter.GroupByRecord))
				{
					return null;
				}
				foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)records))
				{
					global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = record as global::Infragistics.Windows.DataPresenter.GroupByRecord;
					if (groupByRecord != null && object.Equals(groupByRecord.Value, value))
					{
						return groupByRecord;
					}
				}
				return null;
			}

			// Token: 0x06000663 RID: 1635 RVA: 0x00019DBC File Offset: 0x00017FBC
			private bool HasSameGroupByFields(global::Infragistics.Windows.DataPresenter.GroupByRecord record)
			{
				global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = record.FieldLayout.SortedFields;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
				if (sortedFields.CountOfGroupByFields < this._fields.Length)
				{
					return false;
				}
				for (int i = 0; i < this._fields.Length; i++)
				{
					if (this._fields[i] != sortedFields[i].Field)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x040001FF RID: 511
			private global::Infragistics.Windows.DataPresenter.RecordManager _rm;

			// Token: 0x04000200 RID: 512
			private object[] _values;

			// Token: 0x04000201 RID: 513
			private global::Infragistics.Windows.DataPresenter.Field[] _fields;
		}
	}
}
