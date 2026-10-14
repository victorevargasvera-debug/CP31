using System;
using System.Data.Entity.Core.Common.CommandTrees;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000667 RID: 1639
	internal abstract class ScopeEntry
	{
		// Token: 0x06004E48 RID: 20040 RVA: 0x001182D0 File Offset: 0x001164D0
		internal ScopeEntry(global::System.Data.Entity.Core.Common.EntitySql.ScopeEntryKind scopeEntryKind)
		{
			this._scopeEntryKind = scopeEntryKind;
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06004E49 RID: 20041 RVA: 0x001182DF File Offset: 0x001164DF
		internal global::System.Data.Entity.Core.Common.EntitySql.ScopeEntryKind EntryKind
		{
			get
			{
				return this._scopeEntryKind;
			}
		}

		// Token: 0x06004E4A RID: 20042
		internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GetExpression(string refName, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx);

		// Token: 0x04001C64 RID: 7268
		private readonly global::System.Data.Entity.Core.Common.EntitySql.ScopeEntryKind _scopeEntryKind;
	}
}
