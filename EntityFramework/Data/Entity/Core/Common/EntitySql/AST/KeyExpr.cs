using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200068B RID: 1675
	internal class KeyExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F63 RID: 20323 RVA: 0x0011F4DA File Offset: 0x0011D6DA
		internal KeyExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node argExpr)
		{
			this._argExpr = argExpr;
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06004F64 RID: 20324 RVA: 0x0011F4E9 File Offset: 0x0011D6E9
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node ArgExpr
		{
			get
			{
				return this._argExpr;
			}
		}

		// Token: 0x04001CF8 RID: 7416
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _argExpr;
	}
}
