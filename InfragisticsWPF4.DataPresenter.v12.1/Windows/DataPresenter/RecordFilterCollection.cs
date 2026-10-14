using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000144 RID: 324
	public class RecordFilterCollection : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilter>
	{
		// Token: 0x06001143 RID: 4419 RVA: 0x0004AC19 File Offset: 0x00048E19
		internal RecordFilterCollection(object owner)
		{
			this._owner = owner;
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0004AC28 File Offset: 0x00048E28
		protected override void ClearItems()
		{
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilter filter in this)
			{
				this.OnItemBeingAddedOrRemoved(filter, false);
			}
			base.ClearItems();
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0004AC78 File Offset: 0x00048E78
		protected override void InsertItem(int index, global::Infragistics.Windows.DataPresenter.RecordFilter item)
		{
			this.OnItemBeingAddedOrRemoved(item, true);
			index = global::System.Math.Min(index, base.Count);
			base.InsertItem(index, item);
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0004AC98 File Offset: 0x00048E98
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnCollectionChanged(e);
			this.BumpVersion();
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0004ACA7 File Offset: 0x00048EA7
		protected override void RemoveItem(int index)
		{
			this.OnItemBeingAddedOrRemoved(base[index], false);
			base.RemoveItem(index);
		}

		// Token: 0x170003EC RID: 1004
		public global::Infragistics.Windows.DataPresenter.RecordFilter this[global::Infragistics.Windows.DataPresenter.Field field]
		{
			get
			{
				return this.GetItemHelper(field, true);
			}
		}

		// Token: 0x170003ED RID: 1005
		public global::Infragistics.Windows.DataPresenter.RecordFilter this[string fieldName]
		{
			get
			{
				return this.GetItemHelper(fieldName, true);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0004ACD4 File Offset: 0x00048ED4
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._owner as global::Infragistics.Windows.DataPresenter.FieldLayout;
				if (fieldLayout != null)
				{
					return fieldLayout.DataPresenter;
				}
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this._owner as global::Infragistics.Windows.DataPresenter.RecordManager;
				if (recordManager != null)
				{
					return recordManager.DataPresenter;
				}
				return null;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0004AD0E File Offset: 0x00048F0E
		internal bool IsVersionNotificationsSuspended
		{
			get
			{
				return this._versionNotificationsSuspendedCounter > 0;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0004AD19 File Offset: 0x00048F19
		internal object Owner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x0004AD21 File Offset: 0x00048F21
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0004AD29 File Offset: 0x00048F29
		public new void Add(global::Infragistics.Windows.DataPresenter.RecordFilter item)
		{
			base.Add(item);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0004AD32 File Offset: 0x00048F32
		public void Refresh()
		{
			this.ApplyPendingFilters();
			this.BumpVersion();
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0004AD40 File Offset: 0x00048F40
		private void AddImplicitlyCreatedRecordFilter(global::Infragistics.Windows.DataPresenter.RecordFilter filter)
		{
			this.SuspendVersionNotifications();
			try
			{
				this.Add(filter);
			}
			finally
			{
				this.ResumeVersionNotifications(false);
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0004AD74 File Offset: 0x00048F74
		internal void ApplyPendingFilters()
		{
			this.ApplyPendingFilters(true, false, null);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0004AD80 File Offset: 0x00048F80
		internal void ApplyPendingFilters(bool raiseEvents, bool addToUndo, global::Infragistics.Windows.DataPresenter.FilterCell cell)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordFilter> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordFilter>();
			for (int i = 0; i < base.Count; i++)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = base[i].ApplyPendingFilter(raiseEvents, false);
				if (recordFilter != null && addToUndo)
				{
					list.Add(recordFilter);
				}
			}
			if (list.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				if (dataPresenter != null)
				{
					dataPresenter.History.AddUndoActionInternal(new global::Infragistics.Windows.DataPresenter.RecordFiltersAction(list.ToArray(), this.Owner, cell, dataPresenter));
				}
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0004ADF4 File Offset: 0x00048FF4
		internal void BumpVersion()
		{
			if (!this.IsVersionNotificationsSuspended)
			{
				this._version++;
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this._owner as global::Infragistics.Windows.DataPresenter.RecordManager;
				if (recordManager != null)
				{
					global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection recordFiltersResolvedIfAllocated = recordManager.RecordFiltersResolvedIfAllocated;
					if (recordFiltersResolvedIfAllocated != null)
					{
						recordFiltersResolvedIfAllocated.OnSourceFiltersChanged();
					}
				}
				this.RaisePropertyChanged("Version");
			}
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0004AE44 File Offset: 0x00049044
		internal void CloneFrom(global::Infragistics.Windows.DataPresenter.RecordFilterCollection source)
		{
			bool flag = false;
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter in source)
			{
				if (recordFilter.Conditions.Count > 0)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilter item = recordFilter.Clone(true, this);
					this.Add(item);
					flag = true;
				}
			}
			if (flag)
			{
				this.BumpVersion();
			}
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0004AEB0 File Offset: 0x000490B0
		internal global::Infragistics.Windows.DataPresenter.RecordFilter GetItem(global::Infragistics.Windows.DataPresenter.Field field, bool create)
		{
			return this.GetItemHelper(field, create);
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0004AEBC File Offset: 0x000490BC
		private global::Infragistics.Windows.DataPresenter.RecordFilter GetItemHelper(object keyObj, bool create)
		{
			if (keyObj is global::Infragistics.Windows.DataPresenter.Field)
			{
				global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)keyObj;
				int i = 0;
				int count = base.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = base[i];
					if (recordFilter.Field == field)
					{
						return recordFilter;
					}
					i++;
				}
				if (create)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter2 = new global::Infragistics.Windows.DataPresenter.RecordFilter(field);
					this.AddImplicitlyCreatedRecordFilter(recordFilter2);
					return recordFilter2;
				}
			}
			else if (keyObj is string && ((string)keyObj).Length > 0)
			{
				string text = (string)keyObj;
				int j = 0;
				int count2 = base.Count;
				while (j < count2)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter3 = base[j];
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreKeysEqual(recordFilter3.FieldName, text))
					{
						return recordFilter3;
					}
					j++;
				}
				if (create)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter4 = new global::Infragistics.Windows.DataPresenter.RecordFilter(text);
					this.AddImplicitlyCreatedRecordFilter(recordFilter4);
					return recordFilter4;
				}
			}
			return null;
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0004AF80 File Offset: 0x00049180
		private void OnItemBeingAddedOrRemoved(global::Infragistics.Windows.DataPresenter.RecordFilter filter, bool added)
		{
			this.VerifyNotRootRecordManager();
			if (added)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(filter);
				filter.InitializeParentCollection(this);
				object keyObj = (filter.Field != null) ? filter.Field : filter.FieldName;
				global::Infragistics.Windows.DataPresenter.RecordFilter itemHelper = this.GetItemHelper(keyObj, false);
				if (itemHelper != null)
				{
					this.SuspendVersionNotifications();
					try
					{
						base.Remove(itemHelper);
					}
					finally
					{
						this.ResumeVersionNotifications(false);
					}
				}
			}
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0004AFF0 File Offset: 0x000491F0
		internal void OnFieldLayoutInitialized()
		{
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter in this)
			{
				recordFilter.OnFieldLayoutInitialized();
			}
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0004B038 File Offset: 0x00049238
		internal void OnRecordFilterChanged(global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter)
		{
			this.BumpVersion();
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0004B040 File Offset: 0x00049240
		private void RaisePropertyChanged(string propertyName)
		{
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0004B04E File Offset: 0x0004924E
		internal void ResumeVersionNotifications(bool raiseNotification)
		{
			if (this.IsVersionNotificationsSuspended)
			{
				this._versionNotificationsSuspendedCounter--;
				if (raiseNotification && !this.IsVersionNotificationsSuspended)
				{
					this.BumpVersion();
				}
			}
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0004B078 File Offset: 0x00049278
		internal bool ShouldSerialize()
		{
			int i = 0;
			int count = base.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = base[i];
				if (recordFilter != null && recordFilter.ShouldSerialize())
				{
					return true;
				}
				i++;
			}
			return false;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0004B0AE File Offset: 0x000492AE
		internal void SuspendVersionNotifications()
		{
			this._versionNotificationsSuspendedCounter++;
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0004B0C0 File Offset: 0x000492C0
		internal bool VerifyFields()
		{
			this.SuspendVersionNotifications();
			bool raiseNotification = false;
			bool flag = false;
			try
			{
				for (int i = base.Count - 1; i >= 0; i--)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = base[i];
					global::Infragistics.Windows.DataPresenter.Field field = recordFilter.Field;
					if (field != null && field.Index < 0)
					{
						raiseNotification = true;
						flag = (flag || recordFilter.HasConditions);
						base.RemoveAt(i);
					}
				}
			}
			finally
			{
				this.ResumeVersionNotifications(raiseNotification);
			}
			return flag;
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0004B13C File Offset: 0x0004933C
		private void VerifyNotRootRecordManager()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this._owner as global::Infragistics.Windows.DataPresenter.RecordManager;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (recordManager != null) ? recordManager.DataPresenter : null;
			if (recordManager != null && dataPresenterBase.RecordManagerIfAllocated == recordManager)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_28"));
			}
		}

		// Token: 0x040006D2 RID: 1746
		private object _owner;

		// Token: 0x040006D3 RID: 1747
		private int _version;

		// Token: 0x040006D4 RID: 1748
		private int _versionNotificationsSuspendedCounter;
	}
}
