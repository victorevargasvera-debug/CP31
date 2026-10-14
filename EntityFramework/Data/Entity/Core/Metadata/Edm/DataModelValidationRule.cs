using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000499 RID: 1177
	internal abstract class DataModelValidationRule
	{
		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06003A2D RID: 14893
		internal abstract global::System.Type ValidatedType { get; }

		// Token: 0x06003A2E RID: 14894
		internal abstract void Evaluate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item);
	}
}
