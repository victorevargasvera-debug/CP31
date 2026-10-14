using System;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000368 RID: 872
	internal static class SortOpRules
	{
		// Token: 0x06002A54 RID: 10836 RVA: 0x00089730 File Offset: 0x00087930
		private static bool ProcessSortOpOverAtMostOneRow(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = context.Command.GetExtendedNodeInfo(n.Child0);
			if (extendedNodeInfo.MaxRows == global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero || extendedNodeInfo.MaxRows == global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One)
			{
				newNode = n.Child0;
				return true;
			}
			newNode = n;
			return false;
		}

		// Token: 0x04000E96 RID: 3734
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule Rule_SortOpOverAtMostOneRow = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort, new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.SortOpRules.ProcessSortOpOverAtMostOneRow));

		// Token: 0x04000E97 RID: 3735
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.Rule[] Rules = new global::System.Data.Entity.Core.Query.InternalTrees.Rule[]
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.SortOpRules.Rule_SortOpOverAtMostOneRow
		};
	}
}
