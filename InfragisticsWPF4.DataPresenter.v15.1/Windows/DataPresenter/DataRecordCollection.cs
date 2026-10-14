using System;
using System.Collections;
using System.Collections.Generic;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000352 RID: 850
	public class DataRecordCollection : global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataRecord>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002919 RID: 10521 RVA: 0x000B5264 File Offset: 0x000B3464
		internal DataRecordCollection(global::Infragistics.Windows.DataPresenter.Record owner, global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool unsortedCache) : base(owner, parentRecordManager, fieldLayout, unsortedCache)
		{
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x000B5274 File Offset: 0x000B3474
		internal override global::Infragistics.Windows.DataPresenter.Record AllocateNewRecord(int index)
		{
			global::System.Collections.IList list = base.ParentRecordManager.List;
			if (list != null)
			{
				object listObject = (index >= 0 && index < list.Count) ? list[index] : null;
				return global::Infragistics.Windows.DataPresenter.DataRecord.Create(this, listObject, false, index);
			}
			return null;
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x000B52B3 File Offset: 0x000B34B3
		internal override global::Infragistics.Windows.DataPresenter.RecordType RecordsType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.DataRecord;
			}
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x000B52B8 File Offset: 0x000B34B8
		public global::Infragistics.Windows.DataPresenter.DataRecord GetDataRecordFromDataItem(object dataItem, bool recursive)
		{
			if (dataItem == null)
			{
				throw new global::System.ArgumentNullException("dataItem");
			}
			dataItem = global::Infragistics.Windows.DataPresenter.DataRecord.GetObjectForRecordComparision(dataItem);
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = base.ParentRecordManager;
			global::System.Collections.IList list = (parentRecordManager != null) ? parentRecordManager.List : null;
			global::System.Collections.Generic.IEqualityComparer<object> equalityComparer = (parentRecordManager != null) ? parentRecordManager.DataItemComparer : global::Infragistics.Windows.DataPresenter.ReferenceEqualityComparer.Instance;
			if (dataPresenter != null && list != null && !parentRecordManager.IsSorted && dataPresenter.RecordLoadMode != global::Infragistics.Windows.DataPresenter.RecordLoadMode.PreloadRecords)
			{
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					object objectForComparison = global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(list[i]);
					if (equalityComparer.Equals(dataItem, objectForComparison))
					{
						return parentRecordManager.Unsorted[i];
					}
				}
			}
			else
			{
				foreach (global::Infragistics.Windows.DataPresenter.DataRecord dataRecord in this)
				{
					if (equalityComparer.Equals(dataRecord.DataItemForComparison, dataItem))
					{
						return dataRecord;
					}
				}
			}
			if (!recursive)
			{
				return null;
			}
			foreach (global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 in this)
			{
				if (dataRecord2.HasChildren)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecordFromDataItem = dataRecord2.ChildRecords.GetDataRecordFromDataItem(dataItem, recursive);
					if (dataRecordFromDataItem != null)
					{
						return dataRecordFromDataItem;
					}
				}
			}
			return null;
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000B5454 File Offset: 0x000B3654
		internal void LoadDataItemRecordMap(global::Infragistics.Windows.DataPresenter.DataItemRecordMap dataItemRecordMap, bool recursive)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			global::Infragistics.Windows.DataPresenter.RecordManager rm = base.ParentRecordManager;
			global::System.Collections.IList list = (rm != null) ? rm.List : null;
			if (dataPresenter != null && list != null && !rm.IsSorted && dataPresenter.RecordLoadMode != global::Infragistics.Windows.DataPresenter.RecordLoadMode.PreloadRecords)
			{
				int count = list.Count;
				int i;
				for (i = 0; i < count; i++)
				{
					dataItemRecordMap.CheckMap(global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(list[i]), () => rm.Unsorted[i]);
					if (dataItemRecordMap._itemsRemainingToBeMapped < 1)
					{
						return;
					}
				}
			}
			else
			{
				using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord> enumerator = this.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Infragistics.Windows.DataPresenter.DataRecord rcd = enumerator.Current;
						dataItemRecordMap.CheckMap(rcd.DataItemForComparison, () => rcd);
						if (dataItemRecordMap._itemsRemainingToBeMapped < 1)
						{
							return;
						}
					}
				}
			}
			if (recursive)
			{
				foreach (global::Infragistics.Windows.DataPresenter.DataRecord dataRecord in this)
				{
					if (dataRecord.HasChildren)
					{
						dataRecord.ChildRecords.LoadDataItemRecordMap(dataItemRecordMap, recursive);
						if (dataItemRecordMap._itemsRemainingToBeMapped < 1)
						{
							return;
						}
					}
				}
				return;
			}
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x000B560C File Offset: 0x000B380C
		public int IndexOf(global::Infragistics.Windows.DataPresenter.DataRecord item)
		{
			return base.SparseArray.IndexOf(item);
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000B561A File Offset: 0x000B381A
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord>.Insert(int index, global::Infragistics.Windows.DataPresenter.DataRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x000B562B File Offset: 0x000B382B
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000C27 RID: 3111
		public global::Infragistics.Windows.DataPresenter.DataRecord this[int index]
		{
			get
			{
				return base.SparseArray.GetItem(index, true) as global::Infragistics.Windows.DataPresenter.DataRecord;
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
			}
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x000B5661 File Offset: 0x000B3861
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataRecord>.Add(global::Infragistics.Windows.DataPresenter.DataRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x000B5672 File Offset: 0x000B3872
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataRecord>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000B5683 File Offset: 0x000B3883
		public bool Contains(global::Infragistics.Windows.DataPresenter.DataRecord item)
		{
			return base.SparseArray.Contains(item);
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x000B5691 File Offset: 0x000B3891
		public void CopyTo(global::Infragistics.Windows.DataPresenter.DataRecord[] array, int arrayIndex)
		{
			base.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x000B569B File Offset: 0x000B389B
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000B569E File Offset: 0x000B389E
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataRecord>.Remove(global::Infragistics.Windows.DataPresenter.DataRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x000B56AF File Offset: 0x000B38AF
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordCollectionBase.DataRecordEnumerator(base.SparseArray);
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000B56BC File Offset: 0x000B38BC
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return base.SparseArray.GetEnumerator(base.SparseArray);
		}
	}
}
