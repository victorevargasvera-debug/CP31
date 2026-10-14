using System;
using System.Data.Entity.Core.Objects;

namespace System.Data.Entity.Core.Common.QueryCache
{
	// Token: 0x0200062B RID: 1579
	internal sealed class EntitySqlQueryCacheKey : global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey
	{
		// Token: 0x06004C49 RID: 19529 RVA: 0x0010B8E0 File Offset: 0x00109AE0
		internal EntitySqlQueryCacheKey(string defaultContainerName, string eSqlStatement, int parameterCount, string parametersToken, string includePathsToken, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool streaming, global::System.Type resultType)
		{
			this._defaultContainer = defaultContainerName;
			this._eSqlStatement = eSqlStatement;
			this._parameterCount = parameterCount;
			this._parametersToken = parametersToken;
			this._includePathsToken = includePathsToken;
			this._mergeOption = mergeOption;
			this._streaming = streaming;
			this._resultType = resultType;
			int num = this._eSqlStatement.GetHashCode() ^ this._mergeOption.GetHashCode();
			if (this._parametersToken != null)
			{
				num ^= this._parametersToken.GetHashCode();
			}
			if (this._includePathsToken != null)
			{
				num ^= this._includePathsToken.GetHashCode();
			}
			if (this._defaultContainer != null)
			{
				num ^= this._defaultContainer.GetHashCode();
			}
			this._hashCode = num;
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x0010B998 File Offset: 0x00109B98
		public override bool Equals(object otherObject)
		{
			if (typeof(global::System.Data.Entity.Core.Common.QueryCache.EntitySqlQueryCacheKey) != otherObject.GetType())
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.QueryCache.EntitySqlQueryCacheKey entitySqlQueryCacheKey = (global::System.Data.Entity.Core.Common.QueryCache.EntitySqlQueryCacheKey)otherObject;
			return this._parameterCount == entitySqlQueryCacheKey._parameterCount && this._mergeOption == entitySqlQueryCacheKey._mergeOption && this._streaming == entitySqlQueryCacheKey._streaming && this.Equals(entitySqlQueryCacheKey._defaultContainer, this._defaultContainer) && this.Equals(entitySqlQueryCacheKey._eSqlStatement, this._eSqlStatement) && this.Equals(entitySqlQueryCacheKey._includePathsToken, this._includePathsToken) && this.Equals(entitySqlQueryCacheKey._parametersToken, this._parametersToken) && object.Equals(entitySqlQueryCacheKey._resultType, this._resultType);
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x0010BA52 File Offset: 0x00109C52
		public override int GetHashCode()
		{
			return this._hashCode;
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x0010BA5C File Offset: 0x00109C5C
		public override string ToString()
		{
			return string.Join("|", new string[]
			{
				this._defaultContainer,
				this._eSqlStatement,
				this._parametersToken,
				this._includePathsToken,
				global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Objects.MergeOption), this._mergeOption)
			});
		}

		// Token: 0x04001A9D RID: 6813
		private readonly int _hashCode;

		// Token: 0x04001A9E RID: 6814
		private readonly string _defaultContainer;

		// Token: 0x04001A9F RID: 6815
		private readonly string _eSqlStatement;

		// Token: 0x04001AA0 RID: 6816
		private readonly string _parametersToken;

		// Token: 0x04001AA1 RID: 6817
		private readonly int _parameterCount;

		// Token: 0x04001AA2 RID: 6818
		private readonly string _includePathsToken;

		// Token: 0x04001AA3 RID: 6819
		private readonly global::System.Data.Entity.Core.Objects.MergeOption _mergeOption;

		// Token: 0x04001AA4 RID: 6820
		private readonly global::System.Type _resultType;

		// Token: 0x04001AA5 RID: 6821
		private readonly bool _streaming;
	}
}
