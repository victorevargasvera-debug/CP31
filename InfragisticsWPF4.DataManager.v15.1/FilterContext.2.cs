using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Infragistics
{
	// Token: 0x02000006 RID: 6
	public class FilterContext<TDataObject> : global::Infragistics.FilterContext
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002561 File Offset: 0x00000761
		public FilterContext(global::System.Type fieldDataType, bool caseSensitive, bool fromDateColumn, global::Infragistics.CachedTypedInfo cti)
		{
			base.CaseSensitive = caseSensitive;
			base.FieldDataType = fieldDataType;
			base.FromDateColumn = fromDateColumn;
			base.CachedTypedInfo = cti;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002588 File Offset: 0x00000788
		internal override global::System.Linq.Expressions.Expression And(global::System.Linq.Expressions.Expression left, global::System.Linq.Expressions.Expression right)
		{
			global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> left2 = (global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>>)left;
			global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> right2 = (global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>>)right;
			return this.AndAlsoExpression<TDataObject>(left2, right2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000025AC File Offset: 0x000007AC
		internal override global::System.Linq.Expressions.Expression Or(global::System.Linq.Expressions.Expression left, global::System.Linq.Expressions.Expression right)
		{
			global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> left2 = (global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>>)left;
			global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> right2 = (global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>>)right;
			return this.OrElseExpression<TDataObject>(left2, right2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000025D0 File Offset: 0x000007D0
		protected internal global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> OrElseExpression<TDataObjectType>(global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> left, global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> right)
		{
			global::System.Linq.Expressions.InvocationExpression right2 = global::System.Linq.Expressions.Expression.Invoke(right, left.Parameters.Cast<global::System.Linq.Expressions.Expression>());
			global::System.Linq.Expressions.Expression body = global::System.Linq.Expressions.Expression.OrElse(left.Body, right2);
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(body, left.Parameters);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002608 File Offset: 0x00000808
		protected internal global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> AndAlsoExpression<TDataObjectType>(global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> left, global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> right)
		{
			global::System.Linq.Expressions.InvocationExpression right2 = global::System.Linq.Expressions.Expression.Invoke(right, left.Parameters.Cast<global::System.Linq.Expressions.Expression>());
			global::System.Linq.Expressions.Expression body = global::System.Linq.Expressions.Expression.AndAlso(left.Body, right2);
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(body, left.Parameters);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002640 File Offset: 0x00000840
		protected internal global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> ExclusiveOrExpression<TDataObjectType>(global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> left, global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> right)
		{
			global::System.Linq.Expressions.InvocationExpression right2 = global::System.Linq.Expressions.Expression.Invoke(right, left.Parameters.Cast<global::System.Linq.Expressions.Expression>());
			global::System.Linq.Expressions.Expression body = global::System.Linq.Expressions.Expression.ExclusiveOr(left.Body, right2);
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(body, left.Parameters);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002678 File Offset: 0x00000878
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateDateTimeTimeExcludedEqualsExpression<TDataObjectType>(string fieldName, object value)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TDataObjectType), "parameter");
			global::System.Linq.Expressions.Expression left = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(fieldName, parameterExpression, base.CachedTypedInfo, base.FieldDataType, this.GetDefaultValue());
			global::System.Linq.Expressions.Expression right = global::System.Linq.Expressions.Expression.Constant(value, base.FieldDataType);
			global::System.Linq.Expressions.Expression expression;
			if (value != null)
			{
				global::System.Linq.Expressions.Expression left2 = global::System.Linq.Expressions.Expression.GreaterThanOrEqual(left, right);
				global::System.DateTime dateTime = ((global::System.DateTime)value).AddDays(1.0);
				right = global::System.Linq.Expressions.Expression.Constant(dateTime, base.FieldDataType);
				global::System.Linq.Expressions.Expression right2 = global::System.Linq.Expressions.Expression.LessThan(left, right);
				expression = global::System.Linq.Expressions.Expression.AndAlso(left2, right2);
			}
			else
			{
				expression = global::System.Linq.Expressions.Expression.Equal(left, right);
			}
			if (!typeof(TDataObject).IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, typeof(TDataObject)));
				expression = global::System.Linq.Expressions.Expression.Condition(test, global::System.Linq.Expressions.Expression.Constant(false), expression);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000276C File Offset: 0x0000096C
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateEqualsExpression<TDataObjectType>(string fieldName, object value)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TDataObjectType), "parameter");
			global::System.Linq.Expressions.Expression expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(fieldName, parameterExpression, base.CachedTypedInfo, base.FieldDataType, this.GetDefaultValue());
			global::System.Linq.Expressions.Expression expression2 = global::System.Linq.Expressions.Expression.Constant(value, base.FieldDataType);
			global::System.Linq.Expressions.Expression expression3;
			if (base.FromDateColumn && value != null)
			{
				global::System.Linq.Expressions.Expression left = global::System.Linq.Expressions.Expression.GreaterThanOrEqual(expression, expression2);
				global::System.DateTime dateTime = ((global::System.DateTime)value).AddDays(1.0);
				expression2 = global::System.Linq.Expressions.Expression.Constant(dateTime, base.FieldDataType);
				global::System.Linq.Expressions.Expression right = global::System.Linq.Expressions.Expression.LessThan(expression, expression2);
				expression3 = global::System.Linq.Expressions.Expression.AndAlso(left, right);
			}
			else if (!expression.Type.IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(expression, global::System.Linq.Expressions.Expression.Constant(null, expression.Type));
				expression3 = global::System.Linq.Expressions.Expression.Condition(test, global::System.Linq.Expressions.Expression.Equal(expression, expression2), global::System.Linq.Expressions.Expression.Call(expression, global::Infragistics.FilterContext<TDataObject>.EqualsMethod, new global::System.Linq.Expressions.Expression[]
				{
					expression2
				}));
			}
			else
			{
				expression3 = global::System.Linq.Expressions.Expression.Equal(expression, expression2);
			}
			if (!typeof(TDataObject).IsValueType)
			{
				global::System.Linq.Expressions.Expression test2 = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, typeof(TDataObject)));
				expression3 = global::System.Linq.Expressions.Expression.Condition(test2, global::System.Linq.Expressions.Expression.Constant(false), expression3);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(expression3, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000028B4 File Offset: 0x00000AB4
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateNotEqualsExpression<TDataObjectType>(string fieldName, object value)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TDataObjectType), "parameter");
			global::System.Linq.Expressions.Expression expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(fieldName, parameterExpression, base.CachedTypedInfo, base.FieldDataType, this.GetDefaultValue());
			global::System.Linq.Expressions.Expression expression2 = global::System.Linq.Expressions.Expression.Constant(value, base.FieldDataType);
			global::System.Linq.Expressions.Expression expression3;
			if (base.FromDateColumn && value != null)
			{
				global::System.Linq.Expressions.Expression left = global::System.Linq.Expressions.Expression.GreaterThanOrEqual(expression, expression2);
				global::System.DateTime dateTime = ((global::System.DateTime)value).AddDays(1.0);
				expression2 = global::System.Linq.Expressions.Expression.Constant(dateTime, base.FieldDataType);
				global::System.Linq.Expressions.Expression right = global::System.Linq.Expressions.Expression.LessThan(expression, expression2);
				expression3 = global::System.Linq.Expressions.Expression.AndAlso(left, right);
				expression3 = global::System.Linq.Expressions.Expression.Not(expression3);
			}
			else if (!expression.Type.IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(expression, global::System.Linq.Expressions.Expression.Constant(null, expression.Type));
				expression3 = global::System.Linq.Expressions.Expression.Condition(test, global::System.Linq.Expressions.Expression.NotEqual(expression, expression2), global::System.Linq.Expressions.Expression.Not(global::System.Linq.Expressions.Expression.Call(expression, global::Infragistics.FilterContext<TDataObject>.EqualsMethod, new global::System.Linq.Expressions.Expression[]
				{
					expression2
				})));
			}
			else
			{
				expression3 = global::System.Linq.Expressions.Expression.NotEqual(expression, expression2);
			}
			if (!typeof(TDataObject).IsValueType)
			{
				global::System.Linq.Expressions.Expression test2 = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, typeof(TDataObject)));
				expression3 = global::System.Linq.Expressions.Expression.Condition(test2, global::System.Linq.Expressions.Expression.Constant(false), expression3);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(expression3, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002A08 File Offset: 0x00000C08
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateGreaterThanExpression<TDataObjectType>(string fieldName, object value)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TDataObject), "parameter");
			global::System.Linq.Expressions.Expression left = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(fieldName, parameterExpression, base.CachedTypedInfo, base.FieldDataType, this.GetDefaultValue());
			global::System.Linq.Expressions.Expression right = global::System.Linq.Expressions.Expression.Constant(value, base.FieldDataType);
			global::System.Linq.Expressions.Expression expression2;
			if (base.FromDateColumn && value != null)
			{
				global::System.DateTime dateTime = ((global::System.DateTime)value).AddDays(1.0);
				right = global::System.Linq.Expressions.Expression.Constant(dateTime, base.FieldDataType);
				global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.GreaterThanOrEqual(left, right);
				expression2 = expression;
			}
			else
			{
				expression2 = global::System.Linq.Expressions.Expression.GreaterThan(left, right);
			}
			if (!typeof(TDataObject).IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, typeof(TDataObject)));
				expression2 = global::System.Linq.Expressions.Expression.Condition(test, global::System.Linq.Expressions.Expression.Constant(false), expression2);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(expression2, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002AF4 File Offset: 0x00000CF4
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateGreaterThanOrEqualsExpression<TDataObjectType>(string fieldName, object value)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TDataObject), "parameter");
			global::System.Linq.Expressions.Expression left = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(fieldName, parameterExpression, base.CachedTypedInfo, base.FieldDataType, this.GetDefaultValue());
			global::System.Linq.Expressions.Expression right = global::System.Linq.Expressions.Expression.Constant(value, base.FieldDataType);
			global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.GreaterThanOrEqual(left, right);
			if (!typeof(TDataObject).IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, typeof(TDataObject)));
				expression = global::System.Linq.Expressions.Expression.Condition(test, global::System.Linq.Expressions.Expression.Constant(false), expression);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002B9C File Offset: 0x00000D9C
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateLessThanExpression<TDataObjectType>(string fieldName, object value)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TDataObject), "parameter");
			global::System.Linq.Expressions.Expression left = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(fieldName, parameterExpression, base.CachedTypedInfo, base.FieldDataType, this.GetDefaultValue());
			global::System.Linq.Expressions.Expression right = global::System.Linq.Expressions.Expression.Constant(value, base.FieldDataType);
			global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.LessThan(left, right);
			if (!typeof(TDataObject).IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, typeof(TDataObject)));
				expression = global::System.Linq.Expressions.Expression.Condition(test, global::System.Linq.Expressions.Expression.Constant(false), expression);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002C44 File Offset: 0x00000E44
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateLessThanOrEqualsExpression<TDataObjectType>(string fieldName, object value)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TDataObject), "parameter");
			global::System.Linq.Expressions.Expression left = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(fieldName, parameterExpression, base.CachedTypedInfo, base.FieldDataType, this.GetDefaultValue());
			global::System.Linq.Expressions.Expression right = global::System.Linq.Expressions.Expression.Constant(value, base.FieldDataType);
			global::System.Linq.Expressions.Expression expression2;
			if (base.FromDateColumn && value != null)
			{
				global::System.DateTime dateTime = ((global::System.DateTime)value).AddDays(1.0);
				right = global::System.Linq.Expressions.Expression.Constant(dateTime, base.FieldDataType);
				global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.LessThan(left, right);
				expression2 = expression;
			}
			else
			{
				expression2 = global::System.Linq.Expressions.Expression.LessThanOrEqual(left, right);
			}
			if (!typeof(TDataObject).IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, typeof(TDataObject)));
				expression2 = global::System.Linq.Expressions.Expression.Condition(test, global::System.Linq.Expressions.Expression.Constant(false), expression2);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(expression2, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002D30 File Offset: 0x00000F30
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStringExpression<TDataObjectType>(string fieldName, global::System.Linq.Expressions.Expression<global::System.Func<string, bool>> booleanStringExpression)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TDataObject), "parameter");
			global::System.Linq.Expressions.Expression expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(fieldName, parameterExpression, base.CachedTypedInfo, base.FieldDataType, this.GetDefaultValue());
			global::System.Linq.Expressions.Expression expression2 = global::System.Linq.Expressions.Expression.Invoke(booleanStringExpression, new global::System.Linq.Expressions.Expression[]
			{
				expression
			});
			if (!typeof(TDataObject).IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, typeof(TDataObject)));
				expression2 = global::System.Linq.Expressions.Expression.Condition(test, global::System.Linq.Expressions.Expression.Constant(false), expression2);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(expression2, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002DDC File Offset: 0x00000FDC
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateEqualsCaseInsensitiveExpression<TDataObjectType>(string fieldName, string value)
		{
			if (!string.IsNullOrEmpty(value))
			{
				return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x != null && x.Equals(value, global::System.StringComparison.CurrentCultureIgnoreCase));
			}
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => string.IsNullOrEmpty(x));
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002F08 File Offset: 0x00001108
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateNotEqualsCaseInsensitiveExpression<TDataObjectType>(string fieldName, string value)
		{
			if (!string.IsNullOrEmpty(value))
			{
				return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x == null || !x.Equals(value, global::System.StringComparison.CurrentCultureIgnoreCase));
			}
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => !string.IsNullOrEmpty(x));
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000303C File Offset: 0x0000123C
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStartsWithExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x != null && x.StartsWith(value));
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000030E8 File Offset: 0x000012E8
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStartsWithCaseInsensitiveExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x != null && x.StartsWith(value, global::System.StringComparison.CurrentCultureIgnoreCase));
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000031AC File Offset: 0x000013AC
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateEndsWithExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x != null && x.EndsWith(value));
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003258 File Offset: 0x00001458
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateEndsWithCaseInsensitiveExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x != null && x.EndsWith(value, global::System.StringComparison.CurrentCultureIgnoreCase));
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000331C File Offset: 0x0000151C
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateContainsExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x != null && x.Contains(value));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000033C8 File Offset: 0x000015C8
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateContainsCaseInsensitiveExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x != null && x.IndexOf(value, global::System.StringComparison.CurrentCultureIgnoreCase) >= 0);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000034A4 File Offset: 0x000016A4
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateDoesNotContainExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x == null || !x.Contains(value));
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003554 File Offset: 0x00001754
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateDoesNotContainCaseInsensitiveExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x == null || x.IndexOf(value, global::System.StringComparison.CurrentCultureIgnoreCase) == -1);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003630 File Offset: 0x00001830
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStringGreaterThanExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x != null && 1 == x.CompareTo(value));
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000036F4 File Offset: 0x000018F4
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStringGreaterThanCaseInsensitiveExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x != null && 1 == global::System.StringComparer.CurrentCultureIgnoreCase.Compare(x, value));
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000037D0 File Offset: 0x000019D0
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStringGreaterThanOrEqualExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x != null && -1 != x.CompareTo(value));
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003894 File Offset: 0x00001A94
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStringGreaterThanOrEqualCaseInsensitiveExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x != null && -1 != global::System.StringComparer.CurrentCultureIgnoreCase.Compare(x, value));
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003970 File Offset: 0x00001B70
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStringLessThanExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x == null || -1 == x.CompareTo(value));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003A34 File Offset: 0x00001C34
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStringLessThanCaseInsensitiveExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x == null || -1 == global::System.StringComparer.CurrentCultureIgnoreCase.Compare(x, value));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003B10 File Offset: 0x00001D10
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStringLessThanOrEqualExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x == null || 1 != x.CompareTo(value));
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003BD4 File Offset: 0x00001DD4
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStringLessThanOrEqualCaseInsensitiveExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x == null || 1 != global::System.StringComparer.CurrentCultureIgnoreCase.Compare(x, value));
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003CA8 File Offset: 0x00001EA8
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStringEmptyExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => string.IsNullOrEmpty(x));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003D04 File Offset: 0x00001F04
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStringNotEmptyExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => !string.IsNullOrEmpty(x));
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003D6C File Offset: 0x00001F6C
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateDoesNotStartWithExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x == null || !x.StartsWith(value));
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003E1C File Offset: 0x0000201C
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateDoesNotStartWithCaseInsensitiveExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x == null || !x.StartsWith(value, global::System.StringComparison.CurrentCultureIgnoreCase));
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003EE4 File Offset: 0x000020E4
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateDoesNotEndWithExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x == null || !x.EndsWith(value));
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003F94 File Offset: 0x00002194
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateDoesNotEndWithCaseInsensitiveExpression<TDataObjectType>(string fieldName, string value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => x == null || !x.EndsWith(value, global::System.StringComparison.CurrentCultureIgnoreCase));
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004054 File Offset: 0x00002254
		public override global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.ConditionCollection conditionGroup)
		{
			global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> expression = null;
			if (conditionGroup.Count > 0)
			{
				expression = (global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>>)conditionGroup[0].GetCurrentExpression(this);
				for (int i = 1; i < conditionGroup.Count; i++)
				{
					global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> expression2 = (global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>>)conditionGroup[i].GetCurrentExpression(this);
					if (expression == null)
					{
						expression = expression2;
					}
					else if (expression2 != null)
					{
						if (conditionGroup.LogicalOperator == global::Infragistics.LogicalOperator.Or)
						{
							expression = this.OrElseExpression<TDataObject>(expression, expression2);
						}
						else
						{
							expression = this.AndAlsoExpression<TDataObject>(expression, expression2);
						}
					}
				}
			}
			return expression;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000040D0 File Offset: 0x000022D0
		public override global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.RecordFilterCollection conditionGroup)
		{
			global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> expression = null;
			if (conditionGroup.Count > 0)
			{
				expression = (global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>>)conditionGroup[0].GetCurrentExpression();
				for (int i = 1; i < conditionGroup.Count; i++)
				{
					global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> expression2 = (global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>>)conditionGroup[i].GetCurrentExpression();
					if (expression == null)
					{
						expression = expression2;
					}
					else if (expression2 != null)
					{
						if (conditionGroup.LogicalOperator == global::Infragistics.LogicalOperator.Or)
						{
							expression = this.OrElseExpression<TDataObject>(expression, expression2);
						}
						else
						{
							expression = this.AndAlsoExpression<TDataObject>(expression, expression2);
						}
					}
				}
			}
			return expression;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004147 File Offset: 0x00002347
		public override global::System.Linq.Expressions.Expression CreateExpression(string fieldName, global::Infragistics.ComparisonOperator op, object value)
		{
			if (!(base.FieldDataType == typeof(string)))
			{
				return this.CreateObjectExpression(fieldName, op, value);
			}
			if (base.CaseSensitive)
			{
				return this.CreateCaseSensitiveStringExpression(fieldName, op, value);
			}
			return this.CreateCaseInsensitiveStringExpression(fieldName, op, value);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004185 File Offset: 0x00002385
		public override global::System.Linq.Expressions.Expression CreateExpression(string fieldName, global::Infragistics.ComparisonOperator op, object value, bool caseSensitive)
		{
			if (!(base.FieldDataType == typeof(string)))
			{
				return this.CreateObjectExpression(fieldName, op, value);
			}
			if (caseSensitive)
			{
				return this.CreateCaseSensitiveStringExpression(fieldName, op, value);
			}
			return this.CreateCaseInsensitiveStringExpression(fieldName, op, value);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000041C0 File Offset: 0x000023C0
		protected internal global::System.Linq.Expressions.Expression CreateCaseInsensitiveStringExpression(string fieldName, global::Infragistics.ComparisonOperator op, object value)
		{
			string value2 = string.Empty;
			string text = value as string;
			if (text != null)
			{
				value2 = text;
			}
			global::System.Linq.Expressions.Expression result = null;
			switch (op)
			{
			case global::Infragistics.ComparisonOperator.Equals:
				result = this.CreateEqualsCaseInsensitiveExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.NotEquals:
				result = this.CreateNotEqualsCaseInsensitiveExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.GreaterThan:
				result = this.CreateStringGreaterThanCaseInsensitiveExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.GreaterThanOrEqual:
				result = this.CreateStringGreaterThanOrEqualCaseInsensitiveExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.LessThan:
				result = this.CreateStringLessThanCaseInsensitiveExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.LessThanOrEqual:
				result = this.CreateStringLessThanOrEqualCaseInsensitiveExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.StartsWith:
				result = this.CreateStartsWithCaseInsensitiveExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.DoesNotStartWith:
				result = this.CreateDoesNotStartWithCaseInsensitiveExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.EndsWith:
				result = this.CreateEndsWithCaseInsensitiveExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.DoesNotEndWith:
				result = this.CreateDoesNotEndWithCaseInsensitiveExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.Contains:
				result = this.CreateContainsCaseInsensitiveExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.DoesNotContain:
				result = this.CreateDoesNotContainCaseInsensitiveExpression<TDataObject>(fieldName, value2);
				break;
			default:
				if (op == global::Infragistics.ComparisonOperator.InOperand)
				{
					global::System.Collections.Generic.List<string> value3 = global::Infragistics.FilterContext<TDataObject>.ParseAndNormalizeValue(value, false);
					result = this.CreateStringInOperandCaseInsensitiveExpression<TDataObject>(fieldName, value3);
				}
				break;
			}
			return result;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000042CC File Offset: 0x000024CC
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateStringInOperandCaseInsensitiveExpression<TDataObjectType>(string fieldName, global::System.Collections.IList value)
		{
			return this.CreateStringExpression<TDataObject>(fieldName, (string x) => (x != null && value != null && value.Contains(x.ToLower())) || (x == null && value != null && value.Contains(null)));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004478 File Offset: 0x00002678
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateInOperandExpression<TDataObjectType>(string fieldName, global::System.Collections.IList values)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TDataObjectType), "parameter");
			global::System.Linq.Expressions.Expression expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(fieldName, parameterExpression, base.CachedTypedInfo, base.FieldDataType, this.GetDefaultValue());
			global::System.Linq.Expressions.Expression<global::System.Func<object, bool>> expression2 = (object x) => (x != null && values != null && values.Contains(x)) || (x == null && values != null && values.Contains(null));
			global::System.Linq.Expressions.Expression body = global::System.Linq.Expressions.Expression.Invoke(expression2, new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.Convert(expression, typeof(object))
			});
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(body, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004678 File Offset: 0x00002878
		protected internal global::System.Linq.Expressions.Expression CreateCaseSensitiveStringExpression(string fieldName, global::Infragistics.ComparisonOperator op, object value)
		{
			string value2 = string.Empty;
			string text = value as string;
			if (text != null)
			{
				value2 = text;
			}
			global::System.Linq.Expressions.Expression result = null;
			switch (op)
			{
			case global::Infragistics.ComparisonOperator.Equals:
				result = this.CreateEqualsExpression<TDataObject>(fieldName, value);
				break;
			case global::Infragistics.ComparisonOperator.NotEquals:
				result = this.CreateNotEqualsExpression<TDataObject>(fieldName, value);
				break;
			case global::Infragistics.ComparisonOperator.GreaterThan:
				result = this.CreateStringGreaterThanExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.GreaterThanOrEqual:
				result = this.CreateStringGreaterThanOrEqualExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.LessThan:
				result = this.CreateStringLessThanExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.LessThanOrEqual:
				result = this.CreateStringLessThanOrEqualExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.StartsWith:
				result = this.CreateStartsWithExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.DoesNotStartWith:
				result = this.CreateDoesNotStartWithExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.EndsWith:
				result = this.CreateEndsWithExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.DoesNotEndWith:
				result = this.CreateDoesNotEndWithExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.Contains:
				result = this.CreateContainsExpression<TDataObject>(fieldName, value2);
				break;
			case global::Infragistics.ComparisonOperator.DoesNotContain:
				result = this.CreateDoesNotContainExpression<TDataObject>(fieldName, value2);
				break;
			default:
				if (op == global::Infragistics.ComparisonOperator.InOperand)
				{
					global::System.Collections.Generic.List<string> values = global::Infragistics.FilterContext<TDataObject>.ParseAndNormalizeValue(value, true);
					result = this.CreateInOperandExpression<TDataObject>(fieldName, values);
				}
				break;
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000477C File Offset: 0x0000297C
		protected internal global::System.Linq.Expressions.Expression CreateObjectExpression(string fieldName, global::Infragistics.ComparisonOperator op, object value)
		{
			global::System.Linq.Expressions.Expression result = null;
			global::System.Collections.IList values = null;
			if (value is global::System.Collections.IList)
			{
				values = (value as global::System.Collections.IList);
			}
			switch (op)
			{
			case global::Infragistics.ComparisonOperator.Equals:
				result = this.CreateEqualsExpression<TDataObject>(fieldName, value);
				break;
			case global::Infragistics.ComparisonOperator.NotEquals:
				result = this.CreateNotEqualsExpression<TDataObject>(fieldName, value);
				break;
			case global::Infragistics.ComparisonOperator.GreaterThan:
				result = this.CreateGreaterThanExpression<TDataObject>(fieldName, value);
				break;
			case global::Infragistics.ComparisonOperator.GreaterThanOrEqual:
				result = this.CreateGreaterThanOrEqualsExpression<TDataObject>(fieldName, value);
				break;
			case global::Infragistics.ComparisonOperator.LessThan:
				result = this.CreateLessThanExpression<TDataObject>(fieldName, value);
				break;
			case global::Infragistics.ComparisonOperator.LessThanOrEqual:
				result = this.CreateLessThanOrEqualsExpression<TDataObject>(fieldName, value);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeAfter:
				result = this.CreateGreaterThanExpression<TDataObject>(fieldName, value);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeBefore:
				result = this.CreateLessThanExpression<TDataObject>(fieldName, value);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeToday:
				result = this.CreateDateTimeTimeExcludedEqualsExpression<TDataObject>(fieldName, global::System.DateTime.Today);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeTomorrow:
				result = this.CreateDateTimeTimeExcludedEqualsExpression<TDataObject>(fieldName, global::System.DateTime.Today.AddDays(1.0));
				break;
			case global::Infragistics.ComparisonOperator.DateTimeYesterday:
				result = this.CreateDateTimeTimeExcludedEqualsExpression<TDataObject>(fieldName, global::System.DateTime.Today.AddDays(-1.0));
				break;
			case global::Infragistics.ComparisonOperator.DateTimeThisWeek:
				result = this.CreateThisWeekExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeNextWeek:
				result = this.CreateNextWeekExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeLastWeek:
				result = this.CreateLastWeekExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeThisMonth:
				result = this.CreateThisMonthExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeLastMonth:
				result = this.CreateLastMonthExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeNextMonth:
				result = this.CreateNextMonthExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeThisYear:
				result = this.CreateThisYearExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeLastYear:
				result = this.CreateLastYearExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeNextYear:
				result = this.CreateNextYearExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeYearToDate:
				result = this.CreateYearToDateExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeLastQuarter:
				result = this.CreateLastQuarterExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeThisQuarter:
				result = this.CreateThisQuarterExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeNextQuarter:
				result = this.CreateNextQuarterExpression<TDataObject>(fieldName);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeJanuary:
				result = this.CreateMonthExpression<TDataObject>(fieldName, 1);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeFebruary:
				result = this.CreateMonthExpression<TDataObject>(fieldName, 2);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeMarch:
				result = this.CreateMonthExpression<TDataObject>(fieldName, 3);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeApril:
				result = this.CreateMonthExpression<TDataObject>(fieldName, 4);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeMay:
				result = this.CreateMonthExpression<TDataObject>(fieldName, 5);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeJune:
				result = this.CreateMonthExpression<TDataObject>(fieldName, 6);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeJuly:
				result = this.CreateMonthExpression<TDataObject>(fieldName, 7);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeAugust:
				result = this.CreateMonthExpression<TDataObject>(fieldName, 8);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeSeptember:
				result = this.CreateMonthExpression<TDataObject>(fieldName, 9);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeOctober:
				result = this.CreateMonthExpression<TDataObject>(fieldName, 10);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeNovember:
				result = this.CreateMonthExpression<TDataObject>(fieldName, 11);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeDecember:
				result = this.CreateMonthExpression<TDataObject>(fieldName, 12);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeQuarter1:
				result = this.CreateQuarterYearIndependentExpression<TDataObject>(fieldName, 1);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeQuarter2:
				result = this.CreateQuarterYearIndependentExpression<TDataObject>(fieldName, 2);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeQuarter3:
				result = this.CreateQuarterYearIndependentExpression<TDataObject>(fieldName, 3);
				break;
			case global::Infragistics.ComparisonOperator.DateTimeQuarter4:
				result = this.CreateQuarterYearIndependentExpression<TDataObject>(fieldName, 4);
				break;
			case global::Infragistics.ComparisonOperator.InOperand:
				result = this.CreateInOperandExpression<TDataObject>(fieldName, values);
				break;
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004AB4 File Offset: 0x00002CB4
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateThisWeekExpression<TDataObjectType>(string fieldName)
		{
			global::System.DateTime includeStartDate = global::System.DateTime.Today.AddDays((double)(-(double)global::System.DateTime.Today.DayOfWeek + (int)global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek));
			includeStartDate = new global::System.DateTime(includeStartDate.Year, includeStartDate.Month, includeStartDate.Day);
			global::System.DateTime excludedEndDate = includeStartDate.AddDays(7.0);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, includeStartDate, excludedEndDate);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004B24 File Offset: 0x00002D24
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateNextWeekExpression<TDataObjectType>(string fieldName)
		{
			global::System.DateTime includeStartDate = global::System.DateTime.Today.AddDays((double)(-(double)global::System.DateTime.Today.DayOfWeek + (int)global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek));
			includeStartDate = new global::System.DateTime(includeStartDate.Year, includeStartDate.Month, includeStartDate.Day);
			includeStartDate = includeStartDate.AddDays(7.0);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, includeStartDate, includeStartDate.AddDays(7.0));
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004BA4 File Offset: 0x00002DA4
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateLastWeekExpression<TDataObjectType>(string fieldName)
		{
			global::System.DateTime includeStartDate = global::System.DateTime.Today.AddDays((double)(-(double)global::System.DateTime.Today.DayOfWeek + (int)global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek));
			includeStartDate = new global::System.DateTime(includeStartDate.Year, includeStartDate.Month, includeStartDate.Day);
			includeStartDate = includeStartDate.AddDays(-7.0);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, includeStartDate, includeStartDate.AddDays(7.0));
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004C24 File Offset: 0x00002E24
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateThisMonthExpression<TDataObjectType>(string fieldName)
		{
			global::System.DateTime includeStartDate = new global::System.DateTime(global::System.DateTime.Today.Year, global::System.DateTime.Today.Month, 1);
			global::System.DateTime dateTime = global::System.DateTime.Today.AddMonths(1);
			global::System.DateTime excludedEndDate = new global::System.DateTime(dateTime.Year, dateTime.Month, 1);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, includeStartDate, excludedEndDate);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004C84 File Offset: 0x00002E84
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateNextMonthExpression<TDataObjectType>(string fieldName)
		{
			global::System.DateTime dateTime = global::System.DateTime.Today.AddMonths(1);
			global::System.DateTime includeStartDate = new global::System.DateTime(dateTime.Year, dateTime.Month, 1);
			dateTime = dateTime.AddMonths(1);
			global::System.DateTime excludedEndDate = new global::System.DateTime(dateTime.Year, dateTime.Month, 1);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, includeStartDate, excludedEndDate);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004CE0 File Offset: 0x00002EE0
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateLastMonthExpression<TDataObjectType>(string fieldName)
		{
			global::System.DateTime excludedEndDate = new global::System.DateTime(global::System.DateTime.Today.Year, global::System.DateTime.Today.Month, 1);
			global::System.DateTime dateTime = global::System.DateTime.Today.AddMonths(-1);
			global::System.DateTime includeStartDate = new global::System.DateTime(dateTime.Year, dateTime.Month, 1);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, includeStartDate, excludedEndDate);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004D40 File Offset: 0x00002F40
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateThisYearExpression<TDataObjectType>(string fieldName)
		{
			global::System.DateTime includeStartDate = new global::System.DateTime(global::System.DateTime.Today.Year, 1, 1);
			global::System.DateTime excludedEndDate = new global::System.DateTime(global::System.DateTime.Today.Year + 1, 1, 1);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, includeStartDate, excludedEndDate);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004D84 File Offset: 0x00002F84
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateNextYearExpression<TDataObjectType>(string fieldName)
		{
			global::System.DateTime includeStartDate = new global::System.DateTime(global::System.DateTime.Today.Year + 1, 1, 1);
			global::System.DateTime excludedEndDate = new global::System.DateTime(global::System.DateTime.Today.Year + 2, 1, 1);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, includeStartDate, excludedEndDate);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004DCC File Offset: 0x00002FCC
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateLastYearExpression<TDataObjectType>(string fieldName)
		{
			global::System.DateTime excludedEndDate = new global::System.DateTime(global::System.DateTime.Today.Year, 1, 1);
			global::System.DateTime includeStartDate = new global::System.DateTime(global::System.DateTime.Today.Year - 1, 1, 1);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, includeStartDate, excludedEndDate);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004E10 File Offset: 0x00003010
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateThisQuarterExpression<TDataObjectType>(string fieldName)
		{
			global::Infragistics.FilterContext<TDataObject>.QuarterTracking currentQuarterInfo = this.GetCurrentQuarterInfo(global::System.DateTime.Today);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, currentQuarterInfo.StartDate, currentQuarterInfo.EndDate);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004E3C File Offset: 0x0000303C
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateNextQuarterExpression<TDataObjectType>(string fieldName)
		{
			global::Infragistics.FilterContext<TDataObject>.QuarterTracking nextQuarterInfo = this.GetNextQuarterInfo(global::System.DateTime.Today);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, nextQuarterInfo.StartDate, nextQuarterInfo.EndDate);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004E68 File Offset: 0x00003068
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateLastQuarterExpression<TDataObjectType>(string fieldName)
		{
			global::Infragistics.FilterContext<TDataObject>.QuarterTracking previousQuarterInfo = this.GetPreviousQuarterInfo(global::System.DateTime.Today);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, previousQuarterInfo.StartDate, previousQuarterInfo.EndDate);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004E94 File Offset: 0x00003094
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateYearToDateExpression<TDataObjectType>(string fieldName)
		{
			global::System.DateTime includeStartDate = new global::System.DateTime(global::System.DateTime.Today.Year, 1, 1);
			global::System.DateTime excludedEndDate = new global::System.DateTime(global::System.DateTime.Today.Year, global::System.DateTime.Today.Month, global::System.DateTime.Today.Day);
			excludedEndDate = excludedEndDate.AddDays(1.0);
			return this.CreateDateRangeExpression<TDataObject>(fieldName, includeStartDate, excludedEndDate);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004F04 File Offset: 0x00003104
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateDateRangeExpression<TDataObjectType>(string fieldName, global::System.DateTime includeStartDate, global::System.DateTime excludedEndDate)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TDataObjectType), "parameter");
			global::System.Linq.Expressions.Expression left = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(fieldName, parameterExpression, base.CachedTypedInfo, base.FieldDataType, this.GetDefaultValue());
			global::System.Linq.Expressions.Expression right = global::System.Linq.Expressions.Expression.Constant(includeStartDate, base.FieldDataType);
			global::System.Linq.Expressions.Expression left2 = global::System.Linq.Expressions.Expression.GreaterThanOrEqual(left, right);
			right = global::System.Linq.Expressions.Expression.Constant(excludedEndDate, base.FieldDataType);
			global::System.Linq.Expressions.Expression right2 = global::System.Linq.Expressions.Expression.LessThan(left, right);
			global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.AndAlso(left2, right2);
			if (!typeof(TDataObject).IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, typeof(TDataObject)));
				expression = global::System.Linq.Expressions.Expression.Condition(test, global::System.Linq.Expressions.Expression.Constant(false), expression);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004FDC File Offset: 0x000031DC
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateMonthExpression<TDataObjectType>(string fieldName, int month)
		{
			global::System.Linq.Expressions.Expression expression2;
			if (base.FieldDataType == typeof(global::System.DateTime))
			{
				global::System.Linq.Expressions.Expression<global::System.Func<global::System.DateTime, bool>> expression = (global::System.DateTime x) => x.Month == month;
				expression2 = expression;
			}
			else
			{
				global::System.Linq.Expressions.Expression<global::System.Func<global::System.DateTime?, bool>> expression3 = (global::System.DateTime? x) => x != (global::System.DateTime?)null && ((global::System.DateTime)x).Month == month;
				expression2 = expression3;
			}
			global::System.Linq.Expressions.ParameterExpression parameterExpression3 = global::System.Linq.Expressions.Expression.Parameter(typeof(TDataObject), "parameter");
			global::System.Linq.Expressions.Expression expression4 = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(fieldName, parameterExpression3, base.CachedTypedInfo, base.FieldDataType, this.GetDefaultValue());
			global::System.Linq.Expressions.Expression expression5 = global::System.Linq.Expressions.Expression.Invoke(expression2, new global::System.Linq.Expressions.Expression[]
			{
				expression4
			});
			if (!typeof(TDataObject).IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression3, global::System.Linq.Expressions.Expression.Constant(null, typeof(TDataObject)));
				expression5 = global::System.Linq.Expressions.Expression.Condition(test, global::System.Linq.Expressions.Expression.Constant(false), expression5);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(expression5, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression3
			});
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000051DC File Offset: 0x000033DC
		protected internal virtual global::System.Linq.Expressions.Expression<global::System.Func<TDataObject, bool>> CreateQuarterYearIndependentExpression<TDataObjectType>(string fieldName, int quarter)
		{
			global::System.Linq.Expressions.Expression expression2;
			if (base.FieldDataType == typeof(global::System.DateTime))
			{
				global::System.Linq.Expressions.Expression<global::System.Func<global::System.DateTime, bool>> expression = (global::System.DateTime x) => this.IsDateValueInQuarter(x, quarter);
				expression2 = expression;
			}
			else
			{
				global::System.Linq.Expressions.Expression<global::System.Func<global::System.DateTime?, bool>> expression3 = (global::System.DateTime? x) => x != (global::System.DateTime?)null && this.IsDateValueInQuarter((global::System.DateTime)x, quarter);
				expression2 = expression3;
			}
			global::System.Linq.Expressions.ParameterExpression parameterExpression3 = global::System.Linq.Expressions.Expression.Parameter(typeof(TDataObject), "parameter");
			global::System.Linq.Expressions.Expression expression4 = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(fieldName, parameterExpression3, base.CachedTypedInfo, base.FieldDataType, this.GetDefaultValue());
			global::System.Linq.Expressions.Expression expression5 = global::System.Linq.Expressions.Expression.Invoke(expression2, new global::System.Linq.Expressions.Expression[]
			{
				expression4
			});
			if (!typeof(TDataObject).IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression3, global::System.Linq.Expressions.Expression.Constant(null, typeof(TDataObject)));
				expression5 = global::System.Linq.Expressions.Expression.Condition(test, global::System.Linq.Expressions.Expression.Constant(false), expression5);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TDataObject, bool>>(expression5, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression3
			});
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000542C File Offset: 0x0000362C
		internal bool IsDateValueInQuarter(global::System.DateTime value, int quarter)
		{
			int month = 1;
			int month2 = 1;
			int year = 1;
			int num = 1;
			switch (quarter)
			{
			case 1:
				month = 1;
				month2 = 4;
				year = (num = value.Year);
				break;
			case 2:
				month = 4;
				month2 = 7;
				year = (num = value.Year);
				break;
			case 3:
				month = 7;
				month2 = 10;
				year = (num = value.Year);
				break;
			case 4:
				month = 10;
				month2 = 1;
				year = (num = value.Year);
				num++;
				break;
			}
			global::System.DateTime t = new global::System.DateTime(year, month, 1);
			global::System.DateTime t2 = new global::System.DateTime(num, month2, 1);
			return value >= t && value < t2;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000054CC File Offset: 0x000036CC
		internal global::Infragistics.FilterContext<TDataObject>.QuarterTracking GetCurrentQuarterInfo(global::System.DateTime date)
		{
			int month = date.Month;
			int year = date.Year;
			global::Infragistics.FilterContext<TDataObject>.QuarterTracking quarterTracking = new global::Infragistics.FilterContext<TDataObject>.QuarterTracking();
			if (month <= 3)
			{
				quarterTracking.StartDate = new global::System.DateTime(year, 1, 1);
				quarterTracking.EndDate = new global::System.DateTime(year, 4, 1);
			}
			else if (month <= 6)
			{
				quarterTracking.StartDate = new global::System.DateTime(year, 4, 1);
				quarterTracking.EndDate = new global::System.DateTime(year, 7, 1);
			}
			else if (month <= 9)
			{
				quarterTracking.StartDate = new global::System.DateTime(year, 7, 1);
				quarterTracking.EndDate = new global::System.DateTime(year, 10, 1);
			}
			else
			{
				quarterTracking.StartDate = new global::System.DateTime(year, 10, 1);
				quarterTracking.EndDate = new global::System.DateTime(year + 1, 1, 1);
			}
			return quarterTracking;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005578 File Offset: 0x00003778
		internal global::Infragistics.FilterContext<TDataObject>.QuarterTracking GetNextQuarterInfo(global::System.DateTime date)
		{
			int month = date.Month;
			int year = date.Year;
			global::Infragistics.FilterContext<TDataObject>.QuarterTracking quarterTracking = new global::Infragistics.FilterContext<TDataObject>.QuarterTracking();
			if (month <= 3)
			{
				quarterTracking.StartDate = new global::System.DateTime(year, 4, 1);
				quarterTracking.EndDate = new global::System.DateTime(year, 7, 1);
			}
			else if (month <= 6)
			{
				quarterTracking.StartDate = new global::System.DateTime(year, 7, 1);
				quarterTracking.EndDate = new global::System.DateTime(year, 10, 1);
			}
			else if (month <= 9)
			{
				quarterTracking.StartDate = new global::System.DateTime(year, 10, 1);
				quarterTracking.EndDate = new global::System.DateTime(year + 1, 1, 1);
			}
			else
			{
				quarterTracking.StartDate = new global::System.DateTime(year + 1, 1, 1);
				quarterTracking.EndDate = new global::System.DateTime(year + 1, 4, 1);
			}
			return quarterTracking;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005628 File Offset: 0x00003828
		internal global::Infragistics.FilterContext<TDataObject>.QuarterTracking GetPreviousQuarterInfo(global::System.DateTime date)
		{
			int month = date.Month;
			int year = date.Year;
			global::Infragistics.FilterContext<TDataObject>.QuarterTracking quarterTracking = new global::Infragistics.FilterContext<TDataObject>.QuarterTracking();
			if (month <= 3)
			{
				quarterTracking.StartDate = new global::System.DateTime(year - 1, 10, 1);
				quarterTracking.EndDate = new global::System.DateTime(year, 1, 1);
			}
			else if (month <= 6)
			{
				quarterTracking.StartDate = new global::System.DateTime(year, 1, 1);
				quarterTracking.EndDate = new global::System.DateTime(year, 4, 1);
			}
			else if (month <= 9)
			{
				quarterTracking.StartDate = new global::System.DateTime(year, 4, 1);
				quarterTracking.EndDate = new global::System.DateTime(year, 7, 1);
			}
			else
			{
				quarterTracking.StartDate = new global::System.DateTime(year, 7, 1);
				quarterTracking.EndDate = new global::System.DateTime(year, 10, 1);
			}
			return quarterTracking;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000056D3 File Offset: 0x000038D3
		private object GetDefaultValue()
		{
			if (!base.FieldDataType.IsValueType)
			{
				return null;
			}
			return global::System.Activator.CreateInstance(base.FieldDataType);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000056F0 File Offset: 0x000038F0
		private static global::System.Collections.Generic.List<string> ParseAndNormalizeValue(object value, bool isCaseSensitive)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			if (value is global::System.Collections.IList)
			{
				foreach (object obj in (value as global::System.Collections.IList))
				{
					string text = (string)obj;
					if (text != null)
					{
						list.Add(isCaseSensitive ? text : text.ToLower());
					}
					else
					{
						list.Add(null);
					}
				}
				if (list.Contains(null))
				{
					list.Add(string.Empty);
				}
			}
			return list;
		}

		// Token: 0x04000008 RID: 8
		protected static readonly global::System.Reflection.MethodInfo EqualsMethod = typeof(object).GetMethod("Equals", new global::System.Type[]
		{
			typeof(object)
		});

		// Token: 0x02000007 RID: 7
		internal class QuarterTracking
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000069 RID: 105 RVA: 0x000057BF File Offset: 0x000039BF
			// (set) Token: 0x0600006A RID: 106 RVA: 0x000057C7 File Offset: 0x000039C7
			public global::System.DateTime StartDate { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600006B RID: 107 RVA: 0x000057D0 File Offset: 0x000039D0
			// (set) Token: 0x0600006C RID: 108 RVA: 0x000057D8 File Offset: 0x000039D8
			public global::System.DateTime EndDate { get; set; }
		}
	}
}
