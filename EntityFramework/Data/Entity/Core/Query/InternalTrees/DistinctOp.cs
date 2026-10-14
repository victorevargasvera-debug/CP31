using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200039D RID: 925
	internal sealed class DistinctOp : global::System.Data.Entity.Core.Query.InternalTrees.RelOp
	{
		// Token: 0x06002CF8 RID: 11512 RVA: 0x0008F4F1 File Offset: 0x0008D6F1
		private DistinctOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Distinct)
		{
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x0008F4FB File Offset: 0x0008D6FB
		internal DistinctOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec keyVars) : this()
		{
			this.m_keys = keyVars;
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x0008F50A File Offset: 0x0008D70A
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x0008F50D File Offset: 0x0008D70D
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec Keys
		{
			get
			{
				return this.m_keys;
			}
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x0008F515 File Offset: 0x0008D715
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x0008F51F File Offset: 0x0008D71F
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F1C RID: 3868
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_keys;

		// Token: 0x04000F1D RID: 3869
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp();
	}
}
