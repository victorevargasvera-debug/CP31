using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Edm.Services
{
	// Token: 0x0200017A RID: 378
	internal class TableMappingGenerator : global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator
	{
		// Token: 0x060016E0 RID: 5856 RVA: 0x0003BF2A File Offset: 0x0003A12A
		public TableMappingGenerator(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest) : base(providerManifest)
		{
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x0003BF34 File Offset: 0x0003A134
		public void Generate(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = databaseMapping.Model.GetEntitySet(entityType);
			global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping = databaseMapping.GetEntitySetMapping(entitySet) ?? databaseMapping.AddEntitySetMapping(entitySet);
			global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = entitySetMapping.EntityTypeMappings.FirstOrDefault((global::System.Data.Entity.Core.Mapping.EntityTypeMapping m) => m.EntityTypes.Contains(entitySet.ElementType)) ?? entitySetMapping.EntityTypeMappings.FirstOrDefault<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>();
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = (entityTypeMapping != null) ? entityTypeMapping.MappingFragments.First<global::System.Data.Entity.Core.Mapping.MappingFragment>().Table : databaseMapping.Database.AddTable(entityType.GetRootType().Name);
			entityTypeMapping = new global::System.Data.Entity.Core.Mapping.EntityTypeMapping(null);
			global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = new global::System.Data.Entity.Core.Mapping.MappingFragment(databaseMapping.Database.GetEntitySet(entityType2), entityTypeMapping, false);
			entityTypeMapping.AddType(entityType);
			entityTypeMapping.AddFragment(mappingFragment);
			entityTypeMapping.SetClrType(entityType.GetClrType());
			entitySetMapping.AddTypeMapping(entityTypeMapping);
			new global::System.Data.Entity.ModelConfiguration.Edm.Services.PropertyMappingGenerator(this._providerManifest).Generate(entityType, entityType.Properties, entitySetMapping, mappingFragment, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(), false);
		}
	}
}
