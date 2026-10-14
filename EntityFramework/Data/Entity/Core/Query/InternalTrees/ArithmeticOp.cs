using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200037E RID: 894
	internal sealed class ArithmeticOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002B15 RID: 11029 RVA: 0x0008C793 File Offset: 0x0008A993
		internal ArithmeticOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(opType, type)
		{
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x0008C79D File Offset: 0x0008A99D
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x0008C7A7 File Offset: 0x0008A9A7
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}
	}
}
