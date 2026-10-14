using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006B3 RID: 1715
	public sealed class DbElementExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression
	{
		// Token: 0x0600504C RID: 20556 RVA: 0x001212F5 File Offset: 0x0011F4F5
		internal DbElementExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Element, resultType, argument)
		{
			this._singlePropertyUnwrapped = false;
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x00121308 File Offset: 0x0011F508
		internal DbElementExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, bool unwrapSingleProperty) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Element, resultType, argument)
		{
			this._singlePropertyUnwrapped = unwrapSingleProperty;
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x0600504E RID: 20558 RVA: 0x0012131B File Offset: 0x0011F51B
		internal bool IsSinglePropertyUnwrapped
		{
			get
			{
				return this._singlePropertyUnwrapped;
			}
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x00121323 File Offset: 0x0011F523
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x00121338 File Offset: 0x0011F538
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001D55 RID: 7509
		private readonly bool _singlePropertyUnwrapped;
	}
}
