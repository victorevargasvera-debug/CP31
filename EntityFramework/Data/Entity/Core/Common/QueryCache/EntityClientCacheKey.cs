using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Internal;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;

namespace System.Data.Entity.Core.Common.QueryCache
{
	// Token: 0x0200062A RID: 1578
	internal sealed class EntityClientCacheKey : global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey
	{
		// Token: 0x06004C43 RID: 19523 RVA: 0x0010B5E4 File Offset: 0x001097E4
		internal EntityClientCacheKey(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand)
		{
			this._commandType = entityCommand.CommandType;
			this._eSqlStatement = entityCommand.CommandText;
			this._parametersToken = global::System.Data.Entity.Core.Common.QueryCache.EntityClientCacheKey.GetParametersToken(entityCommand);
			this._parameterCount = entityCommand.Parameters.Count;
			this._hashCode = (this._commandType.GetHashCode() ^ this._eSqlStatement.GetHashCode() ^ this._parametersToken.GetHashCode());
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x0010B65C File Offset: 0x0010985C
		public override bool Equals(object otherObject)
		{
			if (typeof(global::System.Data.Entity.Core.Common.QueryCache.EntityClientCacheKey) != otherObject.GetType())
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.QueryCache.EntityClientCacheKey entityClientCacheKey = (global::System.Data.Entity.Core.Common.QueryCache.EntityClientCacheKey)otherObject;
			return this._commandType == entityClientCacheKey._commandType && this._parameterCount == entityClientCacheKey._parameterCount && this.Equals(entityClientCacheKey._eSqlStatement, this._eSqlStatement) && this.Equals(entityClientCacheKey._parametersToken, this._parametersToken);
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x0010B6CD File Offset: 0x001098CD
		public override int GetHashCode()
		{
			return this._hashCode;
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x0010B6D8 File Offset: 0x001098D8
		private static string GetTypeUsageToken(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			string result;
			if (type == global::System.Data.Entity.Core.Common.Internal.DbTypeMap.AnsiString)
			{
				result = "AnsiString";
			}
			else if (type == global::System.Data.Entity.Core.Common.Internal.DbTypeMap.AnsiStringFixedLength)
			{
				result = "AnsiStringFixedLength";
			}
			else if (type == global::System.Data.Entity.Core.Common.Internal.DbTypeMap.String)
			{
				result = "String";
			}
			else if (type == global::System.Data.Entity.Core.Common.Internal.DbTypeMap.StringFixedLength)
			{
				result = "StringFixedLength";
			}
			else if (type == global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Xml)
			{
				result = "String";
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(type))
			{
				result = type.EdmType.FullName;
			}
			else
			{
				result = type.EdmType.Name;
			}
			return result;
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x0010B75C File Offset: 0x0010995C
		private static string GetParametersToken(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand)
		{
			if (entityCommand.Parameters == null || entityCommand.Parameters.Count == 0)
			{
				return "@@0";
			}
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> parameterTypeUsage = entityCommand.GetParameterTypeUsage();
			if (1 == parameterTypeUsage.Count)
			{
				return "@@1:" + entityCommand.Parameters[0].ParameterName + ":" + global::System.Data.Entity.Core.Common.QueryCache.EntityClientCacheKey.GetTypeUsageToken(parameterTypeUsage[entityCommand.Parameters[0].ParameterName]);
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(entityCommand.Parameters.Count * 20);
			stringBuilder.Append("@@");
			stringBuilder.Append(entityCommand.Parameters.Count);
			stringBuilder.Append(":");
			string value = "";
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> keyValuePair in parameterTypeUsage)
			{
				stringBuilder.Append(value);
				stringBuilder.Append(keyValuePair.Key);
				stringBuilder.Append(":");
				stringBuilder.Append(global::System.Data.Entity.Core.Common.QueryCache.EntityClientCacheKey.GetTypeUsageToken(keyValuePair.Value));
				value = ";";
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x0010B894 File Offset: 0x00109A94
		public override string ToString()
		{
			return string.Join("|", new string[]
			{
				global::System.Enum.GetName(typeof(global::System.Data.CommandType), this._commandType),
				this._eSqlStatement,
				this._parametersToken
			});
		}

		// Token: 0x04001A98 RID: 6808
		private readonly global::System.Data.CommandType _commandType;

		// Token: 0x04001A99 RID: 6809
		private readonly string _eSqlStatement;

		// Token: 0x04001A9A RID: 6810
		private readonly string _parametersToken;

		// Token: 0x04001A9B RID: 6811
		private readonly int _parameterCount;

		// Token: 0x04001A9C RID: 6812
		private readonly int _hashCode;
	}
}
