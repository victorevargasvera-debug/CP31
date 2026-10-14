using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x020006A1 RID: 1697
	internal class WhenThenExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004FBC RID: 20412 RVA: 0x00120381 File Offset: 0x0011E581
		internal WhenThenExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node whenExpr, global::System.Data.Entity.Core.Common.EntitySql.AST.Node thenExpr)
		{
			this._whenExpr = whenExpr;
			this._thenExpr = thenExpr;
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06004FBD RID: 20413 RVA: 0x00120397 File Offset: 0x0011E597
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node WhenExpr
		{
			get
			{
				return this._whenExpr;
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06004FBE RID: 20414 RVA: 0x0012039F File Offset: 0x0011E59F
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node ThenExpr
		{
			get
			{
				return this._thenExpr;
			}
		}

		// Token: 0x04001D3B RID: 7483
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _whenExpr;

		// Token: 0x04001D3C RID: 7484
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _thenExpr;
	}
}
