using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.EntitySql.AST;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000657 RID: 1623
	internal sealed class GroupPartitionInfo : global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo
	{
		// Token: 0x06004E1A RID: 19994 RVA: 0x00118099 File Offset: 0x00116299
		internal GroupPartitionInfo(global::System.Data.Entity.Core.Common.EntitySql.AST.GroupPartitionExpr groupPartitionExpr, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo containingAggregate, global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion definingScopeRegion) : base(global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind.Partition, groupPartitionExpr, errCtx, containingAggregate, definingScopeRegion)
		{
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x001180A7 File Offset: 0x001162A7
		internal void AttachToAstNode(string aggregateName, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression aggregateDefinition)
		{
			base.AttachToAstNode(aggregateName, aggregateDefinition.ResultType);
			this.AggregateDefinition = aggregateDefinition;
		}

		// Token: 0x04001C4E RID: 7246
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AggregateDefinition;
	}
}
