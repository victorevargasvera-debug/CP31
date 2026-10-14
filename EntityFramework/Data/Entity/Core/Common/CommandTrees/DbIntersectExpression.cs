using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006C5 RID: 1733
	public sealed class DbIntersectExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression
	{
		// Token: 0x06005110 RID: 20752 RVA: 0x00121B29 File Offset: 0x0011FD29
		internal DbIntersectExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Intersect, resultType, left, right)
		{
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x00121B36 File Offset: 0x0011FD36
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x00121B4B File Offset: 0x0011FD4B
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
