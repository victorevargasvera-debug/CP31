using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003AD RID: 941
	internal sealed class GroupByOp : global::System.Data.Entity.Core.Query.InternalTrees.GroupByBaseOp
	{
		// Token: 0x06002D81 RID: 11649 RVA: 0x00091036 File Offset: 0x0008F236
		private GroupByOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupBy)
		{
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00091040 File Offset: 0x0008F240
		internal GroupByOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputs) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupBy, keys, outputs)
		{
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x0009104C File Offset: 0x0008F24C
		internal override int Arity
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x0009104F File Offset: 0x0008F24F
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00091059 File Offset: 0x0008F259
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F3B RID: 3899
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp();
	}
}
