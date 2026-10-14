using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003EA RID: 1002
	internal sealed class SingleRowTableOp : global::System.Data.Entity.Core.Query.InternalTrees.RelOp
	{
		// Token: 0x06002F1A RID: 12058 RVA: 0x0009476E File Offset: 0x0009296E
		private SingleRowTableOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleRowTable)
		{
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x00094778 File Offset: 0x00092978
		internal override int Arity
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x0009477B File Offset: 0x0009297B
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x00094785 File Offset: 0x00092985
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FDF RID: 4063
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp Instance = new global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp();

		// Token: 0x04000FE0 RID: 4064
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp Pattern = global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp.Instance;
	}
}
