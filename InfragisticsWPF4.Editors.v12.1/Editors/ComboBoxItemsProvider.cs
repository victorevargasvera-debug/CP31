using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Xml;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000012 RID: 18
	[global::System.Windows.Markup.ContentProperty("Items")]
	[global::System.ComponentModel.DefaultProperty("Items")]
	public class ComboBoxItemsProvider : global::System.Windows.DependencyObject
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00003923 File Offset: 0x00001B23
		public ComboBoxItemsProvider()
		{
			this._comboBox = new global::System.Windows.Controls.ComboBox();
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00003936 File Offset: 0x00001B36
		private global::System.Windows.Controls.ComboBox ComboBox
		{
			get
			{
				return this._comboBox;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000393E File Offset: 0x00001B3E
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00003950 File Offset: 0x00001B50
		[global::System.ComponentModel.Bindable(true)]
		public string DisplayMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.DisplayMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.DisplayMemberPathProperty, value);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003960 File Offset: 0x00001B60
		private static void OnDisplayMemberPathChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			string displayMemberPath = (string)e.NewValue;
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider comboBoxItemsProvider = (global::Infragistics.Windows.Editors.ComboBoxItemsProvider)dependencyObject;
			comboBoxItemsProvider._comboBox.DisplayMemberPath = displayMemberPath;
			comboBoxItemsProvider.DirtyCachedItems();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003993 File Offset: 0x00001B93
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayMemberPath()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.DisplayMemberPathProperty, this);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000039A0 File Offset: 0x00001BA0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayMemberPath()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.DisplayMemberPathProperty);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000039AD File Offset: 0x00001BAD
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000039B5 File Offset: 0x00001BB5
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.IComparer DisplayTextComparer
		{
			get
			{
				return this._cachedDisplayTextComparer;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.DisplayTextComparerProperty, value);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000039C4 File Offset: 0x00001BC4
		private static void OnDisplayTextComparerChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider comboBoxItemsProvider = (global::Infragistics.Windows.Editors.ComboBoxItemsProvider)dependencyObject;
			comboBoxItemsProvider._cachedDisplayTextComparer = (global::System.Collections.IComparer)e.NewValue;
			comboBoxItemsProvider.DirtyCachedItems();
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000039F0 File Offset: 0x00001BF0
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00003A02 File Offset: 0x00001C02
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Editors.IItemMemberProvider ItemMemberProvider
		{
			get
			{
				return (global::Infragistics.Windows.Editors.IItemMemberProvider)base.GetValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemMemberProviderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemMemberProviderProperty, value);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003A10 File Offset: 0x00001C10
		private static void OnItemMemberProviderChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider comboBoxItemsProvider = (global::Infragistics.Windows.Editors.ComboBoxItemsProvider)dependencyObject;
			comboBoxItemsProvider._cachedItemMemberProvider = (global::Infragistics.Windows.Editors.IItemMemberProvider)e.NewValue;
			comboBoxItemsProvider.DirtyCachedItems();
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00003A3C File Offset: 0x00001C3C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.ItemCollection Items
		{
			get
			{
				global::System.Windows.Controls.ItemCollection items = this._comboBox.Items;
				if (this._cachedItems != items)
				{
					if (this._cachedItems != null)
					{
						((global::System.Collections.Specialized.INotifyCollectionChanged)this._cachedItems).CollectionChanged -= this.OnItems_CollectionChanged;
					}
					this._cachedItems = items;
					if (this._cachedItems != null)
					{
						((global::System.Collections.Specialized.INotifyCollectionChanged)this._cachedItems).CollectionChanged += this.OnItems_CollectionChanged;
					}
				}
				return items;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003AA4 File Offset: 0x00001CA4
		private void OnItems_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.DirtyCachedItems();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003AAC File Offset: 0x00001CAC
		private void OnItemsSource_ListChanged(object sender, global::System.ComponentModel.ListChangedEventArgs e)
		{
			global::System.ComponentModel.ListChangedType listChangedType = e.ListChangedType;
			if (listChangedType == global::System.ComponentModel.ListChangedType.ItemChanged)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = e.PropertyDescriptor;
				if (propertyDescriptor != null && propertyDescriptor.Name != this.DisplayMemberPath && propertyDescriptor.Name != this.ValuePath)
				{
					return;
				}
			}
			this.DirtyCachedItems();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003AFB File Offset: 0x00001CFB
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00003B0D File Offset: 0x00001D0D
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return (global::System.Collections.IEnumerable)base.GetValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemsSourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemsSourceProperty, value);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003B1C File Offset: 0x00001D1C
		private static void OnItemsSourceChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Collections.IEnumerable enumerable = (global::System.Collections.IEnumerable)e.NewValue;
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider comboBoxItemsProvider = (global::Infragistics.Windows.Editors.ComboBoxItemsProvider)dependencyObject;
			global::System.Collections.IEnumerable enumerable2 = (global::System.Collections.IEnumerable)e.OldValue;
			global::System.ComponentModel.IBindingList bindingList = enumerable2 as global::System.ComponentModel.IBindingList;
			if (bindingList != null)
			{
				bindingList.ListChanged -= comboBoxItemsProvider.OnItemsSource_ListChanged;
			}
			global::System.ComponentModel.IBindingList bindingList2 = enumerable as global::System.ComponentModel.IBindingList;
			if (bindingList2 != null)
			{
				bindingList2.ListChanged += comboBoxItemsProvider.OnItemsSource_ListChanged;
			}
			comboBoxItemsProvider._comboBox.ItemsSource = enumerable;
			comboBoxItemsProvider.DirtyCachedItems();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003B97 File Offset: 0x00001D97
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemsSource()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemsSourceProperty, this);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003BA4 File Offset: 0x00001DA4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemsSource()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemsSourceProperty);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003BB1 File Offset: 0x00001DB1
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00003BB9 File Offset: 0x00001DB9
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.IComparer ValueComparer
		{
			get
			{
				return this._cachedValueComparer;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ValueComparerProperty, value);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003BC8 File Offset: 0x00001DC8
		private static void OnValueComparerChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider comboBoxItemsProvider = (global::Infragistics.Windows.Editors.ComboBoxItemsProvider)dependencyObject;
			comboBoxItemsProvider._cachedValueComparer = (global::System.Collections.IComparer)e.NewValue;
			comboBoxItemsProvider.DirtyCachedItems();
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00003BF4 File Offset: 0x00001DF4
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00003C06 File Offset: 0x00001E06
		[global::System.ComponentModel.Bindable(true)]
		public string ValuePath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ValuePathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ValuePathProperty, value);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003C14 File Offset: 0x00001E14
		private static void OnValuePathChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			string selectedValuePath = (string)e.NewValue;
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider comboBoxItemsProvider = (global::Infragistics.Windows.Editors.ComboBoxItemsProvider)dependencyObject;
			comboBoxItemsProvider._comboBox.SelectedValuePath = selectedValuePath;
			comboBoxItemsProvider.DirtyCachedItems();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003C47 File Offset: 0x00001E47
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeValuePath()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ValuePathProperty, this);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003C54 File Offset: 0x00001E54
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetValuePath()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ValuePathProperty);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003C61 File Offset: 0x00001E61
		private void DirtyCachedItems()
		{
			if (this._cachedInfo != null)
			{
				this._cachedInfo.Dispose();
				this._cachedInfo = null;
			}
			base.SetValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.VersionProperty, 1 + (int)base.GetValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.VersionProperty));
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003CA0 File Offset: 0x00001EA0
		private bool FindItemHolderFromDataValueHelper(object dataValue, int preferredIndex, out global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder)
		{
			itemHolder = null;
			if (!this.VerifyCachedItems())
			{
				return false;
			}
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider.CachedInfo cachedInfo = this._cachedInfo;
			bool flag = cachedInfo._canUseBinarySearch;
			if (flag && null != cachedInfo._compareType && !cachedInfo._compareDataValuesAsText && dataValue != null && global::System.DBNull.Value != dataValue)
			{
				object obj = global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.ConvertDataValue(cachedInfo, dataValue, cachedInfo._compareType);
				if (obj != null)
				{
					dataValue = obj;
				}
				else
				{
					flag = false;
				}
			}
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder[] items = cachedInfo._items;
			if (preferredIndex >= 0 && preferredIndex < items.Length)
			{
				global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder2 = items[preferredIndex];
				if (global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.DataValueEquals(cachedInfo, dataValue, itemHolder2._dataValue))
				{
					itemHolder = itemHolder2;
					return true;
				}
			}
			if (flag)
			{
				int[] dataValueIndex = cachedInfo._dataValueIndex;
				int i = 0;
				int num = items.Length - 1;
				while (i <= num)
				{
					int num2 = (i + num) / 2;
					global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder3 = items[dataValueIndex[num2]];
					int num3 = global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.CompareHelper(cachedInfo, dataValue, itemHolder3._dataValue, cachedInfo._compareDataValuesAsText);
					if (num3 == 0)
					{
						itemHolder = itemHolder3;
						break;
					}
					if (num3 < 0)
					{
						num = num2 - 1;
					}
					else
					{
						i = num2 + 1;
					}
				}
			}
			else
			{
				foreach (global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder4 in items)
				{
					if (global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.DataValueEquals(cachedInfo, dataValue, itemHolder4._dataValue))
					{
						itemHolder = itemHolder4;
						break;
					}
				}
			}
			return true;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003DC4 File Offset: 0x00001FC4
		private bool FindItemHolderFromDisplayTextHelper(string displayText, bool partial, int startIndex, int preferredIndex, out global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder)
		{
			itemHolder = null;
			if (!this.VerifyCachedItems())
			{
				return false;
			}
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder[] items = this._cachedInfo._items;
			if (preferredIndex >= startIndex && preferredIndex < items.Length)
			{
				global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder2 = items[preferredIndex];
				if (global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.DisplayTextEquals(this, displayText, itemHolder2._displayText, partial))
				{
					itemHolder = itemHolder2;
					return true;
				}
			}
			if (this._cachedInfo._canUseBinarySearch)
			{
				int[] displayTextIndex = this._cachedInfo._displayTextIndex;
				int i = startIndex;
				int num = items.Length - 1;
				int j = (i + num) / 2;
				while (i <= num)
				{
					j = (i + num) / 2;
					global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder3 = items[displayTextIndex[j]];
					int num2 = global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.CompareDisplayText(this, displayText, itemHolder3._displayText);
					if (num2 == 0)
					{
						itemHolder = itemHolder3;
						break;
					}
					if (num2 < 0)
					{
						num = j - 1;
					}
					else
					{
						i = j + 1;
					}
				}
				if (itemHolder == null && partial)
				{
					while (j < items.Length)
					{
						global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder4 = items[displayTextIndex[j]];
						if (global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.DisplayTextEquals(this, displayText, itemHolder4._displayText, true))
						{
							itemHolder = itemHolder4;
							break;
						}
						j++;
					}
				}
			}
			else
			{
				for (int k = startIndex; k < items.Length; k++)
				{
					global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder5 = items[k];
					if (global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.DisplayTextEquals(this, displayText, itemHolder5._displayText, partial))
					{
						itemHolder = itemHolder5;
						break;
					}
				}
			}
			return true;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003EF0 File Offset: 0x000020F0
		internal int FindListItemFromDisplayTextHelper(string displayText, bool partial, int startIndex, int preferredIndex, out object foundListItem)
		{
			global::System.Windows.Controls.ItemCollection items = this._comboBox.Items;
			if (preferredIndex >= startIndex && preferredIndex < items.Count)
			{
				object obj = items[preferredIndex];
				string displayTextHelper = this.GetDisplayTextHelper(obj, preferredIndex);
				if (global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.DisplayTextEquals(this, displayText, displayTextHelper, partial))
				{
					foundListItem = obj;
					return preferredIndex;
				}
			}
			for (int i = startIndex; i < items.Count; i++)
			{
				object obj2 = items[i];
				string displayTextHelper2 = this.GetDisplayTextHelper(obj2, i);
				if (global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.DisplayTextEquals(this, displayText, displayTextHelper2, partial))
				{
					foundListItem = obj2;
					return i;
				}
			}
			foundListItem = null;
			return -1;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003F7C File Offset: 0x0000217C
		internal int FindListItemFromDisplayText(string displayText, bool partial, int startIndex, int preferredIndex, out object foundListItem)
		{
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder;
			if (!this.FindItemHolderFromDisplayTextHelper(displayText, partial, startIndex, preferredIndex, out itemHolder))
			{
				return this.FindListItemFromDisplayTextHelper(displayText, partial, startIndex, preferredIndex, out foundListItem);
			}
			if (itemHolder != null)
			{
				foundListItem = itemHolder._item;
				return itemHolder._itemIndex;
			}
			foundListItem = null;
			return -1;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003FC0 File Offset: 0x000021C0
		internal int FindListItemFromDataValueHelper(object dataValue, int preferredIndex, out object foundListItem)
		{
			if (preferredIndex >= 0 && preferredIndex < this._comboBox.Items.Count)
			{
				this._comboBox.SelectedIndex = preferredIndex;
				if (this._comboBox.SelectedIndex == preferredIndex && global::Infragistics.Windows.Editors.Utils.AreEqual(dataValue, this._comboBox.SelectedValue))
				{
					foundListItem = this._comboBox.Items[preferredIndex];
					return preferredIndex;
				}
			}
			this._comboBox.SelectedValue = dataValue;
			int selectedIndex = this._comboBox.SelectedIndex;
			if (selectedIndex >= 0)
			{
				foundListItem = this._comboBox.Items[selectedIndex];
				return selectedIndex;
			}
			foundListItem = null;
			return -1;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000405C File Offset: 0x0000225C
		internal int FindListItemFromDataValue(object dataValue, int preferredIndex, out object foundListItem)
		{
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder;
			if (!this.FindItemHolderFromDataValueHelper(dataValue, preferredIndex, out itemHolder))
			{
				return this.FindListItemFromDataValueHelper(dataValue, preferredIndex, out foundListItem);
			}
			if (itemHolder != null)
			{
				foundListItem = itemHolder._item;
				return itemHolder._itemIndex;
			}
			foundListItem = null;
			return -1;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004098 File Offset: 0x00002298
		private object GetDataValueHelper(object item, int itemIndexIfKnown)
		{
			global::Infragistics.Windows.Editors.ComboBoxDataItem comboBoxDataItem = item as global::Infragistics.Windows.Editors.ComboBoxDataItem;
			if (comboBoxDataItem != null)
			{
				return comboBoxDataItem.Value;
			}
			if (this._cachedItemMemberProvider != null)
			{
				return this._cachedItemMemberProvider.GetValue(item);
			}
			if (itemIndexIfKnown >= 0)
			{
				this._comboBox.SelectedIndex = itemIndexIfKnown;
			}
			else
			{
				this._comboBox.SelectedItem = item;
			}
			return this._comboBox.SelectedValue;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000040F4 File Offset: 0x000022F4
		internal object GetDataValue(object listObject, int itemIndexIfKnown)
		{
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder;
			if (this.VerifyCachedItems() && this._cachedInfo._itemsTable.TryGetValue(global::Infragistics.Windows.Editors.Utils.DictionaryKey(listObject), out itemHolder))
			{
				return itemHolder._dataValue;
			}
			return this.GetDataValueHelper(listObject, itemIndexIfKnown);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004134 File Offset: 0x00002334
		internal bool GetDataValueFromDisplayText(string displayText, bool partialMatch, int preferredIndex, out object dataValue)
		{
			object listObject;
			int num = this.FindListItemFromDisplayText(displayText, partialMatch, 0, preferredIndex, out listObject);
			if (num >= 0)
			{
				dataValue = this.GetDataValue(listObject, num);
				return true;
			}
			dataValue = null;
			return false;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004164 File Offset: 0x00002364
		private string GetDisplayTextHelper(object item, int itemIndexIfKnown)
		{
			global::Infragistics.Windows.Editors.ComboBoxDataItem comboBoxDataItem = item as global::Infragistics.Windows.Editors.ComboBoxDataItem;
			if (comboBoxDataItem != null)
			{
				return comboBoxDataItem.DisplayText;
			}
			if (this._cachedItemMemberProvider != null)
			{
				return this._cachedItemMemberProvider.GetDisplayText(item);
			}
			if (itemIndexIfKnown >= 0)
			{
				this._comboBox.SelectedIndex = itemIndexIfKnown;
			}
			else
			{
				this._comboBox.SelectedItem = item;
			}
			return this._comboBox.Text;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000041C0 File Offset: 0x000023C0
		internal string GetDisplayText(object listObject, int itemIndexIfKnown)
		{
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder;
			if (this.VerifyCachedItems() && this._cachedInfo._itemsTable.TryGetValue(global::Infragistics.Windows.Editors.Utils.DictionaryKey(listObject), out itemHolder))
			{
				return itemHolder._displayText;
			}
			return this.GetDisplayTextHelper(listObject, itemIndexIfKnown);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004200 File Offset: 0x00002400
		internal string GetDisplayTextFromDataValue(object dataValue, int preferredIndex)
		{
			object listObject;
			int num = this.FindListItemFromDataValue(dataValue, preferredIndex, out listObject);
			if (num >= 0)
			{
				return this.GetDisplayText(listObject, num);
			}
			if (dataValue == null)
			{
				return string.Empty;
			}
			return dataValue.ToString();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004234 File Offset: 0x00002434
		internal object GetItemAtIndex(int index)
		{
			if (!this.VerifyCachedItems())
			{
				if (index >= 0 && index < this._comboBox.Items.Count)
				{
					this._comboBox.SelectedIndex = index;
					if (this._comboBox.SelectedIndex == index)
					{
						return this._comboBox.SelectedItem;
					}
				}
				return null;
			}
			if (index >= 0 && index < this._cachedInfo._items.Length)
			{
				global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder = this._cachedInfo._items[index];
				return itemHolder._item;
			}
			return null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000042B4 File Offset: 0x000024B4
		internal int GetItemIndex(object listObject)
		{
			if (!this.VerifyCachedItems())
			{
				this._comboBox.SelectedItem = listObject;
				return this._comboBox.SelectedIndex;
			}
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder;
			this._cachedInfo._itemsTable.TryGetValue(global::Infragistics.Windows.Editors.Utils.DictionaryKey(listObject), out itemHolder);
			if (itemHolder == null)
			{
				return -1;
			}
			return itemHolder._itemIndex;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004308 File Offset: 0x00002508
		private bool VerifyCachedItems()
		{
			if (this._cachedInfo != null)
			{
				return null != this._cachedInfo._itemsTable;
			}
			this._cachedInfo = new global::Infragistics.Windows.Editors.ComboBoxItemsProvider.CachedInfo(this);
			global::System.Windows.Controls.ItemCollection items = this._comboBox.Items;
			global::System.Collections.Generic.List<global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder>(items.Count);
			bool flag = true;
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider.MemberPathEvaluator memberPathEvaluator = (this._cachedItemMemberProvider != null) ? null : new global::Infragistics.Windows.Editors.ComboBoxItemsProvider.MemberPathEvaluator(this.ValuePath);
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider.MemberPathEvaluator memberPathEvaluator2 = (this._cachedItemMemberProvider != null) ? null : new global::Infragistics.Windows.Editors.ComboBoxItemsProvider.MemberPathEvaluator(this.DisplayMemberPath);
			global::System.Type type = null;
			bool flag2 = false;
			int i = 0;
			int count = items.Count;
			while (i < count)
			{
				object obj = items[i];
				if (obj is global::System.Xml.XmlNode)
				{
					flag = false;
					memberPathEvaluator2 = (memberPathEvaluator = null);
				}
				if (obj is global::Infragistics.Windows.Editors.ComboBoxDataItem)
				{
					memberPathEvaluator2 = (memberPathEvaluator = null);
				}
				object dataValueHelper;
				if (memberPathEvaluator == null || !memberPathEvaluator.GetMemberValue(obj, out dataValueHelper))
				{
					dataValueHelper = this.GetDataValueHelper(obj, i);
				}
				string displayTextHelper;
				if (memberPathEvaluator2 == null || !memberPathEvaluator2.GetMemberValueAsString(obj, out displayTextHelper))
				{
					displayTextHelper = this.GetDisplayTextHelper(obj, i);
				}
				global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder item = new global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder(obj, i, dataValueHelper, displayTextHelper);
				list.Add(item);
				if (dataValueHelper != null && global::System.DBNull.Value != dataValueHelper)
				{
					if (!(dataValueHelper is global::System.IComparable))
					{
						flag = false;
					}
					global::System.Type type2 = dataValueHelper.GetType();
					if (type != type2 && null != type)
					{
						flag2 = true;
					}
					type = type2;
				}
				i++;
			}
			global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder[] array = list.ToArray();
			this._cachedInfo._items = array;
			this._cachedInfo._compareDataValuesAsText = flag2;
			this._cachedInfo._compareType = (flag2 ? typeof(string) : type);
			int[] array2 = null;
			int[] array3 = null;
			if (flag)
			{
				array2 = new int[array.Length];
				array3 = new int[array.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = j;
					array3[j] = j;
				}
				try
				{
					global::Infragistics.CoreUtilities.SortMergeGeneric<int>(array2, new global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer(this._cachedInfo, false));
					global::Infragistics.CoreUtilities.SortMergeGeneric<int>(array3, new global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer(this._cachedInfo, true));
				}
				catch
				{
					flag = false;
				}
			}
			global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder> dictionary = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder>(array.Length);
			foreach (global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder in array)
			{
				dictionary[global::Infragistics.Windows.Editors.Utils.DictionaryKey(itemHolder._item)] = itemHolder;
			}
			this._cachedInfo._dataValueIndex = array2;
			this._cachedInfo._displayTextIndex = array3;
			this._cachedInfo._itemsTable = dictionary;
			this._cachedInfo._canUseBinarySearch = flag;
			this._cachedInfo.HookUnhookDataItems(true);
			return true;
		}

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Controls.ComboBox _comboBox;

		// Token: 0x0400000F RID: 15
		private global::Infragistics.Windows.Editors.ComboBoxItemsProvider.CachedInfo _cachedInfo;

		// Token: 0x04000010 RID: 16
		private global::System.Collections.IComparer _cachedValueComparer;

		// Token: 0x04000011 RID: 17
		private global::System.Collections.IComparer _cachedDisplayTextComparer;

		// Token: 0x04000012 RID: 18
		private global::Infragistics.Windows.Editors.IItemMemberProvider _cachedItemMemberProvider;

		// Token: 0x04000013 RID: 19
		internal static readonly global::System.Windows.DependencyProperty VersionProperty = global::System.Windows.DependencyProperty.Register("Version", typeof(int), typeof(global::Infragistics.Windows.Editors.ComboBoxItemsProvider), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000014 RID: 20
		public static readonly global::System.Windows.DependencyProperty DisplayMemberPathProperty = global::System.Windows.DependencyProperty.Register("DisplayMemberPath", typeof(string), typeof(global::Infragistics.Windows.Editors.ComboBoxItemsProvider), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.OnDisplayMemberPathChanged)));

		// Token: 0x04000015 RID: 21
		public static readonly global::System.Windows.DependencyProperty DisplayTextComparerProperty = global::System.Windows.DependencyProperty.Register("DisplayTextComparer", typeof(global::System.Collections.IComparer), typeof(global::Infragistics.Windows.Editors.ComboBoxItemsProvider), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.OnDisplayTextComparerChanged), null));

		// Token: 0x04000016 RID: 22
		public static readonly global::System.Windows.DependencyProperty ItemMemberProviderProperty = global::System.Windows.DependencyProperty.Register("ItemMemberProvider", typeof(global::Infragistics.Windows.Editors.IItemMemberProvider), typeof(global::Infragistics.Windows.Editors.ComboBoxItemsProvider), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.OnItemMemberProviderChanged)));

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Controls.ItemCollection _cachedItems;

		// Token: 0x04000018 RID: 24
		public static readonly global::System.Windows.DependencyProperty ItemsSourceProperty = global::System.Windows.DependencyProperty.Register("ItemsSource", typeof(global::System.Collections.IEnumerable), typeof(global::Infragistics.Windows.Editors.ComboBoxItemsProvider), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.OnItemsSourceChanged)));

		// Token: 0x04000019 RID: 25
		public static readonly global::System.Windows.DependencyProperty ValueComparerProperty = global::System.Windows.DependencyProperty.Register("ValueComparer", typeof(global::System.Collections.IComparer), typeof(global::Infragistics.Windows.Editors.ComboBoxItemsProvider), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.OnValueComparerChanged), null));

		// Token: 0x0400001A RID: 26
		public static readonly global::System.Windows.DependencyProperty ValuePathProperty = global::System.Windows.DependencyProperty.Register("ValuePath", typeof(string), typeof(global::Infragistics.Windows.Editors.ComboBoxItemsProvider), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.OnValuePathChanged)));

		// Token: 0x02000014 RID: 20
		internal class ComboEditorDefaultConverter : global::Infragistics.Windows.Editors.ValueEditorDefaultConverter
		{
			// Token: 0x060000C6 RID: 198 RVA: 0x000048B5 File Offset: 0x00002AB5
			protected ComboEditorDefaultConverter(bool isDisplayTextConverter) : base(isDisplayTextConverter)
			{
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000C7 RID: 199 RVA: 0x000048BE File Offset: 0x00002ABE
			public static global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter Converter
			{
				get
				{
					if (global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter._converter == null)
					{
						global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter._converter = new global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter(false);
					}
					return global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter._converter;
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x000048D7 File Offset: 0x00002AD7
			public static global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter DisplayTextConverter
			{
				get
				{
					if (global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter._displayTextConverter == null)
					{
						global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter._displayTextConverter = new global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter(true);
					}
					return global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter._displayTextConverter;
				}
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x000048F0 File Offset: 0x00002AF0
			protected override object ConvertHelper(bool convertingBack, object value, global::System.Type targetType, global::Infragistics.Windows.Editors.ValueEditor valueEditor, global::System.IFormatProvider formatProvider, string format)
			{
				global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = valueEditor as global::Infragistics.Windows.Editors.XamComboEditor;
				global::Infragistics.Windows.Editors.ComboBoxItemsProvider comboBoxItemsProvider = (xamComboEditor != null) ? xamComboEditor.ItemsProvider : null;
				if (comboBoxItemsProvider != null)
				{
					int selectedIndex = xamComboEditor.SelectedIndex;
					if (!convertingBack)
					{
						string text = comboBoxItemsProvider.GetDisplayTextFromDataValue(value, selectedIndex);
						if (this._isDisplayTextConverter && string.IsNullOrEmpty(text) && (value == null || global::System.DBNull.Value == value))
						{
							text = xamComboEditor.NullText;
						}
						return text;
					}
					string text2 = value as string;
					if (text2 == null)
					{
						text2 = ((value != null) ? value.ToString() : string.Empty);
					}
					object obj;
					if (comboBoxItemsProvider.GetDataValueFromDisplayText(text2, false, selectedIndex, out obj))
					{
						if (obj != null && !targetType.IsInstanceOfType(obj))
						{
							obj = global::Infragistics.CoreUtilities.ConvertDataValue(obj, targetType, formatProvider, format);
						}
						return obj;
					}
				}
				return base.ConvertHelper(convertingBack, value, targetType, valueEditor, formatProvider, format);
			}

			// Token: 0x0400001E RID: 30
			private static global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter _converter;

			// Token: 0x0400001F RID: 31
			private static global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ComboEditorDefaultConverter _displayTextConverter;
		}

		// Token: 0x02000015 RID: 21
		private class ItemHolder
		{
			// Token: 0x060000CA RID: 202 RVA: 0x000049A9 File Offset: 0x00002BA9
			internal ItemHolder(object item, int itemIndex, object dataValue, string displayText)
			{
				this._item = item;
				this._dataValue = dataValue;
				this._displayText = displayText;
				this._itemIndex = itemIndex;
			}

			// Token: 0x060000CB RID: 203 RVA: 0x000049D0 File Offset: 0x00002BD0
			internal void HookUnhookDataItem(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.CachedInfo cacheInfo, bool hook)
			{
				global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = this._item as global::System.ComponentModel.INotifyPropertyChanged;
				if (notifyPropertyChanged != null)
				{
					if (hook)
					{
						notifyPropertyChanged.PropertyChanged += cacheInfo._itemPropChangeHandler;
						return;
					}
					notifyPropertyChanged.PropertyChanged -= cacheInfo._itemPropChangeHandler;
				}
			}

			// Token: 0x04000020 RID: 32
			internal object _item;

			// Token: 0x04000021 RID: 33
			internal object _dataValue;

			// Token: 0x04000022 RID: 34
			internal string _displayText;

			// Token: 0x04000023 RID: 35
			internal int _itemIndex;
		}

		// Token: 0x02000016 RID: 22
		private class MemberPathEvaluator
		{
			// Token: 0x060000CC RID: 204 RVA: 0x00004A08 File Offset: 0x00002C08
			public MemberPathEvaluator(string memberPath)
			{
				this._memberPath = memberPath;
				this._isMemberPathEmpty = string.IsNullOrEmpty(memberPath);
			}

			// Token: 0x060000CD RID: 205 RVA: 0x00004A24 File Offset: 0x00002C24
			public bool GetMemberValue(object dataItem, out object val)
			{
				val = null;
				if (this._isMemberPathEmpty)
				{
					val = dataItem;
					return true;
				}
				if (dataItem != null)
				{
					if (null == this._componentType || !this._componentType.IsInstanceOfType(dataItem))
					{
						this._componentType = dataItem.GetType();
						try
						{
							global::System.ComponentModel.PropertyDescriptorCollection properties = global::System.ComponentModel.TypeDescriptor.GetProperties(this._componentType);
							this._pd = ((properties != null) ? properties.Find(this._memberPath, false) : null);
						}
						catch
						{
							this._pd = null;
						}
					}
					if (this._pd != null)
					{
						try
						{
							val = this._pd.GetValue(dataItem);
							return true;
						}
						catch
						{
							this._pd = null;
						}
						return false;
					}
				}
				return false;
			}

			// Token: 0x060000CE RID: 206 RVA: 0x00004AE0 File Offset: 0x00002CE0
			public bool GetMemberValueAsString(object dataItem, out string val)
			{
				val = null;
				object obj;
				bool memberValue = this.GetMemberValue(dataItem, out obj);
				if (memberValue)
				{
					val = ((obj == null || obj is string) ? ((string)obj) : obj.ToString());
				}
				return memberValue;
			}

			// Token: 0x04000024 RID: 36
			private string _memberPath;

			// Token: 0x04000025 RID: 37
			private bool _isMemberPathEmpty;

			// Token: 0x04000026 RID: 38
			private global::System.Type _componentType;

			// Token: 0x04000027 RID: 39
			private global::System.ComponentModel.PropertyDescriptor _pd;
		}

		// Token: 0x02000017 RID: 23
		private class CachedInfo
		{
			// Token: 0x060000CF RID: 207 RVA: 0x00004B19 File Offset: 0x00002D19
			internal CachedInfo(global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider)
			{
				this._itemsProvider = itemsProvider;
				this._itemPropChangeHandler = new global::System.ComponentModel.PropertyChangedEventHandler(this.OnDataItemPropertyChanged);
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x00004B3A File Offset: 0x00002D3A
			private void OnDataItemPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs args)
			{
				if (this == this._itemsProvider._cachedInfo)
				{
					this._itemsProvider.DirtyCachedItems();
				}
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x00004B55 File Offset: 0x00002D55
			internal void Dispose()
			{
				this.HookUnhookDataItems(false);
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x00004B60 File Offset: 0x00002D60
			internal void HookUnhookDataItems(bool hook)
			{
				if (this._items != null)
				{
					foreach (global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder in this._items)
					{
						itemHolder.HookUnhookDataItem(this, hook);
					}
				}
			}

			// Token: 0x04000028 RID: 40
			internal global::Infragistics.Windows.Editors.ComboBoxItemsProvider _itemsProvider;

			// Token: 0x04000029 RID: 41
			internal global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder[] _items;

			// Token: 0x0400002A RID: 42
			internal global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder> _itemsTable;

			// Token: 0x0400002B RID: 43
			internal int[] _displayTextIndex;

			// Token: 0x0400002C RID: 44
			internal int[] _dataValueIndex;

			// Token: 0x0400002D RID: 45
			internal bool _compareDataValuesAsText;

			// Token: 0x0400002E RID: 46
			internal bool _canUseBinarySearch;

			// Token: 0x0400002F RID: 47
			internal global::System.Type _compareType;

			// Token: 0x04000030 RID: 48
			internal readonly global::System.ComponentModel.PropertyChangedEventHandler _itemPropChangeHandler;
		}

		// Token: 0x02000018 RID: 24
		private class IndexComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<int>
		{
			// Token: 0x060000D3 RID: 211 RVA: 0x00004B96 File Offset: 0x00002D96
			public IndexComparer(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.CachedInfo cachedInfo, bool compareByDisplayText)
			{
				this._cachedInfo = cachedInfo;
				this._items = cachedInfo._items;
				this._compareByDisplayText = compareByDisplayText;
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x00004BB8 File Offset: 0x00002DB8
			public int Compare(object xObj, object yObj)
			{
				int x = (int)xObj;
				int y = (int)yObj;
				return this.Compare(x, y);
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x00004BDC File Offset: 0x00002DDC
			public int Compare(int x, int y)
			{
				global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder = this._items[x];
				global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder itemHolder2 = this._items[y];
				if (this._compareByDisplayText)
				{
					return global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.CompareDisplayText(this._cachedInfo._itemsProvider, itemHolder._displayText, itemHolder2._displayText);
				}
				return global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.CompareHelper(this._cachedInfo, itemHolder._dataValue, itemHolder2._dataValue, this._cachedInfo._compareDataValuesAsText);
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x00004C44 File Offset: 0x00002E44
			internal static int CompareHelper(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.CachedInfo cacheInfo, object x, object y, bool compareAsText)
			{
				global::System.Collections.IComparer valueComparer = cacheInfo._itemsProvider.ValueComparer;
				if (valueComparer != null)
				{
					return valueComparer.Compare(x, y);
				}
				if (x == null || global::System.DBNull.Value == x)
				{
					if (y == null || global::System.DBNull.Value == y)
					{
						return 0;
					}
					return -1;
				}
				else
				{
					if (y == null || global::System.DBNull.Value == y)
					{
						return 1;
					}
					if (compareAsText)
					{
						string strA = x.ToString();
						string strB = y.ToString();
						return string.CompareOrdinal(strA, strB);
					}
					return global::System.Collections.Generic.Comparer<object>.Default.Compare(x, y);
				}
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x00004CB8 File Offset: 0x00002EB8
			public static int CompareDisplayText(global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider, string x, string y)
			{
				global::System.Collections.IComparer displayTextComparer = itemsProvider.DisplayTextComparer;
				if (displayTextComparer != null)
				{
					return displayTextComparer.Compare(x, y);
				}
				return string.Compare(x, y, true, global::System.Globalization.CultureInfo.CurrentCulture);
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x00004CE5 File Offset: 0x00002EE5
			public static object ConvertDataValue(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.CachedInfo cacheInfo, object value, global::System.Type targetType)
			{
				if (targetType == typeof(string) && value != null)
				{
					return value.ToString();
				}
				return global::Infragistics.CoreUtilities.ConvertDataValue(value, targetType, null, null);
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x00004D0C File Offset: 0x00002F0C
			public static bool DataValueEquals(global::Infragistics.Windows.Editors.ComboBoxItemsProvider.CachedInfo cacheInfo, object x, object y)
			{
				global::System.Collections.IComparer valueComparer = cacheInfo._itemsProvider.ValueComparer;
				if (valueComparer != null)
				{
					return 0 == valueComparer.Compare(x, y);
				}
				if (x != null && y != null && x.GetType() == y.GetType())
				{
					return object.Equals(x, y);
				}
				return 0 == global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.CompareHelper(cacheInfo, x, y, true);
			}

			// Token: 0x060000DA RID: 218 RVA: 0x00004D61 File Offset: 0x00002F61
			public static bool DisplayTextEquals(global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider, string x, string y)
			{
				return 0 == global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.CompareDisplayText(itemsProvider, x, y);
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00004D6E File Offset: 0x00002F6E
			public static bool DisplayTextEquals(global::Infragistics.Windows.Editors.ComboBoxItemsProvider itemsProvider, string searchText, string overallText, bool partial)
			{
				if (partial)
				{
					if (searchText.Length > overallText.Length)
					{
						return false;
					}
					overallText = overallText.Substring(0, searchText.Length);
				}
				return global::Infragistics.Windows.Editors.ComboBoxItemsProvider.IndexComparer.DisplayTextEquals(itemsProvider, searchText, overallText);
			}

			// Token: 0x04000031 RID: 49
			private global::Infragistics.Windows.Editors.ComboBoxItemsProvider.CachedInfo _cachedInfo;

			// Token: 0x04000032 RID: 50
			private bool _compareByDisplayText;

			// Token: 0x04000033 RID: 51
			private global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemHolder[] _items;
		}
	}
}
