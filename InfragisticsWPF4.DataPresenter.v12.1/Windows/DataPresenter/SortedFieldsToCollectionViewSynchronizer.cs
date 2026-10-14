using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Threading;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001EB RID: 491
	internal class SortedFieldsToCollectionViewSynchronizer
	{
		// Token: 0x06001BC0 RID: 7104 RVA: 0x000761E8 File Offset: 0x000743E8
		private SortedFieldsToCollectionViewSynchronizer(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			this._rm = rm;
			this._fieldLayout = rm.FieldLayout;
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00076204 File Offset: 0x00074404
		private void Init()
		{
			this._sortVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._fieldLayout, "SortVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnSortVersionChanged));
			this._groupByVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._fieldLayout, "GroupByVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnGroupByVersionChanged));
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00076255 File Offset: 0x00074455
		internal bool IsUpdatingCollectionView
		{
			get
			{
				return this._isUpdatingCollectionView;
			}
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0007625D File Offset: 0x0007445D
		private global::System.ComponentModel.ICollectionView GetCollectionView()
		{
			return global::Infragistics.Windows.DataPresenter.VUtils.GetCollectionView(this._rm);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0007626A File Offset: 0x0007446A
		private void OnSortVersionChanged()
		{
			this.UpdateCollectionViewSortDescriptions();
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00076272 File Offset: 0x00074472
		private void OnGroupByVersionChanged()
		{
			this.UpdateCollectionViewGroupDescriptions();
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0007627C File Offset: 0x0007447C
		internal void Synchronize(bool async)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			if (!async || dataPresenter == null || dataPresenter.IsSynchronousControl)
			{
				this.SynchronizeHelper();
				return;
			}
			dataPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.DataBind, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.SynchronizeHelper));
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000762C3 File Offset: 0x000744C3
		private void SynchronizeHelper()
		{
			if (this._fieldLayout.HasSortedFields)
			{
				this.UpdateCollectionViewGroupDescriptions();
				this.UpdateCollectionViewSortDescriptions();
				return;
			}
			if (!this.AreGroupDescriptionsSynchronized())
			{
				this.UpdateFieldLayoutGroupedFields();
			}
			if (!this.AreSortedDescriptionsSynchronized())
			{
				this.UpdateFieldLayoutSortedFields();
			}
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x000762FC File Offset: 0x000744FC
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
					if (!fieldSortDescription.IsGroupBy)
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

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000763C0 File Offset: 0x000745C0
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
					global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = sortedFields[num2];
					if (!fieldSortDescription.IsGroupBy)
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
						if (propertyGroupDescription == null || global::Infragistics.Windows.DataPresenter.VUtils.GetPropertyName(fieldSortDescription) != propertyGroupDescription.PropertyName)
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

		// Token: 0x06001BCA RID: 7114 RVA: 0x0007647C File Offset: 0x0007467C
		internal void UpdateCollectionViewSortDescriptions()
		{
			if (this._isUpdatingCollectionView || this._isUpdatingFieldLayoutSortedFields)
			{
				return;
			}
			this._isUpdatingCollectionView = true;
			try
			{
				global::System.ComponentModel.ICollectionView collectionView = this.GetCollectionView();
				if (collectionView != null && collectionView.CanSort && global::Infragistics.Windows.DataPresenter.SortEvaluationMode.UseCollectionView == this._rm.SortEvaluationModeResolved)
				{
					if (!this.AreSortedDescriptionsSynchronized())
					{
						global::System.IDisposable disposable = collectionView.DeferRefresh();
						try
						{
							global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = this._fieldLayout.SortedFields;
							collectionView.SortDescriptions.Clear();
							for (int i = 0; i < sortedFields.Count; i++)
							{
								global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = sortedFields[i];
								if (!fieldSortDescription.IsGroupBy)
								{
									global::System.ComponentModel.SortDescription item = new global::System.ComponentModel.SortDescription(global::Infragistics.Windows.DataPresenter.VUtils.GetPropertyName(fieldSortDescription), fieldSortDescription.Direction);
									collectionView.SortDescriptions.Add(item);
								}
							}
						}
						finally
						{
							disposable.Dispose();
						}
					}
					this.HookUnhook_CollectionView_SortDescriptions(collectionView, false);
				}
			}
			finally
			{
				this._isUpdatingCollectionView = false;
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0007656C File Offset: 0x0007476C
		internal void UpdateCollectionViewGroupDescriptions()
		{
			if (this._isUpdatingCollectionView || this._isUpdatingFieldLayoutSortedFields)
			{
				return;
			}
			this._isUpdatingCollectionView = true;
			try
			{
				global::System.ComponentModel.ICollectionView collectionView = this.GetCollectionView();
				if (collectionView != null && collectionView.CanGroup && global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode.UseCollectionView == this._rm.GroupByEvaluationModeResolved)
				{
					if (!this.AreGroupDescriptionsSynchronized())
					{
						this.ClearGroupsSynchronizerHelper();
						global::System.IDisposable disposable = collectionView.DeferRefresh();
						try
						{
							global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = this._fieldLayout.SortedFields;
							collectionView.GroupDescriptions.Clear();
							for (int i = 0; i < sortedFields.Count; i++)
							{
								global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = sortedFields[i];
								if (!fieldSortDescription.IsGroupBy)
								{
									break;
								}
								global::System.Windows.Data.PropertyGroupDescription item = new global::System.Windows.Data.PropertyGroupDescription(global::Infragistics.Windows.DataPresenter.VUtils.GetPropertyName(fieldSortDescription), null, global::System.StringComparison.CurrentCultureIgnoreCase);
								collectionView.GroupDescriptions.Add(item);
							}
						}
						finally
						{
							disposable.Dispose();
						}
						this.CreateGroupByRecordsFromGroups(collectionView);
					}
					this.HookUnhook_CollectionView_GroupDescriptions(collectionView, false);
				}
			}
			finally
			{
				this._isUpdatingCollectionView = false;
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00076664 File Offset: 0x00074864
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

		// Token: 0x06001BCD RID: 7117 RVA: 0x000766CC File Offset: 0x000748CC
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

		// Token: 0x06001BCE RID: 7118 RVA: 0x00076734 File Offset: 0x00074934
		private void CreateGroupByRecordsFromGroups(global::System.ComponentModel.ICollectionView cv)
		{
			if (cv.CanGroup && cv.GroupDescriptions.Count > 0)
			{
				global::System.Collections.ObjectModel.ReadOnlyObservableCollection<object> groups = cv.Groups;
				if (groups != null)
				{
					global::Infragistics.Windows.DataPresenter.VUtils.CreateGroupByRecordsSynchronizerHelper(this._rm.Groups, groups);
					return;
				}
			}
			else
			{
				this.ClearGroupsSynchronizerHelper();
			}
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0007677C File Offset: 0x0007497C
		private void ClearGroupsSynchronizerHelper()
		{
			if (this._rm.GroupsInternal != null && this._rm.GroupsInternal._groupsSynchronizer != null)
			{
				this._rm.GroupsInternal._groupsSynchronizer.Dispose();
				this._rm.GroupsInternal._groupsSynchronizer = null;
			}
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x000767D0 File Offset: 0x000749D0
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

		// Token: 0x06001BD1 RID: 7121 RVA: 0x000768E8 File Offset: 0x00074AE8
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
					this.CreateGroupByRecordsFromGroups(collectionView);
				}
			}
			finally
			{
				sortedFields.EndUpdate();
				this._isUpdatingFieldLayoutSortedFields = false;
			}
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00076A00 File Offset: 0x00074C00
		private void OnCollectionView_SortDescriptionsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			if (!this._isUpdatingCollectionView)
			{
				this.UpdateFieldLayoutSortedFields();
			}
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00076A10 File Offset: 0x00074C10
		private void OnCollectionView_GroupDescriptionsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			if (!this._isUpdatingCollectionView)
			{
				this.UpdateFieldLayoutGroupedFields();
			}
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00076A20 File Offset: 0x00074C20
		internal void Dispose()
		{
			this.HookUnhook_CollectionView_SortDescriptions(null, true);
			this.HookUnhook_CollectionView_GroupDescriptions(null, true);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00076A34 File Offset: 0x00074C34
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

		// Token: 0x04000B87 RID: 2951
		internal readonly global::Infragistics.Windows.DataPresenter.RecordManager _rm;

		// Token: 0x04000B88 RID: 2952
		internal readonly global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000B89 RID: 2953
		private global::Infragistics.Windows.Internal.PropertyValueTracker _sortVersionTracker;

		// Token: 0x04000B8A RID: 2954
		private global::Infragistics.Windows.Internal.PropertyValueTracker _groupByVersionTracker;

		// Token: 0x04000B8B RID: 2955
		private bool _isUpdatingCollectionView;

		// Token: 0x04000B8C RID: 2956
		private bool _isUpdatingFieldLayoutSortedFields;

		// Token: 0x04000B8D RID: 2957
		private global::System.ComponentModel.SortDescriptionCollection _lastHookedSortDescriptions;

		// Token: 0x04000B8E RID: 2958
		private global::System.Collections.ObjectModel.ObservableCollection<global::System.ComponentModel.GroupDescription> _lastHookedGroupDescriptions;
	}
}
