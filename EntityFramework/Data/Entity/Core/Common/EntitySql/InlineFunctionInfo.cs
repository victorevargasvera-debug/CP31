using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.EntitySql.AST;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200065B RID: 1627
	internal abstract class InlineFunctionInfo
	{
		// Token: 0x06004E22 RID: 20002 RVA: 0x001180DC File Offset: 0x001162DC
		internal InlineFunctionInfo(global::System.Data.Entity.Core.Common.EntitySql.AST.FunctionDefinition functionDef, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> parameters)
		{
			this.FunctionDefAst = functionDef;
			this.Parameters = parameters;
		}

		// Token: 0x06004E23 RID: 20003
		internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbLambda GetLambda(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr);

		// Token: 0x04001C50 RID: 7248
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.AST.FunctionDefinition FunctionDefAst;

		// Token: 0x04001C51 RID: 7249
		internal readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> Parameters;
	}
}
