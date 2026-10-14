using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000392 RID: 914
	internal sealed class ConditionalOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002CBA RID: 11450 RVA: 0x0008F12A File Offset: 0x0008D32A
		internal ConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType optype, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(optype, type)
		{
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x0008F134 File Offset: 0x0008D334
		private ConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x0008F13D File Offset: 0x0008D33D
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x0008F147 File Offset: 0x0008D347
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F07 RID: 3847
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp PatternAnd = new global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And);

		// Token: 0x04000F08 RID: 3848
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp PatternOr = new global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Or);

		// Token: 0x04000F09 RID: 3849
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp PatternIn = new global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.In);

		// Token: 0x04000F0A RID: 3850
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp PatternNot = new global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not);

		// Token: 0x04000F0B RID: 3851
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp PatternIsNull = new global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull);
	}
}
