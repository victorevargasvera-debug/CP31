using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003BE RID: 958
	internal sealed class NewMultisetOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002DDD RID: 11741 RVA: 0x000915DE File Offset: 0x0008F7DE
		internal NewMultisetOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewMultiset, type)
		{
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x000915E9 File Offset: 0x0008F7E9
		private NewMultisetOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewMultiset)
		{
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x000915F3 File Offset: 0x0008F7F3
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x000915FD File Offset: 0x0008F7FD
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F57 RID: 3927
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.NewMultisetOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.NewMultisetOp();
	}
}
