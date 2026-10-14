using System;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000309 RID: 777
	internal class UnsortedRecordSparseArray : global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase
	{
		// Token: 0x060024E3 RID: 9443 RVA: 0x0009FC6F File Offset: 0x0009DE6F
		internal UnsortedRecordSparseArray(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records) : base(records, true, 40, 0.2f)
		{
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x0009FC80 File Offset: 0x0009DE80
		protected override object GetOwnerData(object item)
		{
			return ((global::Infragistics.Windows.DataPresenter.Record)item)._sparseArrayOwnerData_Unsorted;
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x0009FC8D File Offset: 0x0009DE8D
		protected override void SetOwnerData(object item, object ownerData)
		{
			((global::Infragistics.Windows.DataPresenter.Record)item)._sparseArrayOwnerData_Unsorted = ownerData;
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x0009FC9B File Offset: 0x0009DE9B
		internal override void EnsureAllItemsCreated()
		{
			base.ToArray(true);
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x0009FCA8 File Offset: 0x0009DEA8
		internal override global::Infragistics.Windows.DataPresenter.Record GetItem(int index, bool create)
		{
			bool flag;
			return this.GetItem(index, create, false, out flag);
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x0009FCC0 File Offset: 0x0009DEC0
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

		// Token: 0x060024E9 RID: 9449 RVA: 0x0009FD84 File Offset: 0x0009DF84
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

		// Token: 0x060024EA RID: 9450 RVA: 0x0009FDF0 File Offset: 0x0009DFF0
		public override object CreateItem(global::Infragistics.Collections.SparseArray array, int relativeIndex)
		{
			bool flag;
			return this.GetItem(relativeIndex, true, false, out flag);
		}
	}
}
