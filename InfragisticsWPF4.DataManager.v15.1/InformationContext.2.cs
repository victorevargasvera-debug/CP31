using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Infragistics
{
	// Token: 0x0200000C RID: 12
	public class InformationContext<T, TColumnType> : global::Infragistics.InformationContext
	{
		// Token: 0x060000AA RID: 170 RVA: 0x000060C4 File Offset: 0x000042C4
		public InformationContext(string propertyName, bool sortAscending, bool caseSensitiveSort, object comparer, bool fromDateColumn, global::Infragistics.CachedTypedInfo cti)
		{
			base.PropertyName = propertyName;
			base.SortAscending = sortAscending;
			base.CaseSensitive = caseSensitiveSort;
			base.Comparer = (global::System.Collections.Generic.IComparer<TColumnType>)comparer;
			base.FromDateColumn = fromDateColumn;
			base.PropertyType = typeof(TColumnType);
			base.DataType = typeof(T);
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(T), "param");
			global::System.Linq.Expressions.Expression expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(propertyName, parameterExpression, cti, base.PropertyType, default(TColumnType));
			if (!caseSensitiveSort && base.PropertyType == typeof(string) && comparer == null)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Call(null, global::Infragistics.InformationContext.IsNullOrEmptyMethod, new global::System.Linq.Expressions.Expression[]
				{
					expression
				});
				global::System.Linq.Expressions.Expression ifTrue = global::System.Linq.Expressions.Expression.Constant(default(TColumnType), base.PropertyType);
				expression = global::System.Linq.Expressions.Expression.Condition(test, ifTrue, expression);
				base.Comparer = global::System.StringComparer.CurrentCultureIgnoreCase;
				this._filterComparer = (global::System.Collections.Generic.IEqualityComparer<TColumnType>)global::System.StringComparer.CurrentCultureIgnoreCase;
			}
			if (!parameterExpression.Type.IsValueType)
			{
				global::System.Linq.Expressions.Expression test2 = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, base.DataType));
				global::System.Linq.Expressions.Expression ifTrue2 = global::System.Linq.Expressions.Expression.Constant(default(TColumnType), base.PropertyType);
				expression = global::System.Linq.Expressions.Expression.Condition(test2, ifTrue2, expression);
			}
			base.Lambda = global::System.Linq.Expressions.Expression.Lambda(expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00006230 File Offset: 0x00004430
		public override global::System.Collections.IList GetDistinctValues(global::System.Collections.IEnumerable list)
		{
			if (list == null)
			{
				return null;
			}
			return this.GetDistinctValuesAsync(list, global::System.Threading.CancellationToken.None, false).Result;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00006254 File Offset: 0x00004454
		internal override global::System.Threading.Tasks.Task<global::System.Collections.IList> GetDistinctValuesAsync(global::System.Collections.IEnumerable list, global::System.Threading.CancellationToken token, bool runAsync)
		{
			if (list == null)
			{
				return null;
			}
			global::System.Type left = global::Infragistics.DataManagerBase.ResolveItemType(list);
			if (left == typeof(global::Infragistics.MergedRowInfo))
			{
				return this.GetDistinctValuesAsync((from global::Infragistics.MergedRowInfo i in list
				select i.Data).Cast<T>().AsQueryable<T>(), token, runAsync);
			}
			global::System.Linq.IQueryable<T> queryable = list as global::System.Linq.IQueryable<T>;
			if (queryable == null)
			{
				queryable = list.Cast<T>().AsQueryable<T>();
			}
			return this.GetDistinctValuesAsync(queryable, token, runAsync);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000062D9 File Offset: 0x000044D9
		public global::System.Collections.Generic.IList<TColumnType> GetDistinctValues(global::System.Linq.IQueryable<T> list)
		{
			return (global::System.Collections.Generic.IList<TColumnType>)this.GetDistinctValuesAsync(list, global::System.Threading.CancellationToken.None, false).Result;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000062F2 File Offset: 0x000044F2
		internal global::System.Threading.Tasks.Task<global::System.Collections.IList> GetDistinctValuesAsync(global::System.Linq.IQueryable<T> list, global::System.Threading.CancellationToken token, bool runAsync)
		{
			return this.GetDistinctValuesImpl(list, token, runAsync);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00006420 File Offset: 0x00004620
		private global::System.Threading.Tasks.Task<global::System.Collections.IList> GetDistinctValuesImpl(global::System.Linq.IQueryable<T> list, global::System.Threading.CancellationToken token, bool runAsync)
		{
			global::System.Linq.Expressions.Expression<global::System.Func<T, TColumnType>> selector = (global::System.Linq.Expressions.Expression<global::System.Func<T, TColumnType>>)base.Lambda;
			global::System.Linq.IQueryable<TColumnType> copy;
			if (!runAsync)
			{
				copy = list.Select(selector);
			}
			else
			{
				copy = new global::System.Collections.Generic.List<TColumnType>(list.Select(selector)).AsQueryable<TColumnType>();
			}
			return global::System.Threading.Tasks.Task<global::System.Collections.IList>.Factory.StartNew(delegate()
			{
				global::System.Linq.IQueryable<TColumnType> source = copy.Distinct(this._filterComparer);
				global::System.Linq.Expressions.LambdaExpression lambdaExpression = (TColumnType param) => param;
				global::System.Linq.Expressions.Expression<global::System.Func<TColumnType, TColumnType>> keySelector = (global::System.Linq.Expressions.Expression<global::System.Func<TColumnType, TColumnType>>)lambdaExpression;
				if (this.SortAscending)
				{
					if (this.Comparer != null)
					{
						source = source.OrderBy(keySelector, (global::System.Collections.Generic.IComparer<TColumnType>)this.Comparer);
					}
					else
					{
						source = source.OrderBy(keySelector);
					}
				}
				else if (this.Comparer != null)
				{
					source = source.OrderByDescending(keySelector, (global::System.Collections.Generic.IComparer<TColumnType>)this.Comparer);
				}
				else
				{
					source = source.OrderByDescending(keySelector);
				}
				global::System.Collections.Generic.List<TColumnType> result;
				if (token == global::System.Threading.CancellationToken.None)
				{
					result = source.ToList<TColumnType>();
				}
				else
				{
					try
					{
						result = source.AsParallel<TColumnType>().AsOrdered<TColumnType>().WithCancellation(token).ToList<TColumnType>();
					}
					catch (global::System.OperationCanceledException)
					{
						result = null;
					}
				}
				return result;
			});
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00006490 File Offset: 0x00004690
		public global::System.Collections.IList GetDistinctValues(global::System.Linq.IQueryable list)
		{
			if (list == null)
			{
				return null;
			}
			global::System.Linq.IQueryable<T> queryable = list as global::System.Linq.IQueryable<T>;
			if (queryable == null)
			{
				queryable = list.AsQueryable().Cast<T>();
			}
			return (global::System.Collections.IList)this.GetDistinctValues(queryable);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000064C4 File Offset: 0x000046C4
		public override global::System.Collections.IList GetCompleteValuesList(global::System.Collections.IEnumerable list)
		{
			if (list == null)
			{
				return null;
			}
			global::System.Linq.IQueryable<T> queryable = list as global::System.Linq.IQueryable<T>;
			if (queryable == null)
			{
				queryable = list.AsQueryable().Cast<T>();
			}
			return (global::System.Collections.IList)this.GetCompleteValuesList(queryable);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000064F8 File Offset: 0x000046F8
		public global::System.Collections.IList GetCompleteValuesList(global::System.Linq.IQueryable list)
		{
			if (list == null)
			{
				return null;
			}
			global::System.Linq.IQueryable<T> queryable = list as global::System.Linq.IQueryable<T>;
			if (queryable == null)
			{
				queryable = list.AsQueryable().Cast<T>();
			}
			return (global::System.Collections.IList)this.GetCompleteValuesList(queryable);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000065A0 File Offset: 0x000047A0
		public global::System.Collections.Generic.IList<TColumnType> GetCompleteValuesList(global::System.Linq.IQueryable<T> list)
		{
			global::System.Linq.Expressions.Expression<global::System.Func<T, TColumnType>> selector = (global::System.Linq.Expressions.Expression<global::System.Func<T, TColumnType>>)base.Lambda;
			if (base.SortAscending)
			{
				global::System.Collections.Generic.IEnumerable<TColumnType> enumerable = list.Select(selector);
				global::System.Type typeFromHandle = typeof(TColumnType);
				if (base.FromDateColumn)
				{
					if (typeFromHandle == typeof(global::System.DateTime))
					{
						enumerable = (global::System.Collections.Generic.IEnumerable<TColumnType>)(from a in (global::System.Collections.Generic.IEnumerable<global::System.DateTime>)enumerable
						select new global::System.DateTime(a.Year, a.Month, a.Day)).Distinct<global::System.DateTime>();
					}
					else if (typeFromHandle == typeof(global::System.DateTime?))
					{
						enumerable = (global::System.Collections.Generic.IEnumerable<TColumnType>)((global::System.Collections.Generic.IEnumerable<global::System.DateTime?>)enumerable).Select(delegate(global::System.DateTime? a)
						{
							if (a != null)
							{
								return new global::System.DateTime?(new global::System.DateTime(a.Value.Year, a.Value.Month, a.Value.Day));
							}
							return null;
						});
					}
				}
				global::System.Collections.Generic.List<TColumnType> list2 = enumerable.ToList<TColumnType>();
				if (base.Comparer != null)
				{
					list2.Sort((global::System.Collections.Generic.IComparer<TColumnType>)base.Comparer);
				}
				else
				{
					try
					{
						list2.Sort();
					}
					catch
					{
					}
				}
				return list2;
			}
			return list.Select(selector).ToList<TColumnType>();
		}

		// Token: 0x04000024 RID: 36
		private global::System.Collections.Generic.IEqualityComparer<TColumnType> _filterComparer;
	}
}
