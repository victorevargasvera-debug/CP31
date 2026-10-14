using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200049B RID: 1179
	internal abstract class DataModelValidationRule<TItem> : global::System.Data.Entity.Core.Metadata.Edm.DataModelValidationRule where TItem : class
	{
		// Token: 0x06003A34 RID: 14900 RVA: 0x000BFAB0 File Offset: 0x000BDCB0
		internal DataModelValidationRule(global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext, TItem> validate)
		{
			this._validate = validate;
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06003A35 RID: 14901 RVA: 0x000BFABF File Offset: 0x000BDCBF
		internal override global::System.Type ValidatedType
		{
			get
			{
				return typeof(TItem);
			}
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x000BFACB File Offset: 0x000BDCCB
		internal override void Evaluate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			this._validate(context, item as TItem);
		}

		// Token: 0x04001369 RID: 4969
		protected global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext, TItem> _validate;
	}
}
