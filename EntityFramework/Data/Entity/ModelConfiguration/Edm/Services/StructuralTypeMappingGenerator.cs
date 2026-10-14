using System;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Edm.Services
{
	// Token: 0x02000179 RID: 377
	internal abstract class StructuralTypeMappingGenerator
	{
		// Token: 0x060016DB RID: 5851 RVA: 0x0003BD1C File Offset: 0x00039F1C
		protected StructuralTypeMappingGenerator(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			this._providerManifest = providerManifest;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0003BD2C File Offset: 0x00039F2C
		protected global::System.Data.Entity.Core.Metadata.Edm.EdmProperty MapTableColumn(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, string columnName, bool isInstancePropertyOnDerivedType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(property.UnderlyingPrimitiveType, property.TypeUsage.Facets);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType = this._providerManifest.GetStoreType(edmType);
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(columnName, storeType)
			{
				Nullable = (isInstancePropertyOnDerivedType || property.Nullable)
			};
			if (edmProperty.IsPrimaryKeyColumn)
			{
				edmProperty.Nullable = false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern? storeGeneratedPattern = property.GetStoreGeneratedPattern();
			if (storeGeneratedPattern != null)
			{
				edmProperty.StoreGeneratedPattern = storeGeneratedPattern.Value;
			}
			global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator.MapPrimitivePropertyFacets(property, edmProperty, storeType);
			return edmProperty;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0003BDAC File Offset: 0x00039FAC
		internal static void MapPrimitivePropertyFacets(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			if (global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator.IsValidFacet(typeUsage, "FixedLength") && property.IsFixedLength != null)
			{
				column.IsFixedLength = property.IsFixedLength;
			}
			if (global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator.IsValidFacet(typeUsage, "MaxLength"))
			{
				column.IsMaxLength = property.IsMaxLength;
				if (!column.IsMaxLength || property.MaxLength != null)
				{
					column.MaxLength = property.MaxLength;
				}
			}
			if (global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator.IsValidFacet(typeUsage, "Unicode") && property.IsUnicode != null)
			{
				column.IsUnicode = property.IsUnicode;
			}
			if (global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator.IsValidFacet(typeUsage, "Precision") && property.Precision != null)
			{
				column.Precision = property.Precision;
			}
			if (global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator.IsValidFacet(typeUsage, "Scale") && property.Scale != null)
			{
				column.Scale = property.Scale;
			}
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0003BE9C File Offset: 0x0003A09C
		private static bool IsValidFacet(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage, string name)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			return typeUsage.Facets.TryGetValue(name, false, out facet) && !facet.Description.IsConstant;
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0003BECC File Offset: 0x0003A0CC
		protected static global::System.Data.Entity.Core.Mapping.EntityTypeMapping GetEntityTypeMappingInHierarchy(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = databaseMapping.GetEntityTypeMapping(entityType);
			if (entityTypeMapping == null)
			{
				global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping = databaseMapping.GetEntitySetMapping(databaseMapping.Model.GetEntitySet(entityType));
				if (entitySetMapping != null)
				{
					entityTypeMapping = entitySetMapping.EntityTypeMappings.First((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => entityType.DeclaredProperties.All((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty dp) => (from pm in etm.MappingFragments.First<global::System.Data.Entity.Core.Mapping.MappingFragment>().ColumnMappings
					select pm.PropertyPath.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>()).Contains(dp)));
				}
			}
			return entityTypeMapping;
		}

		// Token: 0x04000A18 RID: 2584
		protected readonly global::System.Data.Entity.Core.Common.DbProviderManifest _providerManifest;
	}
}
