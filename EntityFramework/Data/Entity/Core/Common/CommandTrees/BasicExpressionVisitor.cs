using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006A3 RID: 1699
	public abstract class BasicExpressionVisitor : global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor
	{
		// Token: 0x06004FC9 RID: 20425 RVA: 0x001205B5 File Offset: 0x0011E7B5
		protected virtual void VisitUnaryExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression>(expression, "expression");
			this.VisitExpression(expression.Argument);
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x001205CF File Offset: 0x0011E7CF
		protected virtual void VisitBinaryExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression>(expression, "expression");
			this.VisitExpression(expression.Left);
			this.VisitExpression(expression.Right);
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x001205F5 File Offset: 0x0011E7F5
		protected virtual void VisitExpressionBindingPre(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(binding, "binding");
			this.VisitExpression(binding.Expression);
		}

		// Token: 0x06004FCC RID: 20428 RVA: 0x0012060F File Offset: 0x0011E80F
		protected virtual void VisitExpressionBindingPost(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding)
		{
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x00120611 File Offset: 0x0011E811
		protected virtual void VisitGroupExpressionBindingPre(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding binding)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding>(binding, "binding");
			this.VisitExpression(binding.Expression);
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x0012062B File Offset: 0x0011E82B
		protected virtual void VisitGroupExpressionBindingMid(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding binding)
		{
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x0012062D File Offset: 0x0011E82D
		protected virtual void VisitGroupExpressionBindingPost(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding binding)
		{
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x0012062F File Offset: 0x0011E82F
		protected virtual void VisitLambdaPre(global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambda>(lambda, "lambda");
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x0012063D File Offset: 0x0011E83D
		protected virtual void VisitLambdaPost(global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda)
		{
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x0012063F File Offset: 0x0011E83F
		public virtual void VisitExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(expression, "expression");
			expression.Accept(this);
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x00120654 File Offset: 0x0011E854
		public virtual void VisitExpressionList(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> expressionList)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(expressionList, "expressionList");
			for (int i = 0; i < expressionList.Count; i++)
			{
				this.VisitExpression(expressionList[i]);
			}
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x0012068C File Offset: 0x0011E88C
		public virtual void VisitAggregateList(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> aggregates)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>>(aggregates, "aggregates");
			for (int i = 0; i < aggregates.Count; i++)
			{
				this.VisitAggregate(aggregates[i]);
			}
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x001206C3 File Offset: 0x0011E8C3
		public virtual void VisitAggregate(global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate aggregate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>(aggregate, "aggregate");
			this.VisitExpressionList(aggregate.Arguments);
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x001206E0 File Offset: 0x0011E8E0
		internal virtual void VisitRelatedEntityReferenceList(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> relatedEntityReferences)
		{
			for (int i = 0; i < relatedEntityReferences.Count; i++)
			{
				this.VisitRelatedEntityReference(relatedEntityReferences[i]);
			}
		}

		// Token: 0x06004FD7 RID: 20439 RVA: 0x0012070B File Offset: 0x0011E90B
		internal virtual void VisitRelatedEntityReference(global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef relatedEntityRef)
		{
			this.VisitExpression(relatedEntityRef.TargetEntityReference);
		}

		// Token: 0x06004FD8 RID: 20440 RVA: 0x00120719 File Offset: 0x0011E919
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(expression, "expression");
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Cqt_General_UnsupportedExpression(expression.GetType().FullName));
		}

		// Token: 0x06004FD9 RID: 20441 RVA: 0x0012073C File Offset: 0x0011E93C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>(expression, "expression");
		}

		// Token: 0x06004FDA RID: 20442 RVA: 0x0012074A File Offset: 0x0011E94A
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression>(expression, "expression");
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x00120758 File Offset: 0x0011E958
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(expression, "expression");
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x00120766 File Offset: 0x0011E966
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(expression, "expression");
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x00120774 File Offset: 0x0011E974
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression>(expression, "expression");
			this.VisitExpressionList(expression.Arguments);
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x00120790 File Offset: 0x0011E990
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression>(expression, "expression");
			this.VisitExpressionList(expression.Arguments);
			this.VisitLambdaPre(expression.Lambda);
			this.VisitExpression(expression.Lambda.Body);
			this.VisitLambdaPost(expression.Lambda);
		}

		// Token: 0x06004FDF RID: 20447 RVA: 0x001207DE File Offset: 0x0011E9DE
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(expression, "expression");
			if (expression.Instance != null)
			{
				this.VisitExpression(expression.Instance);
			}
		}

		// Token: 0x06004FE0 RID: 20448 RVA: 0x00120800 File Offset: 0x0011EA00
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(expression, "expression");
			this.VisitBinaryExpression(expression);
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x00120815 File Offset: 0x0011EA15
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression>(expression, "expression");
			this.VisitExpression(expression.Argument);
			this.VisitExpression(expression.Pattern);
			this.VisitExpression(expression.Escape);
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x00120847 File Offset: 0x0011EA47
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression>(expression, "expression");
			this.VisitExpression(expression.Argument);
			this.VisitExpression(expression.Limit);
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x0012086D File Offset: 0x0011EA6D
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FE4 RID: 20452 RVA: 0x00120882 File Offset: 0x0011EA82
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression>(expression, "expression");
			this.VisitExpressionList(expression.Arguments);
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x0012089C File Offset: 0x0011EA9C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(expression, "expression");
			this.VisitBinaryExpression(expression);
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x001208B1 File Offset: 0x0011EAB1
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression>(expression, "expression");
			this.VisitBinaryExpression(expression);
		}

		// Token: 0x06004FE7 RID: 20455 RVA: 0x001208C6 File Offset: 0x0011EAC6
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression>(expression, "expression");
			this.VisitExpression(expression.Item);
			this.VisitExpressionList(expression.List);
		}

		// Token: 0x06004FE8 RID: 20456 RVA: 0x001208EC File Offset: 0x0011EAEC
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FE9 RID: 20457 RVA: 0x00120901 File Offset: 0x0011EB01
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x00120916 File Offset: 0x0011EB16
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x0012092B File Offset: 0x0011EB2B
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x00120940 File Offset: 0x0011EB40
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression>(expression, "expression");
			this.VisitBinaryExpression(expression);
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x00120955 File Offset: 0x0011EB55
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression>(expression, "expression");
			this.VisitBinaryExpression(expression);
		}

		// Token: 0x06004FEE RID: 20462 RVA: 0x0012096A File Offset: 0x0011EB6A
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression>(expression, "expression");
			this.VisitBinaryExpression(expression);
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x0012097F File Offset: 0x0011EB7F
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x00120994 File Offset: 0x0011EB94
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x001209A9 File Offset: 0x0011EBA9
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x001209BE File Offset: 0x0011EBBE
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x001209D3 File Offset: 0x0011EBD3
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression>(expression, "expression");
			this.VisitExpressionList(expression.When);
			this.VisitExpressionList(expression.Then);
			this.VisitExpression(expression.Else);
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x00120A05 File Offset: 0x0011EC05
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>(expression, "expression");
			this.VisitExpressionList(expression.Arguments);
			if (expression.HasRelatedEntityReferences)
			{
				this.VisitRelatedEntityReferenceList(expression.RelatedEntityReferences);
			}
		}

		// Token: 0x06004FF5 RID: 20469 RVA: 0x00120A33 File Offset: 0x0011EC33
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x00120A48 File Offset: 0x0011EC48
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression>(expression, "expression");
			this.VisitExpression(expression.NavigationSource);
		}

		// Token: 0x06004FF7 RID: 20471 RVA: 0x00120A62 File Offset: 0x0011EC62
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x00120A77 File Offset: 0x0011EC77
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x00120A8C File Offset: 0x0011EC8C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression>(expression, "expression");
			this.VisitUnaryExpression(expression);
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x00120AA1 File Offset: 0x0011ECA1
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(expression, "expression");
		}

		// Token: 0x06004FFB RID: 20475 RVA: 0x00120AAF File Offset: 0x0011ECAF
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>(expression, "expression");
			this.VisitExpressionBindingPre(expression.Input);
			this.VisitExpression(expression.Predicate);
			this.VisitExpressionBindingPost(expression.Input);
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x00120AE1 File Offset: 0x0011ECE1
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression>(expression, "expression");
			this.VisitExpressionBindingPre(expression.Input);
			this.VisitExpression(expression.Projection);
			this.VisitExpressionBindingPost(expression.Input);
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x00120B14 File Offset: 0x0011ED14
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression>(expression, "expression");
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding in expression.Inputs)
			{
				this.VisitExpressionBindingPre(binding);
			}
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding2 in expression.Inputs)
			{
				this.VisitExpressionBindingPost(binding2);
			}
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x00120BAC File Offset: 0x0011EDAC
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression>(expression, "expression");
			this.VisitExpressionBindingPre(expression.Left);
			this.VisitExpressionBindingPre(expression.Right);
			this.VisitExpression(expression.JoinCondition);
			this.VisitExpressionBindingPost(expression.Left);
			this.VisitExpressionBindingPost(expression.Right);
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x00120C01 File Offset: 0x0011EE01
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression>(expression, "expression");
			this.VisitExpressionBindingPre(expression.Input);
			if (expression.Apply != null)
			{
				this.VisitExpression(expression.Apply.Expression);
			}
			this.VisitExpressionBindingPost(expression.Input);
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x00120C40 File Offset: 0x0011EE40
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression>(expression, "expression");
			this.VisitGroupExpressionBindingPre(expression.Input);
			this.VisitExpressionList(expression.Keys);
			this.VisitGroupExpressionBindingMid(expression.Input);
			this.VisitAggregateList(expression.Aggregates);
			this.VisitGroupExpressionBindingPost(expression.Input);
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x00120C98 File Offset: 0x0011EE98
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression>(expression, "expression");
			this.VisitExpressionBindingPre(expression.Input);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause dbSortClause in expression.SortOrder)
			{
				this.VisitExpression(dbSortClause.Expression);
			}
			this.VisitExpressionBindingPost(expression.Input);
			this.VisitExpression(expression.Count);
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x00120D1C File Offset: 0x0011EF1C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(expression, "expression");
			this.VisitExpressionBindingPre(expression.Input);
			for (int i = 0; i < expression.SortOrder.Count; i++)
			{
				this.VisitExpression(expression.SortOrder[i].Expression);
			}
			this.VisitExpressionBindingPost(expression.Input);
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x00120D7A File Offset: 0x0011EF7A
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression>(expression, "expression");
			this.VisitExpressionBindingPre(expression.Input);
			this.VisitExpression(expression.Predicate);
			this.VisitExpressionBindingPost(expression.Input);
		}
	}
}
