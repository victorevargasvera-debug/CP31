using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Data;

namespace Infragistics
{
	// Token: 0x02000013 RID: 19
	public class SortContext<T, TColumnType> : global::Infragistics.SortContext
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00006FF4 File Offset: 0x000051F4
		public SortContext(string propertyName, bool sortAscending, bool caseSensitiveSort, object comparer, global::Infragistics.CachedTypedInfo cachedTypeInfo)
		{
			base.SortPropertyName = propertyName;
			base.SortAscending = sortAscending;
			base.CaseSensitiveSort = caseSensitiveSort;
			this.Comparer = (global::System.Collections.Generic.IComparer<TColumnType>)comparer;
			base.PropertyType = typeof(TColumnType);
			base.DataType = typeof(T);
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(T), "param");
			global::System.Linq.Expressions.Expression expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(propertyName, parameterExpression, cachedTypeInfo, base.PropertyType, default(TColumnType));
			if (!caseSensitiveSort && base.PropertyType == typeof(string) && comparer == null)
			{
				this.Comparer = (global::System.Collections.Generic.IComparer<TColumnType>)global::System.StringComparer.CurrentCultureIgnoreCase;
			}
			if (!parameterExpression.Type.IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, base.DataType));
				global::System.Linq.Expressions.Expression ifTrue = global::System.Linq.Expressions.Expression.Constant(default(TColumnType), base.PropertyType);
				expression = global::System.Linq.Expressions.Expression.Condition(test, ifTrue, expression);
			}
			this._lambda = global::System.Linq.Expressions.Expression.Lambda(expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000710A File Offset: 0x0000530A
		public SortContext(string propertyName, bool sortAscending, bool caseSensitiveSort, global::Infragistics.CachedTypedInfo cachedTypeInfo) : this(propertyName, sortAscending, caseSensitiveSort, null, cachedTypeInfo)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00007118 File Offset: 0x00005318
		public SortContext(bool sortAscending, object comparer, global::System.Windows.Data.IValueConverter converter, object converterParam, global::Infragistics.CachedTypedInfo cachedTypeInfo)
		{
			base.SortAscending = sortAscending;
			this.Converter = converter;
			this.ConverterParameter = converterParam;
			base.PropertyType = (base.DataType = typeof(T));
			this.Comparer = (comparer as global::System.Collections.Generic.IComparer<TColumnType>);
			if (comparer == null && converter != null)
			{
				global::Infragistics.ValObjComparer<TColumnType> comparer2 = new global::Infragistics.ValObjComparer<TColumnType>(converter, converterParam);
				this.Comparer = comparer2;
			}
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(T), "param");
			global::System.Linq.Expressions.Expression expression = parameterExpression;
			if (!parameterExpression.Type.IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, base.DataType));
				global::System.Linq.Expressions.Expression ifTrue = global::System.Linq.Expressions.Expression.Constant(default(TColumnType), base.PropertyType);
				expression = global::System.Linq.Expressions.Expression.Condition(test, ifTrue, expression);
			}
			this._lambda = global::System.Linq.Expressions.Expression.Lambda(expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000071F6 File Offset: 0x000053F6
		protected global::System.Linq.Expressions.LambdaExpression Lambda
		{
			get
			{
				return this._lambda;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000071FE File Offset: 0x000053FE
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00007206 File Offset: 0x00005406
		private protected global::System.Collections.Generic.IComparer<TColumnType> Comparer { protected get; private set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000720F File Offset: 0x0000540F
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00007217 File Offset: 0x00005417
		private protected global::System.Windows.Data.IValueConverter Converter { protected get; private set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00007220 File Offset: 0x00005420
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00007228 File Offset: 0x00005428
		private protected object ConverterParameter { protected get; private set; }

		// Token: 0x0600010A RID: 266 RVA: 0x00007234 File Offset: 0x00005434
		public override global::System.Linq.IOrderedQueryable<TDataType> Sort<TDataType>(global::System.Linq.IQueryable<TDataType> query)
		{
			global::System.Linq.Expressions.Expression<global::System.Func<TDataType, TColumnType>> keySelector = (global::System.Linq.Expressions.Expression<global::System.Func<TDataType, TColumnType>>)this._lambda;
			if (this.Comparer != null)
			{
				if (base.SortAscending)
				{
					return query.OrderBy(keySelector, this.Comparer);
				}
				return query.OrderByDescending(keySelector, this.Comparer);
			}
			else
			{
				if (base.SortAscending)
				{
					return query.OrderBy(keySelector);
				}
				return query.OrderByDescending(keySelector);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00007290 File Offset: 0x00005490
		public override global::System.Linq.IOrderedQueryable<TDataType> AppendSort<TDataType>(global::System.Linq.IOrderedQueryable<TDataType> query)
		{
			global::System.Linq.Expressions.Expression<global::System.Func<TDataType, TColumnType>> keySelector = (global::System.Linq.Expressions.Expression<global::System.Func<TDataType, TColumnType>>)this._lambda;
			if (this.Comparer != null)
			{
				if (base.SortAscending)
				{
					return query.ThenBy(keySelector, this.Comparer);
				}
				return query.ThenByDescending(keySelector, this.Comparer);
			}
			else
			{
				if (base.SortAscending)
				{
					return query.ThenBy(keySelector);
				}
				return query.ThenByDescending(keySelector);
			}
		}

		// Token: 0x04000047 RID: 71
		private global::System.Linq.Expressions.LambdaExpression _lambda;
	}
}
