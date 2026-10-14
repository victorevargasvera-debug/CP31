using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration
{
	// Token: 0x020005C0 RID: 1472
	internal sealed class UnionCqlBlock : global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock
	{
		// Token: 0x0600476A RID: 18282 RVA: 0x000FB56E File Offset: 0x000F976E
		internal UnionCqlBlock(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] slotInfos, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock> children, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, int blockAliasNum) : base(slotInfos, children, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True, identifiers, blockAliasNum)
		{
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x000FB580 File Offset: 0x000F9780
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, bool isTopLevel, int indentLevel)
		{
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock in base.Children)
			{
				if (!flag)
				{
					global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel + 1);
					builder.Append(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode.OpToEsql(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union));
				}
				flag = false;
				builder.Append(" (");
				cqlBlock.AsEsql(builder, isTopLevel, indentLevel + 1);
				builder.Append(')');
			}
			return builder;
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x000FB604 File Offset: 0x000F9804
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(bool isTopLevel)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = base.Children[0].AsCqt(isTopLevel);
			for (int i = 1; i < base.Children.Count; i++)
			{
				dbExpression = dbExpression.UnionAll(base.Children[i].AsCqt(isTopLevel));
			}
			return dbExpression;
		}
	}
}
