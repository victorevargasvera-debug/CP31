using System;
using System.Collections;
using System.Collections.Generic;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000311 RID: 785
	public class DataRecordCollection : global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataRecord>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002568 RID: 9576 RVA: 0x000A148C File Offset: 0x0009F68C
		internal DataRecordCollection(global::Infragistics.Windows.DataPresenter.Record owner, global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool unsortedCache) : base(owner, parentRecordManager, fieldLayout, unsortedCache)
		{
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x000A149C File Offset: 0x0009F69C
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

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000A14DB File Offset: 0x0009F6DB
		internal override global::Infragistics.Windows.DataPresenter.RecordType RecordsType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.DataRecord;
			}
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x000A14E0 File Offset: 0x0009F6E0
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
			if (dataPresenter != null && list != null && !parentRecordManager.IsSorted && dataPresenter.RecordLoadMode != global::Infragistics.Windows.DataPresenter.RecordLoadMode.PreloadRecords)
			{
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					object objectForComparison = global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(list[i]);
					if (dataItem == objectForComparison)
					{
						return parentRecordManager.Unsorted[i];
					}
				}
			}
			else
			{
				foreach (global::Infragistics.Windows.DataPresenter.DataRecord dataRecord in this)
				{
					if (dataRecord.DataItemForComparison == dataItem)
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

		// Token: 0x0600256C RID: 9580 RVA: 0x000A161C File Offset: 0x0009F81C
		public int IndexOf(global::Infragistics.Windows.DataPresenter.DataRecord item)
		{
			return base.SparseArray.IndexOf(item);
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x000A162A File Offset: 0x0009F82A
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord>.Insert(int index, global::Infragistics.Windows.DataPresenter.DataRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x000A163B File Offset: 0x0009F83B
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000AF6 RID: 2806
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

		// Token: 0x06002571 RID: 9585 RVA: 0x000A1671 File Offset: 0x0009F871
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataRecord>.Add(global::Infragistics.Windows.DataPresenter.DataRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x000A1682 File Offset: 0x0009F882
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataRecord>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x000A1693 File Offset: 0x0009F893
		public bool Contains(global::Infragistics.Windows.DataPresenter.DataRecord item)
		{
			return base.SparseArray.Contains(item);
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x000A16A1 File Offset: 0x0009F8A1
		public void CopyTo(global::Infragistics.Windows.DataPresenter.DataRecord[] array, int arrayIndex)
		{
			base.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x000A16AB File Offset: 0x0009F8AB
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x000A16AE File Offset: 0x0009F8AE
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataRecord>.Remove(global::Infragistics.Windows.DataPresenter.DataRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x000A16BF File Offset: 0x0009F8BF
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordCollectionBase.DataRecordEnumerator(base.SparseArray);
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x000A16CC File Offset: 0x0009F8CC
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return base.SparseArray.GetEnumerator(base.SparseArray);
		}
	}
}
