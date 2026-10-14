using System;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000172 RID: 370
	internal static class StorageEntityTypeMappingExtensions
	{
		// Token: 0x060016AA RID: 5802 RVA: 0x0003AC4C File Offset: 0x00038E4C
		public static object GetConfiguration(this global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping)
		{
			return entityTypeMapping.Annotations.GetConfiguration();
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x0003AC59 File Offset: 0x00038E59
		public static void SetConfiguration(this global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, object configuration)
		{
			entityTypeMapping.Annotations.SetConfiguration(configuration);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x0003AC68 File Offset: 0x00038E68
		public static global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder GetPropertyMapping(this global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, params global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] propertyPath)
		{
			return entityTypeMapping.MappingFragments.SelectMany((global::System.Data.Entity.Core.Mapping.MappingFragment f) => f.ColumnMappings).Single((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder p) => p.PropertyPath.SequenceEqual(propertyPath));
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x0003ACBD File Offset: 0x00038EBD
		public static global::System.Data.Entity.Core.Metadata.Edm.EntityType GetPrimaryTable(this global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping)
		{
			return entityTypeMapping.MappingFragments.First<global::System.Data.Entity.Core.Mapping.MappingFragment>().Table;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x0003ACD0 File Offset: 0x00038ED0
		public static bool UsesOtherTables(this global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType table)
		{
			return entityTypeMapping.MappingFragments.Any((global::System.Data.Entity.Core.Mapping.MappingFragment f) => f.Table != table);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x0003AD01 File Offset: 0x00038F01
		public static global::System.Type GetClrType(this global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMappping)
		{
			return entityTypeMappping.Annotations.GetClrType();
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0003AD0E File Offset: 0x00038F0E
		public static void SetClrType(this global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, global::System.Type type)
		{
			entityTypeMapping.Annotations.SetClrType(type);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0003AD1C File Offset: 0x00038F1C
		public static global::System.Data.Entity.Core.Mapping.EntityTypeMapping Clone(this global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping)
		{
			global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping2 = new global::System.Data.Entity.Core.Mapping.EntityTypeMapping(null);
			entityTypeMapping2.AddType(entityTypeMapping.EntityType);
			entityTypeMapping.Annotations.Copy(entityTypeMapping2.Annotations);
			return entityTypeMapping2;
		}
	}
}
