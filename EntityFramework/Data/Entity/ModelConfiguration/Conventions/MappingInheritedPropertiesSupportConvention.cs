using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001A5 RID: 421
	public class MappingInheritedPropertiesSupportConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IDbMappingConvention, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x06001767 RID: 5991 RVA: 0x0003DDA0 File Offset: 0x0003BFA0
		void global::System.Data.Entity.ModelConfiguration.Conventions.IDbMappingConvention.Apply(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping>(databaseMapping, "databaseMapping");
			databaseMapping.EntityContainerMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityContainerMapping ecm) => ecm.EntitySetMappings).Each(delegate(global::System.Data.Entity.Core.Mapping.EntitySetMapping esm)
			{
				foreach (global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping in esm.EntityTypeMappings)
				{
					if (global::System.Data.Entity.ModelConfiguration.Conventions.MappingInheritedPropertiesSupportConvention.RemapsInheritedProperties(databaseMapping, entityTypeMapping) && global::System.Data.Entity.ModelConfiguration.Conventions.MappingInheritedPropertiesSupportConvention.HasBaseWithIsTypeOf(esm, entityTypeMapping.EntityType))
					{
						throw global::System.Data.Entity.Resources.Error.UnsupportedHybridInheritanceMapping(entityTypeMapping.EntityType.Name);
					}
				}
			});
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0003DE0C File Offset: 0x0003C00C
		private static bool RemapsInheritedProperties(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = entityTypeMapping.EntityType.Properties.Except(entityTypeMapping.EntityType.DeclaredProperties).Except(entityTypeMapping.EntityType.GetKeyProperties()).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property = enumerator.Current;
					global::System.Data.Entity.Core.Mapping.MappingFragment fragment = global::System.Data.Entity.ModelConfiguration.Conventions.MappingInheritedPropertiesSupportConvention.GetFragmentForPropertyMapping(entityTypeMapping, property);
					if (fragment != null)
					{
						global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> <>9__1;
						global::System.Func<global::System.Data.Entity.Core.Mapping.EntityTypeMapping, global::System.Data.Entity.Core.Mapping.MappingFragment> <>9__0;
						for (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityTypeMapping.EntityType.BaseType; entityType != null; entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType)
						{
							global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> entityTypeMappings = databaseMapping.GetEntityTypeMappings(entityType);
							global::System.Func<global::System.Data.Entity.Core.Mapping.EntityTypeMapping, global::System.Data.Entity.Core.Mapping.MappingFragment> selector;
							if ((selector = <>9__0) == null)
							{
								selector = (<>9__0 = ((global::System.Data.Entity.Core.Mapping.EntityTypeMapping baseTypeMapping) => global::System.Data.Entity.ModelConfiguration.Conventions.MappingInheritedPropertiesSupportConvention.GetFragmentForPropertyMapping(baseTypeMapping, property)));
							}
							global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment> source = entityTypeMappings.Select(selector);
							global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> predicate;
							if ((predicate = <>9__1) == null)
							{
								predicate = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.MappingFragment baseFragment) => baseFragment != null && baseFragment.Table != fragment.Table));
							}
							if (source.Any(predicate))
							{
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0003DF28 File Offset: 0x0003C128
		private static global::System.Data.Entity.Core.Mapping.MappingFragment GetFragmentForPropertyMapping(global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> <>9__1;
			return entityTypeMapping.MappingFragments.SingleOrDefault(delegate(global::System.Data.Entity.Core.Mapping.MappingFragment tmf)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> columnMappings = tmf.ColumnMappings;
				global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> predicate;
				if ((predicate = <>9__1) == null)
				{
					predicate = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm) => pm.PropertyPath.Last<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() == property));
				}
				return columnMappings.Any(predicate);
			});
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x0003DF5C File Offset: 0x0003C15C
		private static bool HasBaseWithIsTypeOf(global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType baseType;
			for (baseType = entityType.BaseType; baseType != null; baseType = baseType.BaseType)
			{
				if ((from etm in entitySetMapping.EntityTypeMappings
				where etm.EntityType == baseType
				select etm).Any((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => etm.IsHierarchyMapping))
				{
					return true;
				}
			}
			return false;
		}
	}
}
