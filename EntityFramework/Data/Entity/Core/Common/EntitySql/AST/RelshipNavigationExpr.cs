using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000691 RID: 1681
	internal sealed class RelshipNavigationExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F8C RID: 20364 RVA: 0x0012008D File Offset: 0x0011E28D
		internal RelshipNavigationExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node refExpr, global::System.Data.Entity.Core.Common.EntitySql.AST.Node relshipTypeName, global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier toEndIdentifier, global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier fromEndIdentifier)
		{
			this._refExpr = refExpr;
			this._relshipTypeName = relshipTypeName;
			this._toEndIdentifier = toEndIdentifier;
			this._fromEndIdentifier = fromEndIdentifier;
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06004F8D RID: 20365 RVA: 0x001200B2 File Offset: 0x0011E2B2
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node RefExpr
		{
			get
			{
				return this._refExpr;
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06004F8E RID: 20366 RVA: 0x001200BA File Offset: 0x0011E2BA
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node TypeName
		{
			get
			{
				return this._relshipTypeName;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06004F8F RID: 20367 RVA: 0x001200C2 File Offset: 0x0011E2C2
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier ToEndIdentifier
		{
			get
			{
				return this._toEndIdentifier;
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06004F90 RID: 20368 RVA: 0x001200CA File Offset: 0x0011E2CA
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier FromEndIdentifier
		{
			get
			{
				return this._fromEndIdentifier;
			}
		}

		// Token: 0x04001D14 RID: 7444
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _refExpr;

		// Token: 0x04001D15 RID: 7445
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _relshipTypeName;

		// Token: 0x04001D16 RID: 7446
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier _toEndIdentifier;

		// Token: 0x04001D17 RID: 7447
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier _fromEndIdentifier;
	}
}
