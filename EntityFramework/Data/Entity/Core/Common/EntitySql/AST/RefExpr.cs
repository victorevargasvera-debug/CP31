using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000699 RID: 1689
	internal sealed class RefExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004FAA RID: 20394 RVA: 0x0012029F File Offset: 0x0011E49F
		internal RefExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node refArgExpr)
		{
			this._argExpr = refArgExpr;
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06004FAB RID: 20395 RVA: 0x001202AE File Offset: 0x0011E4AE
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node ArgExpr
		{
			get
			{
				return this._argExpr;
			}
		}

		// Token: 0x04001D2D RID: 7469
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _argExpr;
	}
}
