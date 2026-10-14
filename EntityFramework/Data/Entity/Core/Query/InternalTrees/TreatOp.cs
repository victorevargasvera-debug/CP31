using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003F4 RID: 1012
	internal sealed class TreatOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002F51 RID: 12113 RVA: 0x00094CC3 File Offset: 0x00092EC3
		internal TreatOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, bool isFake) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Treat, type)
		{
			this.m_isFake = isFake;
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x00094CD5 File Offset: 0x00092ED5
		private TreatOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Treat)
		{
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06002F53 RID: 12115 RVA: 0x00094CDF File Offset: 0x00092EDF
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x00094CE2 File Offset: 0x00092EE2
		internal bool IsFakeTreat
		{
			get
			{
				return this.m_isFake;
			}
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x00094CEA File Offset: 0x00092EEA
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x00094CF4 File Offset: 0x00092EF4
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FF9 RID: 4089
		private readonly bool m_isFake;

		// Token: 0x04000FFA RID: 4090
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.TreatOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.TreatOp();
	}
}
