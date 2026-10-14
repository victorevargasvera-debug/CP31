using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Threading;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000307 RID: 775
	public sealed class FieldLayoutCollection : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldLayout>
	{
		// Token: 0x06002570 RID: 9584 RVA: 0x000A649D File Offset: 0x000A469D
		internal FieldLayoutCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter)
		{
			this._presenter = presenter;
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x000A64AC File Offset: 0x000A46AC
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
			this._explicitCreateCount = 0;
			this._typedListRootFieldLayout = null;
			this.VerifyPropertyDescriptorProviders();
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x000A64F7 File Offset: 0x000A46F7
		protected override void InsertItem(int index, global::Infragistics.Windows.DataPresenter.FieldLayout item)
		{
			item.InitializeOwner(this._presenter);
			base.InsertItem(index, item);
			if (!item.IsAutoCreated)
			{
				this._explicitCreateCount++;
			}
			item.OnAddedToCollection();
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x000A652C File Offset: 0x000A472C
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
			if (!fieldLayout.IsAutoCreated)
			{
				this._explicitCreateCount--;
			}
			base.RemoveItem(index);
			if (base.Count == 0)
			{
				this.VerifyPropertyDescriptorProviders();
			}
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x000A6588 File Offset: 0x000A4788
		protected override void SetItem(int index, global::Infragistics.Windows.DataPresenter.FieldLayout item)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this[index];
			if (fieldLayout != null)
			{
				fieldLayout.OnRemovedFromCollection();
				if (!fieldLayout.IsAutoCreated)
				{
					this._explicitCreateCount--;
				}
			}
			item.InitializeOwner(this._presenter);
			if (!item.IsAutoCreated)
			{
				this._explicitCreateCount++;
			}
			base.SetItem(index, item);
			item.OnAddedToCollection();
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x000A65EC File Offset: 0x000A47EC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._presenter;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x000A65F4 File Offset: 0x000A47F4
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

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x000A661C File Offset: 0x000A481C
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

		// Token: 0x17000B28 RID: 2856
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

		// Token: 0x17000B29 RID: 2857
		public new global::Infragistics.Windows.DataPresenter.FieldLayout this[int index]
		{
			get
			{
				return base.Items[index];
			}
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000A66DC File Offset: 0x000A48DC
		public bool Exists(object key)
		{
			return this.IndexOfKey(key) >= 0;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000A66EC File Offset: 0x000A48EC
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

		// Token: 0x0600257C RID: 9596 RVA: 0x000A6730 File Offset: 0x000A4930
		internal void BumpLayoutVersions()
		{
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this)
			{
				fieldLayout.InternalVersion++;
			}
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000A6780 File Offset: 0x000A4980
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

		// Token: 0x0600257E RID: 9598 RVA: 0x000A67E0 File Offset: 0x000A49E0
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

		// Token: 0x0600257F RID: 9599 RVA: 0x000A6889 File Offset: 0x000A4A89
		internal global::Infragistics.Windows.DataPresenter.FieldLayout GetDefaultLayoutForItem(object item, global::System.Collections.IEnumerable containingCollection, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentRecordCollection)
		{
			return this.GetDefaultLayoutForItem(item, containingCollection, parentRecordCollection, null);
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x000A6898 File Offset: 0x000A4A98
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

		// Token: 0x06002581 RID: 9601 RVA: 0x000A68E8 File Offset: 0x000A4AE8
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
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
			int i = 0;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2;
			while (i < num)
			{
				fieldLayout2 = list[i];
				bool flag = false;
				if (fieldLayout2.DoesParentFieldLayoutMatch(parentFieldLayout))
				{
					goto IL_58;
				}
				if (fieldLayout2.ParentFieldLayoutKey != null)
				{
					flag = true;
					goto IL_58;
				}
				IL_142:
				i++;
				continue;
				IL_58:
				if (!flag && !fieldLayout2.DoesParentFieldMatch(parentField))
				{
					if (fieldLayout2.ParentFieldName == null)
					{
						goto IL_142;
					}
					flag = true;
				}
				if (flag)
				{
					bool flag2 = false;
					for (global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (parentRecordCollection != null) ? parentRecordCollection.ParentDataRecord : null; dataRecord != null; dataRecord = dataRecord.ParentDataRecord)
					{
						if (dataRecord.FieldLayout == fieldLayout2)
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
						goto IL_142;
					}
					goto IL_142;
				}
				else
				{
					if (parentField == null || fieldLayout2.KeyMatchingEnforced || !fieldLayout2.IsListObjectCompatible(item, containingCollection, false, propertyDescriptorProvider))
					{
						goto IL_142;
					}
					if (item != null && fieldLayout2.IsAutoCreated && this._explicitCreateCount > 0 && propertyDescriptorProvider.Source is global::System.Type)
					{
						global::System.Type type = fieldLayout2.Key as global::System.Type;
						if (type != null)
						{
							global::System.Type type2 = item.GetType();
							if (type2 != type)
							{
								fieldLayout = fieldLayout2;
							}
						}
					}
					if (fieldLayout == null)
					{
						return fieldLayout2;
					}
					goto IL_142;
				}
			}
			for (int j = 0; j < num; j++)
			{
				fieldLayout2 = list[j];
				if ((fieldLayout == null || !fieldLayout2.IsAutoCreated) && fieldLayout2.DoesProviderMatchKeyExactly(propertyDescriptorProvider))
				{
					return fieldLayout2;
				}
			}
			for (int k = 0; k < num; k++)
			{
				fieldLayout2 = list[k];
				if ((fieldLayout == null || !fieldLayout2.IsAutoCreated) && fieldLayout2.DoesProviderMatchKeyByName(propertyDescriptorProvider) && fieldLayout2.IsListObjectCompatible(item, containingCollection, false, propertyDescriptorProvider))
				{
					return fieldLayout2;
				}
			}
			for (int l = 0; l < num; l++)
			{
				fieldLayout2 = list[l];
				if ((fieldLayout == null || !fieldLayout2.IsAutoCreated) && fieldLayout2.IsProviderCached(propertyDescriptorProvider))
				{
					return fieldLayout2;
				}
			}
			for (int m = 0; m < num; m++)
			{
				fieldLayout2 = list[m];
				if ((fieldLayout == null || !fieldLayout2.IsAutoCreated) && (fieldLayout2.Key == null || !fieldLayout2.KeyMatchingEnforced || fieldLayout2.Fields.Count > 0) && fieldLayout2.IsListObjectCompatible(item, containingCollection, false, propertyDescriptorProvider))
				{
					return fieldLayout2;
				}
			}
			if (fieldLayout != null)
			{
				return fieldLayout;
			}
			fieldLayout2 = new global::Infragistics.Windows.DataPresenter.FieldLayout(true);
			base.Add(fieldLayout2);
			return fieldLayout2;
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x000A6B50 File Offset: 0x000A4D50
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

		// Token: 0x06002583 RID: 9603 RVA: 0x000A6BF0 File Offset: 0x000A4DF0
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

		// Token: 0x06002584 RID: 9604 RVA: 0x000A6C6C File Offset: 0x000A4E6C
		internal void InvalidateGeneratedStyles(bool bumpVersion, bool regenerateTemplates, bool bumpSpecialRecords = false, bool? clearAutoFitState = null)
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				base.Items[i].InvalidateGeneratedStyles(bumpVersion, regenerateTemplates, bumpSpecialRecords, clearAutoFitState);
			}
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x000A6CA4 File Offset: 0x000A4EA4
		internal void OnDataSourceChanged()
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				base.Items[i].OnDataSourceChanged();
			}
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x000A6CD8 File Offset: 0x000A4ED8
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

		// Token: 0x06002587 RID: 9607 RVA: 0x000A6D6C File Offset: 0x000A4F6C
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

		// Token: 0x06002588 RID: 9608 RVA: 0x000A6DBC File Offset: 0x000A4FBC
		private void InitializeChildFieldLayouts(global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode node, global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout)
		{
			if (parentFieldLayout.Fields.ExpandableFieldsCount == 0)
			{
				return;
			}
			foreach (global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode providerTreeNode in node.ChildNodes)
			{
				int num = parentFieldLayout.Fields.IndexOf(providerTreeNode.PropertyDescriptorProvider.Name);
				if (num >= 0)
				{
					global::Infragistics.Windows.DataPresenter.Field field = parentFieldLayout.Fields[num];
					if (field.IsExpandableResolved)
					{
						global::Infragistics.Windows.DataPresenter.FieldLayout defaultLayoutForItem = this.GetDefaultLayoutForItem(null, null, null, providerTreeNode.PropertyDescriptorProvider, field, parentFieldLayout);
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
								defaultLayoutForItem.InitializeParentInfo(parentFieldLayout, field);
								if (!defaultLayoutForItem.AreFieldsInitialized)
								{
									defaultLayoutForItem.InitializeFields(null, null, null, providerTreeNode.PropertyDescriptorProvider);
								}
								this.InitializeChildFieldLayouts(providerTreeNode, defaultLayoutForItem);
							}
						}
					}
				}
			}
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x000A6EAC File Offset: 0x000A50AC
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

		// Token: 0x0600258A RID: 9610 RVA: 0x000A6F00 File Offset: 0x000A5100
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

		// Token: 0x040012A8 RID: 4776
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _presenter;

		// Token: 0x040012A9 RID: 4777
		private global::System.Collections.Generic.List<global::System.WeakReference> _propertyDescriptorProviders;

		// Token: 0x040012AA RID: 4778
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _templateDataRecords;

		// Token: 0x040012AB RID: 4779
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _templateGroupByRecords;

		// Token: 0x040012AC RID: 4780
		private global::Infragistics.Windows.DataPresenter.FieldLayout _typedListRootFieldLayout;

		// Token: 0x040012AD RID: 4781
		private int _explicitCreateCount;

		// Token: 0x02000308 RID: 776
		// (Invoke) Token: 0x0600258C RID: 9612
		private delegate void ProviderPropertyDescriptorsChangedCallback(global::Infragistics.Windows.Internal.PropertyDescriptorsChangedEventArgs e);

		// Token: 0x02000309 RID: 777
		private class PropertyDescriptorsChangedListener
		{
			// Token: 0x0600258F RID: 9615 RVA: 0x000A6F4D File Offset: 0x000A514D
			internal PropertyDescriptorsChangedListener(global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldsLayouts, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
			{
				this._weakRef = new global::System.WeakReference(fieldsLayouts);
				provider.PropertyDescriptorsChanged += this.OnProviderPropertyDescriptorsChanged;
			}

			// Token: 0x06002590 RID: 9616 RVA: 0x000A6F74 File Offset: 0x000A5174
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

			// Token: 0x040012AE RID: 4782
			private global::System.WeakReference _weakRef;
		}
	}
}
