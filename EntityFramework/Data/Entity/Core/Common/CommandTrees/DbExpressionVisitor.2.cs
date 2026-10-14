using System;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006BB RID: 1723
	public abstract class DbExpressionVisitor<TResultType>
	{
		// Token: 0x060050B1 RID: 20657
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression);

		// Token: 0x060050B2 RID: 20658
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression expression);

		// Token: 0x060050B3 RID: 20659
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression expression);

		// Token: 0x060050B4 RID: 20660
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression expression);

		// Token: 0x060050B5 RID: 20661
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression expression);

		// Token: 0x060050B6 RID: 20662
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression expression);

		// Token: 0x060050B7 RID: 20663
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression expression);

		// Token: 0x060050B8 RID: 20664
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression expression);

		// Token: 0x060050B9 RID: 20665
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression expression);

		// Token: 0x060050BA RID: 20666
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression expression);

		// Token: 0x060050BB RID: 20667
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression expression);

		// Token: 0x060050BC RID: 20668
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression expression);

		// Token: 0x060050BD RID: 20669
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression expression);

		// Token: 0x060050BE RID: 20670
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression expression);

		// Token: 0x060050BF RID: 20671
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression expression);

		// Token: 0x060050C0 RID: 20672
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression expression);

		// Token: 0x060050C1 RID: 20673
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression expression);

		// Token: 0x060050C2 RID: 20674
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression expression);

		// Token: 0x060050C3 RID: 20675
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression expression);

		// Token: 0x060050C4 RID: 20676
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression expression);

		// Token: 0x060050C5 RID: 20677
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression expression);

		// Token: 0x060050C6 RID: 20678
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression expression);

		// Token: 0x060050C7 RID: 20679
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression expression);

		// Token: 0x060050C8 RID: 20680 RVA: 0x00121726 File Offset: 0x0011F926
		public virtual TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression expression)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060050C9 RID: 20681
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression expression);

		// Token: 0x060050CA RID: 20682
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression expression);

		// Token: 0x060050CB RID: 20683
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression expression);

		// Token: 0x060050CC RID: 20684
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression expression);

		// Token: 0x060050CD RID: 20685
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression expression);

		// Token: 0x060050CE RID: 20686
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression expression);

		// Token: 0x060050CF RID: 20687
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression expression);

		// Token: 0x060050D0 RID: 20688
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression);

		// Token: 0x060050D1 RID: 20689
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression expression);

		// Token: 0x060050D2 RID: 20690
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expression);

		// Token: 0x060050D3 RID: 20691
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression expression);

		// Token: 0x060050D4 RID: 20692
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression expression);

		// Token: 0x060050D5 RID: 20693
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression expression);

		// Token: 0x060050D6 RID: 20694
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression expression);

		// Token: 0x060050D7 RID: 20695
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression expression);

		// Token: 0x060050D8 RID: 20696
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression expression);

		// Token: 0x060050D9 RID: 20697
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression expression);

		// Token: 0x060050DA RID: 20698
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression expression);

		// Token: 0x060050DB RID: 20699
		public abstract TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression expression);

		// Token: 0x060050DC RID: 20700 RVA: 0x0012172D File Offset: 0x0011F92D
		public virtual TResultType Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression expression)
		{
			throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.VisitDbInExpressionNotImplemented);
		}
	}
}
