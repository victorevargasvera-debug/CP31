using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006E2 RID: 1762
	public sealed class DbSortExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x060051B0 RID: 20912 RVA: 0x0012350C File Offset: 0x0012170C
		internal DbSortExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Sort, resultType, true)
		{
			this._input = input;
			this._keys = sortOrder;
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x060051B1 RID: 20913 RVA: 0x00123526 File Offset: 0x00121726
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding Input
		{
			get
			{
				return this._input;
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x0012352E File Offset: 0x0012172E
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> SortOrder
		{
			get
			{
				return this._keys;
			}
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x00123536 File Offset: 0x00121736
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x0012354B File Offset: 0x0012174B
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DD9 RID: 7641
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding _input;

		// Token: 0x04001DDA RID: 7642
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> _keys;
	}
}
