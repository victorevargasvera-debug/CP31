using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003FE RID: 1022
	internal sealed class VarRefOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002F97 RID: 12183 RVA: 0x0009520F File Offset: 0x0009340F
		internal VarRefOp(global::System.Data.Entity.Core.Query.InternalTrees.Var v) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef, v.Type)
		{
			this.m_var = v;
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x00095225 File Offset: 0x00093425
		private VarRefOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef)
		{
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x0009522E File Offset: 0x0009342E
		internal override int Arity
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x00095234 File Offset: 0x00093434
		internal override bool IsEquivalent(global::System.Data.Entity.Core.Query.InternalTrees.Op other)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = other as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
			return varRefOp != null && varRefOp.Var.Equals(this.Var);
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06002F9B RID: 12187 RVA: 0x0009525E File Offset: 0x0009345E
		internal global::System.Data.Entity.Core.Query.InternalTrees.Var Var
		{
			get
			{
				return this.m_var;
			}
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x00095266 File Offset: 0x00093466
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x00095270 File Offset: 0x00093470
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x0400100A RID: 4106
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Var m_var;

		// Token: 0x0400100B RID: 4107
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp();
	}
}
