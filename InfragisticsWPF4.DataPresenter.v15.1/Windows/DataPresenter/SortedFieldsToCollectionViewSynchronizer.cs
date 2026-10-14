using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Threading;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200021E RID: 542
	internal class SortedFieldsToCollectionViewSynchronizer
	{
		// Token: 0x0600202E RID: 8238 RVA: 0x0008BE5B File Offset: 0x0008A05B
		private SortedFieldsToCollectionViewSynchronizer(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			this._rm = rm;
			this._fieldLayout = rm.FieldLayout;
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x0008BE78 File Offset: 0x0008A078
		private void Init()
		{
			this._sortVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._fieldLayout, "SortVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnSortVersionChanged));
			this._groupByVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._fieldLayout, "GroupByVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnGroupByVersionChanged));
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x0008BEC9 File Offset: 0x0008A0C9
		internal bool IsUpdatingCollectionView
		{
			get
			{
				return this._isUpdatingCollectionView;
			}
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x0008BED1 File Offset: 0x0008A0D1
		private global::System.ComponentModel.ICollectionView GetCollectionView()
		{
			return global::Infragistics.Windows.DataPresenter.VUtils.GetCollectionView(this._rm);
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x0008BEDE File Offset: 0x0008A0DE
		private void OnSortVersionChanged()
		{
			if (!this._isUpdatingFieldLayoutSortedFields)
			{
				this.Synchronize(true, new bool?(true));
			}
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x0008BEF5 File Offset: 0x0008A0F5
		private void OnGroupByVersionChanged()
		{
			if (!this._isUpdatingFieldLayoutSortedFields)
			{
				this.Synchronize(true, new bool?(true));
			}
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x0008BF0C File Offset: 0x0008A10C
		internal void Synchronize(bool async, bool? gridToCollectionView)
		{
			bool? flag = gridToCollectionView;
			this._gridToCollectionViewFlag = ((flag != null) ? new bool?(flag.GetValueOrDefault()) : this._gridToCollectionViewFlag);
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			if (!async || dataPresenter == null || dataPresenter.IsSynchronousControl)
			{
				this.SynchronizeHelper();
				return;
			}
			if (this._syncOperation == null || this._syncOperation.Status != global::System.Windows.Threading.DispatcherOperationStatus.Pending)
			{
				this._syncOperation = dataPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.DataBind, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.SynchronizeHelper));
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x0008BF94 File Offset: 0x0008A194
		internal bool HasNonGroupBySortFields
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection fieldSortDescriptionCollection = (this._fieldLayout != null) ? this._fieldLayout.SortedFields : null;
				return fieldSortDescriptionCollection != null && fieldSortDescriptionCollection.Count - fieldSortDescriptionCollection.CountOfGroupByFields > 0;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x0008BFD0 File Offset: 0x0008A1D0
		internal bool HasGroupByFields
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection fieldSortDescriptionCollection = (this._fieldLayout != null) ? this._fieldLayout.SortedFields : null;
				return fieldSortDescriptionCollection != null && fieldSortDescriptionCollection.CountOfGroupByFields > 0;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x0008C002 File Offset: 0x0008A202
		internal bool GroupUsingCollectionView
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode.UseCollectionView == this._rm.GroupByEvaluationModeResolved;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x0008C012 File Offset: 0x0008A212
		internal bool SortUsingCollectionView
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SortEvaluationMode.UseCollectionView == this._rm.SortEvaluationModeResolved;
			}
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x0008C024 File Offset: 0x0008A224
		private void SynchronizeHelper()
		{
			this._syncOperation = null;
			if (this._isDisposed)
			{
				return;
			}
			if ((this._gridToCollectionViewFlag != null) ? this._gridToCollectionViewFlag.Value : this._fieldLayout.HasSortedFields)
			{
				this.UpdateCollectionViewSortAndGroupDescriptions();
			}
			else
			{
				if (this.GroupUsingCollectionView && !this.AreGroupDescriptionsSynchronized())
				{
					this.UpdateFieldLayoutGroupedFields();
				}
				if (this.SortUsingCollectionView && !this.AreSortedDescriptionsSynchronized())
				{
					this.UpdateFieldLayoutSortedFields();
				}
			}
			this._gridToCollectionViewFlag = null;
			this._rm.RaiseCurrentChangedHelper();
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x0008C0B4 File Offset: 0x0008A2B4
		internal bool AreSortedDescriptionsSynchronized()
		{
			global::System.ComponentModel.ICollectionView collectionView = this.GetCollectionView();
			if (collectionView != null && collectionView.CanSort)
			{
				global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = this._fieldLayout.SortedFields;
				bool flag = true;
				int num = 0;
				int num2 = 0;
				while (flag && num2 < sortedFields.Count)
				{
					global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = sortedFields[num2];
					if (this.ShouldFSDBeSorted(fieldSortDescription))
					{
						if (num >= collectionView.SortDescriptions.Count)
						{
							flag = false;
						}
						else
						{
							global::System.ComponentModel.SortDescription sortDescription = collectionView.SortDescriptions[num++];
							if (fieldSortDescription.Direction != sortDescription.Direction || global::Infragistics.Windows.DataPresenter.VUtils.GetPropertyName(fieldSortDescription) != sortDescription.PropertyName)
							{
								flag = false;
							}
						}
					}
					num2++;
				}
				return flag && num == collectionView.SortDescriptions.Count;
			}
			return false;
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x0008C178 File Offset: 0x0008A378
		internal bool AreGroupDescriptionsSynchronized()
		{
			global::System.ComponentModel.ICollectionView collectionView = this.GetCollectionView();
			if (collectionView != null && collectionView.CanGroup)
			{
				global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = this._fieldLayout.SortedFields;
				bool flag = true;
				int num = 0;
				int num2 = 0;
				while (flag && num2 < sortedFields.Count)
				{
					global::Infragistics.Windows.DataPresenter.FieldSortDescription fsd = sortedFields[num2];
					if (!this.ShouldFSDBeGrouped(fsd))
					{
						break;
					}
					if (num >= collectionView.GroupDescriptions.Count)
					{
						flag = false;
					}
					else
					{
						global::System.Windows.Data.PropertyGroupDescription propertyGroupDescription = collectionView.GroupDescriptions[num++] as global::System.Windows.Data.PropertyGroupDescription;
						if (propertyGroupDescription == null || global::Infragistics.Windows.DataPresenter.VUtils.GetPropertyName(fsd) != propertyGroupDescription.PropertyName)
						{
							flag = false;
						}
					}
					num2++;
				}
				return flag && num == collectionView.GroupDescriptions.Count;
			}
			return false;
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0008C235 File Offset: 0x0008A435
		private bool ShouldFSDBeSorted(global::Infragistics.Windows.DataPresenter.FieldSortDescription fsd)
		{
			return (fsd.IsGroupBy || !this._fieldLayout.SortedFields.IsFieldInCollectionTwice(fsd)) && (this.SortUsingCollectionView || (fsd.IsGroupBy && this.GroupUsingCollectionView));
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0008C26E File Offset: 0x0008A46E
		private bool ShouldFSDBeGrouped(global::Infragistics.Windows.DataPresenter.FieldSortDescription fsd)
		{
			return fsd.IsGroupBy && this.GroupUsingCollectionView;
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0008C280 File Offset: 0x0008A480
		internal void UpdateCollectionViewSortAndGroupDescriptions()
		{
			if (this._isUpdatingCollectionView || this._isUpdatingFieldLayoutSortedFields)
			{
				return;
			}
			this._isUpdatingCollectionView = true;
			try
			{
				global::System.ComponentModel.ICollectionView collectionView = this.GetCollectionView();
				global::System.IDisposable disposable = null;
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				try
				{
					if (collectionView != null && collectionView.CanSort && (this.SortUsingCollectionView || this.GroupUsingCollectionView))
					{
						if (!this.AreSortedDescriptionsSynchronized())
						{
							if (disposable == null)
							{
								disposable = collectionView.DeferRefresh();
							}
							global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = this._fieldLayout.SortedFields;
							collectionView.SortDescriptions.Clear();
							for (int i = 0; i < sortedFields.Count; i++)
							{
								global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = sortedFields[i];
								if (this.ShouldFSDBeSorted(fieldSortDescription))
								{
									global::System.ComponentModel.SortDescription item = new global::System.ComponentModel.SortDescription(global::Infragistics.Windows.DataPresenter.VUtils.GetPropertyName(fieldSortDescription), fieldSortDescription.Direction);
									collectionView.SortDescriptions.Add(item);
								}
							}
						}
						flag = true;
					}
					if (collectionView != null && collectionView.CanGroup && this.GroupUsingCollectionView)
					{
						if (!this.AreGroupDescriptionsSynchronized())
						{
							this.ClearGroupsSynchronizerHelper();
							if (disposable == null)
							{
								disposable = collectionView.DeferRefresh();
							}
							global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields2 = this._fieldLayout.SortedFields;
							collectionView.GroupDescriptions.Clear();
							for (int j = 0; j < sortedFields2.Count; j++)
							{
								global::Infragistics.Windows.DataPresenter.FieldSortDescription fsd = sortedFields2[j];
								if (!this.ShouldFSDBeGrouped(fsd))
								{
									break;
								}
								global::System.Windows.Data.PropertyGroupDescription item2 = new global::System.Windows.Data.PropertyGroupDescription(global::Infragistics.Windows.DataPresenter.VUtils.GetPropertyName(fsd), null, global::System.StringComparison.CurrentCultureIgnoreCase);
								collectionView.GroupDescriptions.Add(item2);
							}
							flag3 = true;
						}
						else if (this._rm.HasGroups != collectionView.GroupDescriptions.Count > 0)
						{
							flag3 = true;
						}
						flag2 = true;
					}
				}
				finally
				{
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				if (flag)
				{
					this.HookUnhook_CollectionView_SortDescriptions(collectionView, false);
				}
				if (flag2)
				{
					this.HookUnhook_CollectionView_GroupDescriptions(collectionView, false);
				}
				if (flag3)
				{
					this.CreateGroupByRecordsFromGroups(collectionView);
				}
			}
			finally
			{
				this._isUpdatingCollectionView = false;
			}
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0008C474 File Offset: 0x0008A674
		private void HookUnhook_CollectionView_SortDescriptions(global::System.ComponentModel.ICollectionView cv, bool unhookOnly)
		{
			global::System.ComponentModel.SortDescriptionCollection sortDescriptionCollection = (cv != null && !unhookOnly) ? cv.SortDescriptions : null;
			if (this._lastHookedSortDescriptions != sortDescriptionCollection)
			{
				global::System.Collections.Specialized.INotifyCollectionChanged lastHookedSortDescriptions = this._lastHookedSortDescriptions;
				if (lastHookedSortDescriptions != null)
				{
					lastHookedSortDescriptions.CollectionChanged -= this.OnCollectionView_SortDescriptionsChanged;
				}
				this._lastHookedSortDescriptions = sortDescriptionCollection;
				lastHookedSortDescriptions = this._lastHookedSortDescriptions;
				if (lastHookedSortDescriptions != null)
				{
					lastHookedSortDescriptions.CollectionChanged += this.OnCollectionView_SortDescriptionsChanged;
				}
			}
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0008C4DC File Offset: 0x0008A6DC
		private void HookUnhook_CollectionView_GroupDescriptions(global::System.ComponentModel.ICollectionView cv, bool unhookOnly)
		{
			global::System.Collections.ObjectModel.ObservableCollection<global::System.ComponentModel.GroupDescription> observableCollection = (cv != null && !unhookOnly) ? cv.GroupDescriptions : null;
			if (this._lastHookedGroupDescriptions != observableCollection)
			{
				global::System.Collections.Specialized.INotifyCollectionChanged lastHookedGroupDescriptions = this._lastHookedGroupDescriptions;
				if (lastHookedGroupDescriptions != null)
				{
					lastHookedGroupDescriptions.CollectionChanged -= this.OnCollectionView_GroupDescriptionsChanged;
				}
				this._lastHookedGroupDescriptions = observableCollection;
				lastHookedGroupDescriptions = this._lastHookedGroupDescriptions;
				if (lastHookedGroupDescriptions != null)
				{
					lastHookedGroupDescriptions.CollectionChanged += this.OnCollectionView_GroupDescriptionsChanged;
				}
			}
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x0008C544 File Offset: 0x0008A744
		private void CreateGroupByRecordsFromGroups(global::System.ComponentModel.ICollectionView cv)
		{
			if (cv.CanGroup && cv.GroupDescriptions.Count > 0)
			{
				global::System.Collections.ObjectModel.ReadOnlyObservableCollection<object> groups = cv.Groups;
				if (groups != null)
				{
					global::Infragistics.Windows.DataPresenter.VUtils.CreateGroupByRecordsSynchronizerHelper(this, this._rm.Groups, groups);
					return;
				}
			}
			else
			{
				this.ClearGroupsSynchronizerHelper();
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0008C58C File Offset: 0x0008A78C
		private void ClearGroupsSynchronizerHelper()
		{
			if (this._rm.GroupsInternal != null && this._rm.GroupsInternal._groupsSynchronizer != null)
			{
				global::Infragistics.Windows.DataPresenter.GroupsSynchronizer groupsSynchronizer = this._rm.GroupsInternal._groupsSynchronizer;
				if (groupsSynchronizer._disposable != null)
				{
					groupsSynchronizer._disposable.Dispose();
				}
				groupsSynchronizer.Dispose(true);
				this._rm.GroupsInternal._groupsSynchronizer = null;
			}
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0008C5F4 File Offset: 0x0008A7F4
		internal bool EnsureGroupDescriptionsSynchronized()
		{
			if (!this._isUpdatingCollectionView && !this._isUpdatingFieldLayoutSortedFields && this.GroupUsingCollectionView && !this.AreGroupDescriptionsSynchronized())
			{
				this.UpdateFieldLayoutGroupedFields();
				return false;
			}
			return true;
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0008C620 File Offset: 0x0008A820
		private void UpdateFieldLayoutSortedFields()
		{
			if (this._isUpdatingFieldLayoutSortedFields || this._isUpdatingCollectionView)
			{
				return;
			}
			this._isUpdatingFieldLayoutSortedFields = true;
			global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = this._fieldLayout.SortedFields;
			sortedFields.BeginUpdate();
			try
			{
				int i;
				for (i = 0; i < sortedFields.Count; i++)
				{
					if (!sortedFields[i].IsGroupBy)
					{
						break;
					}
				}
				while (i < sortedFields.Count)
				{
					sortedFields.RemoveAt(i);
				}
				global::System.ComponentModel.ICollectionView collectionView = this.GetCollectionView();
				if (collectionView != null && collectionView.CanSort)
				{
					global::System.ComponentModel.SortDescriptionCollection sortDescriptions = collectionView.SortDescriptions;
					if (sortDescriptions != null)
					{
						foreach (global::System.ComponentModel.SortDescription sortDescription in sortDescriptions)
						{
							global::Infragistics.Windows.DataPresenter.Field field = global::Infragistics.Windows.DataPresenter.VUtils.GetField(this._fieldLayout, sortDescription.PropertyName);
							bool flag = null != field;
							if (flag)
							{
								sortedFields.Add(new global::Infragistics.Windows.DataPresenter.FieldSortDescription(field.Name, sortDescription.Direction, false));
							}
						}
					}
				}
			}
			finally
			{
				sortedFields.EndUpdate();
				this._isUpdatingFieldLayoutSortedFields = false;
			}
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0008C738 File Offset: 0x0008A938
		private void UpdateFieldLayoutGroupedFields()
		{
			if (this._isUpdatingFieldLayoutSortedFields || this._isUpdatingCollectionView)
			{
				return;
			}
			this._isUpdatingFieldLayoutSortedFields = true;
			global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = this._fieldLayout.SortedFields;
			sortedFields.BeginUpdate();
			try
			{
				while (sortedFields.Count > 0 && sortedFields[0].IsGroupBy)
				{
					sortedFields.RemoveAt(0);
				}
				global::System.ComponentModel.ICollectionView collectionView = this.GetCollectionView();
				if (collectionView != null && collectionView.CanGroup)
				{
					global::System.Collections.ObjectModel.ObservableCollection<global::System.ComponentModel.GroupDescription> groupDescriptions = collectionView.GroupDescriptions;
					if (groupDescriptions != null)
					{
						foreach (global::System.ComponentModel.GroupDescription groupDescription in groupDescriptions)
						{
							global::System.Windows.Data.PropertyGroupDescription propertyGroupDescription = groupDescription as global::System.Windows.Data.PropertyGroupDescription;
							global::Infragistics.Windows.DataPresenter.Field field = (propertyGroupDescription != null) ? global::Infragistics.Windows.DataPresenter.VUtils.GetField(this._fieldLayout, propertyGroupDescription.PropertyName) : null;
							bool flag = null != field;
							if (flag)
							{
								sortedFields.Add(new global::Infragistics.Windows.DataPresenter.FieldSortDescription(field.Name, global::System.ComponentModel.ListSortDirection.Ascending, true));
							}
						}
					}
					if (groupDescriptions != null && groupDescriptions.Count != sortedFields.CountOfGroupByFields)
					{
						this._fieldLayout.DataPresenter.RaiseDataError(new global::Infragistics.Windows.DataPresenter.DataErrorInfo(null, null, null, global::Infragistics.Windows.DataPresenter.DataErrorOperation.RecordDelete, "Underlying collection view's GroupDescriptions contains a an entry that's duplicate or the associated field does not exist in the data presenter."), true);
						this.ClearGroupsSynchronizerHelper();
						this.Synchronize(true, new bool?(true));
					}
					else
					{
						this.CreateGroupByRecordsFromGroups(collectionView);
					}
				}
			}
			finally
			{
				sortedFields.EndUpdate();
				this._isUpdatingFieldLayoutSortedFields = false;
			}
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0008C898 File Offset: 0x0008AA98
		private void OnCollectionView_SortDescriptionsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			if (!this._isUpdatingCollectionView && this.SortUsingCollectionView)
			{
				this.UpdateFieldLayoutSortedFields();
			}
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x0008C8B0 File Offset: 0x0008AAB0
		private void OnCollectionView_GroupDescriptionsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			if (!this._isUpdatingCollectionView && this.GroupUsingCollectionView)
			{
				this.UpdateFieldLayoutGroupedFields();
			}
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x0008C8C8 File Offset: 0x0008AAC8
		internal void Dispose()
		{
			this._isDisposed = true;
			if (this._sortVersionTracker != null)
			{
				this._sortVersionTracker.Deactivate();
			}
			if (this._groupByVersionTracker != null)
			{
				this._groupByVersionTracker.Deactivate();
			}
			this._sortVersionTracker = null;
			this._groupByVersionTracker = null;
			this.HookUnhook_CollectionView_SortDescriptions(null, true);
			this.HookUnhook_CollectionView_GroupDescriptions(null, true);
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0008C920 File Offset: 0x0008AB20
		internal static global::Infragistics.Windows.DataPresenter.SortedFieldsToCollectionViewSynchronizer CreateHelper(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			global::Infragistics.Windows.DataPresenter.SortedFieldsToCollectionViewSynchronizer sortedFieldsToCollectionViewSynchronizer = null;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (rm != null) ? rm.FieldLayout : null;
			if (fieldLayout != null)
			{
				sortedFieldsToCollectionViewSynchronizer = new global::Infragistics.Windows.DataPresenter.SortedFieldsToCollectionViewSynchronizer(rm);
				sortedFieldsToCollectionViewSynchronizer.Init();
			}
			return sortedFieldsToCollectionViewSynchronizer;
		}

		// Token: 0x04000D9A RID: 3482
		internal readonly global::Infragistics.Windows.DataPresenter.RecordManager _rm;

		// Token: 0x04000D9B RID: 3483
		internal readonly global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000D9C RID: 3484
		private global::Infragistics.Windows.Internal.PropertyValueTracker _sortVersionTracker;

		// Token: 0x04000D9D RID: 3485
		private global::Infragistics.Windows.Internal.PropertyValueTracker _groupByVersionTracker;

		// Token: 0x04000D9E RID: 3486
		private bool _isUpdatingCollectionView;

		// Token: 0x04000D9F RID: 3487
		private bool _isUpdatingFieldLayoutSortedFields;

		// Token: 0x04000DA0 RID: 3488
		private global::System.ComponentModel.SortDescriptionCollection _lastHookedSortDescriptions;

		// Token: 0x04000DA1 RID: 3489
		private global::System.Collections.ObjectModel.ObservableCollection<global::System.ComponentModel.GroupDescription> _lastHookedGroupDescriptions;

		// Token: 0x04000DA2 RID: 3490
		private global::System.Windows.Threading.DispatcherOperation _syncOperation;

		// Token: 0x04000DA3 RID: 3491
		private bool _isDisposed;

		// Token: 0x04000DA4 RID: 3492
		private bool? _gridToCollectionViewFlag;
	}
}
