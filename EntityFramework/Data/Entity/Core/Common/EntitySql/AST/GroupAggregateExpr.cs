using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000684 RID: 1668
	internal abstract class GroupAggregateExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F51 RID: 20305 RVA: 0x0011F3A7 File Offset: 0x0011D5A7
		internal GroupAggregateExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind distinctKind)
		{
			this.DistinctKind = distinctKind;
		}

		// Token: 0x04001CE6 RID: 7398
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind DistinctKind;

		// Token: 0x04001CE7 RID: 7399
		internal global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo AggregateInfo;
	}
}
