using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003B0 RID: 944
	internal sealed class IntersectOp : global::System.Data.Entity.Core.Query.InternalTrees.SetOp
	{
		// Token: 0x06002D90 RID: 11664 RVA: 0x000910D7 File Offset: 0x0008F2D7
		private IntersectOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect)
		{
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x000910E1 File Offset: 0x0008F2E1
		internal IntersectOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputs, global::System.Data.Entity.Core.Query.InternalTrees.VarMap left, global::System.Data.Entity.Core.Query.InternalTrees.VarMap right) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect, outputs, left, right)
		{
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x000910EE File Offset: 0x0008F2EE
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x000910F8 File Offset: 0x0008F2F8
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F3F RID: 3903
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.IntersectOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.IntersectOp();
	}
}
