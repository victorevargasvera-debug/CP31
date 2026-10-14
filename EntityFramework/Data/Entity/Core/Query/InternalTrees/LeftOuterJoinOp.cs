using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003B5 RID: 949
	internal sealed class LeftOuterJoinOp : global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp
	{
		// Token: 0x06002DAC RID: 11692 RVA: 0x000912E8 File Offset: 0x0008F4E8
		private LeftOuterJoinOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin)
		{
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x000912F2 File Offset: 0x0008F4F2
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x000912FC File Offset: 0x0008F4FC
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F47 RID: 3911
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp Instance = new global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp();

		// Token: 0x04000F48 RID: 3912
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp Pattern = global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp.Instance;
	}
}
