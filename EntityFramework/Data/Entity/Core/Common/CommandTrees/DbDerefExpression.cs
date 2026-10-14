using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006B1 RID: 1713
	public sealed class DbDerefExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression
	{
		// Token: 0x06005046 RID: 20550 RVA: 0x0012128A File Offset: 0x0011F48A
		internal DbDerefExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage entityResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression refExpr) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Deref, entityResultType, refExpr)
		{
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x00121295 File Offset: 0x0011F495
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x001212AA File Offset: 0x0011F4AA
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
