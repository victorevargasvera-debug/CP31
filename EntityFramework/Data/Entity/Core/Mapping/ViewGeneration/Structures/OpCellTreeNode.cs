using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Resources;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005AD RID: 1453
	internal class OpCellTreeNode : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode
	{
		// Token: 0x060046C5 RID: 18117 RVA: 0x000F8D17 File Offset: 0x000F6F17
		internal OpCellTreeNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType) : base(context)
		{
			this.m_opType = opType;
			this.m_attrs = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
			this.m_children = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>();
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x000F8D42 File Offset: 0x000F6F42
		internal OpCellTreeNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType, params global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode[] children) : this(context, opType, children)
		{
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x000F8D50 File Offset: 0x000F6F50
		internal OpCellTreeNode(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> children) : this(context, opType)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode child in children)
			{
				this.Add(child);
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x060046C8 RID: 18120 RVA: 0x000F8DA0 File Offset: 0x000F6FA0
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType OpType
		{
			get
			{
				return this.m_opType;
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x060046C9 RID: 18121 RVA: 0x000F8DA8 File Offset: 0x000F6FA8
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery LeftFragmentQuery
		{
			get
			{
				if (this.m_leftFragmentQuery == null)
				{
					this.m_leftFragmentQuery = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode.GenerateFragmentQuery(this.Children, true, base.ViewgenContext, this.OpType);
				}
				return this.m_leftFragmentQuery;
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x000F8DD6 File Offset: 0x000F6FD6
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery RightFragmentQuery
		{
			get
			{
				if (this.m_rightFragmentQuery == null)
				{
					this.m_rightFragmentQuery = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode.GenerateFragmentQuery(this.Children, false, base.ViewgenContext, this.OpType);
				}
				return this.m_rightFragmentQuery;
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x060046CB RID: 18123 RVA: 0x000F8E04 File Offset: 0x000F7004
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap RightDomainMap
		{
			get
			{
				return this.m_children[0].RightDomainMap;
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x000F8E17 File Offset: 0x000F7017
		internal override global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> Attributes
		{
			get
			{
				return this.m_attrs;
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x000F8E1F File Offset: 0x000F701F
		internal override global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> Children
		{
			get
			{
				return this.m_children;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x000F8E27 File Offset: 0x000F7027
		internal override int NumProjectedSlots
		{
			get
			{
				return this.m_children[0].NumProjectedSlots;
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x060046CF RID: 18127 RVA: 0x000F8E3A File Offset: 0x000F703A
		internal override int NumBoolSlots
		{
			get
			{
				return this.m_children[0].NumBoolSlots;
			}
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x000F8E4D File Offset: 0x000F704D
		internal override TOutput Accept<TInput, TOutput>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.SimpleCellTreeVisitor<TInput, TOutput> visitor, TInput param)
		{
			return visitor.VisitOpNode(this, param);
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x000F8E58 File Offset: 0x000F7058
		internal override TOutput Accept<TInput, TOutput>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.CellTreeVisitor<TInput, TOutput> visitor, TInput param)
		{
			switch (this.OpType)
			{
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union:
				return visitor.VisitUnion(this, param);
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.FOJ:
				return visitor.VisitFullOuterJoin(this, param);
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ:
				return visitor.VisitLeftOuterJoin(this, param);
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ:
				return visitor.VisitInnerJoin(this, param);
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LASJ:
				return visitor.VisitLeftAntiSemiJoin(this, param);
			default:
				return visitor.VisitInnerJoin(this, param);
			}
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x000F8EBF File Offset: 0x000F70BF
		internal void Add(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode child)
		{
			this.Insert(this.m_children.Count, child);
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x000F8ED3 File Offset: 0x000F70D3
		internal void AddFirst(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode child)
		{
			this.Insert(0, child);
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x000F8EDD File Offset: 0x000F70DD
		private void Insert(int index, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode child)
		{
			this.m_attrs.Unite(child.Attributes);
			this.m_children.Insert(index, child);
			this.m_leftFragmentQuery = null;
			this.m_rightFragmentQuery = null;
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x000F8F0C File Offset: 0x000F710C
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock ToCqlBlock(bool[] requiredSlots, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, ref int blockAliasNum, ref global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock result;
			if (this.OpType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union)
			{
				result = this.UnionToCqlBlock(requiredSlots, identifiers, ref blockAliasNum, ref withRelationships);
			}
			else
			{
				result = this.JoinToCqlBlock(requiredSlots, identifiers, ref blockAliasNum, ref withRelationships);
			}
			return result;
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x000F8F40 File Offset: 0x000F7140
		internal override bool IsProjectedSlot(int slot)
		{
			using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>.Enumerator enumerator = this.Children.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsProjectedSlot(slot))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x000F8F9C File Offset: 0x000F719C
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock UnionToCqlBlock(bool[] requiredSlots, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, ref int blockAliasNum, ref global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock>();
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo>> list2 = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo>>();
			int num = requiredSlots.Length;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in this.Children)
			{
				bool[] projectedSlots = cellTreeNode.GetProjectedSlots();
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode.AndWith(projectedSlots, requiredSlots);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock = cellTreeNode.ToCqlBlock(projectedSlots, identifiers, ref blockAliasNum, ref withRelationships);
				for (int i = projectedSlots.Length; i < cqlBlock.Slots.Count; i++)
				{
					list2.Add(global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo>(cqlBlock, cqlBlock.Slots[i]));
				}
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] array = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[cqlBlock.Slots.Count];
				for (int j = 0; j < num; j++)
				{
					if (requiredSlots[j] && !projectedSlots[j])
					{
						if (base.IsBoolSlot(j))
						{
							array[j] = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(true, true, new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.BooleanProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.False, identifiers, base.SlotToBoolIndex(j)), null);
						}
						else
						{
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember = cqlBlock.MemberPath(j);
							array[j] = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(true, true, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null), outputMember);
						}
					}
					else
					{
						array[j] = cqlBlock.Slots[j];
					}
				}
				cqlBlock.Slots = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo>(array);
				list.Add(cqlBlock);
			}
			if (list2.Count != 0)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock2 in list)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] array2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[num + list2.Count];
					cqlBlock2.Slots.CopyTo(array2, 0);
					int num2 = num;
					foreach (global::System.Tuple<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo> tuple in list2)
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo item = tuple.Item2;
						if (tuple.Item1.Equals(cqlBlock2))
						{
							array2[num2] = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(true, true, item.SlotValue, item.OutputMember);
						}
						else
						{
							array2[num2] = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(true, true, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null), item.OutputMember);
						}
						num2++;
					}
					cqlBlock2.Slots = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo>(array2);
				}
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] array3 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[num + list2.Count];
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock3 = list[0];
			for (int k = 0; k < num; k++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo slotInfo = cqlBlock3.Slots[k];
				bool flag = requiredSlots[k];
				array3[k] = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(flag, flag, slotInfo.SlotValue, slotInfo.OutputMember);
			}
			for (int l = num; l < num + list2.Count; l++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo slotInfo2 = cqlBlock3.Slots[l];
				array3[l] = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(true, true, slotInfo2.SlotValue, slotInfo2.OutputMember);
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] slotInfos = array3;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock> children = list;
			int num3 = blockAliasNum + 1;
			blockAliasNum = num3;
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.UnionCqlBlock(slotInfos, children, identifiers, num3);
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x000F92D4 File Offset: 0x000F74D4
		private static void AndWith(bool[] boolArray, bool[] another)
		{
			for (int i = 0; i < boolArray.Length; i++)
			{
				boolArray[i] &= another[i];
			}
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x000F9300 File Offset: 0x000F7500
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock JoinToCqlBlock(bool[] requiredSlots, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, ref int blockAliasNum, ref global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships)
		{
			int num = requiredSlots.Length;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock>();
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>> list2 = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in this.Children)
			{
				bool[] projectedSlots = cellTreeNode.GetProjectedSlots();
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode.AndWith(projectedSlots, requiredSlots);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock = cellTreeNode.ToCqlBlock(projectedSlots, identifiers, ref blockAliasNum, ref withRelationships);
				list.Add(cqlBlock);
				for (int i = projectedSlots.Length; i < cqlBlock.Slots.Count; i++)
				{
					list2.Add(global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(cqlBlock.QualifySlotWithBlockAlias(i), cqlBlock.MemberPath(i)));
				}
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] array = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[num + list2.Count];
			for (int j = 0; j < num; j++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo joinSlotInfo = this.GetJoinSlotInfo(this.OpType, requiredSlots[j], list, j, identifiers);
				array[j] = joinSlotInfo;
			}
			int num2 = 0;
			int k = num;
			while (k < num + list2.Count)
			{
				array[k] = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(true, true, list2[num2].Item1, list2[num2].Item2);
				k++;
				num2++;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock.OnClause> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock.OnClause>();
			for (int l = 1; l < list.Count; l++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock2 = list[l];
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock.OnClause onClause = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock.OnClause();
				foreach (int num3 in base.KeySlots)
				{
					if (!base.ViewgenContext.Config.IsValidationEnabled && (!cqlBlock2.IsProjected(num3) || !list[0].IsProjected(num3)))
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog();
						errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.NoJoinKeyOrFKProvidedInMapping, global::System.Data.Entity.Resources.Strings.Viewgen_NoJoinKeyOrFK, base.ViewgenContext.AllWrappersForExtent, string.Empty));
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExceptionHelpers.ThrowMappingException(errorLog, base.ViewgenContext.Config);
					}
					global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot leftSlot = list[0].QualifySlotWithBlockAlias(num3);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot rightSlot = cqlBlock2.QualifySlotWithBlockAlias(num3);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember = array[num3].OutputMember;
					onClause.Add(leftSlot, outputMember, rightSlot, outputMember);
				}
				list3.Add(onClause);
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType = this.OpType;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] slotInfos = array;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock> children = list;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock.OnClause> onClauses = list3;
			int num4 = blockAliasNum + 1;
			blockAliasNum = num4;
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock(opType, slotInfos, children, onClauses, identifiers, num4);
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x000F9570 File Offset: 0x000F7770
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo GetJoinSlotInfo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType, bool isRequiredSlot, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock> children, int slotNum, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers)
		{
			if (!isRequiredSlot)
			{
				return new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(false, false, null, base.GetMemberPath(slotNum));
			}
			int num = -1;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseStatement = null;
			for (int i = 0; i < children.Count; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock = children[i];
				if (cqlBlock.IsProjected(slotNum))
				{
					if (base.IsKeySlot(slotNum))
					{
						num = i;
						break;
					}
					if (opType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ)
					{
						num = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode.GetInnerJoinChildForSlot(children, slotNum);
						break;
					}
					if (num != -1)
					{
						if (caseStatement == null)
						{
							caseStatement = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement(base.GetMemberPath(slotNum));
							this.AddCaseForOuterJoins(caseStatement, children[num], slotNum, identifiers);
						}
						this.AddCaseForOuterJoins(caseStatement, cqlBlock, slotNum, identifiers);
					}
					num = i;
				}
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = base.GetMemberPath(slotNum);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot slotValue;
			if (caseStatement != null && (caseStatement.Clauses.Count > 0 || caseStatement.ElseValue != null))
			{
				caseStatement.Simplify();
				slotValue = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatementProjectedSlot(caseStatement, null);
			}
			else if (num >= 0)
			{
				slotValue = children[num].QualifySlotWithBlockAlias(slotNum);
			}
			else if (base.IsBoolSlot(slotNum))
			{
				slotValue = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.BooleanProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.False, identifiers, base.SlotToBoolIndex(slotNum));
			}
			else
			{
				slotValue = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain.GetDefaultValueForMemberPath(memberPath, base.GetLeaves(), base.ViewgenContext.Config));
			}
			bool enforceNotNull = base.IsBoolSlot(slotNum) && ((opType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ && num > 0) || opType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.FOJ);
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(true, true, slotValue, memberPath, enforceNotNull);
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x000F96C4 File Offset: 0x000F78C4
		private static int GetInnerJoinChildForSlot(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock> children, int slotNum)
		{
			int num = -1;
			for (int i = 0; i < children.Count; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock = children[i];
				if (cqlBlock.IsProjected(slotNum))
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot projectedSlot = cqlBlock.SlotValue(slotNum);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot constantProjectedSlot = projectedSlot as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot;
					if (projectedSlot is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)
					{
						num = i;
					}
					else if (constantProjectedSlot != null && constantProjectedSlot.CellConstant.IsNull())
					{
						if (num == -1)
						{
							num = i;
						}
					}
					else
					{
						num = i;
					}
				}
			}
			return num;
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x000F972C File Offset: 0x000F792C
		private void AddCaseForOuterJoins(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseForOuterJoins, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock child, int slotNum, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot constantProjectedSlot = child.SlotValue(slotNum) as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot;
			if (constantProjectedSlot != null && constantProjectedSlot.CellConstant.IsNull())
			{
				return;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.False;
			for (int i = 0; i < this.NumBoolSlots; i++)
			{
				int slotNum2 = base.BoolIndexToSlot(i);
				if (child.IsProjected(slotNum2))
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.QualifiedCellIdBoolean literal = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.QualifiedCellIdBoolean(child, identifiers, i);
					boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateOr(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
					{
						boolExpression,
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(literal, this.RightDomainMap)
					});
				}
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot value = child.QualifySlotWithBlockAlias(slotNum);
			caseForOuterJoins.AddWhenThen(boolExpression, value);
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x000F97BC File Offset: 0x000F79BC
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery GenerateFragmentQuery(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> children, bool isLeft, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType OpType)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery = isLeft ? children.First<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>().LeftFragmentQuery : children.First<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>().RightFragmentQuery;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor fragmentQueryProcessor = isLeft ? context.LeftFragmentQP : context.RightFragmentQP;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in children.Skip(1))
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery arg = isLeft ? cellTreeNode.LeftFragmentQuery : cellTreeNode.RightFragmentQuery;
				switch (OpType)
				{
				case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ:
					break;
				case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ:
					fragmentQuery = fragmentQueryProcessor.Intersect(fragmentQuery, arg);
					break;
				case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LASJ:
					fragmentQuery = fragmentQueryProcessor.Difference(fragmentQuery, arg);
					break;
				default:
					fragmentQuery = fragmentQueryProcessor.Union(fragmentQuery, arg);
					break;
				}
			}
			return fragmentQuery;
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x000F9880 File Offset: 0x000F7A80
		internal static string OpToEsql(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType)
		{
			switch (opType)
			{
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union:
				return "UNION ALL";
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.FOJ:
				return "FULL OUTER JOIN";
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ:
				return "LEFT OUTER JOIN";
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ:
				return "INNER JOIN";
			default:
				return null;
			}
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x000F98B8 File Offset: 0x000F7AB8
		internal override void ToCompactString(global::System.Text.StringBuilder stringBuilder)
		{
			stringBuilder.Append("(");
			for (int i = 0; i < this.m_children.Count; i++)
			{
				this.m_children[i].ToCompactString(stringBuilder);
				if (i != this.m_children.Count - 1)
				{
					global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(stringBuilder, " {0} ", new object[]
					{
						this.OpType
					});
				}
			}
			stringBuilder.Append(")");
		}

		// Token: 0x0400192C RID: 6444
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> m_attrs;

		// Token: 0x0400192D RID: 6445
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> m_children;

		// Token: 0x0400192E RID: 6446
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType m_opType;

		// Token: 0x0400192F RID: 6447
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery m_leftFragmentQuery;

		// Token: 0x04001930 RID: 6448
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery m_rightFragmentQuery;
	}
}
