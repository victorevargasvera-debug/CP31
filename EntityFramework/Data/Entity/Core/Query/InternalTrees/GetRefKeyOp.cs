using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003AA RID: 938
	internal sealed class GetRefKeyOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002D6E RID: 11630 RVA: 0x00090F72 File Offset: 0x0008F172
		internal GetRefKeyOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.GetRefKey, type)
		{
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00090F7D File Offset: 0x0008F17D
		private GetRefKeyOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.GetRefKey)
		{
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x00090F87 File Offset: 0x0008F187
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00090F8A File Offset: 0x0008F18A
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00090F94 File Offset: 0x0008F194
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F36 RID: 3894
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.GetRefKeyOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.GetRefKeyOp();
	}
}
