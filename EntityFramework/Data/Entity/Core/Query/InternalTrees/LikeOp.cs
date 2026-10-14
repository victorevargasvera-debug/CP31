using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003B6 RID: 950
	internal sealed class LikeOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002DB0 RID: 11696 RVA: 0x0009131C File Offset: 0x0008F51C
		internal LikeOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage boolType) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Like, boolType)
		{
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00091327 File Offset: 0x0008F527
		private LikeOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Like)
		{
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x00091331 File Offset: 0x0008F531
		internal override int Arity
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00091334 File Offset: 0x0008F534
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x0009133E File Offset: 0x0008F53E
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F49 RID: 3913
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.LikeOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.LikeOp();
	}
}
