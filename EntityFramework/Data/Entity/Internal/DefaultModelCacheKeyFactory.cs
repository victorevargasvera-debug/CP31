using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000FA RID: 250
	internal sealed class DefaultModelCacheKeyFactory
	{
		// Token: 0x06001256 RID: 4694 RVA: 0x0002F40C File Offset: 0x0002D60C
		public global::System.Data.Entity.Infrastructure.IDbModelCacheKey Create(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			string customKey = null;
			global::System.Data.Entity.Infrastructure.IDbModelCacheKeyProvider dbModelCacheKeyProvider = context as global::System.Data.Entity.Infrastructure.IDbModelCacheKeyProvider;
			if (dbModelCacheKeyProvider != null)
			{
				customKey = dbModelCacheKeyProvider.CacheKey;
			}
			return new global::System.Data.Entity.Internal.DefaultModelCacheKey(context.GetType(), context.InternalContext.ProviderName, context.InternalContext.ProviderFactory.GetType(), customKey);
		}
	}
}
