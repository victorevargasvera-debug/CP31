using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006A5 RID: 1701
	public sealed class DbAndExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression
	{
		// Token: 0x06005008 RID: 20488 RVA: 0x00120DDA File Offset: 0x0011EFDA
		internal DbAndExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage booleanResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.And, booleanResultType, left, right)
		{
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x00120DE6 File Offset: 0x0011EFE6
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x00120DFB File Offset: 0x0011EFFB
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
