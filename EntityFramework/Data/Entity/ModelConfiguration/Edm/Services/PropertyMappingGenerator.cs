using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Edm.Services
{
	// Token: 0x02000178 RID: 376
	internal class PropertyMappingGenerator : global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator
	{
		// Token: 0x060016D9 RID: 5849 RVA: 0x0003BAC4 File Offset: 0x00039CC4
		public PropertyMappingGenerator(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest) : base(providerManifest)
		{
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x0003BAD0 File Offset: 0x00039CD0
		public void Generate(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties, global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping, global::System.Data.Entity.Core.Mapping.MappingFragment entityTypeMappingFragment, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> propertyPath, bool createNewColumn)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> declaredProperties = entityType.GetRootType().DeclaredProperties;
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = properties.GetEnumerator())
			{
				global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> <>9__3;
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property = enumerator.Current;
					if (property.IsComplexType && propertyPath.Any((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.IsComplexType && p.ComplexType == property.ComplexType))
					{
						throw global::System.Data.Entity.Resources.Error.CircularComplexTypeHierarchy();
					}
					propertyPath.Add(property);
					if (property.IsComplexType)
					{
						this.Generate(entityType, property.ComplexType.Properties, entitySetMapping, entityTypeMappingFragment, propertyPath, createNewColumn);
					}
					else
					{
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> source = entitySetMapping.EntityTypeMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => etm.MappingFragments).SelectMany((global::System.Data.Entity.Core.Mapping.MappingFragment etmf) => etmf.ColumnMappings);
						global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> predicate;
						if ((predicate = <>9__3) == null)
						{
							predicate = (<>9__3 = ((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm) => pm.PropertyPath.SequenceEqual(propertyPath)));
						}
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (from pm in source.Where(predicate)
						select pm.ColumnProperty).FirstOrDefault<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
						if (edmProperty == null || createNewColumn)
						{
							string columnName = string.Join("_", from p in propertyPath
							select p.Name);
							edmProperty = base.MapTableColumn(property, columnName, !declaredProperties.Contains(propertyPath.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>()));
							entityTypeMappingFragment.Table.AddColumn(edmProperty);
							if (entityType.KeyProperties().Contains(property))
							{
								entityTypeMappingFragment.Table.AddKeyMember(edmProperty);
							}
						}
						entityTypeMappingFragment.AddColumnMapping(new global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder(edmProperty, propertyPath.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>()));
					}
					propertyPath.Remove(property);
				}
			}
		}
	}
}
