using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200039F RID: 927
	internal sealed class ElementOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002D2C RID: 11564 RVA: 0x00090AE0 File Offset: 0x0008ECE0
		internal ElementOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Element, type)
		{
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00090AEB File Offset: 0x0008ECEB
		private ElementOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Element)
		{
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002D2E RID: 11566 RVA: 0x00090AF5 File Offset: 0x0008ECF5
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00090AF8 File Offset: 0x0008ECF8
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x00090B02 File Offset: 0x0008ED02
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F20 RID: 3872
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ElementOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.ElementOp();
	}
}
