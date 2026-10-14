using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200035F RID: 863
	internal abstract class PropertyRef
	{
		// Token: 0x06002A0D RID: 10765 RVA: 0x0008820A File Offset: 0x0008640A
		internal virtual global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef CreateNestedPropertyRef(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef p)
		{
			return new global::System.Data.Entity.Core.Query.PlanCompiler.NestedPropertyRef(p, this);
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x00088213 File Offset: 0x00086413
		internal global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef CreateNestedPropertyRef(global::System.Data.Entity.Core.Metadata.Edm.EdmMember p)
		{
			return this.CreateNestedPropertyRef(new global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef(p));
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x00088221 File Offset: 0x00086421
		internal global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef CreateNestedPropertyRef(global::System.Data.Entity.Core.Query.InternalTrees.RelProperty p)
		{
			return this.CreateNestedPropertyRef(new global::System.Data.Entity.Core.Query.PlanCompiler.RelPropertyRef(p));
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x0008822F File Offset: 0x0008642F
		public override string ToString()
		{
			return "";
		}
	}
}
