using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000383 RID: 899
	internal sealed class CastOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002BBE RID: 11198 RVA: 0x0008CFAF File Offset: 0x0008B1AF
		internal CastOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Cast, type)
		{
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x0008CFBA File Offset: 0x0008B1BA
		private CastOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Cast)
		{
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x0008CFC4 File Offset: 0x0008B1C4
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x0008CFC7 File Offset: 0x0008B1C7
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x0008CFD1 File Offset: 0x0008B1D1
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000EDE RID: 3806
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.CastOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.CastOp();
	}
}
