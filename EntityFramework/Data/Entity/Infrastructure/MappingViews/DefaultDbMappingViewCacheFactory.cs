using System;

namespace System.Data.Entity.Infrastructure.MappingViews
{
	// Token: 0x02000272 RID: 626
	internal class DefaultDbMappingViewCacheFactory : global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCacheFactory
	{
		// Token: 0x06001F87 RID: 8071 RVA: 0x00059054 File Offset: 0x00057254
		public DefaultDbMappingViewCacheFactory(global::System.Type cacheType)
		{
			this._cacheType = cacheType;
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x00059063 File Offset: 0x00057263
		public override global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCache Create(string conceptualModelContainerName, string storeModelContainerName)
		{
			return (global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCache)global::System.Activator.CreateInstance(this._cacheType);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00059075 File Offset: 0x00057275
		public override int GetHashCode()
		{
			return this._cacheType.GetHashCode() * 397 ^ typeof(global::System.Data.Entity.Infrastructure.MappingViews.DefaultDbMappingViewCacheFactory).GetHashCode();
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00059098 File Offset: 0x00057298
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Infrastructure.MappingViews.DefaultDbMappingViewCacheFactory defaultDbMappingViewCacheFactory = obj as global::System.Data.Entity.Infrastructure.MappingViews.DefaultDbMappingViewCacheFactory;
			return defaultDbMappingViewCacheFactory != null && defaultDbMappingViewCacheFactory._cacheType == this._cacheType;
		}

		// Token: 0x04000B6A RID: 2922
		private readonly global::System.Type _cacheType;
	}
}
