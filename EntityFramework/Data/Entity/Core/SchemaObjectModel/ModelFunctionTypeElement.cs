using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002FC RID: 764
	internal abstract class ModelFunctionTypeElement : global::System.Data.Entity.Core.SchemaObjectModel.FacetEnabledSchemaElement
	{
		// Token: 0x06002455 RID: 9301 RVA: 0x00065DEC File Offset: 0x00063FEC
		internal ModelFunctionTypeElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement) : base(parentElement)
		{
			this._typeUsageBuilder = new global::System.Data.Entity.Core.SchemaObjectModel.TypeUsageBuilder(this);
		}

		// Token: 0x06002456 RID: 9302
		internal abstract void WriteIdentity(global::System.Text.StringBuilder builder);

		// Token: 0x06002457 RID: 9303
		internal abstract global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetTypeUsage();

		// Token: 0x06002458 RID: 9304
		internal abstract bool ResolveNameAndSetTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems);

		// Token: 0x04000CEC RID: 3308
		protected global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _typeUsage;
	}
}
