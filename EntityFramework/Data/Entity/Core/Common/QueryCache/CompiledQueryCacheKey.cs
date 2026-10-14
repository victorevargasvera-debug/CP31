using System;

namespace System.Data.Entity.Core.Common.QueryCache
{
	// Token: 0x02000629 RID: 1577
	internal sealed class CompiledQueryCacheKey : global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey
	{
		// Token: 0x06004C3F RID: 19519 RVA: 0x0010B54D File Offset: 0x0010974D
		internal CompiledQueryCacheKey(global::System.Guid cacheIdentity)
		{
			this._cacheIdentity = cacheIdentity;
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x0010B55C File Offset: 0x0010975C
		public override bool Equals(object compareTo)
		{
			return !(typeof(global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheKey) != compareTo.GetType()) && ((global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheKey)compareTo)._cacheIdentity.Equals(this._cacheIdentity);
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x0010B59C File Offset: 0x0010979C
		public override int GetHashCode()
		{
			return this._cacheIdentity.GetHashCode();
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x0010B5C0 File Offset: 0x001097C0
		public override string ToString()
		{
			return this._cacheIdentity.ToString();
		}

		// Token: 0x04001A97 RID: 6807
		private readonly global::System.Guid _cacheIdentity;
	}
}
