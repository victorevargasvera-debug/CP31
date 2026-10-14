using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Infragistics
{
	// Token: 0x02000016 RID: 22
	internal class MultiSortComparer<T> : global::System.Collections.Generic.IComparer<T>
	{
		// Token: 0x06000119 RID: 281 RVA: 0x000074B4 File Offset: 0x000056B4
		public MultiSortComparer(global::System.Collections.Generic.IList<global::Infragistics.SortContext> sortContexts, global::Infragistics.CachedTypedInfo cachedTypedInfo)
		{
			this._sortContexts = sortContexts;
			this._cachedTypedInfo = cachedTypedInfo;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000074CC File Offset: 0x000056CC
		public int Compare(T x, T y)
		{
			object obj = x;
			object obj2 = y;
			if (obj == null && obj2 == null)
			{
				return 0;
			}
			if (obj == null)
			{
				return -1;
			}
			if (obj2 == null)
			{
				return 1;
			}
			if (!this._isCompiled)
			{
				this.Compile();
			}
			int num = this._compare(x, y);
			if (num != 0)
			{
				return num;
			}
			if (object.ReferenceEquals(x, y))
			{
				return 0;
			}
			return -1;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00007530 File Offset: 0x00005730
		private void Compile()
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(T), "p1");
			global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(typeof(T), "p2");
			global::System.Linq.Expressions.ParameterExpression parameterExpression3 = global::System.Linq.Expressions.Expression.Variable(typeof(int), "result");
			global::System.Linq.Expressions.BlockExpression body = global::System.Linq.Expressions.Expression.Block(new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression3
			}, new global::System.Linq.Expressions.Expression[]
			{
				this.BuildCompareExpression(this._sortContexts, parameterExpression3, parameterExpression, parameterExpression2),
				parameterExpression3
			});
			global::System.Linq.Expressions.Expression<global::System.Func<T, T, int>> expression = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<T, T, int>>(body, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			});
			this._compare = expression.Compile();
			this._isCompiled = true;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000075E4 File Offset: 0x000057E4
		private global::System.Linq.Expressions.Expression BuildCompareExpression(global::System.Collections.Generic.IList<global::Infragistics.SortContext> sortContexts, global::System.Linq.Expressions.Expression resultVar, global::System.Linq.Expressions.ParameterExpression p1, global::System.Linq.Expressions.ParameterExpression p2)
		{
			int num = sortContexts.Count - 1;
			global::System.Linq.Expressions.Expression expression = null;
			for (int i = num; i >= 0; i--)
			{
				global::Infragistics.SortContext sortContext = sortContexts[i];
				if (num == i)
				{
					expression = global::System.Linq.Expressions.Expression.Assign(resultVar, this.BuildCompareCondition(sortContext, p1, p2));
				}
				else
				{
					global::System.Linq.Expressions.BinaryExpression test = global::System.Linq.Expressions.Expression.Equal(resultVar, global::System.Linq.Expressions.Expression.Constant(0, typeof(int)));
					expression = global::System.Linq.Expressions.Expression.Block(global::System.Linq.Expressions.Expression.Assign(resultVar, this.BuildCompareCondition(sortContext, p1, p2)), global::System.Linq.Expressions.Expression.IfThen(test, expression));
				}
			}
			return expression;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00007664 File Offset: 0x00005864
		private global::System.Linq.Expressions.Expression BuildCompareCondition(global::Infragistics.SortContext sortContext, global::System.Linq.Expressions.ParameterExpression param1, global::System.Linq.Expressions.ParameterExpression param2)
		{
			global::System.Linq.Expressions.MemberExpression memberExpression = global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(sortContext), "Comparer");
			global::System.Type propertyType = sortContext.PropertyType;
			global::System.Type type = typeof(global::System.Collections.Generic.IComparer<>).MakeGenericType(new global::System.Type[]
			{
				propertyType
			});
			global::System.Reflection.MethodInfo method = type.GetMethod("Compare");
			global::System.Linq.Expressions.Expression expression;
			if (sortContext.SortPropertyName == null)
			{
				expression = global::System.Linq.Expressions.Expression.Call(memberExpression, method, param1, param2);
			}
			else
			{
				global::System.Linq.Expressions.Expression arg = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(sortContext.SortPropertyName, param1, this._cachedTypedInfo, propertyType, null);
				global::System.Linq.Expressions.Expression arg2 = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(sortContext.SortPropertyName, param2, this._cachedTypedInfo, propertyType, null);
				global::System.Type type2 = typeof(global::System.Collections.Generic.Comparer<>).MakeGenericType(new global::System.Type[]
				{
					propertyType
				});
				global::System.Reflection.MethodInfo method2 = type2.GetMethod("Compare", new global::System.Type[]
				{
					propertyType,
					propertyType
				});
				global::System.Linq.Expressions.MemberExpression instance = global::System.Linq.Expressions.Expression.Property(null, type2, "Default");
				global::System.Linq.Expressions.Expression ifTrue = global::System.Linq.Expressions.Expression.Call(instance, method2, arg, arg2);
				global::System.Linq.Expressions.Expression ifFalse = global::System.Linq.Expressions.Expression.Call(memberExpression, method, arg, arg2);
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(memberExpression, global::System.Linq.Expressions.Expression.Constant(null, type));
				expression = global::System.Linq.Expressions.Expression.Condition(test, ifTrue, ifFalse);
			}
			if (!sortContext.SortAscending)
			{
				expression = global::System.Linq.Expressions.Expression.Multiply(expression, global::System.Linq.Expressions.Expression.Constant(-1, typeof(int)));
			}
			return expression;
		}

		// Token: 0x04000050 RID: 80
		private readonly global::System.Collections.Generic.IList<global::Infragistics.SortContext> _sortContexts;

		// Token: 0x04000051 RID: 81
		private global::System.Func<T, T, int> _compare;

		// Token: 0x04000052 RID: 82
		private bool _isCompiled;

		// Token: 0x04000053 RID: 83
		private readonly global::Infragistics.CachedTypedInfo _cachedTypedInfo;
	}
}
