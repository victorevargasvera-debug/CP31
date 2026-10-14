using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration
{
	// Token: 0x020005B9 RID: 1465
	internal sealed class BooleanProjectedSlot : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot
	{
		// Token: 0x06004738 RID: 18232 RVA: 0x000FAA62 File Offset: 0x000F8C62
		internal BooleanProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression expr, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, int originalCellNum)
		{
			this.m_expr = expr;
			this.m_originalCell = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellIdBoolean(identifiers, originalCellNum);
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x000FAA7E File Offset: 0x000F8C7E
		internal override string GetCqlFieldAlias(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			return this.m_originalCell.SlotName;
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x000FAA8C File Offset: 0x000F8C8C
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias, int indentLevel)
		{
			if (this.m_expr.IsTrue || this.m_expr.IsFalse)
			{
				this.m_expr.AsEsql(builder, blockAlias);
			}
			else
			{
				builder.Append("CASE WHEN ");
				this.m_expr.AsEsql(builder, blockAlias);
				builder.Append(" THEN True ELSE False END");
			}
			return builder;
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x000FAAEC File Offset: 0x000F8CEC
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			if (this.m_expr.IsTrue || this.m_expr.IsFalse)
			{
				return this.m_expr.AsCqt(row);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				this.m_expr.AsCqt(row)
			}, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True
			}, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False);
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x000FAB4D File Offset: 0x000F8D4D
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(builder, "<{0}, ", new object[]
			{
				this.m_originalCell.SlotName
			});
			this.m_expr.ToCompactString(builder);
			builder.Append('>');
		}

		// Token: 0x04001942 RID: 6466
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression m_expr;

		// Token: 0x04001943 RID: 6467
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellIdBoolean m_originalCell;
	}
}
