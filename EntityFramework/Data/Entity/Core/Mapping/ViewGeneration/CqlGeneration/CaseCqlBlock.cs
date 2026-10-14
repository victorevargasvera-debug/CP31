using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration
{
	// Token: 0x020005BA RID: 1466
	internal sealed class CaseCqlBlock : global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock
	{
		// Token: 0x0600473D RID: 18237 RVA: 0x000FAB84 File Offset: 0x000F8D84
		internal CaseCqlBlock(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] slots, int caseSlot, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock child, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, int blockAliasNum) : base(slots, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock>(new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock[]
		{
			child
		}), whereClause, identifiers, blockAliasNum)
		{
			this.m_caseSlotInfo = slots[caseSlot];
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x000FABAC File Offset: 0x000F8DAC
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, bool isTopLevel, int indentLevel)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel);
			builder.Append("SELECT ");
			if (isTopLevel)
			{
				builder.Append("VALUE ");
			}
			builder.Append("-- Constructing ").Append(this.m_caseSlotInfo.OutputMember.LeafName);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock = base.Children[0];
			base.GenerateProjectionEsql(builder, cqlBlock.CqlAlias, true, indentLevel, isTopLevel);
			builder.Append("FROM (");
			cqlBlock.AsEsql(builder, false, indentLevel + 1);
			global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel);
			builder.Append(") AS ").Append(cqlBlock.CqlAlias);
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.EqualityComparer.Equals(base.WhereClause, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True))
			{
				global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel);
				builder.Append("WHERE ");
				base.WhereClause.AsEsql(builder, cqlBlock.CqlAlias);
			}
			return builder;
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x000FAC90 File Offset: 0x000F8E90
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(bool isTopLevel)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source = base.Children[0].AsCqt(false);
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.EqualityComparer.Equals(base.WhereClause, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True))
			{
				source = from row in source
				where this.WhereClause.AsCqt(row)
				select row;
			}
			return from row in source
			select this.GenerateProjectionCqt(row, isTopLevel);
		}

		// Token: 0x04001944 RID: 6468
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo m_caseSlotInfo;
	}
}
