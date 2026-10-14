using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003FA RID: 1018
	internal sealed class VarDefOp : global::System.Data.Entity.Core.Query.InternalTrees.AncillaryOp
	{
		// Token: 0x06002F71 RID: 12145 RVA: 0x00094E43 File Offset: 0x00093043
		internal VarDefOp(global::System.Data.Entity.Core.Query.InternalTrees.Var v) : this()
		{
			this.m_var = v;
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00094E52 File Offset: 0x00093052
		private VarDefOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarDef)
		{
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x00094E5C File Offset: 0x0009305C
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x00094E5F File Offset: 0x0009305F
		internal global::System.Data.Entity.Core.Query.InternalTrees.Var Var
		{
			get
			{
				return this.m_var;
			}
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x00094E67 File Offset: 0x00093067
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00094E71 File Offset: 0x00093071
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04001005 RID: 4101
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Var m_var;

		// Token: 0x04001006 RID: 4102
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp();
	}
}
