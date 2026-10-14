using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006B4 RID: 1716
	public sealed class DbEntityRefExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression
	{
		// Token: 0x06005051 RID: 20561 RVA: 0x0012134D File Offset: 0x0011F54D
		internal DbEntityRefExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage refResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression entity) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.EntityRef, refResultType, entity)
		{
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x00121359 File Offset: 0x0011F559
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x0012136E File Offset: 0x0011F56E
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
