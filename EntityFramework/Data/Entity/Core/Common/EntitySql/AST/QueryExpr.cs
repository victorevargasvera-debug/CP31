using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000696 RID: 1686
	internal sealed class QueryExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F9D RID: 20381 RVA: 0x00120171 File Offset: 0x0011E371
		internal QueryExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.SelectClause selectClause, global::System.Data.Entity.Core.Common.EntitySql.AST.FromClause fromClause, global::System.Data.Entity.Core.Common.EntitySql.AST.Node whereClause, global::System.Data.Entity.Core.Common.EntitySql.AST.GroupByClause groupByClause, global::System.Data.Entity.Core.Common.EntitySql.AST.HavingClause havingClause, global::System.Data.Entity.Core.Common.EntitySql.AST.OrderByClause orderByClause)
		{
			this._selectClause = selectClause;
			this._fromClause = fromClause;
			this._whereClause = whereClause;
			this._groupByClause = groupByClause;
			this._havingClause = havingClause;
			this._orderByClause = orderByClause;
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06004F9E RID: 20382 RVA: 0x001201A6 File Offset: 0x0011E3A6
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.SelectClause SelectClause
		{
			get
			{
				return this._selectClause;
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06004F9F RID: 20383 RVA: 0x001201AE File Offset: 0x0011E3AE
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.FromClause FromClause
		{
			get
			{
				return this._fromClause;
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06004FA0 RID: 20384 RVA: 0x001201B6 File Offset: 0x0011E3B6
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node WhereClause
		{
			get
			{
				return this._whereClause;
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06004FA1 RID: 20385 RVA: 0x001201BE File Offset: 0x0011E3BE
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.GroupByClause GroupByClause
		{
			get
			{
				return this._groupByClause;
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06004FA2 RID: 20386 RVA: 0x001201C6 File Offset: 0x0011E3C6
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.HavingClause HavingClause
		{
			get
			{
				return this._havingClause;
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06004FA3 RID: 20387 RVA: 0x001201CE File Offset: 0x0011E3CE
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.OrderByClause OrderByClause
		{
			get
			{
				return this._orderByClause;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x001201D6 File Offset: 0x0011E3D6
		internal bool HasMethodCall
		{
			get
			{
				return this._selectClause.HasMethodCall || (this._havingClause != null && this._havingClause.HasMethodCall) || (this._orderByClause != null && this._orderByClause.HasMethodCall);
			}
		}

		// Token: 0x04001D24 RID: 7460
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.SelectClause _selectClause;

		// Token: 0x04001D25 RID: 7461
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.FromClause _fromClause;

		// Token: 0x04001D26 RID: 7462
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _whereClause;

		// Token: 0x04001D27 RID: 7463
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.GroupByClause _groupByClause;

		// Token: 0x04001D28 RID: 7464
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.HavingClause _havingClause;

		// Token: 0x04001D29 RID: 7465
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.OrderByClause _orderByClause;
	}
}
