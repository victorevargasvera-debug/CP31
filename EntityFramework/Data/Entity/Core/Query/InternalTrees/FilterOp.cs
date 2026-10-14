using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003A6 RID: 934
	internal sealed class FilterOp : global::System.Data.Entity.Core.Query.InternalTrees.RelOp
	{
		// Token: 0x06002D58 RID: 11608 RVA: 0x00090E54 File Offset: 0x0008F054
		private FilterOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Filter)
		{
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x00090E5E File Offset: 0x0008F05E
		internal override int Arity
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x00090E61 File Offset: 0x0008F061
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x00090E6B File Offset: 0x0008F06B
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F2F RID: 3887
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.FilterOp Instance = new global::System.Data.Entity.Core.Query.InternalTrees.FilterOp();

		// Token: 0x04000F30 RID: 3888
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.FilterOp Pattern = global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Instance;
	}
}
