using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Edm.Services
{
	// Token: 0x02000175 RID: 373
	internal class DatabaseMappingGenerator
	{
		// Token: 0x060016C5 RID: 5829 RVA: 0x0003B368 File Offset: 0x00039568
		public DatabaseMappingGenerator(global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			this._providerInfo = providerInfo;
			this._providerManifest = providerManifest;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x0003B37E File Offset: 0x0003957E
		public global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping Generate(global::System.Data.Entity.Core.Metadata.Edm.EdmModel conceptualModel)
		{
			global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping dbDatabaseMapping = this.InitializeDatabaseMapping(conceptualModel);
			global::System.Data.Entity.ModelConfiguration.Edm.Services.DatabaseMappingGenerator.GenerateEntityTypes(dbDatabaseMapping);
			global::System.Data.Entity.ModelConfiguration.Edm.Services.DatabaseMappingGenerator.GenerateDiscriminators(dbDatabaseMapping);
			global::System.Data.Entity.ModelConfiguration.Edm.Services.DatabaseMappingGenerator.GenerateAssociationTypes(dbDatabaseMapping);
			return dbDatabaseMapping;
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0003B39C File Offset: 0x0003959C
		private global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping InitializeDatabaseMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmModel conceptualModel)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmModel database = global::System.Data.Entity.Core.Metadata.Edm.EdmModel.CreateStoreModel(this._providerInfo, this._providerManifest, conceptualModel.SchemaVersion);
			return new global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping().Initialize(conceptualModel, database);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x0003B3D0 File Offset: 0x000395D0
		private static void GenerateEntityTypes(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EntityType> enumerator = databaseMapping.Model.EntityTypes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = enumerator.Current;
					if (entityType.Abstract && databaseMapping.Model.EntityTypes.All((global::System.Data.Entity.Core.Metadata.Edm.EntityType e) => e.BaseType != entityType))
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnmappedAbstractType(entityType.GetClrType()));
					}
					new global::System.Data.Entity.ModelConfiguration.Edm.Services.TableMappingGenerator(databaseMapping.ProviderManifest).Generate(entityType, databaseMapping);
				}
			}
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x0003B480 File Offset: 0x00039680
		private static void GenerateDiscriminators(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping in databaseMapping.GetEntitySetMappings())
			{
				if (entitySetMapping.EntityTypeMappings.Count<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>() > 1)
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType = databaseMapping.ProviderManifest.GetStoreType(global::System.Data.Entity.ModelConfiguration.Edm.Services.DatabaseMappingGenerator.DiscriminatorTypeUsage);
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Discriminator", storeType)
					{
						Nullable = false,
						DefaultValue = "(Undefined)"
					};
					entitySetMapping.EntityTypeMappings.First<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>().MappingFragments.Single<global::System.Data.Entity.Core.Mapping.MappingFragment>().Table.AddColumn(edmProperty);
					foreach (global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping in entitySetMapping.EntityTypeMappings)
					{
						if (!entityTypeMapping.EntityType.Abstract)
						{
							global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = entityTypeMapping.MappingFragments.Single<global::System.Data.Entity.Core.Mapping.MappingFragment>();
							mappingFragment.SetDefaultDiscriminator(edmProperty);
							mappingFragment.AddDiscriminatorCondition(edmProperty, entityTypeMapping.EntityType.Name);
						}
					}
				}
			}
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x0003B59C File Offset: 0x0003979C
		private static void GenerateAssociationTypes(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType in databaseMapping.Model.AssociationTypes)
			{
				new global::System.Data.Entity.ModelConfiguration.Edm.Services.AssociationTypeMappingGenerator(databaseMapping.ProviderManifest).Generate(associationType, databaseMapping);
			}
		}

		// Token: 0x04000A13 RID: 2579
		private const string DiscriminatorColumnName = "Discriminator";

		// Token: 0x04000A14 RID: 2580
		public const int DiscriminatorMaxLength = 128;

		// Token: 0x04000A15 RID: 2581
		public static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage DiscriminatorTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String), true, false, 128);

		// Token: 0x04000A16 RID: 2582
		private readonly global::System.Data.Entity.Infrastructure.DbProviderInfo _providerInfo;

		// Token: 0x04000A17 RID: 2583
		private readonly global::System.Data.Entity.Core.Common.DbProviderManifest _providerManifest;
	}
}
