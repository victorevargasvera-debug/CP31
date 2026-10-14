using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000382 RID: 898
	internal sealed class CaseOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002BB9 RID: 11193 RVA: 0x0008CF7A File Offset: 0x0008B17A
		internal CaseOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Case, type)
		{
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x0008CF85 File Offset: 0x0008B185
		private CaseOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Case)
		{
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x0008CF8F File Offset: 0x0008B18F
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x0008CF99 File Offset: 0x0008B199
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000EDD RID: 3805
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.CaseOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.CaseOp();
	}
}
