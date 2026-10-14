using System;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006BA RID: 1722
	public abstract class DbExpressionVisitor
	{
		// Token: 0x06005084 RID: 20612
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression);

		// Token: 0x06005085 RID: 20613
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression expression);

		// Token: 0x06005086 RID: 20614
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression expression);

		// Token: 0x06005087 RID: 20615
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression expression);

		// Token: 0x06005088 RID: 20616
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression expression);

		// Token: 0x06005089 RID: 20617
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression expression);

		// Token: 0x0600508A RID: 20618
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression expression);

		// Token: 0x0600508B RID: 20619
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression expression);

		// Token: 0x0600508C RID: 20620
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression expression);

		// Token: 0x0600508D RID: 20621
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression expression);

		// Token: 0x0600508E RID: 20622
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression expression);

		// Token: 0x0600508F RID: 20623
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression expression);

		// Token: 0x06005090 RID: 20624
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression expression);

		// Token: 0x06005091 RID: 20625
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression expression);

		// Token: 0x06005092 RID: 20626
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression expression);

		// Token: 0x06005093 RID: 20627
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression expression);

		// Token: 0x06005094 RID: 20628
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression expression);

		// Token: 0x06005095 RID: 20629
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression expression);

		// Token: 0x06005096 RID: 20630
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression expression);

		// Token: 0x06005097 RID: 20631
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression expression);

		// Token: 0x06005098 RID: 20632
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression expression);

		// Token: 0x06005099 RID: 20633
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression expression);

		// Token: 0x0600509A RID: 20634
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression expression);

		// Token: 0x0600509B RID: 20635 RVA: 0x0012170B File Offset: 0x0011F90B
		public virtual void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression expression)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600509C RID: 20636
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression expression);

		// Token: 0x0600509D RID: 20637
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression expression);

		// Token: 0x0600509E RID: 20638
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression expression);

		// Token: 0x0600509F RID: 20639
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression expression);

		// Token: 0x060050A0 RID: 20640
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression expression);

		// Token: 0x060050A1 RID: 20641
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression expression);

		// Token: 0x060050A2 RID: 20642
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression expression);

		// Token: 0x060050A3 RID: 20643
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression);

		// Token: 0x060050A4 RID: 20644
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression expression);

		// Token: 0x060050A5 RID: 20645
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expression);

		// Token: 0x060050A6 RID: 20646
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression expression);

		// Token: 0x060050A7 RID: 20647
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression expression);

		// Token: 0x060050A8 RID: 20648
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression expression);

		// Token: 0x060050A9 RID: 20649
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression expression);

		// Token: 0x060050AA RID: 20650
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression expression);

		// Token: 0x060050AB RID: 20651
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression expression);

		// Token: 0x060050AC RID: 20652
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression expression);

		// Token: 0x060050AD RID: 20653
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression expression);

		// Token: 0x060050AE RID: 20654
		public abstract void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression expression);

		// Token: 0x060050AF RID: 20655 RVA: 0x00121712 File Offset: 0x0011F912
		public virtual void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression expression)
		{
			throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.VisitDbInExpressionNotImplemented);
		}
	}
}
