using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003C5 RID: 965
	internal sealed class NullSentinelOp : global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp
	{
		// Token: 0x06002E27 RID: 11815 RVA: 0x00092D64 File Offset: 0x00090F64
		internal NullSentinelOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, object value) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel, type, value)
		{
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00092D6F File Offset: 0x00090F6F
		private NullSentinelOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel)
		{
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00092D78 File Offset: 0x00090F78
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x00092D82 File Offset: 0x00090F82
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F62 RID: 3938
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.NullSentinelOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.NullSentinelOp();
	}
}
