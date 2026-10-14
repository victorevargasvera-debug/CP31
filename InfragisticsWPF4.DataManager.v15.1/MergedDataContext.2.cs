using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Data;

namespace Infragistics
{
	// Token: 0x0200000E RID: 14
	public class MergedDataContext<T, TColumnType> : global::Infragistics.MergedDataContext
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x000067B3 File Offset: 0x000049B3
		public MergedDataContext(string propertyName, object comparer, global::Infragistics.CachedTypedInfo typedInfo)
		{
			base.PropertyName = propertyName;
			this.Comparer = (comparer as global::System.Collections.Generic.IEqualityComparer<TColumnType>);
			this._unboundColumn = false;
			this.TypedInfo = typedInfo;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000067F4 File Offset: 0x000049F4
		public MergedDataContext(object comparer, global::System.Windows.Data.IValueConverter converter, object converterParam, global::Infragistics.CachedTypedInfo typedInfo)
		{
			this._unboundColumn = true;
			this.Comparer = (comparer as global::System.Collections.Generic.IEqualityComparer<TColumnType>);
			this.Converter = converter;
			this.ConverterParameter = converterParam;
			this.TypedInfo = typedInfo;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00006846 File Offset: 0x00004A46
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000684E File Offset: 0x00004A4E
		public global::System.Collections.Generic.IEqualityComparer<TColumnType> Comparer { get; protected set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00006857 File Offset: 0x00004A57
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000685F File Offset: 0x00004A5F
		private protected global::System.Windows.Data.IValueConverter Converter { protected get; private set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00006868 File Offset: 0x00004A68
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00006870 File Offset: 0x00004A70
		private protected object ConverterParameter { protected get; private set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00006879 File Offset: 0x00004A79
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00006881 File Offset: 0x00004A81
		protected global::Infragistics.SummaryDefinitionCollection Summaries { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000688A File Offset: 0x00004A8A
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00006892 File Offset: 0x00004A92
		protected global::Infragistics.CachedTypedInfo TypedInfo { get; set; }

		// Token: 0x060000D0 RID: 208 RVA: 0x0000689B File Offset: 0x00004A9B
		public override global::System.Collections.IList Merge(global::System.Linq.IQueryable query, global::System.Collections.Generic.List<global::Infragistics.MergedDataContext> mdcs, global::Infragistics.SummaryDefinitionCollection summaries)
		{
			this._rows.Clear();
			this._rowsDictionary.Clear();
			this.Summaries = summaries;
			return this.Merge(query, mdcs, new global::Infragistics.MergeDelegate<object, global::System.Collections.IEnumerable, global::Infragistics.MergedDataContext, object, global::Infragistics.MergedColumnInfo, object>(this.OnGrouping), null);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006908 File Offset: 0x00004B08
		protected internal override global::System.Collections.IList Merge(global::System.Linq.IQueryable iquery, global::System.Collections.Generic.List<global::Infragistics.MergedDataContext> mdcs, global::Infragistics.MergeDelegate<object, global::System.Collections.IEnumerable, global::Infragistics.MergedDataContext, object, global::Infragistics.MergedColumnInfo, object> method, global::Infragistics.MergedColumnInfo parentMCI)
		{
			global::System.Linq.IQueryable<T> queryable = iquery as global::System.Linq.IQueryable<T>;
			if (queryable != null)
			{
				this._mdcs = mdcs;
				int num = mdcs.IndexOf(this);
				if (num != mdcs.Count - 1)
				{
					this._nextMergeDataContext = mdcs[num + 1];
				}
				else
				{
					this._nextMergeDataContext = null;
				}
				global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(T), "param");
				global::System.Linq.Expressions.Expression expression;
				if (this._unboundColumn)
				{
					expression = parameterExpression;
				}
				else
				{
					expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(base.PropertyName, parameterExpression, this.TypedInfo, typeof(TColumnType), default(TColumnType));
				}
				if (!typeof(T).IsValueType)
				{
					global::System.Linq.Expressions.Expression test = global::System.Linq.Expressions.Expression.Equal(parameterExpression, global::System.Linq.Expressions.Expression.Constant(null, typeof(T)));
					global::System.Linq.Expressions.Expression ifTrue = global::System.Linq.Expressions.Expression.Constant(default(TColumnType), typeof(TColumnType));
					expression = global::System.Linq.Expressions.Expression.Condition(test, ifTrue, expression);
				}
				global::System.Linq.Expressions.Expression<global::System.Func<T, TColumnType>> expression2 = global::System.Linq.Expressions.Expression.Lambda(expression, new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression
				}) as global::System.Linq.Expressions.Expression<global::System.Func<T, TColumnType>>;
				global::System.Collections.Generic.IEqualityComparer<TColumnType> equalityComparer = this.Comparer;
				if (equalityComparer == null && this._unboundColumn)
				{
					equalityComparer = new global::Infragistics.ValObjComparer<TColumnType>(this.Converter, this.ConverterParameter);
				}
				global::System.Collections.Generic.IEnumerable<object> source = queryable.AsEnumerable<T>().GroupBy(expression2.Compile(), (TColumnType key, global::System.Collections.Generic.IEnumerable<T> list) => method(key, list, this._nextMergeDataContext, this.MergedObject, parentMCI), equalityComparer);
				source.ToList<object>();
			}
			return this._rows;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006AC0 File Offset: 0x00004CC0
		public object OnGrouping(object key, global::System.Collections.IEnumerable list, global::Infragistics.MergedDataContext nextMergeDataContext, object mergedObject, global::Infragistics.MergedColumnInfo parentMCI)
		{
			global::System.Collections.Generic.IEnumerable<T> source = list as global::System.Collections.Generic.IEnumerable<T>;
			global::Infragistics.MergedColumnInfo mci = new global::Infragistics.MergedColumnInfo
			{
				Key = key,
				Children = source.ToList<T>(),
				DataType = typeof(T),
				Summaries = this.Summaries,
				ParentMergedColumnInfo = parentMCI,
				MergingObject = mergedObject,
				TypedInfo = this.TypedInfo
			};
			int count = source.Count<T>() - 1;
			source.Select((T comic, int index) => this.AppendColumnInfoToRowInfo(comic, mci, index, count, mergedObject)).ToList<global::Infragistics.MergedRowInfo>();
			if (nextMergeDataContext != null)
			{
				nextMergeDataContext.Merge(list.AsQueryable(), this._mdcs, new global::Infragistics.MergeDelegate<object, global::System.Collections.IEnumerable, global::Infragistics.MergedDataContext, object, global::Infragistics.MergedColumnInfo, object>(this.OnGrouping), mci);
			}
			return mci;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006B9C File Offset: 0x00004D9C
		public global::Infragistics.MergedRowInfo AppendColumnInfoToRowInfo(T data, global::Infragistics.MergedColumnInfo mci, int index, int lastIndex, object mergedObject)
		{
			global::Infragistics.MergedRowInfo mergedRowInfo;
			if (this._rowsDictionary.ContainsKey(data))
			{
				mergedRowInfo = this._rowsDictionary[data];
			}
			else
			{
				mergedRowInfo = new global::Infragistics.MergedRowInfo
				{
					Data = data,
					MergedGroups = new global::System.Collections.Generic.List<global::Infragistics.MergedColumnInfo>()
				};
				this._rowsDictionary.Add(data, mergedRowInfo);
				this._rows.Add(mergedRowInfo);
			}
			if (index == lastIndex)
			{
				if (index == 0)
				{
					mergedRowInfo.IsLastRowInGroup.Add(mergedObject, true);
					mergedRowInfo.IsFirstRowInGroup.Add(mergedObject, true);
				}
				else
				{
					mergedRowInfo.IsLastRowInGroup.Add(mergedObject, true);
					mergedRowInfo.IsFirstRowInGroup.Add(mergedObject, false);
				}
			}
			else if (index == 0)
			{
				mergedRowInfo.IsFirstRowInGroup.Add(mergedObject, true);
				mergedRowInfo.IsLastRowInGroup.Add(mergedObject, false);
			}
			else
			{
				mergedRowInfo.IsFirstRowInGroup.Add(mergedObject, false);
				mergedRowInfo.IsLastRowInGroup.Add(mergedObject, false);
			}
			mergedRowInfo.MergedGroups.Add(mci);
			return mergedRowInfo;
		}

		// Token: 0x0400002C RID: 44
		private bool _unboundColumn;

		// Token: 0x0400002D RID: 45
		private global::Infragistics.MergedDataContext _nextMergeDataContext;

		// Token: 0x0400002E RID: 46
		private global::System.Collections.Generic.List<global::Infragistics.MergedDataContext> _mdcs;

		// Token: 0x0400002F RID: 47
		private global::System.Collections.Generic.Dictionary<T, global::Infragistics.MergedRowInfo> _rowsDictionary = new global::System.Collections.Generic.Dictionary<T, global::Infragistics.MergedRowInfo>();

		// Token: 0x04000030 RID: 48
		private global::System.Collections.Generic.List<global::Infragistics.MergedRowInfo> _rows = new global::System.Collections.Generic.List<global::Infragistics.MergedRowInfo>();
	}
}
