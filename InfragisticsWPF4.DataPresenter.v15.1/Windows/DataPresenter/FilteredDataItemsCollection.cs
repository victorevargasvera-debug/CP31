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
	// Token: 0x02000134 RID: 308
	internal class FilteredDataItemsCollection : global::System.Collections.IList, global::System.Collections.ICollection, global::System.ComponentModel.ICollectionView, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x14000055 RID: 85
		// (add) Token: 0x06001253 RID: 4691 RVA: 0x00050FDC File Offset: 0x0004F1DC
		// (remove) Token: 0x06001254 RID: 4692 RVA: 0x00051014 File Offset: 0x0004F214
		private event global::System.ComponentModel.CurrentChangingEventHandler _currentChangingHandler;

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x06001255 RID: 4693 RVA: 0x0005104C File Offset: 0x0004F24C
		// (remove) Token: 0x06001256 RID: 4694 RVA: 0x00051084 File Offset: 0x0004F284
		private event global::System.EventHandler _currentChangedHandler;

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06001257 RID: 4695 RVA: 0x000510BC File Offset: 0x0004F2BC
		// (remove) Token: 0x06001258 RID: 4696 RVA: 0x000510F4 File Offset: 0x0004F2F4
		private event global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedHandler;

		// Token: 0x06001259 RID: 4697 RVA: 0x00051129 File Offset: 0x0004F329
		internal FilteredDataItemsCollection(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(rm);
			this._rm = rm;
		}

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x0600125A RID: 4698 RVA: 0x00051140 File Offset: 0x0004F340
		// (remove) Token: 0x0600125B RID: 4699 RVA: 0x0005117C File Offset: 0x0004F37C
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

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x0600125C RID: 4700 RVA: 0x000511B8 File Offset: 0x0004F3B8
		// (remove) Token: 0x0600125D RID: 4701 RVA: 0x000511F4 File Offset: 0x0004F3F4
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

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x0600125E RID: 4702 RVA: 0x00051230 File Offset: 0x0004F430
		// (remove) Token: 0x0600125F RID: 4703 RVA: 0x0005126C File Offset: 0x0004F46C
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

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06001260 RID: 4704 RVA: 0x000512A8 File Offset: 0x0004F4A8
		// (remove) Token: 0x06001261 RID: 4705 RVA: 0x000512E4 File Offset: 0x0004F4E4
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

		// Token: 0x06001262 RID: 4706 RVA: 0x0005131E File Offset: 0x0004F51E
		public bool Contains(object item)
		{
			this.Verify();
			return this.IndexOf(item) >= 0;
		}

		// Token: 0x1700047B RID: 1147
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

		// Token: 0x06001265 RID: 4709 RVA: 0x00051358 File Offset: 0x0004F558
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

		// Token: 0x06001266 RID: 4710 RVA: 0x000513A3 File Offset: 0x0004F5A3
		public void Refresh()
		{
			if (this._isInVerify)
			{
				return;
			}
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

		// Token: 0x06001267 RID: 4711 RVA: 0x000513D4 File Offset: 0x0004F5D4
		internal void AddRemoveRecordHelper(global::Infragistics.Windows.DataPresenter.DataRecord dataRecord)
		{
			if (this._list == null || this._isInVerify)
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

		// Token: 0x06001268 RID: 4712 RVA: 0x0005156C File Offset: 0x0004F76C
		private int GetPositionAssociatedWithActiveRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			int result = -1;
			while (record != null && (result = this._list.IndexOf(record)) < 0)
			{
				record = record.ParentDataRecord;
			}
			return result;
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0005159C File Offset: 0x0004F79C
		private void HookUnhookRecordManager(bool unhook)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._rm.DataPresenter;
			global::Infragistics.Windows.DataPresenter.DataRecordCollection dataRecordCollection = unhook ? null : this._rm.Sorted;
			if ((unhook || this._hooked_sortedRecords != dataRecordCollection) && this._hooked_sortedRecords != null)
			{
				this._hooked_sortedRecords.CollectionChanged -= this.OnSortedRecords_CollectionChanged;
				this._hooked_sortedRecords = null;
			}
			if (!unhook && this._hooked_sortedRecords != dataRecordCollection)
			{
				if (dataRecordCollection != null)
				{
					dataRecordCollection.CollectionChanged += this.OnSortedRecords_CollectionChanged;
				}
				this._hooked_sortedRecords = dataRecordCollection;
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

		// Token: 0x0600126A RID: 4714 RVA: 0x0005168D File Offset: 0x0004F88D
		private void OnDataPresenterActiveRecordChanged()
		{
			if (this.IsRefreshSuspended)
			{
				return;
			}
			this.SyncCurrentPositionToActiveRecordHelper(true, true);
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x000516A0 File Offset: 0x0004F8A0
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
				this.SetCurrentPosition(positionAssociatedWithActiveRecord, raiseChangeEvents, false);
			}
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x000516F8 File Offset: 0x0004F8F8
		private void OnFiltersChanged()
		{
			this.Refresh();
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00051700 File Offset: 0x0004F900
		private void OnHasListenersChanged()
		{
			if (!this.HasListeners && !this.IsRefreshSuspended)
			{
				this._list = null;
				this.HookUnhookRecordManager(true);
			}
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00051720 File Offset: 0x0004F920
		internal void OnRecordFilteredOutStateChanged(global::Infragistics.Windows.DataPresenter.DataRecord dataRecord)
		{
			this.AddRemoveRecordHelper(dataRecord);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0005172C File Offset: 0x0004F92C
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

		// Token: 0x06001270 RID: 4720 RVA: 0x00051791 File Offset: 0x0004F991
		private void RaiseCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._collectionChangedHandler != null)
			{
				this._collectionChangedHandler(this, e);
			}
			this.RaiseCurrentPositionRelatedEventsHelper(true);
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x000517AF File Offset: 0x0004F9AF
		private void RaiseCurrentChanging(global::System.ComponentModel.CurrentChangingEventArgs e)
		{
			if (this._currentChangingHandler != null)
			{
				this._currentChangingHandler(this, e);
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x000517C6 File Offset: 0x0004F9C6
		private void RaiseCurrentChanged()
		{
			if (this._currentChangedHandler != null)
			{
				this._currentChangedHandler(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x000517E4 File Offset: 0x0004F9E4
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

		// Token: 0x06001274 RID: 4724 RVA: 0x000518D0 File Offset: 0x0004FAD0
		private void RaisePropertyChanged(string name)
		{
			if (this._propertyChangedHandler != null)
			{
				this._propertyChangedHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000518EC File Offset: 0x0004FAEC
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

		// Token: 0x06001276 RID: 4726 RVA: 0x00051913 File Offset: 0x0004FB13
		private bool SetCurrentPosition(int position)
		{
			return this.SetCurrentPosition(position, true, true);
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00051920 File Offset: 0x0004FB20
		private bool SetCurrentPosition(int position, bool raiseChangeEvents, bool syncActiveRecordToPosition)
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
					if (syncActiveRecordToPosition)
					{
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
				}
				if (raiseChangeEvents && currentPosition != this.CurrentPosition)
				{
					this.RaiseCurrentChanged();
					this.RaiseCurrentPositionRelatedEventsHelper(true);
				}
			}
			return this.CurrentPosition == num;
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00051A1D File Offset: 0x0004FC1D
		private void SuspendRefresh()
		{
			this._suspendRefreshCount++;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00051A30 File Offset: 0x0004FC30
		private void Verify()
		{
			if (this._list == null || (this._listDirty && !this.IsRefreshSuspended))
			{
				if (this._isInVerify)
				{
					return;
				}
				this._isInVerify = true;
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
				this._isInVerify = false;
				this.HookUnhookRecordManager(false);
				this.SyncCurrentPositionToActiveRecordHelper(false, false);
				if (flag)
				{
					this.RaiseCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				}
				this.RaiseCurrentPositionRelatedEventsHelper(flag);
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x00051B10 File Offset: 0x0004FD10
		public int Count
		{
			get
			{
				this.Verify();
				return this._list.Count;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x00051B24 File Offset: 0x0004FD24
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

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x00051B70 File Offset: 0x0004FD70
		public int CurrentPosition
		{
			get
			{
				this.Verify();
				return this._currentPosition;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x00051B7E File Offset: 0x0004FD7E
		public bool IsEmpty
		{
			get
			{
				return 0 == this.Count;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x00051B89 File Offset: 0x0004FD89
		private bool HasListeners
		{
			get
			{
				return this._collectionChangedHandler != null || this._currentChangingHandler != null || this._currentChangedHandler != null || null != this._propertyChangedHandler;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x00051BB1 File Offset: 0x0004FDB1
		private bool IsRefreshSuspended
		{
			get
			{
				return this._suspendRefreshCount > 0;
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00051BBC File Offset: 0x0004FDBC
		int global::System.Collections.IList.Add(object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00051BC3 File Offset: 0x0004FDC3
		void global::System.Collections.IList.Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00051BCA File Offset: 0x0004FDCA
		void global::System.Collections.IList.Insert(int index, object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x00051BD1 File Offset: 0x0004FDD1
		public bool IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x00051BD4 File Offset: 0x0004FDD4
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00051BD7 File Offset: 0x0004FDD7
		void global::System.Collections.IList.Remove(object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00051BDE File Offset: 0x0004FDDE
		void global::System.Collections.IList.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00051BE8 File Offset: 0x0004FDE8
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this.Verify();
			foreach (object value in ((global::System.Collections.IEnumerable)this))
			{
				array.SetValue(value, index++);
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x00051C44 File Offset: 0x0004FE44
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00051C47 File Offset: 0x0004FE47
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00051C52 File Offset: 0x0004FE52
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			this.Verify();
			return new global::Infragistics.Windows.DataPresenter.GridUtilities.ConverterEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord, object>(new global::Infragistics.Collections.TypedEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord>.Enumerator(this._list.GetEnumerator()), (global::Infragistics.Windows.DataPresenter.DataRecord dr) => dr.DataItem);
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x00051C8C File Offset: 0x0004FE8C
		bool global::System.ComponentModel.ICollectionView.CanFilter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x00051C8F File Offset: 0x0004FE8F
		bool global::System.ComponentModel.ICollectionView.CanGroup
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x00051C92 File Offset: 0x0004FE92
		bool global::System.ComponentModel.ICollectionView.CanSort
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x00051C95 File Offset: 0x0004FE95
		// (set) Token: 0x0600128F RID: 4751 RVA: 0x00051CA7 File Offset: 0x0004FEA7
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

		// Token: 0x06001290 RID: 4752 RVA: 0x00051CA9 File Offset: 0x0004FEA9
		global::System.IDisposable global::System.ComponentModel.ICollectionView.DeferRefresh()
		{
			this.SuspendRefresh();
			return new global::Infragistics.Windows.DataPresenter.FilteredDataItemsCollection.DeferRefreshObject(this);
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00051CB7 File Offset: 0x0004FEB7
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x00051CBA File Offset: 0x0004FEBA
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

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00051CC1 File Offset: 0x0004FEC1
		global::System.Collections.ObjectModel.ObservableCollection<global::System.ComponentModel.GroupDescription> global::System.ComponentModel.ICollectionView.GroupDescriptions
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00051CC4 File Offset: 0x0004FEC4
		global::System.Collections.ObjectModel.ReadOnlyObservableCollection<object> global::System.ComponentModel.ICollectionView.Groups
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00051CC8 File Offset: 0x0004FEC8
		bool global::System.ComponentModel.ICollectionView.IsCurrentAfterLast
		{
			get
			{
				int currentPosition = this.CurrentPosition;
				return currentPosition >= this._list.Count;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00051CED File Offset: 0x0004FEED
		bool global::System.ComponentModel.ICollectionView.IsCurrentBeforeFirst
		{
			get
			{
				return this.CurrentPosition < 0;
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00051CF8 File Offset: 0x0004FEF8
		bool global::System.ComponentModel.ICollectionView.MoveCurrentTo(object item)
		{
			this.Verify();
			return this.SetCurrentPosition(this.IndexOf(item));
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00051D0D File Offset: 0x0004FF0D
		bool global::System.ComponentModel.ICollectionView.MoveCurrentToFirst()
		{
			this.Verify();
			return this._list.Count > 0 && this.SetCurrentPosition(0);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00051D2C File Offset: 0x0004FF2C
		bool global::System.ComponentModel.ICollectionView.MoveCurrentToLast()
		{
			this.Verify();
			return this._list.Count > 0 && this.SetCurrentPosition(this._list.Count - 1);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00051D57 File Offset: 0x0004FF57
		bool global::System.ComponentModel.ICollectionView.MoveCurrentToNext()
		{
			this.Verify();
			return this.SetCurrentPosition(this.CurrentPosition + 1);
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00051D6D File Offset: 0x0004FF6D
		bool global::System.ComponentModel.ICollectionView.MoveCurrentToPosition(int position)
		{
			this.Verify();
			return this.SetCurrentPosition(position);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00051D7C File Offset: 0x0004FF7C
		bool global::System.ComponentModel.ICollectionView.MoveCurrentToPrevious()
		{
			this.Verify();
			return this.SetCurrentPosition(this.CurrentPosition - 1);
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x00051D92 File Offset: 0x0004FF92
		global::System.ComponentModel.SortDescriptionCollection global::System.ComponentModel.ICollectionView.SortDescriptions
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x00051D95 File Offset: 0x0004FF95
		global::System.Collections.IEnumerable global::System.ComponentModel.ICollectionView.SourceCollection
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04000769 RID: 1897
		private global::Infragistics.Windows.DataPresenter.RecordManager _rm;

		// Token: 0x0400076A RID: 1898
		private global::Infragistics.Windows.DataPresenter.SparseList _list;

		// Token: 0x0400076B RID: 1899
		private global::Infragistics.Windows.Internal.PropertyValueTracker _dpActiveRecordTracker;

		// Token: 0x0400076C RID: 1900
		private global::Infragistics.Windows.Internal.PropertyValueTracker _filtersVersionTracker;

		// Token: 0x0400076D RID: 1901
		private global::Infragistics.Windows.DataPresenter.DataRecordCollection _hooked_sortedRecords;

		// Token: 0x0400076E RID: 1902
		private bool _listDirty;

		// Token: 0x0400076F RID: 1903
		private int _suspendRefreshCount;

		// Token: 0x04000770 RID: 1904
		private int _currentPosition;

		// Token: 0x04000771 RID: 1905
		private bool _isInVerify;

		// Token: 0x04000772 RID: 1906
		private bool _cachedLastIsEmpty;

		// Token: 0x04000773 RID: 1907
		private object _cachedLastCurrentItem;

		// Token: 0x04000774 RID: 1908
		private int _cachedLastCurrentPosition;

		// Token: 0x04000775 RID: 1909
		private bool _cachedLastIsCurrentBeforeFirst;

		// Token: 0x04000776 RID: 1910
		private bool _cachedLastIsCurrentAfterLast;

		// Token: 0x04000777 RID: 1911
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChangedHandler;

		// Token: 0x02000135 RID: 309
		private class DeferRefreshObject : global::System.IDisposable
		{
			// Token: 0x060012A0 RID: 4768 RVA: 0x00051D98 File Offset: 0x0004FF98
			internal DeferRefreshObject(global::Infragistics.Windows.DataPresenter.FilteredDataItemsCollection collection)
			{
				this._collection = collection;
			}

			// Token: 0x060012A1 RID: 4769 RVA: 0x00051DA7 File Offset: 0x0004FFA7
			public void Dispose()
			{
				if (this._collection != null)
				{
					this._collection.ResumeRefresh();
					this._collection = null;
				}
			}

			// Token: 0x0400077C RID: 1916
			private global::Infragistics.Windows.DataPresenter.FilteredDataItemsCollection _collection;
		}
	}
}
