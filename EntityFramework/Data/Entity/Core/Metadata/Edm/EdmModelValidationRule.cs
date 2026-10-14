using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004AF RID: 1199
	internal class EdmModelValidationRule<TItem> : global::System.Data.Entity.Core.Metadata.Edm.DataModelValidationRule<TItem> where TItem : class
	{
		// Token: 0x06003B02 RID: 15106 RVA: 0x000C2226 File Offset: 0x000C0426
		internal EdmModelValidationRule(global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext, TItem> validate) : base(validate)
		{
		}
	}
}
