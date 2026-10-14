using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000353 RID: 851
	public class GroupByRecordCollection : global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.GroupByRecord>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.GroupByRecord>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.GroupByRecord>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600292B RID: 10539 RVA: 0x000B56CF File Offset: 0x000B38CF
		internal GroupByRecordCollection(global::Infragistics.Windows.DataPresenter.Record owner, global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout) : base(owner, parentRecordManager, fieldLayout, false)
		{
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x000B56DB File Offset: 0x000B38DB
		internal override global::Infragistics.Windows.DataPresenter.RecordType RecordsType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.GroupByField;
			}
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000B56DE File Offset: 0x000B38DE
		protected override void SortGroupByRecords(global::System.Collections.IComparer comparer, bool reverse)
		{
			base.InitializeSortVersion();
			if (base.Count < 2)
			{
				return;
			}
			base.SparseArray.Sort(comparer);
			if (reverse)
			{
				base.SparseArray.Reverse();
			}
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x000B570A File Offset: 0x000B390A
		public int IndexOf(global::Infragistics.Windows.DataPresenter.GroupByRecord item)
		{
			return base.IndexOf(item);
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x000B5713 File Offset: 0x000B3913
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.GroupByRecord>.Insert(int index, global::Infragistics.Windows.DataPresenter.GroupByRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000B5724 File Offset: 0x000B3924
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.GroupByRecord>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000C2A RID: 3114
		public global::Infragistics.Windows.DataPresenter.GroupByRecord this[int index]
		{
			get
			{
				return base[index] as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
			}
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x000B5754 File Offset: 0x000B3954
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.GroupByRecord>.Add(global::Infragistics.Windows.DataPresenter.GroupByRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x000B5765 File Offset: 0x000B3965
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.GroupByRecord>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000B5776 File Offset: 0x000B3976
		public bool Contains(global::Infragistics.Windows.DataPresenter.GroupByRecord item)
		{
			return base.Contains(item);
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x000B577F File Offset: 0x000B397F
		public void CopyTo(global::Infragistics.Windows.DataPresenter.GroupByRecord[] array, int arrayIndex)
		{
			base.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x000B5789 File Offset: 0x000B3989
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000B578C File Offset: 0x000B398C
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.GroupByRecord>.Remove(global::Infragistics.Windows.DataPresenter.GroupByRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x000B579D File Offset: 0x000B399D
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.GroupByRecord> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordCollectionBase.GroupByRecordEnumerator(base.SparseArray);
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x000B57AA File Offset: 0x000B39AA
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return base.SparseArray.GetEnumerator(base.SparseArray);
		}
	}
}
