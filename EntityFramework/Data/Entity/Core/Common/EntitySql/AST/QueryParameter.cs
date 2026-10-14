using System;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000697 RID: 1687
	internal sealed class QueryParameter : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004FA5 RID: 20389 RVA: 0x00120214 File Offset: 0x0011E414
		internal QueryParameter(string parameterName, string query, int inputPos) : base(query, inputPos)
		{
			this._name = parameterName.Substring(1);
			if (this._name.StartsWith("_", global::System.StringComparison.OrdinalIgnoreCase) || char.IsDigit(this._name, 0))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = base.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidParameterFormat(this._name);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06004FA6 RID: 20390 RVA: 0x00120271 File Offset: 0x0011E471
		internal string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x04001D2A RID: 7466
		private readonly string _name;
	}
}
