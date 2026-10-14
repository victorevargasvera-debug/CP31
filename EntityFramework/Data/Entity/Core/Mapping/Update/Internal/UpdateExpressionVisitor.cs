using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005D8 RID: 1496
	internal abstract class UpdateExpressionVisitor<TReturn> : global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TReturn>
	{
		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06004828 RID: 18472
		protected abstract string VisitorName { get; }

		// Token: 0x06004829 RID: 18473 RVA: 0x000FFACC File Offset: 0x000FDCCC
		protected global::System.NotSupportedException ConstructNotSupportedException(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression node)
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Update_UnsupportedExpressionKind((node == null) ? null : node.ExpressionKind.ToString(), this.VisitorName));
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x000FFB03 File Offset: 0x000FDD03
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(expression, "expression");
			if (expression != null)
			{
				return expression.Accept<TReturn>(this);
			}
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x000FFB23 File Offset: 0x000FDD23
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x000FFB38 File Offset: 0x000FDD38
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x000FFB4D File Offset: 0x000FDD4D
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x000FFB62 File Offset: 0x000FDD62
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x000FFB77 File Offset: 0x000FDD77
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x000FFB8C File Offset: 0x000FDD8C
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x000FFBA1 File Offset: 0x000FDDA1
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x000FFBB6 File Offset: 0x000FDDB6
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x000FFBCB File Offset: 0x000FDDCB
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x000FFBE0 File Offset: 0x000FDDE0
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x000FFBF5 File Offset: 0x000FDDF5
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x000FFC0A File Offset: 0x000FDE0A
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x000FFC1F File Offset: 0x000FDE1F
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x000FFC34 File Offset: 0x000FDE34
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x000FFC49 File Offset: 0x000FDE49
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x000FFC5E File Offset: 0x000FDE5E
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x000FFC73 File Offset: 0x000FDE73
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x000FFC88 File Offset: 0x000FDE88
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x000FFC9D File Offset: 0x000FDE9D
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x000FFCB2 File Offset: 0x000FDEB2
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600483F RID: 18495 RVA: 0x000FFCC7 File Offset: 0x000FDEC7
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x000FFCDC File Offset: 0x000FDEDC
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x000FFCF1 File Offset: 0x000FDEF1
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x000FFD06 File Offset: 0x000FDF06
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x000FFD1B File Offset: 0x000FDF1B
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x000FFD30 File Offset: 0x000FDF30
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x000FFD45 File Offset: 0x000FDF45
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x000FFD5A File Offset: 0x000FDF5A
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x000FFD6F File Offset: 0x000FDF6F
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x000FFD84 File Offset: 0x000FDF84
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x000FFD99 File Offset: 0x000FDF99
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x000FFDAE File Offset: 0x000FDFAE
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x000FFDC3 File Offset: 0x000FDFC3
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x000FFDD8 File Offset: 0x000FDFD8
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x000FFDED File Offset: 0x000FDFED
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x000FFE02 File Offset: 0x000FE002
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x000FFE17 File Offset: 0x000FE017
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x000FFE2C File Offset: 0x000FE02C
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x000FFE41 File Offset: 0x000FE041
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x000FFE56 File Offset: 0x000FE056
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004853 RID: 18515 RVA: 0x000FFE6B File Offset: 0x000FE06B
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x000FFE80 File Offset: 0x000FE080
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x000FFE95 File Offset: 0x000FE095
		public override TReturn Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(expression, "expression");
			throw this.ConstructNotSupportedException(expression);
		}
	}
}
