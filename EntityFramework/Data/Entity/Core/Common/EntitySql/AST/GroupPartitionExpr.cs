using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000686 RID: 1670
	internal sealed class GroupPartitionExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.GroupAggregateExpr
	{
		// Token: 0x06004F54 RID: 20308 RVA: 0x0011F3CD File Offset: 0x0011D5CD
		internal GroupPartitionExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind distinctKind, global::System.Data.Entity.Core.Common.EntitySql.AST.Node refArgExpr) : base(distinctKind)
		{
			this._argExpr = refArgExpr;
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06004F55 RID: 20309 RVA: 0x0011F3DD File Offset: 0x0011D5DD
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node ArgExpr
		{
			get
			{
				return this._argExpr;
			}
		}

		// Token: 0x04001CE9 RID: 7401
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _argExpr;
	}
}
