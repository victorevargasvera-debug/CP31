using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006DA RID: 1754
	public sealed class DbRefExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression
	{
		// Token: 0x0600518A RID: 20874 RVA: 0x00123140 File Offset: 0x00121340
		internal DbRefExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage refResultType, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression refKeys) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Ref, refResultType, refKeys)
		{
			this._entitySet = entitySet;
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x0600518B RID: 20875 RVA: 0x00123153 File Offset: 0x00121353
		public global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet
		{
			get
			{
				return this._entitySet;
			}
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x0012315B File Offset: 0x0012135B
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x00123170 File Offset: 0x00121370
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DC8 RID: 7624
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet _entitySet;
	}
}
