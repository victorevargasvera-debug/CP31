using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004CE RID: 1230
	internal static class MappingMetadataHelper
	{
		// Token: 0x06003D0E RID: 15630 RVA: 0x000C9300 File Offset: 0x000C7500
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.TypeMapping> GetMappingsForEntitySetAndType(global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingCollection, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType)
		{
			global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping setMapping = global::System.Data.Entity.Core.Metadata.Edm.MappingMetadataHelper.GetEntityContainerMap(mappingCollection, container).GetSetMapping(entitySet.Name);
			if (setMapping != null)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.TypeMapping> typeMappings = setMapping.TypeMappings;
				global::System.Func<global::System.Data.Entity.Core.Mapping.TypeMapping, bool> <>9__0;
				global::System.Func<global::System.Data.Entity.Core.Mapping.TypeMapping, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((global::System.Data.Entity.Core.Mapping.TypeMapping map) => map.Types.Union(map.IsOfTypes).Contains(entityType)));
				}
				foreach (global::System.Data.Entity.Core.Mapping.TypeMapping typeMapping in typeMappings.Where(predicate))
				{
					yield return typeMapping;
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.TypeMapping> enumerator = null;
			}
			yield break;
			yield break;
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x000C9328 File Offset: 0x000C7528
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.TypeMapping> GetMappingsForEntitySetAndSuperTypes(global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingCollection, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase childEntityType)
		{
			return global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndParentTypesOf(childEntityType, true).SelectMany(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType = edmType as global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase;
				if (!edmType.EdmEquals(childEntityType))
				{
					return global::System.Data.Entity.Core.Metadata.Edm.MappingMetadataHelper.GetIsTypeOfMappingsForEntitySetAndType(mappingCollection, container, entitySet, entityType, childEntityType);
				}
				return global::System.Data.Entity.Core.Metadata.Edm.MappingMetadataHelper.GetMappingsForEntitySetAndType(mappingCollection, container, entitySet, entityType);
			}).ToList<global::System.Data.Entity.Core.Mapping.TypeMapping>();
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x000C9379 File Offset: 0x000C7579
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.TypeMapping> GetIsTypeOfMappingsForEntitySetAndType(global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingCollection, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase childEntityType)
		{
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool> <>9__0;
			foreach (global::System.Data.Entity.Core.Mapping.TypeMapping typeMapping in global::System.Data.Entity.Core.Metadata.Edm.MappingMetadataHelper.GetMappingsForEntitySetAndType(mappingCollection, container, entitySet, entityType))
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase> isOfTypes = typeMapping.IsOfTypes;
				global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase parentType) => parentType.IsAssignableFrom(childEntityType)));
				}
				if (isOfTypes.Any(predicate) || typeMapping.Types.Contains(childEntityType))
				{
					yield return typeMapping;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.TypeMapping> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x000C93A6 File Offset: 0x000C75A6
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping> GetModificationFunctionMappingsForEntitySetAndType(global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingCollection, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType)
		{
			global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping = global::System.Data.Entity.Core.Metadata.Edm.MappingMetadataHelper.GetEntityContainerMap(mappingCollection, container).GetSetMapping(entitySet.Name) as global::System.Data.Entity.Core.Mapping.EntitySetMapping;
			if (entitySetMapping != null && entitySetMapping != null)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping> modificationFunctionMappings = entitySetMapping.ModificationFunctionMappings;
				global::System.Func<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping, bool> <>9__0;
				global::System.Func<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping functionMap) => functionMap.EntityType.Equals(entityType)));
				}
				foreach (global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping entityTypeModificationFunctionMapping in modificationFunctionMappings.Where(predicate))
				{
					yield return entityTypeModificationFunctionMapping;
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping> enumerator = null;
			}
			yield break;
			yield break;
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x000C93CC File Offset: 0x000C75CC
		internal static global::System.Data.Entity.Core.Mapping.EntityContainerMapping GetEntityContainerMap(global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingCollection, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer)
		{
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.EntityContainerMapping> items = mappingCollection.GetItems<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>();
			global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping = null;
			foreach (global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping2 in items)
			{
				if (entityContainer.Equals(entityContainerMapping2.EdmEntityContainer) || entityContainer.Equals(entityContainerMapping2.StorageEntityContainer))
				{
					entityContainerMapping = entityContainerMapping2;
					break;
				}
			}
			if (entityContainerMapping == null)
			{
				throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.Mapping_NotFound_EntityContainer(entityContainer.Name));
			}
			return entityContainerMapping;
		}
	}
}
