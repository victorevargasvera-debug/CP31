using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003B1 RID: 945
	internal sealed class IsOfOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002D95 RID: 11669 RVA: 0x0009110E File Offset: 0x0008F30E
		internal IsOfOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage isOfType, bool isOfOnly, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsOf, type)
		{
			this.m_isOfType = isOfType;
			this.m_isOfOnly = isOfOnly;
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x00091127 File Offset: 0x0008F327
		private IsOfOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsOf)
		{
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002D97 RID: 11671 RVA: 0x00091131 File Offset: 0x0008F331
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x00091134 File Offset: 0x0008F334
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage IsOfType
		{
			get
			{
				return this.m_isOfType;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x0009113C File Offset: 0x0008F33C
		internal bool IsOfOnly
		{
			get
			{
				return this.m_isOfOnly;
			}
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x00091144 File Offset: 0x0008F344
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x0009114E File Offset: 0x0008F34E
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F40 RID: 3904
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage m_isOfType;

		// Token: 0x04000F41 RID: 3905
		private readonly bool m_isOfOnly;

		// Token: 0x04000F42 RID: 3906
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp();
	}
}
