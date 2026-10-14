using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006E3 RID: 1763
	public sealed class DbTreatExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression
	{
		// Token: 0x060051B5 RID: 20917 RVA: 0x00123560 File Offset: 0x00121760
		internal DbTreatExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage asType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Treat, asType, argument)
		{
		}

		// Token: 0x060051B6 RID: 20918 RVA: 0x0012356C File Offset: 0x0012176C
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x00123581 File Offset: 0x00121781
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
