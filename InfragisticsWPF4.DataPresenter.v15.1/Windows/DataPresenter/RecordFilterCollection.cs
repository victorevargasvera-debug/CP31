using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000160 RID: 352
	public class RecordFilterCollection : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilter>
	{
		// Token: 0x060014AD RID: 5293 RVA: 0x0005C099 File Offset: 0x0005A299
		internal RecordFilterCollection(object owner)
		{
			this._owner = owner;
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0005C0B0 File Offset: 0x0005A2B0
		protected override void ClearItems()
		{
			this._keyMap = null;
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilter filter in this)
			{
				this.OnItemBeingAddedOrRemoved(filter, false);
			}
			base.ClearItems();
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0005C108 File Offset: 0x0005A308
		protected override void InsertItem(int index, global::Infragistics.Windows.DataPresenter.RecordFilter item)
		{
			this.OnItemBeingAddedOrRemoved(item, true);
			index = global::System.Math.Min(index, base.Count);
			base.InsertItem(index, item);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0005C128 File Offset: 0x0005A328
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnCollectionChanged(e);
			this.BumpVersion();
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0005C137 File Offset: 0x0005A337
		protected override void RemoveItem(int index)
		{
			this.OnItemBeingAddedOrRemoved(base[index], false);
			base.RemoveItem(index);
		}

		// Token: 0x1700052B RID: 1323
		public global::Infragistics.Windows.DataPresenter.RecordFilter this[global::Infragistics.Windows.DataPresenter.Field field]
		{
			get
			{
				return this.GetItemHelper(field, true);
			}
		}

		// Token: 0x1700052C RID: 1324
		public global::Infragistics.Windows.DataPresenter.RecordFilter this[string fieldName]
		{
			get
			{
				return this.GetItemHelper(fieldName, true);
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x0005C164 File Offset: 0x0005A364
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

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x0005C19E File Offset: 0x0005A39E
		internal bool IsVersionNotificationsSuspended
		{
			get
			{
				return this._versionNotificationsSuspendedCounter > 0;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x0005C1A9 File Offset: 0x0005A3A9
		internal object Owner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x0005C1B1 File Offset: 0x0005A3B1
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public int Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0005C1B9 File Offset: 0x0005A3B9
		public new void Add(global::Infragistics.Windows.DataPresenter.RecordFilter item)
		{
			base.Add(item);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0005C1C2 File Offset: 0x0005A3C2
		public void Refresh()
		{
			this.ApplyPendingFilters();
			this.BumpVersion();
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0005C1D0 File Offset: 0x0005A3D0
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

		// Token: 0x060014BB RID: 5307 RVA: 0x0005C204 File Offset: 0x0005A404
		internal void ApplyPendingFilters()
		{
			this.ApplyPendingFilters(true, false, null);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0005C210 File Offset: 0x0005A410
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

		// Token: 0x060014BD RID: 5309 RVA: 0x0005C284 File Offset: 0x0005A484
		internal void BumpVersion()
		{
			if (!this.IsVersionNotificationsSuspended)
			{
				if (!this._isLoadingKeyMap)
				{
					this._keyMap = null;
				}
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

		// Token: 0x060014BE RID: 5310 RVA: 0x0005C2E0 File Offset: 0x0005A4E0
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

		// Token: 0x060014BF RID: 5311 RVA: 0x0005C34C File Offset: 0x0005A54C
		internal global::Infragistics.Windows.DataPresenter.RecordFilter GetItem(global::Infragistics.Windows.DataPresenter.Field field, bool create)
		{
			return this.GetItemHelper(field, create);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0005C358 File Offset: 0x0005A558
		private global::Infragistics.Windows.DataPresenter.RecordFilter GetItemHelper(object keyObj, bool create)
		{
			if (this._keyMap == null)
			{
				this._isLoadingKeyMap = true;
				try
				{
					this._keyMap = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.RecordFilter>();
					int i = 0;
					int count = base.Count;
					while (i < count)
					{
						global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = base[i];
						global::Infragistics.Windows.DataPresenter.Field field = recordFilter.Field;
						if (field != null)
						{
							this._keyMap[field] = recordFilter;
						}
						i++;
					}
				}
				finally
				{
					this._isLoadingKeyMap = false;
				}
			}
			global::Infragistics.Windows.DataPresenter.Field field2 = keyObj as global::Infragistics.Windows.DataPresenter.Field;
			if (field2 == null && keyObj is string && ((string)keyObj).Length > 0)
			{
				string name = (string)keyObj;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (this._owner is global::Infragistics.Windows.DataPresenter.FieldLayout) ? (this._owner as global::Infragistics.Windows.DataPresenter.FieldLayout) : (this._owner as global::Infragistics.Windows.DataPresenter.RecordManager).FieldLayout;
				if (fieldLayout != null)
				{
					int num = fieldLayout.Fields.IndexOf(name);
					if (num >= 0)
					{
						field2 = fieldLayout.Fields[num];
					}
				}
			}
			if (field2 != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter2;
				if (this._keyMap.TryGetValue(field2, out recordFilter2))
				{
					return recordFilter2;
				}
				if (create)
				{
					recordFilter2 = new global::Infragistics.Windows.DataPresenter.RecordFilter(field2);
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
					global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter2 = new global::Infragistics.Windows.DataPresenter.RecordFilter(text);
					this.AddImplicitlyCreatedRecordFilter(recordFilter2);
					return recordFilter2;
				}
			}
			return null;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0005C4E8 File Offset: 0x0005A6E8
		private void OnItemBeingAddedOrRemoved(global::Infragistics.Windows.DataPresenter.RecordFilter filter, bool added)
		{
			this.VerifyNotRootRecordManager();
			if (added)
			{
				if (this._keyMap != null && filter.Field != null)
				{
					this._keyMap[filter.Field] = filter;
				}
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(filter);
				filter.InitializeParentCollection(this);
				object keyObj = (filter.Field != null) ? filter.Field : filter.FieldName;
				global::Infragistics.Windows.DataPresenter.RecordFilter itemHelper = this.GetItemHelper(keyObj, false);
				if (itemHelper == null)
				{
					return;
				}
				this.SuspendVersionNotifications();
				try
				{
					base.Remove(itemHelper);
					return;
				}
				finally
				{
					this.ResumeVersionNotifications(false);
				}
			}
			if (this._keyMap != null && filter.Field != null)
			{
				this._keyMap.Remove(filter.Field);
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0005C59C File Offset: 0x0005A79C
		internal void OnFieldLayoutInitialized()
		{
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter in this)
			{
				recordFilter.OnFieldLayoutInitialized();
			}
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0005C5E4 File Offset: 0x0005A7E4
		internal void OnRecordFilterChanged(global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter)
		{
			this.BumpVersion();
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0005C5EC File Offset: 0x0005A7EC
		internal void OnRecordFilterFieldChanged(global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter, global::Infragistics.Windows.DataPresenter.Field oldField)
		{
			if (this._keyMap != null)
			{
				if (oldField != null)
				{
					this._keyMap.Remove(oldField);
				}
				if (recordFilter.Field != null)
				{
					this._keyMap[recordFilter.Field] = recordFilter;
				}
			}
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0005C620 File Offset: 0x0005A820
		private void RaisePropertyChanged(string propertyName)
		{
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0005C62E File Offset: 0x0005A82E
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

		// Token: 0x060014C7 RID: 5319 RVA: 0x0005C658 File Offset: 0x0005A858
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

		// Token: 0x060014C8 RID: 5320 RVA: 0x0005C68E File Offset: 0x0005A88E
		internal void SuspendVersionNotifications()
		{
			this._versionNotificationsSuspendedCounter++;
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0005C6A0 File Offset: 0x0005A8A0
		internal void SynchronizeTreeFilters()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._owner as global::Infragistics.Windows.DataPresenter.FieldLayout;
			if (fieldLayout == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = fieldLayout.AlignmentFieldLayout;
			if (alignmentFieldLayout == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFilters = alignmentFieldLayout.RecordFilters;
			if (recordFilters.Count == 0 && base.Count == 0)
			{
				return;
			}
			if (recordFilters.Version == this._synchronizedTreeVversion)
			{
				return;
			}
			this._synchronizedTreeVversion = recordFilters.Version;
			this.SuspendVersionNotifications();
			try
			{
				base.Clear();
				for (int i = recordFilters.Count - 1; i >= 0; i--)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = recordFilters[i];
					global::Infragistics.Windows.DataPresenter.Field field = recordFilter.Field;
					if (field != null)
					{
						field = fieldLayout.GetFieldFromMappedField(field);
						global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter2 = recordFilter.Clone(true, this);
						recordFilter2.Field = field;
						recordFilter2.InitializeParentCollection(this);
						this.Add(recordFilter2);
					}
				}
			}
			finally
			{
				this.ResumeVersionNotifications(true);
			}
			this.BumpVersion();
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0005C780 File Offset: 0x0005A980
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

		// Token: 0x060014CB RID: 5323 RVA: 0x0005C7FC File Offset: 0x0005A9FC
		private void VerifyNotRootRecordManager()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this._owner as global::Infragistics.Windows.DataPresenter.RecordManager;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (recordManager != null) ? recordManager.DataPresenter : null;
			if (recordManager != null && dataPresenterBase.RecordManagerIfAllocated == recordManager)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_28"));
			}
		}

		// Token: 0x0400087A RID: 2170
		private object _owner;

		// Token: 0x0400087B RID: 2171
		private int _version;

		// Token: 0x0400087C RID: 2172
		private int _versionNotificationsSuspendedCounter;

		// Token: 0x0400087D RID: 2173
		private int _synchronizedTreeVversion = -1;

		// Token: 0x0400087E RID: 2174
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.RecordFilter> _keyMap;

		// Token: 0x0400087F RID: 2175
		private bool _isLoadingKeyMap;
	}
}
