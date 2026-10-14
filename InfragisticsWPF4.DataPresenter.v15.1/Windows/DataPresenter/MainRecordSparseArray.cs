using System;
using System.Collections;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000349 RID: 841
	internal class MainRecordSparseArray : global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase
	{
		// Token: 0x0600287B RID: 10363 RVA: 0x000B36CC File Offset: 0x000B18CC
		internal MainRecordSparseArray(global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection) : this(ownerCollection, true, 40, 0.2f)
		{
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x000B36DD File Offset: 0x000B18DD
		internal MainRecordSparseArray(global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection, bool manageScrollCounts) : this(ownerCollection, manageScrollCounts, 40, 0.2f)
		{
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x000B36EE File Offset: 0x000B18EE
		internal MainRecordSparseArray(global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection, bool manageScrollCounts, int factor) : this(ownerCollection, manageScrollCounts, factor, 0.2f)
		{
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x000B3700 File Offset: 0x000B1900
		internal MainRecordSparseArray(global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection, bool manageScrollCounts, int factor, float growthFactor) : base(ownerCollection, manageScrollCounts, factor, growthFactor)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = ownerCollection.ParentRecordManager;
			if (parentRecordManager != null)
			{
				this._verifiedScrollCountVersion = parentRecordManager.ScrollCountVersion;
			}
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x000B3738 File Offset: 0x000B1938
		internal void DirtyScrollCount()
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection = base.OwnerCollection;
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = ownerCollection.ParentRecordManager;
			if (parentRecordManager != null)
			{
				this._verifiedScrollCountVersion = parentRecordManager.ScrollCountVersion;
			}
			base.DirtyScrollCountInfo();
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x000B3768 File Offset: 0x000B1968
		internal override void EnsureAllItemsCreated()
		{
			base.ToArray(true);
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x000B3774 File Offset: 0x000B1974
		private void VerifyAgainstScrollVersion()
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection = base.OwnerCollection;
			if (ownerCollection != null && !ownerCollection.IsUpdating)
			{
				ownerCollection.EnsureNotDirty();
				global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = ownerCollection.ParentRecordManager;
				if (parentRecordManager != null && this._verifiedScrollCountVersion != parentRecordManager.ScrollCountVersion)
				{
					this._verifiedScrollCountVersion = parentRecordManager.ScrollCountVersion;
					base.DirtyScrollCountInfo();
				}
			}
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x000B37C3 File Offset: 0x000B19C3
		internal override global::Infragistics.Windows.DataPresenter.Record GetItem(int index, bool create)
		{
			return (global::Infragistics.Windows.DataPresenter.Record)base.GetItem(index, create ? this : null);
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x000B37D8 File Offset: 0x000B19D8
		protected override object GetOwnerData(object item)
		{
			if (base.OwnerCollection is global::Infragistics.Windows.DataPresenter.DataRecordCollection)
			{
				return ((global::Infragistics.Windows.DataPresenter.Record)item)._sparseArrayOwnerData_Sorted;
			}
			return ((global::Infragistics.Windows.DataPresenter.Record)item)._sparseArrayOwnerData_Grouped;
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x000B37FE File Offset: 0x000B19FE
		protected override void SetOwnerData(object item, object ownerData)
		{
			if (base.OwnerCollection is global::Infragistics.Windows.DataPresenter.DataRecordCollection)
			{
				((global::Infragistics.Windows.DataPresenter.Record)item)._sparseArrayOwnerData_Sorted = ownerData;
				return;
			}
			((global::Infragistics.Windows.DataPresenter.Record)item)._sparseArrayOwnerData_Grouped = ownerData;
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06002885 RID: 10373 RVA: 0x000B3826 File Offset: 0x000B1A26
		internal int VisibleCount
		{
			get
			{
				this.VerifyAgainstScrollVersion();
				return base.GetVisibleCount();
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06002886 RID: 10374 RVA: 0x000B3834 File Offset: 0x000B1A34
		internal int ScrollCount
		{
			get
			{
				this.VerifyAgainstScrollVersion();
				return base.GetScrollCount();
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002887 RID: 10375 RVA: 0x000B3842 File Offset: 0x000B1A42
		internal new bool InCalculatingScrollCount
		{
			get
			{
				return base.InCalculatingScrollCount;
			}
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x000B384A File Offset: 0x000B1A4A
		internal int VisibleIndexOf(global::Infragistics.Collections.ISparseArrayMultiItem immediateChild)
		{
			return this.VisibleIndexOf(immediateChild, false);
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x000B3854 File Offset: 0x000B1A54
		internal int VisibleIndexOf(global::Infragistics.Collections.ISparseArrayMultiItem immediateChild, bool ignoreItemHiddenState)
		{
			this.VerifyAgainstScrollVersion();
			return base.GetVisibleIndexOf(immediateChild, ignoreItemHiddenState);
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000B3864 File Offset: 0x000B1A64
		internal int ScrollIndexOf(global::Infragistics.Collections.ISparseArrayMultiItem immediateChild, bool ignoreHiddenItemState)
		{
			this.VerifyAgainstScrollVersion();
			return base.GetScrollIndexOf(immediateChild, ignoreHiddenItemState);
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000B3874 File Offset: 0x000B1A74
		internal global::Infragistics.Windows.DataPresenter.Record GetItemAtVisibleIndex(int visibleIndex)
		{
			this.VerifyAgainstScrollVersion();
			return (global::Infragistics.Windows.DataPresenter.Record)base.GetItemAtVisibleIndex(visibleIndex, this);
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x000B3889 File Offset: 0x000B1A89
		internal global::Infragistics.Windows.DataPresenter.Record GetItemAtVisibleIndexOffset(global::Infragistics.Windows.DataPresenter.Record startRow, int offset)
		{
			this.VerifyAgainstScrollVersion();
			return (global::Infragistics.Windows.DataPresenter.Record)base.GetItemAtVisibleIndexOffset(startRow, offset, this);
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x000B389F File Offset: 0x000B1A9F
		internal global::Infragistics.Windows.DataPresenter.Record GetItemAtScrollIndex(int scrollIndex)
		{
			this.VerifyAgainstScrollVersion();
			return (global::Infragistics.Windows.DataPresenter.Record)base.GetItemAtScrollIndex(scrollIndex, this);
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x000B38B4 File Offset: 0x000B1AB4
		internal global::Infragistics.Windows.DataPresenter.Record GetItemContainingScrollIndex(ref int scrollIndex)
		{
			this.VerifyAgainstScrollVersion();
			return (global::Infragistics.Windows.DataPresenter.Record)base.GetItemContainingScrollIndex(ref scrollIndex, this);
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x000B38C9 File Offset: 0x000B1AC9
		internal global::System.Collections.IEnumerable GetVisibleRecords(bool createItems)
		{
			return base.GetVisibleItems(createItems ? this : null);
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x000B38D8 File Offset: 0x000B1AD8
		internal override global::Infragistics.Windows.DataPresenter.Record[] ToArray(bool create, global::System.Type arrayElementType)
		{
			if (!create)
			{
				return (global::Infragistics.Windows.DataPresenter.Record[])base.ToArray(arrayElementType);
			}
			global::Infragistics.Windows.DataPresenter.Record[] array = (global::Infragistics.Windows.DataPresenter.Record[])global::System.Array.CreateInstance(arrayElementType, base.Count);
			base.OwnerCollection.BeginUpdate();
			try
			{
				for (int i = 0; i < base.Count; i++)
				{
					array[i] = this.GetItem(i, true);
				}
			}
			finally
			{
				base.OwnerCollection.EndUpdate(false);
			}
			return array;
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x000B3950 File Offset: 0x000B1B50
		protected override void OnItemCreated(object item, int index)
		{
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null && global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter == record._cachedFilterState)
			{
				record._cachedFilterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter;
			}
			base.OnItemCreated(item, index);
			if (this._initializeRecordPending)
			{
				this._initializeRecordPending = false;
				if (record != null)
				{
					record.FireInitializeRecord();
				}
			}
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x000B3998 File Offset: 0x000B1B98
		protected override void OnScrollCountChanged()
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection = base.OwnerCollection;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordsIfAllocated = ownerCollection.ViewableRecordsIfAllocated;
			if (viewableRecordsIfAllocated != null)
			{
				viewableRecordsIfAllocated.OnScrollCountDirtiedHelper();
			}
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x000B39BC File Offset: 0x000B1BBC
		public override object CreateItem(global::Infragistics.Collections.SparseArray array, int relativeIndex)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = base.OwnerCollection.ParentRecordManager;
			global::Infragistics.Windows.DataPresenter.UnsortedRecordSparseArray unsortedRecordSparseArray = ((global::Infragistics.Windows.DataPresenter.DataRecordCollection)parentRecordManager.Unsorted).SparseArray as global::Infragistics.Windows.DataPresenter.UnsortedRecordSparseArray;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = parentRecordManager.Sorted.ViewableRecords;
			int unsortedIndexFromSortedIndex = viewableRecords.GetUnsortedIndexFromSortedIndex(relativeIndex);
			bool flag;
			global::Infragistics.Windows.DataPresenter.Record item = unsortedRecordSparseArray.GetItem(unsortedIndexFromSortedIndex, true, true, out flag);
			if (flag && item != null)
			{
				item.InitializeParentCollection(base.OwnerCollection);
				this._initializeRecordPending = true;
				if (viewableRecords.VerificationNeeded)
				{
					item._cachedFilterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter;
				}
			}
			return item;
		}

		// Token: 0x040013E0 RID: 5088
		private int _verifiedScrollCountVersion = -1;

		// Token: 0x040013E1 RID: 5089
		private bool _initializeRecordPending;
	}
}
