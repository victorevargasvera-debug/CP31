using System;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000375 RID: 885
	internal static class TypeUtils
	{
		// Token: 0x06002ADC RID: 10972 RVA: 0x0008BE50 File Offset: 0x0008A050
		internal static bool IsStructuredType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRelationshipType(type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(type);
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x0008BE7A File Offset: 0x0008A07A
		internal static bool IsCollectionType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(type);
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x0008BE82 File Offset: 0x0008A082
		internal static bool IsEnumerationType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(type);
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x0008BE8A File Offset: 0x0008A08A
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateCollectionType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType)
		{
			return global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionTypeUsage(elementType);
		}
	}
}
