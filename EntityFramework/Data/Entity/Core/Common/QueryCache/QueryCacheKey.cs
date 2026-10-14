using System;

namespace System.Data.Entity.Core.Common.QueryCache
{
	// Token: 0x0200062E RID: 1582
	internal abstract class QueryCacheKey
	{
		// Token: 0x06004C54 RID: 19540 RVA: 0x0010BCC8 File Offset: 0x00109EC8
		protected QueryCacheKey()
		{
			this._hitCount = 1U;
		}

		// Token: 0x06004C55 RID: 19541
		public abstract override bool Equals(object obj);

		// Token: 0x06004C56 RID: 19542
		public abstract override int GetHashCode();

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06004C57 RID: 19543 RVA: 0x0010BCD7 File Offset: 0x00109ED7
		// (set) Token: 0x06004C58 RID: 19544 RVA: 0x0010BCDF File Offset: 0x00109EDF
		internal uint HitCount
		{
			get
			{
				return this._hitCount;
			}
			set
			{
				this._hitCount = value;
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06004C59 RID: 19545 RVA: 0x0010BCE8 File Offset: 0x00109EE8
		// (set) Token: 0x06004C5A RID: 19546 RVA: 0x0010BCF0 File Offset: 0x00109EF0
		internal int AgingIndex { get; set; }

		// Token: 0x06004C5B RID: 19547 RVA: 0x0010BCF9 File Offset: 0x00109EF9
		internal void UpdateHit()
		{
			if (4294967295U != this._hitCount)
			{
				this._hitCount += 1U;
			}
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x0010BD12 File Offset: 0x00109F12
		protected virtual bool Equals(string s, string t)
		{
			return string.Equals(s, t, global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey._stringComparison);
		}

		// Token: 0x04001AB1 RID: 6833
		protected const int EstimatedParameterStringSize = 20;

		// Token: 0x04001AB2 RID: 6834
		private uint _hitCount;

		// Token: 0x04001AB3 RID: 6835
		protected static global::System.StringComparison _stringComparison = global::System.StringComparison.Ordinal;
	}
}
