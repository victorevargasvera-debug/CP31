using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000118 RID: 280
	internal class FilteredDataItemsCollection : global::System.Collections.IList, global::System.Collections.ICollection, global::System.ComponentModel.ICollectionView, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x14000054 RID: 84
		// (add) Token: 0x06000EED RID: 3821 RVA: 0x000403F4 File Offset: 0x0003E5F4
		// (remove) Token: 0x06000EEE RID: 3822 RVA: 0x0004042C File Offset: 0x0003E62C
		private event global::System.ComponentModel.CurrentChangingEventHandler _currentChangingHandler;

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x06000EEF RID: 3823 RVA: 0x00040464 File Offset: 0x0003E664
		// (remove) Token: 0x06000EF0 RID: 3824 RVA: 0x0004049C File Offset: 0x0003E69C
		private event global::System.EventHandler _currentChangedHandler;

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x06000EF1 RID: 3825 RVA: 0x000404D4 File Offset: 0x0003E6D4
		// (remove) Token: 0x06000EF2 RID: 3826 RVA: 0x0004050C File Offset: 0x0003E70C
		private event global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedHandler;

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00040541 File Offset: 0x0003E741
		internal FilteredDataItemsCollection(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(rm);
			this._rm = rm;
		}

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06000EF4 RID: 3828 RVA: 0x00040558 File Offset: 0x0003E758
		// (remove) Token: 0x06000EF5 RID: 3829 RVA: 0x00040594 File Offset: 0x0003E794
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged
		{
			add
			{
				bool hasListeners = this.HasListeners;
				this._collectionChangedHandler = (global::System.Delegate.Combine(this._collectionChangedHandler, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
				if (this.HasListeners != hasListeners)
				{
					this.OnHasListenersChanged();
				}
			}
			remove
			{
				bool hasListeners = this.HasListeners;
				this._collectionChangedHandler = (global::System.Delegate.Remove(this._collectionChangedHandler, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
				if (this.HasListeners != hasListeners)
				{
					this.OnHasListenersChanged();
				}
			}
		}

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06000EF6 RID: 3830 RVA: 0x000405D0 File Offset: 0x0003E7D0
		// (remove) Token: 0x06000EF7 RID: 3831 RVA: 0x0004060C File Offset: 0x0003E80C
		public event global::System.EventHandler CurrentChanged
		{
			add
			{
				bool hasListeners = this.HasListeners;
				this._currentChangedHandler = (global::System.Delegate.Combine(this._currentChangedHandler, value) as global::System.EventHandler);
				if (this.HasListeners != hasListeners)
				{
					this.OnHasListenersChanged();
				}
			}
			remove
			{
				bool hasListeners = this.HasListeners;
				this._currentChangedHandler = (global::System.Delegate.Remove(this._currentChangedHandler, value) as global::System.EventHandler);
				if (this.HasListeners != hasListeners)
				{
					this.OnHasListenersChanged();
				}
			}
		}

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06000EF8 RID: 3832 RVA: 0x00040648 File Offset: 0x0003E848
		// (remove) Token: 0x06000EF9 RID: 3833 RVA: 0x00040684 File Offset: 0x0003E884
		public event global::System.ComponentModel.CurrentChangingEventHandler CurrentChanging
		{
			add
			{
				bool hasListeners = this.HasListeners;
				this._currentChangingHandler = (global::System.Delegate.Combine(this._currentChangingHandler, value) as global::System.ComponentModel.CurrentChangingEventHandler);
				if (this.HasListeners != hasListeners)
				{
					this.OnHasListenersChanged();
				}
			}
			remove
			{
				bool hasListeners = this.HasListeners;
				this._currentChangingHandler = (global::System.Delegate.Remove(this._currentChangingHandler, value) as global::System.ComponentModel.CurrentChangingEventHandler);
				if (this.HasListeners != hasListeners)
				{
					this.OnHasListenersChanged();
				}
			}
		}

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06000EFA RID: 3834 RVA: 0x000406C0 File Offset: 0x0003E8C0
		// (remove) Token: 0x06000EFB RID: 3835 RVA: 0x000406FC File Offset: 0x0003E8FC
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				bool hasListeners = this.HasListeners;
				this._propertyChangedHandler = (global::System.Delegate.Combine(this._propertyChangedHandler, value) as global::System.ComponentModel.PropertyChangedEventHandler);
				if (this.HasListeners != hasListeners)
				{
					this.OnHasListenersChanged();
				}
			}
			remove
			{
				bool hasListeners = this.HasListeners;
				this._propertyChangedHandler = (global::System.Delegate.Remove(this._propertyChangedHandler, value) as global::System.ComponentModel.PropertyChangedEventHandler);
				if (this.HasListeners != hasListeners)
				{
					this.OnHasListenersChanged();
				}
			}
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00040736 File Offset: 0x0003E936
		public bool Contains(object item)
		{
			this.Verify();
			return this.IndexOf(item) >= 0;
		}

		// Token: 0x1700033B RID: 827
		public object this[int index]
		{
			get
			{
				this.Verify();
				return ((global::Infragistics.Windows.DataPresenter.DataRecord)this._list[index]).DataItem;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00040770 File Offset: 0x0003E970
		public int IndexOf(object item)
		{
			this.Verify();
			global::Infragistics.Windows.DataPresenter.SparseList list = this._list;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)list[i];
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreEqual(item, dataRecord.DataItem))
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x000407BB File Offset: 0x0003E9BB
		public void Refresh()
		{
			if (this._list != null)
			{
				if (!this.HasListeners)
				{
					this._list = null;
					return;
				}
				this._listDirty = true;
				this.Verify();
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x000407E4 File Offset: 0x0003E9E4
		internal void AddRemoveRecordHelper(global::Infragistics.Windows.DataPresenter.DataRecord dataRecord)
		{
			if (this._list == null)
			{
				return;
			}
			if (this.IsRefreshSuspended)
			{
				this._listDirty = true;
				return;
			}
			bool internalIsFilteredOut_Verify = dataRecord.InternalIsFilteredOut_Verify;
			global::Infragistics.Collections.SparseArray sparseArray = this._rm.Sorted.SparseArray;
			int num = sparseArray.IndexOf(dataRecord);
			bool flag = internalIsFilteredOut_Verify || num < 0;
			int num2 = this._list.IndexOf(dataRecord);
			if (flag)
			{
				if (num2 >= 0)
				{
					bool flag2 = this._currentPosition == num2;
					if (flag2)
					{
						this.RaiseCurrentChanging(new global::System.ComponentModel.CurrentChangingEventArgs(false));
					}
					this._list.RemoveAt(num2);
					if (this._currentPosition > num2)
					{
						this._currentPosition--;
					}
					else if (this._currentPosition == num2)
					{
						this._currentPosition = -1;
					}
					global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, dataRecord.DataItem, num2);
					this.RaiseCollectionChanged(e);
					if (flag2)
					{
						this.RaiseCurrentChanged();
						return;
					}
				}
			}
			else if (num2 < 0 && num >= 0)
			{
				int i = 0;
				int num3 = this._list.Count - 1;
				int num4 = 0;
				while (i <= num3)
				{
					num4 = (i + num3) / 2;
					global::Infragistics.Windows.DataPresenter.DataRecord item = (global::Infragistics.Windows.DataPresenter.DataRecord)this._list[num4];
					int num5 = sparseArray.IndexOf(item);
					if (num5 < num)
					{
						num3 = num4 - 1;
					}
					else
					{
						if (num5 <= num)
						{
							break;
						}
						i = num4 + 1;
					}
				}
				this._list.Insert(num4, dataRecord);
				if (this._currentPosition >= num4)
				{
					this._currentPosition++;
				}
				global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e2 = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, dataRecord.DataItem, num4);
				this.RaiseCollectionChanged(e2);
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00040974 File Offset: 0x0003EB74
		private int GetPositionAssociatedWithActiveRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			int result = -1;
			while (record != null && (result = this._list.IndexOf(record)) < 0)
			{
				record = record.ParentDataRecord;
			}
			return result;
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x000409A4 File Offset: 0x0003EBA4
		private void HookUnhookRecordManager(bool unhook)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._rm.DataPresenter;
			global::Infragistics.Windows.DataPresenter.DataRecordCollection sorted = this._rm.Sorted;
			if ((unhook || this._hooked_sortedRecords != sorted) && this._hooked_sortedRecords != null)
			{
				this._hooked_sortedRecords.CollectionChanged -= this.OnSortedRecords_CollectionChanged;
				this._hooked_sortedRecords = null;
			}
			if (!unhook && this._hooked_sortedRecords != sorted)
			{
				if (sorted != null)
				{
					sorted.CollectionChanged += this.OnSortedRecords_CollectionChanged;
				}
				this._hooked_sortedRecords = sorted;
			}
			if (unhook)
			{
				this._dpActiveRecordTracker = null;
				this._filtersVersionTracker = null;
				return;
			}
			if (this._filtersVersionTracker == null)
			{
				this._filtersVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._rm.RecordFiltersResolved, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.VersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFiltersChanged), true);
				this._filtersVersionTracker.AsynchronousDispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Background;
				this._dpActiveRecordTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(dataPresenter, global::Infragistics.Windows.DataPresenter.DataPresenterBase.ActiveRecordProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnDataPresenterActiveRecordChanged), false);
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00040A8F File Offset: 0x0003EC8F
		private void OnDataPresenterActiveRecordChanged()
		{
			if (this.IsRefreshSuspended)
			{
				return;
			}
			this.SyncCurrentPositionToActiveRecordHelper(true, true);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00040AA4 File Offset: 0x0003ECA4
		private void SyncCurrentPositionToActiveRecordHelper(bool verify, bool raiseChangeEvents)
		{
			if (verify)
			{
				this.Verify();
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._rm.DataPresenter;
			if (dataPresenter != null)
			{
				int positionAssociatedWithActiveRecord = this.GetPositionAssociatedWithActiveRecord(dataPresenter.ActiveRecord);
				if (positionAssociatedWithActiveRecord < 0 && (this._currentPosition < 0 || this._currentPosition == this.Count))
				{
					return;
				}
				this.SetCurrentPosition(positionAssociatedWithActiveRecord, raiseChangeEvents);
			}
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00040AFB File Offset: 0x0003ECFB
		private void OnFiltersChanged()
		{
			this.Refresh();
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00040B03 File Offset: 0x0003ED03
		private void OnHasListenersChanged()
		{
			if (!this.HasListeners && !this.IsRefreshSuspended)
			{
				this._list = null;
				this.HookUnhookRecordManager(true);
			}
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00040B23 File Offset: 0x0003ED23
		internal void OnRecordFilteredOutStateChanged(global::Infragistics.Windows.DataPresenter.DataRecord dataRecord)
		{
			this.AddRemoveRecordHelper(dataRecord);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00040B2C File Offset: 0x0003ED2C
		private void OnSortedRecords_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._list != null)
			{
				switch (e.Action)
				{
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = global::Infragistics.Windows.DataPresenter.GridUtilities.GetOneAndOnlyOneItem((e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add) ? e.NewItems : e.OldItems) as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord != null)
					{
						this.AddRemoveRecordHelper(dataRecord);
						return;
					}
					this.Refresh();
					return;
				}
				default:
					this.Refresh();
					break;
				}
			}
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00040B91 File Offset: 0x0003ED91
		private void RaiseCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._collectionChangedHandler != null)
			{
				this._collectionChangedHandler(this, e);
			}
			this.RaiseCurrentPositionRelatedEventsHelper(true);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00040BAF File Offset: 0x0003EDAF
		private void RaiseCurrentChanging(global::System.ComponentModel.CurrentChangingEventArgs e)
		{
			if (this._currentChangingHandler != null)
			{
				this._currentChangingHandler(this, e);
			}
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00040BC6 File Offset: 0x0003EDC6
		private void RaiseCurrentChanged()
		{
			if (this._currentChangedHandler != null)
			{
				this._currentChangedHandler(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00040BE4 File Offset: 0x0003EDE4
		private void RaiseCurrentPositionRelatedEventsHelper(bool raisePropertyChange)
		{
			this.RaisePropertyChanged("Count");
			bool cachedLastIsEmpty = this._cachedLastIsEmpty;
			this._cachedLastIsEmpty = this.IsEmpty;
			if (cachedLastIsEmpty != this._cachedLastIsEmpty && raisePropertyChange)
			{
				this.RaisePropertyChanged("IsEmpty");
			}
			object cachedLastCurrentItem = this._cachedLastCurrentItem;
			this._cachedLastCurrentItem = this.CurrentItem;
			if (cachedLastCurrentItem != this._cachedLastCurrentItem && raisePropertyChange)
			{
				this.RaisePropertyChanged("CurrentItem");
			}
			int cachedLastCurrentPosition = this._cachedLastCurrentPosition;
			this._cachedLastCurrentPosition = this.CurrentPosition;
			if (cachedLastCurrentPosition != this._cachedLastCurrentPosition && raisePropertyChange)
			{
				this.RaisePropertyChanged("CurrentPosition");
			}
			bool cachedLastIsCurrentBeforeFirst = this._cachedLastIsCurrentBeforeFirst;
			this._cachedLastIsCurrentBeforeFirst = ((global::System.ComponentModel.ICollectionView)this).IsCurrentBeforeFirst;
			if (cachedLastIsCurrentBeforeFirst != this._cachedLastIsCurrentBeforeFirst && raisePropertyChange)
			{
				this.RaisePropertyChanged("IsCurrentBeforeFirst");
			}
			bool cachedLastIsCurrentAfterLast = this._cachedLastIsCurrentAfterLast;
			this._cachedLastIsCurrentAfterLast = ((global::System.ComponentModel.ICollectionView)this).IsCurrentAfterLast;
			if (cachedLastIsCurrentAfterLast != this._cachedLastIsCurrentAfterLast && raisePropertyChange)
			{
				this.RaisePropertyChanged("IsCurrentAfterLast");
			}
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00040CD0 File Offset: 0x0003EED0
		private void RaisePropertyChanged(string name)
		{
			if (this._propertyChangedHandler != null)
			{
				this._propertyChangedHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00040CEC File Offset: 0x0003EEEC
		private void ResumeRefresh()
		{
			if (this._suspendRefreshCount > 0)
			{
				this._suspendRefreshCount--;
				if (!this.IsRefreshSuspended)
				{
					this.Verify();
				}
			}
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00040D13 File Offset: 0x0003EF13
		private bool SetCurrentPosition(int position)
		{
			return this.SetCurrentPosition(position, true);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00040D20 File Offset: 0x0003EF20
		private bool SetCurrentPosition(int position, bool raiseChangeEvents)
		{
			this.Verify();
			int num = position;
			position = global::System.Math.Max(global::System.Math.Min(position, this.Count), -1);
			int currentPosition = this.CurrentPosition;
			if (currentPosition != position)
			{
				if (raiseChangeEvents)
				{
					global::System.ComponentModel.CurrentChangingEventArgs currentChangingEventArgs = new global::System.ComponentModel.CurrentChangingEventArgs(true);
					this.RaiseCurrentChanging(currentChangingEventArgs);
					if (currentChangingEventArgs.Cancel)
					{
						return false;
					}
				}
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (position >= 0 && position < this._list.Count) ? ((global::Infragistics.Windows.DataPresenter.DataRecord)this._list[position]) : null;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._rm.DataPresenter;
				if (dataPresenter != null)
				{
					this._currentPosition = position;
					global::Infragistics.Windows.DataPresenter.Record activeRecord = dataPresenter.ActiveRecord;
					if (dataRecord != null || activeRecord == null || activeRecord.IsDataRecord)
					{
						dataPresenter.ActiveRecord = dataRecord;
					}
					if (dataPresenter.ActiveRecord == dataRecord)
					{
						this._currentPosition = position;
					}
					else
					{
						this._currentPosition = this.GetPositionAssociatedWithActiveRecord(dataPresenter.ActiveRecord);
					}
				}
				if (raiseChangeEvents && currentPosition != this.CurrentPosition)
				{
					this.RaiseCurrentChanged();
					this.RaiseCurrentPositionRelatedEventsHelper(true);
				}
			}
			return this.CurrentPosition == num;
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00040E1A File Offset: 0x0003F01A
		private void SuspendRefresh()
		{
			this._suspendRefreshCount++;
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00040E2C File Offset: 0x0003F02C
		private void Verify()
		{
			if (this._list == null || (this._listDirty && !this.IsRefreshSuspended))
			{
				this._listDirty = false;
				bool flag = this._list != null && this.HasListeners;
				this._list = new global::Infragistics.Windows.DataPresenter.SparseList();
				foreach (global::Infragistics.Windows.DataPresenter.DataRecord dataRecord in this._rm.Sorted)
				{
					if (!dataRecord.InternalIsFilteredOut_Verify)
					{
						this._list.Add(dataRecord);
					}
				}
				this.HookUnhookRecordManager(false);
				this.SyncCurrentPositionToActiveRecordHelper(false, false);
				if (flag)
				{
					this.RaiseCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				}
				this.RaiseCurrentPositionRelatedEventsHelper(flag);
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00040EF4 File Offset: 0x0003F0F4
		public int Count
		{
			get
			{
				this.Verify();
				return this._list.Count;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x00040F08 File Offset: 0x0003F108
		public object CurrentItem
		{
			get
			{
				this.Verify();
				int currentPosition = this.CurrentPosition;
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (currentPosition >= 0 && currentPosition < this._list.Count) ? ((global::Infragistics.Windows.DataPresenter.DataRecord)this._list[currentPosition]) : null;
				if (dataRecord == null)
				{
					return null;
				}
				return dataRecord.DataItem;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00040F54 File Offset: 0x0003F154
		public int CurrentPosition
		{
			get
			{
				this.Verify();
				return this._currentPosition;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x00040F62 File Offset: 0x0003F162
		public bool IsEmpty
		{
			get
			{
				return 0 == this.Count;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x00040F6D File Offset: 0x0003F16D
		private bool HasListeners
		{
			get
			{
				return this._collectionChangedHandler != null || this._currentChangingHandler != null || this._currentChangedHandler != null || null != this._propertyChangedHandler;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x00040F95 File Offset: 0x0003F195
		private bool IsRefreshSuspended
		{
			get
			{
				return this._suspendRefreshCount > 0;
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00040FA0 File Offset: 0x0003F1A0
		int global::System.Collections.IList.Add(object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00040FA7 File Offset: 0x0003F1A7
		void global::System.Collections.IList.Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00040FAE File Offset: 0x0003F1AE
		void global::System.Collections.IList.Insert(int index, object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x00040FB5 File Offset: 0x0003F1B5
		public bool IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x00040FB8 File Offset: 0x0003F1B8
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00040FBB File Offset: 0x0003F1BB
		void global::System.Collections.IList.Remove(object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00040FC2 File Offset: 0x0003F1C2
		void global::System.Collections.IList.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00040FCC File Offset: 0x0003F1CC
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this.Verify();
			foreach (object value in ((global::System.Collections.IEnumerable)this))
			{
				array.SetValue(value, index++);
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00041028 File Offset: 0x0003F228
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0004102B File Offset: 0x0003F22B
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00041036 File Offset: 0x0003F236
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			this.Verify();
			return new global::Infragistics.Windows.DataPresenter.GridUtilities.ConverterEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord, object>(new global::Infragistics.Collections.TypedEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord>.Enumerator(this._list.GetEnumerator()), (global::Infragistics.Windows.DataPresenter.DataRecord dr) => dr.DataItem);
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00041070 File Offset: 0x0003F270
		bool global::System.ComponentModel.ICollectionView.CanFilter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00041073 File Offset: 0x0003F273
		bool global::System.ComponentModel.ICollectionView.CanGroup
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00041076 File Offset: 0x0003F276
		bool global::System.ComponentModel.ICollectionView.CanSort
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00041079 File Offset: 0x0003F279
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x0004108B File Offset: 0x0003F28B
		global::System.Globalization.CultureInfo global::System.ComponentModel.ICollectionView.Culture
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(this._rm.FieldLayout);
			}
			set
			{
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0004108D File Offset: 0x0003F28D
		global::System.IDisposable global::System.ComponentModel.ICollectionView.DeferRefresh()
		{
			this.SuspendRefresh();
			return new global::Infragistics.Windows.DataPresenter.FilteredDataItemsCollection.DeferRefreshObject(this);
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0004109B File Offset: 0x0003F29B
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x0004109E File Offset: 0x0003F29E
		global::System.Predicate<object> global::System.ComponentModel.ICollectionView.Filter
		{
			get
			{
				return null;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000410A5 File Offset: 0x0003F2A5
		global::System.Collections.ObjectModel.ObservableCollection<global::System.ComponentModel.GroupDescription> global::System.ComponentModel.ICollectionView.GroupDescriptions
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x000410A8 File Offset: 0x0003F2A8
		global::System.Collections.ObjectModel.ReadOnlyObservableCollection<object> global::System.ComponentModel.ICollectionView.Groups
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000410AC File Offset: 0x0003F2AC
		bool global::System.ComponentModel.ICollectionView.IsCurrentAfterLast
		{
			get
			{
				int currentPosition = this.CurrentPosition;
				return currentPosition >= this._list.Count;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x000410D1 File Offset: 0x0003F2D1
		bool global::System.ComponentModel.ICollectionView.IsCurrentBeforeFirst
		{
			get
			{
				return this.CurrentPosition < 0;
			}
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x000410DC File Offset: 0x0003F2DC
		bool global::System.ComponentModel.ICollectionView.MoveCurrentTo(object item)
		{
			this.Verify();
			return this.SetCurrentPosition(this.IndexOf(item));
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x000410F1 File Offset: 0x0003F2F1
		bool global::System.ComponentModel.ICollectionView.MoveCurrentToFirst()
		{
			this.Verify();
			return this._list.Count > 0 && this.SetCurrentPosition(0);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00041110 File Offset: 0x0003F310
		bool global::System.ComponentModel.ICollectionView.MoveCurrentToLast()
		{
			this.Verify();
			return this._list.Count > 0 && this.SetCurrentPosition(this._list.Count - 1);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0004113B File Offset: 0x0003F33B
		bool global::System.ComponentModel.ICollectionView.MoveCurrentToNext()
		{
			this.Verify();
			return this.SetCurrentPosition(this.CurrentPosition + 1);
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00041151 File Offset: 0x0003F351
		bool global::System.ComponentModel.ICollectionView.MoveCurrentToPosition(int position)
		{
			this.Verify();
			return this.SetCurrentPosition(position);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00041160 File Offset: 0x0003F360
		bool global::System.ComponentModel.ICollectionView.MoveCurrentToPrevious()
		{
			this.Verify();
			return this.SetCurrentPosition(this.CurrentPosition - 1);
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00041176 File Offset: 0x0003F376
		global::System.ComponentModel.SortDescriptionCollection global::System.ComponentModel.ICollectionView.SortDescriptions
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x00041179 File Offset: 0x0003F379
		global::System.Collections.IEnumerable global::System.ComponentModel.ICollectionView.SourceCollection
		{
			get
			{
				return this;
			}
		}

		// Token: 0x040005C8 RID: 1480
		private global::Infragistics.Windows.DataPresenter.RecordManager _rm;

		// Token: 0x040005C9 RID: 1481
		private global::Infragistics.Windows.DataPresenter.SparseList _list;

		// Token: 0x040005CA RID: 1482
		private global::Infragistics.Windows.Internal.PropertyValueTracker _dpActiveRecordTracker;

		// Token: 0x040005CB RID: 1483
		private global::Infragistics.Windows.Internal.PropertyValueTracker _filtersVersionTracker;

		// Token: 0x040005CC RID: 1484
		private global::Infragistics.Windows.DataPresenter.DataRecordCollection _hooked_sortedRecords;

		// Token: 0x040005CD RID: 1485
		private bool _listDirty;

		// Token: 0x040005CE RID: 1486
		private int _suspendRefreshCount;

		// Token: 0x040005CF RID: 1487
		private int _currentPosition;

		// Token: 0x040005D0 RID: 1488
		private bool _cachedLastIsEmpty;

		// Token: 0x040005D1 RID: 1489
		private object _cachedLastCurrentItem;

		// Token: 0x040005D2 RID: 1490
		private int _cachedLastCurrentPosition;

		// Token: 0x040005D3 RID: 1491
		private bool _cachedLastIsCurrentBeforeFirst;

		// Token: 0x040005D4 RID: 1492
		private bool _cachedLastIsCurrentAfterLast;

		// Token: 0x040005D5 RID: 1493
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChangedHandler;

		// Token: 0x02000119 RID: 281
		private class DeferRefreshObject : global::System.IDisposable
		{
			// Token: 0x06000F3A RID: 3898 RVA: 0x0004117C File Offset: 0x0003F37C
			internal DeferRefreshObject(global::Infragistics.Windows.DataPresenter.FilteredDataItemsCollection collection)
			{
				this._collection = collection;
			}

			// Token: 0x06000F3B RID: 3899 RVA: 0x0004118B File Offset: 0x0003F38B
			public void Dispose()
			{
				if (this._collection != null)
				{
					this._collection.ResumeRefresh();
					this._collection = null;
				}
			}

			// Token: 0x040005DA RID: 1498
			private global::Infragistics.Windows.DataPresenter.FilteredDataItemsCollection _collection;
		}
	}
}
