using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000397 RID: 919
	internal sealed class CrossApplyOp : global::System.Data.Entity.Core.Query.InternalTrees.ApplyBaseOp
	{
		// Token: 0x06002CD9 RID: 11481 RVA: 0x0008F2EE File Offset: 0x0008D4EE
		private CrossApplyOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossApply)
		{
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x0008F2F8 File Offset: 0x0008D4F8
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x0008F302 File Offset: 0x0008D502
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F11 RID: 3857
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp Instance = new global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp();

		// Token: 0x04000F12 RID: 3858
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp Pattern = global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp.Instance;
	}
}
