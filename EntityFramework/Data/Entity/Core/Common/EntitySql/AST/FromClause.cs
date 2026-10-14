using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000680 RID: 1664
	internal sealed class FromClause : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F44 RID: 20292 RVA: 0x0011F2E4 File Offset: 0x0011D4E4
		internal FromClause(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem> fromClauseItems)
		{
			this._fromClauseItems = fromClauseItems;
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06004F45 RID: 20293 RVA: 0x0011F2F3 File Offset: 0x0011D4F3
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem> FromClauseItems
		{
			get
			{
				return this._fromClauseItems;
			}
		}

		// Token: 0x04001CDA RID: 7386
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem> _fromClauseItems;
	}
}
