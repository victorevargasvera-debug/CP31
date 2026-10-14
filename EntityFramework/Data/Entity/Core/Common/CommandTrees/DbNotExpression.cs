using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006D1 RID: 1745
	public sealed class DbNotExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression
	{
		// Token: 0x0600515B RID: 20827 RVA: 0x00122DAD File Offset: 0x00120FAD
		internal DbNotExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage booleanResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Not, booleanResultType, argument)
		{
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x00122DB9 File Offset: 0x00120FB9
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x00122DCE File Offset: 0x00120FCE
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
