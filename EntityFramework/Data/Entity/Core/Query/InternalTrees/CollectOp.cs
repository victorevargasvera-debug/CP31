using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000386 RID: 902
	internal sealed class CollectOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002BCF RID: 11215 RVA: 0x0008D099 File Offset: 0x0008B299
		internal CollectOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Collect, type)
		{
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x0008D0A4 File Offset: 0x0008B2A4
		private CollectOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Collect)
		{
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x0008D0AE File Offset: 0x0008B2AE
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x0008D0B1 File Offset: 0x0008B2B1
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x0008D0BB File Offset: 0x0008B2BB
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000EE8 RID: 3816
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.CollectOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.CollectOp();
	}
}
