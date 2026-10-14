using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x020006A0 RID: 1696
	internal sealed class PropDefinition : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004FB9 RID: 20409 RVA: 0x0012035B File Offset: 0x0011E55B
		internal PropDefinition(global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier name, global::System.Data.Entity.Core.Common.EntitySql.AST.Node typeDefExpr)
		{
			this._name = name;
			this._typeDefExpr = typeDefExpr;
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06004FBA RID: 20410 RVA: 0x00120371 File Offset: 0x0011E571
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06004FBB RID: 20411 RVA: 0x00120379 File Offset: 0x0011E579
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node Type
		{
			get
			{
				return this._typeDefExpr;
			}
		}

		// Token: 0x04001D39 RID: 7481
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier _name;

		// Token: 0x04001D3A RID: 7482
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _typeDefExpr;
	}
}
