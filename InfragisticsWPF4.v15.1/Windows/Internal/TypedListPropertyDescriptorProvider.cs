using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001F9 RID: 505
	public class TypedListPropertyDescriptorProvider : global::Infragistics.Windows.Internal.PropertyDescriptorProvider
	{
		// Token: 0x060012DB RID: 4827 RVA: 0x0004353B File Offset: 0x0004173B
		public TypedListPropertyDescriptorProvider(global::System.ComponentModel.ITypedList typedList) : base(typedList)
		{
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x00043544 File Offset: 0x00041744
		public global::System.ComponentModel.ITypedList TypedList
		{
			get
			{
				return base.Source as global::System.ComponentModel.ITypedList;
			}
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00043551 File Offset: 0x00041751
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties()
		{
			return this.TypedList.GetItemProperties(null);
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x0004355F File Offset: 0x0004175F
		public override string Name
		{
			get
			{
				return this.TypedList.GetListName(null);
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0004356D File Offset: 0x0004176D
		public global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode GetProviderTree()
		{
			return new global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode(this.TypedList, this, new global::System.Collections.Generic.Dictionary<global::System.ComponentModel.PropertyDescriptorCollection, global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode>(global::Infragistics.Windows.Internal.PropertyDescriptorCollectionComparer.Instance), null, null);
		}

		// Token: 0x020001FA RID: 506
		public class ProviderTreeNode
		{
			// Token: 0x060012E0 RID: 4832 RVA: 0x00043588 File Offset: 0x00041788
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

			// Token: 0x17000436 RID: 1078
			// (get) Token: 0x060012E1 RID: 4833 RVA: 0x000436DC File Offset: 0x000418DC
			public global::Infragistics.Windows.Internal.PropertyDescriptorProvider PropertyDescriptorProvider
			{
				get
				{
					return this._propertyDescriptorProvider;
				}
			}

			// Token: 0x17000437 RID: 1079
			// (get) Token: 0x060012E2 RID: 4834 RVA: 0x000436E4 File Offset: 0x000418E4
			public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode> ChildNodes
			{
				get
				{
					return this._children;
				}
			}

			// Token: 0x040009BB RID: 2491
			private global::System.ComponentModel.ITypedList _ancestorList;

			// Token: 0x040009BC RID: 2492
			private global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode _parentNode;

			// Token: 0x040009BD RID: 2493
			private global::System.ComponentModel.PropertyDescriptor[] _listAccessors;

			// Token: 0x040009BE RID: 2494
			private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.Internal.TypedListPropertyDescriptorProvider.ProviderTreeNode> _children;

			// Token: 0x040009BF RID: 2495
			private global::Infragistics.Windows.Internal.PropertyDescriptorProvider _propertyDescriptorProvider;
		}

		// Token: 0x020001FB RID: 507
		public class ProviderTreeNodePropertyDescriptorProvider : global::Infragistics.Windows.Internal.PropertyDescriptorProvider
		{
			// Token: 0x060012E3 RID: 4835 RVA: 0x000436EC File Offset: 0x000418EC
			internal ProviderTreeNodePropertyDescriptorProvider(global::System.ComponentModel.ITypedList typedList, global::System.ComponentModel.PropertyDescriptor[] listAccessors, string propName) : base(typedList)
			{
				this._listAccessors = listAccessors;
				this._propName = propName;
			}

			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00043703 File Offset: 0x00041903
			public global::System.ComponentModel.ITypedList TypedList
			{
				get
				{
					return base.Source as global::System.ComponentModel.ITypedList;
				}
			}

			// Token: 0x060012E5 RID: 4837 RVA: 0x00043710 File Offset: 0x00041910
			public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties()
			{
				return this.TypedList.GetItemProperties(this._listAccessors);
			}

			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x060012E6 RID: 4838 RVA: 0x00043723 File Offset: 0x00041923
			public override object Key
			{
				get
				{
					return this.TypedList.GetListName(this._listAccessors);
				}
			}

			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00043736 File Offset: 0x00041936
			public override string Name
			{
				get
				{
					return this._propName;
				}
			}

			// Token: 0x040009C0 RID: 2496
			private global::System.ComponentModel.PropertyDescriptor[] _listAccessors;

			// Token: 0x040009C1 RID: 2497
			private string _propName;
		}
	}
}
