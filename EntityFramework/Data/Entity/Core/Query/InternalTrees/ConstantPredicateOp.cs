using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000395 RID: 917
	internal sealed class ConstantPredicateOp : global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp
	{
		// Token: 0x06002CC9 RID: 11465 RVA: 0x0008F245 File Offset: 0x0008D445
		internal ConstantPredicateOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, bool value) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstantPredicate, type, value)
		{
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x0008F255 File Offset: 0x0008D455
		private ConstantPredicateOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstantPredicate)
		{
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x0008F25E File Offset: 0x0008D45E
		internal new bool Value
		{
			get
			{
				return (bool)base.Value;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x0008F26B File Offset: 0x0008D46B
		internal bool IsTrue
		{
			get
			{
				return this.Value;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002CCD RID: 11469 RVA: 0x0008F273 File Offset: 0x0008D473
		internal bool IsFalse
		{
			get
			{
				return !this.Value;
			}
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x0008F27E File Offset: 0x0008D47E
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x0008F288 File Offset: 0x0008D488
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F0E RID: 3854
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp();
	}
}
