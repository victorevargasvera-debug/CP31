using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Threading;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002C8 RID: 712
	public sealed class FieldLayoutCollection : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldLayout>
	{
		// Token: 0x060021DC RID: 8668 RVA: 0x000933B1 File Offset: 0x000915B1
		internal FieldLayoutCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter)
		{
			this._presenter = presenter;
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x000933C0 File Offset: 0x000915C0
		protected override void ClearItems()
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this[i];
				if (fieldLayout != null)
				{
					fieldLayout.OnRemovedFromCollection();
				}
			}
			base.ClearItems();
			this._typedListRootFieldLayout = null;
			this.VerifyPropertyDescriptorProviders();
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x00093404 File Offset: 0x00091604
		protected override void InsertItem(int index, global::Infragistics.Windows.DataPresenter.FieldLayout item)
		{
			item.InitializeOwner(this._presenter);
			base.InsertItem(index, item);
			item.OnAddedToCollection();
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x00093420 File Offset: 0x00091620
		protected override void RemoveItem(int index)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this[index];
			if (fieldLayout != null)
			{
				fieldLayout.OnRemovedFromCollection();
			}
			if (fieldLayout == this._typedListRootFieldLayout)
			{
				this._typedListRootFieldLayout = null;
			}
			base.RemoveItem(index);
			if (base.Count == 0)
			{
				this.VerifyPropertyDescriptorProviders();
			}
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00093464 File Offset: 0x00091664
		protected override void SetItem(int index, global::Infragistics.Windows.DataPresenter.FieldLayout item)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this[index];
			if (fieldLayout != null)
			{
				fieldLayout.OnRemovedFromCollection();
			}
			item.InitializeOwner(this._presenter);
			base.SetItem(index, item);
			item.OnAddedToCollection();
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x0009349C File Offset: 0x0009169C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._presenter;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x000934A4 File Offset: 0x000916A4
		internal global::Infragistics.Windows.DataPresenter.RecordCollectionBase TemplateDataRecords
		{
			get
			{
				if (this._templateDataRecords == null)
				{
					this._templateDataRecords = new global::Infragistics.Windows.DataPresenter.RecordCollection(null, this._presenter.RecordManager, null);
				}
				return this._templateDataRecords;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x000934CC File Offset: 0x000916CC
		internal global::Infragistics.Windows.DataPresenter.RecordCollectionBase TemplateGroupByRecords
		{
			get
			{
				if (this._templateGroupByRecords == null)
				{
					this._templateGroupByRecords = new global::Infragistics.Windows.DataPresenter.RecordCollection(null, this._presenter.RecordManager, null);
				}
				return this._templateGroupByRecords;
			}
		}

		// Token: 0x170009FD RID: 2557
		public global::Infragistics.Windows.DataPresenter.FieldLayout this[object key]
		{
			get
			{
				if (key is int)
				{
					return base.Items[(int)key];
				}
				int num = this.IndexOfKey(key);
				if (num >= 0)
				{
					return base.Items[num];
				}
				if (key is string && ((string)key).Trim().Length > 0 && int.TryParse((string)key, out num) && num >= 0)
				{
					return base.Items[num];
				}
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_14"));
			}
		}

		// Token: 0x170009FE RID: 2558
		public new global::Infragistics.Windows.DataPresenter.FieldLayout this[int index]
		{
			get
			{
				return base.Items[index];
			}
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x0009358C File Offset: 0x0009178C
		public bool Exists(object key)
		{
			return this.IndexOfKey(key) >= 0;
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x0009359C File Offset: 0x0009179C
		public int IndexOfKey(object key)
		{
			if (key != null)
			{
				int count = base.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.Items[i];
					if (object.Equals(key, fieldLayout.Key))
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000935E0 File Offset: 0x000917E0
		internal void BumpLayoutVersions()
		{
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this)
			{
				fieldLayout.InternalVersion++;
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00093630 File Offset: 0x00091830
		internal void BumpSortVersions()
		{
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this)
			{
				if (fieldLayout.HasSortedFields)
				{
					if (fieldLayout.HasGroupBySortFields)
					{
						fieldLayout.BumpGroupByVersion();
					}
					else
					{
						fieldLayout.BumpSortVersion();
					}
				}
			}
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00093690 File Offset: 0x00091890
		internal global::Infragistics.Windows.DataPresenter.FieldLayout GetDefaultFieldLayout()
		{
			if (this._presenter != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._presenter.RecordManager.FieldLayout;
				if (fieldLayout != null)
				{
					return fieldLayout;
				}
			}
			if (this._typedListRootFieldLayout != null)
			{
				return this._typedListRootFieldLayout;
			}
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = base.Items[i];
				if (fieldLayout2.IsInitialRecordLoaded && fieldLayout2.ParentFieldLayoutKey == null)
				{
					return fieldLayout2;
				}
			}
			for (int j = 0; j < count; j++)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout3 = base.Items[j];
				if (fieldLayout3.HasBeenInitializedAfterDataSourceChange)
				{
					return fieldLayout3;
				}
			}
			if (count <= 0)
			{
				return null;
			}
			return base.Items[0];
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00093739 File Offset: 0x00091939
		internal global::Infragistics.Windows.DataPresenter.FieldLayout GetDefaultLayoutForItem(object item, global::System.Collections.IEnumerable containingCollection, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentRecordCollection)
		{
			return this.GetDefaultLayoutForItem(item, containingCollection, parentRecordCollection, null);
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00093748 File Offset: 0x00091948
		internal global::Infragistics.Windows.DataPresenter.FieldLayout GetDefaultLayoutForItem(object item, global::System.Collections.IEnumerable containingCollection, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentRecordCollection, global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider)
		{
			if (item == null && containingCollection == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = (parentRecordCollection != null) ? (parentRecordCollection.ParentRecord as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord) : null;
			global::Infragistics.Windows.DataPresenter.Field field = (expandableFieldRecord != null) ? expandableFieldRecord.Field : null;
			global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout = (field != null) ? field.Owner : null;
			return this.GetDefaultLayoutForItem(item, containingCollection, parentRecordCollection, propertyDescriptorProvider, field, parentFieldLayout);
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00093798 File Offset: 0x00091998
		internal global::Infragistics.Windows.DataPresenter.FieldLayout GetDefaultLayoutForItem(object item, global::System.Collections.IEnumerable containingCollection, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentRecordCollection, global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider, global::Infragistics.Windows.DataPresenter.Field parentField, global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout)
		{
			if (propertyDescriptorProvider == null)
			{
				propertyDescriptorProvider = this.GetPropertyDescriptorProvider(item, containingCollection);
				if (propertyDescriptorProvider == null)
				{
					return null;
				}
			}
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldLayout> list = base.Items;
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldLayout> items = base.Items;
			int num = list.Count;
			int i = 0;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout;
			while (i < num)
			{
				fieldLayout = list[i];
				bool flag = false;
				if (fieldLayout.DoesParentFieldLayoutMatch(parentFieldLayout))
				{
					goto IL_55;
				}
				if (fieldLayout.ParentFieldLayoutKey != null)
				{
					flag = true;
					goto IL_55;
				}
				IL_DE:
				i++;
				continue;
				IL_55:
				if (!flag && !fieldLayout.DoesParentFieldMatch(parentField))
				{
					if (fieldLayout.ParentFieldName == null)
					{
						goto IL_DE;
					}
					flag = true;
				}
				if (flag)
				{
					bool flag2 = false;
					for (global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (parentRecordCollection != null) ? parentRecordCollection.ParentDataRecord : null; dataRecord != null; dataRecord = dataRecord.ParentDataRecord)
					{
						if (dataRecord.FieldLayout == fieldLayout)
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						if (i < num - 1)
						{
							if (items == list)
							{
								list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout>(list);
							}
							list.RemoveAt(i);
						}
						num--;
						i--;
						goto IL_DE;
					}
					goto IL_DE;
				}
				else
				{
					if (parentField != null && fieldLayout.IsListObjectCompatible(item, containingCollection, false, propertyDescriptorProvider))
					{
						return fieldLayout;
					}
					goto IL_DE;
				}
			}
			for (int j = 0; j < num; j++)
			{
				fieldLayout = list[j];
				if (fieldLayout.DoesProviderMatchKeyExactly(propertyDescriptorProvider))
				{
					return fieldLayout;
				}
			}
			for (int k = 0; k < num; k++)
			{
				fieldLayout = list[k];
				if (fieldLayout.DoesProviderMatchKeyByName(propertyDescriptorProvider) && fieldLayout.IsListObjectCompatible(item, containingCollection, false, propertyDescriptorProvider))
				{
					return fieldLayout;
				}
			}
			for (int l = 0; l < num; l++)
			{
				fieldLayout = list[l];
				if (fieldLayout.IsProviderCached(propertyDescriptorProvider))
				{
					return fieldLayout;
				}
			}
			for (int m = 0; m < num; m++)
			{
				fieldLayout = list[m];
				if ((fieldLayout.Key == null || !fieldLayout.KeyMatchingEnforced || fieldLayout.Fields.Count > 0) && fieldLayout.IsListObjectCompatible(item, containingCollection, false, propertyDescriptorProvider))
				{
					return fieldLayout;
				}
			}
			fieldLayout = new global::Infragistics.Windows.DataPresenter.FieldLayout();
			base.Add(fieldLayout);
			return fieldLayout;
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x00093964 File Offset: 0x00091B64
		internal global::Infragistics.Windows.Internal.PropertyDescriptorProvider GetPropertyDescriptorProvider(object listObject, global::System.Collections.IEnumerable containingCollection)
		{
			if (this._propertyDescriptorProviders == null)
			{
				this._propertyDescriptorProviders = new global::System.Collections.Generic.List<global::System.WeakReference>();
			}
			else
			{
				this.VerifyPropertyDescriptorProviders();
			}
			global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider;
			for (int i = 0; i < this._propertyDescriptorProviders.Count; i++)
			{
				propertyDescriptorProvider = (global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._propertyDescriptorProviders[i]) as global::Infragistics.Windows.Internal.PropertyDescriptorProvider);
				if (propertyDescriptorProvider != null)
				{
					if (listObject != null)
					{
						if (propertyDescriptorProvider.IsCompatibleItem(listObject, containingCollection))
						{
							return propertyDescriptorProvider;
						}
					}
					else if (propertyDescriptorProvider.IsCompatibleList(containingCollection))
					{
						return propertyDescriptorProvider;
					}
				}
			}
			propertyDescriptorProvider = global::Infragistics.Windows.Internal.PropertyDescriptorProvider.CreateProvider(listObject, containingCollection);
			if (propertyDescriptorProvider != null)
			{
				this._propertyDescriptorProviders.Add(new global::System.WeakReference(propertyDescriptorProvider));
				if (propertyDescriptorProvider.RaisesPropertyDescriptorsChangedEvent)
				{
					new global::Infragistics.Windows.DataPresenter.FieldLayoutCollection.PropertyDescriptorsChangedListener(this, propertyDescriptorProvider);
				}
			}
			return propertyDescriptorProvider;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00093A04 File Offset: 0x00091C04
		internal global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider InitializeFieldLayoutStructureFromTypedList(global::System.ComponentModel.ITypedList typedList)
		{
			this._typedListRootFieldLayout = null;
			if (!(typedList is global::System.Collections.IEnumerable))
			{
				return null;
			}
			global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider typedListPropertyDescriptorProvider = this.GetPropertyDescriptorProvider(null, typedList as global::System.Collections.IEnumerable) as global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider;
			if (typedListPropertyDescriptorProvider == null)
			{
				return null;
			}
			global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode providerTree = typedListPropertyDescriptorProvider.GetProviderTree();
			global::Infragistics.Windows.DataPresenter.FieldLayout defaultLayoutForItem = this.GetDefaultLayoutForItem(null, typedList as global::System.Collections.IEnumerable, null, typedListPropertyDescriptorProvider);
			if (defaultLayoutForItem != null)
			{
				if (!defaultLayoutForItem.AreFieldsInitialized)
				{
					defaultLayoutForItem.InitializeFields(null, null, null, typedListPropertyDescriptorProvider);
				}
				this._typedListRootFieldLayout = defaultLayoutForItem;
				this.InitializeChildFieldLayouts(providerTree, defaultLayoutForItem);
				return defaultLayoutForItem.GetProvider(typedListPropertyDescriptorProvider);
			}
			return null;
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00093A80 File Offset: 0x00091C80
		internal void InvalidateGeneratedStyles(bool bumpVersion, bool regenerateTemplates)
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				base.Items[i].InvalidateGeneratedStyles(bumpVersion, regenerateTemplates);
			}
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x00093AB4 File Offset: 0x00091CB4
		internal void OnDataSourceChanged()
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				base.Items[i].OnDataSourceChanged();
			}
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x00093AE8 File Offset: 0x00091CE8
		internal void OnListMetaDataChanged(global::System.ComponentModel.ListChangedEventArgs e, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
		{
			if (base.Count > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this)
				{
					switch (e.ListChangedType)
					{
					case global::System.ComponentModel.ListChangedType.PropertyDescriptorAdded:
						fieldLayout.OnPropertyDescriptorAdded(e.PropertyDescriptor, provider);
						break;
					case global::System.ComponentModel.ListChangedType.PropertyDescriptorDeleted:
						fieldLayout.OnPropertyDescriptorDeleted(e.PropertyDescriptor, provider);
						break;
					case global::System.ComponentModel.ListChangedType.PropertyDescriptorChanged:
						fieldLayout.OnPropertyDescriptorChanged(e.PropertyDescriptor, provider);
						break;
					}
				}
			}
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x00093B7C File Offset: 0x00091D7C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerialize()
		{
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this)
			{
				if (fieldLayout.ShouldSerialize())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00093BCC File Offset: 0x00091DCC
		private void InitializeChildFieldLayouts(global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode node, global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout)
		{
			foreach (global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode providerTreeNode in node.ChildNodes)
			{
				int num = parentFieldLayout.Fields.IndexOf(providerTreeNode.PropertyDescriptorProvider.Name);
				global::Infragistics.Windows.DataPresenter.Field parentField = (num < 0) ? null : parentFieldLayout.Fields[num];
				global::Infragistics.Windows.DataPresenter.FieldLayout defaultLayoutForItem = this.GetDefaultLayoutForItem(null, null, null, providerTreeNode.PropertyDescriptorProvider, parentField, parentFieldLayout);
				if (defaultLayoutForItem != null)
				{
					bool flag = false;
					for (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = parentFieldLayout; fieldLayout != null; fieldLayout = fieldLayout.ParentFieldLayout)
					{
						if (defaultLayoutForItem == fieldLayout)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						defaultLayoutForItem.InitializeParentInfo(parentFieldLayout, parentField);
						if (!defaultLayoutForItem.AreFieldsInitialized)
						{
							defaultLayoutForItem.InitializeFields(null, null, null, providerTreeNode.PropertyDescriptorProvider);
						}
						this.InitializeChildFieldLayouts(providerTreeNode, defaultLayoutForItem);
					}
				}
			}
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00093CA8 File Offset: 0x00091EA8
		private void OnProviderPropertyDescriptorsChanged(global::Infragistics.Windows.Internal.PropertyDescriptorsChangedEventArgs e)
		{
			if (base.Count > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this)
				{
					fieldLayout.OnProviderPropertyDescriptorsChanged(e);
				}
			}
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00093CFC File Offset: 0x00091EFC
		private void VerifyPropertyDescriptorProviders()
		{
			if (this._propertyDescriptorProviders == null)
			{
				return;
			}
			for (int i = this._propertyDescriptorProviders.Count - 1; i >= 0; i--)
			{
				if (!this._propertyDescriptorProviders[i].IsAlive)
				{
					this._propertyDescriptorProviders.RemoveAt(i);
				}
			}
		}

		// Token: 0x04001094 RID: 4244
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _presenter;

		// Token: 0x04001095 RID: 4245
		private global::System.Collections.Generic.List<global::System.WeakReference> _propertyDescriptorProviders;

		// Token: 0x04001096 RID: 4246
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _templateDataRecords;

		// Token: 0x04001097 RID: 4247
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _templateGroupByRecords;

		// Token: 0x04001098 RID: 4248
		private global::Infragistics.Windows.DataPresenter.FieldLayout _typedListRootFieldLayout;

		// Token: 0x020002C9 RID: 713
		// (Invoke) Token: 0x060021F8 RID: 8696
		private delegate void ProviderPropertyDescriptorsChangedCallback(global::Infragistics.Windows.Internal.PropertyDescriptorsChangedEventArgs e);

		// Token: 0x020002CA RID: 714
		private class PropertyDescriptorsChangedListener
		{
			// Token: 0x060021FB RID: 8699 RVA: 0x00093D49 File Offset: 0x00091F49
			internal PropertyDescriptorsChangedListener(global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldsLayouts, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
			{
				this._weakRef = new global::System.WeakReference(fieldsLayouts);
				provider.PropertyDescriptorsChanged += this.OnProviderPropertyDescriptorsChanged;
			}

			// Token: 0x060021FC RID: 8700 RVA: 0x00093D70 File Offset: 0x00091F70
			private void OnProviderPropertyDescriptorsChanged(object sender, global::Infragistics.Windows.Internal.PropertyDescriptorsChangedEventArgs e)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldLayoutCollection = this._weakRef.Target as global::Infragistics.Windows.DataPresenter.FieldLayoutCollection;
				if (fieldLayoutCollection == null)
				{
					e.Provider.PropertyDescriptorsChanged -= this.OnProviderPropertyDescriptorsChanged;
					return;
				}
				if (fieldLayoutCollection._presenter != null)
				{
					if (fieldLayoutCollection._presenter.Dispatcher.CheckAccess())
					{
						fieldLayoutCollection.OnProviderPropertyDescriptorsChanged(e);
						return;
					}
					fieldLayoutCollection._presenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.FieldLayoutCollection.ProviderPropertyDescriptorsChangedCallback(fieldLayoutCollection.OnProviderPropertyDescriptorsChanged), new object[]
					{
						e
					});
				}
			}

			// Token: 0x04001099 RID: 4249
			private global::System.WeakReference _weakRef;
		}
	}
}
