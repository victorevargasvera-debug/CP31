using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200068F RID: 1679
	internal sealed class MultisetConstructorExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F85 RID: 20357 RVA: 0x0011FFF2 File Offset: 0x0011E1F2
		internal MultisetConstructorExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.Node> exprList)
		{
			this._exprList = exprList;
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06004F86 RID: 20358 RVA: 0x00120001 File Offset: 0x0011E201
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.Node> ExprList
		{
			get
			{
				return this._exprList;
			}
		}

		// Token: 0x04001D11 RID: 7441
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.Node> _exprList;
	}
}
