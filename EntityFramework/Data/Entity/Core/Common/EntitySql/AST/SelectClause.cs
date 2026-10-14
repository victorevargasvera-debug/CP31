using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200069D RID: 1693
	internal sealed class SelectClause : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004FB2 RID: 20402 RVA: 0x001202FB File Offset: 0x0011E4FB
		internal SelectClause(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr> items, global::System.Data.Entity.Core.Common.EntitySql.AST.SelectKind selectKind, global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind distinctKind, global::System.Data.Entity.Core.Common.EntitySql.AST.Node topExpr, uint methodCallCount)
		{
			this._selectKind = selectKind;
			this._selectClauseItems = items;
			this._distinctKind = distinctKind;
			this._topExpr = topExpr;
			this._methodCallCount = methodCallCount;
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06004FB3 RID: 20403 RVA: 0x00120328 File Offset: 0x0011E528
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr> Items
		{
			get
			{
				return this._selectClauseItems;
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06004FB4 RID: 20404 RVA: 0x00120330 File Offset: 0x0011E530
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.SelectKind SelectKind
		{
			get
			{
				return this._selectKind;
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x00120338 File Offset: 0x0011E538
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind DistinctKind
		{
			get
			{
				return this._distinctKind;
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06004FB6 RID: 20406 RVA: 0x00120340 File Offset: 0x0011E540
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node TopExpr
		{
			get
			{
				return this._topExpr;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06004FB7 RID: 20407 RVA: 0x00120348 File Offset: 0x0011E548
		internal bool HasMethodCall
		{
			get
			{
				return this._methodCallCount > 0U;
			}
		}

		// Token: 0x04001D31 RID: 7473
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr> _selectClauseItems;

		// Token: 0x04001D32 RID: 7474
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.SelectKind _selectKind;

		// Token: 0x04001D33 RID: 7475
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind _distinctKind;

		// Token: 0x04001D34 RID: 7476
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _topExpr;

		// Token: 0x04001D35 RID: 7477
		private readonly uint _methodCallCount;
	}
}
