using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000693 RID: 1683
	internal sealed class OrderByClauseItem : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F96 RID: 20374 RVA: 0x0012011A File Offset: 0x0011E31A
		internal OrderByClauseItem(global::System.Data.Entity.Core.Common.EntitySql.AST.Node orderExpr, global::System.Data.Entity.Core.Common.EntitySql.AST.OrderKind orderKind) : this(orderExpr, orderKind, null)
		{
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x00120125 File Offset: 0x0011E325
		internal OrderByClauseItem(global::System.Data.Entity.Core.Common.EntitySql.AST.Node orderExpr, global::System.Data.Entity.Core.Common.EntitySql.AST.OrderKind orderKind, global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier optCollationIdentifier)
		{
			this._orderExpr = orderExpr;
			this._orderKind = orderKind;
			this._optCollationIdentifier = optCollationIdentifier;
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06004F98 RID: 20376 RVA: 0x00120142 File Offset: 0x0011E342
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node OrderExpr
		{
			get
			{
				return this._orderExpr;
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06004F99 RID: 20377 RVA: 0x0012014A File Offset: 0x0011E34A
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.OrderKind OrderKind
		{
			get
			{
				return this._orderKind;
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06004F9A RID: 20378 RVA: 0x00120152 File Offset: 0x0011E352
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier Collation
		{
			get
			{
				return this._optCollationIdentifier;
			}
		}

		// Token: 0x04001D1C RID: 7452
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _orderExpr;

		// Token: 0x04001D1D RID: 7453
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.OrderKind _orderKind;

		// Token: 0x04001D1E RID: 7454
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier _optCollationIdentifier;
	}
}
