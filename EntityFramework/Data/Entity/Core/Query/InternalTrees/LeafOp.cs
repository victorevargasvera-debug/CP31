using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003B4 RID: 948
	internal sealed class LeafOp : global::System.Data.Entity.Core.Query.InternalTrees.RulePatternOp
	{
		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06002DA9 RID: 11689 RVA: 0x000912C5 File Offset: 0x0008F4C5
		internal override int Arity
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x000912C8 File Offset: 0x0008F4C8
		private LeafOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Leaf)
		{
		}

		// Token: 0x04000F45 RID: 3909
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.LeafOp Instance = new global::System.Data.Entity.Core.Query.InternalTrees.LeafOp();

		// Token: 0x04000F46 RID: 3910
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.LeafOp Pattern = global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Instance;
	}
}
