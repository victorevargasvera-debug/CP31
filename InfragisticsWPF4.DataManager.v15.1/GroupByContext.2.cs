using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Data;

namespace Infragistics
{
	// Token: 0x02000009 RID: 9
	public class GroupByContext<TColumnType> : global::Infragistics.GroupByContext
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000058C0 File Offset: 0x00003AC0
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000058C8 File Offset: 0x00003AC8
		public global::System.Collections.Generic.IEqualityComparer<TColumnType> Comparer { get; protected set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000058D1 File Offset: 0x00003AD1
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000058D9 File Offset: 0x00003AD9
		private protected global::System.Windows.Data.IValueConverter Converter { protected get; private set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000058E2 File Offset: 0x00003AE2
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000058EA File Offset: 0x00003AEA
		private protected object ConverterParameter { protected get; private set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000058F3 File Offset: 0x00003AF3
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000058FB File Offset: 0x00003AFB
		private protected global::Infragistics.CachedTypedInfo CachedTypedInfo { protected get; private set; }

		// Token: 0x0600007E RID: 126 RVA: 0x00005904 File Offset: 0x00003B04
		public GroupByContext(string propertyName, object comparer, global::Infragistics.CachedTypedInfo cti)
		{
			base.PropertyName = propertyName;
			this.Comparer = (comparer as global::System.Collections.Generic.IEqualityComparer<TColumnType>);
			this._unboundColumn = false;
			this.CachedTypedInfo = cti;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000592D File Offset: 0x00003B2D
		public GroupByContext(object comparer, global::System.Windows.Data.IValueConverter converter, object converterParam, global::Infragistics.CachedTypedInfo cti)
		{
			this._unboundColumn = true;
			this.Comparer = (comparer as global::System.Collections.Generic.IEqualityComparer<TColumnType>);
			this.Converter = converter;
			this.ConverterParameter = converterParam;
			this.CachedTypedInfo = cti;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005960 File Offset: 0x00003B60
		public override global::System.Collections.IList Group<T>(global::System.Linq.IQueryable<T> query)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(T), "param");
			global::System.Linq.Expressions.Expression expression;
			if (this._unboundColumn)
			{
				expression = parameterExpression;
			}
			else
			{
				expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(base.PropertyName, parameterExpression, this.CachedTypedInfo, typeof(TColumnType), default(TColumnType));
			}
			if (!typeof(T).IsValueType)
			{
				global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, typeof(T)));
				global::System.Linq.Expressions.Expression ifTrue = global::System.Linq.Expressions.Expression.Constant(default(TColumnType), typeof(TColumnType));
				expression = global::System.Linq.Expressions.Expression.Condition(test, ifTrue, expression);
			}
			global::System.Linq.Expressions.Expression<global::System.Func<T, TColumnType>> keySelector = global::System.Linq.Expressions.Expression.Lambda(expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			}) as global::System.Linq.Expressions.Expression<global::System.Func<T, TColumnType>>;
			global::System.Collections.Generic.List<global::Infragistics.GroupByDataContext> list = new global::System.Collections.Generic.List<global::Infragistics.GroupByDataContext>();
			global::System.Collections.Generic.IEqualityComparer<TColumnType> equalityComparer = this.Comparer;
			if (equalityComparer == null && this._unboundColumn)
			{
				equalityComparer = new global::Infragistics.ValObjComparer<TColumnType>(this.Converter, this.ConverterParameter);
			}
			global::System.Linq.IQueryable<global::System.Linq.IGrouping<TColumnType, T>> queryable = query.GroupBy(keySelector, equalityComparer);
			if (this._unboundColumn)
			{
				using (global::System.Collections.Generic.IEnumerator<global::System.Linq.IGrouping<TColumnType, T>> enumerator = queryable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Linq.IGrouping<TColumnType, T> grouping = enumerator.Current;
						global::Infragistics.ValObj valObj = new global::Infragistics.ValObj();
						global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
						binding.Converter = this.Converter;
						binding.ConverterParameter = this.ConverterParameter;
						binding.Source = grouping.Key;
						valObj.SetBinding(global::Infragistics.ValObj.ValueProperty, binding);
						list.Add(new global::Infragistics.GroupByDataContext
						{
							Records = grouping.ToList<T>(),
							Value = valObj.Value,
							TypedInfo = this.CachedTypedInfo,
							Summaries = base.Summaries
						});
					}
					return list;
				}
			}
			foreach (global::System.Linq.IGrouping<TColumnType, T> grouping2 in queryable)
			{
				list.Add(new global::Infragistics.GroupByDataContext
				{
					Records = grouping2.ToList<T>(),
					Value = grouping2.Key,
					TypedInfo = this.CachedTypedInfo,
					Summaries = base.Summaries
				});
			}
			return list;
		}

		// Token: 0x0400000D RID: 13
		private bool _unboundColumn;
	}
}
