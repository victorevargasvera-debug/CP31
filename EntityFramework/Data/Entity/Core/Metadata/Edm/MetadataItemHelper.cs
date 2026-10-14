using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004DB RID: 1243
	internal static class MetadataItemHelper
	{
		// Token: 0x06003DE9 RID: 15849 RVA: 0x000CC930 File Offset: 0x000CAB30
		public static bool IsInvalid(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem instance)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty;
			return instance.MetadataProperties.TryGetValue("EdmSchemaInvalid", false, out metadataProperty) && metadataProperty != null && (bool)metadataProperty.Value;
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x000CC962 File Offset: 0x000CAB62
		public static bool HasSchemaErrors(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem instance)
		{
			return instance.MetadataProperties.Contains("EdmSchemaErrors");
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x000CC974 File Offset: 0x000CAB74
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> GetSchemaErrors(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem instance)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty;
			if (!instance.MetadataProperties.TryGetValue("EdmSchemaErrors", false, out metadataProperty) || metadataProperty == null)
			{
				return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>();
			}
			return (global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>)metadataProperty.Value;
		}

		// Token: 0x04001512 RID: 5394
		internal const string SchemaErrorsMetadataPropertyName = "EdmSchemaErrors";

		// Token: 0x04001513 RID: 5395
		internal const string SchemaInvalidMetadataPropertyName = "EdmSchemaInvalid";
	}
}
