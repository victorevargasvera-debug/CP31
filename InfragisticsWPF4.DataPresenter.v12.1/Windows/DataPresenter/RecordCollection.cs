using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000310 RID: 784
	public class RecordCollection : global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002557 RID: 9559 RVA: 0x000A1318 File Offset: 0x0009F518
		internal RecordCollection(global::Infragistics.Windows.DataPresenter.GroupByRecord owner, global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager, global::Infragistics.Windows.DataPresenter.FieldLayout fieldlayout) : base(owner, parentRecordManager, fieldlayout, false)
		{
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x000A1324 File Offset: 0x0009F524
		internal override global::Infragistics.Windows.DataPresenter.RecordType RecordsType
		{
			get
			{
				global::Infragistics.Collections.SparseArray sparseArray = base.SparseArray;
				if (sparseArray.Count > 0)
				{
					global::Infragistics.Windows.DataPresenter.Record record = sparseArray[0] as global::Infragistics.Windows.DataPresenter.Record;
					if (record != null)
					{
						return record.RecordType;
					}
				}
				return global::Infragistics.Windows.DataPresenter.RecordType.DataRecord;
			}
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x000A1359 File Offset: 0x0009F559
		protected override void SortGroupByRecords(global::System.Collections.IComparer comparer, bool reverse)
		{
			base.SparseArray.Sort(comparer);
			if (reverse)
			{
				base.SparseArray.Reverse();
			}
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x000A1378 File Offset: 0x0009F578
		public void Sort()
		{
			if (base.SparseArray.Count < 2)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = base.ParentRecordManager;
			base.SparseArray.Sort(new global::Infragistics.Windows.DataPresenter.RecordManager.RecordsSortComparer(parentRecordManager == null || !parentRecordManager.IsSorted));
			this.OnPropertyChanged("Item[]");
			this.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset, null, -1);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x000A13CE File Offset: 0x0009F5CE
		public new int IndexOf(global::Infragistics.Windows.DataPresenter.Record item)
		{
			return base.SparseArray.IndexOf(item);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000A13DC File Offset: 0x0009F5DC
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.Insert(int index, global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x000A13ED File Offset: 0x0009F5ED
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000AF3 RID: 2803
		public new global::Infragistics.Windows.DataPresenter.Record this[int index]
		{
			get
			{
				return base.SparseArray.GetItem(index, true);
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
			}
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x000A141E File Offset: 0x0009F61E
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Add(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x000A142F File Offset: 0x0009F62F
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x000A1440 File Offset: 0x0009F640
		public new bool Contains(global::Infragistics.Windows.DataPresenter.Record item)
		{
			return base.SparseArray.Contains(item);
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x000A144E File Offset: 0x0009F64E
		public new void CopyTo(global::Infragistics.Windows.DataPresenter.Record[] array, int arrayIndex)
		{
			base.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x000A1458 File Offset: 0x0009F658
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x000A145B File Offset: 0x0009F65B
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Remove(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x000A146C File Offset: 0x0009F66C
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumerator(base.SparseArray);
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x000A1479 File Offset: 0x0009F679
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return base.SparseArray.GetEnumerator(base.SparseArray);
		}
	}
}
