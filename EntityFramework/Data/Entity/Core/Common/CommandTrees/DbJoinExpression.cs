using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006C9 RID: 1737
	public sealed class DbJoinExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x0600511E RID: 20766 RVA: 0x00121C19 File Offset: 0x0011FE19
		internal DbJoinExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind joinKind, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionOfRowResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding right, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression condition) : base(joinKind, collectionOfRowResultType, true)
		{
			this._left = left;
			this._right = right;
			this._condition = condition;
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x0600511F RID: 20767 RVA: 0x00121C3B File Offset: 0x0011FE3B
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding Left
		{
			get
			{
				return this._left;
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x00121C43 File Offset: 0x0011FE43
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding Right
		{
			get
			{
				return this._right;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06005121 RID: 20769 RVA: 0x00121C4B File Offset: 0x0011FE4B
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression JoinCondition
		{
			get
			{
				return this._condition;
			}
		}

		// Token: 0x06005122 RID: 20770 RVA: 0x00121C53 File Offset: 0x0011FE53
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005123 RID: 20771 RVA: 0x00121C68 File Offset: 0x0011FE68
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DAD RID: 7597
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding _left;

		// Token: 0x04001DAE RID: 7598
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding _right;

		// Token: 0x04001DAF RID: 7599
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _condition;
	}
}
