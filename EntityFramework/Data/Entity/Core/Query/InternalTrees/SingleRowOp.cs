using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003E9 RID: 1001
	internal sealed class SingleRowOp : global::System.Data.Entity.Core.Query.InternalTrees.RelOp
	{
		// Token: 0x06002F15 RID: 12053 RVA: 0x00094737 File Offset: 0x00092937
		private SingleRowOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleRow)
		{
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x00094741 File Offset: 0x00092941
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00094744 File Offset: 0x00092944
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x0009474E File Offset: 0x0009294E
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FDD RID: 4061
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp Instance = new global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp();

		// Token: 0x04000FDE RID: 4062
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp Pattern = global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp.Instance;
	}
}
