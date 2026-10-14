using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000351 RID: 849
	public class RecordCollection : global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002908 RID: 10504 RVA: 0x000B50ED File Offset: 0x000B32ED
		internal RecordCollection(global::Infragistics.Windows.DataPresenter.GroupByRecord owner, global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager, global::Infragistics.Windows.DataPresenter.FieldLayout fieldlayout) : base(owner, parentRecordManager, fieldlayout, false)
		{
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x000B50FC File Offset: 0x000B32FC
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

		// Token: 0x0600290A RID: 10506 RVA: 0x000B5131 File Offset: 0x000B3331
		protected override void SortGroupByRecords(global::System.Collections.IComparer comparer, bool reverse)
		{
			base.SparseArray.Sort(comparer);
			if (reverse)
			{
				base.SparseArray.Reverse();
			}
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x000B5150 File Offset: 0x000B3350
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

		// Token: 0x0600290C RID: 10508 RVA: 0x000B51A6 File Offset: 0x000B33A6
		public new int IndexOf(global::Infragistics.Windows.DataPresenter.Record item)
		{
			return base.SparseArray.IndexOf(item);
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x000B51B4 File Offset: 0x000B33B4
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.Insert(int index, global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000B51C5 File Offset: 0x000B33C5
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000C24 RID: 3108
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

		// Token: 0x06002911 RID: 10513 RVA: 0x000B51F6 File Offset: 0x000B33F6
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Add(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000B5207 File Offset: 0x000B3407
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000B5218 File Offset: 0x000B3418
		public new bool Contains(global::Infragistics.Windows.DataPresenter.Record item)
		{
			return base.SparseArray.Contains(item);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000B5226 File Offset: 0x000B3426
		public new void CopyTo(global::Infragistics.Windows.DataPresenter.Record[] array, int arrayIndex)
		{
			base.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x000B5230 File Offset: 0x000B3430
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000B5233 File Offset: 0x000B3433
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Remove(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000B5244 File Offset: 0x000B3444
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumerator(base.SparseArray);
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000B5251 File Offset: 0x000B3451
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return base.SparseArray.GetEnumerator(base.SparseArray);
		}
	}
}
