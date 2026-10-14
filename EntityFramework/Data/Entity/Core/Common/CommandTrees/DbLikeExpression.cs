using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006CC RID: 1740
	public sealed class DbLikeExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x0600513F RID: 20799 RVA: 0x00122BEA File Offset: 0x00120DEA
		internal DbLikeExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage booleanResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression pattern, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression escape) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Like, booleanResultType, true)
		{
			this._argument = input;
			this._pattern = pattern;
			this._escape = escape;
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06005140 RID: 20800 RVA: 0x00122C0C File Offset: 0x00120E0C
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Argument
		{
			get
			{
				return this._argument;
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06005141 RID: 20801 RVA: 0x00122C14 File Offset: 0x00120E14
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Pattern
		{
			get
			{
				return this._pattern;
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06005142 RID: 20802 RVA: 0x00122C1C File Offset: 0x00120E1C
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Escape
		{
			get
			{
				return this._escape;
			}
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x00122C24 File Offset: 0x00120E24
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x00122C39 File Offset: 0x00120E39
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DB4 RID: 7604
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _argument;

		// Token: 0x04001DB5 RID: 7605
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _pattern;

		// Token: 0x04001DB6 RID: 7606
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _escape;
	}
}
