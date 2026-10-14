using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003A2 RID: 930
	internal sealed class ExceptOp : global::System.Data.Entity.Core.Query.InternalTrees.SetOp
	{
		// Token: 0x06002D39 RID: 11577 RVA: 0x00090B7E File Offset: 0x0008ED7E
		private ExceptOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except)
		{
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x00090B88 File Offset: 0x0008ED88
		internal ExceptOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputs, global::System.Data.Entity.Core.Query.InternalTrees.VarMap left, global::System.Data.Entity.Core.Query.InternalTrees.VarMap right) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except, outputs, left, right)
		{
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x00090B95 File Offset: 0x0008ED95
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00090B9F File Offset: 0x0008ED9F
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F23 RID: 3875
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ExceptOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.ExceptOp();
	}
}
