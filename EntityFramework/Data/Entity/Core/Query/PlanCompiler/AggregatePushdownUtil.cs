using System;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200032D RID: 813
	internal static class AggregatePushdownUtil
	{
		// Token: 0x060026E7 RID: 9959 RVA: 0x0006F421 File Offset: 0x0006D621
		internal static bool IsVarRefOverGivenVar(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Query.InternalTrees.Var var)
		{
			return node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef && ((global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)node.Op).Var == var;
		}
	}
}
