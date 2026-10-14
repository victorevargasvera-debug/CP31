using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200069B RID: 1691
	internal sealed class RowConstructorExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004FAE RID: 20398 RVA: 0x001202CD File Offset: 0x0011E4CD
		internal RowConstructorExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr> exprList)
		{
			this._exprList = exprList;
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06004FAF RID: 20399 RVA: 0x001202DC File Offset: 0x0011E4DC
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr> AliasedExprList
		{
			get
			{
				return this._exprList;
			}
		}

		// Token: 0x04001D2F RID: 7471
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr> _exprList;
	}
}
