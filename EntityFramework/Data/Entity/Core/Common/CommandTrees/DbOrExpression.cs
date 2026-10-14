using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006D4 RID: 1748
	public class DbOrExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression
	{
		// Token: 0x06005165 RID: 20837 RVA: 0x00122E5E File Offset: 0x0012105E
		internal DbOrExpression()
		{
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x00122E66 File Offset: 0x00121066
		internal DbOrExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage booleanResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Or, booleanResultType, left, right)
		{
		}

		// Token: 0x06005167 RID: 20839 RVA: 0x00122E73 File Offset: 0x00121073
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x00122E88 File Offset: 0x00121088
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
