using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006A9 RID: 1705
	public sealed class DbCaseExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x06005018 RID: 20504 RVA: 0x00120EDA File Offset: 0x0011F0DA
		internal DbCaseExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonResultType, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList whens, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList thens, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression elseExpr) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Case, commonResultType, true)
		{
			this._when = whens;
			this._then = thens;
			this._else = elseExpr;
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06005019 RID: 20505 RVA: 0x00120EFB File Offset: 0x0011F0FB
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> When
		{
			get
			{
				return this._when;
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x0600501A RID: 20506 RVA: 0x00120F03 File Offset: 0x0011F103
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> Then
		{
			get
			{
				return this._then;
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x0600501B RID: 20507 RVA: 0x00120F0B File Offset: 0x0011F10B
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Else
		{
			get
			{
				return this._else;
			}
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x00120F13 File Offset: 0x0011F113
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x00120F28 File Offset: 0x0011F128
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001D44 RID: 7492
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList _when;

		// Token: 0x04001D45 RID: 7493
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList _then;

		// Token: 0x04001D46 RID: 7494
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _else;
	}
}
