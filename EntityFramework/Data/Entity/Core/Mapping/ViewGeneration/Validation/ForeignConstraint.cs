using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x0200057E RID: 1406
	internal class ForeignConstraint : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004426 RID: 17446 RVA: 0x000EDD88 File Offset: 0x000EBF88
		internal ForeignConstraint(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet i_fkeySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet i_parentTable, global::System.Data.Entity.Core.Metadata.Edm.EntitySet i_childTable, global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> i_parentColumns, global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> i_childColumns)
		{
			this.m_fKeySet = i_fkeySet;
			this.m_parentTable = i_parentTable;
			this.m_childTable = i_childTable;
			this.m_childColumns = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty member in i_childColumns)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath item = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(this.m_childTable, member);
				this.m_childColumns.Add(item);
			}
			this.m_parentColumns = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty member2 in i_parentColumns)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath item2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(this.m_parentTable, member2);
				this.m_parentColumns.Add(item2);
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06004427 RID: 17447 RVA: 0x000EDE6C File Offset: 0x000EC06C
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet ParentTable
		{
			get
			{
				return this.m_parentTable;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06004428 RID: 17448 RVA: 0x000EDE74 File Offset: 0x000EC074
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet ChildTable
		{
			get
			{
				return this.m_childTable;
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06004429 RID: 17449 RVA: 0x000EDE7C File Offset: 0x000EC07C
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> ChildColumns
		{
			get
			{
				return this.m_childColumns;
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x000EDE84 File Offset: 0x000EC084
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> ParentColumns
		{
			get
			{
				return this.m_parentColumns;
			}
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x000EDE8C File Offset: 0x000EC08C
		internal static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint> GetForeignConstraints(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in container.BaseEntitySets)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = entitySetBase as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
				if (associationSet != null)
				{
					global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
					foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSet.AssociationSetEnds)
					{
						dictionary.Add(associationSetEnd.Name, associationSetEnd.EntitySet);
					}
					foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in associationSet.ElementType.ReferentialConstraints)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EntitySet i_parentTable = dictionary[referentialConstraint.FromRole.Name];
						global::System.Data.Entity.Core.Metadata.Edm.EntitySet i_childTable = dictionary[referentialConstraint.ToRole.Name];
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint item = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint(associationSet, i_parentTable, i_childTable, referentialConstraint.FromProperties, referentialConstraint.ToProperties);
						list.Add(item);
					}
				}
			}
			return list;
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x000EDFD4 File Offset: 0x000EC1D4
		internal void CheckConstraint(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter childRewriter, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter parentRewriter, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			if (!this.IsConstraintRelevantForCells(cells))
			{
				return;
			}
			if (config.IsNormalTracing)
			{
				global::System.Diagnostics.Trace.WriteLine(string.Empty);
				global::System.Diagnostics.Trace.WriteLine(string.Empty);
				global::System.Diagnostics.Trace.Write("Checking: ");
				global::System.Diagnostics.Trace.WriteLine(this);
			}
			if (childRewriter == null && parentRewriter == null)
			{
				return;
			}
			if (childRewriter == null)
			{
				string message = global::System.Data.Entity.Resources.Strings.ViewGen_Foreign_Key_Missing_Table_Mapping(this.ToUserString(), this.ChildTable.Name);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ForeignKeyMissingTableMapping, message, parentRewriter.UsedCells, string.Empty);
				errorLog.AddEntry(record);
				return;
			}
			if (parentRewriter == null)
			{
				string message2 = global::System.Data.Entity.Resources.Strings.ViewGen_Foreign_Key_Missing_Table_Mapping(this.ToUserString(), this.ParentTable.Name);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ForeignKeyMissingTableMapping, message2, childRewriter.UsedCells, string.Empty);
				errorLog.AddEntry(record2);
				return;
			}
			if (this.CheckIfConstraintMappedToForeignKeyAssociation(childRewriter, cells))
			{
				return;
			}
			int count = errorLog.Count;
			if (this.IsForeignKeySuperSetOfPrimaryKeyInChildTable())
			{
				this.GuaranteeForeignKeyConstraintInCSpace(childRewriter, parentRewriter, errorLog);
			}
			else
			{
				this.GuaranteeMappedRelationshipForForeignKey(childRewriter, parentRewriter, cells, errorLog, config);
			}
			if (count == errorLog.Count)
			{
				this.CheckForeignKeyColumnOrder(cells, errorLog);
			}
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x000EE0DC File Offset: 0x000EC2DC
		private void GuaranteeForeignKeyConstraintInCSpace(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter childRewriter, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter parentRewriter, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext viewgenContext = childRewriter.ViewgenContext;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext viewgenContext2 = parentRewriter.ViewgenContext;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode basicView = childRewriter.BasicView;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode basicView2 = parentRewriter.BasicView;
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor.Merge(viewgenContext.RightFragmentQP, viewgenContext2.RightFragmentQP).IsContainedIn(basicView.RightFragmentQuery, basicView2.RightFragmentQuery))
			{
				string message = global::System.Data.Entity.Resources.Strings.ViewGen_Foreign_Key_Not_Guaranteed_InCSpace(this.ToUserString());
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>(basicView2.GetLeaves());
				set.AddRange(basicView.GetLeaves());
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ForeignKeyNotGuaranteedInCSpace, message, set, string.Empty);
				errorLog.AddEntry(record);
			}
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x000EE16C File Offset: 0x000EC36C
		private void GuaranteeMappedRelationshipForForeignKey(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter childRewriter, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter parentRewriter, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext viewgenContext = childRewriter.ViewgenContext;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext viewgenContext2 = parentRewriter.ViewgenContext;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> keyFields = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetPrimaryKeyForEntityType(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(this.ChildTable), this.ChildTable.ElementType).KeyFields;
			bool flag = false;
			bool flag2 = false;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record> list = null;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cells)
			{
				if (cell.SQuery.Extent.Equals(this.ChildTable))
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember relationEndForColumns = global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.GetRelationEndForColumns(cell, this.ChildColumns);
					if (relationEndForColumns == null || this.CheckParentColumnsForForeignKey(cell, cells, relationEndForColumns, ref list))
					{
						flag2 = true;
						if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.GetRelationEndForColumns(cell, keyFields) != null && relationEndForColumns != null && global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.FindEntitySetForColumnsMappedToEntityKeys(cells, keyFields).Count > 0)
						{
							flag = true;
							this.CheckConstraintWhenParentChildMapped(cell, errorLog, relationEndForColumns, config);
							break;
						}
						if (relationEndForColumns != null)
						{
							flag = global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.CheckConstraintWhenOnlyParentMapped((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)cell.CQuery.Extent, relationEndForColumns, childRewriter, parentRewriter);
							if (flag)
							{
								break;
							}
						}
					}
				}
			}
			if (!flag2)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record in list)
				{
					errorLog.AddEntry(record);
				}
				return;
			}
			if (!flag)
			{
				string message = global::System.Data.Entity.Resources.Strings.ViewGen_Foreign_Key_Missing_Relationship_Mapping(this.ToUserString());
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> wrappersFromContext = global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.GetWrappersFromContext(viewgenContext2, this.ParentTable);
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> wrappersFromContext2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.GetWrappersFromContext(viewgenContext, this.ChildTable);
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>(wrappersFromContext);
				set.AddRange(wrappersFromContext2);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ForeignKeyMissingRelationshipMapping, message, set, string.Empty);
				errorLog.AddEntry(record2);
			}
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x000EE324 File Offset: 0x000EC524
		private bool CheckIfConstraintMappedToForeignKeyAssociation(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter childRewriter, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext viewgenContext = childRewriter.ViewgenContext;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cells)
			{
				if (cell.CQuery.Extent.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet)
				{
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> cslotsForTableColumns = cell.GetCSlotsForTableColumns(this.ChildColumns);
					if (cslotsForTableColumns != null && cslotsForTableColumns.Count != 0)
					{
						list.Add(cslotsForTableColumns);
					}
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> cslotsForTableColumns2 = cell.GetCSlotsForTableColumns(this.ParentColumns);
					if (cslotsForTableColumns2 != null && cslotsForTableColumns2.Count != 0)
					{
						list2.Add(cslotsForTableColumns2);
					}
				}
			}
			if (list.Count != 0 && list2.Count != 0)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType in from it in viewgenContext.EntityContainerMapping.EdmEntityContainer.BaseEntitySets.OfType<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>()
				where it.ElementType.IsForeignKey
				select it.ElementType)
				{
					global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint refConstraint = associationType.ReferentialConstraints.FirstOrDefault<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>();
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> enumerable = list.Where((global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> it) => it.SetEquals(new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(refConstraint.ToProperties)));
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> enumerable2 = list2.Where((global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> it) => it.SetEquals(new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(refConstraint.FromProperties)));
					if (enumerable.Count<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>() != 0 && enumerable2.Count<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>() != 0)
					{
						foreach (global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties in enumerable2)
						{
							global::System.Data.Entity.Core.Common.Utils.Set<int> propertyIndexes = global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.GetPropertyIndexes(properties, refConstraint.FromProperties);
							using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>> enumerator4 = enumerable.GetEnumerator())
							{
								while (enumerator4.MoveNext())
								{
									if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.GetPropertyIndexes(enumerator4.Current, refConstraint.ToProperties).SequenceEqual(propertyIndexes))
									{
										return true;
									}
								}
							}
						}
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x000EE588 File Offset: 0x000EC788
		private static global::System.Data.Entity.Core.Common.Utils.Set<int> GetPropertyIndexes(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties1, global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties2)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<int> set = new global::System.Data.Entity.Core.Common.Utils.Set<int>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty value in properties1)
			{
				set.Add(properties2.IndexOf(value));
			}
			return set;
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x000EE5E0 File Offset: 0x000EC7E0
		private static bool CheckConstraintWhenOnlyParentMapped(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet assocSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember endMember, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter childRewriter, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter parentRewriter)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext viewgenContext = childRewriter.ViewgenContext;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext viewgenContext2 = parentRewriter.ViewgenContext;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode basicView = parentRewriter.BasicView;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean literal = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean(assocSet.AssociationSetEnds[endMember.Name]);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause = basicView.RightFragmentQuery.Condition.Create(literal);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(basicView.RightFragmentQuery.Attributes, whereClause);
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor.Merge(viewgenContext.RightFragmentQP, viewgenContext2.RightFragmentQP).IsContainedIn(q, basicView.RightFragmentQuery);
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x000EE65C File Offset: 0x000EC85C
		private bool CheckConstraintWhenParentChildMapped(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember parentEnd, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			bool flag = true;
			if (parentEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
			{
				string message = global::System.Data.Entity.Resources.Strings.ViewGen_Foreign_Key_UpperBound_MustBeOne(this.ToUserString(), cell.CQuery.Extent.Name, parentEnd.Name);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ForeignKeyUpperBoundMustBeOne, message, cell, string.Empty);
				errorLog.AddEntry(record);
				flag = false;
			}
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.AreAllMembersNullable(this.ChildColumns) && parentEnd.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)
			{
				string message2 = global::System.Data.Entity.Resources.Strings.ViewGen_Foreign_Key_LowerBound_MustBeOne(this.ToUserString(), cell.CQuery.Extent.Name, parentEnd.Name);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ForeignKeyLowerBoundMustBeOne, message2, cell, string.Empty);
				errorLog.AddEntry(record2);
				flag = false;
			}
			if (config.IsNormalTracing && flag)
			{
				global::System.Diagnostics.Trace.WriteLine("Foreign key mapped to relationship " + cell.CQuery.Extent.Name);
			}
			return flag;
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x000EE734 File Offset: 0x000EC934
		private bool CheckParentColumnsForForeignKey(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember parentEnd, ref global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record> errorList)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetAtEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntitySetAtEnd((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)cell.CQuery.Extent, parentEnd);
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.FindEntitySetForColumnsMappedToEntityKeys(cells, this.ParentColumns).Contains(entitySetAtEnd))
			{
				if (errorList == null)
				{
					errorList = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record>();
				}
				string message = global::System.Data.Entity.Resources.Strings.ViewGen_Foreign_Key_ParentTable_NotMappedToEnd(this.ToUserString(), this.ChildTable.Name, cell.CQuery.Extent.Name, parentEnd.Name, this.ParentTable.Name, entitySetAtEnd.Name);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record item = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ForeignKeyParentTableNotMappedToEnd, message, cell, string.Empty);
				errorList.Add(item);
				return false;
			}
			return true;
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x000EE7D8 File Offset: 0x000EC9D8
		private static global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> FindEntitySetForColumnsMappedToEntityKeys(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> tableColumns)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cells)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cquery = cell.CQuery;
				if (!(cquery.Extent is global::System.Data.Entity.Core.Metadata.Edm.AssociationSet))
				{
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> cslotsForTableColumns = cell.GetCSlotsForTableColumns(tableColumns);
					if (cslotsForTableColumns != null)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)cquery.Extent;
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
						foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in entitySet.ElementType.KeyMembers)
						{
							global::System.Data.Entity.Core.Metadata.Edm.EdmProperty item = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)edmMember;
							list2.Add(item);
						}
						if (new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(list2).MakeReadOnly().SetEquals(cslotsForTableColumns))
						{
							list.Add(entitySet);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x000EE8CC File Offset: 0x000ECACC
		private static global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember GetRelationEndForColumns(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> columns)
		{
			if (cell.CQuery.Extent is global::System.Data.Entity.Core.Metadata.Edm.EntitySet)
			{
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)cell.CQuery.Extent;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSet.AssociationSetEnds)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember correspondingAssociationEndMember = associationSetEnd.CorrespondingAssociationEndMember;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey primaryKeyForEntityType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetPrimaryKeyForEntityType(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(associationSet, correspondingAssociationEndMember), associationSetEnd.EntitySet.ElementType);
				global::System.Collections.Generic.List<int> projectedPositions = cell.CQuery.GetProjectedPositions(primaryKeyForEntityType.KeyFields);
				if (projectedPositions != null)
				{
					global::System.Collections.Generic.List<int> projectedPositions2 = cell.SQuery.GetProjectedPositions(columns, projectedPositions);
					if (projectedPositions2 != null && global::System.Data.Entity.Core.Common.Utils.Helpers.IsSetEqual<int>(projectedPositions2, projectedPositions, global::System.Collections.Generic.EqualityComparer<int>.Default))
					{
						return correspondingAssociationEndMember;
					}
				}
			}
			return null;
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x000EE9A4 File Offset: 0x000ECBA4
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> GetWrappersFromContext(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> result;
			if (context == null)
			{
				result = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>();
			}
			else
			{
				result = context.AllWrappersForExtent;
			}
			return result;
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x000EE9C4 File Offset: 0x000ECBC4
		private bool CheckForeignKeyColumnOrder(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cells)
			{
				if (cell.SQuery.Extent.Equals(this.ChildTable))
				{
					list2.Add(cell);
				}
				if (cell.SQuery.Extent.Equals(this.ParentTable))
				{
					list.Add(cell);
				}
			}
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell2 in list2)
			{
				global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>> slotNumsForColumns = global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.GetSlotNumsForColumns(cell2, this.ChildColumns);
				if (slotNumsForColumns.Count != 0)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> list3 = null;
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> list4 = null;
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell3 = null;
					foreach (global::System.Collections.Generic.List<int> list5 in slotNumsForColumns)
					{
						list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(list5.Count);
						foreach (int slotNum in list5)
						{
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)cell2.CQuery.ProjectedSlotAt(slotNum);
							list3.Add(memberProjectedSlot.MemberPath);
						}
						foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell4 in list)
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>> slotNumsForColumns2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.GetSlotNumsForColumns(cell4, this.ParentColumns);
							if (slotNumsForColumns2.Count != 0)
							{
								foreach (global::System.Collections.Generic.List<int> list6 in slotNumsForColumns2)
								{
									list4 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(list6.Count);
									foreach (int slotNum2 in list6)
									{
										global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot2 = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)cell4.CQuery.ProjectedSlotAt(slotNum2);
										list4.Add(memberProjectedSlot2.MemberPath);
									}
									if (list3.Count == list4.Count)
									{
										bool flag = false;
										int num = 0;
										while (num < list3.Count && !flag)
										{
											global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = list4[num];
											global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath2 = list3[num];
											if (!memberPath.LeafEdmMember.Equals(memberPath2.LeafEdmMember))
											{
												if (memberPath.IsEquivalentViaRefConstraint(memberPath2))
												{
													return true;
												}
												flag = true;
											}
											num++;
										}
										if (!flag)
										{
											return true;
										}
										cell3 = cell4;
									}
								}
							}
						}
					}
					string message = global::System.Data.Entity.Resources.Strings.ViewGen_Foreign_Key_ColumnOrder_Incorrect(this.ToUserString(), global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.PropertiesToUserString(this.ChildColumns, false), this.ChildTable.Name, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.PropertiesToUserString(list3, false), cell2.CQuery.Extent.Name, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.PropertiesToUserString(this.ParentColumns, false), this.ParentTable.Name, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.PropertiesToUserString(list4, false), cell3.CQuery.Extent.Name);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.ForeignKeyColumnOrderIncorrect, message, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell[]
					{
						cell3,
						cell2
					}, string.Empty);
					errorLog.AddEntry(record);
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x000EEDCC File Offset: 0x000ECFCC
		private static global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>> GetSlotNumsForColumns(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> columns)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>();
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = cell.CQuery.Extent as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
			if (associationSet != null)
			{
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>.Enumerator enumerator = associationSet.AssociationSetEnds.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = enumerator.Current;
						global::System.Collections.Generic.List<int> associationEndSlots = cell.CQuery.GetAssociationEndSlots(associationSetEnd.CorrespondingAssociationEndMember);
						global::System.Collections.Generic.List<int> projectedPositions = cell.SQuery.GetProjectedPositions(columns, associationEndSlots);
						if (projectedPositions != null)
						{
							list.Add(projectedPositions);
						}
					}
					return list;
				}
			}
			global::System.Collections.Generic.List<int> projectedPositions2 = cell.SQuery.GetProjectedPositions(columns);
			if (projectedPositions2 != null)
			{
				list.Add(projectedPositions2);
			}
			return list;
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x000EEE7C File Offset: 0x000ED07C
		private bool IsForeignKeySuperSetOfPrimaryKeyInChildTable()
		{
			bool result = true;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in this.m_childTable.ElementType.KeyMembers)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty obj = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)edmMember;
				bool flag = false;
				using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>.Enumerator enumerator2 = this.m_childColumns.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.LeafEdmMember.Equals(obj))
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x000EEF30 File Offset: 0x000ED130
		private bool IsConstraintRelevantForCells(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells)
		{
			bool result = false;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cells)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent = cell.SQuery.Extent;
				if (extent.Equals(this.m_parentTable) || extent.Equals(this.m_childTable))
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x000EEFA0 File Offset: 0x000ED1A0
		internal string ToUserString()
		{
			string p = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.PropertiesToUserString(this.m_childColumns, false);
			string p2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.PropertiesToUserString(this.m_parentColumns, false);
			return global::System.Data.Entity.Resources.Strings.ViewGen_Foreign_Key(this.m_fKeySet.Name, this.m_childTable.Name, p, this.m_parentTable.Name, p2);
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x000EEFEF File Offset: 0x000ED1EF
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append(this.m_fKeySet.Name + ": ");
			builder.Append(this.ToUserString());
		}

		// Token: 0x04001892 RID: 6290
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationSet m_fKeySet;

		// Token: 0x04001893 RID: 6291
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet m_parentTable;

		// Token: 0x04001894 RID: 6292
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet m_childTable;

		// Token: 0x04001895 RID: 6293
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> m_parentColumns;

		// Token: 0x04001896 RID: 6294
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> m_childColumns;
	}
}
