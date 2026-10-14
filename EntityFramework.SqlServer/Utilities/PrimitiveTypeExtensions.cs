using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x02000020 RID: 32
	internal static class PrimitiveTypeExtensions
	{
		// Token: 0x06000375 RID: 885 RVA: 0x0000EB64 File Offset: 0x0000CD64
		internal static bool IsSpatialType(this global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind = type.PrimitiveTypeKind;
			return primitiveTypeKind >= global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry && primitiveTypeKind <= global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyCollection;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000EB87 File Offset: 0x0000CD87
		internal static bool IsHierarchyIdType(this global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType type)
		{
			return type.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId;
		}
	}
}
