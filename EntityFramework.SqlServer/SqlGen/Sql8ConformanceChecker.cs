using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.SqlServer.Resources;
using System.Data.Entity.SqlServer.Utilities;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x02000033 RID: 51
	internal class Sql8ConformanceChecker : global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<bool>
	{
		// Token: 0x06000467 RID: 1127 RVA: 0x000117E4 File Offset: 0x0000F9E4
		internal static bool NeedsRewrite(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
		{
			global::System.Data.Entity.SqlServer.SqlGen.Sql8ConformanceChecker visitor = new global::System.Data.Entity.SqlServer.SqlGen.Sql8ConformanceChecker();
			return expr.Accept<bool>(visitor);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000117FE File Offset: 0x0000F9FE
		private Sql8ConformanceChecker()
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00011806 File Offset: 0x0000FA06
		private bool VisitUnaryExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression expr)
		{
			return this.VisitExpression(expr.Argument);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00011814 File Offset: 0x0000FA14
		private bool VisitBinaryExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression expr)
		{
			bool flag = this.VisitExpression(expr.Left);
			bool flag2 = this.VisitExpression(expr.Right);
			return flag || flag2;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0001183C File Offset: 0x0000FA3C
		private bool VisitAggregate(global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate aggregate)
		{
			return this.VisitExpressionList(aggregate.Arguments);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0001184A File Offset: 0x0000FA4A
		private bool VisitExpressionBinding(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding expressionBinding)
		{
			return this.VisitExpression(expressionBinding.Expression);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00011858 File Offset: 0x0000FA58
		private bool VisitExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			return expression != null && expression.Accept<bool>(this);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00011866 File Offset: 0x0000FA66
		private bool VisitSortClause(global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause sortClause)
		{
			return this.VisitExpression(sortClause.Expression);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00011874 File Offset: 0x0000FA74
		private static bool VisitList<TElementType>(global::System.Data.Entity.SqlServer.SqlGen.Sql8ConformanceChecker.ListElementHandler<TElementType> handler, global::System.Collections.Generic.IList<TElementType> list)
		{
			bool flag = false;
			foreach (TElementType element in list)
			{
				bool flag2 = handler(element);
				flag = (flag || flag2);
			}
			return flag;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000118C4 File Offset: 0x0000FAC4
		private bool VisitAggregateList(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> list)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.Sql8ConformanceChecker.VisitList<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>(new global::System.Data.Entity.SqlServer.SqlGen.Sql8ConformanceChecker.ListElementHandler<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>(this.VisitAggregate), list);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000118D8 File Offset: 0x0000FAD8
		private bool VisitExpressionBindingList(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> list)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.Sql8ConformanceChecker.VisitList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(new global::System.Data.Entity.SqlServer.SqlGen.Sql8ConformanceChecker.ListElementHandler<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(this.VisitExpressionBinding), list);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x000118EC File Offset: 0x0000FAEC
		private bool VisitExpressionList(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.Sql8ConformanceChecker.VisitList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(new global::System.Data.Entity.SqlServer.SqlGen.Sql8ConformanceChecker.ListElementHandler<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this.VisitExpression), list);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00011900 File Offset: 0x0000FB00
		private bool VisitSortClauseList(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> list)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.Sql8ConformanceChecker.VisitList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>(new global::System.Data.Entity.SqlServer.SqlGen.Sql8ConformanceChecker.ListElementHandler<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>(this.VisitSortClause), list);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00011914 File Offset: 0x0000FB14
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(expression, "expression");
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.Cqt_General_UnsupportedExpression(expression.GetType().FullName));
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00011937 File Offset: 0x0000FB37
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(expression, "expression");
			return this.VisitBinaryExpression(expression);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001194C File Offset: 0x0000FB4C
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression>(expression, "expression");
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_ApplyNotSupportedOnSql8);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00011964 File Offset: 0x0000FB64
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression>(expression, "expression");
			return this.VisitExpressionList(expression.Arguments);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00011980 File Offset: 0x0000FB80
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression>(expression, "expression");
			bool flag = this.VisitExpressionList(expression.When);
			bool flag2 = this.VisitExpressionList(expression.Then);
			bool flag3 = this.VisitExpression(expression.Else);
			return flag || flag2 || flag3;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000119C3 File Offset: 0x0000FBC3
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000119D8 File Offset: 0x0000FBD8
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(expression, "expression");
			return this.VisitBinaryExpression(expression);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000119ED File Offset: 0x0000FBED
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>(expression, "expression");
			return false;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000119FC File Offset: 0x0000FBFC
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression>(expression, "expression");
			return this.VisitExpressionBindingList(expression.Inputs);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00011A16 File Offset: 0x0000FC16
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00011A2B File Offset: 0x0000FC2B
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00011A40 File Offset: 0x0000FC40
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00011A55 File Offset: 0x0000FC55
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00011A6A File Offset: 0x0000FC6A
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression>(expression, "expression");
			this.VisitExpression(expression.Left);
			this.VisitExpression(expression.Right);
			return true;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00011A94 File Offset: 0x0000FC94
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>(expression, "expression");
			bool flag = this.VisitExpressionBinding(expression.Input);
			bool flag2 = this.VisitExpression(expression.Predicate);
			return flag || flag2;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00011AC8 File Offset: 0x0000FCC8
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression>(expression, "expression");
			return this.VisitExpressionList(expression.Arguments);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00011AE4 File Offset: 0x0000FCE4
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression>(expression, "expression");
			bool flag = this.VisitExpressionList(expression.Arguments);
			bool flag2 = this.VisitExpression(expression.Lambda.Body);
			return flag || flag2;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00011B20 File Offset: 0x0000FD20
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression>(expression, "expression");
			bool flag = this.VisitExpression(expression.Input.Expression);
			bool flag2 = this.VisitExpressionList(expression.Keys);
			bool flag3 = this.VisitAggregateList(expression.Aggregates);
			return flag || flag2 || flag3;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00011B68 File Offset: 0x0000FD68
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression>(expression, "expression");
			this.VisitExpression(expression.Left);
			this.VisitExpression(expression.Right);
			return true;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00011B91 File Offset: 0x0000FD91
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00011BA6 File Offset: 0x0000FDA6
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00011BBB File Offset: 0x0000FDBB
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00011BD0 File Offset: 0x0000FDD0
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression>(expression, "expression");
			bool flag = this.VisitExpressionBinding(expression.Left);
			bool flag2 = this.VisitExpressionBinding(expression.Right);
			bool flag3 = this.VisitExpression(expression.JoinCondition);
			return flag || flag2 || flag3;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00011C14 File Offset: 0x0000FE14
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression>(expression, "expression");
			bool flag = this.VisitExpression(expression.Argument);
			bool flag2 = this.VisitExpression(expression.Pattern);
			bool flag3 = this.VisitExpression(expression.Escape);
			return flag || flag2 || flag3;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00011C57 File Offset: 0x0000FE57
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression>(expression, "expression");
			if (expression.Limit is global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_ParameterForLimitNotSupportedOnSql8);
			}
			return this.VisitExpression(expression.Argument);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00011C89 File Offset: 0x0000FE89
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>(expression, "expression");
			return this.VisitExpressionList(expression.Arguments);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00011CA3 File Offset: 0x0000FEA3
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression>(expression, "expression");
			return false;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00011CC7 File Offset: 0x0000FEC7
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00011CDC File Offset: 0x0000FEDC
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression>(expression, "expression");
			return this.VisitBinaryExpression(expression);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00011CF1 File Offset: 0x0000FEF1
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression>(expression, "expression");
			return this.VisitExpression(expression.Item) || this.VisitExpressionList(expression.List);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00011D1B File Offset: 0x0000FF1B
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(expression, "expression");
			return false;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00011D2C File Offset: 0x0000FF2C
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression>(expression, "expression");
			bool flag = this.VisitExpressionBinding(expression.Input);
			bool flag2 = this.VisitExpression(expression.Projection);
			return flag || flag2;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00011D60 File Offset: 0x0000FF60
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(expression, "expression");
			return this.VisitExpression(expression.Instance);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00011D7C File Offset: 0x0000FF7C
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression>(expression, "expression");
			bool flag = this.VisitExpressionBinding(expression.Input);
			bool flag2 = this.VisitExpression(expression.Predicate);
			return flag || flag2;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00011DB0 File Offset: 0x0000FFB0
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00011DC5 File Offset: 0x0000FFC5
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00011DDA File Offset: 0x0000FFDA
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression>(expression, "expression");
			return this.VisitExpression(expression.NavigationSource);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00011DF4 File Offset: 0x0000FFF4
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(expression, "expression");
			return false;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00011E04 File Offset: 0x00010004
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression>(expression, "expression");
			if (expression.Count is global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_ParameterForSkipNotSupportedOnSql8);
			}
			this.VisitExpressionBinding(expression.Input);
			this.VisitSortClauseList(expression.SortOrder);
			this.VisitExpression(expression.Count);
			return true;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00011E60 File Offset: 0x00010060
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(expression, "expression");
			bool flag = this.VisitExpressionBinding(expression.Input);
			bool flag2 = this.VisitSortClauseList(expression.SortOrder);
			return flag || flag2;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00011E94 File Offset: 0x00010094
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression>(expression, "expression");
			return this.VisitUnaryExpression(expression);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00011EA9 File Offset: 0x000100A9
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression>(expression, "expression");
			return this.VisitBinaryExpression(expression);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00011EBE File Offset: 0x000100BE
		public override bool Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(expression, "expression");
			return false;
		}

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060006FD RID: 1789
		private delegate bool ListElementHandler<TElementType>(TElementType element);
	}
}
