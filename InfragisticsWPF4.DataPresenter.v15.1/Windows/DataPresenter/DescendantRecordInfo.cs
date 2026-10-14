using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200008D RID: 141
	internal class DescendantRecordInfo
	{
		// Token: 0x060006EE RID: 1774 RVA: 0x0001BE08 File Offset: 0x0001A008
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

		// Token: 0x060006EF RID: 1775 RVA: 0x0001BE62 File Offset: 0x0001A062
		internal bool AddRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this.AddRecord(record, null);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001BE6C File Offset: 0x0001A06C
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

		// Token: 0x060006F1 RID: 1777 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> GetChildren(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> result;
			this._ancestorToDescendants.TryGetValue(record, out result);
			return result;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0001BF18 File Offset: 0x0001A118
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

		// Token: 0x060006F3 RID: 1779 RVA: 0x0001BF4C File Offset: 0x0001A14C
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

		// Token: 0x0400022F RID: 559
		private static readonly global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> ListPlaceholder = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.Record>(new global::Infragistics.Windows.DataPresenter.Record[0]);

		// Token: 0x04000230 RID: 560
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>> _ancestorToDescendants;

		// Token: 0x04000231 RID: 561
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> _records;

		// Token: 0x04000232 RID: 562
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>> _expandableFields;
	}
}
