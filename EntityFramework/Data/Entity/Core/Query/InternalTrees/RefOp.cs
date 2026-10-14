using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003D3 RID: 979
	internal sealed class RefOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002EB6 RID: 11958 RVA: 0x00093E83 File Offset: 0x00092083
		internal RefOp(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Ref, type)
		{
			this.m_entitySet = entitySet;
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x00093E95 File Offset: 0x00092095
		private RefOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Ref)
		{
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002EB8 RID: 11960 RVA: 0x00093E9F File Offset: 0x0009209F
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06002EB9 RID: 11961 RVA: 0x00093EA2 File Offset: 0x000920A2
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet
		{
			get
			{
				return this.m_entitySet;
			}
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x00093EAA File Offset: 0x000920AA
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x00093EB4 File Offset: 0x000920B4
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FC1 RID: 4033
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet m_entitySet;

		// Token: 0x04000FC2 RID: 4034
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.RefOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.RefOp();
	}
}
