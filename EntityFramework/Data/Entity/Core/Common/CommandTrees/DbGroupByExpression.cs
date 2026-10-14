using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006C1 RID: 1729
	public sealed class DbGroupByExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x060050F4 RID: 20724 RVA: 0x00121914 File Offset: 0x0011FB14
		internal DbGroupByExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionOfRowResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList groupKeys, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> aggregates) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GroupBy, collectionOfRowResultType, true)
		{
			this._input = input;
			this._keys = groupKeys;
			this._aggregates = aggregates;
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x060050F5 RID: 20725 RVA: 0x00121936 File Offset: 0x0011FB36
		public global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding Input
		{
			get
			{
				return this._input;
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x060050F6 RID: 20726 RVA: 0x0012193E File Offset: 0x0011FB3E
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> Keys
		{
			get
			{
				return this._keys;
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x060050F7 RID: 20727 RVA: 0x00121946 File Offset: 0x0011FB46
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> Aggregates
		{
			get
			{
				return this._aggregates;
			}
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x0012194E File Offset: 0x0011FB4E
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x00121963 File Offset: 0x0011FB63
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DA1 RID: 7585
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding _input;

		// Token: 0x04001DA2 RID: 7586
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList _keys;

		// Token: 0x04001DA3 RID: 7587
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> _aggregates;
	}
}
