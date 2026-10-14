using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000394 RID: 916
	internal sealed class ConstantOp : global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp
	{
		// Token: 0x06002CC4 RID: 11460 RVA: 0x0008F211 File Offset: 0x0008D411
		internal ConstantOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, object value) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Constant, type, value)
		{
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x0008F21C File Offset: 0x0008D41C
		private ConstantOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Constant)
		{
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x0008F225 File Offset: 0x0008D425
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x0008F22F File Offset: 0x0008D42F
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F0D RID: 3853
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ConstantOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.ConstantOp();
	}
}
