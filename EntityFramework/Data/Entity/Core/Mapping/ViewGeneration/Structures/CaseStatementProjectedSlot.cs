using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x02000599 RID: 1433
	internal sealed class CaseStatementProjectedSlot : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot
	{
		// Token: 0x06004571 RID: 17777 RVA: 0x000F43E4 File Offset: 0x000F25E4
		internal CaseStatementProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement statement, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships)
		{
			this.m_caseStatement = statement;
			this.m_withRelationships = withRelationships;
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x000F43FA File Offset: 0x000F25FA
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot DeepQualify(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock block)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatementProjectedSlot(this.m_caseStatement.DeepQualify(block), null);
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x000F440E File Offset: 0x000F260E
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias, int indentLevel)
		{
			this.m_caseStatement.AsEsql(builder, this.m_withRelationships, blockAlias, indentLevel);
			return builder;
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x000F4427 File Offset: 0x000F2627
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			return this.m_caseStatement.AsCqt(row, this.m_withRelationships);
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x000F443B File Offset: 0x000F263B
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			this.m_caseStatement.ToCompactString(builder);
		}

		// Token: 0x040018E9 RID: 6377
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement m_caseStatement;

		// Token: 0x040018EA RID: 6378
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> m_withRelationships;
	}
}
