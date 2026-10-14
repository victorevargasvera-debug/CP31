using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration.Mapping
{
	// Token: 0x02000216 RID: 534
	internal class EntityMappingService
	{
		// Token: 0x06001C2A RID: 7210 RVA: 0x0004EDEC File Offset: 0x0004CFEC
		public EntityMappingService(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			this._databaseMapping = databaseMapping;
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0004EDFB File Offset: 0x0004CFFB
		public void Configure()
		{
			this.Analyze();
			this.Transform();
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0004EE0C File Offset: 0x0004D00C
		private void Analyze()
		{
			this._tableMappings = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping>();
			this._entityTypes = new global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.SortedEntityTypeIndex();
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping in this._databaseMapping.EntityContainerMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityContainerMapping ecm) => ecm.EntitySetMappings))
			{
				foreach (global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping in entitySetMapping.EntityTypeMappings)
				{
					this._entityTypes.Add(entitySetMapping.EntitySet, entityTypeMapping.EntityType);
					foreach (global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment in entityTypeMapping.MappingFragments)
					{
						this.FindOrCreateTableMapping(mappingFragment.Table).AddEntityTypeMappingFragment(entitySetMapping.EntitySet, entityTypeMapping.EntityType, mappingFragment);
					}
				}
			}
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0004EF40 File Offset: 0x0004D140
		private void Transform()
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> enumerator = this._entityTypes.GetEntitySets().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = enumerator.Current;
					global::System.Collections.Generic.Dictionary<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.EntityTypeMapping>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.EntityTypeMapping>>();
					using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EntityType> enumerator2 = this._entityTypes.GetEntityTypes(entitySet).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = enumerator2.Current;
							global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping> values = this._tableMappings.Values;
							global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping, bool> predicate;
							global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping, bool> <>9__0;
							if ((predicate = <>9__0) == null)
							{
								predicate = (<>9__0 = ((global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping tm) => tm.EntityTypes.Contains(entitySet, entityType)));
							}
							global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> <>9__1;
							global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> <>9__2;
							foreach (global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping tableMapping in values.Where(predicate))
							{
								global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.EntityTypeMapping> dictionary2;
								if (!dictionary.TryGetValue(tableMapping, out dictionary2))
								{
									dictionary2 = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.EntityTypeMapping>();
									dictionary.Add(tableMapping, dictionary2);
								}
								global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingService.RemoveRedundantDefaultDiscriminators(tableMapping);
								bool flag = this.DetermineRequiresIsTypeOf(tableMapping, entitySet, entityType);
								global::System.Data.Entity.Core.Mapping.EntityTypeMapping propertiesTypeMapping;
								global::System.Data.Entity.Core.Mapping.MappingFragment propertiesTypeMappingFragment;
								if (this.FindPropertyEntityTypeMapping(tableMapping, entitySet, entityType, flag, out propertiesTypeMapping, out propertiesTypeMappingFragment))
								{
									bool flag2 = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingService.DetermineRequiresSplitEntityTypeMapping(tableMapping, entityType, flag);
									global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = this.FindConditionTypeMapping(entityType, flag2, propertiesTypeMapping);
									global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingService.FindConditionTypeMappingFragment(this._databaseMapping.Database.GetEntitySet(tableMapping.Table), propertiesTypeMappingFragment, entityTypeMapping);
									if (flag)
									{
										if (!propertiesTypeMapping.IsHierarchyMapping)
										{
											global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping2 = this._databaseMapping.GetEntityTypeMappings(entityType).SingleOrDefault((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => etm.IsHierarchyMapping);
											if (entityTypeMapping2 == null)
											{
												if (propertiesTypeMapping.MappingFragments.Count > 1)
												{
													global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping3 = propertiesTypeMapping.Clone();
													this._databaseMapping.GetEntitySetMappings().Single((global::System.Data.Entity.Core.Mapping.EntitySetMapping esm) => esm.EntityTypeMappings.Contains(propertiesTypeMapping)).AddTypeMapping(entityTypeMapping3);
													global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment> mappingFragments = propertiesTypeMapping.MappingFragments;
													global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> predicate2;
													global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> <>9__5;
													if ((predicate2 = <>9__5) == null)
													{
														predicate2 = (<>9__5 = ((global::System.Data.Entity.Core.Mapping.MappingFragment tmf) => tmf != propertiesTypeMappingFragment));
													}
													foreach (global::System.Data.Entity.Core.Mapping.MappingFragment fragment in mappingFragments.Where(predicate2).ToArray<global::System.Data.Entity.Core.Mapping.MappingFragment>())
													{
														propertiesTypeMapping.RemoveFragment(fragment);
														entityTypeMapping3.AddFragment(fragment);
													}
												}
												propertiesTypeMapping.AddIsOfType(propertiesTypeMapping.EntityType);
											}
											else
											{
												propertiesTypeMapping.RemoveFragment(propertiesTypeMappingFragment);
												if (propertiesTypeMapping.MappingFragments.Count == 0)
												{
													this._databaseMapping.GetEntitySetMapping(entitySet).RemoveTypeMapping(propertiesTypeMapping);
												}
												propertiesTypeMapping = entityTypeMapping2;
												propertiesTypeMapping.AddFragment(propertiesTypeMappingFragment);
											}
										}
										dictionary2.Add(entityType, propertiesTypeMapping);
									}
									global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingService.ConfigureTypeMappings(tableMapping, dictionary2, entityType, propertiesTypeMappingFragment, mappingFragment);
									if (propertiesTypeMappingFragment.IsUnmappedPropertiesFragment())
									{
										global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> columnMappings = propertiesTypeMappingFragment.ColumnMappings;
										global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> predicate3;
										if ((predicate3 = <>9__1) == null)
										{
											predicate3 = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm) => entityType.GetKeyProperties().Contains(pm.PropertyPath.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())));
										}
										if (columnMappings.All(predicate3))
										{
											this.RemoveFragment(entitySet, propertiesTypeMapping, propertiesTypeMappingFragment);
											if (flag2)
											{
												global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> columnMappings2 = mappingFragment.ColumnMappings;
												global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> predicate4;
												if ((predicate4 = <>9__2) == null)
												{
													predicate4 = (<>9__2 = ((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm) => entityType.GetKeyProperties().Contains(pm.PropertyPath.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())));
												}
												if (columnMappings2.All(predicate4))
												{
													this.RemoveFragment(entitySet, entityTypeMapping, mappingFragment);
												}
											}
										}
									}
									global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.CleanupUnmappedArtifacts(this._databaseMapping, tableMapping.Table);
									foreach (global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder foreignKeyBuilder in tableMapping.Table.ForeignKeyBuilders)
									{
										global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = foreignKeyBuilder.GetAssociationType();
										if (associationType != null && associationType.IsRequiredToNonRequired())
										{
											global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
											global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2;
											foreignKeyBuilder.GetAssociationType().TryGuessPrincipalAndDependentEnds(out associationEndMember, out associationEndMember2);
											if (associationEndMember2.GetEntityType() == entityType)
											{
												this.MarkColumnsAsNonNullableIfNoTableSharing(entitySet, tableMapping.Table, entityType, foreignKeyBuilder.DependentColumns);
											}
										}
									}
								}
							}
						}
					}
					this.ConfigureAssociationSetMappingForeignKeys(entitySet);
				}
			}
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0004F494 File Offset: 0x0004D694
		private void ConfigureAssociationSetMappingForeignKeys(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.AssociationSetMapping> source = this._databaseMapping.EntityContainerMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityContainerMapping ecm) => ecm.AssociationSetMappings);
			global::System.Func<global::System.Data.Entity.Core.Mapping.AssociationSetMapping, bool> <>9__1;
			global::System.Func<global::System.Data.Entity.Core.Mapping.AssociationSetMapping, bool> predicate;
			if ((predicate = <>9__1) == null)
			{
				predicate = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.AssociationSetMapping asm) => (asm.AssociationSet.SourceSet == entitySet || asm.AssociationSet.TargetSet == entitySet) && asm.AssociationSet.ElementType.IsRequiredToNonRequired()));
			}
			foreach (global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping in source.Where(predicate))
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2;
				associationSetMapping.AssociationSet.ElementType.TryGuessPrincipalAndDependentEnds(out associationEndMember, out associationEndMember2);
				if ((associationEndMember2 == associationSetMapping.AssociationSet.ElementType.SourceEnd && associationSetMapping.AssociationSet.SourceSet == entitySet) || (associationEndMember2 == associationSetMapping.AssociationSet.ElementType.TargetEnd && associationSetMapping.AssociationSet.TargetSet == entitySet))
				{
					global::System.Data.Entity.Core.Mapping.EndPropertyMapping endPropertyMapping = (associationSetMapping.SourceEndMapping.AssociationEnd == associationEndMember2) ? associationSetMapping.TargetEndMapping : associationSetMapping.SourceEndMapping;
					this.MarkColumnsAsNonNullableIfNoTableSharing(entitySet, associationSetMapping.Table, associationEndMember2.GetEntityType(), from pm in endPropertyMapping.PropertyMappings
					select pm.Column);
				}
			}
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0004F600 File Offset: 0x0004D800
		private void MarkColumnsAsNonNullableIfNoTableSharing(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentEndEntityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> columns)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> source = from et in this._tableMappings[table].EntityTypes.GetEntityTypes(entitySet)
			where et != dependentEndEntityType && (et.IsAncestorOf(dependentEndEntityType) || !dependentEndEntityType.IsAncestorOf(et))
			select et;
			if (source.Count<global::System.Data.Entity.Core.Metadata.Edm.EntityType>() != 0)
			{
				if (!source.All((global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => et.Abstract))
				{
					return;
				}
			}
			columns.Each((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c) => c.Nullable = false);
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0004F698 File Offset: 0x0004D898
		private static void ConfigureTypeMappings(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping tableMapping, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.EntityTypeMapping> rootMappings, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Mapping.MappingFragment propertiesTypeMappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment conditionTypeMappingFragment)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>(from pm in propertiesTypeMappingFragment.ColumnMappings
			where !pm.ColumnProperty.IsPrimaryKeyColumn
			select pm);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(propertiesTypeMappingFragment.ColumnConditions);
			var source = from cm in tableMapping.ColumnMappings
			from pm in cm.PropertyMappings
			select new
			{
				cm,
				pm
			};
			global::System.Func<global::<>f__AnonymousType47<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification>, bool> <>9__3;
			var predicate;
			if ((predicate = <>9__3) == null)
			{
				predicate = (<>9__3 = (<>h__TransparentIdentifier0 => <>h__TransparentIdentifier0.pm.EntityType == entityType));
			}
			using (var enumerator = (from <>h__TransparentIdentifier0 in source.Where(predicate)
			select new
			{
				Column = <>h__TransparentIdentifier0.cm.Column,
				Property = <>h__TransparentIdentifier0.pm
			}).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::<>f__AnonymousType48<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification> columnMapping = enumerator.Current;
					if (columnMapping.Property.PropertyPath != null && !global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingService.IsRootTypeMapping(rootMappings, columnMapping.Property.EntityType, columnMapping.Property.PropertyPath))
					{
						global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder columnMappingBuilder = propertiesTypeMappingFragment.ColumnMappings.SingleOrDefault((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder x) => x.PropertyPath == columnMapping.Property.PropertyPath);
						if (columnMappingBuilder != null)
						{
							list.Remove(columnMappingBuilder);
						}
						else
						{
							columnMappingBuilder = new global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder(columnMapping.Column, columnMapping.Property.PropertyPath);
							propertiesTypeMappingFragment.AddColumnMapping(columnMappingBuilder);
						}
					}
					if (columnMapping.Property.Conditions != null)
					{
						foreach (global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMapping in columnMapping.Property.Conditions)
						{
							if (conditionTypeMappingFragment.ColumnConditions.Contains(conditionPropertyMapping))
							{
								list2.Remove(conditionPropertyMapping);
							}
							else if (!entityType.Abstract)
							{
								conditionTypeMappingFragment.AddConditionProperty(conditionPropertyMapping);
							}
						}
					}
				}
			}
			foreach (global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder columnMappingBuilder2 in list)
			{
				propertiesTypeMappingFragment.RemoveColumnMapping(columnMappingBuilder2);
			}
			foreach (global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition in list2)
			{
				conditionTypeMappingFragment.RemoveConditionProperty(condition);
			}
			if (entityType.Abstract)
			{
				propertiesTypeMappingFragment.ClearConditions();
			}
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0004F9A8 File Offset: 0x0004DBA8
		private static global::System.Data.Entity.Core.Mapping.MappingFragment FindConditionTypeMappingFragment(global::System.Data.Entity.Core.Metadata.Edm.EntitySet tableSet, global::System.Data.Entity.Core.Mapping.MappingFragment propertiesTypeMappingFragment, global::System.Data.Entity.Core.Mapping.EntityTypeMapping conditionTypeMapping)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType table = tableSet.ElementType;
			global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = conditionTypeMapping.MappingFragments.SingleOrDefault((global::System.Data.Entity.Core.Mapping.MappingFragment x) => x.Table == table);
			if (mappingFragment == null)
			{
				mappingFragment = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.CreateTypeMappingFragment(conditionTypeMapping, propertiesTypeMappingFragment, tableSet);
				mappingFragment.SetIsConditionOnlyFragment(true);
				if (propertiesTypeMappingFragment.GetDefaultDiscriminator() != null)
				{
					mappingFragment.SetDefaultDiscriminator(propertiesTypeMappingFragment.GetDefaultDiscriminator());
					propertiesTypeMappingFragment.RemoveDefaultDiscriminatorAnnotation();
				}
			}
			return mappingFragment;
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x0004FA10 File Offset: 0x0004DC10
		private global::System.Data.Entity.Core.Mapping.EntityTypeMapping FindConditionTypeMapping(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, bool requiresSplit, global::System.Data.Entity.Core.Mapping.EntityTypeMapping propertiesTypeMapping)
		{
			global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = propertiesTypeMapping;
			if (requiresSplit)
			{
				if (!entityType.Abstract)
				{
					entityTypeMapping = propertiesTypeMapping.Clone();
					entityTypeMapping.RemoveIsOfType(entityTypeMapping.EntityType);
					this._databaseMapping.GetEntitySetMappings().Single((global::System.Data.Entity.Core.Mapping.EntitySetMapping esm) => esm.EntityTypeMappings.Contains(propertiesTypeMapping)).AddTypeMapping(entityTypeMapping);
				}
				propertiesTypeMapping.MappingFragments.Each(delegate(global::System.Data.Entity.Core.Mapping.MappingFragment tmf)
				{
					tmf.ClearConditions();
				});
			}
			return entityTypeMapping;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x0004FAA8 File Offset: 0x0004DCA8
		private bool DetermineRequiresIsTypeOf(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping tableMapping, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder, bool> <>9__2;
			return entityType.IsRootOfSet(tableMapping.EntityTypes.GetEntityTypes(entitySet)) && ((tableMapping.EntityTypes.GetEntityTypes(entitySet).Count<global::System.Data.Entity.Core.Metadata.Edm.EntityType>() > 1 && tableMapping.EntityTypes.GetEntityTypes(entitySet).Any((global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => et != entityType && !et.Abstract)) || this._tableMappings.Values.Any(delegate(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping tm)
			{
				if (tm != tableMapping)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder> foreignKeyBuilders = tm.Table.ForeignKeyBuilders;
					global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder, bool> predicate;
					if ((predicate = <>9__2) == null)
					{
						predicate = (<>9__2 = ((global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk) => fk.GetIsTypeConstraint() && fk.PrincipalTable == tableMapping.Table));
					}
					return foreignKeyBuilders.Any(predicate);
				}
				return false;
			}));
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0004FB44 File Offset: 0x0004DD44
		private static bool DetermineRequiresSplitEntityTypeMapping(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping tableMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, bool requiresIsTypeOf)
		{
			return requiresIsTypeOf && global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingService.HasConditions(tableMapping, entityType);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0004FB54 File Offset: 0x0004DD54
		private bool FindPropertyEntityTypeMapping(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping tableMapping, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, bool requiresIsTypeOf, out global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, out global::System.Data.Entity.Core.Mapping.MappingFragment fragment)
		{
			entityTypeMapping = null;
			fragment = null;
			var <>f__AnonymousType = (from etm in this._databaseMapping.GetEntityTypeMappings(entityType)
			from tmf in etm.MappingFragments
			where tmf.Table == tableMapping.Table
			select new
			{
				TypeMapping = etm,
				Fragment = tmf
			}).SingleOrDefault();
			if (<>f__AnonymousType == null)
			{
				return false;
			}
			entityTypeMapping = <>f__AnonymousType.TypeMapping;
			fragment = <>f__AnonymousType.Fragment;
			if (!requiresIsTypeOf && entityType.Abstract)
			{
				this.RemoveFragment(entitySet, <>f__AnonymousType.TypeMapping, <>f__AnonymousType.Fragment);
				return false;
			}
			return true;
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0004FC3C File Offset: 0x0004DE3C
		private void RemoveFragment(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, global::System.Data.Entity.Core.Mapping.MappingFragment fragment)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty defaultDiscriminator = fragment.GetDefaultDiscriminator();
			if (defaultDiscriminator != null && entityTypeMapping.EntityType.BaseType != null && !entityTypeMapping.EntityType.Abstract)
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping columnMapping = this._tableMappings[fragment.Table].ColumnMappings.SingleOrDefault((global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping cm) => cm.Column == defaultDiscriminator);
				if (columnMapping != null)
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification propertyMappingSpecification = columnMapping.PropertyMappings.SingleOrDefault((global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification pm) => pm.EntityType == entityTypeMapping.EntityType);
					if (propertyMappingSpecification != null)
					{
						columnMapping.PropertyMappings.Remove(propertyMappingSpecification);
					}
				}
				defaultDiscriminator.Nullable = true;
			}
			if (entityTypeMapping.EntityType.Abstract)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping> columnMappings = this._tableMappings[fragment.Table].ColumnMappings;
				global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping, bool> <>9__2;
				global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping, bool> predicate;
				if ((predicate = <>9__2) == null)
				{
					global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification, bool> <>9__3;
					predicate = (<>9__2 = delegate(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping cm)
					{
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification> propertyMappings = cm.PropertyMappings;
						global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification, bool> predicate2;
						if ((predicate2 = <>9__3) == null)
						{
							predicate2 = (<>9__3 = ((global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification pm) => pm.EntityType == entityTypeMapping.EntityType));
						}
						return propertyMappings.All(predicate2);
					});
				}
				foreach (global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping columnMapping2 in columnMappings.Where(predicate))
				{
					fragment.Table.RemoveMember(columnMapping2.Column);
				}
			}
			entityTypeMapping.RemoveFragment(fragment);
			if (!entityTypeMapping.MappingFragments.Any<global::System.Data.Entity.Core.Mapping.MappingFragment>())
			{
				this._databaseMapping.GetEntitySetMapping(entitySet).RemoveTypeMapping(entityTypeMapping);
			}
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x0004FDBC File Offset: 0x0004DFBC
		private static void RemoveRedundantDefaultDiscriminators(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping tableMapping)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> enumerator = tableMapping.EntityTypes.GetEntitySets().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = enumerator.Current;
					(from cm in tableMapping.ColumnMappings
					from pm in cm.PropertyMappings
					where (from pm1 in cm.PropertyMappings
					where tableMapping.EntityTypes.GetEntityTypes(entitySet).Contains(pm1.EntityType)
					select pm1).Count((global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification pms) => pms.IsDefaultDiscriminatorCondition) == 1
					select new
					{
						ColumnMapping = cm,
						PropertyMapping = pm
					}).ToArray().Each(delegate(x)
					{
						x.PropertyMapping.Conditions.Clear();
						if (x.PropertyMapping.PropertyPath == null)
						{
							x.ColumnMapping.PropertyMappings.Remove(x.PropertyMapping);
						}
					});
				}
			}
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0004FEE4 File Offset: 0x0004E0E4
		private static bool HasConditions(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping tableMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return tableMapping.ColumnMappings.SelectMany((global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping cm) => cm.PropertyMappings).Any((global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification pm) => pm.EntityType == entityType && pm.Conditions.Count > 0);
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x0004FF3C File Offset: 0x0004E13C
		private static bool IsRootTypeMapping(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.EntityTypeMapping> rootMappings, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> propertyPath)
		{
			global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> <>9__1;
			for (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType; entityType2 != null; entityType2 = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType2.BaseType)
			{
				global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping;
				if (rootMappings.TryGetValue(entityType2, out entityTypeMapping))
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> source = entityTypeMapping.MappingFragments.SelectMany((global::System.Data.Entity.Core.Mapping.MappingFragment etmf) => etmf.ColumnMappings);
					global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> predicate;
					if ((predicate = <>9__1) == null)
					{
						predicate = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm) => pm.PropertyPath.SequenceEqual(propertyPath)));
					}
					return source.Any(predicate);
				}
			}
			return false;
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x0004FFD0 File Offset: 0x0004E1D0
		private global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping FindOrCreateTableMapping(global::System.Data.Entity.Core.Metadata.Edm.EntityType table)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping tableMapping;
			if (!this._tableMappings.TryGetValue(table, out tableMapping))
			{
				tableMapping = new global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping(table);
				this._tableMappings.Add(table, tableMapping);
			}
			return tableMapping;
		}

		// Token: 0x04000AE3 RID: 2787
		private readonly global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping _databaseMapping;

		// Token: 0x04000AE4 RID: 2788
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableMapping> _tableMappings;

		// Token: 0x04000AE5 RID: 2789
		private global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.SortedEntityTypeIndex _entityTypes;
	}
}
