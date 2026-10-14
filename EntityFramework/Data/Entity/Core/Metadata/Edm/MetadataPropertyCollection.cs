using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004DF RID: 1247
	internal sealed class MetadataPropertyCollection : global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty>
	{
		// Token: 0x06003E0F RID: 15887 RVA: 0x000CD1EC File Offset: 0x000CB3EC
		internal MetadataPropertyCollection(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item) : base(global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.GetSystemMetadataProperties(item))
		{
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x000CD1FA File Offset: 0x000CB3FA
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> GetSystemMetadataProperties(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.GetItemTypeInformation(item.GetType()).GetItemAttributes(item);
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x000CD20D File Offset: 0x000CB40D
		private static global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemTypeInformation GetItemTypeInformation(global::System.Type clrType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection._itemTypeMemoizer.Evaluate(clrType);
		}

		// Token: 0x04001520 RID: 5408
		private static readonly global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Type, global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemTypeInformation> _itemTypeMemoizer = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Type, global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemTypeInformation>((global::System.Type clrType) => new global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemTypeInformation(clrType), null);

		// Token: 0x02000AFC RID: 2812
		private class ItemTypeInformation
		{
			// Token: 0x0600641F RID: 25631 RVA: 0x00159F4C File Offset: 0x0015814C
			internal ItemTypeInformation(global::System.Type clrType)
			{
				this._itemProperties = global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemTypeInformation.GetItemProperties(clrType);
			}

			// Token: 0x06006420 RID: 25632 RVA: 0x00159F60 File Offset: 0x00158160
			internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> GetItemAttributes(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemPropertyInfo itemPropertyInfo in this._itemProperties)
				{
					yield return itemPropertyInfo.GetMetadataProperty(item);
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemPropertyInfo>.Enumerator enumerator = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemPropertyInfo>.Enumerator);
				yield break;
				yield break;
			}

			// Token: 0x06006421 RID: 25633 RVA: 0x00159F78 File Offset: 0x00158178
			private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemPropertyInfo> GetItemProperties(global::System.Type clrType)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemPropertyInfo> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemPropertyInfo>();
				foreach (global::System.Reflection.PropertyInfo propertyInfo in clrType.GetInstanceProperties())
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyAttribute attribute in propertyInfo.GetCustomAttributes(false))
					{
						list.Add(new global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemPropertyInfo(propertyInfo, attribute));
					}
				}
				return list;
			}

			// Token: 0x04002C77 RID: 11383
			private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection.ItemPropertyInfo> _itemProperties;
		}

		// Token: 0x02000AFD RID: 2813
		private class ItemPropertyInfo
		{
			// Token: 0x06006422 RID: 25634 RVA: 0x0015A00C File Offset: 0x0015820C
			internal ItemPropertyInfo(global::System.Reflection.PropertyInfo propertyInfo, global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyAttribute attribute)
			{
				this._propertyInfo = propertyInfo;
				this._attribute = attribute;
			}

			// Token: 0x06006423 RID: 25635 RVA: 0x0015A022 File Offset: 0x00158222
			internal global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty GetMetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(this._propertyInfo.Name, this._attribute.Type, this._attribute.IsCollectionType, new global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyValue(this._propertyInfo, item));
			}

			// Token: 0x04002C78 RID: 11384
			private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyAttribute _attribute;

			// Token: 0x04002C79 RID: 11385
			private readonly global::System.Reflection.PropertyInfo _propertyInfo;
		}
	}
}
