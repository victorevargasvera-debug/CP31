using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200064C RID: 1612
	public sealed class EntitySqlParser
	{
		// Token: 0x06004DF5 RID: 19957 RVA: 0x001177E4 File Offset: 0x001159E4
		internal EntitySqlParser(global::System.Data.Entity.Core.Metadata.Edm.Perspective perspective)
		{
			this._perspective = perspective;
		}

		// Token: 0x06004DF6 RID: 19958 RVA: 0x001177F4 File Offset: 0x001159F4
		public global::System.Data.Entity.Core.Common.EntitySql.ParseResult Parse(string query, params global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(query, "query");
			if (parameters != null)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> enumerable = parameters;
				global::System.Data.Entity.Core.EntityUtil.CheckArgumentContainsNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(ref enumerable, "parameters");
			}
			return global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.Compile(query, this._perspective, null, parameters);
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x00117830 File Offset: 0x00115A30
		public global::System.Data.Entity.Core.Common.CommandTrees.DbLambda ParseLambda(string query, params global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] variables)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(query, "query");
			if (variables != null)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> enumerable = variables;
				global::System.Data.Entity.Core.EntityUtil.CheckArgumentContainsNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(ref enumerable, "variables");
			}
			return global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.CompileQueryCommandLambda(query, this._perspective, null, null, variables);
		}

		// Token: 0x04001C2C RID: 7212
		private readonly global::System.Data.Entity.Core.Metadata.Edm.Perspective _perspective;
	}
}
