using System;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006E1 RID: 1761
	public sealed class DbSortClause
	{
		// Token: 0x060051AC RID: 20908 RVA: 0x001234D7 File Offset: 0x001216D7
		internal DbSortClause(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key, bool asc, string collation)
		{
			this._expr = key;
			this._asc = asc;
			this._coll = collation;
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x060051AD RID: 20909 RVA: 0x001234F4 File Offset: 0x001216F4
		public bool Ascending
		{
			get
			{
				return this._asc;
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x060051AE RID: 20910 RVA: 0x001234FC File Offset: 0x001216FC
		public string Collation
		{
			get
			{
				return this._coll;
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x060051AF RID: 20911 RVA: 0x00123504 File Offset: 0x00121704
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Expression
		{
			get
			{
				return this._expr;
			}
		}

		// Token: 0x04001DD6 RID: 7638
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _expr;

		// Token: 0x04001DD7 RID: 7639
		private readonly bool _asc;

		// Token: 0x04001DD8 RID: 7640
		private readonly string _coll;
	}
}
