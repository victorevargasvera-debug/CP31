using System;
using System.Data.Entity.Core.Mapping;

namespace System.Data.Entity.Infrastructure.MappingViews
{
	// Token: 0x02000270 RID: 624
	public abstract class DbMappingViewCacheFactory
	{
		// Token: 0x06001F80 RID: 8064
		public abstract global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCache Create(string conceptualModelContainerName, string storeModelContainerName);

		// Token: 0x06001F81 RID: 8065 RVA: 0x00058EED File Offset: 0x000570ED
		internal global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCache Create(global::System.Data.Entity.Core.Mapping.EntityContainerMapping mapping)
		{
			return this.Create(mapping.EdmEntityContainer.Name, mapping.StorageEntityContainer.Name);
		}
	}
}
