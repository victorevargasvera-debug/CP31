using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006CD RID: 1741
	public sealed class DbLimitExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x06005145 RID: 20805 RVA: 0x00122C4E File Offset: 0x00120E4E
		internal DbLimitExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression limit, bool withTies) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Limit, resultType, true)
		{
			this._argument = argument;
			this._limit = limit;
			this._withTies = withTies;
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06005146 RID: 20806 RVA: 0x00122C70 File Offset: 0x00120E70
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Argument
		{
			get
			{
				return this._argument;
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06005147 RID: 20807 RVA: 0x00122C78 File Offset: 0x00120E78
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Limit
		{
			get
			{
				return this._limit;
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06005148 RID: 20808 RVA: 0x00122C80 File Offset: 0x00120E80
		public bool WithTies
		{
			get
			{
				return this._withTies;
			}
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x00122C88 File Offset: 0x00120E88
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x00122C9D File Offset: 0x00120E9D
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DB7 RID: 7607
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _argument;

		// Token: 0x04001DB8 RID: 7608
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _limit;

		// Token: 0x04001DB9 RID: 7609
		private readonly bool _withTies;
	}
}
