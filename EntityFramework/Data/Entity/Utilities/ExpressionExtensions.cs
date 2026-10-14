using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Resources;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Utilities
{
	// Token: 0x0200007E RID: 126
	internal static class ExpressionExtensions
	{
		// Token: 0x06000447 RID: 1095 RVA: 0x0000EE10 File Offset: 0x0000D010
		public static global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath GetSimplePropertyAccess(this global::System.Linq.Expressions.LambdaExpression propertyAccessExpression)
		{
			global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath = propertyAccessExpression.Parameters.Single<global::System.Linq.Expressions.ParameterExpression>().MatchSimplePropertyAccess(propertyAccessExpression.Body);
			if (propertyPath == null)
			{
				throw global::System.Data.Entity.Resources.Error.InvalidPropertyExpression(propertyAccessExpression);
			}
			return propertyPath;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000EE38 File Offset: 0x0000D038
		public static global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath GetComplexPropertyAccess(this global::System.Linq.Expressions.LambdaExpression propertyAccessExpression)
		{
			global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath = propertyAccessExpression.Parameters.Single<global::System.Linq.Expressions.ParameterExpression>().MatchComplexPropertyAccess(propertyAccessExpression.Body);
			if (propertyPath == null)
			{
				throw global::System.Data.Entity.Resources.Error.InvalidComplexPropertyExpression(propertyAccessExpression);
			}
			return propertyPath;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000EE60 File Offset: 0x0000D060
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> GetSimplePropertyAccessList(this global::System.Linq.Expressions.LambdaExpression propertyAccessExpression)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> enumerable = propertyAccessExpression.MatchPropertyAccessList((global::System.Linq.Expressions.Expression p, global::System.Linq.Expressions.Expression e) => e.MatchSimplePropertyAccess(p));
			if (enumerable == null)
			{
				throw global::System.Data.Entity.Resources.Error.InvalidPropertiesExpression(propertyAccessExpression);
			}
			return enumerable;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000EE91 File Offset: 0x0000D091
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> GetComplexPropertyAccessList(this global::System.Linq.Expressions.LambdaExpression propertyAccessExpression)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> enumerable = propertyAccessExpression.MatchPropertyAccessList((global::System.Linq.Expressions.Expression p, global::System.Linq.Expressions.Expression e) => e.MatchComplexPropertyAccess(p));
			if (enumerable == null)
			{
				throw global::System.Data.Entity.Resources.Error.InvalidComplexPropertiesExpression(propertyAccessExpression);
			}
			return enumerable;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> MatchPropertyAccessList(this global::System.Linq.Expressions.LambdaExpression lambdaExpression, global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression, global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> propertyMatcher)
		{
			global::System.Linq.Expressions.NewExpression newExpression = lambdaExpression.Body.RemoveConvert() as global::System.Linq.Expressions.NewExpression;
			if (newExpression != null)
			{
				global::System.Linq.Expressions.ParameterExpression parameterExpression = lambdaExpression.Parameters.Single<global::System.Linq.Expressions.ParameterExpression>();
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> enumerable = from a in newExpression.Arguments
				select propertyMatcher(a, parameterExpression) into p
				where p != null
				select p;
				if (enumerable.Count<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath>() == newExpression.Arguments.Count<global::System.Linq.Expressions.Expression>())
				{
					if (!newExpression.HasDefaultMembersOnly(enumerable))
					{
						return null;
					}
					return enumerable;
				}
			}
			global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath = propertyMatcher(lambdaExpression.Body, lambdaExpression.Parameters.Single<global::System.Linq.Expressions.ParameterExpression>());
			if (!(propertyPath != null))
			{
				return null;
			}
			return new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath[]
			{
				propertyPath
			};
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000EF94 File Offset: 0x0000D194
		private static bool HasDefaultMembersOnly(this global::System.Linq.Expressions.NewExpression newExpression, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> propertyPaths)
		{
			return newExpression.Members == null || !newExpression.Members.Where((global::System.Reflection.MemberInfo t, int i) => !string.Equals(t.Name, propertyPaths.ElementAt(i).Last<global::System.Reflection.PropertyInfo>().Name, global::System.StringComparison.Ordinal)).Any<global::System.Reflection.MemberInfo>();
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000EFD8 File Offset: 0x0000D1D8
		private static global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath MatchSimplePropertyAccess(this global::System.Linq.Expressions.Expression parameterExpression, global::System.Linq.Expressions.Expression propertyAccessExpression)
		{
			global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath = parameterExpression.MatchPropertyAccess(propertyAccessExpression);
			if (!(propertyPath != null) || propertyPath.Count != 1)
			{
				return null;
			}
			return propertyPath;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000F002 File Offset: 0x0000D202
		private static global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath MatchComplexPropertyAccess(this global::System.Linq.Expressions.Expression parameterExpression, global::System.Linq.Expressions.Expression propertyAccessExpression)
		{
			return parameterExpression.MatchPropertyAccess(propertyAccessExpression);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000F00C File Offset: 0x0000D20C
		private static global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath MatchPropertyAccess(this global::System.Linq.Expressions.Expression parameterExpression, global::System.Linq.Expressions.Expression propertyAccessExpression)
		{
			global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> list = new global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo>();
			for (;;)
			{
				global::System.Linq.Expressions.MemberExpression memberExpression = propertyAccessExpression.RemoveConvert() as global::System.Linq.Expressions.MemberExpression;
				if (memberExpression == null)
				{
					break;
				}
				global::System.Reflection.PropertyInfo propertyInfo = memberExpression.Member as global::System.Reflection.PropertyInfo;
				if (propertyInfo == null)
				{
					goto Block_2;
				}
				list.Insert(0, propertyInfo);
				propertyAccessExpression = memberExpression.Expression;
				if (memberExpression.Expression == parameterExpression)
				{
					goto Block_3;
				}
			}
			return null;
			Block_2:
			return null;
			Block_3:
			return new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(list);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000F066 File Offset: 0x0000D266
		public static global::System.Linq.Expressions.Expression RemoveConvert(this global::System.Linq.Expressions.Expression expression)
		{
			while (expression.NodeType == global::System.Linq.Expressions.ExpressionType.Convert || expression.NodeType == global::System.Linq.Expressions.ExpressionType.ConvertChecked)
			{
				expression = ((global::System.Linq.Expressions.UnaryExpression)expression).Operand;
			}
			return expression;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000F08C File Offset: 0x0000D28C
		public static bool IsNullConstant(this global::System.Linq.Expressions.Expression expression)
		{
			expression = expression.RemoveConvert();
			return expression.NodeType == global::System.Linq.Expressions.ExpressionType.Constant && ((global::System.Linq.Expressions.ConstantExpression)expression).Value == null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
		public static bool IsStringAddExpression(this global::System.Linq.Expressions.Expression expression)
		{
			global::System.Linq.Expressions.BinaryExpression binaryExpression = expression as global::System.Linq.Expressions.BinaryExpression;
			return binaryExpression != null && !(binaryExpression.Method == null) && binaryExpression.NodeType == global::System.Linq.Expressions.ExpressionType.Add && binaryExpression.Method.DeclaringType == typeof(string) && string.Equals(binaryExpression.Method.Name, "Concat", global::System.StringComparison.Ordinal);
		}
	}
}
