using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003A9 RID: 937
	internal sealed class GetEntityRefOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002D68 RID: 11624 RVA: 0x00090F3A File Offset: 0x0008F13A
		internal GetEntityRefOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.GetEntityRef, type)
		{
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00090F45 File Offset: 0x0008F145
		private GetEntityRefOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.GetEntityRef)
		{
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x00090F4F File Offset: 0x0008F14F
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00090F52 File Offset: 0x0008F152
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00090F5C File Offset: 0x0008F15C
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F35 RID: 3893
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.GetEntityRefOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.GetEntityRefOp();
	}
}
