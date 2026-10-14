using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006D3 RID: 1747
	public sealed class DbOfTypeExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression
	{
		// Token: 0x06005161 RID: 20833 RVA: 0x00122E19 File Offset: 0x00121019
		internal DbOfTypeExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind ofTypeKind, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : base(ofTypeKind, collectionResultType, argument)
		{
			this._ofType = type;
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06005162 RID: 20834 RVA: 0x00122E2C File Offset: 0x0012102C
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage OfType
		{
			get
			{
				return this._ofType;
			}
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x00122E34 File Offset: 0x00121034
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x00122E49 File Offset: 0x00121049
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DBE RID: 7614
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _ofType;
	}
}
