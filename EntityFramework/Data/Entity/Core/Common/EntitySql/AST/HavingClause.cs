using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000687 RID: 1671
	internal sealed class HavingClause : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F56 RID: 20310 RVA: 0x0011F3E5 File Offset: 0x0011D5E5
		internal HavingClause(global::System.Data.Entity.Core.Common.EntitySql.AST.Node havingExpr, uint methodCallCounter)
		{
			this._havingExpr = havingExpr;
			this._methodCallCount = methodCallCounter;
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06004F57 RID: 20311 RVA: 0x0011F3FB File Offset: 0x0011D5FB
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node HavingPredicate
		{
			get
			{
				return this._havingExpr;
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06004F58 RID: 20312 RVA: 0x0011F403 File Offset: 0x0011D603
		internal bool HasMethodCall
		{
			get
			{
				return this._methodCallCount > 0U;
			}
		}

		// Token: 0x04001CEA RID: 7402
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _havingExpr;

		// Token: 0x04001CEB RID: 7403
		private readonly uint _methodCallCount;
	}
}
