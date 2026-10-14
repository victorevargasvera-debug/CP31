using System;
using System.Data.Entity.Internal.ConfigFile;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000128 RID: 296
	internal class QueryCacheConfig
	{
		// Token: 0x06001493 RID: 5267 RVA: 0x00034CE8 File Offset: 0x00032EE8
		public QueryCacheConfig(global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection entityFrameworkSection)
		{
			this._entityFrameworkSection = entityFrameworkSection;
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00034CF8 File Offset: 0x00032EF8
		public int GetQueryCacheSize()
		{
			int size = this._entityFrameworkSection.QueryCache.Size;
			if (size == 0)
			{
				return 1000;
			}
			return size;
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00034D20 File Offset: 0x00032F20
		public int GetCleaningIntervalInSeconds()
		{
			int cleaningIntervalInSeconds = this._entityFrameworkSection.QueryCache.CleaningIntervalInSeconds;
			if (cleaningIntervalInSeconds == 0)
			{
				return 60;
			}
			return cleaningIntervalInSeconds;
		}

		// Token: 0x040009A7 RID: 2471
		private const int DefaultSize = 1000;

		// Token: 0x040009A8 RID: 2472
		private const int DefaultCleaningIntervalInSeconds = 60;

		// Token: 0x040009A9 RID: 2473
		private readonly global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection _entityFrameworkSection;
	}
}
