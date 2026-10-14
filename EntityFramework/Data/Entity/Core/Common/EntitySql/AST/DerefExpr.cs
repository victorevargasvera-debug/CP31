using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200067D RID: 1661
	internal sealed class DerefExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F3E RID: 20286 RVA: 0x0011F1C5 File Offset: 0x0011D3C5
		internal DerefExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node derefArgExpr)
		{
			this._argExpr = derefArgExpr;
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06004F3F RID: 20287 RVA: 0x0011F1D4 File Offset: 0x0011D3D4
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node ArgExpr
		{
			get
			{
				return this._argExpr;
			}
		}

		// Token: 0x04001CD1 RID: 7377
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _argExpr;
	}
}
