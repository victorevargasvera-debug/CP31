using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200068E RID: 1678
	internal sealed class MethodExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.GroupAggregateExpr
	{
		// Token: 0x06004F7F RID: 20351 RVA: 0x0011FF95 File Offset: 0x0011E195
		internal MethodExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr, global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind distinctKind, global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.Node> args) : this(expr, distinctKind, args, null)
		{
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x0011FFA1 File Offset: 0x0011E1A1
		internal MethodExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr, global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind distinctKind, global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.Node> args, global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.RelshipNavigationExpr> relationships) : base(distinctKind)
		{
			this._expr = expr;
			this._args = args;
			this._relationships = relationships;
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06004F81 RID: 20353 RVA: 0x0011FFC0 File Offset: 0x0011E1C0
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node Expr
		{
			get
			{
				return this._expr;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06004F82 RID: 20354 RVA: 0x0011FFC8 File Offset: 0x0011E1C8
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.Node> Args
		{
			get
			{
				return this._args;
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06004F83 RID: 20355 RVA: 0x0011FFD0 File Offset: 0x0011E1D0
		internal bool HasRelationships
		{
			get
			{
				return this._relationships != null && this._relationships.Count > 0;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06004F84 RID: 20356 RVA: 0x0011FFEA File Offset: 0x0011E1EA
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.RelshipNavigationExpr> Relationships
		{
			get
			{
				return this._relationships;
			}
		}

		// Token: 0x04001D0E RID: 7438
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _expr;

		// Token: 0x04001D0F RID: 7439
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.Node> _args;

		// Token: 0x04001D10 RID: 7440
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.RelshipNavigationExpr> _relationships;
	}
}
