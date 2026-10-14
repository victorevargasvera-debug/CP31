using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003AC RID: 940
	internal sealed class GroupByIntoOp : global::System.Data.Entity.Core.Query.InternalTrees.GroupByBaseOp
	{
		// Token: 0x06002D7A RID: 11642 RVA: 0x00090FEE File Offset: 0x0008F1EE
		private GroupByIntoOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupByInto)
		{
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00090FF8 File Offset: 0x0008F1F8
		internal GroupByIntoOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys, global::System.Data.Entity.Core.Query.InternalTrees.VarVec inputs, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputs) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupByInto, keys, outputs)
		{
			this.m_inputs = inputs;
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x0009100B File Offset: 0x0008F20B
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec Inputs
		{
			get
			{
				return this.m_inputs;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x00091013 File Offset: 0x0008F213
		internal override int Arity
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x00091016 File Offset: 0x0008F216
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x00091020 File Offset: 0x0008F220
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F39 RID: 3897
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_inputs;

		// Token: 0x04000F3A RID: 3898
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp();
	}
}
