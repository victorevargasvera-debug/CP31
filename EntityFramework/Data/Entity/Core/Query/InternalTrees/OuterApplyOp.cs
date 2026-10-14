using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003CA RID: 970
	internal sealed class OuterApplyOp : global::System.Data.Entity.Core.Query.InternalTrees.ApplyBaseOp
	{
		// Token: 0x06002E8C RID: 11916 RVA: 0x00093BFA File Offset: 0x00091DFA
		private OuterApplyOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.OuterApply)
		{
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00093C04 File Offset: 0x00091E04
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00093C0E File Offset: 0x00091E0E
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FB4 RID: 4020
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp Instance = new global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp();

		// Token: 0x04000FB5 RID: 4021
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp Pattern = global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp.Instance;
	}
}
