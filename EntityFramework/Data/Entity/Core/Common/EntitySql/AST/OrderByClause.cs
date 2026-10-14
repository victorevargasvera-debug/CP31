using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000692 RID: 1682
	internal sealed class OrderByClause : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F91 RID: 20369 RVA: 0x001200D2 File Offset: 0x0011E2D2
		internal OrderByClause(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.OrderByClauseItem> orderByClauseItem, global::System.Data.Entity.Core.Common.EntitySql.AST.Node skipExpr, global::System.Data.Entity.Core.Common.EntitySql.AST.Node limitExpr, uint methodCallCount)
		{
			this._orderByClauseItem = orderByClauseItem;
			this._skipExpr = skipExpr;
			this._limitExpr = limitExpr;
			this._methodCallCount = methodCallCount;
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06004F92 RID: 20370 RVA: 0x001200F7 File Offset: 0x0011E2F7
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.OrderByClauseItem> OrderByClauseItem
		{
			get
			{
				return this._orderByClauseItem;
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06004F93 RID: 20371 RVA: 0x001200FF File Offset: 0x0011E2FF
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node SkipSubClause
		{
			get
			{
				return this._skipExpr;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06004F94 RID: 20372 RVA: 0x00120107 File Offset: 0x0011E307
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node LimitSubClause
		{
			get
			{
				return this._limitExpr;
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06004F95 RID: 20373 RVA: 0x0012010F File Offset: 0x0011E30F
		internal bool HasMethodCall
		{
			get
			{
				return this._methodCallCount > 0U;
			}
		}

		// Token: 0x04001D18 RID: 7448
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.OrderByClauseItem> _orderByClauseItem;

		// Token: 0x04001D19 RID: 7449
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _skipExpr;

		// Token: 0x04001D1A RID: 7450
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _limitExpr;

		// Token: 0x04001D1B RID: 7451
		private readonly uint _methodCallCount;
	}
}
