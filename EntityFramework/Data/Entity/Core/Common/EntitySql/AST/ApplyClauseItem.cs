using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000673 RID: 1651
	internal sealed class ApplyClauseItem : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F1C RID: 20252 RVA: 0x0011EF69 File Offset: 0x0011D169
		internal ApplyClauseItem(global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem applyLeft, global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem applyRight, global::System.Data.Entity.Core.Common.EntitySql.AST.ApplyKind applyKind)
		{
			this._applyLeft = applyLeft;
			this._applyRight = applyRight;
			this._applyKind = applyKind;
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06004F1D RID: 20253 RVA: 0x0011EF86 File Offset: 0x0011D186
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem LeftExpr
		{
			get
			{
				return this._applyLeft;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06004F1E RID: 20254 RVA: 0x0011EF8E File Offset: 0x0011D18E
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem RightExpr
		{
			get
			{
				return this._applyRight;
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06004F1F RID: 20255 RVA: 0x0011EF96 File Offset: 0x0011D196
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.ApplyKind ApplyKind
		{
			get
			{
				return this._applyKind;
			}
		}

		// Token: 0x04001C94 RID: 7316
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem _applyLeft;

		// Token: 0x04001C95 RID: 7317
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem _applyRight;

		// Token: 0x04001C96 RID: 7318
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.ApplyKind _applyKind;
	}
}
