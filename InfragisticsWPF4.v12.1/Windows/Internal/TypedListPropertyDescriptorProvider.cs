using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001CB RID: 459
	public class TypedListPropertyDescriptorProvider : global::Infragistics.Windows.Internal.PropertyDescriptorProvider
	{
		// Token: 0x0600110A RID: 4362 RVA: 0x0003DDFB File Offset: 0x0003BFFB
		public TypedListPropertyDescriptorProvider(global::System.ComponentModel.ITypedList typedList) : base(typedList)
		{
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x0003DE04 File Offset: 0x0003C004
		public global::System.ComponentModel.ITypedList TypedList
		{
			get
			{
				return base.Source as global::System.ComponentModel.ITypedList;
			}
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0003DE11 File Offset: 0x0003C011
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties()
		{
			return this.TypedList.GetItemProperties(null);
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x0003DE1F File Offset: 0x0003C01F
		public override string Name
		{
			get
			{
				return this.TypedList.GetListName(null);
			}
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0003DE2D File Offset: 0x0003C02D
		public global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode GetProviderTree()
		{
			return new global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode(this.TypedList, this, new global::System.Collections.Generic.Dictionary<global::System.ComponentModel.PropertyDescriptorCollection, global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode>(global::Infragistics.Windows.Internal.PropertyDescriptorCollectionComparer.Instance), null, null);
		}

		// Token: 0x020001CC RID: 460
		public class ProviderTreeNode
		{
			// Token: 0x0600110F RID: 4367 RVA: 0x0003DE48 File Offset: 0x0003C048
			internal ProviderTreeNode(global::System.ComponentModel.ITypedList ancestorList, global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider, global::System.Collections.Generic.Dictionary<global::System.ComponentModel.PropertyDescriptorCollection, global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode> nodeMap, global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode parentNode, global::System.ComponentModel.PropertyDescriptor[] listAccessors)
			{
				this._ancestorList = ancestorList;
				this._propertyDescriptorProvider = propertyDescriptorProvider;
				this._parentNode = parentNode;
				this._listAccessors = listAccessors;
				global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode>();
				global::System.ComponentModel.PropertyDescriptorCollection properties = this._propertyDescriptorProvider.GetProperties();
				nodeMap.Add(properties, this);
				foreach (object obj in properties)
				{
					global::System.ComponentModel.PropertyDescriptor propertyDescriptor = (global::System.ComponentModel.PropertyDescriptor)obj;
					global::System.Type propertyType = propertyDescriptor.PropertyType;
					if (!(propertyType == null) && !(propertyType == typeof(string)) && typeof(global::System.Collections.IEnumerable).IsAssignableFrom(propertyType))
					{
						try
						{
							global::System.ComponentModel.PropertyDescriptor[] array = new global::System.ComponentModel.PropertyDescriptor[(listAccessors != null) ? (listAccessors.Length + 1) : 1];
							if (listAccessors != null)
							{
								listAccessors.CopyTo(array, 0);
							}
							array[array.Length - 1] = propertyDescriptor;
							global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNodePropertyDescriptorProvider providerTreeNodePropertyDescriptorProvider = new global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNodePropertyDescriptorProvider(ancestorList, array, propertyDescriptor.Name);
							global::System.ComponentModel.PropertyDescriptorCollection properties2 = providerTreeNodePropertyDescriptorProvider.GetProperties();
							if (!nodeMap.ContainsKey(properties2))
							{
								list.Add(new global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode(ancestorList, providerTreeNodePropertyDescriptorProvider, nodeMap, this, array));
							}
						}
						catch (global::System.Exception ex)
						{
						}
					}
				}
				this._children = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode>(list);
			}

			// Token: 0x170003C5 RID: 965
			// (get) Token: 0x06001110 RID: 4368 RVA: 0x0003DF9C File Offset: 0x0003C19C
			public global::Infragistics.Windows.Internal.PropertyDescriptorProvider PropertyDescriptorProvider
			{
				get
				{
					return this._propertyDescriptorProvider;
				}
			}

			// Token: 0x170003C6 RID: 966
			// (get) Token: 0x06001111 RID: 4369 RVA: 0x0003DFA4 File Offset: 0x0003C1A4
			public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode> ChildNodes
			{
				get
				{
					return this._children;
				}
			}

			// Token: 0x0400087A RID: 2170
			private global::System.ComponentModel.ITypedList _ancestorList;

			// Token: 0x0400087B RID: 2171
			private global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode _parentNode;

			// Token: 0x0400087C RID: 2172
			private global::System.ComponentModel.PropertyDescriptor[] _listAccessors;

			// Token: 0x0400087D RID: 2173
			private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode> _children;

			// Token: 0x0400087E RID: 2174
			private global::Infragistics.Windows.Internal.PropertyDescriptorProvider _propertyDescriptorProvider;
		}

		// Token: 0x020001CD RID: 461
		public class ProviderTreeNodePropertyDescriptorProvider : global::Infragistics.Windows.Internal.PropertyDescriptorProvider
		{
			// Token: 0x06001112 RID: 4370 RVA: 0x0003DFAC File Offset: 0x0003C1AC
			internal ProviderTreeNodePropertyDescriptorProvider(global::System.ComponentModel.ITypedList typedList, global::System.ComponentModel.PropertyDescriptor[] listAccessors, string propName) : base(typedList)
			{
				this._listAccessors = listAccessors;
				this._propName = propName;
			}

			// Token: 0x170003C7 RID: 967
			// (get) Token: 0x06001113 RID: 4371 RVA: 0x0003DFC3 File Offset: 0x0003C1C3
			public global::System.ComponentModel.ITypedList TypedList
			{
				get
				{
					return base.Source as global::System.ComponentModel.ITypedList;
				}
			}

			// Token: 0x06001114 RID: 4372 RVA: 0x0003DFD0 File Offset: 0x0003C1D0
			public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties()
			{
				return this.TypedList.GetItemProperties(this._listAccessors);
			}

			// Token: 0x170003C8 RID: 968
			// (get) Token: 0x06001115 RID: 4373 RVA: 0x0003DFE3 File Offset: 0x0003C1E3
			public override object Key
			{
				get
				{
					return this.TypedList.GetListName(this._listAccessors);
				}
			}

			// Token: 0x170003C9 RID: 969
			// (get) Token: 0x06001116 RID: 4374 RVA: 0x0003DFF6 File Offset: 0x0003C1F6
			public override string Name
			{
				get
				{
					return this._propName;
				}
			}

			// Token: 0x0400087F RID: 2175
			private global::System.ComponentModel.PropertyDescriptor[] _listAccessors;

			// Token: 0x04000880 RID: 2176
			private string _propName;
		}
	}
}
