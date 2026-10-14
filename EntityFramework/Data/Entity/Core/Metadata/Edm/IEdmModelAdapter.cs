using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004CB RID: 1227
	[global::System.Obsolete("ConceptualModel and StoreModel are now available as properties directly on DbModel.")]
	public interface IEdmModelAdapter
	{
		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06003CED RID: 15597
		[global::System.Obsolete("ConceptualModel is now available as a property directly on DbModel.")]
		global::System.Data.Entity.Core.Metadata.Edm.EdmModel ConceptualModel { get; }

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06003CEE RID: 15598
		[global::System.Obsolete("StoreModel is now available as a property directly on DbModel.")]
		global::System.Data.Entity.Core.Metadata.Edm.EdmModel StoreModel { get; }
	}
}
