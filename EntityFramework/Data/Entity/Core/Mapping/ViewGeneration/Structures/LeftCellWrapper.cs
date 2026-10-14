using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005A5 RID: 1445
	internal class LeftCellWrapper : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x0600462E RID: 17966 RVA: 0x000F699C File Offset: 0x000F4B9C
		internal LeftCellWrapper(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> attrs, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery leftCellQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery rightCellQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberMaps memberMaps, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> inputCells)
		{
			this.m_leftFragmentQuery = fragmentQuery;
			this.m_rightCellQuery = rightCellQuery;
			this.m_leftCellQuery = leftCellQuery;
			this.m_attributes = attrs;
			this.m_viewTarget = viewTarget;
			this.m_memberMaps = memberMaps;
			this.m_mergedCells = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>(inputCells);
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x000F69EC File Offset: 0x000F4BEC
		internal LeftCellWrapper(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> attrs, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery leftCellQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery rightCellQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberMaps memberMaps, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell inputCell) : this(viewTarget, attrs, fragmentQuery, leftCellQuery, rightCellQuery, memberMaps, global::System.Linq.Enumerable.Repeat<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>(inputCell, 1))
		{
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06004630 RID: 17968 RVA: 0x000F6A10 File Offset: 0x000F4C10
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery FragmentQuery
		{
			get
			{
				return this.m_leftFragmentQuery;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06004631 RID: 17969 RVA: 0x000F6A18 File Offset: 0x000F4C18
		internal global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> Attributes
		{
			get
			{
				return this.m_attributes;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06004632 RID: 17970 RVA: 0x000F6A20 File Offset: 0x000F4C20
		internal string OriginalCellNumberString
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedString(from cell in this.m_mergedCells
				select cell.CellNumberAsString, "+", "");
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06004633 RID: 17971 RVA: 0x000F6A5B File Offset: 0x000F4C5B
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap RightDomainMap
		{
			get
			{
				return this.m_memberMaps.RightDomainMap;
			}
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x000F6A68 File Offset: 0x000F4C68
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal void AssertHasUniqueCell()
		{
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06004635 RID: 17973 RVA: 0x000F6A6A File Offset: 0x000F4C6A
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> Cells
		{
			get
			{
				return this.m_mergedCells;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06004636 RID: 17974 RVA: 0x000F6A72 File Offset: 0x000F4C72
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell OnlyInputCell
		{
			get
			{
				return this.m_mergedCells.First<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>();
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06004637 RID: 17975 RVA: 0x000F6A7F File Offset: 0x000F4C7F
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery RightCellQuery
		{
			get
			{
				return this.m_rightCellQuery;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06004638 RID: 17976 RVA: 0x000F6A87 File Offset: 0x000F4C87
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery LeftCellQuery
		{
			get
			{
				return this.m_leftCellQuery;
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06004639 RID: 17977 RVA: 0x000F6A8F File Offset: 0x000F4C8F
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase LeftExtent
		{
			get
			{
				return this.m_mergedCells.First<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>().GetLeftQuery(this.m_viewTarget).Extent;
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x0600463A RID: 17978 RVA: 0x000F6AAC File Offset: 0x000F4CAC
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase RightExtent
		{
			get
			{
				return this.m_rightCellQuery.Extent;
			}
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x000F6AB9 File Offset: 0x000F4CB9
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> GetInputCellsForWrappers(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> wrappers)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in wrappers)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in leftCellWrapper.m_mergedCells)
				{
					yield return cell;
				}
				global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>.Enumerator enumerator2 = default(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>.Enumerator);
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x000F6ACC File Offset: 0x000F4CCC
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean CreateRoleBoolean()
		{
			if (this.RightExtent is global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)
			{
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> endsForTablePrimaryKey = this.GetEndsForTablePrimaryKey();
				if (endsForTablePrimaryKey.Count == 1)
				{
					return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean(((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.RightExtent).AssociationSetEnds[endsForTablePrimaryKey.First<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>().Name]);
				}
			}
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean(this.RightExtent);
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x000F6B28 File Offset: 0x000F4D28
		internal static string GetExtentListAsUserString(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> wrappers)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>.Default);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in wrappers)
			{
				set.Add(leftCellWrapper.RightExtent);
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in set)
			{
				if (!flag)
				{
					stringBuilder.Append(", ");
				}
				flag = false;
				stringBuilder.Append(entitySetBase.Name);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x000F6BE8 File Offset: 0x000F4DE8
		internal override void ToFullString(global::System.Text.StringBuilder builder)
		{
			builder.Append("P[");
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedString(builder, this.m_attributes, ",");
			builder.Append("] = ");
			this.m_rightCellQuery.ToFullString(builder);
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x000F6C1F File Offset: 0x000F4E1F
		internal override void ToCompactString(global::System.Text.StringBuilder stringBuilder)
		{
			stringBuilder.Append(this.OriginalCellNumberString);
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x000F6C30 File Offset: 0x000F4E30
		internal static void WrappersToStringBuilder(global::System.Text.StringBuilder builder, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> wrappers, string header)
		{
			builder.AppendLine().Append(header).AppendLine();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper[] array = wrappers.ToArray();
			global::System.Array.Sort<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>(array, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper.OriginalCellIdComparer);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper leftCellWrapper in array)
			{
				leftCellWrapper.ToCompactString(builder);
				builder.Append(" = ");
				leftCellWrapper.ToFullString(builder);
				builder.AppendLine();
			}
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x000F6C94 File Offset: 0x000F4E94
		private global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> GetEndsForTablePrimaryKey()
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery rightCellQuery = this.RightCellQuery;
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>.Default);
			foreach (int slotNum in this.m_memberMaps.ProjectedSlotMap.KeySlots)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember element = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)rightCellQuery.ProjectedSlotAt(slotNum)).MemberPath.RootEdmMember;
				set.Add(element);
			}
			return set;
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x000F6D1C File Offset: 0x000F4F1C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot GetLeftSideMappedSlotForRightSideMember(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member)
		{
			int projectedPosition = this.RightCellQuery.GetProjectedPosition(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(member));
			if (projectedPosition == -1)
			{
				return null;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot projectedSlot = this.LeftCellQuery.ProjectedSlotAt(projectedPosition);
			if (projectedSlot == null || projectedSlot is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot)
			{
				return null;
			}
			return projectedSlot as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x000F6D64 File Offset: 0x000F4F64
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot GetRightSideMappedSlotForLeftSideMember(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member)
		{
			int projectedPosition = this.LeftCellQuery.GetProjectedPosition(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(member));
			if (projectedPosition == -1)
			{
				return null;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot projectedSlot = this.RightCellQuery.ProjectedSlotAt(projectedPosition);
			if (projectedSlot == null || projectedSlot is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot)
			{
				return null;
			}
			return projectedSlot as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x000F6DA9 File Offset: 0x000F4FA9
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot GetCSideMappedSlotForSMember(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member)
		{
			if (this.m_viewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
			{
				return this.GetLeftSideMappedSlotForRightSideMember(member);
			}
			return this.GetRightSideMappedSlotForLeftSideMember(member);
		}

		// Token: 0x04001910 RID: 6416
		internal static readonly global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> BoolEqualityComparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper.BoolWrapperComparer();

		// Token: 0x04001911 RID: 6417
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> m_attributes;

		// Token: 0x04001912 RID: 6418
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberMaps m_memberMaps;

		// Token: 0x04001913 RID: 6419
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery m_leftCellQuery;

		// Token: 0x04001914 RID: 6420
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery m_rightCellQuery;

		// Token: 0x04001915 RID: 6421
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> m_mergedCells;

		// Token: 0x04001916 RID: 6422
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget m_viewTarget;

		// Token: 0x04001917 RID: 6423
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery m_leftFragmentQuery;

		// Token: 0x04001918 RID: 6424
		internal static readonly global::System.Collections.Generic.IComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> Comparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper.LeftCellWrapperComparer();

		// Token: 0x04001919 RID: 6425
		internal static readonly global::System.Collections.Generic.IComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> OriginalCellIdComparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper.CellIdComparer();

		// Token: 0x02000BD1 RID: 3025
		private class BoolWrapperComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>
		{
			// Token: 0x06006835 RID: 26677 RVA: 0x001626CC File Offset: 0x001608CC
			public bool Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper left, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper right)
			{
				if (left == right)
				{
					return true;
				}
				if (left == null || right == null)
				{
					return false;
				}
				bool flag = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.EqualityComparer.Equals(left.RightCellQuery.WhereClause, right.RightCellQuery.WhereClause);
				return left.RightExtent.Equals(right.RightExtent) && flag;
			}

			// Token: 0x06006836 RID: 26678 RVA: 0x0016271B File Offset: 0x0016091B
			public int GetHashCode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper wrapper)
			{
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.EqualityComparer.GetHashCode(wrapper.RightCellQuery.WhereClause) ^ wrapper.RightExtent.GetHashCode();
			}
		}

		// Token: 0x02000BD2 RID: 3026
		private class LeftCellWrapperComparer : global::System.Collections.Generic.IComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>
		{
			// Token: 0x06006838 RID: 26680 RVA: 0x00162748 File Offset: 0x00160948
			public int Compare(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper x, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper y)
			{
				if (x.FragmentQuery.Attributes.Count > y.FragmentQuery.Attributes.Count)
				{
					return -1;
				}
				if (x.FragmentQuery.Attributes.Count < y.FragmentQuery.Attributes.Count)
				{
					return 1;
				}
				return string.CompareOrdinal(x.OriginalCellNumberString, y.OriginalCellNumberString);
			}
		}

		// Token: 0x02000BD3 RID: 3027
		internal class CellIdComparer : global::System.Collections.Generic.IComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>
		{
			// Token: 0x0600683A RID: 26682 RVA: 0x001627B6 File Offset: 0x001609B6
			public int Compare(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper x, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper y)
			{
				return global::System.StringComparer.Ordinal.Compare(x.OriginalCellNumberString, y.OriginalCellNumberString);
			}
		}
	}
}
