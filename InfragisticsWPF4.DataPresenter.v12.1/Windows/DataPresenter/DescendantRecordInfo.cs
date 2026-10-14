using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000088 RID: 136
	internal class DescendantRecordInfo
	{
		// Token: 0x06000670 RID: 1648 RVA: 0x0001979C File Offset: 0x0001799C
		internal DescendantRecordInfo(global::Infragistics.Windows.DataPresenter.DataRecord[] recordsToTrack)
		{
			this._expandableFields = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>>();
			this._records = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>(recordsToTrack);
			this._ancestorToDescendants = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>>();
			foreach (global::Infragistics.Windows.DataPresenter.DataRecord key in recordsToTrack)
			{
				this._ancestorToDescendants[key] = global::Infragistics.Windows.DataPresenter.DescendantRecordInfo.ListPlaceholder;
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x000197F6 File Offset: 0x000179F6
		internal bool AddRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this.AddRecord(record, null);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00019800 File Offset: 0x00017A00
		private bool AddRecord(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Record child)
		{
			if (record == null)
			{
				return false;
			}
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> list;
			if (!this._ancestorToDescendants.TryGetValue(record, out list))
			{
				global::Infragistics.Windows.DataPresenter.Record record2 = (record is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord) ? record.ParentRecord : record.RecordManager.ParentRecord;
				if (this.AddRecord(record2, record))
				{
					list = global::Infragistics.Windows.DataPresenter.DescendantRecordInfo.ListPlaceholder;
				}
				this._ancestorToDescendants.Add(record, list);
			}
			if (list != null && child != null)
			{
				if (list == global::Infragistics.Windows.DataPresenter.DescendantRecordInfo.ListPlaceholder)
				{
					list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>(3);
					this._ancestorToDescendants[record] = list;
				}
				list.Add(child);
			}
			return null != list;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0001988C File Offset: 0x00017A8C
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> GetChildren(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> result;
			this._ancestorToDescendants.TryGetValue(record, out result);
			return result;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000198AC File Offset: 0x00017AAC
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> GetExpandableFields(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> expandableFieldsImpl;
			if (!this._expandableFields.TryGetValue(fl, out expandableFieldsImpl))
			{
				expandableFieldsImpl = global::Infragistics.Windows.DataPresenter.DescendantRecordInfo.GetExpandableFieldsImpl(fl);
				this._expandableFields[fl] = expandableFieldsImpl;
			}
			return expandableFieldsImpl;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000198E0 File Offset: 0x00017AE0
		private static global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> GetExpandableFieldsImpl(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			foreach (global::Infragistics.Windows.DataPresenter.Field field in fl.Fields)
			{
				if (field.IsExpandableResolved)
				{
					list.Add(field);
				}
			}
			return list;
		}

		// Token: 0x040001F1 RID: 497
		private static readonly global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> ListPlaceholder = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.Record>(new global::Infragistics.Windows.DataPresenter.Record[0]);

		// Token: 0x040001F2 RID: 498
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>> _ancestorToDescendants;

		// Token: 0x040001F3 RID: 499
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> _records;

		// Token: 0x040001F4 RID: 500
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>> _expandableFields;
	}
}
