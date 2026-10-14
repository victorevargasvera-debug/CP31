using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000698 RID: 1688
	internal sealed class QueryStatement : global::System.Data.Entity.Core.Common.EntitySql.AST.Statement
	{
		// Token: 0x06004FA7 RID: 20391 RVA: 0x00120279 File Offset: 0x0011E479
		internal QueryStatement(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.FunctionDefinition> functionDefList, global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr)
		{
			this._functionDefList = functionDefList;
			this._expr = expr;
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06004FA8 RID: 20392 RVA: 0x0012028F File Offset: 0x0011E48F
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.FunctionDefinition> FunctionDefList
		{
			get
			{
				return this._functionDefList;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06004FA9 RID: 20393 RVA: 0x00120297 File Offset: 0x0011E497
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node Expr
		{
			get
			{
				return this._expr;
			}
		}

		// Token: 0x04001D2B RID: 7467
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.FunctionDefinition> _functionDefList;

		// Token: 0x04001D2C RID: 7468
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _expr;
	}
}
