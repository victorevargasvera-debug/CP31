using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration
{
	// Token: 0x020005BE RID: 1470
	internal sealed class JoinCqlBlock : global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock
	{
		// Token: 0x0600475A RID: 18266 RVA: 0x000FB1D2 File Offset: 0x000F93D2
		internal JoinCqlBlock(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] slotInfos, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock> children, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock.OnClause> onClauses, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, int blockAliasNum) : base(slotInfos, children, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True, identifiers, blockAliasNum)
		{
			this.m_opType = opType;
			this.m_onClauses = onClauses;
		}

		// Token: 0x0600475B RID: 18267 RVA: 0x000FB1F4 File Offset: 0x000F93F4
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, bool isTopLevel, int indentLevel)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel);
			builder.Append("SELECT ");
			base.GenerateProjectionEsql(builder, null, false, indentLevel, isTopLevel);
			global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel);
			builder.Append("FROM ");
			int num = 0;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock in base.Children)
			{
				if (num > 0)
				{
					global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel + 1);
					builder.Append(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode.OpToEsql(this.m_opType));
				}
				builder.Append(" (");
				cqlBlock.AsEsql(builder, false, indentLevel + 1);
				builder.Append(") AS ").Append(cqlBlock.CqlAlias);
				if (num > 0)
				{
					global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel + 1);
					builder.Append("ON ");
					this.m_onClauses[num - 1].AsEsql(builder);
				}
				num++;
			}
			return builder;
		}

		// Token: 0x0600475C RID: 18268 RVA: 0x000FB2F8 File Offset: 0x000F94F8
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(bool isTopLevel)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock = base.Children[0];
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = cqlBlock.AsCqt(false);
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			for (int i = 1; i < base.Children.Count; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock2 = base.Children[i];
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right = cqlBlock2.AsCqt(false);
				global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> joinCondition = new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this.m_onClauses[i - 1].AsCqt);
				global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression dbJoinExpression;
				switch (this.m_opType)
				{
				case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.FOJ:
					dbJoinExpression = dbExpression.FullOuterJoin(right, joinCondition);
					break;
				case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ:
					dbJoinExpression = dbExpression.LeftOuterJoin(right, joinCondition);
					break;
				case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ:
					dbJoinExpression = dbExpression.InnerJoin(right, joinCondition);
					break;
				default:
					return null;
				}
				if (i == 1)
				{
					cqlBlock.SetJoinTreeContext(list, dbJoinExpression.Left.VariableName);
				}
				else
				{
					list.Add(dbJoinExpression.Left.VariableName);
				}
				cqlBlock2.SetJoinTreeContext(list, dbJoinExpression.Right.VariableName);
				dbExpression = dbJoinExpression;
			}
			return from row in dbExpression
			select base.GenerateProjectionCqt(row, false);
		}

		// Token: 0x0400194F RID: 6479
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType m_opType;

		// Token: 0x04001950 RID: 6480
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock.OnClause> m_onClauses;

		// Token: 0x02000BF1 RID: 3057
		internal sealed class OnClause : global::System.Data.Entity.Core.Common.Utils.InternalBase
		{
			// Token: 0x060068BE RID: 26814 RVA: 0x00163FB3 File Offset: 0x001621B3
			internal OnClause()
			{
				this.m_singleClauses = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock.OnClause.SingleClause>();
			}

			// Token: 0x060068BF RID: 26815 RVA: 0x00163FC8 File Offset: 0x001621C8
			internal void Add(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot leftSlot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath leftSlotOutputMember, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot rightSlot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath rightSlotOutputMember)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock.OnClause.SingleClause item = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock.OnClause.SingleClause(leftSlot, leftSlotOutputMember, rightSlot, rightSlotOutputMember);
				this.m_singleClauses.Add(item);
			}

			// Token: 0x060068C0 RID: 26816 RVA: 0x00163FEC File Offset: 0x001621EC
			internal global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder)
			{
				bool flag = true;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock.OnClause.SingleClause singleClause in this.m_singleClauses)
				{
					if (!flag)
					{
						builder.Append(" AND ");
					}
					singleClause.AsEsql(builder);
					flag = false;
				}
				return builder;
			}

			// Token: 0x060068C1 RID: 26817 RVA: 0x00164054 File Offset: 0x00162254
			internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression leftRow, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression rightRow)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.m_singleClauses[0].AsCqt(leftRow, rightRow);
				for (int i = 1; i < this.m_singleClauses.Count; i++)
				{
					dbExpression = dbExpression.And(this.m_singleClauses[i].AsCqt(leftRow, rightRow));
				}
				return dbExpression;
			}

			// Token: 0x060068C2 RID: 26818 RVA: 0x001640A6 File Offset: 0x001622A6
			internal override void ToCompactString(global::System.Text.StringBuilder builder)
			{
				builder.Append("ON ");
				global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedString(builder, this.m_singleClauses, " AND ");
			}

			// Token: 0x04002F38 RID: 12088
			private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.JoinCqlBlock.OnClause.SingleClause> m_singleClauses;

			// Token: 0x02000D89 RID: 3465
			private sealed class SingleClause : global::System.Data.Entity.Core.Common.Utils.InternalBase
			{
				// Token: 0x06006F89 RID: 28553 RVA: 0x0017D004 File Offset: 0x0017B204
				internal SingleClause(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot leftSlot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath leftSlotOutputMember, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot rightSlot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath rightSlotOutputMember)
				{
					this.m_leftSlot = leftSlot;
					this.m_leftSlotOutputMember = leftSlotOutputMember;
					this.m_rightSlot = rightSlot;
					this.m_rightSlotOutputMember = rightSlotOutputMember;
				}

				// Token: 0x06006F8A RID: 28554 RVA: 0x0017D029 File Offset: 0x0017B229
				internal global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder)
				{
					builder.Append(this.m_leftSlot.GetQualifiedCqlName(this.m_leftSlotOutputMember)).Append(" = ").Append(this.m_rightSlot.GetQualifiedCqlName(this.m_rightSlotOutputMember));
					return builder;
				}

				// Token: 0x06006F8B RID: 28555 RVA: 0x0017D064 File Offset: 0x0017B264
				internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression leftRow, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression rightRow)
				{
					return this.m_leftSlot.AsCqt(leftRow, this.m_leftSlotOutputMember).Equal(this.m_rightSlot.AsCqt(rightRow, this.m_rightSlotOutputMember));
				}

				// Token: 0x06006F8C RID: 28556 RVA: 0x0017D08F File Offset: 0x0017B28F
				internal override void ToCompactString(global::System.Text.StringBuilder builder)
				{
					this.m_leftSlot.ToCompactString(builder);
					builder.Append(" = ");
					this.m_rightSlot.ToCompactString(builder);
				}

				// Token: 0x04003362 RID: 13154
				private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot m_leftSlot;

				// Token: 0x04003363 RID: 13155
				private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath m_leftSlotOutputMember;

				// Token: 0x04003364 RID: 13156
				private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot m_rightSlot;

				// Token: 0x04003365 RID: 13157
				private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath m_rightSlotOutputMember;
			}
		}
	}
}
