using System;
using System.Linq;
using System.Linq.Expressions;

namespace Infragistics
{
	// Token: 0x02000018 RID: 24
	public class SummaryContext<TObjectType, TColumnType> : global::Infragistics.SummaryContext
	{
		// Token: 0x0600012A RID: 298 RVA: 0x000078A4 File Offset: 0x00005AA4
		public SummaryContext(string propertyName, global::Infragistics.LinqSummaryOperator linqSummary, global::Infragistics.CachedTypedInfo cti)
		{
			base.FieldName = propertyName;
			base.LinqSummary = linqSummary;
			this.CachedTypedInfo = cti;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000078C1 File Offset: 0x00005AC1
		// (set) Token: 0x0600012C RID: 300 RVA: 0x000078C9 File Offset: 0x00005AC9
		private protected global::Infragistics.CachedTypedInfo CachedTypedInfo { protected get; private set; }

		// Token: 0x0600012D RID: 301 RVA: 0x000078D4 File Offset: 0x00005AD4
		protected override object Maximum(global::System.Linq.IQueryable query)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TObjectType), "parameter");
			global::System.Linq.Expressions.Expression body = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(base.FieldName, parameterExpression, this.CachedTypedInfo, typeof(TColumnType), default(TColumnType));
			global::System.Linq.Expressions.Expression<global::System.Func<TObjectType, TColumnType>> selector = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, TColumnType>>(body, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
			object result;
			try
			{
				result = query.Cast<TObjectType>().Max(selector);
			}
			catch (global::System.InvalidOperationException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00007964 File Offset: 0x00005B64
		protected override object Minimum(global::System.Linq.IQueryable query)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TObjectType), "parameter");
			global::System.Linq.Expressions.Expression body = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(base.FieldName, parameterExpression, this.CachedTypedInfo, typeof(TColumnType), default(TColumnType));
			global::System.Linq.Expressions.Expression<global::System.Func<TObjectType, TColumnType>> selector = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, TColumnType>>(body, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
			object result;
			try
			{
				result = query.Cast<TObjectType>().Min(selector);
			}
			catch (global::System.InvalidOperationException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000079F4 File Offset: 0x00005BF4
		protected override object Sum(global::System.Linq.IQueryable query)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TObjectType), "parameter");
			global::System.Linq.Expressions.Expression expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(base.FieldName, parameterExpression, this.CachedTypedInfo, typeof(TColumnType), default(TColumnType));
			global::System.Type typeFromHandle = typeof(TColumnType);
			try
			{
				if (typeFromHandle == typeof(int))
				{
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, double>>(global::System.Linq.Expressions.Expression.Convert(expression, typeof(double)), new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(int?))
				{
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, double?>>(global::System.Linq.Expressions.Expression.Convert(expression, typeof(double?)), new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(long))
				{
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, double>>(global::System.Linq.Expressions.Expression.Convert(expression, typeof(double)), new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(long?))
				{
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, double?>>(global::System.Linq.Expressions.Expression.Convert(expression, typeof(double?)), new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(double))
				{
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, double>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(double?))
				{
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, double?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(decimal))
				{
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, decimal>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(decimal?))
				{
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, decimal?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(float))
				{
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, float>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(float?))
				{
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, float?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(byte))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int));
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(byte?))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int?));
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(sbyte))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int));
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(sbyte?))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int?));
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(uint))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(long));
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, long>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(uint?))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(long?));
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, long?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(short))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int));
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(short?))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int?));
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(ushort))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int));
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(ushort?))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int?));
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(ulong))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(decimal));
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, decimal>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle == typeof(ulong?))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(decimal?));
					return query.Cast<TObjectType>().Sum(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, decimal?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
			}
			catch (global::System.InvalidOperationException)
			{
				return null;
			}
			return null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000080B4 File Offset: 0x000062B4
		protected override object Average(global::System.Linq.IQueryable query)
		{
			global::System.Type typeFromHandle = typeof(TObjectType);
			global::System.Type typeFromHandle2 = typeof(TColumnType);
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeFromHandle, "parameter");
			global::System.Linq.Expressions.Expression expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(base.FieldName, parameterExpression, this.CachedTypedInfo, typeof(TColumnType), default(TColumnType));
			try
			{
				if (typeFromHandle2 == typeof(int))
				{
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(int?))
				{
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(long))
				{
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, long>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(long?))
				{
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, long?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(double))
				{
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, double>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(double?))
				{
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, double?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(decimal))
				{
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, decimal>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(decimal?))
				{
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, decimal?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(float))
				{
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, float>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(float?))
				{
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, float?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(byte))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int));
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(byte?))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int?));
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(sbyte))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int));
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(sbyte?))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int?));
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(uint))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(long));
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, long>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(uint?))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(long?));
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, long?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(short))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int));
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(short?))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int?));
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(ushort))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int));
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(ushort?))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(int?));
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, int?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(ulong))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(decimal));
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, decimal>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
				if (typeFromHandle2 == typeof(ulong?))
				{
					expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(decimal?));
					return query.Cast<TObjectType>().Average(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TObjectType, decimal?>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
					{
						parameterExpression
					}));
				}
			}
			catch (global::System.InvalidOperationException)
			{
				return null;
			}
			return null;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00008754 File Offset: 0x00006954
		protected override int Count(global::System.Linq.IQueryable query)
		{
			return query.Cast<TObjectType>().Count<TObjectType>();
		}
	}
}
