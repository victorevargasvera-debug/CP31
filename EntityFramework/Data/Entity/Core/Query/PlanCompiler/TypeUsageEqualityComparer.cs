using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000374 RID: 884
	internal sealed class TypeUsageEqualityComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>
	{
		// Token: 0x06002AD7 RID: 10967 RVA: 0x0008BDFC File Offset: 0x00089FFC
		private TypeUsageEqualityComparer()
		{
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x0008BE04 File Offset: 0x0008A004
		public bool Equals(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage x, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage y)
		{
			return x != null && y != null && global::System.Data.Entity.Core.Query.PlanCompiler.TypeUsageEqualityComparer.Equals(x.EdmType, y.EdmType);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x0008BE1F File Offset: 0x0008A01F
		public int GetHashCode(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage obj)
		{
			return obj.EdmType.Identity.GetHashCode();
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x0008BE31 File Offset: 0x0008A031
		internal static bool Equals(global::System.Data.Entity.Core.Metadata.Edm.EdmType x, global::System.Data.Entity.Core.Metadata.Edm.EdmType y)
		{
			return x.Identity.Equals(y.Identity);
		}

		// Token: 0x04000ECF RID: 3791
		internal static readonly global::System.Data.Entity.Core.Query.PlanCompiler.TypeUsageEqualityComparer Instance = new global::System.Data.Entity.Core.Query.PlanCompiler.TypeUsageEqualityComparer();
	}
}
