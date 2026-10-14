using System;

namespace System.Data.Entity.Core.Common.QueryCache
{
	// Token: 0x0200062D RID: 1581
	internal class QueryCacheEntry
	{
		// Token: 0x06004C51 RID: 19537 RVA: 0x0010BCA2 File Offset: 0x00109EA2
		internal QueryCacheEntry(global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey queryCacheKey, object target)
		{
			this._queryCacheKey = queryCacheKey;
			this._target = target;
		}

		// Token: 0x06004C52 RID: 19538 RVA: 0x0010BCB8 File Offset: 0x00109EB8
		internal virtual object GetTarget()
		{
			return this._target;
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06004C53 RID: 19539 RVA: 0x0010BCC0 File Offset: 0x00109EC0
		internal global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey QueryCacheKey
		{
			get
			{
				return this._queryCacheKey;
			}
		}

		// Token: 0x04001AAF RID: 6831
		private readonly global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey _queryCacheKey;

		// Token: 0x04001AB0 RID: 6832
		protected readonly object _target;
	}
}
