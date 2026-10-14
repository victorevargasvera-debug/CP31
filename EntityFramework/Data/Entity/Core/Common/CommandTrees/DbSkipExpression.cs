using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006E0 RID: 1760
	public sealed class DbSkipExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x060051A6 RID: 20902 RVA: 0x00123473 File Offset: 0x00121673
		internal DbSkipExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression count) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Skip, resultType, true)
		{
			this._input = input;
			this._keys = sortOrder;
			this._count = count;
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x060051A7 RID: 20903 RVA: 0x00123495 File Offset: 0x00121695
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding Input
		{
			get
			{
				return this._input;
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x060051A8 RID: 20904 RVA: 0x0012349D File Offset: 0x0012169D
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> SortOrder
		{
			get
			{
				return this._keys;
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x060051A9 RID: 20905 RVA: 0x001234A5 File Offset: 0x001216A5
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x001234AD File Offset: 0x001216AD
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x001234C2 File Offset: 0x001216C2
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DD3 RID: 7635
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding _input;

		// Token: 0x04001DD4 RID: 7636
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> _keys;

		// Token: 0x04001DD5 RID: 7637
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _count;
	}
}
