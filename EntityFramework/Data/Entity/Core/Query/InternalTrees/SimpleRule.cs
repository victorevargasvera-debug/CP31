using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003E8 RID: 1000
	internal sealed class SimpleRule : global::System.Data.Entity.Core.Query.InternalTrees.Rule
	{
		// Token: 0x06002F13 RID: 12051 RVA: 0x00094718 File Offset: 0x00092918
		internal SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate processDelegate) : base(opType, processDelegate)
		{
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x00094722 File Offset: 0x00092922
		internal override bool Match(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			return node.Op.OpType == base.RuleOpType;
		}
	}
}
