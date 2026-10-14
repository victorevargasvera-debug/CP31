using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.EntitySql.AST;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000650 RID: 1616
	internal sealed class FunctionAggregateInfo : global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo
	{
		// Token: 0x06004DFB RID: 19963 RVA: 0x0011788F File Offset: 0x00115A8F
		internal FunctionAggregateInfo(global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr methodExpr, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo containingAggregate, global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion definingScopeRegion) : base(global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind.Function, methodExpr, errCtx, containingAggregate, definingScopeRegion)
		{
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x0011789D File Offset: 0x00115A9D
		internal void AttachToAstNode(string aggregateName, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate aggregateDefinition)
		{
			base.AttachToAstNode(aggregateName, aggregateDefinition.ResultType);
			this.AggregateDefinition = aggregateDefinition;
		}

		// Token: 0x04001C36 RID: 7222
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate AggregateDefinition;
	}
}
