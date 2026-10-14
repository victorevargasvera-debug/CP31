using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.SqlServer.Utilities;
using System.Globalization;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x02000034 RID: 52
	internal class Sql8ExpressionRewriter : global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionRebinder
	{
		// Token: 0x060004A0 RID: 1184 RVA: 0x00011ED0 File Offset: 0x000100D0
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree Rewrite(global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree originalTree)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query = new global::System.Data.Entity.SqlServer.SqlGen.Sql8ExpressionRewriter(originalTree.MetadataWorkspace).VisitExpression(originalTree.Query);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree(originalTree.MetadataWorkspace, originalTree.DataSpace, query, false);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00011F07 File Offset: 0x00010107
		private Sql8ExpressionRewriter(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata) : base(metadata)
		{
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00011F10 File Offset: 0x00010110
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression>(e, "e");
			return this.TransformIntersectOrExcept(this.VisitExpression(e.Left), this.VisitExpression(e.Right), global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Except);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00011F3E File Offset: 0x0001013E
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression>(e, "e");
			return this.TransformIntersectOrExcept(this.VisitExpression(e.Left), this.VisitExpression(e.Right), global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Intersect);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00011F6C File Offset: 0x0001016C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression>(e, "e");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right = this.VisitExpressionBinding(e.Input).Sort(this.VisitSortOrder(e.SortOrder)).Limit(this.VisitExpression(e.Count));
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left = this.VisitExpression(e.Input.Expression);
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> list = this.VisitSortOrder(e.SortOrder);
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(e.SortOrder.Count);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause dbSortClause in list)
			{
				if (dbSortClause.Expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)
				{
					list2.Add((global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)dbSortClause.Expression);
				}
			}
			return this.TransformIntersectOrExcept(left, right, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Skip, list2, e.Input.VariableName).BindAs(e.Input.VariableName).Sort(list);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001206C File Offset: 0x0001026C
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TransformIntersectOrExcept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind)
		{
			return this.TransformIntersectOrExcept(left, right, expressionKind, null, null);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0001207C File Offset: 0x0001027C
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression TransformIntersectOrExcept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> sortExpressionsOverLeft, string sortExpressionsBindingVariableName)
		{
			bool flag = expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Except || expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Skip;
			bool flag2 = expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Except || expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Intersect;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = left.Bind();
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2 = right.Bind();
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>();
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>();
			this.FlattenProperties(dbExpressionBinding.Variable, list);
			this.FlattenProperties(dbExpressionBinding2.Variable, list2);
			if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Skip && global::System.Data.Entity.SqlServer.SqlGen.Sql8ExpressionRewriter.RemoveNonSortProperties(list, list2, sortExpressionsOverLeft, dbExpressionBinding.VariableName, sortExpressionsBindingVariableName))
			{
				dbExpressionBinding2 = global::System.Data.Entity.SqlServer.SqlGen.Sql8ExpressionRewriter.CapWithProject(dbExpressionBinding2, list2);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = null;
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left2 = list[i].Equal(list2[i]);
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left3 = list[i].IsNull();
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right2 = list2[i].IsNull();
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right3 = left3.And(right2);
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = left2.Or(right3);
				if (i == 0)
				{
					dbExpression = dbExpression2;
				}
				else
				{
					dbExpression = dbExpression.And(dbExpression2);
				}
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = dbExpressionBinding2.Any(dbExpression);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate;
			if (flag)
			{
				predicate = dbExpression3.Not();
			}
			else
			{
				predicate = dbExpression3;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression4 = dbExpressionBinding.Filter(predicate);
			if (flag2)
			{
				dbExpression4 = dbExpression4.Distinct();
			}
			return dbExpression4;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000121AC File Offset: 0x000103AC
		private void FlattenProperties(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> flattenedProperties)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in input.ResultType.GetProperties())
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = input.Property(edmProperty);
				if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType == edmProperty.TypeUsage.EdmType.BuiltInTypeKind)
				{
					flattenedProperties.Add(dbPropertyExpression);
				}
				else
				{
					this.FlattenProperties(dbPropertyExpression, flattenedProperties);
				}
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00012224 File Offset: 0x00010424
		private static bool RemoveNonSortProperties(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> list1, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> list2, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> sortList, string list1BindingVariableName, string sortExpressionsBindingVariableName)
		{
			bool result = false;
			for (int i = list1.Count - 1; i >= 0; i--)
			{
				if (!global::System.Data.Entity.SqlServer.SqlGen.Sql8ExpressionRewriter.HasMatchInList(list1[i], sortList, list1BindingVariableName, sortExpressionsBindingVariableName))
				{
					list1.RemoveAt(i);
					list2.RemoveAt(i);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001226C File Offset: 0x0001046C
		private static bool HasMatchInList(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expr, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> list, string exprBindingVariableName, string listExpressionsBindingVariableName)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (global::System.Data.Entity.SqlServer.SqlGen.Sql8ExpressionRewriter.AreMatching(expr, list[i], exprBindingVariableName, listExpressionsBindingVariableName))
				{
					list.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000122A8 File Offset: 0x000104A8
		private static bool AreMatching(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expr1, global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expr2, string expr1BindingVariableName, string expr2BindingVariableName)
		{
			if (expr1.Property.Name != expr2.Property.Name)
			{
				return false;
			}
			if (expr1.Instance.ExpressionKind != expr2.Instance.ExpressionKind)
			{
				return false;
			}
			if (expr1.Instance.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)
			{
				return global::System.Data.Entity.SqlServer.SqlGen.Sql8ExpressionRewriter.AreMatching((global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)expr1.Instance, (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)expr2.Instance, expr1BindingVariableName, expr2BindingVariableName);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression dbVariableReferenceExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)expr1.Instance;
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression dbVariableReferenceExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)expr2.Instance;
			return string.Equals(dbVariableReferenceExpression.VariableName, expr1BindingVariableName, global::System.StringComparison.Ordinal) && string.Equals(dbVariableReferenceExpression2.VariableName, expr2BindingVariableName, global::System.StringComparison.Ordinal);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00012350 File Offset: 0x00010550
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding CapWithProject(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding inputBinding, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> flattenedProperties)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(flattenedProperties.Count);
			global::System.Collections.Generic.Dictionary<string, int> dictionary = new global::System.Collections.Generic.Dictionary<string, int>(flattenedProperties.Count);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression in flattenedProperties)
			{
				string text = dbPropertyExpression.Property.Name;
				int num;
				if (dictionary.TryGetValue(text, out num))
				{
					string text2;
					do
					{
						num++;
						text2 = text + num.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
					}
					while (dictionary.ContainsKey(text2));
					dictionary[text] = num;
					text = text2;
				}
				dictionary[text] = 0;
				list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(text, dbPropertyExpression));
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(list);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = inputBinding.Project(dbExpression).Bind();
			flattenedProperties.Clear();
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)dbExpression.ResultType.EdmType;
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValuePair in list)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty propertyMetadata = rowType.Properties[keyValuePair.Key];
				flattenedProperties.Add(dbExpressionBinding.Variable.Property(propertyMetadata));
			}
			return dbExpressionBinding;
		}
	}
}
