using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003C4 RID: 964
	internal sealed class NullOp : global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp
	{
		// Token: 0x06002E22 RID: 11810 RVA: 0x00092D30 File Offset: 0x00090F30
		internal NullOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null, type, null)
		{
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x00092D3B File Offset: 0x00090F3B
		private NullOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null)
		{
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x00092D44 File Offset: 0x00090F44
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00092D4E File Offset: 0x00090F4E
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F61 RID: 3937
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.NullOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.NullOp();
	}
}
