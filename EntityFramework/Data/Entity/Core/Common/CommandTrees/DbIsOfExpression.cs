using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006C8 RID: 1736
	public sealed class DbIsOfExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression
	{
		// Token: 0x0600511A RID: 20762 RVA: 0x00121BD4 File Offset: 0x0011FDD4
		internal DbIsOfExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind isOfKind, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage booleanResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage isOfType) : base(isOfKind, booleanResultType, argument)
		{
			this._ofType = isOfType;
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x0600511B RID: 20763 RVA: 0x00121BE7 File Offset: 0x0011FDE7
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage OfType
		{
			get
			{
				return this._ofType;
			}
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x00121BEF File Offset: 0x0011FDEF
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x00121C04 File Offset: 0x0011FE04
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DAC RID: 7596
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _ofType;
	}
}
