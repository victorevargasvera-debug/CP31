using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration.Mapping
{
	// Token: 0x02000210 RID: 528
	internal static class ForeignKeyPrimitiveOperations
	{
		// Token: 0x06001C0B RID: 7179 RVA: 0x0004DEDC File Offset: 0x0004C0DC
		public static void UpdatePrincipalTables(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, bool isMappingAnyInheritedProperty)
		{
			if (fromTable != toTable)
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.UpdatePrincipalTables(databaseMapping, toTable, entityType, false);
				if (isMappingAnyInheritedProperty)
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.UpdatePrincipalTables(databaseMapping, toTable, (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType, true);
				}
			}
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0004DF04 File Offset: 0x0004C104
		private static void UpdatePrincipalTables(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, bool removeFks)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> associationTypes = databaseMapping.Model.AssociationTypes;
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, bool> <>9__0;
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType at) => at.SourceEnd.GetEntityType().Equals(entityType) || at.TargetEnd.GetEntityType().Equals(entityType)));
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType in associationTypes.Where(predicate))
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.UpdatePrincipalTables(databaseMapping, toTable, removeFks, associationType, entityType);
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0004DF90 File Offset: 0x0004C190
		private static void UpdatePrincipalTables(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, bool removeFks, global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.EntityType et)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>();
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember item;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
			if (associationType.TryGuessPrincipalAndDependentEnds(out item, out associationEndMember))
			{
				list.Add(item);
			}
			else if (associationType.SourceEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many && associationType.TargetEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
			{
				list.Add(associationType.SourceEnd);
				list.Add(associationType.TargetEnd);
			}
			else
			{
				list.Add(associationType.SourceEnd);
			}
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.EntityTypeMapping> <>9__0;
			global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> <>9__5;
			global::System.Func<global::System.Data.Entity.Core.Mapping.EntityTypeMapping, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment>> <>9__2;
			global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> <>9__8;
			global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>> <>9__4;
			global::System.Func<global::System.Data.Entity.Core.Mapping.AssociationSetMapping, bool> <>9__10;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2 in list)
			{
				if (associationEndMember2.GetEntityType() == et)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>> enumerable;
					if (associationType.Constraint != null)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = associationType.GetOtherEnd(associationEndMember2).GetEntityType();
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> selfAndAllDerivedTypes = databaseMapping.Model.GetSelfAndAllDerivedTypes(entityType);
						global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.EntityTypeMapping> selector;
						if ((selector = <>9__0) == null)
						{
							selector = (<>9__0 = ((global::System.Data.Entity.Core.Metadata.Edm.EntityType t) => databaseMapping.GetEntityTypeMapping(t)));
						}
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> source = from dm in selfAndAllDerivedTypes.Select(selector)
						where dm != null
						select dm;
						global::System.Func<global::System.Data.Entity.Core.Mapping.EntityTypeMapping, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment>> selector2;
						if ((selector2 = <>9__2) == null)
						{
							selector2 = (<>9__2 = delegate(global::System.Data.Entity.Core.Mapping.EntityTypeMapping dm)
							{
								global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment> mappingFragments = dm.MappingFragments;
								global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> predicate3;
								if ((predicate3 = <>9__5) == null)
								{
									predicate3 = (<>9__5 = ((global::System.Data.Entity.Core.Mapping.MappingFragment tmf) => associationType.Constraint.ToProperties.All((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => tmf.ColumnMappings.Any((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm) => pm.PropertyPath.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() == p))));
								}
								return mappingFragments.Where(predicate3);
							});
						}
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment> source2 = source.SelectMany(selector2).Distinct((global::System.Data.Entity.Core.Mapping.MappingFragment f1, global::System.Data.Entity.Core.Mapping.MappingFragment f2) => f1.Table == f2.Table);
						global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>> selector3;
						if ((selector3 = <>9__4) == null)
						{
							selector3 = (<>9__4 = delegate(global::System.Data.Entity.Core.Mapping.MappingFragment df)
							{
								global::System.Data.Entity.Core.Metadata.Edm.EntityType table2 = df.Table;
								global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> columnMappings = df.ColumnMappings;
								global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> predicate3;
								if ((predicate3 = <>9__8) == null)
								{
									predicate3 = (<>9__8 = ((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm) => associationType.Constraint.ToProperties.Contains(pm.PropertyPath.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())));
								}
								return new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>(table2, from pm in columnMappings.Where(predicate3)
								select pm.ColumnProperty);
							});
						}
						enumerable = source2.Select(selector3);
					}
					else
					{
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.AssociationSetMapping> associationSetMappings = databaseMapping.EntityContainerMappings.Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().AssociationSetMappings;
						global::System.Func<global::System.Data.Entity.Core.Mapping.AssociationSetMapping, bool> predicate;
						if ((predicate = <>9__10) == null)
						{
							predicate = (<>9__10 = ((global::System.Data.Entity.Core.Mapping.AssociationSetMapping asm) => asm.AssociationSet.ElementType == associationType));
						}
						global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping = associationSetMappings.Single(predicate);
						global::System.Data.Entity.Core.Metadata.Edm.EntityType table = associationSetMapping.Table;
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> value = from pm in (associationSetMapping.SourceEndMapping.AssociationEnd == associationEndMember2) ? associationSetMapping.SourceEndMapping.PropertyMappings : associationSetMapping.TargetEndMapping.PropertyMappings
						select pm.Column;
						enumerable = new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>[]
						{
							new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>(table, value)
						};
					}
					using (global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>> enumerator2 = enumerable.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> tableInfo = enumerator2.Current;
							global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder> foreignKeyBuilders = tableInfo.Key.ForeignKeyBuilders;
							global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder, bool> predicate2;
							global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder, bool> <>9__12;
							if ((predicate2 = <>9__12) == null)
							{
								predicate2 = (<>9__12 = ((global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk) => fk.DependentColumns.SequenceEqual(tableInfo.Value)));
							}
							foreach (global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder foreignKeyBuilder in foreignKeyBuilders.Where(predicate2).ToArray<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder>())
							{
								if (removeFks)
								{
									tableInfo.Key.RemoveForeignKey(foreignKeyBuilder);
								}
								else if (foreignKeyBuilder.GetAssociationType() == null || foreignKeyBuilder.GetAssociationType() == associationType)
								{
									foreignKeyBuilder.PrincipalTable = toTable;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0004E318 File Offset: 0x0004C518
		private static void MoveForeignKeyConstraint(global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk)
		{
			fromTable.RemoveForeignKey(fk);
			if (fk.PrincipalTable == toTable)
			{
				if (fk.DependentColumns.All((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c) => c.IsPrimaryKeyColumn))
				{
					return;
				}
			}
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> dependentColumns = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.GetDependentColumns(fk.DependentColumns.ToArray<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(), toTable.Properties);
			if (!global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.ContainsEquivalentForeignKey(toTable, fk.PrincipalTable, dependentColumns))
			{
				toTable.AddForeignKey(fk);
				fk.DependentColumns = dependentColumns;
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0004E398 File Offset: 0x0004C598
		private static void CopyForeignKeyConstraint(global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> selector = null)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder foreignKeyBuilder = new global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder(database, database.EntityTypes.SelectMany((global::System.Data.Entity.Core.Metadata.Edm.EntityType t) => t.ForeignKeyBuilders).UniquifyName(fk.Name))
			{
				PrincipalTable = fk.PrincipalTable,
				DeleteAction = fk.DeleteAction
			};
			foreignKeyBuilder.SetPreferredName(fk.Name);
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> dependentColumns = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.GetDependentColumns((selector != null) ? fk.DependentColumns.Select(selector) : fk.DependentColumns, toTable.Properties);
			if (!global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.ContainsEquivalentForeignKey(toTable, foreignKeyBuilder.PrincipalTable, dependentColumns))
			{
				toTable.AddForeignKey(foreignKeyBuilder);
				foreignKeyBuilder.DependentColumns = dependentColumns;
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0004E448 File Offset: 0x0004C648
		private static bool ContainsEquivalentForeignKey(global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType principalTable, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> columns)
		{
			return dependentTable.ForeignKeyBuilders.Any((global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk) => fk.PrincipalTable == principalTable && fk.DependentColumns.SequenceEqual(columns));
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0004E480 File Offset: 0x0004C680
		private static global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetDependentColumns(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> sourceColumns, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> destinationColumns)
		{
			return (from sc in sourceColumns
			select destinationColumns.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty dc) => string.Equals(dc.Name, sc.Name, global::System.StringComparison.Ordinal)) ?? destinationColumns.Single((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty dc) => string.Equals(dc.GetUnpreferredUniqueName(), sc.Name, global::System.StringComparison.Ordinal))).ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0004E4B4 File Offset: 0x0004C6B4
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder> FindAllForeignKeyConstraintsForColumn(global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column)
		{
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool> <>9__1;
			return fromTable.ForeignKeyBuilders.Where(delegate(global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk)
			{
				if (fk.DependentColumns.Contains(column))
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> dependentColumns = fk.DependentColumns;
					global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool> predicate;
					if ((predicate = <>9__1) == null)
					{
						predicate = (<>9__1 = ((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c) => toTable.Properties.Any((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty nc) => string.Equals(nc.Name, c.Name, global::System.StringComparison.Ordinal) || string.Equals(nc.GetUnpreferredUniqueName(), c.Name, global::System.StringComparison.Ordinal))));
					}
					return dependentColumns.All(predicate);
				}
				return false;
			});
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0004E4EC File Offset: 0x0004C6EC
		public static void CopyAllForeignKeyConstraintsForColumn(global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty movedColumn)
		{
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> <>9__1;
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.FindAllForeignKeyConstraintsForColumn(fromTable, toTable, column).ToArray<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder>().Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmModel database2 = database;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable2 = toTable;
				global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> selector;
				if ((selector = <>9__1) == null)
				{
					selector = (<>9__1 = delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c)
					{
						if (c != column)
						{
							return c;
						}
						return movedColumn;
					});
				}
				global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.CopyForeignKeyConstraint(database2, toTable2, fk, selector);
			});
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0004E544 File Offset: 0x0004C744
		public static void MoveAllDeclaredForeignKeyConstraintsForPrimaryKeyColumns(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable)
		{
			global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder> <>9__0;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column in fromTable.KeyProperties)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder> ts = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.FindAllForeignKeyConstraintsForColumn(fromTable, toTable, column).ToArray<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder>();
				global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder> action;
				if ((action = <>9__0) == null)
				{
					action = (<>9__0 = delegate(global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk)
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = fk.GetAssociationType();
						if (associationType != null && associationType.Constraint.ToRole.GetEntityType() == entityType && !fk.GetIsTypeConstraint())
						{
							global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.MoveForeignKeyConstraint(fromTable, toTable, fk);
						}
					});
				}
				ts.Each(action);
			}
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0004E5EC File Offset: 0x0004C7EC
		public static void CopyAllForeignKeyConstraintsForPrimaryKeyColumns(global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable)
		{
			global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder> <>9__0;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column in fromTable.KeyProperties)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder> ts = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.FindAllForeignKeyConstraintsForColumn(fromTable, toTable, column).ToArray<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder>();
				global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder> action;
				if ((action = <>9__0) == null)
				{
					action = (<>9__0 = delegate(global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk)
					{
						if (!fk.GetIsTypeConstraint())
						{
							global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.CopyForeignKeyConstraint(database, toTable, fk, null);
						}
					});
				}
				ts.Each(action);
			}
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0004E684 File Offset: 0x0004C884
		public static void MoveAllForeignKeyConstraintsForColumn(global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.FindAllForeignKeyConstraintsForColumn(fromTable, toTable, column).ToArray<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder>().Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk)
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.MoveForeignKeyConstraint(fromTable, toTable, fk);
			});
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0004E6D0 File Offset: 0x0004C8D0
		public static void RemoveAllForeignKeyConstraintsForColumn(global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			(from fk in table.ForeignKeyBuilders
			where fk.DependentColumns.Contains(column)
			select fk).ToArray<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder>().Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk)
			{
				table.RemoveForeignKey(fk);
				global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder foreignKeyBuilder = databaseMapping.Database.EntityTypes.SelectMany((global::System.Data.Entity.Core.Metadata.Edm.EntityType t) => t.ForeignKeyBuilders).SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk2) => object.Equals(fk2.GetPreferredName(), fk.Name));
				if (foreignKeyBuilder != null)
				{
					foreignKeyBuilder.Name = foreignKeyBuilder.GetPreferredName();
				}
			});
		}
	}
}
