using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200039C RID: 924
	internal sealed class DiscriminatedNewEntityOp : global::System.Data.Entity.Core.Query.InternalTrees.NewEntityBaseOp
	{
		// Token: 0x06002CF2 RID: 11506 RVA: 0x0008F4A9 File Offset: 0x0008D6A9
		internal DiscriminatedNewEntityOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap discriminatorMap, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> relProperties) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.DiscriminatedNewEntity, type, true, entitySet, relProperties)
		{
			this.m_discriminatorMap = discriminatorMap;
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x0008F4BF File Offset: 0x0008D6BF
		private DiscriminatedNewEntityOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.DiscriminatedNewEntity)
		{
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x0008F4C9 File Offset: 0x0008D6C9
		internal global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap DiscriminatorMap
		{
			get
			{
				return this.m_discriminatorMap;
			}
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x0008F4D1 File Offset: 0x0008D6D1
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x0008F4DB File Offset: 0x0008D6DB
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F1A RID: 3866
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap m_discriminatorMap;

		// Token: 0x04000F1B RID: 3867
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp();
	}
}
