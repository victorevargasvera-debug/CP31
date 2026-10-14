using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006D2 RID: 1746
	public sealed class DbNullExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x0600515E RID: 20830 RVA: 0x00122DE3 File Offset: 0x00120FE3
		internal DbNullExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null, type, true)
		{
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x00122DEF File Offset: 0x00120FEF
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005160 RID: 20832 RVA: 0x00122E04 File Offset: 0x00121004
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
