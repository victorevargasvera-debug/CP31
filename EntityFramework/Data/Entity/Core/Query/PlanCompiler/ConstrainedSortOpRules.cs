using System;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000339 RID: 825
	internal static class ConstrainedSortOpRules
	{
		// Token: 0x06002740 RID: 10048 RVA: 0x000713C5 File Offset: 0x0006F5C5
		private static bool ProcessConstrainedSortOpOverEmptySet(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			if (context.Command.GetExtendedNodeInfo(n.Child0).MaxRows == global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero)
			{
				newNode = n.Child0;
				return true;
			}
			newNode = n;
			return false;
		}

		// Token: 0x04000DAD RID: 3501
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule Rule_ConstrainedSortOpOverEmptySet = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstrainedSort, new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ConstrainedSortOpRules.ProcessConstrainedSortOpOverEmptySet));

		// Token: 0x04000DAE RID: 3502
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.Rule[] Rules = new global::System.Data.Entity.Core.Query.InternalTrees.Rule[]
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.ConstrainedSortOpRules.Rule_ConstrainedSortOpOverEmptySet
		};
	}
}
