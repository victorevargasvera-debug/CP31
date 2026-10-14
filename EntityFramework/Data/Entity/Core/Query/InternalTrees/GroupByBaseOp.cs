using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003AB RID: 939
	internal abstract class GroupByBaseOp : global::System.Data.Entity.Core.Query.InternalTrees.RelOp
	{
		// Token: 0x06002D74 RID: 11636 RVA: 0x00090FAA File Offset: 0x0008F1AA
		protected GroupByBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00090FB3 File Offset: 0x0008F1B3
		internal GroupByBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputs) : this(opType)
		{
			this.m_keys = keys;
			this.m_outputs = outputs;
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06002D76 RID: 11638 RVA: 0x00090FCA File Offset: 0x0008F1CA
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec Keys
		{
			get
			{
				return this.m_keys;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x00090FD2 File Offset: 0x0008F1D2
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec Outputs
		{
			get
			{
				return this.m_outputs;
			}
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x00090FDA File Offset: 0x0008F1DA
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00090FE4 File Offset: 0x0008F1E4
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F37 RID: 3895
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_keys;

		// Token: 0x04000F38 RID: 3896
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_outputs;
	}
}
