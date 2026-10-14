using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006AD RID: 1709
	public sealed class DbComparisonExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression
	{
		// Token: 0x06005032 RID: 20530 RVA: 0x0012110A File Offset: 0x0011F30A
		internal DbComparisonExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage booleanResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right) : base(kind, booleanResultType, left, right)
		{
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x00121117 File Offset: 0x0011F317
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x0012112C File Offset: 0x0011F32C
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
