using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000399 RID: 921
	internal sealed class DerefOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002CE2 RID: 11490 RVA: 0x0008F359 File Offset: 0x0008D559
		internal DerefOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Deref, type)
		{
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x0008F364 File Offset: 0x0008D564
		private DerefOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Deref)
		{
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x0008F36E File Offset: 0x0008D56E
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x0008F371 File Offset: 0x0008D571
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x0008F37B File Offset: 0x0008D57B
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F15 RID: 3861
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.DerefOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.DerefOp();
	}
}
