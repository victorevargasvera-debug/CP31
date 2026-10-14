using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000695 RID: 1685
	internal sealed class ParenExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F9B RID: 20379 RVA: 0x0012015A File Offset: 0x0011E35A
		internal ParenExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr)
		{
			this._expr = expr;
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06004F9C RID: 20380 RVA: 0x00120169 File Offset: 0x0011E369
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node Expr
		{
			get
			{
				return this._expr;
			}
		}

		// Token: 0x04001D23 RID: 7459
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _expr;
	}
}
