using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006C7 RID: 1735
	public class DbIsNullExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression
	{
		// Token: 0x06005116 RID: 20758 RVA: 0x00121B96 File Offset: 0x0011FD96
		internal DbIsNullExpression()
		{
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x00121B9E File Offset: 0x0011FD9E
		internal DbIsNullExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage booleanResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression arg) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsNull, booleanResultType, arg)
		{
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x00121BAA File Offset: 0x0011FDAA
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x00121BBF File Offset: 0x0011FDBF
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
