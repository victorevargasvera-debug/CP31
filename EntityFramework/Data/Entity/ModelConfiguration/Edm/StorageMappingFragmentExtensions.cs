using System;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000173 RID: 371
	internal static class StorageMappingFragmentExtensions
	{
		// Token: 0x060016B2 RID: 5810 RVA: 0x0003AD4E File Offset: 0x00038F4E
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty GetDefaultDiscriminator(this global::System.Data.Entity.Core.Mapping.MappingFragment entityTypeMapppingFragment)
		{
			return (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)entityTypeMapppingFragment.Annotations.GetAnnotation("DefaultDiscriminator");
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0003AD65 File Offset: 0x00038F65
		public static void SetDefaultDiscriminator(this global::System.Data.Entity.Core.Mapping.MappingFragment entityTypeMappingFragment, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty discriminator)
		{
			entityTypeMappingFragment.Annotations.SetAnnotation("DefaultDiscriminator", discriminator);
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0003AD78 File Offset: 0x00038F78
		public static void RemoveDefaultDiscriminatorAnnotation(this global::System.Data.Entity.Core.Mapping.MappingFragment entityTypeMappingFragment)
		{
			entityTypeMappingFragment.Annotations.RemoveAnnotation("DefaultDiscriminator");
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0003AD8C File Offset: 0x00038F8C
		public static void RemoveDefaultDiscriminator(this global::System.Data.Entity.Core.Mapping.MappingFragment entityTypeMappingFragment, global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty discriminatorColumn = entityTypeMappingFragment.RemoveDefaultDiscriminatorCondition();
			if (discriminatorColumn != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType table = entityTypeMappingFragment.Table;
				(from c in table.Properties
				where c.Name.Equals(discriminatorColumn.Name, global::System.StringComparison.Ordinal)
				select c).ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>().Each(new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(table.RemoveMember));
			}
			if (entitySetMapping != null && entityTypeMappingFragment.IsConditionOnlyFragment() && !entityTypeMappingFragment.ColumnConditions.Any<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>())
			{
				global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = entitySetMapping.EntityTypeMappings.Single((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => etm.MappingFragments.Contains(entityTypeMappingFragment));
				entityTypeMapping.RemoveFragment(entityTypeMappingFragment);
				if (entityTypeMapping.MappingFragments.Count == 0)
				{
					entitySetMapping.RemoveTypeMapping(entityTypeMapping);
				}
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x0003AE53 File Offset: 0x00039053
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty RemoveDefaultDiscriminatorCondition(this global::System.Data.Entity.Core.Mapping.MappingFragment entityTypeMappingFragment)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty defaultDiscriminator = entityTypeMappingFragment.GetDefaultDiscriminator();
			if (defaultDiscriminator != null && entityTypeMappingFragment.ColumnConditions.Any<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>())
			{
				entityTypeMappingFragment.ClearConditions();
			}
			entityTypeMappingFragment.RemoveDefaultDiscriminatorAnnotation();
			return defaultDiscriminator;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0003AE77 File Offset: 0x00039077
		public static void AddDiscriminatorCondition(this global::System.Data.Entity.Core.Mapping.MappingFragment entityTypeMapppingFragment, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty discriminatorColumn, object value)
		{
			entityTypeMapppingFragment.AddConditionProperty(new global::System.Data.Entity.Core.Mapping.ValueConditionMapping(discriminatorColumn, value));
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0003AE86 File Offset: 0x00039086
		public static void AddNullabilityCondition(this global::System.Data.Entity.Core.Mapping.MappingFragment entityTypeMapppingFragment, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, bool isNull)
		{
			entityTypeMapppingFragment.AddConditionProperty(new global::System.Data.Entity.Core.Mapping.IsNullConditionMapping(column, isNull));
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0003AE98 File Offset: 0x00039098
		public static bool IsConditionOnlyFragment(this global::System.Data.Entity.Core.Mapping.MappingFragment entityTypeMapppingFragment)
		{
			object annotation = entityTypeMapppingFragment.Annotations.GetAnnotation("ConditionOnlyFragment");
			return annotation != null && (bool)annotation;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0003AEC1 File Offset: 0x000390C1
		public static void SetIsConditionOnlyFragment(this global::System.Data.Entity.Core.Mapping.MappingFragment entityTypeMapppingFragment, bool isConditionOnlyFragment)
		{
			if (isConditionOnlyFragment)
			{
				entityTypeMapppingFragment.Annotations.SetAnnotation("ConditionOnlyFragment", isConditionOnlyFragment);
				return;
			}
			entityTypeMapppingFragment.Annotations.RemoveAnnotation("ConditionOnlyFragment");
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0003AEF0 File Offset: 0x000390F0
		public static bool IsUnmappedPropertiesFragment(this global::System.Data.Entity.Core.Mapping.MappingFragment entityTypeMapppingFragment)
		{
			object annotation = entityTypeMapppingFragment.Annotations.GetAnnotation("UnmappedPropertiesFragment");
			return annotation != null && (bool)annotation;
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0003AF19 File Offset: 0x00039119
		public static void SetIsUnmappedPropertiesFragment(this global::System.Data.Entity.Core.Mapping.MappingFragment entityTypeMapppingFragment, bool isUnmappedPropertiesFragment)
		{
			if (isUnmappedPropertiesFragment)
			{
				entityTypeMapppingFragment.Annotations.SetAnnotation("UnmappedPropertiesFragment", isUnmappedPropertiesFragment);
				return;
			}
			entityTypeMapppingFragment.Annotations.RemoveAnnotation("UnmappedPropertiesFragment");
		}

		// Token: 0x04000A10 RID: 2576
		private const string DefaultDiscriminatorAnnotation = "DefaultDiscriminator";

		// Token: 0x04000A11 RID: 2577
		private const string ConditionOnlyFragmentAnnotation = "ConditionOnlyFragment";

		// Token: 0x04000A12 RID: 2578
		private const string UnmappedPropertiesFragmentAnnotation = "UnmappedPropertiesFragment";
	}
}
