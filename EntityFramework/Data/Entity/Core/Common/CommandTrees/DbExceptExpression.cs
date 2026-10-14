using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006B5 RID: 1717
	public sealed class DbExceptExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression
	{
		// Token: 0x06005054 RID: 20564 RVA: 0x00121383 File Offset: 0x0011F583
		internal DbExceptExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Except, resultType, left, right)
		{
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x00121390 File Offset: 0x0011F590
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x001213A5 File Offset: 0x0011F5A5
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
