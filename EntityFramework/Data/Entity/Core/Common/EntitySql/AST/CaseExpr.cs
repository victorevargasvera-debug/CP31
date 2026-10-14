using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000679 RID: 1657
	internal sealed class CaseExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F30 RID: 20272 RVA: 0x0011F118 File Offset: 0x0011D318
		internal CaseExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.WhenThenExpr> whenThenExpr) : this(whenThenExpr, null)
		{
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x0011F122 File Offset: 0x0011D322
		internal CaseExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.WhenThenExpr> whenThenExpr, global::System.Data.Entity.Core.Common.EntitySql.AST.Node elseExpr)
		{
			this._whenThenExpr = whenThenExpr;
			this._elseExpr = elseExpr;
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06004F32 RID: 20274 RVA: 0x0011F138 File Offset: 0x0011D338
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.WhenThenExpr> WhenThenExprList
		{
			get
			{
				return this._whenThenExpr;
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06004F33 RID: 20275 RVA: 0x0011F140 File Offset: 0x0011D340
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node ElseExpr
		{
			get
			{
				return this._elseExpr;
			}
		}

		// Token: 0x04001CC9 RID: 7369
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.WhenThenExpr> _whenThenExpr;

		// Token: 0x04001CCA RID: 7370
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _elseExpr;
	}
}
