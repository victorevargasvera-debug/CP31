using System;
using System.Data.Entity.Core.Common.CommandTrees;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200066D RID: 1645
	internal sealed class ProjectionItemDefinitionScopeEntry : global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry
	{
		// Token: 0x06004EF4 RID: 20212 RVA: 0x0011E7FB File Offset: 0x0011C9FB
		internal ProjectionItemDefinitionScopeEntry(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression) : base(global::System.Data.Entity.Core.Common.EntitySql.ScopeEntryKind.ProjectionItemDefinition)
		{
			this._expression = expression;
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x0011E80B File Offset: 0x0011CA0B
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GetExpression(string refName, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			return this._expression;
		}

		// Token: 0x04001C86 RID: 7302
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _expression;
	}
}
