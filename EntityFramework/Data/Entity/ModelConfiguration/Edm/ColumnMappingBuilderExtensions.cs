using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x0200015F RID: 351
	internal static class ColumnMappingBuilderExtensions
	{
		// Token: 0x06001623 RID: 5667 RVA: 0x00039008 File Offset: 0x00037208
		public static void SyncNullabilityCSSpace(this global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder propertyMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = propertyMappingBuilder.PropertyPath.Last<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping = null;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType baseType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)edmProperty.DeclaringType.BaseType;
			if (baseType != null)
			{
				entitySetMapping = global::System.Data.Entity.ModelConfiguration.Edm.ColumnMappingBuilderExtensions.GetEntitySetMapping(databaseMapping, baseType, entitySets);
			}
			while (baseType != null)
			{
				if (toTable == entitySetMapping.EntityTypeMappings.First((global::System.Data.Entity.Core.Mapping.EntityTypeMapping m) => m.EntityType == baseType).GetPrimaryTable())
				{
					return;
				}
				baseType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)baseType.BaseType;
			}
			propertyMappingBuilder.ColumnProperty.Nullable = edmProperty.Nullable;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x000390A8 File Offset: 0x000372A8
		private static global::System.Data.Entity.Core.Mapping.EntitySetMapping GetEntitySetMapping(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType cSpaceEntityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets)
		{
			while (cSpaceEntityType.BaseType != null)
			{
				cSpaceEntityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)cSpaceEntityType.BaseType;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet cSpaceEntitySet = entitySets.First((global::System.Data.Entity.Core.Metadata.Edm.EntitySet s) => s.ElementType == cSpaceEntityType);
			return databaseMapping.EntityContainerMappings.First<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().EntitySetMappings.First((global::System.Data.Entity.Core.Mapping.EntitySetMapping m) => m.EntitySet == cSpaceEntitySet);
		}
	}
}
