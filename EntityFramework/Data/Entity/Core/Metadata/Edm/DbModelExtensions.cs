using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200049F RID: 1183
	[global::System.Obsolete("ConceptualModel and StoreModel are now available as properties directly on DbModel.")]
	public static class DbModelExtensions
	{
		// Token: 0x06003A44 RID: 14916 RVA: 0x000BFBF6 File Offset: 0x000BDDF6
		[global::System.Obsolete("ConceptualModel is now available as a property directly on DbModel.")]
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmModel GetConceptualModel(this global::System.Data.Entity.Core.Metadata.Edm.IEdmModelAdapter model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.IEdmModelAdapter>(model, "model");
			return model.ConceptualModel;
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x000BFC0A File Offset: 0x000BDE0A
		[global::System.Obsolete("StoreModel is now available as a property directly on DbModel.")]
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmModel GetStoreModel(this global::System.Data.Entity.Core.Metadata.Edm.IEdmModelAdapter model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.IEdmModelAdapter>(model, "model");
			return model.StoreModel;
		}
	}
}
