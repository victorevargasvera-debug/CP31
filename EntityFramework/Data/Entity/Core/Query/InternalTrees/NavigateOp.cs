using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003B9 RID: 953
	internal sealed class NavigateOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002DC0 RID: 11712 RVA: 0x00091489 File Offset: 0x0008F689
		internal NavigateOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Navigate, type)
		{
			this.m_property = relProperty;
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x0009149B File Offset: 0x0008F69B
		private NavigateOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Navigate)
		{
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06002DC2 RID: 11714 RVA: 0x000914A5 File Offset: 0x0008F6A5
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x000914A8 File Offset: 0x0008F6A8
		internal global::System.Data.Entity.Core.Query.InternalTrees.RelProperty RelProperty
		{
			get
			{
				return this.m_property;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x000914B0 File Offset: 0x0008F6B0
		internal global::System.Data.Entity.Core.Metadata.Edm.RelationshipType Relationship
		{
			get
			{
				return this.m_property.Relationship;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000914BD File Offset: 0x0008F6BD
		internal global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember FromEnd
		{
			get
			{
				return this.m_property.FromEnd;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06002DC6 RID: 11718 RVA: 0x000914CA File Offset: 0x0008F6CA
		internal global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember ToEnd
		{
			get
			{
				return this.m_property.ToEnd;
			}
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x000914D7 File Offset: 0x0008F6D7
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x000914E1 File Offset: 0x0008F6E1
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F4D RID: 3917
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.RelProperty m_property;

		// Token: 0x04000F4E RID: 3918
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.NavigateOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.NavigateOp();
	}
}
