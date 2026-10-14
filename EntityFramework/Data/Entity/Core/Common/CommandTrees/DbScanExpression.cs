using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006DE RID: 1758
	public class DbScanExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x0600519C RID: 20892 RVA: 0x00123324 File Offset: 0x00121524
		internal DbScanExpression()
		{
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x0012332C File Offset: 0x0012152C
		internal DbScanExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionOfEntityType, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Scan, collectionOfEntityType, true)
		{
			this._targetSet = entitySet;
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x0600519E RID: 20894 RVA: 0x0012333F File Offset: 0x0012153F
		public virtual global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase Target
		{
			get
			{
				return this._targetSet;
			}
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x00123347 File Offset: 0x00121547
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x0012335C File Offset: 0x0012155C
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DD0 RID: 7632
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase _targetSet;
	}
}
