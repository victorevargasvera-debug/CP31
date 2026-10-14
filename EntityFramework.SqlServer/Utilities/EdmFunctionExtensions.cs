using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x0200001C RID: 28
	internal static class EdmFunctionExtensions
	{
		// Token: 0x06000370 RID: 880 RVA: 0x0000EA4C File Offset: 0x0000CC4C
		internal static bool IsCSpace(this global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty = function.MetadataProperties.FirstOrDefault((global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty p) => p.Name == "DataSpace");
			return metadataProperty != null && (global::System.Data.Entity.Core.Metadata.Edm.DataSpace)metadataProperty.Value == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000EA97 File Offset: 0x0000CC97
		internal static bool IsCanonicalFunction(this global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			return function.IsCSpace() && function.NamespaceName == "Edm";
		}
	}
}
