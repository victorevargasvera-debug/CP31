using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003F6 RID: 1014
	internal sealed class UnionAllOp : global::System.Data.Entity.Core.Query.InternalTrees.SetOp
	{
		// Token: 0x06002F59 RID: 12121 RVA: 0x00094D15 File Offset: 0x00092F15
		private UnionAllOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll)
		{
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x00094D1F File Offset: 0x00092F1F
		internal UnionAllOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputs, global::System.Data.Entity.Core.Query.InternalTrees.VarMap left, global::System.Data.Entity.Core.Query.InternalTrees.VarMap right, global::System.Data.Entity.Core.Query.InternalTrees.Var branchDiscriminator) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll, outputs, left, right)
		{
			this.m_branchDiscriminator = branchDiscriminator;
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x00094D34 File Offset: 0x00092F34
		internal global::System.Data.Entity.Core.Query.InternalTrees.Var BranchDiscriminator
		{
			get
			{
				return this.m_branchDiscriminator;
			}
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x00094D3C File Offset: 0x00092F3C
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x00094D46 File Offset: 0x00092F46
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FFB RID: 4091
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Var m_branchDiscriminator;

		// Token: 0x04000FFC RID: 4092
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp();
	}
}
