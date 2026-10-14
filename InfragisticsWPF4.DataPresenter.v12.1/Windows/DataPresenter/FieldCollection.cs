using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002BB RID: 699
	public class FieldCollection : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.Field>
	{
		// Token: 0x06001FEB RID: 8171 RVA: 0x00088BB1 File Offset: 0x00086DB1
		internal FieldCollection(global::Infragistics.Windows.DataPresenter.FieldLayout owner)
		{
			this._owner = owner;
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00088BE0 File Offset: 0x00086DE0
		protected override void ClearItems()
		{
			int count = base.Count;
			base.ClearItems();
			this._indexMap.Clear();
			if (this._owner != null && count > 0)
			{
				this._owner.OnFieldAddedRemovedFromCollection();
			}
			this.BumpVersion(false, this._expandableFieldsCount > 0);
			this._expandableFieldsCount = 0;
			this._unboundFieldsCount = 0;
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00088C3C File Offset: 0x00086E3C
		protected override void InsertItem(int index, global::Infragistics.Windows.DataPresenter.Field item)
		{
			item.Initialize(this._owner);
			bool preventBumpLayoutManagerVersionRequired = false;
			if (this._owner != null)
			{
				preventBumpLayoutManagerVersionRequired = this._owner.PreventBumpLayoutManagerVersionRequired;
				this._owner.PreventBumpLayoutManagerVersionRequired = true;
			}
			base.InsertItem(index, item);
			if (this._owner != null)
			{
				this._owner.PreventBumpLayoutManagerVersionRequired = preventBumpLayoutManagerVersionRequired;
			}
			this._indexMap.Clear();
			if (this._owner != null && item != null && !item.IsUnbound)
			{
				this._owner.OnFieldAddedRemovedFromCollection();
			}
			this.BumpVersion(false, item != null && item.IsExpandableResolved);
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._owner;
			if (owner != null && !owner.AutoGenerateFieldsResolved && owner.FieldLayoutInitializedEventRaised && !item.IsPropertyDescriptorInitialized)
			{
				if (this._updateCount > 0)
				{
					this._bumpVersionFlagsOnUpdate |= global::Infragistics.Windows.DataPresenter.FieldCollection.BumpVersionFlags.VerifyAllPropertyDescriptorProviders;
					return;
				}
				this._owner.VerifyAllPropertyDescriptorProviders();
			}
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00088D15 File Offset: 0x00086F15
		protected override void MoveItem(int oldIndex, int newIndex)
		{
			base.MoveItem(oldIndex, newIndex);
			this._indexMap.Clear();
			this.BumpVersion(true);
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00088D34 File Offset: 0x00086F34
		protected override void RemoveItem(int index)
		{
			global::Infragistics.Windows.DataPresenter.Field field = base[index];
			if (this._owner != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
				if (dataPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.SelectedCellCollection cells = dataPresenter.SelectedItems.Cells;
					int count = cells.Count;
					int i;
					for (i = count - 1; i >= 0; i--)
					{
						if (field == cells[i].Field)
						{
							cells.RemoveAt(i);
						}
					}
					global::Infragistics.Windows.DataPresenter.SelectedFieldCollection fields = dataPresenter.SelectedItems.Fields;
					i = fields.IndexOf(field);
					if (i >= 0)
					{
						fields.RemoveAt(i);
					}
				}
			}
			base.RemoveItem(index);
			this._indexMap.Clear();
			if (this._owner != null && field != null && !field.IsUnbound)
			{
				this._owner.OnFieldAddedRemovedFromCollection();
			}
			this.BumpVersion(false, field != null && field.IsExpandableResolved);
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00088E08 File Offset: 0x00087008
		protected override void SetItem(int index, global::Infragistics.Windows.DataPresenter.Field item)
		{
			global::Infragistics.Windows.DataPresenter.Field field = base[index];
			item.Initialize(this._owner);
			base.SetItem(index, item);
			this._indexMap.Clear();
			if ((this._owner != null && item != null && !item.IsUnbound) || (field != null && !field.IsUnbound))
			{
				this._owner.OnFieldAddedRemovedFromCollection();
			}
			this.BumpVersion(true);
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x00088E6C File Offset: 0x0008706C
		public global::Infragistics.Windows.DataPresenter.FieldLayout Owner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x00088E74 File Offset: 0x00087074
		internal int ExpandableFieldsCount
		{
			get
			{
				if (this._expandableFieldsCount < 0)
				{
					this._expandableFieldsCount = 0;
					foreach (global::Infragistics.Windows.DataPresenter.Field field in this)
					{
						if (field.IsExpandableResolved)
						{
							this._expandableFieldsCount++;
						}
					}
				}
				return this._expandableFieldsCount;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x00088EE4 File Offset: 0x000870E4
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> FieldsWithDataValueChangedScopeSetToAllRecords
		{
			get
			{
				if (this._fieldsWithDataValueChangedScopeSetToAllRecords == null)
				{
					this._fieldsWithDataValueChangedScopeSetToAllRecords = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>(base.Count);
					foreach (global::Infragistics.Windows.DataPresenter.Field field in this)
					{
						if (field.DataValueChangedNotificationsActiveResolved && field.DataValueChangedScopeResolved == global::Infragistics.Windows.DataPresenter.DataValueChangedScope.AllAllocatedRecords)
						{
							this._fieldsWithDataValueChangedScopeSetToAllRecords.Add(field);
						}
					}
				}
				return this._fieldsWithDataValueChangedScopeSetToAllRecords;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x00088F64 File Offset: 0x00087164
		internal int InternalVersion
		{
			get
			{
				return this._internalVersion;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x00088F6C File Offset: 0x0008716C
		internal int NotCollapsedExpandableFieldsCount
		{
			get
			{
				if (this._notCollapsedExpandableFieldsCount < 0)
				{
					this._notCollapsedExpandableFieldsCount = 0;
					foreach (global::Infragistics.Windows.DataPresenter.Field field in this)
					{
						if (field.IsExpandableResolved && field.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							this._notCollapsedExpandableFieldsCount++;
						}
					}
				}
				return this._notCollapsedExpandableFieldsCount;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x00088FE4 File Offset: 0x000871E4
		internal global::Infragistics.Windows.DataPresenter.Field[] UnboundFields
		{
			get
			{
				if (this.UnboundFieldsCount < 1)
				{
					return global::Infragistics.Windows.DataPresenter.FieldCollection.EmptyFieldArray;
				}
				return this._unboundFields;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x00088FFC File Offset: 0x000871FC
		internal int UnboundFieldsCount
		{
			get
			{
				if (this._unboundFieldsCount < 0)
				{
					this._unboundFieldsCount = 0;
					this._unboundFields = null;
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = null;
					foreach (global::Infragistics.Windows.DataPresenter.Field field in this)
					{
						if (field.IsUnbound)
						{
							this._unboundFieldsCount++;
							if (list == null)
							{
								list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>(base.Count);
							}
							list.Add(field);
						}
					}
					if (list != null)
					{
						this._unboundFields = list.ToArray();
					}
				}
				return this._unboundFieldsCount;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x00089098 File Offset: 0x00087298
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x1700092B RID: 2347
		public global::Infragistics.Windows.DataPresenter.Field this[string key]
		{
			get
			{
				int num = this.IndexOf(key);
				if (num >= 0)
				{
					return base[num];
				}
				if (key != null && key.Trim().Length > 0 && int.TryParse(key, out num) && num >= 0)
				{
					return base[num];
				}
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_14"));
			}
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x000890F7 File Offset: 0x000872F7
		public void BeginUpdate()
		{
			this._updateCount++;
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00089108 File Offset: 0x00087308
		public void EndUpdate()
		{
			this._updateCount--;
			if (this._updateCount > 0)
			{
				return;
			}
			if (this._updateCount < 0)
			{
				this._updateCount = 0;
			}
			if (this._bumpVersionFlagsOnUpdate != (global::Infragistics.Windows.DataPresenter.FieldCollection.BumpVersionFlags)0)
			{
				this.BumpVersion((byte)(this._bumpVersionFlagsOnUpdate & global::Infragistics.Windows.DataPresenter.FieldCollection.BumpVersionFlags.BumpVersionAndInvalidate) != 0, (byte)(this._bumpVersionFlagsOnUpdate & global::Infragistics.Windows.DataPresenter.FieldCollection.BumpVersionFlags.BumpVersionAndScrollCountRecalcVersion) != 0);
				if ((byte)(this._bumpVersionFlagsOnUpdate & global::Infragistics.Windows.DataPresenter.FieldCollection.BumpVersionFlags.VerifyAllPropertyDescriptorProviders) != 0)
				{
					this._owner.VerifyAllPropertyDescriptorProviders();
				}
				this._bumpVersionFlagsOnUpdate = (global::Infragistics.Windows.DataPresenter.FieldCollection.BumpVersionFlags)0;
			}
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00089188 File Offset: 0x00087388
		public int IndexOf(string name)
		{
			if (this._indexMap.Count == 0)
			{
				this.InitializeIndexMap();
			}
			int result;
			if (name != null && this._indexMap.TryGetValue(name, out result))
			{
				return result;
			}
			return -1;
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000891C0 File Offset: 0x000873C0
		internal global::Infragistics.Windows.DataPresenter.Field GetFieldFromPropertyDescriptor(global::System.ComponentModel.PropertyDescriptor propertyDescriptor)
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.Field field = base[i];
				if (field.DoesPropertyMatch(propertyDescriptor))
				{
					return field;
				}
			}
			return null;
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x000891F4 File Offset: 0x000873F4
		internal global::Infragistics.Windows.DataPresenter.Field GetFirstFieldVisibleInCellArea()
		{
			int count = base.Count;
			for (int i = 0; i < base.Count; i++)
			{
				if (base[i].IsVisibleInCellArea)
				{
					return base[i];
				}
			}
			return null;
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00089230 File Offset: 0x00087430
		internal void OnFieldNameChanged(global::Infragistics.Windows.DataPresenter.Field field, string newName, string oldName)
		{
			this._indexMap.Clear();
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0008923D File Offset: 0x0008743D
		internal void OnIsExpandableFieldInvalidated(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._expandableFieldsCount = -1;
			this._notCollapsedExpandableFieldsCount = -1;
			this.BumpVersion(true);
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00089254 File Offset: 0x00087454
		internal void RefreshDataValueChangedCounts()
		{
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00089258 File Offset: 0x00087458
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerialize()
		{
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this)
			{
				if (field.ShouldSerialize())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x000892A8 File Offset: 0x000874A8
		private void BumpVersion()
		{
			this.BumpVersion(false);
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x000892B1 File Offset: 0x000874B1
		private void BumpVersion(bool invalidate)
		{
			this.BumpVersion(invalidate, true);
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x000892BC File Offset: 0x000874BC
		private void BumpVersion(bool invalidate, bool bumpScrollCountRecalcVersion)
		{
			this._internalVersion++;
			if (this._updateCount > 0)
			{
				if (invalidate)
				{
					this._bumpVersionFlagsOnUpdate |= global::Infragistics.Windows.DataPresenter.FieldCollection.BumpVersionFlags.BumpVersionAndInvalidate;
				}
				if (bumpScrollCountRecalcVersion)
				{
					this._bumpVersionFlagsOnUpdate |= global::Infragistics.Windows.DataPresenter.FieldCollection.BumpVersionFlags.BumpVersionAndScrollCountRecalcVersion;
				}
				return;
			}
			this._version++;
			this._expandableFieldsCount = -1;
			this._notCollapsedExpandableFieldsCount = -1;
			this._unboundFieldsCount = -1;
			if (this._fieldsWithDataValueChangedScopeSetToAllRecords != null)
			{
				this._fieldsWithDataValueChangedScopeSetToAllRecords.Clear();
				this._fieldsWithDataValueChangedScopeSetToAllRecords = null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (this._owner != null) ? this._owner.DataPresenter : null;
			if (dataPresenterBase != null && bumpScrollCountRecalcVersion)
			{
				dataPresenterBase.BumpScrollCountRecalcVersion();
			}
			if (invalidate && dataPresenterBase != null)
			{
				dataPresenterBase.InvalidateItemsHost();
				dataPresenterBase.BumpOverallSortVersion();
			}
			if (this._owner != null)
			{
				this.Owner.BumpLayoutManagerVersion();
			}
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Version"));
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x0008939C File Offset: 0x0008759C
		private void InitializeIndexMap()
		{
			int count = base.Count;
			if (count == 0)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.Field field = base[i];
				string name = field.Name;
				if (name != null && name.Length > 0 && !this._indexMap.ContainsKey(name))
				{
					this._indexMap.Add(name, i);
				}
			}
		}

		// Token: 0x04000FAC RID: 4012
		private int _expandableFieldsCount = -1;

		// Token: 0x04000FAD RID: 4013
		private int _notCollapsedExpandableFieldsCount = -1;

		// Token: 0x04000FAE RID: 4014
		private int _unboundFieldsCount = -1;

		// Token: 0x04000FAF RID: 4015
		private global::Infragistics.Windows.DataPresenter.Field[] _unboundFields;

		// Token: 0x04000FB0 RID: 4016
		private static global::Infragistics.Windows.DataPresenter.Field[] EmptyFieldArray = new global::Infragistics.Windows.DataPresenter.Field[0];

		// Token: 0x04000FB1 RID: 4017
		private global::System.Collections.Generic.Dictionary<string, int> _indexMap = new global::System.Collections.Generic.Dictionary<string, int>();

		// Token: 0x04000FB2 RID: 4018
		private int _version;

		// Token: 0x04000FB3 RID: 4019
		private int _internalVersion;

		// Token: 0x04000FB4 RID: 4020
		private global::Infragistics.Windows.DataPresenter.FieldLayout _owner;

		// Token: 0x04000FB5 RID: 4021
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _fieldsWithDataValueChangedScopeSetToAllRecords;

		// Token: 0x04000FB6 RID: 4022
		private int _updateCount;

		// Token: 0x04000FB7 RID: 4023
		private global::Infragistics.Windows.DataPresenter.FieldCollection.BumpVersionFlags _bumpVersionFlagsOnUpdate;

		// Token: 0x020002BC RID: 700
		internal class FieldEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06002008 RID: 8200 RVA: 0x00089403 File Offset: 0x00087603
			internal FieldEnumerator(global::System.Collections.IEnumerator enumerator)
			{
				this._enumerator = enumerator;
			}

			// Token: 0x1700092C RID: 2348
			// (get) Token: 0x06002009 RID: 8201 RVA: 0x00089412 File Offset: 0x00087612
			public global::Infragistics.Windows.DataPresenter.Field Current
			{
				get
				{
					return this._enumerator.Current as global::Infragistics.Windows.DataPresenter.Field;
				}
			}

			// Token: 0x0600200A RID: 8202 RVA: 0x00089424 File Offset: 0x00087624
			public void Dispose()
			{
			}

			// Token: 0x1700092D RID: 2349
			// (get) Token: 0x0600200B RID: 8203 RVA: 0x00089426 File Offset: 0x00087626
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._enumerator.Current;
				}
			}

			// Token: 0x0600200C RID: 8204 RVA: 0x00089433 File Offset: 0x00087633
			public bool MoveNext()
			{
				return this._enumerator.MoveNext();
			}

			// Token: 0x0600200D RID: 8205 RVA: 0x00089440 File Offset: 0x00087640
			public void Reset()
			{
				this._enumerator.Reset();
			}

			// Token: 0x1700092E RID: 2350
			// (get) Token: 0x0600200E RID: 8206 RVA: 0x0008944D File Offset: 0x0008764D
			global::Infragistics.Windows.DataPresenter.Field global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field>.Current
			{
				get
				{
					return this._enumerator.Current as global::Infragistics.Windows.DataPresenter.Field;
				}
			}

			// Token: 0x04000FB8 RID: 4024
			private global::System.Collections.IEnumerator _enumerator;
		}

		// Token: 0x020002BD RID: 701
		private enum BumpVersionFlags : byte
		{
			// Token: 0x04000FBA RID: 4026
			BumpVersionAndInvalidate = 1,
			// Token: 0x04000FBB RID: 4027
			BumpVersionAndScrollCountRecalcVersion,
			// Token: 0x04000FBC RID: 4028
			VerifyAllPropertyDescriptorProviders = 4
		}
	}
}
