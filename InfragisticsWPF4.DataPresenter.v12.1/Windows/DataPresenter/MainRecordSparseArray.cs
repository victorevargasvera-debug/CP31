using System;
using System.Collections;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000308 RID: 776
	internal class MainRecordSparseArray : global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase
	{
		// Token: 0x060024CA RID: 9418 RVA: 0x0009F900 File Offset: 0x0009DB00
		internal MainRecordSparseArray(global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection) : this(ownerCollection, true, 40, 0.2f)
		{
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x0009F911 File Offset: 0x0009DB11
		internal MainRecordSparseArray(global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection, bool manageScrollCounts) : this(ownerCollection, manageScrollCounts, 40, 0.2f)
		{
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x0009F922 File Offset: 0x0009DB22
		internal MainRecordSparseArray(global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection, bool manageScrollCounts, int factor) : this(ownerCollection, manageScrollCounts, factor, 0.2f)
		{
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x0009F934 File Offset: 0x0009DB34
		internal MainRecordSparseArray(global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection, bool manageScrollCounts, int factor, float growthFactor) : base(ownerCollection, manageScrollCounts, factor, growthFactor)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = ownerCollection.ParentRecordManager;
			if (parentRecordManager != null)
			{
				this._verifiedScrollCountVersion = parentRecordManager.ScrollCountVersion;
			}
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x0009F96C File Offset: 0x0009DB6C
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

		// Token: 0x060024CF RID: 9423 RVA: 0x0009F99C File Offset: 0x0009DB9C
		internal override void EnsureAllItemsCreated()
		{
			base.ToArray(true);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x0009F9A8 File Offset: 0x0009DBA8
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

		// Token: 0x060024D1 RID: 9425 RVA: 0x0009F9F7 File Offset: 0x0009DBF7
		internal override global::Infragistics.Windows.DataPresenter.Record GetItem(int index, bool create)
		{
			return (global::Infragistics.Windows.DataPresenter.Record)base.GetItem(index, create ? this : null);
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x0009FA0C File Offset: 0x0009DC0C
		protected override object GetOwnerData(object item)
		{
			if (base.OwnerCollection is global::Infragistics.Windows.DataPresenter.DataRecordCollection)
			{
				return ((global::Infragistics.Windows.DataPresenter.Record)item)._sparseArrayOwnerData_Sorted;
			}
			return ((global::Infragistics.Windows.DataPresenter.Record)item)._sparseArrayOwnerData_Grouped;
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x0009FA32 File Offset: 0x0009DC32
		protected override void SetOwnerData(object item, object ownerData)
		{
			if (base.OwnerCollection is global::Infragistics.Windows.DataPresenter.DataRecordCollection)
			{
				((global::Infragistics.Windows.DataPresenter.Record)item)._sparseArrayOwnerData_Sorted = ownerData;
				return;
			}
			((global::Infragistics.Windows.DataPresenter.Record)item)._sparseArrayOwnerData_Grouped = ownerData;
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x0009FA5A File Offset: 0x0009DC5A
		internal int VisibleCount
		{
			get
			{
				this.VerifyAgainstScrollVersion();
				return base.GetVisibleCount();
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x060024D5 RID: 9429 RVA: 0x0009FA68 File Offset: 0x0009DC68
		internal int ScrollCount
		{
			get
			{
				this.VerifyAgainstScrollVersion();
				return base.GetScrollCount();
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x0009FA76 File Offset: 0x0009DC76
		internal new bool InCalculatingScrollCount
		{
			get
			{
				return base.InCalculatingScrollCount;
			}
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x0009FA7E File Offset: 0x0009DC7E
		internal int VisibleIndexOf(global::Infragistics.Collections.ISparseArrayMultiItem immediateChild)
		{
			return this.VisibleIndexOf(immediateChild, false);
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x0009FA88 File Offset: 0x0009DC88
		internal int VisibleIndexOf(global::Infragistics.Collections.ISparseArrayMultiItem immediateChild, bool ignoreItemHiddenState)
		{
			this.VerifyAgainstScrollVersion();
			return base.GetVisibleIndexOf(immediateChild, ignoreItemHiddenState);
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x0009FA98 File Offset: 0x0009DC98
		internal int ScrollIndexOf(global::Infragistics.Collections.ISparseArrayMultiItem immediateChild, bool ignoreHiddenItemState)
		{
			this.VerifyAgainstScrollVersion();
			return base.GetScrollIndexOf(immediateChild, ignoreHiddenItemState);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x0009FAA8 File Offset: 0x0009DCA8
		internal global::Infragistics.Windows.DataPresenter.Record GetItemAtVisibleIndex(int visibleIndex)
		{
			this.VerifyAgainstScrollVersion();
			return (global::Infragistics.Windows.DataPresenter.Record)base.GetItemAtVisibleIndex(visibleIndex, this);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x0009FABD File Offset: 0x0009DCBD
		internal global::Infragistics.Windows.DataPresenter.Record GetItemAtVisibleIndexOffset(global::Infragistics.Windows.DataPresenter.Record startRow, int offset)
		{
			this.VerifyAgainstScrollVersion();
			return (global::Infragistics.Windows.DataPresenter.Record)base.GetItemAtVisibleIndexOffset(startRow, offset, this);
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x0009FAD3 File Offset: 0x0009DCD3
		internal global::Infragistics.Windows.DataPresenter.Record GetItemAtScrollIndex(int scrollIndex)
		{
			this.VerifyAgainstScrollVersion();
			return (global::Infragistics.Windows.DataPresenter.Record)base.GetItemAtScrollIndex(scrollIndex, this);
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x0009FAE8 File Offset: 0x0009DCE8
		internal global::Infragistics.Windows.DataPresenter.Record GetItemContainingScrollIndex(ref int scrollIndex)
		{
			this.VerifyAgainstScrollVersion();
			return (global::Infragistics.Windows.DataPresenter.Record)base.GetItemContainingScrollIndex(ref scrollIndex, this);
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x0009FAFD File Offset: 0x0009DCFD
		internal global::System.Collections.IEnumerable GetVisibleRecords(bool createItems)
		{
			return base.GetVisibleItems(createItems ? this : null);
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x0009FB0C File Offset: 0x0009DD0C
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

		// Token: 0x060024E0 RID: 9440 RVA: 0x0009FB84 File Offset: 0x0009DD84
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

		// Token: 0x060024E1 RID: 9441 RVA: 0x0009FBCC File Offset: 0x0009DDCC
		protected override void OnScrollCountChanged()
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection = base.OwnerCollection;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordsIfAllocated = ownerCollection.ViewableRecordsIfAllocated;
			if (viewableRecordsIfAllocated != null)
			{
				viewableRecordsIfAllocated.OnScrollCountDirtiedHelper();
			}
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x0009FBF0 File Offset: 0x0009DDF0
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

		// Token: 0x040011C0 RID: 4544
		private int _verifiedScrollCountVersion = -1;

		// Token: 0x040011C1 RID: 4545
		private bool _initializeRecordPending;
	}
}
