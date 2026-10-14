using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000681 RID: 1665
	internal sealed class FromClauseItem : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F46 RID: 20294 RVA: 0x0011F2FB File Offset: 0x0011D4FB
		internal FromClauseItem(global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr aliasExpr)
		{
			this._fromClauseItemExpr = aliasExpr;
			this._fromClauseItemKind = global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItemKind.AliasedFromClause;
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x0011F311 File Offset: 0x0011D511
		internal FromClauseItem(global::System.Data.Entity.Core.Common.EntitySql.AST.JoinClauseItem joinClauseItem)
		{
			this._fromClauseItemExpr = joinClauseItem;
			this._fromClauseItemKind = global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItemKind.JoinFromClause;
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x0011F327 File Offset: 0x0011D527
		internal FromClauseItem(global::System.Data.Entity.Core.Common.EntitySql.AST.ApplyClauseItem applyClauseItem)
		{
			this._fromClauseItemExpr = applyClauseItem;
			this._fromClauseItemKind = global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItemKind.ApplyFromClause;
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06004F49 RID: 20297 RVA: 0x0011F33D File Offset: 0x0011D53D
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node FromExpr
		{
			get
			{
				return this._fromClauseItemExpr;
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06004F4A RID: 20298 RVA: 0x0011F345 File Offset: 0x0011D545
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItemKind FromClauseItemKind
		{
			get
			{
				return this._fromClauseItemKind;
			}
		}

		// Token: 0x04001CDB RID: 7387
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _fromClauseItemExpr;

		// Token: 0x04001CDC RID: 7388
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItemKind _fromClauseItemKind;
	}
}
