using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006AF RID: 1711
	public sealed class DbCrossJoinExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x0600503B RID: 20539 RVA: 0x001211F2 File Offset: 0x0011F3F2
		internal DbCrossJoinExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionOfRowResultType, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> inputs) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossJoin, collectionOfRowResultType, true)
		{
			this._inputs = inputs;
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x0600503C RID: 20540 RVA: 0x00121204 File Offset: 0x0011F404
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> Inputs
		{
			get
			{
				return this._inputs;
			}
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x0012120C File Offset: 0x0011F40C
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x00121221 File Offset: 0x0011F421
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001D53 RID: 7507
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> _inputs;
	}
}
