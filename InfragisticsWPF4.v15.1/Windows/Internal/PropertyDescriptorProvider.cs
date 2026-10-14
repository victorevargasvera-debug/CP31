using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001F5 RID: 501
	public abstract class PropertyDescriptorProvider
	{
		// Token: 0x060012C1 RID: 4801 RVA: 0x00042B74 File Offset: 0x00040D74
		protected PropertyDescriptorProvider(object source)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			this._source = source;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00042B91 File Offset: 0x00040D91
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060012C3 RID: 4803 RVA: 0x00042B9C File Offset: 0x00040D9C
		// (remove) Token: 0x060012C4 RID: 4804 RVA: 0x00042BD4 File Offset: 0x00040DD4
		public event global::System.EventHandler<global::Infragistics.Windows.Internal.PropertyDescriptorsChangedEventArgs> PropertyDescriptorsChanged;

		// Token: 0x060012C5 RID: 4805 RVA: 0x00042C09 File Offset: 0x00040E09
		protected virtual void RaisePropertyDescriptorsChangedEvent(global::Infragistics.Windows.Internal.PropertyDescriptorsChangedEventArgs args)
		{
			if (this.PropertyDescriptorsChanged != null)
			{
				this.PropertyDescriptorsChanged(this, args);
			}
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00042C20 File Offset: 0x00040E20
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected void OnPropertiesChangedHelper(global::System.ComponentModel.PropertyDescriptorCollection oldProperties, global::System.ComponentModel.PropertyDescriptorCollection newProperties)
		{
			if (this.PropertyDescriptorsChanged == null)
			{
				return;
			}
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet((oldProperties != null) ? oldProperties.Count : 0, 0.5f, global::Infragistics.Windows.Internal.PropertyDescriptorProvider.PropertyDescriptorComparer.Instance);
			global::Infragistics.Windows.Helpers.HashSet hashSet2 = new global::Infragistics.Windows.Helpers.HashSet((newProperties != null) ? newProperties.Count : 0, 0.5f, global::Infragistics.Windows.Internal.PropertyDescriptorProvider.PropertyDescriptorComparer.Instance);
			if (oldProperties != null)
			{
				hashSet.AddItems(oldProperties);
			}
			if (newProperties != null)
			{
				hashSet2.AddItems(newProperties);
			}
			if (global::Infragistics.Windows.Helpers.HashSet.AreEqual(hashSet, hashSet2))
			{
				return;
			}
			global::Infragistics.Windows.Helpers.HashSet intersection = global::Infragistics.Windows.Helpers.HashSet.GetIntersection(hashSet, hashSet2);
			global::System.ComponentModel.PropertyDescriptor[] array = new global::System.ComponentModel.PropertyDescriptor[hashSet2.Count - intersection.Count];
			global::System.ComponentModel.PropertyDescriptor[] array2 = new global::System.ComponentModel.PropertyDescriptor[hashSet.Count - intersection.Count];
			int num = 0;
			foreach (object obj in hashSet2)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = (global::System.ComponentModel.PropertyDescriptor)obj;
				if (!intersection.Exists(propertyDescriptor))
				{
					array[num] = propertyDescriptor;
					num++;
				}
			}
			num = 0;
			foreach (object obj2 in hashSet)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor2 = (global::System.ComponentModel.PropertyDescriptor)obj2;
				if (!intersection.Exists(propertyDescriptor2))
				{
					array2[num] = propertyDescriptor2;
					num++;
				}
			}
			global::System.Collections.Generic.List<global::System.ComponentModel.PropertyDescriptor> list = new global::System.Collections.Generic.List<global::System.ComponentModel.PropertyDescriptor>();
			foreach (object obj3 in intersection)
			{
				global::System.ComponentModel.PropertyDescriptor item = (global::System.ComponentModel.PropertyDescriptor)obj3;
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor3 = hashSet.GetEquivalentItem(item) as global::System.ComponentModel.PropertyDescriptor;
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor4 = hashSet2.GetEquivalentItem(item) as global::System.ComponentModel.PropertyDescriptor;
				if (!(propertyDescriptor3.PropertyType == propertyDescriptor4.PropertyType) || !(propertyDescriptor3.DisplayName == propertyDescriptor4.DisplayName) || propertyDescriptor3.IsReadOnly != propertyDescriptor4.IsReadOnly || propertyDescriptor3.IsBrowsable != propertyDescriptor4.IsBrowsable)
				{
					list.Add(propertyDescriptor4);
				}
			}
			global::System.ComponentModel.PropertyDescriptor[] array3 = new global::System.ComponentModel.PropertyDescriptor[list.Count];
			list.CopyTo(array3);
			this.RaisePropertyDescriptorsChangedEvent(new global::Infragistics.Windows.Internal.PropertyDescriptorsChangedEventArgs(this, array, array3, array2));
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00042E64 File Offset: 0x00041064
		public virtual object Key
		{
			get
			{
				string name = this.Name;
				if (name != null && name.Length > 0)
				{
					return name;
				}
				return this.Source;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060012C8 RID: 4808
		public abstract string Name { get; }

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00042E8C File Offset: 0x0004108C
		public virtual bool RaisesPropertyDescriptorsChangedEvent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x00042E8F File Offset: 0x0004108F
		public object Source
		{
			get
			{
				return this._source;
			}
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00042E98 File Offset: 0x00041098
		public static global::Infragistics.Windows.Internal.PropertyDescriptorProvider CreateProvider(object item, global::System.Collections.IEnumerable containingList)
		{
			if (item != null)
			{
				global::System.Data.DataRowView dataRowView = item as global::System.Data.DataRowView;
				if (dataRowView != null)
				{
					return new global::Infragistics.Windows.Internal.DataViewPropertyDescriptorProvider(dataRowView.DataView);
				}
				global::System.Data.DataRow dataRow = item as global::System.Data.DataRow;
				if (dataRow != null && (typeof(global::System.Data.DataRow) == dataRow.GetType() || !(containingList is global::System.ComponentModel.ITypedList)))
				{
					return new global::Infragistics.Windows.Internal.DataTablePropertyDescriptorProvider(dataRow.Table);
				}
				global::System.Xml.XmlNode xmlNode = item as global::System.Xml.XmlNode;
				if (xmlNode != null)
				{
					return new global::Infragistics.Windows.Internal.XmlNodePropertyDescriptorProvider(xmlNode);
				}
			}
			else
			{
				global::System.Data.DataView dataView = containingList as global::System.Data.DataView;
				if (dataView != null)
				{
					return new global::Infragistics.Windows.Internal.DataViewPropertyDescriptorProvider(dataView);
				}
				global::System.Data.DataTable dataTable = containingList as global::System.Data.DataTable;
				if (dataTable != null)
				{
					return new global::Infragistics.Windows.Internal.DataTablePropertyDescriptorProvider(dataTable);
				}
			}
			global::System.Type type;
			global::System.ComponentModel.ITypedList typedListFromContainingList = global::Infragistics.Windows.Internal.PropertyDescriptorProvider.GetTypedListFromContainingList(containingList, out type);
			if (typedListFromContainingList != null)
			{
				return new global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider(typedListFromContainingList);
			}
			if (item != null)
			{
				return new global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider(item.GetType());
			}
			if (!(type != null))
			{
				return null;
			}
			if (type == typeof(global::System.Xml.XmlNode))
			{
				return null;
			}
			return new global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider(type);
		}

		// Token: 0x060012CC RID: 4812
		public abstract global::System.ComponentModel.PropertyDescriptorCollection GetProperties();

		// Token: 0x060012CD RID: 4813 RVA: 0x00042F78 File Offset: 0x00041178
		public virtual bool IsCompatibleItem(object item, global::System.Collections.IEnumerable containingList)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			global::System.Data.DataRowView dataRowView = item as global::System.Data.DataRowView;
			if (dataRowView != null)
			{
				global::Infragistics.Windows.Internal.DataViewPropertyDescriptorProvider dataViewPropertyDescriptorProvider = this as global::Infragistics.Windows.Internal.DataViewPropertyDescriptorProvider;
				if (dataViewPropertyDescriptorProvider == null)
				{
					return false;
				}
				global::System.Data.DataView view = dataViewPropertyDescriptorProvider.View;
				return view != null && view.Equals(dataRowView.DataView);
			}
			else
			{
				global::System.Data.DataRow dataRow = item as global::System.Data.DataRow;
				if (dataRow != null)
				{
					global::Infragistics.Windows.Internal.DataTablePropertyDescriptorProvider dataTablePropertyDescriptorProvider = this as global::Infragistics.Windows.Internal.DataTablePropertyDescriptorProvider;
					return dataTablePropertyDescriptorProvider != null && dataTablePropertyDescriptorProvider.Table == dataRow.Table;
				}
				global::System.Xml.XmlNode xmlNode = item as global::System.Xml.XmlNode;
				if (xmlNode != null)
				{
					global::System.Xml.XmlNode xmlNode2 = this._source as global::System.Xml.XmlNode;
					if (xmlNode2 == null)
					{
						return false;
					}
					global::System.Xml.Schema.IXmlSchemaInfo schemaInfo = xmlNode.SchemaInfo;
					global::System.Xml.Schema.IXmlSchemaInfo schemaInfo2 = xmlNode2.SchemaInfo;
					if (schemaInfo != null || schemaInfo2 != null)
					{
						return schemaInfo == schemaInfo2;
					}
					return !(xmlNode.GetType() != xmlNode2.GetType()) && xmlNode.LocalName == xmlNode2.LocalName;
				}
				else
				{
					global::System.ComponentModel.ITypedList typedList = global::Infragistics.Windows.Internal.DataBindingUtilities.GetUnderlyingItemSource(containingList) as global::System.ComponentModel.ITypedList;
					if (typedList != null)
					{
						return typedList == this._source as global::System.ComponentModel.ITypedList;
					}
					return item.GetType() == this._source as global::System.Type;
				}
			}
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0004308C File Offset: 0x0004128C
		public virtual bool IsCompatibleList(global::System.Collections.IEnumerable list)
		{
			if (list == null)
			{
				return false;
			}
			if (this._source is global::System.Type)
			{
				global::System.Type type;
				global::System.ComponentModel.ITypedList typedListFromContainingList = global::Infragistics.Windows.Internal.PropertyDescriptorProvider.GetTypedListFromContainingList(list, out type);
				if (typedListFromContainingList != null)
				{
					return false;
				}
				if (type != null)
				{
					return global::Infragistics.CoreUtilities.GetUnderlyingType(this._source as global::System.Type) == global::Infragistics.CoreUtilities.GetUnderlyingType(type);
				}
				global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider typePropertyDescriptorProvider = this as global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider;
				return typePropertyDescriptorProvider != null && typePropertyDescriptorProvider.Type == typeof(object);
			}
			else
			{
				global::System.Data.DataView dataView;
				if (this._source is global::System.Windows.Controls.ItemCollection)
				{
					dataView = (((global::System.Windows.Controls.ItemCollection)this._source).SourceCollection as global::System.Data.DataView);
				}
				else
				{
					dataView = (this._source as global::System.Data.DataView);
				}
				if (dataView != null)
				{
					global::System.Data.DataView dataView2 = global::Infragistics.Windows.Internal.DataBindingUtilities.GetUnderlyingItemSource(list) as global::System.Data.DataView;
					return dataView2 != null && dataView.Equals(dataView2);
				}
				global::System.Type type2;
				global::System.ComponentModel.ITypedList typedListFromContainingList2 = global::Infragistics.Windows.Internal.PropertyDescriptorProvider.GetTypedListFromContainingList(list, out type2);
				global::System.ComponentModel.ITypedList typedListFromContainingList3 = global::Infragistics.Windows.Internal.PropertyDescriptorProvider.GetTypedListFromContainingList(this._source as global::System.Collections.IEnumerable, out type2);
				return typedListFromContainingList2 != null && typedListFromContainingList3 == typedListFromContainingList2;
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0004317A File Offset: 0x0004137A
		public virtual bool IsCompatibleProvider(global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
		{
			return provider != null && this._source == provider._source;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00043190 File Offset: 0x00041390
		public static global::System.ComponentModel.ITypedList GetTypedListFromContainingList(global::System.Collections.IEnumerable sourceList, out global::System.Type itemType)
		{
			sourceList = global::Infragistics.Windows.Internal.DataBindingUtilities.GetUnderlyingItemSource(sourceList);
			if (sourceList == null)
			{
				itemType = null;
				return null;
			}
			global::System.Type type = sourceList.GetType();
			lock (global::Infragistics.Windows.Internal.PropertyDescriptorProvider.g_ListTypeItemTypeMap)
			{
				global::Infragistics.Windows.Internal.PropertyDescriptorProvider.ListTypeInfo value;
				if (global::Infragistics.Windows.Internal.PropertyDescriptorProvider.g_ListTypeItemTypeMap.TryGetValue(type, out value))
				{
					itemType = value.ItemType;
					if (value.IsKnownType)
					{
						return null;
					}
					return sourceList as global::System.ComponentModel.ITypedList;
				}
				else
				{
					value.ListType = type;
					if (type.FullName == "System.Windows.Forms.BindingSource")
					{
						type = global::Infragistics.Windows.Internal.PropertyDescriptorProvider.GetListTypeFromBindingSource(sourceList);
					}
					global::System.Type[] interfaces = type.GetInterfaces();
					int num = interfaces.Length;
					global::System.Type type2 = null;
					for (int i = 0; i < num; i++)
					{
						global::System.Type type3 = interfaces[i];
						if (type3 != typeof(global::System.Collections.IEnumerable) && type3 != typeof(global::System.Collections.ICollection) && type3 != typeof(global::System.Collections.IList) && type3 != typeof(global::System.ComponentModel.IBindingList) && type3 != typeof(global::System.ComponentModel.IBindingListView) && type3 != typeof(global::System.ComponentModel.ITypedList) && type3.IsGenericType)
						{
							global::System.Type genericTypeDefinition = type3.GetGenericTypeDefinition();
							if (genericTypeDefinition == typeof(global::System.Collections.Generic.IEnumerable<>))
							{
								type2 = type3;
								break;
							}
						}
					}
					if (type2 == null)
					{
						string name = type.Name;
						if (name != null && name.Length > 10 && name.StartsWith("ObjectView") && type.IsGenericType)
						{
							type2 = type;
						}
					}
					if (type2 != null)
					{
						global::System.Type[] genericArguments = type2.GetGenericArguments();
						if (genericArguments != null && genericArguments.Length == 1 && genericArguments[0] != typeof(object))
						{
							value.ItemType = genericArguments[0];
							value.IsKnownType = global::Infragistics.Windows.Internal.DataBindingUtilities.IsKnownType(value.ItemType);
						}
					}
					itemType = value.ItemType;
					global::Infragistics.Windows.Internal.PropertyDescriptorProvider.g_ListTypeItemTypeMap.Add(value.ListType, value);
					if (value.IsKnownType)
					{
						return null;
					}
				}
			}
			return sourceList as global::System.ComponentModel.ITypedList;
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x000433D0 File Offset: 0x000415D0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.Type GetListTypeFromBindingSource(global::System.Collections.IEnumerable containingList)
		{
			global::System.Windows.Forms.BindingSource bindingSource = containingList as global::System.Windows.Forms.BindingSource;
			if (bindingSource != null && bindingSource.List != null)
			{
				return bindingSource.List.GetType();
			}
			return containingList.GetType();
		}

		// Token: 0x040009B3 RID: 2483
		private object _source;

		// Token: 0x040009B5 RID: 2485
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::Infragistics.Windows.Internal.PropertyDescriptorProvider.ListTypeInfo> g_ListTypeItemTypeMap = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Infragistics.Windows.Internal.PropertyDescriptorProvider.ListTypeInfo>();

		// Token: 0x020001F6 RID: 502
		private struct ListTypeInfo
		{
			// Token: 0x040009B6 RID: 2486
			internal global::System.Type ListType;

			// Token: 0x040009B7 RID: 2487
			internal bool IsKnownType;

			// Token: 0x040009B8 RID: 2488
			internal global::System.Type ItemType;
		}

		// Token: 0x020001F7 RID: 503
		internal class PropertyDescriptorComparer : global::System.Collections.IEqualityComparer
		{
			// Token: 0x060012D3 RID: 4819 RVA: 0x00043410 File Offset: 0x00041610
			bool global::System.Collections.IEqualityComparer.Equals(object x, object y)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = x as global::System.ComponentModel.PropertyDescriptor;
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor2 = y as global::System.ComponentModel.PropertyDescriptor;
				return propertyDescriptor == propertyDescriptor2 || (propertyDescriptor != null && propertyDescriptor2 != null && propertyDescriptor.ComponentType == propertyDescriptor2.ComponentType && propertyDescriptor.Name == propertyDescriptor2.Name);
			}

			// Token: 0x060012D4 RID: 4820 RVA: 0x00043460 File Offset: 0x00041660
			int global::System.Collections.IEqualityComparer.GetHashCode(object obj)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = obj as global::System.ComponentModel.PropertyDescriptor;
				if (propertyDescriptor != null)
				{
					return propertyDescriptor.Name.GetHashCode() ^ propertyDescriptor.ComponentType.GetHashCode();
				}
				if (obj != null)
				{
					return obj.GetHashCode();
				}
				return 0;
			}

			// Token: 0x040009B9 RID: 2489
			internal static global::Infragistics.Windows.Internal.PropertyDescriptorProvider.PropertyDescriptorComparer Instance = new global::Infragistics.Windows.Internal.PropertyDescriptorProvider.PropertyDescriptorComparer();
		}
	}
}
