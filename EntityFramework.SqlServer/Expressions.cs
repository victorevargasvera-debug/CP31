using System;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000006 RID: 6
	internal static class Expressions
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002475 File Offset: 0x00000675
		internal static global::System.Linq.Expressions.Expression Null<TNullType>()
		{
			return global::System.Linq.Expressions.Expression.Constant(null, typeof(TNullType));
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002487 File Offset: 0x00000687
		internal static global::System.Linq.Expressions.Expression Null(global::System.Type nullType)
		{
			return global::System.Linq.Expressions.Expression.Constant(null, nullType);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002490 File Offset: 0x00000690
		internal static global::System.Linq.Expressions.Expression<global::System.Func<TArg, TResult>> Lambda<TArg, TResult>(string argumentName, global::System.Func<global::System.Linq.Expressions.ParameterExpression, global::System.Linq.Expressions.Expression> createLambdaBodyGivenParameter)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TArg), argumentName);
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TArg, TResult>>(createLambdaBodyGivenParameter(parameterExpression), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000024C4 File Offset: 0x000006C4
		internal static global::System.Linq.Expressions.Expression Call(this global::System.Linq.Expressions.Expression exp, string methodName)
		{
			return global::System.Linq.Expressions.Expression.Call(exp, methodName, global::System.Type.EmptyTypes, new global::System.Linq.Expressions.Expression[0]);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000024D8 File Offset: 0x000006D8
		internal static global::System.Linq.Expressions.Expression ConvertTo(this global::System.Linq.Expressions.Expression exp, global::System.Type convertToType)
		{
			return global::System.Linq.Expressions.Expression.Convert(exp, convertToType);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000024E1 File Offset: 0x000006E1
		internal static global::System.Linq.Expressions.Expression ConvertTo<TConvertToType>(this global::System.Linq.Expressions.Expression exp)
		{
			return global::System.Linq.Expressions.Expression.Convert(exp, typeof(TConvertToType));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000024F3 File Offset: 0x000006F3
		internal static global::System.Data.Entity.SqlServer.Expressions.ConditionalExpressionBuilder IfTrueThen(this global::System.Linq.Expressions.Expression conditionExp, global::System.Linq.Expressions.Expression resultIfTrue)
		{
			return new global::System.Data.Entity.SqlServer.Expressions.ConditionalExpressionBuilder(conditionExp, resultIfTrue);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000024FC File Offset: 0x000006FC
		internal static global::System.Linq.Expressions.Expression Property<TPropertyType>(this global::System.Linq.Expressions.Expression exp, string propertyName)
		{
			global::System.Reflection.PropertyInfo runtimeProperty = exp.Type.GetRuntimeProperty(propertyName);
			return global::System.Linq.Expressions.Expression.Property(exp, runtimeProperty);
		}

		// Token: 0x02000048 RID: 72
		internal sealed class ConditionalExpressionBuilder
		{
			// Token: 0x06000614 RID: 1556 RVA: 0x0001A846 File Offset: 0x00018A46
			internal ConditionalExpressionBuilder(global::System.Linq.Expressions.Expression conditionExpression, global::System.Linq.Expressions.Expression ifTrueExpression)
			{
				this.condition = conditionExpression;
				this.ifTrueThen = ifTrueExpression;
			}

			// Token: 0x06000615 RID: 1557 RVA: 0x0001A85C File Offset: 0x00018A5C
			internal global::System.Linq.Expressions.Expression Else(global::System.Linq.Expressions.Expression resultIfFalse)
			{
				return global::System.Linq.Expressions.Expression.Condition(this.condition, this.ifTrueThen, resultIfFalse);
			}

			// Token: 0x04000164 RID: 356
			private readonly global::System.Linq.Expressions.Expression condition;

			// Token: 0x04000165 RID: 357
			private readonly global::System.Linq.Expressions.Expression ifTrueThen;
		}
	}
}
