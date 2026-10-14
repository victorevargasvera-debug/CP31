using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200038F RID: 911
	internal sealed class ComparisonOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002CAC RID: 11436 RVA: 0x0008F087 File Offset: 0x0008D287
		internal ComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(opType, type)
		{
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x0008F091 File Offset: 0x0008D291
		private ComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x0008F09A File Offset: 0x0008D29A
		internal override int Arity
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x0008F09D File Offset: 0x0008D29D
		// (set) Token: 0x06002CB0 RID: 11440 RVA: 0x0008F0A5 File Offset: 0x0008D2A5
		internal bool UseDatabaseNullSemantics { get; set; }

		// Token: 0x06002CB1 RID: 11441 RVA: 0x0008F0AE File Offset: 0x0008D2AE
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x0008F0B8 File Offset: 0x0008D2B8
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F04 RID: 3844
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp PatternEq = new global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ);
	}
}
