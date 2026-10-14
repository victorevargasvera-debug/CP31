using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000689 RID: 1673
	internal sealed class JoinClauseItem : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F5C RID: 20316 RVA: 0x0011F480 File Offset: 0x0011D680
		internal JoinClauseItem(global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem joinLeft, global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem joinRight, global::System.Data.Entity.Core.Common.EntitySql.AST.JoinKind joinKind) : this(joinLeft, joinRight, joinKind, null)
		{
		}

		// Token: 0x06004F5D RID: 20317 RVA: 0x0011F48C File Offset: 0x0011D68C
		internal JoinClauseItem(global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem joinLeft, global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem joinRight, global::System.Data.Entity.Core.Common.EntitySql.AST.JoinKind joinKind, global::System.Data.Entity.Core.Common.EntitySql.AST.Node onExpr)
		{
			this._joinLeft = joinLeft;
			this._joinRight = joinRight;
			this.JoinKind = joinKind;
			this._onExpr = onExpr;
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06004F5E RID: 20318 RVA: 0x0011F4B1 File Offset: 0x0011D6B1
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem LeftExpr
		{
			get
			{
				return this._joinLeft;
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06004F5F RID: 20319 RVA: 0x0011F4B9 File Offset: 0x0011D6B9
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem RightExpr
		{
			get
			{
				return this._joinRight;
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06004F60 RID: 20320 RVA: 0x0011F4C1 File Offset: 0x0011D6C1
		// (set) Token: 0x06004F61 RID: 20321 RVA: 0x0011F4C9 File Offset: 0x0011D6C9
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.JoinKind JoinKind { get; set; }

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06004F62 RID: 20322 RVA: 0x0011F4D2 File Offset: 0x0011D6D2
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node OnExpr
		{
			get
			{
				return this._onExpr;
			}
		}

		// Token: 0x04001CEE RID: 7406
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem _joinLeft;

		// Token: 0x04001CEF RID: 7407
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem _joinRight;

		// Token: 0x04001CF0 RID: 7408
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _onExpr;
	}
}
