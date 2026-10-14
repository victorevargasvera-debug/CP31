using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006DB RID: 1755
	public sealed class DbRefKeyExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression
	{
		// Token: 0x0600518E RID: 20878 RVA: 0x00123185 File Offset: 0x00121385
		internal DbRefKeyExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage rowResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression reference) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.RefKey, rowResultType, reference)
		{
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x00123191 File Offset: 0x00121391
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005190 RID: 20880 RVA: 0x001231A6 File Offset: 0x001213A6
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}
	}
}
