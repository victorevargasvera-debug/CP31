using System;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000672 RID: 1650
	internal sealed class AliasedExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F18 RID: 20248 RVA: 0x0011EF08 File Offset: 0x0011D108
		internal AliasedExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr, global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier alias)
		{
			if (string.IsNullOrEmpty(alias.Name))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = alias.ErrCtx;
				string invalidEmptyIdentifier = global::System.Data.Entity.Resources.Strings.InvalidEmptyIdentifier;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, invalidEmptyIdentifier, null);
			}
			this._expr = expr;
			this._alias = alias;
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x0011EF4A File Offset: 0x0011D14A
		internal AliasedExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr)
		{
			this._expr = expr;
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06004F1A RID: 20250 RVA: 0x0011EF59 File Offset: 0x0011D159
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node Expr
		{
			get
			{
				return this._expr;
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06004F1B RID: 20251 RVA: 0x0011EF61 File Offset: 0x0011D161
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier Alias
		{
			get
			{
				return this._alias;
			}
		}

		// Token: 0x04001C92 RID: 7314
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _expr;

		// Token: 0x04001C93 RID: 7315
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier _alias;
	}
}
