using System;
using System.Data.Entity.Core.Objects;

namespace System.Data.Entity.Core.Common.QueryCache
{
	// Token: 0x02000630 RID: 1584
	internal class ShaperFactoryQueryCacheKey<T> : global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey
	{
		// Token: 0x06004C68 RID: 19560 RVA: 0x0010C0BD File Offset: 0x0010A2BD
		internal ShaperFactoryQueryCacheKey(string columnMapKey, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool streaming, bool isValueLayer)
		{
			this._columnMapKey = columnMapKey;
			this._mergeOption = mergeOption;
			this._isValueLayer = isValueLayer;
			this._streaming = streaming;
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x0010C0E4 File Offset: 0x0010A2E4
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Common.QueryCache.ShaperFactoryQueryCacheKey<T> shaperFactoryQueryCacheKey = obj as global::System.Data.Entity.Core.Common.QueryCache.ShaperFactoryQueryCacheKey<T>;
			return shaperFactoryQueryCacheKey != null && (this._columnMapKey.Equals(shaperFactoryQueryCacheKey._columnMapKey, global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey._stringComparison) && this._mergeOption == shaperFactoryQueryCacheKey._mergeOption && this._isValueLayer == shaperFactoryQueryCacheKey._isValueLayer) && this._streaming == shaperFactoryQueryCacheKey._streaming;
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x0010C141 File Offset: 0x0010A341
		public override int GetHashCode()
		{
			return this._columnMapKey.GetHashCode();
		}

		// Token: 0x04001ABC RID: 6844
		private readonly string _columnMapKey;

		// Token: 0x04001ABD RID: 6845
		private readonly global::System.Data.Entity.Core.Objects.MergeOption _mergeOption;

		// Token: 0x04001ABE RID: 6846
		private readonly bool _isValueLayer;

		// Token: 0x04001ABF RID: 6847
		private readonly bool _streaming;
	}
}
