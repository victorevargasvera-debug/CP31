using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000312 RID: 786
	public class GroupByRecordCollection : global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.GroupByRecord>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.GroupByRecord>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.GroupByRecord>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002579 RID: 9593 RVA: 0x000A16DF File Offset: 0x0009F8DF
		internal GroupByRecordCollection(global::Infragistics.Windows.DataPresenter.Record owner, global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout) : base(owner, parentRecordManager, fieldLayout, false)
		{
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x000A16EB File Offset: 0x0009F8EB
		internal override global::Infragistics.Windows.DataPresenter.RecordType RecordsType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.GroupByField;
			}
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000A16EE File Offset: 0x0009F8EE
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

		// Token: 0x0600257C RID: 9596 RVA: 0x000A171A File Offset: 0x0009F91A
		public int IndexOf(global::Infragistics.Windows.DataPresenter.GroupByRecord item)
		{
			return base.IndexOf(item);
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000A1723 File Offset: 0x0009F923
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.GroupByRecord>.Insert(int index, global::Infragistics.Windows.DataPresenter.GroupByRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000A1734 File Offset: 0x0009F934
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.GroupByRecord>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000AF9 RID: 2809
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

		// Token: 0x06002581 RID: 9601 RVA: 0x000A1764 File Offset: 0x0009F964
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.GroupByRecord>.Add(global::Infragistics.Windows.DataPresenter.GroupByRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x000A1775 File Offset: 0x0009F975
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.GroupByRecord>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x000A1786 File Offset: 0x0009F986
		public bool Contains(global::Infragistics.Windows.DataPresenter.GroupByRecord item)
		{
			return base.Contains(item);
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x000A178F File Offset: 0x0009F98F
		public void CopyTo(global::Infragistics.Windows.DataPresenter.GroupByRecord[] array, int arrayIndex)
		{
			base.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x000A1799 File Offset: 0x0009F999
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x000A179C File Offset: 0x0009F99C
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.GroupByRecord>.Remove(global::Infragistics.Windows.DataPresenter.GroupByRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x000A17AD File Offset: 0x0009F9AD
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.GroupByRecord> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordCollectionBase.GroupByRecordEnumerator(base.SparseArray);
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x000A17BA File Offset: 0x0009F9BA
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return base.SparseArray.GetEnumerator(base.SparseArray);
		}
	}
}
