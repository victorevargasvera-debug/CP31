using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005C2 RID: 1474
	internal class ChangeNode
	{
		// Token: 0x06004772 RID: 18290 RVA: 0x000FB8B0 File Offset: 0x000F9AB0
		internal ChangeNode(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType)
		{
			this.m_elementType = elementType;
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06004773 RID: 18291 RVA: 0x000FB8D5 File Offset: 0x000F9AD5
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ElementType
		{
			get
			{
				return this.m_elementType;
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06004774 RID: 18292 RVA: 0x000FB8DD File Offset: 0x000F9ADD
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> Inserted
		{
			get
			{
				return this.m_inserted;
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06004775 RID: 18293 RVA: 0x000FB8E5 File Offset: 0x000F9AE5
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> Deleted
		{
			get
			{
				return this.m_deleted;
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x000FB8ED File Offset: 0x000F9AED
		// (set) Token: 0x06004777 RID: 18295 RVA: 0x000FB8F5 File Offset: 0x000F9AF5
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Placeholder { get; set; }

		// Token: 0x04001959 RID: 6489
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage m_elementType;

		// Token: 0x0400195A RID: 6490
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> m_inserted = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>();

		// Token: 0x0400195B RID: 6491
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> m_deleted = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>();
	}
}
