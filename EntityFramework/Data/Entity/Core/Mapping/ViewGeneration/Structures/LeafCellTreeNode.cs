using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005A4 RID: 1444
	internal class LeafCellTreeNode : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode
	{
		// Token: 0x0600461B RID: 17947 RVA: 0x000F6470 File Offset: 0x000F4670
		internal LeafCellTreeNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper cellWrapper) : base(context)
		{
			this.m_cellWrapper = cellWrapper;
			this.m_rightFragmentQuery = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(cellWrapper.OriginalCellNumberString, cellWrapper.CreateRoleBoolean(), cellWrapper.RightCellQuery);
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x000F649D File Offset: 0x000F469D
		internal LeafCellTreeNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper cellWrapper, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery rightFragmentQuery) : base(context)
		{
			this.m_cellWrapper = cellWrapper;
			this.m_rightFragmentQuery = rightFragmentQuery;
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x000F64B4 File Offset: 0x000F46B4
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper LeftCellWrapper
		{
			get
			{
				return this.m_cellWrapper;
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x0600461E RID: 17950 RVA: 0x000F64BC File Offset: 0x000F46BC
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap RightDomainMap
		{
			get
			{
				return this.m_cellWrapper.RightDomainMap;
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x000F64C9 File Offset: 0x000F46C9
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery LeftFragmentQuery
		{
			get
			{
				return this.m_cellWrapper.FragmentQuery;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06004620 RID: 17952 RVA: 0x000F64D6 File Offset: 0x000F46D6
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery RightFragmentQuery
		{
			get
			{
				return this.m_rightFragmentQuery;
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x000F64DE File Offset: 0x000F46DE
		internal override global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> Attributes
		{
			get
			{
				return this.m_cellWrapper.Attributes;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06004622 RID: 17954 RVA: 0x000F64EB File Offset: 0x000F46EB
		internal override global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> Children
		{
			get
			{
				return new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>();
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x000F64F2 File Offset: 0x000F46F2
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType OpType
		{
			get
			{
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Leaf;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06004624 RID: 17956 RVA: 0x000F64F5 File Offset: 0x000F46F5
		internal override int NumProjectedSlots
		{
			get
			{
				return this.LeftCellWrapper.RightCellQuery.NumProjectedSlots;
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06004625 RID: 17957 RVA: 0x000F6507 File Offset: 0x000F4707
		internal override int NumBoolSlots
		{
			get
			{
				return this.LeftCellWrapper.RightCellQuery.NumBoolVars;
			}
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x000F6519 File Offset: 0x000F4719
		internal override TOutput Accept<TInput, TOutput>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.CellTreeVisitor<TInput, TOutput> visitor, TInput param)
		{
			return visitor.VisitLeaf(this, param);
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x000F6523 File Offset: 0x000F4723
		internal override TOutput Accept<TInput, TOutput>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.SimpleCellTreeVisitor<TInput, TOutput> visitor, TInput param)
		{
			return visitor.VisitLeaf(this, param);
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x000F6530 File Offset: 0x000F4730
		internal override bool IsProjectedSlot(int slot)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery rightCellQuery = this.LeftCellWrapper.RightCellQuery;
			if (base.IsBoolSlot(slot))
			{
				return rightCellQuery.GetBoolVar(base.SlotToBoolIndex(slot)) != null;
			}
			return rightCellQuery.ProjectedSlotAt(slot) != null;
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x000F6570 File Offset: 0x000F4770
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock ToCqlBlock(bool[] requiredSlots, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, ref int blockAliasNum, ref global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships)
		{
			int num = requiredSlots.Length;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery rightCellQuery = this.LeftCellWrapper.RightCellQuery;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] array = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[num];
			for (int i = 0; i < rightCellQuery.NumProjectedSlots; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot projectedSlot = rightCellQuery.ProjectedSlotAt(i);
				if (requiredSlots[i] && projectedSlot == null)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot constantProjectedSlot = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.GetDefaultValueForMemberPath(base.ProjectedSlotMap[i], base.GetLeaves(), base.ViewgenContext.Config));
					rightCellQuery.FixMissingSlotAsDefaultConstant(i, constantProjectedSlot);
					projectedSlot = constantProjectedSlot;
				}
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo slotInfo = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(requiredSlots[i], projectedSlot != null, projectedSlot, base.ProjectedSlotMap[i]);
				array[i] = slotInfo;
			}
			for (int j = 0; j < rightCellQuery.NumBoolVars; j++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolVar = rightCellQuery.GetBoolVar(j);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.BooleanProjectedSlot slotValue;
				if (boolVar != null)
				{
					slotValue = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.BooleanProjectedSlot(boolVar, identifiers, j);
				}
				else
				{
					slotValue = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.BooleanProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.False, identifiers, j);
				}
				int num2 = base.BoolIndexToSlot(j);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo slotInfo2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(requiredSlots[num2], boolVar != null, slotValue, null);
				array[num2] = slotInfo2;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo> source = array;
			if (rightCellQuery.Extent.EntityContainer.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace && this.m_cellWrapper.LeftExtent.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.AssociationSetMapping> relationshipSetMappingsFor = base.ViewgenContext.EntityContainerMapping.GetRelationshipSetMappingsFor(this.m_cellWrapper.LeftExtent, rightCellQuery.Extent);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo> second = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo>();
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.AssociationSetMapping> enumerator = relationshipSetMappingsFor.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship item;
						if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode.TryGetWithRelationship(enumerator.Current, this.m_cellWrapper.LeftExtent, rightCellQuery.SourceExtentMemberPath, ref second, out item))
						{
							withRelationships.Add(item);
							source = array.Concat(second);
						}
					}
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent = rightCellQuery.Extent;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct selectDistinctFlag = rightCellQuery.SelectDistinctFlag;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] slots = source.ToArray<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo>();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause = rightCellQuery.WhereClause;
			int num3 = blockAliasNum + 1;
			blockAliasNum = num3;
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.ExtentCqlBlock(extent, selectDistinctFlag, slots, whereClause, identifiers, num3);
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x000F6754 File Offset: 0x000F4954
		private static bool TryGetWithRelationship(global::System.Data.Entity.Core.Mapping.AssociationSetMapping collocatedAssociationSetMap, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase thisExtent, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath sRootNode, ref global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo> foreignKeySlots, out global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship withRelationship)
		{
			withRelationship = null;
			global::System.Data.Entity.Core.Mapping.EndPropertyMapping foreignKeyEndMapFromAssociationMap = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode.GetForeignKeyEndMapFromAssociationMap(collocatedAssociationSetMap);
			if (foreignKeyEndMapFromAssociationMap == null || foreignKeyEndMapFromAssociationMap.AssociationEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
			{
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEnd = foreignKeyEndMapFromAssociationMap.AssociationEnd;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember otherAssociationEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetOtherAssociationEnd(associationEnd);
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)associationEnd.TypeUsage.EdmType).ElementType;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)otherAssociationEnd.TypeUsage.EdmType).ElementType;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)collocatedAssociationSetMap.Set;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath prefix = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(associationSet, associationEnd);
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping> source = foreignKeyEndMapFromAssociationMap.PropertyMappings.Cast<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
			using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Enumerator enumerator = entityType.KeyMembers.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)enumerator.Current;
					global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping = (from propMap in source
					where propMap.Property.Equals(edmProperty)
					select propMap).First<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>();
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slotValue = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(sRootNode, scalarPropertyMapping.Column));
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(prefix, edmProperty);
					list.Add(memberPath);
					foreignKeySlots.Add(new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(true, true, slotValue, memberPath));
				}
			}
			if (thisExtent.ElementType.IsAssignableFrom(entityType2))
			{
				withRelationship = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship(associationSet, otherAssociationEnd, entityType2, associationEnd, entityType, list);
				return true;
			}
			return false;
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x000F68C0 File Offset: 0x000F4AC0
		private static global::System.Data.Entity.Core.Mapping.EndPropertyMapping GetForeignKeyEndMapFromAssociationMap(global::System.Data.Entity.Core.Mapping.AssociationSetMapping collocatedAssociationSetMap)
		{
			global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = collocatedAssociationSetMap.TypeMappings.First<global::System.Data.Entity.Core.Mapping.TypeMapping>().MappingFragments.First<global::System.Data.Entity.Core.Mapping.MappingFragment>();
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers = collocatedAssociationSetMap.StoreEntitySet.ElementType.KeyMembers;
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.PropertyMapping> enumerator = mappingFragment.PropertyMappings.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Mapping.EndPropertyMapping endMap = (global::System.Data.Entity.Core.Mapping.EndPropertyMapping)enumerator.Current;
					if (endMap.StoreProperties.SequenceEqual(keyMembers, global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Default))
					{
						return (from eMap in mappingFragment.PropertyMappings.OfType<global::System.Data.Entity.Core.Mapping.EndPropertyMapping>()
						where !eMap.Equals(endMap)
						select eMap).First<global::System.Data.Entity.Core.Mapping.EndPropertyMapping>();
					}
				}
			}
			return null;
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x000F6980 File Offset: 0x000F4B80
		internal override void ToCompactString(global::System.Text.StringBuilder stringBuilder)
		{
			this.m_cellWrapper.ToCompactString(stringBuilder);
		}

		// Token: 0x0400190D RID: 6413
		internal static readonly global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> EqualityComparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode.LeafCellTreeNodeComparer();

		// Token: 0x0400190E RID: 6414
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper m_cellWrapper;

		// Token: 0x0400190F RID: 6415
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery m_rightFragmentQuery;

		// Token: 0x02000BCE RID: 3022
		private class LeafCellTreeNodeComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>
		{
			// Token: 0x0600682E RID: 26670 RVA: 0x0016265F File Offset: 0x0016085F
			public bool Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode left, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode right)
			{
				return left == right || (left != null && right != null && left.m_cellWrapper.Equals(right.m_cellWrapper));
			}

			// Token: 0x0600682F RID: 26671 RVA: 0x00162680 File Offset: 0x00160880
			public int GetHashCode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode node)
			{
				return node.m_cellWrapper.GetHashCode();
			}
		}
	}
}
