using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006A7 RID: 1703
	public sealed class DbArithmeticExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x06005010 RID: 20496 RVA: 0x00120E64 File Offset: 0x0011F064
		internal DbArithmeticExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage numericResultType, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList args) : base(kind, numericResultType, true)
		{
			this._args = args;
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06005011 RID: 20497 RVA: 0x00120E76 File Offset: 0x0011F076
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> Arguments
		{
			get
			{
				return this._args;
			}
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x00120E7E File Offset: 0x0011F07E
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x00120E93 File Offset: 0x0011F093
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001D41 RID: 7489
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList _args;
	}
}
