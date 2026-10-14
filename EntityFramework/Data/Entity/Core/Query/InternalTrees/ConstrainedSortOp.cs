using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000396 RID: 918
	internal sealed class ConstrainedSortOp : global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp
	{
		// Token: 0x06002CD1 RID: 11473 RVA: 0x0008F29E File Offset: 0x0008D49E
		private ConstrainedSortOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstrainedSort)
		{
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x0008F2A8 File Offset: 0x0008D4A8
		internal ConstrainedSortOp(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys, bool withTies) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstrainedSort, sortKeys)
		{
			this.WithTies = withTies;
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x0008F2BA File Offset: 0x0008D4BA
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x0008F2C2 File Offset: 0x0008D4C2
		internal bool WithTies { get; set; }

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x0008F2CB File Offset: 0x0008D4CB
		internal override int Arity
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x0008F2CE File Offset: 0x0008D4CE
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x0008F2D8 File Offset: 0x0008D4D8
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F10 RID: 3856
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp();
	}
}
