using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x0200059E RID: 1438
	internal abstract class CellTreeNode : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x060045C2 RID: 17858 RVA: 0x000F56FC File Offset: 0x000F38FC
		protected CellTreeNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context)
		{
			this.m_viewgenContext = context;
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x000F570C File Offset: 0x000F390C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode MakeCopy()
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.DefaultCellTreeVisitor<bool> visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.DefaultCellTreeVisitor<bool>();
			return this.Accept<bool, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(visitor, true);
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x060045C4 RID: 17860
		internal abstract global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType OpType { get; }

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x060045C5 RID: 17861
		internal abstract global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap RightDomainMap { get; }

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x060045C6 RID: 17862
		internal abstract global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery LeftFragmentQuery { get; }

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x060045C7 RID: 17863
		internal abstract global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery RightFragmentQuery { get; }

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x060045C8 RID: 17864 RVA: 0x000F5727 File Offset: 0x000F3927
		internal bool IsEmptyRightFragmentQuery
		{
			get
			{
				return !this.m_viewgenContext.RightFragmentQP.IsSatisfiable(this.RightFragmentQuery);
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x060045C9 RID: 17865
		internal abstract global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> Attributes { get; }

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x060045CA RID: 17866
		internal abstract global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> Children { get; }

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x060045CB RID: 17867
		internal abstract int NumProjectedSlots { get; }

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x060045CC RID: 17868
		internal abstract int NumBoolSlots { get; }

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x060045CD RID: 17869 RVA: 0x000F5742 File Offset: 0x000F3942
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex ProjectedSlotMap
		{
			get
			{
				return this.m_viewgenContext.MemberMaps.ProjectedSlotMap;
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x060045CE RID: 17870 RVA: 0x000F5754 File Offset: 0x000F3954
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext ViewgenContext
		{
			get
			{
				return this.m_viewgenContext;
			}
		}

		// Token: 0x060045CF RID: 17871
		internal abstract global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock ToCqlBlock(bool[] requiredSlots, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, ref int blockAliasNum, ref global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships);

		// Token: 0x060045D0 RID: 17872
		internal abstract bool IsProjectedSlot(int slot);

		// Token: 0x060045D1 RID: 17873
		internal abstract TOutput Accept<TInput, TOutput>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.CellTreeVisitor<TInput, TOutput> visitor, TInput param);

		// Token: 0x060045D2 RID: 17874
		internal abstract TOutput Accept<TInput, TOutput>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.SimpleCellTreeVisitor<TInput, TOutput> visitor, TInput param);

		// Token: 0x060045D3 RID: 17875 RVA: 0x000F575C File Offset: 0x000F395C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode Flatten()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.FlatteningVisitor.Flatten(this);
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x000F5764 File Offset: 0x000F3964
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> GetLeaves()
		{
			return (from leafNode in this.GetLeafNodes()
			select leafNode.LeftCellWrapper).ToList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper>();
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x000F5795 File Offset: 0x000F3995
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> GetLeafNodes()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.LeafVisitor.GetLeaves(this);
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x000F579D File Offset: 0x000F399D
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode AssociativeFlatten()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.AssociativeOpFlatteningVisitor.Flatten(this);
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x000F57A5 File Offset: 0x000F39A5
		internal static bool IsAssociativeOp(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType)
		{
			return opType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ || opType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union || opType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.FOJ;
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x000F57B8 File Offset: 0x000F39B8
		internal bool[] GetProjectedSlots()
		{
			int num = this.ProjectedSlotMap.Count + this.NumBoolSlots;
			bool[] array = new bool[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.IsProjectedSlot(i);
			}
			return array;
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x000F57F6 File Offset: 0x000F39F6
		protected global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath GetMemberPath(int slotNum)
		{
			return this.ProjectedSlotMap.GetMemberPath(slotNum, this.NumBoolSlots);
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x000F580A File Offset: 0x000F3A0A
		protected int BoolIndexToSlot(int boolIndex)
		{
			return this.ProjectedSlotMap.BoolIndexToSlot(boolIndex, this.NumBoolSlots);
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x000F581E File Offset: 0x000F3A1E
		protected int SlotToBoolIndex(int slotNum)
		{
			return this.ProjectedSlotMap.SlotToBoolIndex(slotNum, this.NumBoolSlots);
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x000F5832 File Offset: 0x000F3A32
		protected bool IsKeySlot(int slotNum)
		{
			return this.ProjectedSlotMap.IsKeySlot(slotNum, this.NumBoolSlots);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x000F5846 File Offset: 0x000F3A46
		protected bool IsBoolSlot(int slotNum)
		{
			return this.ProjectedSlotMap.IsBoolSlot(slotNum, this.NumBoolSlots);
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x060045DE RID: 17886 RVA: 0x000F585A File Offset: 0x000F3A5A
		protected global::System.Collections.Generic.IEnumerable<int> KeySlots
		{
			get
			{
				int numMembers = this.ProjectedSlotMap.Count;
				int num;
				for (int slotNum = 0; slotNum < numMembers; slotNum = num + 1)
				{
					if (this.IsKeySlot(slotNum))
					{
						yield return slotNum;
					}
					num = slotNum;
				}
				yield break;
			}
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x000F586C File Offset: 0x000F3A6C
		internal override void ToFullString(global::System.Text.StringBuilder builder)
		{
			int num = 0;
			bool[] projectedSlots = this.GetProjectedSlots();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship>();
			this.ToCqlBlock(projectedSlots, identifiers, ref num, ref list).AsEsql(builder, false, 1);
		}

		// Token: 0x040018FC RID: 6396
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext m_viewgenContext;

		// Token: 0x02000BBD RID: 3005
		internal abstract class CellTreeVisitor<TInput, TOutput>
		{
			// Token: 0x060067BA RID: 26554
			internal abstract TOutput VisitLeaf(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode node, TInput param);

			// Token: 0x060067BB RID: 26555
			internal abstract TOutput VisitUnion(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, TInput param);

			// Token: 0x060067BC RID: 26556
			internal abstract TOutput VisitInnerJoin(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, TInput param);

			// Token: 0x060067BD RID: 26557
			internal abstract TOutput VisitLeftOuterJoin(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, TInput param);

			// Token: 0x060067BE RID: 26558
			internal abstract TOutput VisitFullOuterJoin(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, TInput param);

			// Token: 0x060067BF RID: 26559
			internal abstract TOutput VisitLeftAntiSemiJoin(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, TInput param);
		}

		// Token: 0x02000BBE RID: 3006
		internal abstract class SimpleCellTreeVisitor<TInput, TOutput>
		{
			// Token: 0x060067C1 RID: 26561
			internal abstract TOutput VisitLeaf(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode node, TInput param);

			// Token: 0x060067C2 RID: 26562
			internal abstract TOutput VisitOpNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, TInput param);
		}

		// Token: 0x02000BBF RID: 3007
		private class DefaultCellTreeVisitor<TInput> : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.CellTreeVisitor<TInput, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>
		{
			// Token: 0x060067C4 RID: 26564 RVA: 0x00161B47 File Offset: 0x0015FD47
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitLeaf(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode node, TInput param)
			{
				return node;
			}

			// Token: 0x060067C5 RID: 26565 RVA: 0x00161B4A File Offset: 0x0015FD4A
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitUnion(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, TInput param)
			{
				return this.AcceptChildren(node, param);
			}

			// Token: 0x060067C6 RID: 26566 RVA: 0x00161B54 File Offset: 0x0015FD54
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitInnerJoin(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, TInput param)
			{
				return this.AcceptChildren(node, param);
			}

			// Token: 0x060067C7 RID: 26567 RVA: 0x00161B5E File Offset: 0x0015FD5E
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitLeftOuterJoin(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, TInput param)
			{
				return this.AcceptChildren(node, param);
			}

			// Token: 0x060067C8 RID: 26568 RVA: 0x00161B68 File Offset: 0x0015FD68
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitFullOuterJoin(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, TInput param)
			{
				return this.AcceptChildren(node, param);
			}

			// Token: 0x060067C9 RID: 26569 RVA: 0x00161B72 File Offset: 0x0015FD72
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitLeftAntiSemiJoin(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, TInput param)
			{
				return this.AcceptChildren(node, param);
			}

			// Token: 0x060067CA RID: 26570 RVA: 0x00161B7C File Offset: 0x0015FD7C
			private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode AcceptChildren(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, TInput param)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>();
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in node.Children)
				{
					list.Add(cellTreeNode.Accept<TInput, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(this, param));
				}
				return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(node.ViewgenContext, node.OpType, list);
			}
		}

		// Token: 0x02000BC0 RID: 3008
		private class FlatteningVisitor : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.SimpleCellTreeVisitor<bool, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>
		{
			// Token: 0x060067CC RID: 26572 RVA: 0x00161BF8 File Offset: 0x0015FDF8
			protected FlatteningVisitor()
			{
			}

			// Token: 0x060067CD RID: 26573 RVA: 0x00161C00 File Offset: 0x0015FE00
			internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode Flatten(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode node)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.FlatteningVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.FlatteningVisitor();
				return node.Accept<bool, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(visitor, true);
			}

			// Token: 0x060067CE RID: 26574 RVA: 0x00161C1B File Offset: 0x0015FE1B
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitLeaf(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode node, bool dummy)
			{
				return node;
			}

			// Token: 0x060067CF RID: 26575 RVA: 0x00161C20 File Offset: 0x0015FE20
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitOpNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, bool dummy)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>();
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in node.Children)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode item = cellTreeNode.Accept<bool, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(this, dummy);
					list.Add(item);
				}
				if (list.Count == 1)
				{
					return list[0];
				}
				return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(node.ViewgenContext, node.OpType, list);
			}
		}

		// Token: 0x02000BC1 RID: 3009
		private class AssociativeOpFlatteningVisitor : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.SimpleCellTreeVisitor<bool, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>
		{
			// Token: 0x060067D0 RID: 26576 RVA: 0x00161CA4 File Offset: 0x0015FEA4
			private AssociativeOpFlatteningVisitor()
			{
			}

			// Token: 0x060067D1 RID: 26577 RVA: 0x00161CAC File Offset: 0x0015FEAC
			internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode Flatten(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode node)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.FlatteningVisitor.Flatten(node);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.AssociativeOpFlatteningVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.AssociativeOpFlatteningVisitor();
				return cellTreeNode.Accept<bool, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(visitor, true);
			}

			// Token: 0x060067D2 RID: 26578 RVA: 0x00161CCC File Offset: 0x0015FECC
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitLeaf(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode node, bool dummy)
			{
				return node;
			}

			// Token: 0x060067D3 RID: 26579 RVA: 0x00161CD0 File Offset: 0x0015FED0
			internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode VisitOpNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, bool dummy)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>();
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in node.Children)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode item = cellTreeNode.Accept<bool, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(this, dummy);
					list.Add(item);
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> list2 = list;
				if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.IsAssociativeOp(node.OpType))
				{
					list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>();
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode2 in list)
					{
						if (cellTreeNode2.OpType == node.OpType)
						{
							list2.AddRange(cellTreeNode2.Children);
						}
						else
						{
							list2.Add(cellTreeNode2);
						}
					}
				}
				return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(node.ViewgenContext, node.OpType, list2);
			}
		}

		// Token: 0x02000BC2 RID: 3010
		private class LeafVisitor : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.SimpleCellTreeVisitor<bool, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>>
		{
			// Token: 0x060067D4 RID: 26580 RVA: 0x00161DB4 File Offset: 0x0015FFB4
			private LeafVisitor()
			{
			}

			// Token: 0x060067D5 RID: 26581 RVA: 0x00161DBC File Offset: 0x0015FFBC
			internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> GetLeaves(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode node)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.LeafVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.LeafVisitor();
				return node.Accept<bool, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>>(visitor, true);
			}

			// Token: 0x060067D6 RID: 26582 RVA: 0x00161DD7 File Offset: 0x0015FFD7
			internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> VisitLeaf(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode node, bool dummy)
			{
				yield return node;
				yield break;
			}

			// Token: 0x060067D7 RID: 26583 RVA: 0x00161DE7 File Offset: 0x0015FFE7
			internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> VisitOpNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode node, bool dummy)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in node.Children)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> enumerable = cellTreeNode.Accept<bool, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>>(this, dummy);
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode leafCellTreeNode in enumerable)
					{
						yield return leafCellTreeNode;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> enumerator2 = null;
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>.Enumerator enumerator = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>.Enumerator);
				yield break;
				yield break;
			}
		}
	}
}
