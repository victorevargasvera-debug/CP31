using System;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000398 RID: 920
	internal sealed class CrossJoinOp : global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp
	{
		// Token: 0x06002CDD RID: 11485 RVA: 0x0008F322 File Offset: 0x0008D522
		private CrossJoinOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossJoin)
		{
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06002CDE RID: 11486 RVA: 0x0008F32C File Offset: 0x0008D52C
		internal override int Arity
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x0008F32F File Offset: 0x0008D52F
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x0008F339 File Offset: 0x0008D539
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F13 RID: 3859
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp Instance = new global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp();

		// Token: 0x04000F14 RID: 3860
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp Pattern = global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp.Instance;
	}
}
