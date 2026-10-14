using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration.Mapping
{
	// Token: 0x02000212 RID: 530
	internal static class EntityMappingOperations
	{
		// Token: 0x06001C1A RID: 7194 RVA: 0x0004E798 File Offset: 0x0004C998
		public static global::System.Data.Entity.Core.Mapping.MappingFragment CreateTypeMappingFragment(global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, global::System.Data.Entity.Core.Mapping.MappingFragment templateFragment, global::System.Data.Entity.Core.Metadata.Edm.EntitySet tableSet)
		{
			global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = new global::System.Data.Entity.Core.Mapping.MappingFragment(tableSet, entityTypeMapping, false);
			entityTypeMapping.AddFragment(mappingFragment);
			foreach (global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder columnMappingBuilder in from pm in templateFragment.ColumnMappings
			where pm.ColumnProperty.IsPrimaryKeyColumn
			select pm)
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.CopyPropertyMappingToFragment(columnMappingBuilder, mappingFragment, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TablePrimitiveOperations.GetNameMatcher(columnMappingBuilder.ColumnProperty.Name), true);
			}
			return mappingFragment;
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0004E82C File Offset: 0x0004CA2C
		private static void UpdatePropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>> columnMappingIndex, global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder propertyMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, bool useExisting)
		{
			propertyMappingBuilder.ColumnProperty = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableOperations.CopyColumnAndAnyConstraints(databaseMapping.Database, fromTable, toTable, propertyMappingBuilder.ColumnProperty, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.GetPropertyPathMatcher(columnMappingIndex, propertyMappingBuilder), useExisting);
			propertyMappingBuilder.SyncNullabilityCSSpace(databaseMapping, entitySets, toTable);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0004E85C File Offset: 0x0004CA5C
		private static global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool> GetPropertyPathMatcher(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>> columnMappingIndex, global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder propertyMappingBuilder)
		{
			return delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c)
			{
				if (!columnMappingIndex.ContainsKey(c))
				{
					return false;
				}
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> list = columnMappingIndex[c];
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].PropertyPath.PathEqual(propertyMappingBuilder.PropertyPath))
					{
						return true;
					}
				}
				return false;
			};
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0004E87C File Offset: 0x0004CA7C
		private static bool PathEqual(this global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> listA, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> listB)
		{
			if (listA == null || listB == null)
			{
				return false;
			}
			if (listA.Count != listB.Count)
			{
				return false;
			}
			for (int i = 0; i < listA.Count; i++)
			{
				if (listA[i] != listB[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0004E8C8 File Offset: 0x0004CAC8
		private static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>> GetColumnMappingIndex(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>>();
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.EntitySetMapping> entitySetMappings = databaseMapping.EntityContainerMappings.Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().EntitySetMappings;
			if (entitySetMappings == null)
			{
				return dictionary;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntitySetMapping> list = entitySetMappings.ToList<global::System.Data.Entity.Core.Mapping.EntitySetMapping>();
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> entityTypeMappings = list[i].EntityTypeMappings;
				if (entityTypeMappings != null)
				{
					for (int j = 0; j < entityTypeMappings.Count; j++)
					{
						global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.MappingFragment> mappingFragments = entityTypeMappings[j].MappingFragments;
						if (mappingFragments != null)
						{
							for (int k = 0; k < mappingFragments.Count; k++)
							{
								global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> list2 = mappingFragments[k].ColumnMappings as global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>;
								if (list2 != null)
								{
									for (int l = 0; l < list2.Count; l++)
									{
										global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder columnMappingBuilder = list2[l];
										global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> list3;
										if (dictionary.ContainsKey(columnMappingBuilder.ColumnProperty))
										{
											list3 = dictionary[columnMappingBuilder.ColumnProperty];
										}
										else
										{
											dictionary.Add(columnMappingBuilder.ColumnProperty, list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>());
										}
										list3.Add(columnMappingBuilder);
									}
								}
							}
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0004E9F0 File Offset: 0x0004CBF0
		public static void UpdatePropertyMappings(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Mapping.MappingFragment fragment, bool useExisting)
		{
			if (fromTable != fragment.Table)
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>> columnMappingIndex = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.GetColumnMappingIndex(databaseMapping);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> list = fragment.ColumnMappings.ToList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>();
				for (int i = 0; i < list.Count; i++)
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.UpdatePropertyMapping(databaseMapping, entitySets, columnMappingIndex, list[i], fromTable, fragment.Table, useExisting);
				}
			}
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0004EA44 File Offset: 0x0004CC44
		public static void MovePropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets, global::System.Data.Entity.Core.Mapping.MappingFragment fromFragment, global::System.Data.Entity.Core.Mapping.MappingFragment toFragment, global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder propertyMappingBuilder, bool requiresUpdate, bool useExisting)
		{
			if (requiresUpdate && fromFragment.Table != toFragment.Table)
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.UpdatePropertyMapping(databaseMapping, entitySets, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.GetColumnMappingIndex(databaseMapping), propertyMappingBuilder, fromFragment.Table, toFragment.Table, useExisting);
			}
			fromFragment.RemoveColumnMapping(propertyMappingBuilder);
			toFragment.AddColumnMapping(propertyMappingBuilder);
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0004EA90 File Offset: 0x0004CC90
		public static void CopyPropertyMappingToFragment(global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder propertyMappingBuilder, global::System.Data.Entity.Core.Mapping.MappingFragment fragment, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool> isCompatible, bool useExisting)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty columnProperty = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TablePrimitiveOperations.IncludeColumn(fragment.Table, propertyMappingBuilder.ColumnProperty, isCompatible, useExisting);
			fragment.AddColumnMapping(new global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder(columnProperty, propertyMappingBuilder.PropertyPath));
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0004EAC4 File Offset: 0x0004CCC4
		public static void UpdateConditions(global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Mapping.MappingFragment fragment)
		{
			if (fromTable != fragment.Table)
			{
				fragment.ColumnConditions.Each(delegate(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping cc)
				{
					cc.Column = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableOperations.CopyColumnAndAnyConstraints(database, fromTable, fragment.Table, cc.Column, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TablePrimitiveOperations.GetNameMatcher(cc.Column.Name), true);
				});
			}
		}
	}
}
