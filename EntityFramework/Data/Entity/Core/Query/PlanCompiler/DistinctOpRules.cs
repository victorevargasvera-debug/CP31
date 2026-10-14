using System;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200033D RID: 829
	internal static class DistinctOpRules
	{
		// Token: 0x060027A5 RID: 10149 RVA: 0x0007336C File Offset: 0x0007156C
		private static bool ProcessDistinctOpOfKeys(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = context.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(n.Child0);
			global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp distinctOp = (global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp)n.Op;
			if (!extendedNodeInfo.Keys.NoKeys && distinctOp.Keys.Subsumes(extendedNodeInfo.Keys.KeyVars))
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op = command.CreateProjectOp(distinctOp.Keys);
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp op2 = command.CreateVarDefListOp();
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg = command.CreateNode(op2);
				newNode = command.CreateNode(op, n.Child0, arg);
				return true;
			}
			newNode = n;
			return false;
		}

		// Token: 0x04000DCA RID: 3530
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule Rule_DistinctOpOfKeys = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Distinct, new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.DistinctOpRules.ProcessDistinctOpOfKeys));

		// Token: 0x04000DCB RID: 3531
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.Rule[] Rules = new global::System.Data.Entity.Core.Query.InternalTrees.Rule[]
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.DistinctOpRules.Rule_DistinctOpOfKeys
		};
	}
}
