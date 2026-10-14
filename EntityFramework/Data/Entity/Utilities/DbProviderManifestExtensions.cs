using System;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000079 RID: 121
	internal static class DbProviderManifestExtensions
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x0000EC00 File Offset: 0x0000CE00
		public static global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType GetStoreTypeFromName(this global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, string name)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = providerManifest.GetStoreTypes().SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType p) => string.Equals(p.Name, name, global::System.StringComparison.OrdinalIgnoreCase));
			if (primitiveType == null)
			{
				throw global::System.Data.Entity.Resources.Error.StoreTypeNotFound(name, providerManifest.NamespaceName);
			}
			return primitiveType;
		}
	}
}
