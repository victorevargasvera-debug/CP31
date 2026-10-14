using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006B2 RID: 1714
	public sealed class DbDistinctExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression
	{
		// Token: 0x06005049 RID: 20553 RVA: 0x001212BF File Offset: 0x0011F4BF
		internal DbDistinctExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Distinct, resultType, argument)
		{
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x001212CB File Offset: 0x0011F4CB
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x001212E0 File Offset: 0x0011F4E0
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
