using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000075 RID: 117
	internal class RecordExpansionAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x060005DD RID: 1501 RVA: 0x00017460 File Offset: 0x00015660
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

		// Token: 0x060005DE RID: 1502 RVA: 0x000174EC File Offset: 0x000156EC
		protected internal override void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
			for (int i = 0; i < this._records.Length; i++)
			{
				descendantInfo.AddRecord(this._records[i]);
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0001751C File Offset: 0x0001571C
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

		// Token: 0x060005E0 RID: 1504 RVA: 0x0001756C File Offset: 0x0001576C
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

		// Token: 0x060005E1 RID: 1505 RVA: 0x000175C4 File Offset: 0x000157C4
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

		// Token: 0x060005E2 RID: 1506 RVA: 0x00017653 File Offset: 0x00015853
		internal void FixGroupByRecords(global::Infragistics.Windows.Helpers.HashSet fixedRecords)
		{
			this.VerifyGroupByRecords(fixedRecords);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0001765C File Offset: 0x0001585C
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

		// Token: 0x040001C0 RID: 448
		private global::Infragistics.Windows.DataPresenter.Record[] _records;

		// Token: 0x040001C1 RID: 449
		private object[] _dataItems;

		// Token: 0x040001C2 RID: 450
		private bool _isExpanded;

		// Token: 0x02000076 RID: 118
		private class GroupByContext
		{
			// Token: 0x060005E4 RID: 1508 RVA: 0x000176B5 File Offset: 0x000158B5
			private GroupByContext()
			{
			}

			// Token: 0x060005E5 RID: 1509 RVA: 0x000176C0 File Offset: 0x000158C0
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

			// Token: 0x060005E6 RID: 1510 RVA: 0x0001773C File Offset: 0x0001593C
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

			// Token: 0x060005E7 RID: 1511 RVA: 0x000177F4 File Offset: 0x000159F4
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

			// Token: 0x060005E8 RID: 1512 RVA: 0x0001786C File Offset: 0x00015A6C
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

			// Token: 0x040001C3 RID: 451
			private global::Infragistics.Windows.DataPresenter.RecordManager _rm;

			// Token: 0x040001C4 RID: 452
			private object[] _values;

			// Token: 0x040001C5 RID: 453
			private global::Infragistics.Windows.DataPresenter.Field[] _fields;
		}
	}
}
