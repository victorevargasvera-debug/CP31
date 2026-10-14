using System;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000690 RID: 1680
	internal sealed class NamespaceImport : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F87 RID: 20359 RVA: 0x00120009 File Offset: 0x0011E209
		internal NamespaceImport(global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier identifier)
		{
			this._namespaceName = identifier;
		}

		// Token: 0x06004F88 RID: 20360 RVA: 0x00120018 File Offset: 0x0011E218
		internal NamespaceImport(global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr dorExpr)
		{
			this._namespaceName = dorExpr;
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x00120028 File Offset: 0x0011E228
		internal NamespaceImport(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr)
		{
			this._namespaceAlias = null;
			global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier identifier = bltInExpr.Arg1 as global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier;
			if (identifier == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = bltInExpr.Arg1.ErrCtx;
				string invalidNamespaceAlias = global::System.Data.Entity.Resources.Strings.InvalidNamespaceAlias;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, invalidNamespaceAlias, null);
			}
			this._namespaceAlias = identifier;
			this._namespaceName = bltInExpr.Arg2;
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06004F8A RID: 20362 RVA: 0x0012007D File Offset: 0x0011E27D
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier Alias
		{
			get
			{
				return this._namespaceAlias;
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06004F8B RID: 20363 RVA: 0x00120085 File Offset: 0x0011E285
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node NamespaceName
		{
			get
			{
				return this._namespaceName;
			}
		}

		// Token: 0x04001D12 RID: 7442
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier _namespaceAlias;

		// Token: 0x04001D13 RID: 7443
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _namespaceName;
	}
}
