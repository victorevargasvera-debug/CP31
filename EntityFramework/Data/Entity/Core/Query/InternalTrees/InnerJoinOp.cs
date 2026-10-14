using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003AE RID: 942
	internal sealed class InnerJoinOp : global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp
	{
		// Token: 0x06002D87 RID: 11655 RVA: 0x0009106F File Offset: 0x0008F26F
		private InnerJoinOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.InnerJoin)
		{
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00091079 File Offset: 0x0008F279
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00091083 File Offset: 0x0008F283
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F3C RID: 3900
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp Instance = new global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp();

		// Token: 0x04000F3D RID: 3901
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp Pattern = global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp.Instance;
	}
}
