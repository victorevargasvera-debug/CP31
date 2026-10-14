using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003A7 RID: 935
	internal sealed class FullOuterJoinOp : global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp
	{
		// Token: 0x06002D5D RID: 11613 RVA: 0x00090E8B File Offset: 0x0008F08B
		private FullOuterJoinOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.FullOuterJoin)
		{
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00090E95 File Offset: 0x0008F095
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x00090E9F File Offset: 0x0008F09F
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F31 RID: 3889
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.FullOuterJoinOp Instance = new global::System.Data.Entity.Core.Query.InternalTrees.FullOuterJoinOp();

		// Token: 0x04000F32 RID: 3890
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.FullOuterJoinOp Pattern = global::System.Data.Entity.Core.Query.InternalTrees.FullOuterJoinOp.Instance;
	}
}
