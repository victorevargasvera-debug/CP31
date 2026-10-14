using System;
using System.Data.Entity.Core.Objects;

namespace System.Data.Entity.Core.Common.QueryCache
{
	// Token: 0x0200062C RID: 1580
	internal sealed class LinqQueryCacheKey : global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey
	{
		// Token: 0x06004C4D RID: 19533 RVA: 0x0010BABC File Offset: 0x00109CBC
		internal LinqQueryCacheKey(string expressionKey, int parameterCount, string parametersToken, string includePathsToken, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool streaming, bool useCSharpNullComparisonBehavior, global::System.Type resultType)
		{
			this._expressionKey = expressionKey;
			this._parameterCount = parameterCount;
			this._parametersToken = parametersToken;
			this._includePathsToken = includePathsToken;
			this._mergeOption = mergeOption;
			this._streaming = streaming;
			this._resultType = resultType;
			this._useCSharpNullComparisonBehavior = useCSharpNullComparisonBehavior;
			int num = this._expressionKey.GetHashCode() ^ this._mergeOption.GetHashCode();
			if (this._parametersToken != null)
			{
				num ^= this._parametersToken.GetHashCode();
			}
			if (this._includePathsToken != null)
			{
				num ^= this._includePathsToken.GetHashCode();
			}
			num ^= this._useCSharpNullComparisonBehavior.GetHashCode();
			this._hashCode = num;
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x0010BB6C File Offset: 0x00109D6C
		public override bool Equals(object otherObject)
		{
			if (typeof(global::System.Data.Entity.Core.Common.QueryCache.LinqQueryCacheKey) != otherObject.GetType())
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.QueryCache.LinqQueryCacheKey linqQueryCacheKey = (global::System.Data.Entity.Core.Common.QueryCache.LinqQueryCacheKey)otherObject;
			return this._parameterCount == linqQueryCacheKey._parameterCount && this._mergeOption == linqQueryCacheKey._mergeOption && this._streaming == linqQueryCacheKey._streaming && this.Equals(linqQueryCacheKey._expressionKey, this._expressionKey) && this.Equals(linqQueryCacheKey._includePathsToken, this._includePathsToken) && this.Equals(linqQueryCacheKey._parametersToken, this._parametersToken) && object.Equals(linqQueryCacheKey._resultType, this._resultType) && object.Equals(linqQueryCacheKey._useCSharpNullComparisonBehavior, this._useCSharpNullComparisonBehavior);
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x0010BC32 File Offset: 0x00109E32
		public override int GetHashCode()
		{
			return this._hashCode;
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x0010BC3C File Offset: 0x00109E3C
		public override string ToString()
		{
			return string.Join("|", new string[]
			{
				this._expressionKey,
				this._parametersToken,
				this._includePathsToken,
				global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Objects.MergeOption), this._mergeOption),
				this._useCSharpNullComparisonBehavior.ToString()
			});
		}

		// Token: 0x04001AA6 RID: 6822
		private readonly int _hashCode;

		// Token: 0x04001AA7 RID: 6823
		private readonly string _expressionKey;

		// Token: 0x04001AA8 RID: 6824
		private readonly string _parametersToken;

		// Token: 0x04001AA9 RID: 6825
		private readonly int _parameterCount;

		// Token: 0x04001AAA RID: 6826
		private readonly string _includePathsToken;

		// Token: 0x04001AAB RID: 6827
		private readonly global::System.Data.Entity.Core.Objects.MergeOption _mergeOption;

		// Token: 0x04001AAC RID: 6828
		private readonly global::System.Type _resultType;

		// Token: 0x04001AAD RID: 6829
		private readonly bool _streaming;

		// Token: 0x04001AAE RID: 6830
		private readonly bool _useCSharpNullComparisonBehavior;
	}
}
