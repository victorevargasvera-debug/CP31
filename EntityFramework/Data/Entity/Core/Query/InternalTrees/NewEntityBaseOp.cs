using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003BB RID: 955
	internal abstract class NewEntityBaseOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002DCE RID: 11726 RVA: 0x0009152E File Offset: 0x0008F72E
		internal NewEntityBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, bool scoped, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> relProperties) : base(opType, type)
		{
			this.m_scoped = scoped;
			this.m_entitySet = entitySet;
			this.m_relProperties = relProperties;
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x0009154F File Offset: 0x0008F74F
		protected NewEntityBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x00091558 File Offset: 0x0008F758
		internal bool Scoped
		{
			get
			{
				return this.m_scoped;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x00091560 File Offset: 0x0008F760
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet
		{
			get
			{
				return this.m_entitySet;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06002DD2 RID: 11730 RVA: 0x00091568 File Offset: 0x0008F768
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> RelationshipProperties
		{
			get
			{
				return this.m_relProperties;
			}
		}

		// Token: 0x04000F52 RID: 3922
		private readonly bool m_scoped;

		// Token: 0x04000F53 RID: 3923
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet m_entitySet;

		// Token: 0x04000F54 RID: 3924
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> m_relProperties;
	}
}
