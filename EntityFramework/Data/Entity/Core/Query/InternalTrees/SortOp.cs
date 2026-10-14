using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003EF RID: 1007
	internal sealed class SortOp : global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp
	{
		// Token: 0x06002F34 RID: 12084 RVA: 0x00094890 File Offset: 0x00092A90
		private SortOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort)
		{
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x0009489A File Offset: 0x00092A9A
		internal SortOp(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort, sortKeys)
		{
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002F36 RID: 12086 RVA: 0x000948A5 File Offset: 0x00092AA5
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x000948A8 File Offset: 0x00092AA8
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x000948B2 File Offset: 0x00092AB2
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FE9 RID: 4073
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SortOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.SortOp();
	}
}
