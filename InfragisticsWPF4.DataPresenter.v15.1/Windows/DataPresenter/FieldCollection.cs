using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F9 RID: 761
	public class FieldCollection : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.Field>
	{
		// Token: 0x0600233E RID: 9022 RVA: 0x00099231 File Offset: 0x00097431
		internal FieldCollection(global::Infragistics.Windows.DataPresenter.FieldLayout owner)
		{
			this._owner = owner;
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00099260 File Offset: 0x00097460
		protected override void ClearItems()
		{
			int count = base.Count;
			if (this._owner != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this)
				{
					this._owner.OnFieldRemovedFromCollection(field);
				}
			}
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

		// Token: 0x06002340 RID: 9024 RVA: 0x00099304 File Offset: 0x00097504
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
			if (this._owner != null && item != null && item.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
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
				}
				else
				{
					this._owner.VerifyAllPropertyDescriptorProviders();
				}
			}
			if (this._owner != null && item != null)
			{
				this._owner.OnFieldAddedToCollection(item);
			}
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x000993F5 File Offset: 0x000975F5
		protected override void MoveItem(int oldIndex, int newIndex)
		{
			base.MoveItem(oldIndex, newIndex);
			this._indexMap.Clear();
			this.BumpVersion(true);
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00099414 File Offset: 0x00097614
		protected override void RemoveItem(int index)
		{
			global::Infragistics.Windows.DataPresenter.Field field = base[index];
			if (this._owner != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
				if (dataPresenter != null)
				{
					this._owner.OnFieldRemovedFromCollection(field);
				}
			}
			base.RemoveItem(index);
			this._indexMap.Clear();
			if (this._owner != null && field != null && field.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
			{
				this._owner.OnFieldAddedRemovedFromCollection();
			}
			this.BumpVersion(false, field != null && field.IsExpandableResolved);
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00099490 File Offset: 0x00097690
		protected override void SetItem(int index, global::Infragistics.Windows.DataPresenter.Field item)
		{
			global::Infragistics.Windows.DataPresenter.Field field = base[index];
			if (this._owner != null)
			{
				this._owner.OnFieldRemovedFromCollection(field);
			}
			item.Initialize(this._owner);
			base.SetItem(index, item);
			this._indexMap.Clear();
			if ((this._owner != null && item != null && item.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding) || (field != null && field.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding))
			{
				this._owner.OnFieldAddedRemovedFromCollection();
			}
			this.BumpVersion(true);
			if (this._owner != null && item != null)
			{
				this._owner.OnFieldAddedToCollection(item);
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x0009951F File Offset: 0x0009771F
		public global::Infragistics.Windows.DataPresenter.FieldLayout Owner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x00099528 File Offset: 0x00097728
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

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x00099598 File Offset: 0x00097798
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

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x00099618 File Offset: 0x00097818
		internal int InternalVersion
		{
			get
			{
				return this._internalVersion;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x00099620 File Offset: 0x00097820
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

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x00099698 File Offset: 0x00097898
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

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x000996B0 File Offset: 0x000978B0
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
						if (field.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
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

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x0009974C File Offset: 0x0009794C
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

		// Token: 0x17000A45 RID: 2629
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

		// Token: 0x0600234D RID: 9037 RVA: 0x000997AB File Offset: 0x000979AB
		public void BeginUpdate()
		{
			this._updateCount++;
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x000997BC File Offset: 0x000979BC
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

		// Token: 0x0600234F RID: 9039 RVA: 0x0009983C File Offset: 0x00097A3C
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

		// Token: 0x06002350 RID: 9040 RVA: 0x00099874 File Offset: 0x00097A74
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

		// Token: 0x06002351 RID: 9041 RVA: 0x000998A8 File Offset: 0x00097AA8
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

		// Token: 0x06002352 RID: 9042 RVA: 0x000998E4 File Offset: 0x00097AE4
		internal void OnFieldIsUnboundChanged()
		{
			this.BumpVersion(true);
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x000998ED File Offset: 0x00097AED
		internal void OnFieldNameChanged(global::Infragistics.Windows.DataPresenter.Field field, string newName, string oldName)
		{
			this._indexMap.Clear();
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x000998FA File Offset: 0x00097AFA
		internal void OnIsExpandableFieldInvalidated(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._expandableFieldsCount = -1;
			this._notCollapsedExpandableFieldsCount = -1;
			this.BumpVersion(true);
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00099911 File Offset: 0x00097B11
		internal void RefreshDataValueChangedCounts()
		{
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x00099914 File Offset: 0x00097B14
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

		// Token: 0x06002357 RID: 9047 RVA: 0x00099964 File Offset: 0x00097B64
		internal void BumpVersion()
		{
			this.BumpVersion(false);
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x0009996D File Offset: 0x00097B6D
		private void BumpVersion(bool invalidate)
		{
			this.BumpVersion(invalidate, true);
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00099978 File Offset: 0x00097B78
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

		// Token: 0x0600235A RID: 9050 RVA: 0x00099A58 File Offset: 0x00097C58
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

		// Token: 0x040011A1 RID: 4513
		private int _expandableFieldsCount = -1;

		// Token: 0x040011A2 RID: 4514
		private int _notCollapsedExpandableFieldsCount = -1;

		// Token: 0x040011A3 RID: 4515
		private int _unboundFieldsCount = -1;

		// Token: 0x040011A4 RID: 4516
		private global::Infragistics.Windows.DataPresenter.Field[] _unboundFields;

		// Token: 0x040011A5 RID: 4517
		private static global::Infragistics.Windows.DataPresenter.Field[] EmptyFieldArray = new global::Infragistics.Windows.DataPresenter.Field[0];

		// Token: 0x040011A6 RID: 4518
		private global::System.Collections.Generic.Dictionary<string, int> _indexMap = new global::System.Collections.Generic.Dictionary<string, int>();

		// Token: 0x040011A7 RID: 4519
		private int _version;

		// Token: 0x040011A8 RID: 4520
		private int _internalVersion;

		// Token: 0x040011A9 RID: 4521
		private global::Infragistics.Windows.DataPresenter.FieldLayout _owner;

		// Token: 0x040011AA RID: 4522
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _fieldsWithDataValueChangedScopeSetToAllRecords;

		// Token: 0x040011AB RID: 4523
		private int _updateCount;

		// Token: 0x040011AC RID: 4524
		private global::Infragistics.Windows.DataPresenter.FieldCollection.BumpVersionFlags _bumpVersionFlagsOnUpdate;

		// Token: 0x020002FA RID: 762
		internal class FieldEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600235C RID: 9052 RVA: 0x00099ABF File Offset: 0x00097CBF
			internal FieldEnumerator(global::System.Collections.IEnumerator enumerator)
			{
				this._enumerator = enumerator;
			}

			// Token: 0x17000A46 RID: 2630
			// (get) Token: 0x0600235D RID: 9053 RVA: 0x00099ACE File Offset: 0x00097CCE
			public global::Infragistics.Windows.DataPresenter.Field Current
			{
				get
				{
					return this._enumerator.Current as global::Infragistics.Windows.DataPresenter.Field;
				}
			}

			// Token: 0x0600235E RID: 9054 RVA: 0x00099AE0 File Offset: 0x00097CE0
			public void Dispose()
			{
			}

			// Token: 0x17000A47 RID: 2631
			// (get) Token: 0x0600235F RID: 9055 RVA: 0x00099AE2 File Offset: 0x00097CE2
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._enumerator.Current;
				}
			}

			// Token: 0x06002360 RID: 9056 RVA: 0x00099AEF File Offset: 0x00097CEF
			public bool MoveNext()
			{
				return this._enumerator.MoveNext();
			}

			// Token: 0x06002361 RID: 9057 RVA: 0x00099AFC File Offset: 0x00097CFC
			public void Reset()
			{
				this._enumerator.Reset();
			}

			// Token: 0x17000A48 RID: 2632
			// (get) Token: 0x06002362 RID: 9058 RVA: 0x00099B09 File Offset: 0x00097D09
			global::Infragistics.Windows.DataPresenter.Field global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field>.Current
			{
				get
				{
					return this._enumerator.Current as global::Infragistics.Windows.DataPresenter.Field;
				}
			}

			// Token: 0x040011AD RID: 4525
			private global::System.Collections.IEnumerator _enumerator;
		}

		// Token: 0x020002FB RID: 763
		private enum BumpVersionFlags : byte
		{
			// Token: 0x040011AF RID: 4527
			BumpVersionAndInvalidate = 1,
			// Token: 0x040011B0 RID: 4528
			BumpVersionAndScrollCountRecalcVersion,
			// Token: 0x040011B1 RID: 4529
			VerifyAllPropertyDescriptorProviders = 4
		}
	}
}
