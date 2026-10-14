using System;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200034A RID: 842
	internal class UnsortedRecordSparseArray : global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase
	{
		// Token: 0x06002894 RID: 10388 RVA: 0x000B3A3B File Offset: 0x000B1C3B
		internal UnsortedRecordSparseArray(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records) : base(records, true, 40, 0.2f)
		{
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x000B3A4C File Offset: 0x000B1C4C
		protected override object GetOwnerData(object item)
		{
			return ((global::Infragistics.Windows.DataPresenter.Record)item)._sparseArrayOwnerData_Unsorted;
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x000B3A59 File Offset: 0x000B1C59
		protected override void SetOwnerData(object item, object ownerData)
		{
			((global::Infragistics.Windows.DataPresenter.Record)item)._sparseArrayOwnerData_Unsorted = ownerData;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000B3A67 File Offset: 0x000B1C67
		internal override void EnsureAllItemsCreated()
		{
			base.ToArray(true);
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x000B3A74 File Offset: 0x000B1C74
		internal override global::Infragistics.Windows.DataPresenter.Record GetItem(int index, bool create)
		{
			bool flag;
			return this.GetItem(index, create, false, out flag);
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x000B3A8C File Offset: 0x000B1C8C
		internal global::Infragistics.Windows.DataPresenter.Record GetItem(int index, bool create, bool calledFromSortedManagerSparseArray, out bool newRowCreated)
		{
			newRowCreated = false;
			global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)base[index];
			if (record == null && create)
			{
				record = base.OwnerCollection.AllocateNewRecord(index);
				newRowCreated = true;
				base[index] = record;
				if (!calledFromSortedManagerSparseArray)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = base.OwnerCollection.ParentRecordManager;
					global::Infragistics.Windows.DataPresenter.RecordCollectionBase sorted = parentRecordManager.Sorted;
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = sorted.ViewableRecords;
					int sortedIndexFromUnsortedIndex = viewableRecords.GetSortedIndexFromUnsortedIndex(index);
					record.InitializeParentCollection(sorted);
					record.SuspendFiltering();
					int scrollCountInternal = record.ScrollCountInternal;
					if (scrollCountInternal == 1)
					{
						sorted.BeginUpdate();
					}
					try
					{
						sorted.SparseArray[sortedIndexFromUnsortedIndex] = record;
					}
					finally
					{
						if (scrollCountInternal == 1)
						{
							sorted.EndUpdate(false);
						}
					}
					record.FireInitializeRecord();
					record.ResumeFiltering(true);
				}
			}
			return record;
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x000B3B50 File Offset: 0x000B1D50
		internal override global::Infragistics.Windows.DataPresenter.Record[] ToArray(bool create, global::System.Type arrayElementType)
		{
			global::Infragistics.Windows.DataPresenter.Record[] array = (global::Infragistics.Windows.DataPresenter.Record[])base.ToArray(arrayElementType);
			if (create)
			{
				base.OwnerCollection.BeginUpdate();
				try
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i] == null)
						{
							bool flag;
							array[i] = this.GetItem(i, create, false, out flag);
						}
					}
				}
				finally
				{
					base.OwnerCollection.EndUpdate(false);
				}
			}
			return array;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x000B3BBC File Offset: 0x000B1DBC
		public override object CreateItem(global::Infragistics.Collections.SparseArray array, int relativeIndex)
		{
			bool flag;
			return this.GetItem(relativeIndex, true, false, out flag);
		}
	}
}
