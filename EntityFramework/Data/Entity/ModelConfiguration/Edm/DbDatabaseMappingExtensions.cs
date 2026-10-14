using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000162 RID: 354
	internal static class DbDatabaseMappingExtensions
	{
		// Token: 0x0600162A RID: 5674 RVA: 0x000391E0 File Offset: 0x000373E0
		public static global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping Initialize(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.EdmModel database)
		{
			databaseMapping.Model = model;
			databaseMapping.Database = database;
			databaseMapping.AddEntityContainerMapping(new global::System.Data.Entity.Core.Mapping.EntityContainerMapping(model.Containers.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>()));
			return databaseMapping;
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00039208 File Offset: 0x00037408
		public static global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace ToMetadataWorkspace(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection = new global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection(databaseMapping.Model);
			global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = new global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection(databaseMapping.Database);
			global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection storageMappingItemCollection = databaseMapping.ToStorageMappingItemCollection(itemCollection, storeItemCollection);
			global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace = new global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace(() => itemCollection, () => storeItemCollection, () => storageMappingItemCollection);
			new global::System.Data.Entity.Core.Metadata.Edm.CodeFirstOSpaceLoader(null).LoadTypes(itemCollection, (global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection)metadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace));
			return metadataWorkspace;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000392A0 File Offset: 0x000374A0
		public static global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection ToStorageMappingItemCollection(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection, global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			using (global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(stringBuilder, new global::System.Xml.XmlWriterSettings
			{
				Indent = true
			}))
			{
				new global::System.Data.Entity.Core.Metadata.Edm.MslSerializer().Serialize(databaseMapping, xmlWriter);
			}
			global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection result;
			using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(stringBuilder.ToString())))
			{
				result = new global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection(itemCollection, storeItemCollection, new global::System.Xml.XmlReader[]
				{
					xmlReader
				});
			}
			return result;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x0003932C File Offset: 0x0003752C
		public static global::System.Data.Entity.Core.Mapping.EntityTypeMapping GetEntityTypeMapping(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> entityTypeMappings = databaseMapping.GetEntityTypeMappings(entityType);
			if (entityTypeMappings.Count <= 1)
			{
				return entityTypeMappings.FirstOrDefault<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>();
			}
			return entityTypeMappings.SingleOrDefault((global::System.Data.Entity.Core.Mapping.EntityTypeMapping m) => m.IsHierarchyMapping);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00039378 File Offset: 0x00037578
		public static global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> GetEntityTypeMappings(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>();
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping in databaseMapping.EntityContainerMappings.Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().EntitySetMappings)
			{
				foreach (global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping in entitySetMapping.EntityTypeMappings)
				{
					if (entityTypeMapping.EntityType == entityType)
					{
						list.Add(entityTypeMapping);
					}
				}
			}
			return list;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00039414 File Offset: 0x00037614
		public static global::System.Data.Entity.Core.Mapping.EntityTypeMapping GetEntityTypeMapping(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Type clrType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>();
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping in databaseMapping.EntityContainerMappings.Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().EntitySetMappings)
			{
				foreach (global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping in entitySetMapping.EntityTypeMappings)
				{
					if (entityTypeMapping.GetClrType() == clrType)
					{
						list.Add(entityTypeMapping);
					}
				}
			}
			if (list.Count <= 1)
			{
				return list.FirstOrDefault<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>();
			}
			return list.SingleOrDefault((global::System.Data.Entity.Core.Mapping.EntityTypeMapping m) => m.IsHierarchyMapping);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000394E8 File Offset: 0x000376E8
		public static global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> GetComplexPropertyMappings(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Type complexType)
		{
			return from esm in databaseMapping.EntityContainerMappings.Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().EntitySetMappings
			from etm in esm.EntityTypeMappings
			from etmf in etm.MappingFragments
			from epm in etmf.ColumnMappings
			where epm.PropertyPath.Any((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.IsComplexType && p.ComplexType.GetClrType() == complexType)
			select global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType>(epm, etmf.Table);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00039610 File Offset: 0x00037810
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> GetComplexParameterBindings(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Type complexType)
		{
			return from esm in databaseMapping.GetEntitySetMappings()
			from mfm in esm.ModificationFunctionMappings
			from pb in mfm.PrimaryParameterBindings
			where pb.MemberPath.Members.OfType<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>().Any((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.IsComplexType && p.ComplexType.GetClrType() == complexType)
			select pb;
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x000396EC File Offset: 0x000378EC
		public static global::System.Data.Entity.Core.Mapping.EntitySetMapping GetEntitySetMapping(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			return databaseMapping.EntityContainerMappings.Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().EntitySetMappings.SingleOrDefault((global::System.Data.Entity.Core.Mapping.EntitySetMapping e) => e.EntitySet == entitySet);
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00039727 File Offset: 0x00037927
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.EntitySetMapping> GetEntitySetMappings(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			return databaseMapping.EntityContainerMappings.Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().EntitySetMappings;
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00039739 File Offset: 0x00037939
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.AssociationSetMapping> GetAssociationSetMappings(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			return databaseMapping.EntityContainerMappings.Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().AssociationSetMappings;
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x0003974C File Offset: 0x0003794C
		public static global::System.Data.Entity.Core.Mapping.EntitySetMapping AddEntitySetMapping(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping = new global::System.Data.Entity.Core.Mapping.EntitySetMapping(entitySet, null);
			databaseMapping.EntityContainerMappings.Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().AddSetMapping(entitySetMapping);
			return entitySetMapping;
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00039774 File Offset: 0x00037974
		public static global::System.Data.Entity.Core.Mapping.AssociationSetMapping AddAssociationSetMapping(this global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping = databaseMapping.EntityContainerMappings.Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>();
			global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping = new global::System.Data.Entity.Core.Mapping.AssociationSetMapping(associationSet, entitySet, entityContainerMapping).Initialize();
			entityContainerMapping.AddSetMapping(associationSetMapping);
			return associationSetMapping;
		}
	}
}
