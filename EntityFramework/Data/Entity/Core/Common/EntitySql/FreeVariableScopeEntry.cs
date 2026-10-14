using System;
using System.Data.Entity.Core.Common.CommandTrees;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200066E RID: 1646
	internal sealed class FreeVariableScopeEntry : global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry
	{
		// Token: 0x06004EF6 RID: 20214 RVA: 0x0011E813 File Offset: 0x0011CA13
		internal FreeVariableScopeEntry(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression varRef) : base(global::System.Data.Entity.Core.Common.EntitySql.ScopeEntryKind.FreeVar)
		{
			this._varRef = varRef;
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x0011E823 File Offset: 0x0011CA23
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GetExpression(string refName, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			return this._varRef;
		}

		// Token: 0x04001C87 RID: 7303
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression _varRef;
	}
}
