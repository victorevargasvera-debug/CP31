using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration
{
	// Token: 0x020005BD RID: 1469
	internal sealed class ExtentCqlBlock : global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock
	{
		// Token: 0x06004756 RID: 18262 RVA: 0x000FB054 File Offset: 0x000F9254
		internal ExtentCqlBlock(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct selectDistinct, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] slots, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, int blockAliasNum) : base(slots, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.ExtentCqlBlock._emptyChildren, whereClause, identifiers, blockAliasNum)
		{
			this.m_extent = extent;
			this.m_nodeTableAlias = identifiers.GetBlockAlias();
			this.m_selectDistinct = selectDistinct;
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x000FB084 File Offset: 0x000F9284
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, bool isTopLevel, int indentLevel)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel);
			builder.Append("SELECT ");
			if (this.m_selectDistinct == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct.Yes)
			{
				builder.Append("DISTINCT ");
			}
			base.GenerateProjectionEsql(builder, this.m_nodeTableAlias, true, indentLevel, isTopLevel);
			builder.Append("FROM ");
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedQualifiedName(builder, this.m_extent.EntityContainer.Name, this.m_extent.Name);
			builder.Append(" AS ").Append(this.m_nodeTableAlias);
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.EqualityComparer.Equals(base.WhereClause, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True))
			{
				global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel);
				builder.Append("WHERE ");
				base.WhereClause.AsEsql(builder, this.m_nodeTableAlias);
			}
			return builder;
		}

		// Token: 0x06004758 RID: 18264 RVA: 0x000FB14C File Offset: 0x000F934C
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(bool isTopLevel)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.m_extent.Scan();
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.EqualityComparer.Equals(base.WhereClause, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True))
			{
				dbExpression = from row in dbExpression
				where this.WhereClause.AsCqt(row)
				select row;
			}
			dbExpression = from row in dbExpression
			select this.GenerateProjectionCqt(row, isTopLevel);
			if (this.m_selectDistinct == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct.Yes)
			{
				dbExpression = dbExpression.Distinct();
			}
			return dbExpression;
		}

		// Token: 0x0400194B RID: 6475
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase m_extent;

		// Token: 0x0400194C RID: 6476
		private readonly string m_nodeTableAlias;

		// Token: 0x0400194D RID: 6477
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct m_selectDistinct;

		// Token: 0x0400194E RID: 6478
		private static readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock> _emptyChildren = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock>();
	}
}
