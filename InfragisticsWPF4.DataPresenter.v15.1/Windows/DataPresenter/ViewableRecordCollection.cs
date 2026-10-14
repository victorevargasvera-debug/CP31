using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200039E RID: 926
	public class ViewableRecordCollection : global::Infragistics.PropertyChangeNotifier, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x06002C3F RID: 11327 RVA: 0x000C22C4 File Offset: 0x000C04C4
		internal ViewableRecordCollection(global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(recordCollection);
			this._recordCollection = recordCollection;
			this._recordCollection.CollectionChanged += this.OnSorted_CollectionChanged;
			this._recordCollection.PropertyChanged += this.OnSorted_PropertyChanged;
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x000C2319 File Offset: 0x000C0519
		protected override void OnFirstListenerAdding()
		{
			base.OnFirstListenerAdding();
			this.OnFirstListenerAddingInternal();
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x000C2327 File Offset: 0x000C0527
		protected override void OnHasListenersChanged()
		{
			base.OnHasListenersChanged();
			this.VerifyHasAnyListeners();
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x000C2335 File Offset: 0x000C0535
		private void OnSorted_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (!this._bypassRecordCollectionNotifications)
			{
				this.RaisePropertyChangedEvent(e.PropertyName);
			}
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x000C234C File Offset: 0x000C054C
		private void OnSorted_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.BumpRecordNumberVersion();
			global::System.Collections.Specialized.NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs = e;
			if (e.Action != global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				if (this._bypassRecordCollectionNotifications)
				{
					return;
				}
				switch (e.Action)
				{
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				{
					global::System.Collections.IList newItems = e.NewItems;
					int num = e.NewStartingIndex;
					if (newItems != null && newItems.Count == 1)
					{
						global::Infragistics.Windows.DataPresenter.Record record = newItems[0] as global::Infragistics.Windows.DataPresenter.Record;
						if (record == null || record.Visibility == global::System.Windows.Visibility.Collapsed)
						{
							return;
						}
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
						if (dataRecord != null && dataRecord.IsAddRecord)
						{
							this.VerifyCachedRecordStatus(dataRecord);
							return;
						}
						if (dataRecord == this._lastAddRecord)
						{
							this._lastAddRecord = null;
						}
						num = this.RecordCollectionSparseArray.VisibleIndexOf(record);
						if (num < 0)
						{
							return;
						}
						bool flag = false;
						if (this._fixedNonSpecialRecordsOnTop != null)
						{
							flag = (num < this._fixedNonSpecialRecordsOnTop.Count);
						}
						if (!flag && this._fixedNonSpecialRecordsOnBottom != null)
						{
							flag = (num >= this.RecordCollectionSparseArray.Count - this._fixedNonSpecialRecordsOnBottom.Count);
						}
						if (flag)
						{
							this.DirtySpecialRecords(true);
							return;
						}
						if (this._specialRecordsOnTop != null)
						{
							num += this._specialRecordsOnTop.Count;
						}
						if (num < 0)
						{
							notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset);
						}
						else if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
						{
							notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(e.Action, e.NewItems, num);
						}
						else
						{
							notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(e.Action, e.OldItems, num);
						}
					}
					else
					{
						notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset);
					}
					break;
				}
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
					notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset);
					break;
				}
			}
			if (notifyCollectionChangedEventArgs.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				this._isResetNotificationNeeded = false;
				if (this._recordCollection.ParentRecord == null)
				{
					this._lastScrollCount = -1;
				}
			}
			this.RaiseCollectionChanged(notifyCollectionChangedEventArgs);
			if (notifyCollectionChangedEventArgs.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
				if (recordManager != null)
				{
					recordManager.NotifyCalcAdapterHelper(global::Infragistics.Windows.DataPresenter.DataChangeType.Reset, null, null);
				}
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x000C2519 File Offset: 0x000C0719
		public int CountOfFixedRecordsOnBottom
		{
			get
			{
				this.Verify();
				if (this._fixedRecordsOnBottom == null)
				{
					return 0;
				}
				return this._fixedRecordsOnBottom.Count;
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x000C2536 File Offset: 0x000C0736
		public int CountOfFixedRecordsOnTop
		{
			get
			{
				this.Verify();
				if (this._fixedRecordsOnTop == null)
				{
					return 0;
				}
				return this._fixedRecordsOnTop.Count;
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x000C2554 File Offset: 0x000C0754
		internal bool IsSpecialRecordsDirty
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
				return fieldLayout != null && this._verifiedSpecialRecordsVersion != fieldLayout.SpecialRecordsVersion;
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x000C2580 File Offset: 0x000C0780
		internal bool AreRecordFiltersDirty
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
				global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection resolvedRecordFilterCollection = (recordManager != null) ? recordManager.RecordFiltersResolved : null;
				return resolvedRecordFilterCollection != null && this._verifiedFiltersVersion != resolvedRecordFilterCollection.Version;
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x000C25B8 File Offset: 0x000C07B8
		internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection AssociatedViewableRecordCollection
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase dataPresenterExportControlBase = this.RecordCollection.DataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase;
				if (dataPresenterExportControlBase == null)
				{
					return null;
				}
				if (dataPresenterExportControlBase.ReportVersion != this._reportVersion)
				{
					this._reportVersion = dataPresenterExportControlBase.ReportVersion;
					this._associatedViewableRecordCollection = null;
				}
				if (this._associatedViewableRecordCollection == null)
				{
					global::Infragistics.Windows.DataPresenter.Record parentRecord = this.RecordCollection.ParentRecord;
					if (parentRecord == null)
					{
						this._associatedViewableRecordCollection = dataPresenterExportControlBase.SourceDataPresenter.ViewableRecords;
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.Record associatedRecord = parentRecord.GetAssociatedRecord();
						if (associatedRecord == null)
						{
							return null;
						}
						this._associatedViewableRecordCollection = associatedRecord.ViewableChildRecords;
					}
				}
				return this._associatedViewableRecordCollection;
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x000C2644 File Offset: 0x000C0844
		internal int CountOfNonSpecialRecords
		{
			get
			{
				return this.RecordCollectionSparseArray.VisibleCount;
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x000C2651 File Offset: 0x000C0851
		internal int CountOfSpecialRecordsOnBottom
		{
			get
			{
				this.Verify();
				if (this._specialRecordsOnBottom != null)
				{
					return this._specialRecordsOnBottom.Count;
				}
				return 0;
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x000C266E File Offset: 0x000C086E
		internal int CountOfSpecialRecordsOnTop
		{
			get
			{
				this.Verify();
				if (this._specialRecordsOnTop != null)
				{
					return this._specialRecordsOnTop.Count;
				}
				return 0;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x000C268B File Offset: 0x000C088B
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._recordCollection.FieldLayout;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x000C2698 File Offset: 0x000C0898
		internal bool HasAnyListeners
		{
			get
			{
				return this._collectionChanged != null || base.HasListeners;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x000C26AA File Offset: 0x000C08AA
		internal bool HasFilterRecord
		{
			get
			{
				this.VerifySpecialRecords();
				return this.HasRecordType(this._specialRecordsOnTop, global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord) || this.HasRecordType(this._specialRecordsOnBottom, global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord);
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x000C26D0 File Offset: 0x000C08D0
		internal bool HasHeaderRecord
		{
			get
			{
				this.VerifySpecialRecords();
				return this.HasRecordType(this._specialRecordsOnTop, global::Infragistics.Windows.DataPresenter.RecordType.HeaderRecord) || this.HasRecordType(this._specialRecordsOnBottom, global::Infragistics.Windows.DataPresenter.RecordType.HeaderRecord);
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x000C26F6 File Offset: 0x000C08F6
		internal bool HasSummaryRecord
		{
			get
			{
				this.VerifySpecialRecords();
				return this.HasRecordType(this._specialRecordsOnTop, global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord) || this.HasRecordType(this._specialRecordsOnBottom, global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord);
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x000C271C File Offset: 0x000C091C
		internal bool IsAddRecordOnTop
		{
			get
			{
				return this._recordCollection is global::Infragistics.Windows.DataPresenter.DataRecordCollection && this._recordCollection.ParentRecordManager.IsAddRecordOnTop;
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x000C273D File Offset: 0x000C093D
		internal bool VerificationNeeded
		{
			get
			{
				return this.IsSpecialRecordsDirty || this.AreRecordFiltersDirty;
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06002C53 RID: 11347 RVA: 0x000C2754 File Offset: 0x000C0954
		// (set) Token: 0x06002C54 RID: 11348 RVA: 0x000C2794 File Offset: 0x000C0994
		internal global::Infragistics.Windows.DataPresenter.RecordListControl LastRecordList
		{
			get
			{
				if (this._lastRecordList == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._lastRecordList) as global::Infragistics.Windows.DataPresenter.RecordListControl;
				if (recordListControl == null)
				{
					return null;
				}
				if (recordListControl.ItemsSource != this)
				{
					this._lastRecordList = null;
					return null;
				}
				return recordListControl;
			}
			set
			{
				if (value == null)
				{
					this._lastRecordList = null;
					return;
				}
				if (value != this.LastRecordList)
				{
					this._lastRecordList = new global::System.WeakReference(value);
				}
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002C55 RID: 11349 RVA: 0x000C27B6 File Offset: 0x000C09B6
		internal global::Infragistics.Windows.DataPresenter.RecordCollectionBase RecordCollection
		{
			get
			{
				return this._recordCollection;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x000C27BE File Offset: 0x000C09BE
		internal global::Infragistics.Windows.DataPresenter.MainRecordSparseArray RecordCollectionSparseArray
		{
			get
			{
				return this._recordCollection.SparseArray as global::Infragistics.Windows.DataPresenter.MainRecordSparseArray;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06002C57 RID: 11351 RVA: 0x000C27D0 File Offset: 0x000C09D0
		internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return this._recordCollection.ParentRecordManager;
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x000C27DD File Offset: 0x000C09DD
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> RecordsInsertedAtTop
		{
			get
			{
				if (this._recordsInsertedAtTop == null && this._recordCollection is global::Infragistics.Windows.DataPresenter.DataRecordCollection)
				{
					this._recordsInsertedAtTop = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
				}
				return this._recordsInsertedAtTop;
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x000C2808 File Offset: 0x000C0A08
		internal int ScrollCount
		{
			get
			{
				this.Verify();
				int num = this.RecordCollectionSparseArray.ScrollCount;
				if (this._specialRecordsOnTop != null)
				{
					num += this._specialRecordsOnTop.Count;
				}
				if (this._specialRecordsOnBottom != null)
				{
					num += this._specialRecordsOnBottom.Count;
				}
				return num;
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x000C2854 File Offset: 0x000C0A54
		internal bool ShouldRaiseCollectionNotifications
		{
			get
			{
				if (this.HasAnyListeners)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
					if (recordManager == null || !recordManager.IsUpdating || !recordManager.BeginUpdateInfo.HasPendingResetNotification(this))
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x000C288C File Offset: 0x000C0A8C
		internal void ClearCachedRecordsOnTop()
		{
			if (this._recordsInsertedAtTop != null && this._recordsInsertedAtTop.Count > 0)
			{
				this._recordsInsertedAtTop.Clear();
				this.RaiseChangeEvents(true);
			}
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x000C28B8 File Offset: 0x000C0AB8
		internal void ClearFixedRecords()
		{
			bool flag = false;
			if (this._fixedNonSpecialRecordsOnTop != null)
			{
				flag = (this._fixedNonSpecialRecordsOnTop.Count > 0);
				this._fixedNonSpecialRecordsOnTop = null;
			}
			if (this._fixedNonSpecialRecordsOnBottom != null)
			{
				flag = (flag || this._fixedNonSpecialRecordsOnBottom.Count > 0);
				this._fixedNonSpecialRecordsOnBottom = null;
			}
			if (flag)
			{
				this.DirtySpecialRecords(false);
			}
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x000C2914 File Offset: 0x000C0B14
		internal void CloneFixedRecords(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection source)
		{
			foreach (global::Infragistics.Windows.DataPresenter.DataRecord dataRecord in this._recordCollection.ParentRecordManager.Sorted)
			{
			}
			this.CloneFixedRecordsHelper(source, true);
			this.CloneFixedRecordsHelper(source, false);
			this.DirtySpecialRecords(false);
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000C297C File Offset: 0x000C0B7C
		private void CloneFixedRecordsHelper(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection source, bool onTop)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list;
			if (onTop)
			{
				list = source._fixedNonSpecialRecordsOnTop;
			}
			else
			{
				list = source._fixedNonSpecialRecordsOnBottom;
			}
			if (list == null || list.Count == 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this._recordCollection.ParentRecordManager;
			if (parentRecordManager == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray = ((global::Infragistics.Windows.DataPresenter.DataRecordCollection)parentRecordManager.Unsorted).SparseArray;
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager2 = source._recordCollection.ParentRecordManager;
			if (parentRecordManager2 == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray2 = ((global::Infragistics.Windows.DataPresenter.DataRecordCollection)parentRecordManager2.Unsorted).SparseArray;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>(list.Count);
			foreach (global::Infragistics.Windows.DataPresenter.Record record in list)
			{
				if (record is global::Infragistics.Windows.DataPresenter.DataRecord)
				{
					int num = sparseArray2.IndexOf(record);
					if (num >= 0)
					{
						global::Infragistics.Windows.DataPresenter.Record item = sparseArray.GetItem(num, true);
						item._fixedLocation = record._fixedLocation;
						item.SeparatorVisibility = record.SeparatorVisibility;
						list2.Add(item);
					}
				}
			}
			if (onTop)
			{
				this._fixedNonSpecialRecordsOnTop = list2;
				return;
			}
			this._fixedNonSpecialRecordsOnBottom = list2;
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000C2A94 File Offset: 0x000C0C94
		internal void DirtyFixedRecordOrder()
		{
			this._verifiedSpecialRecordsVersion = global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.FixedRecordOrderIsDirty;
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x000C2AA1 File Offset: 0x000C0CA1
		internal void DirtySpecialRecords(bool verify)
		{
			if (this._verifiedSpecialRecordsVersion >= 0)
			{
				this._verifiedSpecialRecordsVersion = -1;
			}
			if (verify)
			{
				this.Verify();
			}
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x000C2ABC File Offset: 0x000C0CBC
		internal void EnsureCorrectSortPosition(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (this.RecordCollection == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.MainRecordSparseArray recordCollectionSparseArray = this.RecordCollectionSparseArray;
			if (recordCollectionSparseArray != null)
			{
				int num = recordCollectionSparseArray.IndexOf(record);
				if (num < 0)
				{
					return;
				}
				int num2 = -1;
				if (record is global::Infragistics.Windows.DataPresenter.DataRecord)
				{
					num2 = this.GetDataRecordInsertLocation(recordCollectionSparseArray, (global::Infragistics.Windows.DataPresenter.DataRecord)record);
				}
				else if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord)
				{
					num2 = this.GetGroupByRecordInsertLocation((global::Infragistics.Windows.DataPresenter.GroupByRecord)record, true);
				}
				if (num2 >= 0 && num != num2)
				{
					this.MoveRecord(record, num2, num);
				}
			}
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x000C2B2C File Offset: 0x000C0D2C
		internal bool EnsureFiltersEvaluated()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
			if (this._inEnsureFiltersEvaluated || recordManager == null || recordManager.IsInReset || recordManager.IsResetPending)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection resolvedRecordFilterCollection = (recordManager != null) ? recordManager.RecordFiltersResolved : null;
			if (resolvedRecordFilterCollection == null || this._verifiedFiltersVersion == resolvedRecordFilterCollection.Version)
			{
				return true;
			}
			this._verifiedFiltersVersion = resolvedRecordFilterCollection.Version;
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection = this.RecordCollection;
			if (recordCollection.IsTopLevel && recordCollection != recordManager.Current)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.FilterEvaluationMode filterEvaluationModeResolved = recordManager.FilterEvaluationModeResolved;
			if (global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.UseCollectionView == filterEvaluationModeResolved || global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Manual == filterEvaluationModeResolved)
			{
				return true;
			}
			recordCollection.EnsureNotDirty();
			this._inEnsureFiltersEvaluated = true;
			int num = 0;
			recordCollection.BeginUpdate();
			try
			{
				global::Infragistics.Windows.DataPresenter.RecordType recordsType = recordCollection.RecordsType;
				if (global::Infragistics.Windows.DataPresenter.RecordType.GroupByField == recordsType || recordsType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord)
				{
					global::Infragistics.Windows.DataPresenter.MainRecordSparseArray recordCollectionSparseArray = this.RecordCollectionSparseArray;
					recordCollectionSparseArray.DirtyScrollCount();
					if (this._recordCollection.IsTopLevel && resolvedRecordFilterCollection.HasActiveFiltersInAnyFieldLayout())
					{
						recordCollectionSparseArray.EnsureAllItemsCreated();
					}
					int num2 = 0;
					int num3 = 0;
					foreach (object obj in recordCollectionSparseArray.NonNullItems)
					{
						global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)obj;
						global::Infragistics.Windows.DataPresenter.Record.FilterState cachedFilterState = record._cachedFilterState;
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
						if (dataRecord != null)
						{
							dataRecord.ApplyFiltersHelper(resolvedRecordFilterCollection, false);
						}
						else
						{
							global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = record as global::Infragistics.Windows.DataPresenter.GroupByRecord;
							if (groupByRecord != null)
							{
								groupByRecord.ApplyFiltersHelper(false);
							}
						}
						global::Infragistics.Windows.DataPresenter.Record.FilterState cachedFilterState2 = record._cachedFilterState;
						if ((short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & cachedFilterState2) != 0)
						{
							num2++;
						}
						if ((short)((global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn | global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction | global::Infragistics.Windows.DataPresenter.Record.FilterState.ReduceOpacity) & cachedFilterState) != (short)((global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn | global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction | global::Infragistics.Windows.DataPresenter.Record.FilterState.ReduceOpacity) & cachedFilterState2))
						{
							num3++;
						}
						if ((short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & cachedFilterState) != (short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & cachedFilterState2))
						{
							num++;
						}
					}
					global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord2 = recordCollection.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
					if (groupByRecord2 != null)
					{
						groupByRecord2.ApplyFiltersHelper(num2 > 0 && num2 == recordCollectionSparseArray.Count, false);
					}
					this._verifiedFiltersVersion = resolvedRecordFilterCollection.Version;
					if (num3 > 0)
					{
						this.DirtySpecialRecords(false);
						this.RaiseChangeEvents(true);
					}
					if (recordCollection == recordManager.Groups)
					{
						global::Infragistics.Windows.DataPresenter.DataRecordCollection sortedInternal = recordManager.SortedInternal;
						global::Infragistics.Windows.DataPresenter.MainRecordSparseArray mainRecordSparseArray = (sortedInternal != null) ? (sortedInternal.SparseArray as global::Infragistics.Windows.DataPresenter.MainRecordSparseArray) : null;
						if (mainRecordSparseArray != null)
						{
							mainRecordSparseArray.DirtyScrollCount();
							sortedInternal.RaiseChangeEvents(true);
						}
					}
				}
			}
			finally
			{
				this._inEnsureFiltersEvaluated = false;
				recordCollection.EndUpdate(false);
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
				if (num > 0 && fieldLayout != null && global::Infragistics.Windows.DataPresenter.CalculationScope.FilteredSortedList == fieldLayout.CalculationScopeResolved)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager.DirtySummaryResults(null, null, this._recordCollection, recordManager);
					global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCalcAdapter(global::Infragistics.Windows.DataPresenter.GridUtilities.GetDataPresenter(this._recordCollection), this, "Reset", null);
				}
				this.BumpRecordNumberVersion();
			}
			return true;
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x000C2DDC File Offset: 0x000C0FDC
		internal global::Infragistics.Windows.DataPresenter.FilterRecord GetAssociatedFilterRecord(global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord)
		{
			return null;
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x000C2DE0 File Offset: 0x000C0FE0
		internal global::Infragistics.Windows.DataPresenter.SummaryRecord GetAssociatedSummaryRecord(global::Infragistics.Windows.DataPresenter.SummaryRecord record)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase dataPresenterExportControlBase = this.RecordCollection.DataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase;
			if (dataPresenterExportControlBase == null)
			{
				return null;
			}
			if (dataPresenterExportControlBase.ReportVersion != this._reportVersion)
			{
				this._associatedRecordMap = null;
			}
			if (this._associatedRecordMap == null)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection associatedViewableRecordCollection = this.AssociatedViewableRecordCollection;
				if (associatedViewableRecordCollection == null)
				{
					return null;
				}
				int num = 0;
				if (this._specialRecordsOnBottom != null)
				{
					num += this._specialRecordsOnBottom.Count;
				}
				if (this._specialRecordsOnTop != null)
				{
					num += this._specialRecordsOnTop.Count;
				}
				this._associatedRecordMap = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext, global::Infragistics.Windows.DataPresenter.SummaryRecord>(global::System.Math.Max(10, num * 2));
				this.AddSummaryRecordsToMapHelper(associatedViewableRecordCollection._specialRecordsOnBottom);
				this.AddSummaryRecordsToMapHelper(associatedViewableRecordCollection._specialRecordsOnTop);
			}
			global::Infragistics.Windows.DataPresenter.SummaryRecord result;
			this._associatedRecordMap.TryGetValue(record.SummaryDisplayAreaContext, out result);
			return result;
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x000C2E9C File Offset: 0x000C109C
		private void AddSummaryRecordsToMapHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list)
		{
			if (list != null)
			{
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = list[i] as global::Infragistics.Windows.DataPresenter.SummaryRecord;
					if (summaryRecord != null)
					{
						this._associatedRecordMap[summaryRecord.SummaryDisplayAreaContext] = summaryRecord;
					}
				}
			}
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000C2EE1 File Offset: 0x000C10E1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> CreateFlatScrollRecordsCollection(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc)
		{
			return new global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection(vrc.RecordManager);
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x000C2EF0 File Offset: 0x000C10F0
		private int GetDataRecordInsertLocation(global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sarr, global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
			global::System.Collections.IComparer comparer = new global::Infragistics.Windows.DataPresenter.RecordManager.RecordsSortComparer(recordManager == null || !recordManager.IsSorted);
			int i = 0;
			int num = sarr.Count - 1;
			int num2 = sarr.IndexOf(record);
			while (i <= num)
			{
				int num3 = (i + num) / 2;
				global::Infragistics.Windows.DataPresenter.Record item = sarr.GetItem(num3, true);
				if (record == item)
				{
					if (i == num)
					{
						break;
					}
					item = sarr.GetItem(++num3, true);
				}
				int num4 = comparer.Compare(record, item);
				if (num4 < 0)
				{
					num = num3 - 1;
				}
				else if (num4 > 0)
				{
					i = num3 + 1;
				}
				else if (num2 >= 0 && num2 < num3)
				{
					num = num3 - 1;
				}
				else
				{
					i = num3 + 1;
				}
			}
			if (num2 < 0 || num2 >= i)
			{
				return i;
			}
			return i - 1;
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x000C2FA8 File Offset: 0x000C11A8
		internal object GetItem(int index)
		{
			if (index < 0)
			{
				throw new global::System.ArgumentOutOfRangeException();
			}
			int num = 0;
			if (this._specialRecordsOnTop != null)
			{
				num = this._specialRecordsOnTop.Count;
			}
			if (index < num)
			{
				return this._specialRecordsOnTop[index];
			}
			index -= num;
			int visibleCount = this.RecordCollectionSparseArray.VisibleCount;
			bool flag = true;
			if (index < visibleCount)
			{
				global::Infragistics.Windows.DataPresenter.Record itemAtVisibleIndex = this.RecordCollectionSparseArray.GetItemAtVisibleIndex(index);
				if (itemAtVisibleIndex != null)
				{
					return itemAtVisibleIndex;
				}
				visibleCount = this.RecordCollectionSparseArray.VisibleCount;
				flag = false;
			}
			index -= visibleCount;
			if (index >= 0)
			{
				int num2 = 0;
				if (this._specialRecordsOnBottom != null)
				{
					num2 = this._specialRecordsOnBottom.Count;
				}
				if (index < num2)
				{
					return this._specialRecordsOnBottom[index];
				}
			}
			if (flag)
			{
				throw new global::System.ArgumentOutOfRangeException();
			}
			return null;
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x000C305C File Offset: 0x000C125C
		internal global::Infragistics.Windows.DataPresenter.Record GetRecordAtScrollPosition(int index)
		{
			if (index < 0)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.MainRecordSparseArray recordCollectionSparseArray = this.RecordCollectionSparseArray;
			int scrollCount = recordCollectionSparseArray.ScrollCount;
			int num = 0;
			this.Verify();
			if (scrollCount > 0 && (this._fixedRecordsOnTop == null || this._fixedRecordsOnTop.Count == 0))
			{
				global::Infragistics.Windows.DataPresenter.Record itemAtVisibleIndex = recordCollectionSparseArray.GetItemAtVisibleIndex(0);
				if (itemAtVisibleIndex != null && itemAtVisibleIndex.IsExpanded && itemAtVisibleIndex.FieldLayout.ChildRecordsDisplayOrderResolved == global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.BeforeParentHeadersAttached)
				{
					num = itemAtVisibleIndex.ViewableChildRecordScrollCount;
					if (index < num)
					{
						return itemAtVisibleIndex.ViewableChildRecords.GetRecordAtScrollPosition(index);
					}
					index -= num;
				}
			}
			int num2 = (this._specialRecordsOnTop != null) ? this._specialRecordsOnTop.Count : 0;
			if (num2 > 0)
			{
				if (index < num2)
				{
					return this._specialRecordsOnTop[index];
				}
				index -= num2;
			}
			int num3 = scrollCount - num;
			if (index < num3)
			{
				return recordCollectionSparseArray.GetItemAtScrollIndex(index + num);
			}
			index -= num3;
			num2 = ((this._specialRecordsOnBottom != null) ? this._specialRecordsOnBottom.Count : 0);
			if (index < num2)
			{
				return this._specialRecordsOnBottom[index];
			}
			return null;
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x000C3158 File Offset: 0x000C1358
		internal global::Infragistics.Windows.DataPresenter.Record GetRecordContainingScrollIndex(ref int scrollIndex)
		{
			global::Infragistics.Windows.DataPresenter.MainRecordSparseArray recordCollectionSparseArray = this.RecordCollectionSparseArray;
			int scrollCount = recordCollectionSparseArray.ScrollCount;
			int num = 0;
			if (scrollCount > 0 && this.CountOfFixedRecordsOnTop == 0)
			{
				global::Infragistics.Windows.DataPresenter.Record itemAtVisibleIndex = recordCollectionSparseArray.GetItemAtVisibleIndex(0);
				if (itemAtVisibleIndex != null && itemAtVisibleIndex.IsExpanded && itemAtVisibleIndex.FieldLayout.ChildRecordsDisplayOrderResolved == global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.BeforeParentHeadersAttached)
				{
					num = itemAtVisibleIndex.ViewableChildRecordScrollCount;
					if (scrollIndex < num)
					{
						return itemAtVisibleIndex;
					}
					scrollIndex -= num;
				}
			}
			if (this._specialRecordsOnTop != null)
			{
				int count = this._specialRecordsOnTop.Count;
				if (scrollIndex < count)
				{
					global::Infragistics.Windows.DataPresenter.Record result = this._specialRecordsOnTop[scrollIndex];
					scrollIndex = 0;
					return result;
				}
				scrollIndex -= count;
			}
			int num2 = scrollCount - num;
			if (scrollIndex < num2)
			{
				scrollIndex += num;
				return recordCollectionSparseArray.GetItemContainingScrollIndex(ref scrollIndex);
			}
			scrollIndex -= num2;
			if (this._specialRecordsOnBottom != null)
			{
				int count2 = this._specialRecordsOnBottom.Count;
				if (scrollIndex < count2)
				{
					global::Infragistics.Windows.DataPresenter.Record result2 = this._specialRecordsOnBottom[scrollIndex];
					scrollIndex = 0;
					return result2;
				}
			}
			return null;
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x000C323E File Offset: 0x000C143E
		internal int GetScopedScrollIndexOfRecord(global::Infragistics.Windows.DataPresenter.Record record, bool ignoreHiddenItemState)
		{
			return this.GetScopedScrollIndexOfRecord(record, ignoreHiddenItemState, false);
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x000C324C File Offset: 0x000C144C
		internal int GetScopedScrollIndexOfRecord(global::Infragistics.Windows.DataPresenter.Record record, bool ignoreHiddenItemState, bool getMinOfRecordAndFirstChild)
		{
			global::Infragistics.Windows.DataPresenter.MainRecordSparseArray recordCollectionSparseArray = this.RecordCollectionSparseArray;
			int scrollCount = recordCollectionSparseArray.ScrollCount;
			int num = 0;
			global::Infragistics.Windows.DataPresenter.Record record2 = null;
			if (scrollCount > 0 && this.CountOfFixedRecordsOnTop == 0)
			{
				record2 = recordCollectionSparseArray.GetItemAtVisibleIndex(0);
				if (record2 != null && record2.IsExpanded && record2.FieldLayout.ChildRecordsDisplayOrderResolved == global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.BeforeParentHeadersAttached && record2.ViewableChildRecords != null)
				{
					num = record2.ViewableChildRecordScrollCount;
				}
			}
			if (!record.IsSpecialRecord)
			{
				int num2 = this.RecordCollectionSparseArray.ScrollIndexOf(record, ignoreHiddenItemState);
				if (!record.AreChildrenAfterParent && record.IsExpanded && record.ViewableChildRecordsIfNeeded != null)
				{
					if (getMinOfRecordAndFirstChild)
					{
						if (record == record2 && record2.FieldLayout.ChildRecordsDisplayOrderResolved == global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.BeforeParentHeadersAttached)
						{
							return num2;
						}
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded = record.ViewableChildRecordsIfNeeded;
						if (viewableChildRecordsIfNeeded != null)
						{
							num2 += viewableChildRecordsIfNeeded.ScrollCount;
						}
					}
				}
				return num2 + this.CountOfSpecialRecordsOnTop;
			}
			if (this._specialRecordsOnTop != null && this._specialRecordsOnTop.Contains(record))
			{
				return num + this._specialRecordsOnTop.IndexOf(record);
			}
			if (this._specialRecordsOnBottom != null && this._specialRecordsOnBottom.Contains(record))
			{
				return this._specialRecordsOnBottom.IndexOf(record) + this.CountOfSpecialRecordsOnTop + this.RecordCollectionSparseArray.ScrollCount;
			}
			return -1;
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x000C336C File Offset: 0x000C156C
		internal global::Infragistics.Windows.DataPresenter.Record GetSpecialRecord(global::Infragistics.Windows.DataPresenter.RecordType recordType)
		{
			this.Verify();
			if (this._specialRecordsOnTop != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Record record in this._specialRecordsOnTop)
				{
					if (record.RecordType == recordType)
					{
						return record;
					}
				}
			}
			if (this._specialRecordsOnBottom != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Record record2 in this._specialRecordsOnBottom)
				{
					if (record2.RecordType == recordType)
					{
						return record2;
					}
				}
			}
			return null;
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x000C3428 File Offset: 0x000C1628
		internal global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> GetSpecialRecords(bool onTop)
		{
			this.VerifySpecialRecords();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = onTop ? this._specialRecordsOnTop : this._specialRecordsOnBottom;
			if (list == null)
			{
				return null;
			}
			return list.GetEnumerator();
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x000C3460 File Offset: 0x000C1660
		internal int GetSortedIndexFromUnsortedIndex(int unsortedIndex)
		{
			if (unsortedIndex < 0)
			{
				return unsortedIndex;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this._recordCollection.ParentRecordManager;
			if (parentRecordManager == null)
			{
				return unsortedIndex;
			}
			global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray = ((global::Infragistics.Windows.DataPresenter.DataRecordCollection)parentRecordManager.Unsorted).SparseArray;
			if (parentRecordManager.IsSorted)
			{
				if (parentRecordManager.IsInReset)
				{
					if (this._recordsInsertedAtTop != null && parentRecordManager.IsInVerifySort)
					{
						this._recordsInsertedAtTop.Clear();
					}
					return unsortedIndex;
				}
				global::Infragistics.Windows.DataPresenter.Record record = null;
				if (unsortedIndex < sparseArray.Count)
				{
					record = sparseArray.GetItem(unsortedIndex, false);
				}
				if (record != null)
				{
					int num = parentRecordManager.Sorted.SparseArray.IndexOf(record);
					if (num >= 0)
					{
						return num;
					}
				}
			}
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			if (this._fixedNonSpecialRecordsOnTop != null)
			{
				num2 = this._fixedNonSpecialRecordsOnTop.Count;
				int listIndexFromUnsortedIndex = this.GetListIndexFromUnsortedIndex(this._fixedNonSpecialRecordsOnTop, unsortedIndex, sparseArray, ref num3);
				if (listIndexFromUnsortedIndex >= 0)
				{
					return listIndexFromUnsortedIndex;
				}
			}
			if (this._fixedNonSpecialRecordsOnBottom != null)
			{
				num4 = this._fixedNonSpecialRecordsOnBottom.Count;
				int listIndexFromUnsortedIndex2 = this.GetListIndexFromUnsortedIndex(this._fixedNonSpecialRecordsOnBottom, unsortedIndex, sparseArray, ref num5);
				if (listIndexFromUnsortedIndex2 >= 0)
				{
					return sparseArray.Count + listIndexFromUnsortedIndex2 - num4;
				}
			}
			if (this._recordsInsertedAtTop != null)
			{
				int count = this._recordsInsertedAtTop.Count;
				int listIndexFromUnsortedIndex3 = this.GetListIndexFromUnsortedIndex(this._recordsInsertedAtTop, unsortedIndex, sparseArray, ref num6);
				if (listIndexFromUnsortedIndex3 >= 0)
				{
					return listIndexFromUnsortedIndex3 + num2;
				}
			}
			return unsortedIndex + num3 + num6 - (num4 - num5);
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x000C35A8 File Offset: 0x000C17A8
		internal int GetUnsortedIndexFromSortedIndex(int sortedIndex)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this._recordCollection.ParentRecordManager;
			if (parentRecordManager == null)
			{
				return sortedIndex;
			}
			global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray = ((global::Infragistics.Windows.DataPresenter.DataRecordCollection)parentRecordManager.Unsorted).SparseArray;
			global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray2 = parentRecordManager.Sorted.SparseArray;
			if (parentRecordManager.IsSorted)
			{
				if (parentRecordManager.IsInReset)
				{
					if (this._recordsInsertedAtTop != null && parentRecordManager.IsInVerifySort)
					{
						this._recordsInsertedAtTop.Clear();
					}
					return sortedIndex;
				}
				global::Infragistics.Windows.DataPresenter.Record item = sparseArray2.GetItem(sortedIndex, false);
				if (item != null)
				{
					return sparseArray.IndexOf(item);
				}
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> fixedNonSpecialRecordsOnTop = this._fixedNonSpecialRecordsOnTop;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> recordsInsertedAtTop = this._recordsInsertedAtTop;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> fixedNonSpecialRecordsOnBottom = this._fixedNonSpecialRecordsOnBottom;
			int num = ((fixedNonSpecialRecordsOnTop != null) ? fixedNonSpecialRecordsOnTop.Count : 0) + ((recordsInsertedAtTop != null) ? recordsInsertedAtTop.Count : 0);
			int num2 = (fixedNonSpecialRecordsOnBottom != null) ? fixedNonSpecialRecordsOnBottom.Count : 0;
			if (num + num2 == 0)
			{
				return sortedIndex;
			}
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>(num + num2);
			global::Infragistics.Windows.DataPresenter.Record item2 = sparseArray2.GetItem(sortedIndex, false);
			foreach (object obj in new global::Infragistics.Windows.DataPresenter.GridUtilities.AggregateEnumerable<global::Infragistics.Windows.DataPresenter.Record>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>[]
			{
				fixedNonSpecialRecordsOnTop,
				new global::Infragistics.Collections.TypedEnumerable<global::Infragistics.Windows.DataPresenter.Record>(recordsInsertedAtTop),
				fixedNonSpecialRecordsOnBottom
			}))
			{
				global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)obj;
				int num3 = sparseArray.IndexOf(record);
				if (num3 >= 0)
				{
					list.Add(num3);
				}
				if (item2 == record)
				{
					return num3;
				}
			}
			list.Sort();
			int num4 = sortedIndex - num;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				if (list[i] <= num4)
				{
					num4++;
				}
				i++;
			}
			return num4;
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x000C375C File Offset: 0x000C195C
		internal global::Infragistics.Windows.DataPresenter.Record GetRecordInThisCollectionFromDescendant(global::Infragistics.Windows.DataPresenter.Record descendantRecord)
		{
			if (descendantRecord == null)
			{
				return null;
			}
			if (descendantRecord.ParentCollection == this._recordCollection)
			{
				if (this.Contains(descendantRecord))
				{
					return descendantRecord;
				}
				return null;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = descendantRecord.ParentRecord;
				if (parentRecord != null)
				{
					return this.GetRecordInThisCollectionFromDescendant(parentRecord);
				}
				return null;
			}
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x000C379C File Offset: 0x000C199C
		internal void InsertDataRecordInGroupBySlot(global::Infragistics.Windows.DataPresenter.DataRecord dr)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dr.FieldLayout;
			bool flag = this._recordCollection.ParentRecordManager.Groups == this.RecordCollection;
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = null;
			bool flag2 = false;
			int num = -1;
			bool flag3 = false;
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord2 = (this._recordCollection.Count > 0) ? (this._recordCollection[0] as global::Infragistics.Windows.DataPresenter.GroupByRecord) : null;
			if (flag && groupByRecord2 != null)
			{
				if (groupByRecord2.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout)
				{
					foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this._recordCollection))
					{
						global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord3 = (global::Infragistics.Windows.DataPresenter.GroupByRecord)record;
						if (groupByRecord3.FieldLayout == fieldLayout)
						{
							groupByRecord = groupByRecord3;
							break;
						}
					}
					if (groupByRecord == null)
					{
						groupByRecord = new global::Infragistics.Windows.DataPresenter.GroupByRecord(fieldLayout, this._recordCollection);
						flag2 = true;
						num = this.GetGroupByRecordInsertLocation(groupByRecord, false);
						if (num < 0)
						{
							num = 0;
						}
					}
				}
				else if (groupByRecord2.FieldLayout != fieldLayout)
				{
					global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord4 = new global::Infragistics.Windows.DataPresenter.GroupByRecord(groupByRecord2.FieldLayout, this._recordCollection);
					groupByRecord = new global::Infragistics.Windows.DataPresenter.GroupByRecord(fieldLayout, this._recordCollection);
					flag2 = true;
					if (fieldLayout.Index < groupByRecord4.Index)
					{
						num = 0;
					}
					else
					{
						num = 1;
					}
					bool bypassRecordCollectionNotifications = this._bypassRecordCollectionNotifications;
					this._bypassRecordCollectionNotifications = true;
					try
					{
						global::Infragistics.Windows.DataPresenter.RecordCollection childRecords = groupByRecord4.ChildRecords;
						global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>(this._recordCollection);
						this._recordCollection.SparseArray.Clear();
						foreach (global::Infragistics.Windows.DataPresenter.Record record2 in list)
						{
							global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord5 = (global::Infragistics.Windows.DataPresenter.GroupByRecord)record2;
							groupByRecord5.InitializeParentCollection(childRecords);
							childRecords.SparseArray.Add(groupByRecord5);
						}
						this._recordCollection.SparseArray.Add(groupByRecord4);
					}
					finally
					{
						this._bypassRecordCollectionNotifications = bypassRecordCollectionNotifications;
					}
					groupByRecord.ChildRecords.ViewableRecords.InsertDataRecordInGroupBySlot(dr);
					flag3 = true;
					this.RaiseChangeEvents(true);
					groupByRecord4.FireInitializeRecord();
				}
			}
			if (groupByRecord == null)
			{
				global::Infragistics.Windows.DataPresenter.Field field;
				if (groupByRecord2 != null)
				{
					field = groupByRecord2.GroupByField;
				}
				else
				{
					field = this._recordCollection.GroupByField;
					if (field == null && fieldLayout.SortedFields.Count > 0 && fieldLayout.SortedFields[0].IsGroupBy)
					{
						field = fieldLayout.SortedFields[0].Field;
					}
				}
				if (field != null)
				{
					global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord6 = new global::Infragistics.Windows.DataPresenter.GroupByRecord(field, this._recordCollection, dr.GetCellValue(field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType));
					global::Infragistics.Windows.DataPresenter.IGroupByEvaluator groupByEvaluatorResolved = field.GroupByEvaluatorResolved;
					if (groupByEvaluatorResolved != null)
					{
						groupByRecord6.InitializeCommonValue(groupByEvaluatorResolved.GetGroupByValue(groupByRecord6, dr));
					}
					num = this.GetGroupByRecordInsertLocation(groupByRecord6, true);
					if (num < 0)
					{
						num = 0;
					}
					if (num < this._recordCollection.Count)
					{
						groupByRecord = (this._recordCollection[num] as global::Infragistics.Windows.DataPresenter.GroupByRecord);
						if (groupByRecord == null || !groupByRecord.DoesRecordMatchGroup(dr))
						{
							groupByRecord = groupByRecord6;
							flag2 = true;
						}
					}
					else
					{
						groupByRecord = groupByRecord6;
						flag2 = true;
					}
					if (flag2 && field.GroupByComparerResolved != null)
					{
						global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord7 = this.FindMatchingGroupLinear(dr, groupByEvaluatorResolved);
						if (groupByRecord7 != null)
						{
							groupByRecord = groupByRecord7;
							flag2 = false;
						}
					}
				}
			}
			if (groupByRecord != null)
			{
				if (!flag3)
				{
					if (global::Infragistics.Windows.DataPresenter.RecordCollectionBase.HasAdditionalGroupByFields(groupByRecord.FieldLayout, groupByRecord.GroupByField))
					{
						groupByRecord.ChildRecords.ViewableRecords.InsertDataRecordInGroupBySlot(dr);
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.Record record3 = null;
						if (groupByRecord.ChildRecords.Count > 0)
						{
							record3 = groupByRecord.ChildRecords[0];
						}
						if (record3 == null || record3 is global::Infragistics.Windows.DataPresenter.DataRecord)
						{
							dr.InitializeParentCollection(groupByRecord.ChildRecords);
							groupByRecord.ChildRecords.AddRecord(dr);
							groupByRecord.OnGroupingChanged();
						}
						else if (record3 is global::Infragistics.Windows.DataPresenter.GroupByRecord)
						{
							groupByRecord.ChildRecords.ViewableRecords.InsertDataRecordInGroupBySlot(dr);
						}
					}
				}
				if (flag2)
				{
					if (num < 0)
					{
						num = 0;
					}
					groupByRecord.InitializeParentCollection(this._recordCollection);
					this._recordCollection.InsertRecord(num, groupByRecord);
					groupByRecord.FireInitializeRecord();
					global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord8 = groupByRecord.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
					if (groupByRecord8 != null)
					{
						groupByRecord8.OnGroupingChanged();
						return;
					}
				}
			}
			else
			{
				dr.InitializeParentCollection(this._recordCollection);
				this._recordCollection.AddRecord(dr);
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord9 = dr.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				if (groupByRecord9 != null)
				{
					groupByRecord9.OnGroupingChanged();
				}
			}
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x000C3BC4 File Offset: 0x000C1DC4
		internal void MoveRecord(global::Infragistics.Windows.DataPresenter.Record record, int newSortedIndex, int oldSortedIndex)
		{
			int collectionChanged_RaiseResetCounter = this._collectionChanged_RaiseResetCounter;
			global::Infragistics.Windows.DataPresenter.MainRecordSparseArray recordCollectionSparseArray = this.RecordCollectionSparseArray;
			bool hasAnyListeners = this.HasAnyListeners;
			bool flag = hasAnyListeners && (this._isResetNotificationNeeded || this.VerificationNeeded);
			int num = (hasAnyListeners && !flag) ? recordCollectionSparseArray.GetVisibleIndexOf(oldSortedIndex, false) : -1;
			int num2 = -1;
			this._bypassRecordCollectionNotifications = true;
			try
			{
				recordCollectionSparseArray.Move(oldSortedIndex, newSortedIndex);
				if (collectionChanged_RaiseResetCounter != this._collectionChanged_RaiseResetCounter || this._isResetNotificationNeeded)
				{
					flag = true;
				}
				if (!flag)
				{
					num2 = (hasAnyListeners ? recordCollectionSparseArray.GetVisibleIndexOf(newSortedIndex, false) : -1);
					if (record == null)
					{
						record = recordCollectionSparseArray.GetItem(newSortedIndex, true);
					}
				}
			}
			finally
			{
				this._bypassRecordCollectionNotifications = false;
			}
			if (this._inVerifySpecialRecords)
			{
				return;
			}
			if (num < 0 != num2 < 0)
			{
				this._isResetNotificationNeeded = true;
			}
			if (flag)
			{
				this.RaiseChangeEvents(true);
				return;
			}
			if (num >= 0 && num2 >= 0)
			{
				int countOfSpecialRecordsOnTop = this.CountOfSpecialRecordsOnTop;
				num2 += countOfSpecialRecordsOnTop;
				num += countOfSpecialRecordsOnTop;
				this.RaiseChangeEvents(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Move, record, num2, num));
			}
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x000C3CC8 File Offset: 0x000C1EC8
		internal void OnFixedStatusChanged(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this.RemoveFromFixedList(record);
			switch (record.FixedLocation)
			{
			case global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToTop:
				this.AddRecordToFixedList(true, record);
				goto IL_9D;
			case global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToBottom:
				this.AddRecordToFixedList(false, record);
				goto IL_9D;
			}
			if (this._fixedNonSpecialRecordsOnBottom != null && this._fixedNonSpecialRecordsOnBottom.Contains(record))
			{
				this._fixedNonSpecialRecordsOnBottom.Remove(record);
			}
			else if (this._fixedNonSpecialRecordsOnTop != null && this._fixedNonSpecialRecordsOnTop.Contains(record))
			{
				this._fixedNonSpecialRecordsOnTop.Remove(record);
			}
			if (this._pendingUnfixedNonSpecialRecords == null)
			{
				this._pendingUnfixedNonSpecialRecords = new global::System.Collections.Generic.Queue<global::Infragistics.Windows.DataPresenter.Record>();
			}
			this._pendingUnfixedNonSpecialRecords.Enqueue(record);
			IL_9D:
			this.BumpRecordNumberVersion();
			if (record.DataPresenter.IsInitializeRecordSuspendedFor(record))
			{
				this.DirtySpecialRecords(false);
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
			if (recordManager == null || recordManager.IsInReset)
			{
				this.DirtySpecialRecords(false);
				return;
			}
			int num = this.IndexOf(record);
			if (num < 0)
			{
				this.DirtySpecialRecords(false);
				return;
			}
			this.DirtyFixedRecordOrder();
			this.VerifyCachedRecordStatus(record);
			int num2 = this.IndexOf(record);
			if (num == num2 || !this.HasAnyListeners)
			{
				this.DirtySpecialRecords(true);
				return;
			}
			if (num2 >= 0)
			{
				if (num < 0)
				{
					this.RaiseChangeEvents(true);
				}
				else if (num2 != num)
				{
					this.RaiseCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Move, record, num2, num);
				}
			}
			else
			{
				this.RaiseChangeEvents(true);
			}
			this.DirtySpecialRecords(true);
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x000C3E14 File Offset: 0x000C2014
		internal void OnScrollCountDirtiedHelper()
		{
			if (this._recordCollection.IsUpdating)
			{
				this._recordCollection.BeginUpdateInfo._scrollCountDirtied = true;
				return;
			}
			global::Infragistics.Windows.DataPresenter.Record parentRecord = this._recordCollection.ParentRecord;
			global::Infragistics.Windows.DataPresenter.MainRecordSparseArray recordCollectionSparseArray = this.RecordCollectionSparseArray;
			if (recordCollectionSparseArray != null && recordCollectionSparseArray.InCalculatingScrollCount)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._recordCollection.DataPresenter;
				if (dataPresenter != null)
				{
					dataPresenter._cachedOverallScrollCountDirty = true;
				}
				return;
			}
			bool areAllAncestorRecordsExpanded = this.AreAllAncestorRecordsExpanded;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			if (this._recordCollection.ParentRecordManager.IsInBulkOperation)
			{
				flag3 = true;
				flag = true;
				flag2 = true;
				this._lastScrollCount = -1;
			}
			else if (areAllAncestorRecordsExpanded)
			{
				int scrollCount = this.ScrollCount;
				if (this._lastScrollCount != scrollCount)
				{
					this._lastScrollCount = scrollCount;
					flag3 = true;
					flag = true;
					flag2 = true;
				}
			}
			else
			{
				this._lastScrollCount = -1;
				flag3 = true;
				if (parentRecord != null && parentRecord.IsExpanded)
				{
					flag = true;
				}
				flag2 = true;
			}
			if (flag3)
			{
				this.RaisePropertyChangedEvent("ScrollCount");
			}
			if (!flag)
			{
				if (!flag2)
				{
					return;
				}
			}
			while (parentRecord != null)
			{
				if (flag)
				{
					parentRecord.DirtyScrollCount();
				}
				if (flag2)
				{
					parentRecord.InvalidateExpansionIndicatorVisibility();
					parentRecord.InvalidateHasChildren();
					global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = parentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
					if (groupByRecord != null)
					{
						groupByRecord.DirtyFilterState(areAllAncestorRecordsExpanded);
					}
				}
				if (parentRecord is global::Infragistics.Windows.DataPresenter.DataRecord)
				{
					return;
				}
				parentRecord = parentRecord.ParentRecord;
			}
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x000C3F46 File Offset: 0x000C2146
		internal void OnRecordCollectionFieldLayoutChanged()
		{
			this._specialRecordsVersionTracker = null;
			this.DirtySpecialRecords(false);
			this.VerifyHasAnyListeners();
			if (this.HasAnyListeners)
			{
				this.Verify();
			}
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x000C3F6A File Offset: 0x000C216A
		internal void OnRecordRefreshSortPosition(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this.EnsureCorrectSortPosition(record);
			if (record.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable)
			{
				if (record.IsOnTopWhenFixed)
				{
					this.RefreshSortOrderOfFixedRecordsHelper(this._fixedNonSpecialRecordsOnTop);
				}
				else
				{
					this.RefreshSortOrderOfFixedRecordsHelper(this._fixedNonSpecialRecordsOnBottom);
				}
			}
			this.BumpRecordNumberVersion();
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x000C3FA4 File Offset: 0x000C21A4
		internal void OnRecordVisibilityChanged(global::Infragistics.Windows.DataPresenter.Record record, global::System.Windows.Visibility oldValue, int oldIndex)
		{
			if (!this.ShouldRaiseCollectionNotifications)
			{
				return;
			}
			bool flag = oldValue == global::System.Windows.Visibility.Collapsed;
			bool flag2 = record.VisibilityResolved == global::System.Windows.Visibility.Collapsed;
			if (flag == flag2)
			{
				return;
			}
			int collectionChanged_RaiseResetCounter = this._collectionChanged_RaiseResetCounter;
			this.VerifyCachedRecordStatus(record);
			if (record.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable)
			{
				this.DirtySpecialRecords(false);
			}
			if (collectionChanged_RaiseResetCounter == this._collectionChanged_RaiseResetCounter)
			{
				if (flag2)
				{
					if (oldIndex >= 0)
					{
						this.RaiseChangeEvents(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, record, oldIndex));
						return;
					}
				}
				else
				{
					int indexOf = this.GetIndexOf(record, false);
					if (indexOf >= 0)
					{
						this.RaiseChangeEvents(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, record, indexOf));
					}
				}
			}
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x000C4025 File Offset: 0x000C2225
		internal void RefreshSortOrderOfFixedRecords()
		{
			this.RefreshSortOrderOfFixedRecordsHelper(this._fixedNonSpecialRecordsOnTop);
			this.RefreshSortOrderOfFixedRecordsHelper(this._fixedNonSpecialRecordsOnBottom);
			this.BumpRecordNumberVersion();
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x000C4048 File Offset: 0x000C2248
		private void RefreshSortOrderOfFixedRecordsHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list)
		{
			if (list == null || list.Count < 2)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
			if (recordManager != null)
			{
				list.Sort(new global::Infragistics.Windows.DataPresenter.RecordManager.RecordsSortComparer(!recordManager.IsSorted));
				this.DirtySpecialRecords(false);
			}
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x000C4088 File Offset: 0x000C2288
		internal bool RemoveRecord(global::Infragistics.Windows.DataPresenter.Record record, bool notifyListeners)
		{
			int num = -2;
			bool flag = false;
			if (notifyListeners)
			{
				if (this.VerificationNeeded)
				{
					flag = true;
				}
				else
				{
					num = this.IndexOf(record);
				}
			}
			bool flag2 = false;
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
			global::Infragistics.Windows.DataPresenter.MainRecordSparseArray recordCollectionSparseArray = this.RecordCollectionSparseArray;
			int num2 = recordCollectionSparseArray.IndexOf(record);
			bool flag3 = false;
			if (dataRecord != null && this._recordsInsertedAtTop != null)
			{
				flag3 = this._recordsInsertedAtTop.Remove(dataRecord);
			}
			int collectionChanged_RaiseResetCounter = this._collectionChanged_RaiseResetCounter;
			if (num2 >= 0)
			{
				if (notifyListeners)
				{
					try
					{
						this._bypassRecordCollectionNotifications = true;
						this.RecordCollection.RemoveAt(num2);
						flag2 = true;
						goto IL_8E;
					}
					finally
					{
						this._bypassRecordCollectionNotifications = false;
					}
				}
				recordCollectionSparseArray.RemoveAt(num2);
				flag2 = true;
				IL_8E:
				if (recordCollectionSparseArray.Count == 0 || record.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable)
				{
					flag3 = true;
				}
			}
			if (flag3)
			{
				this.DirtySpecialRecords(true);
			}
			if (flag)
			{
				this._isResetNotificationNeeded = true;
			}
			else if (num < 0)
			{
				notifyListeners = false;
			}
			if (notifyListeners && collectionChanged_RaiseResetCounter == this._collectionChanged_RaiseResetCounter)
			{
				if (this._isResetNotificationNeeded)
				{
					this.RaiseChangeEvents(true);
				}
				else if (flag2)
				{
					this.RaiseChangeEvents(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, record, num));
				}
			}
			if (flag2)
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this.RecordCollection.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				if (groupByRecord != null)
				{
					if (this.RecordCollection.SparseArray.Count == 0 && groupByRecord.ParentCollection != null)
					{
						groupByRecord.ParentCollection.ViewableRecords.RemoveRecord(groupByRecord, notifyListeners);
					}
					else
					{
						groupByRecord.OnGroupingChanged();
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x000C41E8 File Offset: 0x000C23E8
		internal bool RemoveRecordAtUnsortedIndex(int unsortedIndex, bool notifyListeners)
		{
			int sortedIndexFromUnsortedIndex = this.GetSortedIndexFromUnsortedIndex(unsortedIndex);
			if (sortedIndexFromUnsortedIndex < 0)
			{
				return false;
			}
			if (notifyListeners)
			{
				try
				{
					this._bypassRecordCollectionNotifications = true;
					this.RecordCollection.RemoveAt(sortedIndexFromUnsortedIndex);
				}
				finally
				{
					this._bypassRecordCollectionNotifications = false;
				}
				this.RaiseChangeEvents(true);
			}
			else
			{
				this.RecordCollectionSparseArray.RemoveAt(sortedIndexFromUnsortedIndex);
			}
			return true;
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x000C424C File Offset: 0x000C244C
		internal void RaiseChangeEvents(bool fullReset)
		{
			if (fullReset)
			{
				this.RaiseChangeEvents(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				return;
			}
			this.RaisePropertyChangedEvent("Count");
			this.RaisePropertyChangedEvent("Item[]");
			this.OnScrollCountDirtiedHelper();
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x000C427A File Offset: 0x000C247A
		internal void RaiseChangeEvents(global::System.Collections.Specialized.NotifyCollectionChangedAction action, global::Infragistics.Windows.DataPresenter.Record item, int newSortedIndex, int oldSortedIndex)
		{
			this.RaiseChangeEvents(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action, item, newSortedIndex, oldSortedIndex));
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x000C428C File Offset: 0x000C248C
		internal void RaiseChangeEvents(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			if (args.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				this._isResetNotificationNeeded = false;
			}
			this.RaisePropertyChangedEvent("Count");
			this.RaisePropertyChangedEvent("Item[]");
			this.RaiseCollectionChanged(args);
			this.OnScrollCountDirtiedHelper();
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x000C42C1 File Offset: 0x000C24C1
		private void RaiseCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction action, global::Infragistics.Windows.DataPresenter.Record item, int newSortedIndex, int oldSortedIndex)
		{
			this.RaiseCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action, item, newSortedIndex, oldSortedIndex));
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x000C42D4 File Offset: 0x000C24D4
		internal void RaiseCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			if (global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset == args.Action)
			{
				this._collectionChanged_RaiseResetCounter++;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
			if (recordManager != null && recordManager.IsUpdating)
			{
				recordManager.BeginUpdateInfo.EnqueNotification(this, args);
				return;
			}
			if (this._collectionChanged != null)
			{
				this._collectionChanged(this, args);
			}
			if (this._recordCollection != null)
			{
				this._recordCollection.BumpCollectionVersion();
			}
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x000C4340 File Offset: 0x000C2540
		internal new void RaisePropertyChangedEvent(string propName)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
			if (recordManager != null && recordManager.IsUpdating)
			{
				recordManager.BeginUpdateInfo.EnqueNotification(this, new global::System.ComponentModel.PropertyChangedEventArgs(propName));
				return;
			}
			base.RaisePropertyChangedEvent(propName);
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x000C437C File Offset: 0x000C257C
		internal void Verify()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this._recordCollection.ParentRecordManager;
			if (parentRecordManager != null && parentRecordManager.IsResetPending)
			{
				parentRecordManager.OnDelayedReset();
			}
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection expandableFieldRecordCollection = this._recordCollection as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection;
			if (expandableFieldRecordCollection != null)
			{
				expandableFieldRecordCollection.VerifyChildren();
			}
			this.EnsureFiltersEvaluated();
			this.VerifySpecialRecords();
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x000C43C8 File Offset: 0x000C25C8
		internal void VerifyFixedRecordLists()
		{
			this.VerifyFixedRecordList(true);
			this.VerifyFixedRecordList(false);
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x000C43D8 File Offset: 0x000C25D8
		private void AddFixedRecordsHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> source, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> dest)
		{
			if (source != null)
			{
				int i = 0;
				int count = source.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DataPresenter.Record record = source[i];
					global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal fixedRecordLocationOverride = record.FixedRecordLocationOverride;
					if (global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top == fixedRecordLocationOverride || global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Bottom == fixedRecordLocationOverride)
					{
						dest.Add(record);
					}
					i++;
				}
			}
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000C441C File Offset: 0x000C261C
		private void AddRecordToFixedList(bool onTop, global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list;
			if (onTop)
			{
				if (this._fixedNonSpecialRecordsOnTop == null)
				{
					this._fixedNonSpecialRecordsOnTop = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
				}
				list = this._fixedNonSpecialRecordsOnTop;
			}
			else
			{
				if (this._fixedNonSpecialRecordsOnBottom == null)
				{
					this._fixedNonSpecialRecordsOnBottom = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
				}
				list = this._fixedNonSpecialRecordsOnBottom;
			}
			if (onTop)
			{
				list.Add(record);
			}
			else
			{
				list.Insert(0, record);
			}
			int fixedRecordLimitResolved = record.FieldLayout.FixedRecordLimitResolved;
			if (fixedRecordLimitResolved < 1)
			{
				return;
			}
			if (fixedRecordLimitResolved >= list.Count)
			{
				return;
			}
			global::System.Collections.Generic.Queue<global::Infragistics.Windows.DataPresenter.Record> queue = new global::System.Collections.Generic.Queue<global::Infragistics.Windows.DataPresenter.Record>();
			int num = onTop ? 0 : (list.Count - 1);
			int num2 = onTop ? 1 : -1;
			for (int i = list.Count - fixedRecordLimitResolved; i > 0; i--)
			{
				queue.Enqueue(list[num]);
				num += num2;
			}
			while (queue.Count > 0)
			{
				queue.Dequeue().FixedLocation = global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable;
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002C87 RID: 11399 RVA: 0x000C44F0 File Offset: 0x000C26F0
		internal bool AreAllAncestorRecordsExpanded
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = this.RecordCollection.ParentRecord;
				return parentRecord == null || (parentRecord.IsExpanded && parentRecord.IsAncestorChainExpanded);
			}
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x000C4520 File Offset: 0x000C2720
		private void BumpRecordNumberVersion()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (this._recordCollection != null) ? this._recordCollection.FieldLayout : null;
			if (fieldLayout == null || fieldLayout.RecordSelectorNumberTypeResolved == global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.None)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._recordCollection.DataPresenter;
			if (dataPresenter != null)
			{
				dataPresenter.BumpRecordNumberVersionAsync();
			}
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x000C4568 File Offset: 0x000C2768
		private global::Infragistics.Windows.DataPresenter.GroupByRecord FindMatchingGroupLinear(global::Infragistics.Windows.DataPresenter.DataRecord dr, global::Infragistics.Windows.DataPresenter.IGroupByEvaluator evaluator)
		{
			int count = this._recordCollection.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this._recordCollection[i] as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				if (groupByRecord != null && evaluator.DoesGroupContainRecord(groupByRecord, dr))
				{
					return groupByRecord;
				}
			}
			return null;
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x000C45B0 File Offset: 0x000C27B0
		private void FixInterveningNonFixedRecords(bool top, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> specialRecords, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> fixedNonSpecialRecords)
		{
			int count = specialRecords.Count;
			int num = top ? 0 : (count - 1);
			int num2 = top ? (count - 1) : 0;
			int num3 = top ? 1 : -1;
			int num4;
			if (fixedNonSpecialRecords == null || fixedNonSpecialRecords.Count == 0)
			{
				num4 = -1;
				for (int i = num; i >= 0; i += num3)
				{
					if (i >= count)
					{
						break;
					}
					global::Infragistics.Windows.DataPresenter.Record record = specialRecords[i];
					if (record.IsFixed)
					{
						num4 = i;
					}
				}
			}
			else
			{
				num4 = num2;
			}
			if (num4 >= 0)
			{
				global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal fixedRecordLocationOverride = top ? global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top : global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Bottom;
				int num5 = num;
				while (num5 >= 0 && num5 < count)
				{
					global::Infragistics.Windows.DataPresenter.Record record2 = specialRecords[num5];
					record2.FixedRecordLocationOverride = fixedRecordLocationOverride;
					if (num5 == num4)
					{
						return;
					}
					num5 += num3;
				}
			}
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x000C465C File Offset: 0x000C285C
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> GetFixedRecordsList(global::Infragistics.Windows.DataPresenter.Record[] records, bool top)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = null;
			int num = records.Length;
			int num2 = top ? 0 : (num - 1);
			int num3 = top ? 1 : -1;
			int num4 = top ? num : -1;
			global::Infragistics.Windows.DataPresenter.FixedRecordLocation fixedRecordLocation = top ? global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToTop : global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToBottom;
			for (int num5 = num2; num5 != num4; num5 += num3)
			{
				global::Infragistics.Windows.DataPresenter.Record record = records[num5];
				if (record.FixedLocation != fixedRecordLocation)
				{
					break;
				}
				if (list == null)
				{
					list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
				}
				list.Add(record);
			}
			if (!top && list != null && list.Count > 1)
			{
				list.Reverse();
			}
			return list;
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x000C46DC File Offset: 0x000C28DC
		private int GetGroupByRecordInsertLocation(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, bool returnIndexOnMatch)
		{
			global::Infragistics.Windows.DataPresenter.Field groupByField = groupByRecord.GroupByField;
			bool flag = true;
			global::System.Collections.IComparer comparer = null;
			global::System.Collections.IComparer comparer2 = null;
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = null;
			object x = null;
			bool caseInSensitive = false;
			if (groupByField == null)
			{
				if (groupByRecord.RecordType != global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout)
				{
					return -1;
				}
			}
			else
			{
				if (groupByRecord.ParentCollection != this._recordCollection || this._recordCollection.GroupByField != groupByField)
				{
					return -1;
				}
				comparer = groupByField.GroupByComparerResolved;
				comparer2 = groupByField.SortComparerResolved;
				flag = (groupByField.SortStatusGroupBy == global::Infragistics.Windows.Controls.SortStatus.Ascending);
				caseInSensitive = (global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive == groupByField.SortComparisonTypeResolved);
				if (comparer2 != null)
				{
					dataRecord = groupByRecord.GetFirstDescendantDataRecord();
					if (dataRecord != null)
					{
						x = dataRecord.GetCellValue(groupByField, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
					}
				}
			}
			global::Infragistics.Collections.SparseArray sparseArray = this._recordCollection.SparseArray;
			global::Infragistics.Windows.DataPresenter.RecordCollection childRecords = groupByRecord.ChildRecords;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = groupByRecord.FieldLayout;
			int i = 0;
			int num = sparseArray.Count - 1;
			int num2 = sparseArray.IndexOf(groupByRecord);
			while (i <= num)
			{
				int num3 = (i + num) / 2;
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord2 = (global::Infragistics.Windows.DataPresenter.GroupByRecord)sparseArray[num3];
				if (groupByRecord2 == groupByRecord)
				{
					if (i == num)
					{
						break;
					}
					groupByRecord2 = (global::Infragistics.Windows.DataPresenter.GroupByRecord)sparseArray[++num3];
				}
				int num4;
				if (groupByField == null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = groupByRecord2.FieldLayout;
					if (fieldLayout == fieldLayout2)
					{
						break;
					}
					num4 = ((fieldLayout.Index < fieldLayout2.Index) ? -1 : 1);
				}
				else if (comparer != null)
				{
					num4 = comparer.Compare(groupByRecord, groupByRecord2);
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = null;
					if (comparer2 != null && dataRecord != null)
					{
						dataRecord2 = groupByRecord2.GetFirstDescendantDataRecord();
					}
					if (dataRecord2 != null)
					{
						num4 = comparer2.Compare(x, dataRecord2.GetCellValue(groupByField, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType));
					}
					else
					{
						num4 = global::Infragistics.Windows.DataPresenter.RecordManager.RecordsSortComparer.DefaultCompare(groupByRecord.Value, groupByRecord2.Value, true, caseInSensitive);
					}
				}
				if (!flag)
				{
					num4 = -num4;
				}
				if (num4 < 0)
				{
					num = num3 - 1;
				}
				else if (num4 > 0)
				{
					i = num3 + 1;
				}
				else
				{
					if (returnIndexOnMatch)
					{
						return num3;
					}
					if (num2 >= 0 && num2 < num3)
					{
						num = num3 - 1;
					}
					else
					{
						i = num3 + 1;
					}
				}
			}
			if (num2 < 0 || num2 >= i)
			{
				return i;
			}
			return i - 1;
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x000C48BC File Offset: 0x000C2ABC
		internal int GetIndexOf(global::Infragistics.Windows.DataPresenter.Record record, bool verify)
		{
			if (verify)
			{
				this.Verify();
			}
			int num = 0;
			if (this._specialRecordsOnTop != null)
			{
				num = this._specialRecordsOnTop.Count;
			}
			for (int i = 0; i < num; i++)
			{
				if (this._specialRecordsOnTop[i] == record)
				{
					return i;
				}
			}
			int num2 = 0;
			if (this._specialRecordsOnBottom != null)
			{
				num2 = this._specialRecordsOnBottom.Count;
			}
			for (int j = 0; j < num2; j++)
			{
				if (this._specialRecordsOnBottom[j] == record)
				{
					return this.RecordCollectionSparseArray.VisibleCount + num + j;
				}
			}
			int num3 = this.RecordCollectionSparseArray.VisibleIndexOf(record);
			if (num3 < 0)
			{
				return num3;
			}
			return num3 + num;
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x000C4960 File Offset: 0x000C2B60
		private int GetListIndexFromUnsortedIndex(global::System.Collections.IList list, int unsortedIndex, global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase unsortedArray, ref int rcdsWithHigherIndices)
		{
			int num = list.Count;
			int result = -1;
			for (int i = 0; i < num; i++)
			{
				global::Infragistics.Windows.DataPresenter.Record item = list[i] as global::Infragistics.Windows.DataPresenter.Record;
				int num2 = unsortedArray.IndexOf(item);
				if (num2 < 0)
				{
					list.RemoveAt(i);
					i--;
					num--;
				}
				else if (num2 == unsortedIndex)
				{
					result = i;
				}
				else if (num2 > unsortedIndex)
				{
					rcdsWithHigherIndices++;
				}
			}
			return result;
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x000C49C4 File Offset: 0x000C2BC4
		private bool HasRecordType(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> records, global::Infragistics.Windows.DataPresenter.RecordType recordType)
		{
			if (records != null && records.Count > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Record record in records)
				{
					if (record != null && record.RecordType == recordType)
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x000C4A2C File Offset: 0x000C2C2C
		private void OnFirstListenerAddingInternal()
		{
			this.Verify();
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection expandableFieldRecordCollection = this.RecordCollection as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection;
			if (expandableFieldRecordCollection != null)
			{
				expandableFieldRecordCollection.VerifyChildren();
			}
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x000C4A54 File Offset: 0x000C2C54
		private void OnRecordFilterCollectionVersionChanged()
		{
			this.EnsureFiltersEvaluated();
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x000C4A60 File Offset: 0x000C2C60
		private void RemoveFromFixedList(global::Infragistics.Windows.DataPresenter.Record record)
		{
			int num = (this._fixedNonSpecialRecordsOnTop == null) ? -1 : this._fixedNonSpecialRecordsOnTop.IndexOf(record);
			if (num >= 0)
			{
				this._fixedNonSpecialRecordsOnTop.RemoveAt(num);
				return;
			}
			if (this._fixedNonSpecialRecordsOnBottom != null)
			{
				num = this._fixedNonSpecialRecordsOnBottom.IndexOf(record);
				if (num >= 0)
				{
					this._fixedNonSpecialRecordsOnBottom.RemoveAt(num);
				}
			}
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x000C4ABC File Offset: 0x000C2CBC
		private void RemoveFromRcdsInsertedAtTop(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> rcdsToRemove)
		{
			if (this._recordsInsertedAtTop == null || this._recordsInsertedAtTop.Count == 0 || rcdsToRemove == null || rcdsToRemove.Count == 0)
			{
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.Record record in rcdsToRemove)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null)
				{
					this._recordsInsertedAtTop.Remove(dataRecord);
				}
			}
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x000C4B38 File Offset: 0x000C2D38
		private void VerifyCachedRecordStatus(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this.Verify();
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x000C4B40 File Offset: 0x000C2D40
		private void VerifyFixedRecordLimit(bool top)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = top ? this._fixedNonSpecialRecordsOnTop : this._fixedNonSpecialRecordsOnBottom;
			if (list == null || list.Count < 2)
			{
				return;
			}
			int i = list[0].FieldLayout.FixedRecordLimitResolved;
			if (i < 1 || i >= list.Count)
			{
				return;
			}
			global::System.Collections.Generic.Queue<global::Infragistics.Windows.DataPresenter.Record> queue = new global::System.Collections.Generic.Queue<global::Infragistics.Windows.DataPresenter.Record>();
			while (i < list.Count)
			{
				int index = top ? 0 : (list.Count - 1);
				global::Infragistics.Windows.DataPresenter.Record item = list[index];
				queue.Enqueue(item);
				list.RemoveAt(index);
			}
			while (queue != null && queue.Count > 0)
			{
				queue.Dequeue().FixedLocation = global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable;
			}
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x000C4BE0 File Offset: 0x000C2DE0
		private void VerifyFixedRecordList(bool top)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = top ? this._fixedNonSpecialRecordsOnTop : this._fixedNonSpecialRecordsOnBottom;
			int count = this._recordCollection.Count;
			int num = top ? 0 : (count - 1);
			int num2 = top ? 1 : -1;
			int num3 = num;
			while (num3 >= 0 && num3 < count)
			{
				global::Infragistics.Windows.DataPresenter.Record item = this._recordCollection.SparseArray.GetItem(num3, false);
				if (item == null || item.FixedLocation == global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable || item.IsOnTopWhenFixed != top)
				{
					break;
				}
				if (list == null)
				{
					if (top)
					{
						list = (this._fixedNonSpecialRecordsOnTop = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>());
					}
					else
					{
						list = (this._fixedNonSpecialRecordsOnBottom = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>());
					}
				}
				if (!list.Contains(item))
				{
					if (top)
					{
						list.Add(item);
					}
					else
					{
						list.Insert(0, item);
					}
				}
				num3 += num2;
			}
			this.VerifyFixedRecordLimit(top);
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x000C4CB4 File Offset: 0x000C2EB4
		private void VerifyHasAnyListeners()
		{
			if (this.HasAnyListeners)
			{
				if (this._specialRecordsVersionTracker == null && this.FieldLayout != null)
				{
					this._specialRecordsVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this.FieldLayout, global::Infragistics.Windows.DataPresenter.FieldLayout.SpecialRecordsVersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.VerifySpecialRecords), true);
				}
				if (this._filtersVersionTracker == null)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
					global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection resolvedRecordFilterCollection = (recordManager != null) ? recordManager.RecordFiltersResolved : null;
					if (resolvedRecordFilterCollection != null)
					{
						this._filtersVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(resolvedRecordFilterCollection, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.VersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnRecordFilterCollectionVersionChanged), true);
						this._filtersVersionTracker.AsynchronousDispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Background;
					}
				}
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection expandableFieldRecordCollection = this.RecordCollection as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection;
				if (expandableFieldRecordCollection != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = expandableFieldRecordCollection.FieldLayout;
					if (this._fieldsVersionTracker == null && fieldLayout != null)
					{
						this._fieldsVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(fieldLayout.Fields, "Version", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(expandableFieldRecordCollection.VerifyChildren));
						return;
					}
				}
			}
			else
			{
				this._specialRecordsVersionTracker = null;
				this._filtersVersionTracker = null;
				this._fieldsVersionTracker = null;
			}
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x000C4DA4 File Offset: 0x000C2FA4
		private void VerifySpecialRecords()
		{
			if (!this.IsSpecialRecordsDirty)
			{
				return;
			}
			if (this._inVerifySpecialRecords)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
			if (recordManager == null || recordManager.IsInReset)
			{
				return;
			}
			bool flag = global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.FixedRecordOrderIsDirty == this._verifiedSpecialRecordsVersion;
			bool flag2 = false;
			this._inVerifySpecialRecords = true;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
			if (fieldLayout != null)
			{
				this._verifiedSpecialRecordsVersion = fieldLayout.SpecialRecordsVersion;
			}
			try
			{
				if (flag)
				{
					this._fixedNonSpecialRecordsOnTop = null;
					this._fixedNonSpecialRecordsOnBottom = null;
					if (this._recordCollection.Count > 0)
					{
						global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray = this._recordCollection.SparseArray;
						global::Infragistics.Windows.DataPresenter.Record[] array = sparseArray.ToArray(true);
						if (global::Infragistics.Windows.DataPresenter.GridUtilities.MoveFixedRecords(array))
						{
							flag2 = true;
							this._recordCollection.BeginUpdate();
							sparseArray.Clear();
							sparseArray.AddRange(array);
							this._fixedNonSpecialRecordsOnTop = this.GetFixedRecordsList(array, true);
							this._fixedNonSpecialRecordsOnBottom = this.GetFixedRecordsList(array, false);
							this.VerifyFixedRecordLimit(true);
							this.VerifyFixedRecordLimit(false);
						}
					}
					this.RemoveFromRcdsInsertedAtTop(this._fixedNonSpecialRecordsOnTop);
					this.RemoveFromRcdsInsertedAtTop(this._fixedNonSpecialRecordsOnBottom);
				}
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> specialRecordsOnTop = this._specialRecordsOnTop;
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> specialRecordsOnBottom = this._specialRecordsOnBottom;
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> fixedRecordsOnTop = this._fixedRecordsOnTop;
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> fixedRecordsOnBottom = this._fixedRecordsOnBottom;
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.CachedInfo.ResetCachedSettings(specialRecordsOnTop);
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.CachedInfo.ResetCachedSettings(specialRecordsOnBottom);
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.CachedInfo.ResetCachedSettings(fixedRecordsOnTop);
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.CachedInfo.ResetCachedSettings(fixedRecordsOnBottom);
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.CachedInfo.ResetCachedSettings(this._fixedNonSpecialRecordsOnTop);
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.CachedInfo.ResetCachedSettings(this._fixedNonSpecialRecordsOnBottom);
				global::Infragistics.Windows.DataPresenter.Record[] recordsToRecycle = global::Infragistics.Windows.DataPresenter.GridUtilities.Aggregate<global::Infragistics.Windows.DataPresenter.Record>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>[]
				{
					this._specialRecordsOnTop,
					this._specialRecordsOnBottom
				});
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.CachedInfo cachedInfo = new global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.CachedInfo(this, recordsToRecycle);
				this._specialRecordsOnTop = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
				this._specialRecordsOnBottom = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
				this._fixedRecordsOnTop = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
				this._fixedRecordsOnBottom = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
				bool flag3 = false;
				if (!cachedInfo.ProcessPendingUnfixNonSpecialRecords(this._pendingUnfixedNonSpecialRecords))
				{
					flag3 = true;
				}
				this._pendingUnfixedNonSpecialRecords = null;
				if (!cachedInfo.VerifyFixedNonSpecialRecords(this._fixedNonSpecialRecordsOnTop, true))
				{
					flag3 = true;
				}
				if (!cachedInfo.VerifyFixedNonSpecialRecords(this._fixedNonSpecialRecordsOnBottom, false))
				{
					flag3 = true;
				}
				cachedInfo.GetSpecialRecordsHelper(this._specialRecordsOnTop, true);
				cachedInfo.GetSpecialRecordsHelper(this._specialRecordsOnBottom, false);
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
				cachedInfo.GetFixedNonSpecialRecords(list, true);
				cachedInfo.GetFixedNonSpecialRecords(list2, false);
				this.FixInterveningNonFixedRecords(true, this._specialRecordsOnTop, list);
				this.FixInterveningNonFixedRecords(false, this._specialRecordsOnBottom, list2);
				this.AddFixedRecordsHelper(this._specialRecordsOnTop, this._fixedRecordsOnTop);
				if (cachedInfo._isRecordFixingAllowed)
				{
					this.AddFixedRecordsHelper(list, this._fixedRecordsOnTop);
					this.AddFixedRecordsHelper(list2, this._fixedRecordsOnBottom);
				}
				this.AddFixedRecordsHelper(this._specialRecordsOnBottom, this._fixedRecordsOnBottom);
				if (cachedInfo._addHeaderRecord && this._specialRecordsOnTop.Count + this._specialRecordsOnBottom.Count == 0)
				{
					global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = (global::Infragistics.Windows.DataPresenter.HeaderRecord)cachedInfo.ExtractRecord(cachedInfo._recordsToRecycle, typeof(global::Infragistics.Windows.DataPresenter.HeaderRecord));
					if (headerRecord == null)
					{
						headerRecord = new global::Infragistics.Windows.DataPresenter.HeaderRecord(cachedInfo._fieldLayout, cachedInfo._recordColl)
						{
							_vrcPlaceholderRecord = new global::Infragistics.Windows.DataPresenter.TemplateDataRecord(cachedInfo._fieldLayout, cachedInfo._recordColl)
						};
						headerRecord.AttachedToRecord = headerRecord._vrcPlaceholderRecord;
					}
					this._specialRecordsOnTop.Add(headerRecord);
				}
				if (!flag2)
				{
					if (!flag3)
					{
						flag3 = (!global::Infragistics.Windows.DataPresenter.GridUtilities.CompareLists(specialRecordsOnTop, this._specialRecordsOnTop) || !global::Infragistics.Windows.DataPresenter.GridUtilities.CompareLists(specialRecordsOnBottom, this._specialRecordsOnBottom));
					}
					if (!flag3)
					{
						flag3 = (!global::Infragistics.Windows.DataPresenter.GridUtilities.CompareLists(fixedRecordsOnTop, this._fixedRecordsOnTop) || !global::Infragistics.Windows.DataPresenter.GridUtilities.CompareLists(fixedRecordsOnBottom, this._fixedRecordsOnBottom));
					}
					if (flag3)
					{
						this.RaiseChangeEvents(true);
					}
				}
			}
			finally
			{
				if (flag2)
				{
					this.RaiseChangeEvents(true);
					this._recordCollection.EndUpdate(false);
				}
				this._inVerifySpecialRecords = false;
			}
		}

		// Token: 0x1400007F RID: 127
		// (add) Token: 0x06002C99 RID: 11417 RVA: 0x000C516C File Offset: 0x000C336C
		// (remove) Token: 0x06002C9A RID: 11418 RVA: 0x000C51A4 File Offset: 0x000C33A4
		private event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;

		// Token: 0x14000080 RID: 128
		// (add) Token: 0x06002C9B RID: 11419 RVA: 0x000C51D9 File Offset: 0x000C33D9
		// (remove) Token: 0x06002C9C RID: 11420 RVA: 0x000C5206 File Offset: 0x000C3406
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged
		{
			add
			{
				if (!this.HasAnyListeners)
				{
					this.OnFirstListenerAddingInternal();
				}
				this._collectionChanged = (global::System.Delegate.Combine(this._collectionChanged, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
				this.VerifyHasAnyListeners();
			}
			remove
			{
				this._collectionChanged = (global::System.Delegate.Remove(this._collectionChanged, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
				this.VerifyHasAnyListeners();
			}
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x000C5225 File Offset: 0x000C3425
		int global::System.Collections.IList.Add(object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x000C5236 File Offset: 0x000C3436
		void global::System.Collections.IList.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000C5247 File Offset: 0x000C3447
		bool global::System.Collections.IList.Contains(object value)
		{
			return ((global::System.Collections.IList)this).IndexOf(value) >= 0;
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000C5256 File Offset: 0x000C3456
		int global::System.Collections.IList.IndexOf(object value)
		{
			if (value is global::Infragistics.Windows.DataPresenter.Record)
			{
				return this.GetIndexOf(value as global::Infragistics.Windows.DataPresenter.Record, true);
			}
			return -1;
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x000C526F File Offset: 0x000C346F
		void global::System.Collections.IList.Insert(int index, object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x000C5280 File Offset: 0x000C3480
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002CA3 RID: 11427 RVA: 0x000C5283 File Offset: 0x000C3483
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x000C5286 File Offset: 0x000C3486
		void global::System.Collections.IList.Remove(object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x000C5297 File Offset: 0x000C3497
		void global::System.Collections.IList.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000D99 RID: 3481
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				this.Verify();
				return this.GetItem(index);
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
			}
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x000C52C8 File Offset: 0x000C34C8
		public void CopyTo(global::System.Array array, int arrayIndex)
		{
			int count = this.Count;
			for (int i = 0; i < count; i++)
			{
				array.SetValue(this.GetItem(i), arrayIndex + i);
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x000C52F8 File Offset: 0x000C34F8
		public int Count
		{
			get
			{
				this.Verify();
				return this.CountNoVerify;
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x000C5314 File Offset: 0x000C3514
		private int CountNoVerify
		{
			get
			{
				int num = this.RecordCollectionSparseArray.VisibleCount;
				if (this._specialRecordsOnTop != null)
				{
					num += this._specialRecordsOnTop.Count;
				}
				if (this._specialRecordsOnBottom != null)
				{
					num += this._specialRecordsOnBottom.Count;
				}
				return num;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x000C535A File Offset: 0x000C355A
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return ((global::System.Collections.ICollection)this._recordCollection).IsSynchronized;
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x000C5367 File Offset: 0x000C3567
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return ((global::System.Collections.ICollection)this._recordCollection).SyncRoot;
			}
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x000C5374 File Offset: 0x000C3574
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			this.Verify();
			return new global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.VisualRecordEnumerator(this);
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x000C5382 File Offset: 0x000C3582
		public int IndexOf(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return ((global::System.Collections.IList)this).IndexOf(record);
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x000C538B File Offset: 0x000C358B
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.Insert(int index, global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x000C539C File Offset: 0x000C359C
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000D9E RID: 3486
		public global::Infragistics.Windows.DataPresenter.Record this[int index]
		{
			get
			{
				return ((global::System.Collections.IList)this)[index] as global::Infragistics.Windows.DataPresenter.Record;
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
			}
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x000C53CC File Offset: 0x000C35CC
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Add(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x000C53DD File Offset: 0x000C35DD
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x000C53EE File Offset: 0x000C35EE
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x000C53F1 File Offset: 0x000C35F1
		public bool Contains(global::Infragistics.Windows.DataPresenter.Record item)
		{
			return ((global::System.Collections.IList)this).Contains(item);
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x000C53FA File Offset: 0x000C35FA
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Record[] array, int arrayIndex)
		{
			this.CopyTo(array, arrayIndex);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x000C5404 File Offset: 0x000C3604
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Remove(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x000C5415 File Offset: 0x000C3615
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>.GetEnumerator()
		{
			this.Verify();
			return new global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.VisualRecordEnumerator(this);
		}

		// Token: 0x04001522 RID: 5410
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _recordCollection;

		// Token: 0x04001523 RID: 5411
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> _recordsInsertedAtTop;

		// Token: 0x04001524 RID: 5412
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _fixedRecordsOnTop;

		// Token: 0x04001525 RID: 5413
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _fixedRecordsOnBottom;

		// Token: 0x04001526 RID: 5414
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _specialRecordsOnTop;

		// Token: 0x04001527 RID: 5415
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _specialRecordsOnBottom;

		// Token: 0x04001528 RID: 5416
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _fixedNonSpecialRecordsOnTop;

		// Token: 0x04001529 RID: 5417
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _fixedNonSpecialRecordsOnBottom;

		// Token: 0x0400152A RID: 5418
		private global::System.Collections.Generic.Queue<global::Infragistics.Windows.DataPresenter.Record> _pendingUnfixedNonSpecialRecords;

		// Token: 0x0400152B RID: 5419
		private int _lastScrollCount = -1;

		// Token: 0x0400152C RID: 5420
		private global::Infragistics.Windows.DataPresenter.DataRecord _lastAddRecord;

		// Token: 0x0400152D RID: 5421
		private global::System.WeakReference _lastRecordList;

		// Token: 0x0400152E RID: 5422
		private bool _isResetNotificationNeeded;

		// Token: 0x0400152F RID: 5423
		private bool _bypassRecordCollectionNotifications;

		// Token: 0x04001530 RID: 5424
		private bool _inVerifySpecialRecords;

		// Token: 0x04001531 RID: 5425
		private int _verifiedSpecialRecordsVersion;

		// Token: 0x04001532 RID: 5426
		private global::Infragistics.Windows.Internal.PropertyValueTracker _specialRecordsVersionTracker;

		// Token: 0x04001533 RID: 5427
		private static readonly int FixedRecordOrderIsDirty = -5;

		// Token: 0x04001534 RID: 5428
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext, global::Infragistics.Windows.DataPresenter.SummaryRecord> _associatedRecordMap;

		// Token: 0x04001535 RID: 5429
		private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _associatedViewableRecordCollection;

		// Token: 0x04001536 RID: 5430
		private int _reportVersion;

		// Token: 0x04001537 RID: 5431
		private bool _inEnsureFiltersEvaluated;

		// Token: 0x04001538 RID: 5432
		internal int _verifiedFiltersVersion;

		// Token: 0x04001539 RID: 5433
		private global::Infragistics.Windows.Internal.PropertyValueTracker _filtersVersionTracker;

		// Token: 0x0400153A RID: 5434
		private int _collectionChanged_RaiseResetCounter;

		// Token: 0x0400153B RID: 5435
		private global::Infragistics.Windows.Internal.PropertyValueTracker _fieldsVersionTracker;

		// Token: 0x0200039F RID: 927
		private class CachedInfo
		{
			// Token: 0x06002CBB RID: 11451 RVA: 0x000C542C File Offset: 0x000C362C
			internal CachedInfo(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc, global::Infragistics.Windows.DataPresenter.Record[] recordsToRecycle)
			{
				this._vrc = vrc;
				this._recordColl = vrc.RecordCollection;
				this._recordManager = vrc.RecordManager;
				this._isTopLevel = this._recordColl.IsTopLevel;
				this._isRootLevel = this._recordColl.IsRootLevel;
				this._recordsType = this._recordColl.RecordsType;
				this._isDataRecords = (global::Infragistics.Windows.DataPresenter.RecordType.DataRecord == this._recordsType);
				this._isGroupByRecords = (global::Infragistics.Windows.DataPresenter.RecordType.GroupByField == this._recordsType);
				this._recordsToRecycle = recordsToRecycle;
				this._fieldLayout = (vrc.FieldLayout ?? this._recordManager.FieldLayout);
				this._dataPresenter = this._recordManager.DataPresenter;
				this._view = this._dataPresenter.CurrentViewInternal;
				this._isRecordFixingAllowed = (this._view.IsFixedRecordsSupported && (this._view.IsFixingSupportedForNestedRecords || this._recordColl.ParentRecord == null));
				this.InitShouldAddSpecialRecords();
				this._sparseArray = vrc.RecordCollectionSparseArray;
			}

			// Token: 0x06002CBC RID: 11452 RVA: 0x000C553C File Offset: 0x000C373C
			private void AssignSeparatorVisibility(global::Infragistics.Windows.DataPresenter.Record record, bool isTopSpecialRecord)
			{
				global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation recordSeparatorLocation = (this._fieldLayout != null) ? this._fieldLayout.RecordSeparatorLocationResolved : global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation.None;
				global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility separatorVisibility = global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.None;
				if (record is global::Infragistics.Windows.DataPresenter.SummaryRecord)
				{
					if ((global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation.SummaryRecord & recordSeparatorLocation) != global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation.None)
					{
						separatorVisibility = (isTopSpecialRecord ? global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.After : global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.Before);
					}
				}
				else if (record is global::Infragistics.Windows.DataPresenter.FilterRecord)
				{
					if ((global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation.FilterRecord & recordSeparatorLocation) != global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation.None)
					{
						separatorVisibility = (isTopSpecialRecord ? global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.After : global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.Before);
					}
				}
				else if (typeof(global::Infragistics.Windows.DataPresenter.DataRecord) == record.GetType() && (global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation.TemplateAddRecord & recordSeparatorLocation) != global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation.None)
				{
					separatorVisibility = (isTopSpecialRecord ? global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.After : global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.Before);
				}
				record.SeparatorVisibility = separatorVisibility;
			}

			// Token: 0x06002CBD RID: 11453 RVA: 0x000C55BC File Offset: 0x000C37BC
			internal global::Infragistics.Windows.DataPresenter.Record ExtractRecord(global::Infragistics.Windows.DataPresenter.Record[] arr, global::System.Type recordType)
			{
				if (arr != null)
				{
					for (int i = 0; i < arr.Length; i++)
					{
						global::Infragistics.Windows.DataPresenter.Record record = arr[i];
						if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsObjectOfType(record, recordType) && this._fieldLayout == record.FieldLayout)
						{
							arr[i] = null;
							return record;
						}
					}
				}
				return null;
			}

			// Token: 0x06002CBE RID: 11454 RVA: 0x000C55FC File Offset: 0x000C37FC
			private global::Infragistics.Windows.DataPresenter.DataRecord GetAddRecordIfVisible(bool top)
			{
				if (this._isTopLevel && this._isDataRecords)
				{
					global::Infragistics.Windows.DataPresenter.AddNewRecordLocation addNewRecordLocation = this._recordManager.AddNewRecordLocation;
					bool flag = top ? (global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnTop == addNewRecordLocation || global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnTopFixed == addNewRecordLocation) : (global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnBottom == addNewRecordLocation || global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnBottomFixed == addNewRecordLocation);
					if (flag)
					{
						global::Infragistics.Windows.DataPresenter.DataRecord currentAddRecord = this._recordManager.CurrentAddRecord;
						if (currentAddRecord != null)
						{
							currentAddRecord.FixedRecordLocationOverride = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFixedRecordLocation(top, global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnTopFixed == addNewRecordLocation || (global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnBottomFixed == addNewRecordLocation && this._isRootLevel));
							return currentAddRecord;
						}
					}
				}
				return null;
			}

			// Token: 0x06002CBF RID: 11455 RVA: 0x000C5678 File Offset: 0x000C3878
			internal void GetFixedNonSpecialRecords(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list, bool top)
			{
				int count = this._recordColl.Count;
				int num = top ? 0 : (count - 1);
				int num2 = top ? 1 : -1;
				bool flag = this._dataPresenter.IsNestedDataDisplayEnabled && this._view.SupportedDataDisplayMode != global::Infragistics.Windows.DataPresenter.DataDisplayMode.Flat;
				global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal fixedRecordLocationInternal = top ? global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top : (this._isRootLevel ? global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Bottom : global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.None);
				if (!this._isRecordFixingAllowed)
				{
					fixedRecordLocationInternal = global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.None;
				}
				bool flag2 = this._recordColl.FieldLayout.ChildRecordsDisplayOrderResolved == global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.AfterParent;
				global::Infragistics.Windows.DataPresenter.Record record = null;
				int num3 = num;
				while (num3 >= 0 && num3 < count)
				{
					global::Infragistics.Windows.DataPresenter.Record item = this._recordColl.SparseArray.GetItem(num3, false);
					if (item == null || !item.IsFixed || top != item.IsOnTopWhenFixed)
					{
						break;
					}
					item.SeparatorVisibility = global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.None;
					global::System.Windows.Visibility visibilityResolved = item.VisibilityResolved;
					if (global::System.Windows.Visibility.Collapsed != visibilityResolved && this._recordManager.CurrentAddRecordInternal != item)
					{
						bool flag3 = item.IsExpanded && item.HasVisibleChildren;
						if (flag && flag3 && fixedRecordLocationInternal != global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.None && (!top || !flag2))
						{
							fixedRecordLocationInternal = global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.None;
						}
						if (fixedRecordLocationInternal != global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.None)
						{
							list.Add(item);
							record = item;
						}
						item.FixedRecordLocationOverride = fixedRecordLocationInternal;
						if (flag && flag3 && fixedRecordLocationInternal != global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.None && ((top && flag2) || (!top && !flag2)))
						{
							fixedRecordLocationInternal = global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.None;
						}
					}
					num3 += num2;
				}
				if (record != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation recordSeparatorLocation = (this._fieldLayout != null) ? this._fieldLayout.RecordSeparatorLocationResolved : global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation.None;
					if ((global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation.FixedRecords & recordSeparatorLocation) != global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation.None)
					{
						record.SeparatorVisibility = (top ? global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.After : global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.Before);
					}
				}
			}

			// Token: 0x06002CC0 RID: 11456 RVA: 0x000C5804 File Offset: 0x000C3A04
			private global::System.Type[] GetOrderedSpecialRecordTypes(bool top)
			{
				long num = -1L;
				long num2 = -1L;
				long num3 = -1L;
				for (int i = 0; i <= 1; i++)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings;
					if (i == 0)
					{
						fieldLayoutSettings = ((this._fieldLayout != null) ? this._fieldLayout.SettingsIfAllocated : null);
					}
					else
					{
						fieldLayoutSettings = ((this._dataPresenter != null) ? this._dataPresenter.FieldLayoutSettingsIfAllocated : null);
					}
					if (fieldLayoutSettings != null)
					{
						global::Infragistics.Windows.DataPresenter.SpecialRecordOrder specialRecordOrder = fieldLayoutSettings.SpecialRecordOrder;
						if (specialRecordOrder != null)
						{
							if (num < 0L)
							{
								num = (long)specialRecordOrder.SummaryRecord;
							}
							if (num2 < 0L)
							{
								num2 = (long)specialRecordOrder.AddRecord;
							}
							if (num3 < 0L)
							{
								num3 = (long)specialRecordOrder.FilterRecord;
							}
						}
					}
				}
				num = 256L * num + (top ? -20L : 20L);
				num3 = 256L * num3 + (top ? -15L : 15L);
				num2 = 256L * num2 + (top ? -10L : 10L);
				global::System.Type[] array = new global::System.Type[]
				{
					typeof(global::Infragistics.Windows.DataPresenter.DataRecord),
					typeof(global::Infragistics.Windows.DataPresenter.FilterRecord),
					typeof(global::Infragistics.Windows.DataPresenter.SummaryRecord)
				};
				long[] array2 = new long[]
				{
					num2,
					num3,
					num
				};
				for (int j = 0; j < array2.Length; j++)
				{
					for (int k = 1 + j; k < array2.Length; k++)
					{
						if (array2[j] > array2[k])
						{
							global::Infragistics.Windows.DataPresenter.GridUtilities.Swap(array2, j, k);
							global::Infragistics.Windows.DataPresenter.GridUtilities.Swap(array, j, k);
						}
					}
				}
				return array;
			}

			// Token: 0x06002CC1 RID: 11457 RVA: 0x000C5970 File Offset: 0x000C3B70
			internal void GetSpecialRecordsHelper(global::System.Type recordType, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list, bool top)
			{
				if (typeof(global::Infragistics.Windows.DataPresenter.DataRecord) == recordType)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord addRecordIfVisible = this.GetAddRecordIfVisible(top);
					if (addRecordIfVisible != null)
					{
						list.Add(addRecordIfVisible);
					}
					return;
				}
				if (typeof(global::Infragistics.Windows.DataPresenter.SummaryRecord) == recordType)
				{
					if ((this._isDataRecords || this._isGroupByRecords) && this._view != null && this._view.IsSummaryRecordSupported && this._shouldAddSpecialRecords && this._recordManager.DataSource != null)
					{
						global::Infragistics.Windows.DataPresenter.SummaryResultCollection summaryResults = this._recordColl.SummaryResults;
						if (summaryResults != null)
						{
							global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = summaryResults.GetSummaryRecord(top, top, this._recordsToRecycle, this._isRootLevel);
							if (summaryRecord != null)
							{
								list.Add(summaryRecord);
							}
							summaryRecord = summaryResults.GetSummaryRecord(top, !top, this._recordsToRecycle, this._isRootLevel);
							if (summaryRecord != null)
							{
								list.Add(summaryRecord);
							}
						}
					}
					return;
				}
				if (typeof(global::Infragistics.Windows.DataPresenter.FilterRecord) == recordType)
				{
					global::Infragistics.Windows.DataPresenter.FilterRecordLocation filterRecordLocationResolved = this._fieldLayout.FilterRecordLocationResolved;
					bool flag = top ? (global::Infragistics.Windows.DataPresenter.FilterRecordLocation.OnTop == filterRecordLocationResolved || global::Infragistics.Windows.DataPresenter.FilterRecordLocation.OnTopFixed == filterRecordLocationResolved) : (global::Infragistics.Windows.DataPresenter.FilterRecordLocation.OnBottom == filterRecordLocationResolved || global::Infragistics.Windows.DataPresenter.FilterRecordLocation.OnBottomFixed == filterRecordLocationResolved);
					if (flag)
					{
						global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = (global::Infragistics.Windows.DataPresenter.FilterRecord)this.ExtractRecord(this._recordsToRecycle, typeof(global::Infragistics.Windows.DataPresenter.FilterRecord));
						if (this.IsFilterRecordVisibleHelper(filterRecord))
						{
							if (filterRecord == null)
							{
								filterRecord = new global::Infragistics.Windows.DataPresenter.FilterRecord(this._fieldLayout, this._recordColl);
							}
							filterRecord.FixedRecordLocationOverride = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFixedRecordLocation(top, global::Infragistics.Windows.DataPresenter.FilterRecordLocation.OnTopFixed == filterRecordLocationResolved || (global::Infragistics.Windows.DataPresenter.FilterRecordLocation.OnBottomFixed == filterRecordLocationResolved && this._isRootLevel));
							list.Add(filterRecord);
						}
					}
				}
			}

			// Token: 0x06002CC2 RID: 11458 RVA: 0x000C5AEC File Offset: 0x000C3CEC
			internal void GetSpecialRecordsHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list, bool top)
			{
				global::System.Type[] orderedSpecialRecordTypes = this.GetOrderedSpecialRecordTypes(top);
				int count = list.Count;
				for (int i = 0; i < orderedSpecialRecordTypes.Length; i++)
				{
					this.GetSpecialRecordsHelper(orderedSpecialRecordTypes[i], list, top);
				}
				int count2 = list.Count;
				if (count < count2)
				{
					for (int j = 0; j < count2; j++)
					{
						this.AssignSeparatorVisibility(list[j], top);
					}
					for (int k = 0; k < 2; k++)
					{
						for (int l = count; l < count2; l++)
						{
							global::Infragistics.Windows.DataPresenter.Record record = list[l];
							bool flag = global::Infragistics.Windows.DataPresenter.GridUtilities.IsFixed(record.FixedRecordLocationOverride);
							if (0 == k == (top == flag))
							{
								list.Add(record);
							}
						}
					}
					list.RemoveRange(count, count2 - count);
				}
			}

			// Token: 0x06002CC3 RID: 11459 RVA: 0x000C5BA1 File Offset: 0x000C3DA1
			private bool IsAddRecordVisible()
			{
				return this.GetAddRecordIfVisible(true) != null || null != this.GetAddRecordIfVisible(false);
			}

			// Token: 0x06002CC4 RID: 11460 RVA: 0x000C5BBC File Offset: 0x000C3DBC
			private bool IsFilterRecordVisibleHelper(global::Infragistics.Windows.DataPresenter.FilterRecord currFilterRecord)
			{
				if (this._dataPresenter.IsTreeView && !this._recordManager.IsRootManager)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._fieldLayout;
				bool flag;
				return this._shouldAddSpecialRecords && global::Infragistics.Windows.DataPresenter.FilterUIType.FilterRecord == fieldLayout.FilterUITypeResolved && (currFilterRecord == null || currFilterRecord.VisibilityResolvedBase == global::System.Windows.Visibility.Visible) && this._isTopLevel && (this._isDataRecords || this._isGroupByRecords) && this._view.IsFilterRecordSupported && (global::Infragistics.Windows.DataPresenter.FilterRecord.DoesAnyFieldAllowFiltering(fieldLayout, out flag) || (!flag && this._fieldLayout.AllowRecordFilteringResolvedDefault)) && null != this._recordManager.DataSource;
			}

			// Token: 0x06002CC5 RID: 11461 RVA: 0x000C5C5C File Offset: 0x000C3E5C
			internal bool ProcessPendingUnfixNonSpecialRecords(global::System.Collections.Generic.Queue<global::Infragistics.Windows.DataPresenter.Record> queue)
			{
				if (queue == null || queue.Count == 0)
				{
					return true;
				}
				bool flag = false;
				foreach (global::Infragistics.Windows.DataPresenter.Record record in queue)
				{
					if (record.FixedLocation == global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable)
					{
						int num = this._sparseArray.IndexOf(record);
						if (num >= 0)
						{
							this._vrc.EnsureCorrectSortPosition(record);
							flag = true;
						}
					}
				}
				return !flag;
			}

			// Token: 0x06002CC6 RID: 11462 RVA: 0x000C5CE0 File Offset: 0x000C3EE0
			internal static void ResetCachedSettings(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> records)
			{
				if (records != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.Record record in records)
					{
						record.FixedRecordLocationOverride = global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Default;
						record.SeparatorVisibility = global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.None;
					}
				}
			}

			// Token: 0x06002CC7 RID: 11463 RVA: 0x000C5D34 File Offset: 0x000C3F34
			private void InitShouldAddSpecialRecords()
			{
				bool flag = this._isRootLevel;
				if (!flag)
				{
					global::Infragistics.Collections.SparseArray sparseArray = this._recordColl.SparseArray;
					int num = (sparseArray != null) ? sparseArray.Count : 0;
					int num2 = (sparseArray is global::Infragistics.Windows.DataPresenter.MainRecordSparseArray) ? ((global::Infragistics.Windows.DataPresenter.MainRecordSparseArray)sparseArray).VisibleCount : num;
					flag = (num2 > 0 || this.IsAddRecordVisible());
					if (!flag && num > 0)
					{
						flag = true;
						if (this._isTopLevel && (this._isDataRecords || this._isGroupByRecords) && global::Infragistics.Windows.DataPresenter.FilterUIType.LabelIcons == this._fieldLayout.FilterUITypeResolved && !this._dataPresenter.IsExportControl && !this._dataPresenter.IsReportControl)
						{
							this._addHeaderRecord = !this._fieldLayout.IsTreeView;
						}
					}
				}
				this._shouldAddSpecialRecords = flag;
			}

			// Token: 0x06002CC8 RID: 11464 RVA: 0x000C5DF0 File Offset: 0x000C3FF0
			internal bool VerifyFixedNonSpecialRecords(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list, bool onTop)
			{
				if (list == null || list.Count == 0)
				{
					return true;
				}
				int count = list.Count;
				int count2 = this._sparseArray.Count;
				if (count2 < count)
				{
					return false;
				}
				int num = onTop ? 0 : (count2 - 1);
				int num2 = onTop ? (count - 1) : (count2 - count);
				if (this._isDataRecords)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
					if (onTop)
					{
						dataRecord = (this._sparseArray[0] as global::Infragistics.Windows.DataPresenter.DataRecord);
						dataRecord2 = (list[0] as global::Infragistics.Windows.DataPresenter.DataRecord);
					}
					else
					{
						dataRecord = (this._sparseArray[count2 - 1] as global::Infragistics.Windows.DataPresenter.DataRecord);
						dataRecord2 = (list[count - 1] as global::Infragistics.Windows.DataPresenter.DataRecord);
					}
					if (dataRecord != null && dataRecord2 != dataRecord && dataRecord.IsAddRecord)
					{
						if (onTop)
						{
							num++;
							num2++;
						}
						else
						{
							num--;
							num2--;
						}
					}
				}
				int num3 = onTop ? 0 : (count - 1);
				int num4 = onTop ? 1 : -1;
				bool flag = false;
				int num5 = num;
				while (onTop ? (num5 <= num2) : (num5 >= num2))
				{
					global::Infragistics.Windows.DataPresenter.Record record = this._sparseArray[num5] as global::Infragistics.Windows.DataPresenter.Record;
					global::Infragistics.Windows.DataPresenter.Record record2 = list[num3];
					if (record2 != record)
					{
						int num6 = this._sparseArray.IndexOf(record2);
						if (num6 < 0)
						{
							list.RemoveAt(num3);
							num2 -= num4;
							num5 -= num4;
							if (onTop)
							{
								num3 -= num4;
							}
						}
						else
						{
							this._sparseArray.RemoveAt(num6);
							this._sparseArray.Insert(num5, record2);
							flag = true;
						}
					}
					num3 += num4;
					num5 += num4;
				}
				return !flag;
			}

			// Token: 0x0400153D RID: 5437
			internal global::Infragistics.Windows.DataPresenter.RecordCollectionBase _recordColl;

			// Token: 0x0400153E RID: 5438
			internal global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

			// Token: 0x0400153F RID: 5439
			internal bool _isTopLevel;

			// Token: 0x04001540 RID: 5440
			internal bool _isRootLevel;

			// Token: 0x04001541 RID: 5441
			internal global::Infragistics.Windows.DataPresenter.RecordType _recordsType;

			// Token: 0x04001542 RID: 5442
			internal bool _isDataRecords;

			// Token: 0x04001543 RID: 5443
			internal bool _isGroupByRecords;

			// Token: 0x04001544 RID: 5444
			internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _vrc;

			// Token: 0x04001545 RID: 5445
			internal global::Infragistics.Windows.DataPresenter.Record[] _recordsToRecycle;

			// Token: 0x04001546 RID: 5446
			internal global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

			// Token: 0x04001547 RID: 5447
			internal global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

			// Token: 0x04001548 RID: 5448
			internal global::Infragistics.Windows.DataPresenter.ViewBase _view;

			// Token: 0x04001549 RID: 5449
			internal global::Infragistics.Windows.DataPresenter.MainRecordSparseArray _sparseArray;

			// Token: 0x0400154A RID: 5450
			internal bool _shouldAddSpecialRecords;

			// Token: 0x0400154B RID: 5451
			internal bool _isRecordFixingAllowed;

			// Token: 0x0400154C RID: 5452
			internal bool _addHeaderRecord;
		}

		// Token: 0x020003A0 RID: 928
		private class VisualRecordEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06002CC9 RID: 11465 RVA: 0x000C5F77 File Offset: 0x000C4177
			internal VisualRecordEnumerator(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection collection)
			{
				this._collection = collection;
				this._currentPosition = -1;
				this._currentItem = global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.VisualRecordEnumerator.UnsetObjectMarker;
			}

			// Token: 0x06002CCA RID: 11466 RVA: 0x000C5F98 File Offset: 0x000C4198
			public void Dispose()
			{
				this.Reset();
			}

			// Token: 0x06002CCB RID: 11467 RVA: 0x000C5FA0 File Offset: 0x000C41A0
			public bool MoveNext()
			{
				int count = this._collection.Count;
				if (this._currentPosition < count - 1)
				{
					this._currentPosition++;
					this._currentItem = this._collection.GetItem(this._currentPosition);
					return true;
				}
				this._currentPosition = count;
				this._currentItem = global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.VisualRecordEnumerator.UnsetObjectMarker;
				return false;
			}

			// Token: 0x06002CCC RID: 11468 RVA: 0x000C5FFE File Offset: 0x000C41FE
			public void Reset()
			{
				this._currentPosition = -1;
				this._currentItem = global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.VisualRecordEnumerator.UnsetObjectMarker;
			}

			// Token: 0x17000DA0 RID: 3488
			// (get) Token: 0x06002CCD RID: 11469 RVA: 0x000C6012 File Offset: 0x000C4212
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x17000DA1 RID: 3489
			// (get) Token: 0x06002CCE RID: 11470 RVA: 0x000C601C File Offset: 0x000C421C
			public global::Infragistics.Windows.DataPresenter.Record Current
			{
				get
				{
					if (this._currentItem != global::Infragistics.Windows.DataPresenter.ViewableRecordCollection.VisualRecordEnumerator.UnsetObjectMarker)
					{
						return this._currentItem as global::Infragistics.Windows.DataPresenter.Record;
					}
					if (this._currentPosition == -1)
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_25"));
					}
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_26"));
				}
			}

			// Token: 0x0400154D RID: 5453
			private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _collection;

			// Token: 0x0400154E RID: 5454
			private int _currentPosition;

			// Token: 0x0400154F RID: 5455
			private object _currentItem;

			// Token: 0x04001550 RID: 5456
			private static object UnsetObjectMarker = new object();
		}
	}
}
