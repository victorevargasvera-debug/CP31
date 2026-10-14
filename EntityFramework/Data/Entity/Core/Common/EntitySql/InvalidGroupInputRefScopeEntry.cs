using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200065C RID: 1628
	internal sealed class InvalidGroupInputRefScopeEntry : global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry
	{
		// Token: 0x06004E24 RID: 20004 RVA: 0x001180F2 File Offset: 0x001162F2
		internal InvalidGroupInputRefScopeEntry() : base(global::System.Data.Entity.Core.Common.EntitySql.ScopeEntryKind.InvalidGroupInputRef)
		{
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x001180FC File Offset: 0x001162FC
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GetExpression(string refName, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidGroupIdentifierReference(refName);
			throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
		}
	}
}
