using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x02000564 RID: 1380
	internal class CellCreator : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004366 RID: 17254 RVA: 0x000E7525 File Offset: 0x000E5725
		internal CellCreator(global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping)
		{
			this.m_containerMapping = containerMapping;
			this.m_identifiers = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers();
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06004367 RID: 17255 RVA: 0x000E753F File Offset: 0x000E573F
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers Identifiers
		{
			get
			{
				return this.m_identifiers;
			}
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x000E7548 File Offset: 0x000E5748
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> GenerateCells()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>();
			this.ExtractCells(list);
			this.ExpandCells(list);
			this.m_identifiers.AddIdentifier(this.m_containerMapping.EdmEntityContainer.Name);
			this.m_identifiers.AddIdentifier(this.m_containerMapping.StorageEntityContainer.Name);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in list)
			{
				cell.GetIdentifiers(this.m_identifiers);
			}
			return list;
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x000E75E4 File Offset: 0x000E57E4
		private void ExpandCells(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
			using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>.Enumerator enumerator = cells.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell = enumerator.Current;
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> source = from member in cell.SQuery.GetProjectedMembers()
					where global::System.Data.Entity.Core.Mapping.ViewGeneration.CellCreator.IsBooleanMember(member)
					select member;
					global::System.Func<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, bool> predicate;
					global::System.Func<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, bool> <>9__1;
					if ((predicate = <>9__1) == null)
					{
						predicate = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath boolMember) => (from restriction in cell.SQuery.GetConjunctsFromWhereClause()
						where restriction.Domain.Values.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.NotNull)
						select restriction.RestrictedMemberSlot.MemberPath).Contains(boolMember)));
					}
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath element in source.Where(predicate))
					{
						set.Add(element);
					}
				}
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>>();
			using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>.Enumerator enumerator = cells.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell = enumerator.Current;
					global::System.Func<int, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> <>9__4;
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in set)
					{
						global::System.Collections.Generic.IEnumerable<int> projectedPositions = cell.SQuery.GetProjectedPositions(memberPath);
						global::System.Func<int, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> selector;
						if ((selector = <>9__4) == null)
						{
							selector = (<>9__4 = ((int pos) => ((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)cell.CQuery.ProjectedSlotAt(pos)).MemberPath));
						}
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> elements = projectedPositions.Select(selector);
						global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> set2 = null;
						if (!dictionary.TryGetValue(memberPath, out set2))
						{
							set2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
							dictionary[memberPath] = set2;
						}
						set2.AddRange(elements);
					}
				}
			}
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell2 in cells.ToArray())
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath2 in set)
				{
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> second = dictionary[memberPath2];
					if (cell2.SQuery.GetProjectedMembers().Contains(memberPath2))
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell item = null;
						if (this.TryCreateAdditionalCellWithCondition(cell2, memberPath2, true, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView, out item))
						{
							cells.Add(item);
						}
						if (this.TryCreateAdditionalCellWithCondition(cell2, memberPath2, false, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView, out item))
						{
							cells.Add(item);
						}
					}
					else
					{
						foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberToExpand in cell2.CQuery.GetProjectedMembers().Intersect(second))
						{
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell item2 = null;
							if (this.TryCreateAdditionalCellWithCondition(cell2, memberToExpand, true, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView, out item2))
							{
								cells.Add(item2);
							}
							if (this.TryCreateAdditionalCellWithCondition(cell2, memberToExpand, false, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView, out item2))
							{
								cells.Add(item2);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x000E78FC File Offset: 0x000E5AFC
		private bool TryCreateAdditionalCellWithCondition(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell originalCell, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberToExpand, bool conditionValue, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget, out global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell result)
		{
			result = null;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath sourceExtentMemberPath = originalCell.GetLeftQuery(viewTarget).SourceExtentMemberPath;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath sourceExtentMemberPath2 = originalCell.GetRightQuery(viewTarget).SourceExtentMemberPath;
			int slotNum = originalCell.GetLeftQuery(viewTarget).GetProjectedMembers().TakeWhile((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path) => !path.Equals(memberToExpand)).Count<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)originalCell.GetRightQuery(viewTarget).ProjectedSlotAt(slotNum);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath rightSidePath = memberProjectedSlot.MemberPath;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot>();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant negatedCondition = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant(!conditionValue);
			if ((from restriction in originalCell.GetLeftQuery(viewTarget).Conditions
			where restriction.RestrictedMemberSlot.MemberPath.Equals(memberToExpand)
			where restriction.Domain.Values.Contains(negatedCondition)
			select restriction).Any<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction>() || (from restriction in originalCell.GetRightQuery(viewTarget).Conditions
			where restriction.RestrictedMemberSlot.MemberPath.Equals(rightSidePath)
			where restriction.Domain.Values.Contains(negatedCondition)
			select restriction).Any<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction>())
			{
				return false;
			}
			for (int i = 0; i < originalCell.GetLeftQuery(viewTarget).NumProjectedSlots; i++)
			{
				list.Add(originalCell.GetLeftQuery(viewTarget).ProjectedSlotAt(i));
			}
			for (int j = 0; j < originalCell.GetRightQuery(viewTarget).NumProjectedSlots; j++)
			{
				list2.Add(originalCell.GetRightQuery(viewTarget).ProjectedSlotAt(j));
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction(memberToExpand, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant(conditionValue)), null);
			boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
			{
				originalCell.GetLeftQuery(viewTarget).WhereClause,
				boolExpression
			});
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction(rightSidePath, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant(conditionValue)), null);
			boolExpression2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
			{
				originalCell.GetRightQuery(viewTarget).WhereClause,
				boolExpression2
			});
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cellQuery = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery(list2, boolExpression2, sourceExtentMemberPath2, originalCell.GetRightQuery(viewTarget).SelectDistinctFlag);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cellQuery2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery(list, boolExpression, sourceExtentMemberPath, originalCell.GetLeftQuery(viewTarget).SelectDistinctFlag);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell;
			if (viewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView)
			{
				cell = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell.CreateCS(cellQuery, cellQuery2, originalCell.CellLabel, this.m_currentCellNumber);
			}
			else
			{
				cell = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell.CreateCS(cellQuery2, cellQuery, originalCell.CellLabel, this.m_currentCellNumber);
			}
			this.m_currentCellNumber++;
			result = cell;
			return true;
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x000E7B6C File Offset: 0x000E5D6C
		private void ExtractCells(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells)
		{
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping in this.m_containerMapping.AllSetMaps)
			{
				foreach (global::System.Data.Entity.Core.Mapping.TypeMapping typeMapping in entitySetBaseMapping.TypeMappings)
				{
					global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = typeMapping as global::System.Data.Entity.Core.Mapping.EntityTypeMapping;
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType>();
					if (entityTypeMapping != null)
					{
						set.AddRange(entityTypeMapping.Types);
						foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase type in entityTypeMapping.IsOfTypes)
						{
							global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> typeAndSubtypesOf = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(type, this.m_containerMapping.StorageMappingItemCollection.EdmItemCollection, false);
							set.AddRange(typeAndSubtypesOf);
						}
					}
					global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase set2 = entitySetBaseMapping.Set;
					foreach (global::System.Data.Entity.Core.Mapping.MappingFragment fragmentMap in typeMapping.MappingFragments)
					{
						this.ExtractCellsFromTableFragment(set2, fragmentMap, set, cells);
					}
				}
			}
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x000E7CC4 File Offset: 0x000E5EC4
		private void ExtractCellsFromTableFragment(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Mapping.MappingFragment fragmentMap, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType> allTypes, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(extent);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot>();
			if (allTypes.Count > 0)
			{
				whereClause = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction(memberPath, allTypes), null);
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(fragmentMap.TableSet);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression @true = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot>();
			this.ExtractProperties(fragmentMap.AllProperties, memberPath, list, ref whereClause, memberPath2, list2, ref @true);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cQuery = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery(list, whereClause, memberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct.No);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery sQuery = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery(list2, @true, memberPath2, fragmentMap.IsSQueryDistinct ? global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct.Yes : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct.No);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellLabel label = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellLabel(fragmentMap);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell item = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell.CreateCS(cQuery, sQuery, label, this.m_currentCellNumber);
			this.m_currentCellNumber++;
			cells.Add(item);
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x000E7D7C File Offset: 0x000E5F7C
		private void ExtractProperties(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.PropertyMapping> properties, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath cNode, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot> cSlots, ref global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression cQueryWhereClause, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath sRootExtent, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot> sSlots, ref global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression sQueryWhereClause)
		{
			foreach (global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping in properties)
			{
				global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping;
				global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping;
				global::System.Data.Entity.Core.Mapping.EndPropertyMapping endPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.EndPropertyMapping;
				global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping;
				if (scalarPropertyMapping != null)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath node = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(cNode, scalarPropertyMapping.Property);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath node2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(sRootExtent, scalarPropertyMapping.Column);
					cSlots.Add(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(node));
					sSlots.Add(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(node2));
				}
				if (complexPropertyMapping != null)
				{
					foreach (global::System.Data.Entity.Core.Mapping.ComplexTypeMapping complexTypeMapping in complexPropertyMapping.TypeMappings)
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(cNode, complexPropertyMapping.Property);
						global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType>();
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> elements = global::System.Data.Entity.Core.Common.Utils.Helpers.AsSuperTypeList<global::System.Data.Entity.Core.Metadata.Edm.ComplexType, global::System.Data.Entity.Core.Metadata.Edm.EdmType>(complexTypeMapping.Types);
						set.AddRange(elements);
						foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType type in complexTypeMapping.IsOfTypes)
						{
							set.AddRange(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(type, this.m_containerMapping.StorageMappingItemCollection.EdmItemCollection, false));
						}
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction(memberPath, set), null);
						cQueryWhereClause = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
						{
							cQueryWhereClause,
							boolExpression
						});
						this.ExtractProperties(complexTypeMapping.AllProperties, memberPath, cSlots, ref cQueryWhereClause, sRootExtent, sSlots, ref sQueryWhereClause);
					}
				}
				if (endPropertyMapping != null)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath cNode2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(cNode, endPropertyMapping.AssociationEnd);
					this.ExtractProperties(endPropertyMapping.PropertyMappings, cNode2, cSlots, ref cQueryWhereClause, sRootExtent, sSlots, ref sQueryWhereClause);
				}
				if (conditionPropertyMapping != null)
				{
					if (conditionPropertyMapping.Column != null)
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression conditionExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.CellCreator.GetConditionExpression(sRootExtent, conditionPropertyMapping);
						sQueryWhereClause = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
						{
							sQueryWhereClause,
							conditionExpression
						});
					}
					else
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression conditionExpression2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.CellCreator.GetConditionExpression(cNode, conditionPropertyMapping);
						cQueryWhereClause = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
						{
							cQueryWhereClause,
							conditionExpression2
						});
					}
				}
			}
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x000E7FCC File Offset: 0x000E61CC
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression GetConditionExpression(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member, global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionMap)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = (conditionMap.Column != null) ? conditionMap.Column : conditionMap.Property;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(member, edmMember);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction literal;
			if (conditionMap.IsNull != null)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant value = conditionMap.IsNull.Value ? global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.NotNull;
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsNonRefSimpleMember(edmMember))
				{
					literal = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction(member2, value);
				}
				else
				{
					literal = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction(member2, value);
				}
			}
			else
			{
				literal = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction(member2, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant(conditionMap.Value));
			}
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(literal, null);
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x000E8060 File Offset: 0x000E6260
		private static bool IsBooleanMember(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = path.EdmType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
			return primitiveType != null && primitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean;
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x000E8087 File Offset: 0x000E6287
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append("CellCreator");
		}

		// Token: 0x0400180E RID: 6158
		private readonly global::System.Data.Entity.Core.Mapping.EntityContainerMapping m_containerMapping;

		// Token: 0x0400180F RID: 6159
		private int m_currentCellNumber;

		// Token: 0x04001810 RID: 6160
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers m_identifiers;
	}
}
