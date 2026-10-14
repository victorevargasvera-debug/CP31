using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000685 RID: 1669
	internal sealed class GroupByClause : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F52 RID: 20306 RVA: 0x0011F3B6 File Offset: 0x0011D5B6
		internal GroupByClause(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr> groupItems)
		{
			this._groupItems = groupItems;
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06004F53 RID: 20307 RVA: 0x0011F3C5 File Offset: 0x0011D5C5
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr> GroupItems
		{
			get
			{
				return this._groupItems;
			}
		}

		// Token: 0x04001CE8 RID: 7400
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr> _groupItems;
	}
}
