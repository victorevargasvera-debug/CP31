using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003F9 RID: 1017
	internal sealed class VarDefListOp : global::System.Data.Entity.Core.Query.InternalTrees.AncillaryOp
	{
		// Token: 0x06002F6D RID: 12141 RVA: 0x00094E0F File Offset: 0x0009300F
		private VarDefListOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarDefList)
		{
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00094E19 File Offset: 0x00093019
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x00094E23 File Offset: 0x00093023
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04001003 RID: 4099
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp Instance = new global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp();

		// Token: 0x04001004 RID: 4100
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp Pattern = global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp.Instance;
	}
}
