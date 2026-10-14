using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x02000467 RID: 1127
	internal static class ReflectionUtil
	{
		// Token: 0x0600378E RID: 14222 RVA: 0x000B3EBC File Offset: 0x000B20BC
		static ReflectionUtil()
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod>();
			dictionary.Add("AsQueryable(IEnumerable`1<T0>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AsQueryableGeneric);
			dictionary.Add("AsQueryable(IEnumerable)->IQueryable", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AsQueryable);
			dictionary.Add("Where(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Where);
			dictionary.Add("Where(IQueryable`1<T0>, Expression`1<Func`3<T0, Int32, Boolean>>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.WhereOrdinal);
			dictionary.Add("OfType(IQueryable)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OfType);
			dictionary.Add("Cast(IQueryable)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Cast);
			dictionary.Add("Select(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>)->IQueryable`1<T1>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Select);
			dictionary.Add("Select(IQueryable`1<T0>, Expression`1<Func`3<T0, Int32, T1>>)->IQueryable`1<T1>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SelectOrdinal);
			dictionary.Add("SelectMany(IQueryable`1<T0>, Expression`1<Func`2<T0, IEnumerable`1<T1>>>)->IQueryable`1<T1>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SelectMany);
			dictionary.Add("SelectMany(IQueryable`1<T0>, Expression`1<Func`3<T0, Int32, IEnumerable`1<T1>>>)->IQueryable`1<T1>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SelectManyOrdinal);
			dictionary.Add("SelectMany(IQueryable`1<T0>, Expression`1<Func`3<T0, Int32, IEnumerable`1<T1>>>, Expression`1<Func`3<T0, T1, T2>>)->IQueryable`1<T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SelectManyOrdinalResultSelector);
			dictionary.Add("SelectMany(IQueryable`1<T0>, Expression`1<Func`2<T0, IEnumerable`1<T1>>>, Expression`1<Func`3<T0, T1, T2>>)->IQueryable`1<T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SelectManyResultSelector);
			dictionary.Add("Join(IQueryable`1<T0>, IEnumerable`1<T1>, Expression`1<Func`2<T0, T2>>, Expression`1<Func`2<T1, T2>>, Expression`1<Func`3<T0, T1, T3>>)->IQueryable`1<T3>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Join);
			dictionary.Add("Join(IQueryable`1<T0>, IEnumerable`1<T1>, Expression`1<Func`2<T0, T2>>, Expression`1<Func`2<T1, T2>>, Expression`1<Func`3<T0, T1, T3>>, IEqualityComparer`1<T2>)->IQueryable`1<T3>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.JoinComparer);
			dictionary.Add("GroupJoin(IQueryable`1<T0>, IEnumerable`1<T1>, Expression`1<Func`2<T0, T2>>, Expression`1<Func`2<T1, T2>>, Expression`1<Func`3<T0, IEnumerable`1<T1>, T3>>)->IQueryable`1<T3>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupJoin);
			dictionary.Add("GroupJoin(IQueryable`1<T0>, IEnumerable`1<T1>, Expression`1<Func`2<T0, T2>>, Expression`1<Func`2<T1, T2>>, Expression`1<Func`3<T0, IEnumerable`1<T1>, T3>>, IEqualityComparer`1<T2>)->IQueryable`1<T3>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupJoinComparer);
			dictionary.Add("OrderBy(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>)->IOrderedQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OrderBy);
			dictionary.Add("OrderBy(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>, IComparer`1<T1>)->IOrderedQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OrderByComparer);
			dictionary.Add("OrderByDescending(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>)->IOrderedQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OrderByDescending);
			dictionary.Add("OrderByDescending(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>, IComparer`1<T1>)->IOrderedQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OrderByDescendingComparer);
			dictionary.Add("ThenBy(IOrderedQueryable`1<T0>, Expression`1<Func`2<T0, T1>>)->IOrderedQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ThenBy);
			dictionary.Add("ThenBy(IOrderedQueryable`1<T0>, Expression`1<Func`2<T0, T1>>, IComparer`1<T1>)->IOrderedQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ThenByComparer);
			dictionary.Add("ThenByDescending(IOrderedQueryable`1<T0>, Expression`1<Func`2<T0, T1>>)->IOrderedQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ThenByDescending);
			dictionary.Add("ThenByDescending(IOrderedQueryable`1<T0>, Expression`1<Func`2<T0, T1>>, IComparer`1<T1>)->IOrderedQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ThenByDescendingComparer);
			dictionary.Add("Take(IQueryable`1<T0>, Int32)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Take);
			dictionary.Add("TakeWhile(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.TakeWhile);
			dictionary.Add("TakeWhile(IQueryable`1<T0>, Expression`1<Func`3<T0, Int32, Boolean>>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.TakeWhileOrdinal);
			dictionary.Add("Skip(IQueryable`1<T0>, Int32)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Skip);
			dictionary.Add("SkipWhile(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SkipWhile);
			dictionary.Add("SkipWhile(IQueryable`1<T0>, Expression`1<Func`3<T0, Int32, Boolean>>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SkipWhileOrdinal);
			dictionary.Add("GroupBy(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>)->IQueryable`1<IGrouping`2<T1, T0>>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupBy);
			dictionary.Add("GroupBy(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>, Expression`1<Func`2<T0, T2>>)->IQueryable`1<IGrouping`2<T1, T2>>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelector);
			dictionary.Add("GroupBy(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>, IEqualityComparer`1<T1>)->IQueryable`1<IGrouping`2<T1, T0>>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByComparer);
			dictionary.Add("GroupBy(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>, Expression`1<Func`2<T0, T2>>, IEqualityComparer`1<T1>)->IQueryable`1<IGrouping`2<T1, T2>>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelectorComparer);
			dictionary.Add("GroupBy(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>, Expression`1<Func`2<T0, T2>>, Expression`1<Func`3<T1, IEnumerable`1<T2>, T3>>)->IQueryable`1<T3>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelectorResultSelector);
			dictionary.Add("GroupBy(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>, Expression`1<Func`3<T1, IEnumerable`1<T0>, T2>>)->IQueryable`1<T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByResultSelector);
			dictionary.Add("GroupBy(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>, Expression`1<Func`3<T1, IEnumerable`1<T0>, T2>>, IEqualityComparer`1<T1>)->IQueryable`1<T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByResultSelectorComparer);
			dictionary.Add("GroupBy(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>, Expression`1<Func`2<T0, T2>>, Expression`1<Func`3<T1, IEnumerable`1<T2>, T3>>, IEqualityComparer`1<T1>)->IQueryable`1<T3>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelectorResultSelectorComparer);
			dictionary.Add("Distinct(IQueryable`1<T0>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Distinct);
			dictionary.Add("Distinct(IQueryable`1<T0>, IEqualityComparer`1<T0>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.DistinctComparer);
			dictionary.Add("Concat(IQueryable`1<T0>, IEnumerable`1<T0>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Concat);
			dictionary.Add("Zip(IQueryable`1<T0>, IEnumerable`1<T1>, Expression`1<Func`3<T0, T1, T2>>)->IQueryable`1<T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Zip);
			dictionary.Add("Union(IQueryable`1<T0>, IEnumerable`1<T0>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Union);
			dictionary.Add("Union(IQueryable`1<T0>, IEnumerable`1<T0>, IEqualityComparer`1<T0>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.UnionComparer);
			dictionary.Add("Intersect(IQueryable`1<T0>, IEnumerable`1<T0>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Intersect);
			dictionary.Add("Intersect(IQueryable`1<T0>, IEnumerable`1<T0>, IEqualityComparer`1<T0>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.IntersectComparer);
			dictionary.Add("Except(IQueryable`1<T0>, IEnumerable`1<T0>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Except);
			dictionary.Add("Except(IQueryable`1<T0>, IEnumerable`1<T0>, IEqualityComparer`1<T0>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ExceptComparer);
			dictionary.Add("First(IQueryable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.First);
			dictionary.Add("First(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstPredicate);
			dictionary.Add("FirstOrDefault(IQueryable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstOrDefault);
			dictionary.Add("FirstOrDefault(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstOrDefaultPredicate);
			dictionary.Add("Last(IQueryable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Last);
			dictionary.Add("Last(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LastPredicate);
			dictionary.Add("LastOrDefault(IQueryable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LastOrDefault);
			dictionary.Add("LastOrDefault(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LastOrDefaultPredicate);
			dictionary.Add("Single(IQueryable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Single);
			dictionary.Add("Single(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SinglePredicate);
			dictionary.Add("SingleOrDefault(IQueryable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SingleOrDefault);
			dictionary.Add("SingleOrDefault(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SingleOrDefaultPredicate);
			dictionary.Add("ElementAt(IQueryable`1<T0>, Int32)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ElementAt);
			dictionary.Add("ElementAtOrDefault(IQueryable`1<T0>, Int32)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ElementAtOrDefault);
			dictionary.Add("DefaultIfEmpty(IQueryable`1<T0>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.DefaultIfEmpty);
			dictionary.Add("DefaultIfEmpty(IQueryable`1<T0>, T0)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.DefaultIfEmptyValue);
			dictionary.Add("Contains(IQueryable`1<T0>, T0)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Contains);
			dictionary.Add("Contains(IQueryable`1<T0>, T0, IEqualityComparer`1<T0>)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ContainsComparer);
			dictionary.Add("Reverse(IQueryable`1<T0>)->IQueryable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Reverse);
			dictionary.Add("SequenceEqual(IQueryable`1<T0>, IEnumerable`1<T0>)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SequenceEqual);
			dictionary.Add("SequenceEqual(IQueryable`1<T0>, IEnumerable`1<T0>, IEqualityComparer`1<T0>)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SequenceEqualComparer);
			dictionary.Add("Any(IQueryable`1<T0>)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Any);
			dictionary.Add("Any(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AnyPredicate);
			dictionary.Add("All(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.All);
			dictionary.Add("Count(IQueryable`1<T0>)->Int32", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Count);
			dictionary.Add("Count(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->Int32", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.CountPredicate);
			dictionary.Add("LongCount(IQueryable`1<T0>)->Int64", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LongCount);
			dictionary.Add("LongCount(IQueryable`1<T0>, Expression`1<Func`2<T0, Boolean>>)->Int64", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LongCountPredicate);
			dictionary.Add("Min(IQueryable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Min);
			dictionary.Add("Min(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>)->T1", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinSelector);
			dictionary.Add("Max(IQueryable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Max);
			dictionary.Add("Max(IQueryable`1<T0>, Expression`1<Func`2<T0, T1>>)->T1", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxSelector);
			dictionary.Add("Sum(IQueryable`1<Int32>)->Int32", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumInt);
			dictionary.Add("Sum(IQueryable`1<Nullable`1<Int32>>)->Nullable`1<Int32>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableInt);
			dictionary.Add("Sum(IQueryable`1<Int64>)->Int64", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumLong);
			dictionary.Add("Sum(IQueryable`1<Nullable`1<Int64>>)->Nullable`1<Int64>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableLong);
			dictionary.Add("Sum(IQueryable`1<Single>)->Single", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumSingle);
			dictionary.Add("Sum(IQueryable`1<Nullable`1<Single>>)->Nullable`1<Single>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableSingle);
			dictionary.Add("Sum(IQueryable`1<Double>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumDouble);
			dictionary.Add("Sum(IQueryable`1<Nullable`1<Double>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableDouble);
			dictionary.Add("Sum(IQueryable`1<Decimal>)->Decimal", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumDecimal);
			dictionary.Add("Sum(IQueryable`1<Nullable`1<Decimal>>)->Nullable`1<Decimal>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableDecimal);
			dictionary.Add("Sum(IQueryable`1<T0>, Expression`1<Func`2<T0, Int32>>)->Int32", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumIntSelector);
			dictionary.Add("Sum(IQueryable`1<T0>, Expression`1<Func`2<T0, Nullable`1<Int32>>>)->Nullable`1<Int32>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableIntSelector);
			dictionary.Add("Sum(IQueryable`1<T0>, Expression`1<Func`2<T0, Int64>>)->Int64", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumLongSelector);
			dictionary.Add("Sum(IQueryable`1<T0>, Expression`1<Func`2<T0, Nullable`1<Int64>>>)->Nullable`1<Int64>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableLongSelector);
			dictionary.Add("Sum(IQueryable`1<T0>, Expression`1<Func`2<T0, Single>>)->Single", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumSingleSelector);
			dictionary.Add("Sum(IQueryable`1<T0>, Expression`1<Func`2<T0, Nullable`1<Single>>>)->Nullable`1<Single>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableSingleSelector);
			dictionary.Add("Sum(IQueryable`1<T0>, Expression`1<Func`2<T0, Double>>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumDoubleSelector);
			dictionary.Add("Sum(IQueryable`1<T0>, Expression`1<Func`2<T0, Nullable`1<Double>>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableDoubleSelector);
			dictionary.Add("Sum(IQueryable`1<T0>, Expression`1<Func`2<T0, Decimal>>)->Decimal", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumDecimalSelector);
			dictionary.Add("Sum(IQueryable`1<T0>, Expression`1<Func`2<T0, Nullable`1<Decimal>>>)->Nullable`1<Decimal>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableDecimalSelector);
			dictionary.Add("Average(IQueryable`1<Int32>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageInt);
			dictionary.Add("Average(IQueryable`1<Nullable`1<Int32>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableInt);
			dictionary.Add("Average(IQueryable`1<Int64>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageLong);
			dictionary.Add("Average(IQueryable`1<Nullable`1<Int64>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableLong);
			dictionary.Add("Average(IQueryable`1<Single>)->Single", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageSingle);
			dictionary.Add("Average(IQueryable`1<Nullable`1<Single>>)->Nullable`1<Single>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableSingle);
			dictionary.Add("Average(IQueryable`1<Double>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageDouble);
			dictionary.Add("Average(IQueryable`1<Nullable`1<Double>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableDouble);
			dictionary.Add("Average(IQueryable`1<Decimal>)->Decimal", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageDecimal);
			dictionary.Add("Average(IQueryable`1<Nullable`1<Decimal>>)->Nullable`1<Decimal>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableDecimal);
			dictionary.Add("Average(IQueryable`1<T0>, Expression`1<Func`2<T0, Int32>>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageIntSelector);
			dictionary.Add("Average(IQueryable`1<T0>, Expression`1<Func`2<T0, Nullable`1<Int32>>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableIntSelector);
			dictionary.Add("Average(IQueryable`1<T0>, Expression`1<Func`2<T0, Single>>)->Single", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageSingleSelector);
			dictionary.Add("Average(IQueryable`1<T0>, Expression`1<Func`2<T0, Nullable`1<Single>>>)->Nullable`1<Single>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableSingleSelector);
			dictionary.Add("Average(IQueryable`1<T0>, Expression`1<Func`2<T0, Int64>>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageLongSelector);
			dictionary.Add("Average(IQueryable`1<T0>, Expression`1<Func`2<T0, Nullable`1<Int64>>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableLongSelector);
			dictionary.Add("Average(IQueryable`1<T0>, Expression`1<Func`2<T0, Double>>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageDoubleSelector);
			dictionary.Add("Average(IQueryable`1<T0>, Expression`1<Func`2<T0, Nullable`1<Double>>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableDoubleSelector);
			dictionary.Add("Average(IQueryable`1<T0>, Expression`1<Func`2<T0, Decimal>>)->Decimal", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageDecimalSelector);
			dictionary.Add("Average(IQueryable`1<T0>, Expression`1<Func`2<T0, Nullable`1<Decimal>>>)->Nullable`1<Decimal>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableDecimalSelector);
			dictionary.Add("Aggregate(IQueryable`1<T0>, Expression`1<Func`3<T0, T0, T0>>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Aggregate);
			dictionary.Add("Aggregate(IQueryable`1<T0>, T1, Expression`1<Func`3<T1, T0, T1>>)->T1", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AggregateSeed);
			dictionary.Add("Aggregate(IQueryable`1<T0>, T1, Expression`1<Func`3<T1, T0, T1>>, Expression`1<Func`2<T1, T2>>)->T2", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AggregateSeedSelector);
			dictionary.Add("Where(IEnumerable`1<T0>, Func`2<T0, Boolean>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Where);
			dictionary.Add("Where(IEnumerable`1<T0>, Func`3<T0, Int32, Boolean>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.WhereOrdinal);
			dictionary.Add("Select(IEnumerable`1<T0>, Func`2<T0, T1>)->IEnumerable`1<T1>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Select);
			dictionary.Add("Select(IEnumerable`1<T0>, Func`3<T0, Int32, T1>)->IEnumerable`1<T1>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SelectOrdinal);
			dictionary.Add("SelectMany(IEnumerable`1<T0>, Func`2<T0, IEnumerable`1<T1>>)->IEnumerable`1<T1>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SelectMany);
			dictionary.Add("SelectMany(IEnumerable`1<T0>, Func`3<T0, Int32, IEnumerable`1<T1>>)->IEnumerable`1<T1>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SelectManyOrdinal);
			dictionary.Add("SelectMany(IEnumerable`1<T0>, Func`3<T0, Int32, IEnumerable`1<T1>>, Func`3<T0, T1, T2>)->IEnumerable`1<T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SelectManyOrdinalResultSelector);
			dictionary.Add("SelectMany(IEnumerable`1<T0>, Func`2<T0, IEnumerable`1<T1>>, Func`3<T0, T1, T2>)->IEnumerable`1<T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SelectManyResultSelector);
			dictionary.Add("Take(IEnumerable`1<T0>, Int32)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Take);
			dictionary.Add("TakeWhile(IEnumerable`1<T0>, Func`2<T0, Boolean>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.TakeWhile);
			dictionary.Add("TakeWhile(IEnumerable`1<T0>, Func`3<T0, Int32, Boolean>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.TakeWhileOrdinal);
			dictionary.Add("Skip(IEnumerable`1<T0>, Int32)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Skip);
			dictionary.Add("SkipWhile(IEnumerable`1<T0>, Func`2<T0, Boolean>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SkipWhile);
			dictionary.Add("SkipWhile(IEnumerable`1<T0>, Func`3<T0, Int32, Boolean>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SkipWhileOrdinal);
			dictionary.Add("Join(IEnumerable`1<T0>, IEnumerable`1<T1>, Func`2<T0, T2>, Func`2<T1, T2>, Func`3<T0, T1, T3>)->IEnumerable`1<T3>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Join);
			dictionary.Add("Join(IEnumerable`1<T0>, IEnumerable`1<T1>, Func`2<T0, T2>, Func`2<T1, T2>, Func`3<T0, T1, T3>, IEqualityComparer`1<T2>)->IEnumerable`1<T3>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.JoinComparer);
			dictionary.Add("GroupJoin(IEnumerable`1<T0>, IEnumerable`1<T1>, Func`2<T0, T2>, Func`2<T1, T2>, Func`3<T0, IEnumerable`1<T1>, T3>)->IEnumerable`1<T3>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupJoin);
			dictionary.Add("GroupJoin(IEnumerable`1<T0>, IEnumerable`1<T1>, Func`2<T0, T2>, Func`2<T1, T2>, Func`3<T0, IEnumerable`1<T1>, T3>, IEqualityComparer`1<T2>)->IEnumerable`1<T3>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupJoinComparer);
			dictionary.Add("OrderBy(IEnumerable`1<T0>, Func`2<T0, T1>)->IOrderedEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OrderBy);
			dictionary.Add("OrderBy(IEnumerable`1<T0>, Func`2<T0, T1>, IComparer`1<T1>)->IOrderedEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OrderByComparer);
			dictionary.Add("OrderByDescending(IEnumerable`1<T0>, Func`2<T0, T1>)->IOrderedEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OrderByDescending);
			dictionary.Add("OrderByDescending(IEnumerable`1<T0>, Func`2<T0, T1>, IComparer`1<T1>)->IOrderedEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OrderByDescendingComparer);
			dictionary.Add("ThenBy(IOrderedEnumerable`1<T0>, Func`2<T0, T1>)->IOrderedEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ThenBy);
			dictionary.Add("ThenBy(IOrderedEnumerable`1<T0>, Func`2<T0, T1>, IComparer`1<T1>)->IOrderedEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ThenByComparer);
			dictionary.Add("ThenByDescending(IOrderedEnumerable`1<T0>, Func`2<T0, T1>)->IOrderedEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ThenByDescending);
			dictionary.Add("ThenByDescending(IOrderedEnumerable`1<T0>, Func`2<T0, T1>, IComparer`1<T1>)->IOrderedEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ThenByDescendingComparer);
			dictionary.Add("GroupBy(IEnumerable`1<T0>, Func`2<T0, T1>)->IEnumerable`1<IGrouping`2<T1, T0>>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupBy);
			dictionary.Add("GroupBy(IEnumerable`1<T0>, Func`2<T0, T1>, IEqualityComparer`1<T1>)->IEnumerable`1<IGrouping`2<T1, T0>>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByComparer);
			dictionary.Add("GroupBy(IEnumerable`1<T0>, Func`2<T0, T1>, Func`2<T0, T2>)->IEnumerable`1<IGrouping`2<T1, T2>>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelector);
			dictionary.Add("GroupBy(IEnumerable`1<T0>, Func`2<T0, T1>, Func`2<T0, T2>, IEqualityComparer`1<T1>)->IEnumerable`1<IGrouping`2<T1, T2>>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelectorComparer);
			dictionary.Add("GroupBy(IEnumerable`1<T0>, Func`2<T0, T1>, Func`3<T1, IEnumerable`1<T0>, T2>)->IEnumerable`1<T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByResultSelector);
			dictionary.Add("GroupBy(IEnumerable`1<T0>, Func`2<T0, T1>, Func`2<T0, T2>, Func`3<T1, IEnumerable`1<T2>, T3>)->IEnumerable`1<T3>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelectorResultSelector);
			dictionary.Add("GroupBy(IEnumerable`1<T0>, Func`2<T0, T1>, Func`3<T1, IEnumerable`1<T0>, T2>, IEqualityComparer`1<T1>)->IEnumerable`1<T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByResultSelectorComparer);
			dictionary.Add("GroupBy(IEnumerable`1<T0>, Func`2<T0, T1>, Func`2<T0, T2>, Func`3<T1, IEnumerable`1<T2>, T3>, IEqualityComparer`1<T1>)->IEnumerable`1<T3>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.GroupByElementSelectorResultSelectorComparer);
			dictionary.Add("Concat(IEnumerable`1<T0>, IEnumerable`1<T0>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Concat);
			dictionary.Add("Zip(IEnumerable`1<T0>, IEnumerable`1<T1>, Func`3<T0, T1, T2>)->IEnumerable`1<T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Zip);
			dictionary.Add("Distinct(IEnumerable`1<T0>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Distinct);
			dictionary.Add("Distinct(IEnumerable`1<T0>, IEqualityComparer`1<T0>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.DistinctComparer);
			dictionary.Add("Union(IEnumerable`1<T0>, IEnumerable`1<T0>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Union);
			dictionary.Add("Union(IEnumerable`1<T0>, IEnumerable`1<T0>, IEqualityComparer`1<T0>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.UnionComparer);
			dictionary.Add("Intersect(IEnumerable`1<T0>, IEnumerable`1<T0>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Intersect);
			dictionary.Add("Intersect(IEnumerable`1<T0>, IEnumerable`1<T0>, IEqualityComparer`1<T0>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.IntersectComparer);
			dictionary.Add("Except(IEnumerable`1<T0>, IEnumerable`1<T0>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Except);
			dictionary.Add("Except(IEnumerable`1<T0>, IEnumerable`1<T0>, IEqualityComparer`1<T0>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ExceptComparer);
			dictionary.Add("Reverse(IEnumerable`1<T0>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Reverse);
			dictionary.Add("SequenceEqual(IEnumerable`1<T0>, IEnumerable`1<T0>)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SequenceEqual);
			dictionary.Add("SequenceEqual(IEnumerable`1<T0>, IEnumerable`1<T0>, IEqualityComparer`1<T0>)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SequenceEqualComparer);
			dictionary.Add("AsEnumerable(IEnumerable`1<T0>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AsEnumerable);
			dictionary.Add("ToArray(IEnumerable`1<T0>)->TSource[]", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.NotSupported);
			dictionary.Add("ToList(IEnumerable`1<T0>)->List`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ToList);
			dictionary.Add("ToDictionary(IEnumerable`1<T0>, Func`2<T0, T1>)->Dictionary`2<T1, T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.NotSupported);
			dictionary.Add("ToDictionary(IEnumerable`1<T0>, Func`2<T0, T1>, IEqualityComparer`1<T1>)->Dictionary`2<T1, T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.NotSupported);
			dictionary.Add("ToDictionary(IEnumerable`1<T0>, Func`2<T0, T1>, Func`2<T0, T2>)->Dictionary`2<T1, T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.NotSupported);
			dictionary.Add("ToDictionary(IEnumerable`1<T0>, Func`2<T0, T1>, Func`2<T0, T2>, IEqualityComparer`1<T1>)->Dictionary`2<T1, T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.NotSupported);
			dictionary.Add("ToLookup(IEnumerable`1<T0>, Func`2<T0, T1>)->ILookup`2<T1, T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.NotSupported);
			dictionary.Add("ToLookup(IEnumerable`1<T0>, Func`2<T0, T1>, IEqualityComparer`1<T1>)->ILookup`2<T1, T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.NotSupported);
			dictionary.Add("ToLookup(IEnumerable`1<T0>, Func`2<T0, T1>, Func`2<T0, T2>)->ILookup`2<T1, T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.NotSupported);
			dictionary.Add("ToLookup(IEnumerable`1<T0>, Func`2<T0, T1>, Func`2<T0, T2>, IEqualityComparer`1<T1>)->ILookup`2<T1, T2>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.NotSupported);
			dictionary.Add("DefaultIfEmpty(IEnumerable`1<T0>)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.DefaultIfEmpty);
			dictionary.Add("DefaultIfEmpty(IEnumerable`1<T0>, T0)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.DefaultIfEmptyValue);
			dictionary.Add("OfType(IEnumerable)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.OfType);
			dictionary.Add("Cast(IEnumerable)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Cast);
			dictionary.Add("First(IEnumerable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.First);
			dictionary.Add("First(IEnumerable`1<T0>, Func`2<T0, Boolean>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstPredicate);
			dictionary.Add("FirstOrDefault(IEnumerable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstOrDefault);
			dictionary.Add("FirstOrDefault(IEnumerable`1<T0>, Func`2<T0, Boolean>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstOrDefaultPredicate);
			dictionary.Add("Last(IEnumerable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Last);
			dictionary.Add("Last(IEnumerable`1<T0>, Func`2<T0, Boolean>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LastPredicate);
			dictionary.Add("LastOrDefault(IEnumerable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LastOrDefault);
			dictionary.Add("LastOrDefault(IEnumerable`1<T0>, Func`2<T0, Boolean>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LastOrDefaultPredicate);
			dictionary.Add("Single(IEnumerable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Single);
			dictionary.Add("Single(IEnumerable`1<T0>, Func`2<T0, Boolean>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SinglePredicate);
			dictionary.Add("SingleOrDefault(IEnumerable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SingleOrDefault);
			dictionary.Add("SingleOrDefault(IEnumerable`1<T0>, Func`2<T0, Boolean>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SingleOrDefaultPredicate);
			dictionary.Add("ElementAt(IEnumerable`1<T0>, Int32)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ElementAt);
			dictionary.Add("ElementAtOrDefault(IEnumerable`1<T0>, Int32)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ElementAtOrDefault);
			dictionary.Add("Range(Int32, Int32)->IEnumerable`1<Int32>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.NotSupported);
			dictionary.Add("Repeat(T0, Int32)->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.NotSupported);
			dictionary.Add("Empty()->IEnumerable`1<T0>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Empty);
			dictionary.Add("Any(IEnumerable`1<T0>)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Any);
			dictionary.Add("Any(IEnumerable`1<T0>, Func`2<T0, Boolean>)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AnyPredicate);
			dictionary.Add("All(IEnumerable`1<T0>, Func`2<T0, Boolean>)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.All);
			dictionary.Add("Count(IEnumerable`1<T0>)->Int32", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Count);
			dictionary.Add("Count(IEnumerable`1<T0>, Func`2<T0, Boolean>)->Int32", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.CountPredicate);
			dictionary.Add("LongCount(IEnumerable`1<T0>)->Int64", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LongCount);
			dictionary.Add("LongCount(IEnumerable`1<T0>, Func`2<T0, Boolean>)->Int64", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LongCountPredicate);
			dictionary.Add("Contains(IEnumerable`1<T0>, T0)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Contains);
			dictionary.Add("Contains(IEnumerable`1<T0>, T0, IEqualityComparer`1<T0>)->Boolean", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.ContainsComparer);
			dictionary.Add("Aggregate(IEnumerable`1<T0>, Func`3<T0, T0, T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Aggregate);
			dictionary.Add("Aggregate(IEnumerable`1<T0>, T1, Func`3<T1, T0, T1>)->T1", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AggregateSeed);
			dictionary.Add("Aggregate(IEnumerable`1<T0>, T1, Func`3<T1, T0, T1>, Func`2<T1, T2>)->T2", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AggregateSeedSelector);
			dictionary.Add("Sum(IEnumerable`1<Int32>)->Int32", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumInt);
			dictionary.Add("Sum(IEnumerable`1<Nullable`1<Int32>>)->Nullable`1<Int32>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableInt);
			dictionary.Add("Sum(IEnumerable`1<Int64>)->Int64", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumLong);
			dictionary.Add("Sum(IEnumerable`1<Nullable`1<Int64>>)->Nullable`1<Int64>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableLong);
			dictionary.Add("Sum(IEnumerable`1<Single>)->Single", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumSingle);
			dictionary.Add("Sum(IEnumerable`1<Nullable`1<Single>>)->Nullable`1<Single>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableSingle);
			dictionary.Add("Sum(IEnumerable`1<Double>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumDouble);
			dictionary.Add("Sum(IEnumerable`1<Nullable`1<Double>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableDouble);
			dictionary.Add("Sum(IEnumerable`1<Decimal>)->Decimal", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumDecimal);
			dictionary.Add("Sum(IEnumerable`1<Nullable`1<Decimal>>)->Nullable`1<Decimal>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableDecimal);
			dictionary.Add("Sum(IEnumerable`1<T0>, Func`2<T0, Int32>)->Int32", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumIntSelector);
			dictionary.Add("Sum(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Int32>>)->Nullable`1<Int32>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableIntSelector);
			dictionary.Add("Sum(IEnumerable`1<T0>, Func`2<T0, Int64>)->Int64", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumLongSelector);
			dictionary.Add("Sum(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Int64>>)->Nullable`1<Int64>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableLongSelector);
			dictionary.Add("Sum(IEnumerable`1<T0>, Func`2<T0, Single>)->Single", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumSingleSelector);
			dictionary.Add("Sum(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Single>>)->Nullable`1<Single>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableSingleSelector);
			dictionary.Add("Sum(IEnumerable`1<T0>, Func`2<T0, Double>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumDoubleSelector);
			dictionary.Add("Sum(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Double>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableDoubleSelector);
			dictionary.Add("Sum(IEnumerable`1<T0>, Func`2<T0, Decimal>)->Decimal", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumDecimalSelector);
			dictionary.Add("Sum(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Decimal>>)->Nullable`1<Decimal>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SumNullableDecimalSelector);
			dictionary.Add("Min(IEnumerable`1<Int32>)->Int32", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinInt);
			dictionary.Add("Min(IEnumerable`1<Nullable`1<Int32>>)->Nullable`1<Int32>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableInt);
			dictionary.Add("Min(IEnumerable`1<Int64>)->Int64", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinLong);
			dictionary.Add("Min(IEnumerable`1<Nullable`1<Int64>>)->Nullable`1<Int64>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableLong);
			dictionary.Add("Min(IEnumerable`1<Single>)->Single", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinSingle);
			dictionary.Add("Min(IEnumerable`1<Nullable`1<Single>>)->Nullable`1<Single>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableSingle);
			dictionary.Add("Min(IEnumerable`1<Double>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinDouble);
			dictionary.Add("Min(IEnumerable`1<Nullable`1<Double>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableDouble);
			dictionary.Add("Min(IEnumerable`1<Decimal>)->Decimal", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinDecimal);
			dictionary.Add("Min(IEnumerable`1<Nullable`1<Decimal>>)->Nullable`1<Decimal>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableDecimal);
			dictionary.Add("Min(IEnumerable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Min);
			dictionary.Add("Min(IEnumerable`1<T0>, Func`2<T0, Int32>)->Int32", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinIntSelector);
			dictionary.Add("Min(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Int32>>)->Nullable`1<Int32>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableIntSelector);
			dictionary.Add("Min(IEnumerable`1<T0>, Func`2<T0, Int64>)->Int64", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinLongSelector);
			dictionary.Add("Min(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Int64>>)->Nullable`1<Int64>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableLongSelector);
			dictionary.Add("Min(IEnumerable`1<T0>, Func`2<T0, Single>)->Single", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinSingleSelector);
			dictionary.Add("Min(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Single>>)->Nullable`1<Single>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableSingleSelector);
			dictionary.Add("Min(IEnumerable`1<T0>, Func`2<T0, Double>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinDoubleSelector);
			dictionary.Add("Min(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Double>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableDoubleSelector);
			dictionary.Add("Min(IEnumerable`1<T0>, Func`2<T0, Decimal>)->Decimal", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinDecimalSelector);
			dictionary.Add("Min(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Decimal>>)->Nullable`1<Decimal>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinNullableDecimalSelector);
			dictionary.Add("Min(IEnumerable`1<T0>, Func`2<T0, T1>)->T1", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MinSelector);
			dictionary.Add("Max(IEnumerable`1<Int32>)->Int32", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxInt);
			dictionary.Add("Max(IEnumerable`1<Nullable`1<Int32>>)->Nullable`1<Int32>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableInt);
			dictionary.Add("Max(IEnumerable`1<Int64>)->Int64", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxLong);
			dictionary.Add("Max(IEnumerable`1<Nullable`1<Int64>>)->Nullable`1<Int64>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableLong);
			dictionary.Add("Max(IEnumerable`1<Double>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxDouble);
			dictionary.Add("Max(IEnumerable`1<Nullable`1<Double>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableDouble);
			dictionary.Add("Max(IEnumerable`1<Single>)->Single", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxSingle);
			dictionary.Add("Max(IEnumerable`1<Nullable`1<Single>>)->Nullable`1<Single>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableSingle);
			dictionary.Add("Max(IEnumerable`1<Decimal>)->Decimal", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxDecimal);
			dictionary.Add("Max(IEnumerable`1<Nullable`1<Decimal>>)->Nullable`1<Decimal>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableDecimal);
			dictionary.Add("Max(IEnumerable`1<T0>)->T0", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Max);
			dictionary.Add("Max(IEnumerable`1<T0>, Func`2<T0, Int32>)->Int32", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxIntSelector);
			dictionary.Add("Max(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Int32>>)->Nullable`1<Int32>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableIntSelector);
			dictionary.Add("Max(IEnumerable`1<T0>, Func`2<T0, Int64>)->Int64", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxLongSelector);
			dictionary.Add("Max(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Int64>>)->Nullable`1<Int64>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableLongSelector);
			dictionary.Add("Max(IEnumerable`1<T0>, Func`2<T0, Single>)->Single", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxSingleSelector);
			dictionary.Add("Max(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Single>>)->Nullable`1<Single>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableSingleSelector);
			dictionary.Add("Max(IEnumerable`1<T0>, Func`2<T0, Double>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxDoubleSelector);
			dictionary.Add("Max(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Double>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableDoubleSelector);
			dictionary.Add("Max(IEnumerable`1<T0>, Func`2<T0, Decimal>)->Decimal", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxDecimalSelector);
			dictionary.Add("Max(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Decimal>>)->Nullable`1<Decimal>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxNullableDecimalSelector);
			dictionary.Add("Max(IEnumerable`1<T0>, Func`2<T0, T1>)->T1", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.MaxSelector);
			dictionary.Add("Average(IEnumerable`1<Int32>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageInt);
			dictionary.Add("Average(IEnumerable`1<Nullable`1<Int32>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableInt);
			dictionary.Add("Average(IEnumerable`1<Int64>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageLong);
			dictionary.Add("Average(IEnumerable`1<Nullable`1<Int64>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableLong);
			dictionary.Add("Average(IEnumerable`1<Single>)->Single", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageSingle);
			dictionary.Add("Average(IEnumerable`1<Nullable`1<Single>>)->Nullable`1<Single>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableSingle);
			dictionary.Add("Average(IEnumerable`1<Double>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageDouble);
			dictionary.Add("Average(IEnumerable`1<Nullable`1<Double>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableDouble);
			dictionary.Add("Average(IEnumerable`1<Decimal>)->Decimal", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageDecimal);
			dictionary.Add("Average(IEnumerable`1<Nullable`1<Decimal>>)->Nullable`1<Decimal>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableDecimal);
			dictionary.Add("Average(IEnumerable`1<T0>, Func`2<T0, Int32>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageIntSelector);
			dictionary.Add("Average(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Int32>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableIntSelector);
			dictionary.Add("Average(IEnumerable`1<T0>, Func`2<T0, Int64>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageLongSelector);
			dictionary.Add("Average(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Int64>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableLongSelector);
			dictionary.Add("Average(IEnumerable`1<T0>, Func`2<T0, Single>)->Single", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageSingleSelector);
			dictionary.Add("Average(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Single>>)->Nullable`1<Single>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableSingleSelector);
			dictionary.Add("Average(IEnumerable`1<T0>, Func`2<T0, Double>)->Double", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageDoubleSelector);
			dictionary.Add("Average(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Double>>)->Nullable`1<Double>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableDoubleSelector);
			dictionary.Add("Average(IEnumerable`1<T0>, Func`2<T0, Decimal>)->Decimal", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageDecimalSelector);
			dictionary.Add("Average(IEnumerable`1<T0>, Func`2<T0, Nullable`1<Decimal>>)->Nullable`1<Decimal>", global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AverageNullableDecimalSelector);
			global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil._methodMap = new global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod>();
			global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil._inverseMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod, global::System.Reflection.MethodInfo>();
			foreach (global::System.Reflection.MethodInfo methodInfo in global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil.GetAllLinqOperators())
			{
				string canonicalMethodDescription = global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil.GetCanonicalMethodDescription(methodInfo);
				global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod sequenceMethod;
				if (dictionary.TryGetValue(canonicalMethodDescription, out sequenceMethod))
				{
					global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil._methodMap.Add(methodInfo, sequenceMethod);
					global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil._inverseMap[sequenceMethod] = methodInfo;
				}
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x0600378F RID: 14223 RVA: 0x000B4F50 File Offset: 0x000B3150
		internal static global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod> MethodMap
		{
			get
			{
				return global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil._methodMap;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06003790 RID: 14224 RVA: 0x000B4F57 File Offset: 0x000B3157
		internal static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod, global::System.Reflection.MethodInfo> InverseMap
		{
			get
			{
				return global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil._inverseMap;
			}
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x000B4F5E File Offset: 0x000B315E
		internal static bool TryIdentifySequenceMethod(global::System.Reflection.MethodInfo method, out global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod sequenceMethod)
		{
			method = (method.IsGenericMethod ? method.GetGenericMethodDefinition() : method);
			return global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil._methodMap.TryGetValue(method, out sequenceMethod);
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x000B4F7F File Offset: 0x000B317F
		internal static bool TryIdentifySequenceMethod(global::System.Linq.Expressions.Expression expression, bool unwrapLambda, out global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod sequenceMethod)
		{
			if (expression.NodeType == global::System.Linq.Expressions.ExpressionType.Lambda && unwrapLambda)
			{
				expression = ((global::System.Linq.Expressions.LambdaExpression)expression).Body;
			}
			if (expression.NodeType == global::System.Linq.Expressions.ExpressionType.Call)
			{
				return global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil.TryIdentifySequenceMethod(((global::System.Linq.Expressions.MethodCallExpression)expression).Method, out sequenceMethod);
			}
			sequenceMethod = global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Where;
			return false;
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x000B4FBB File Offset: 0x000B31BB
		internal static bool TryLookupMethod(global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod sequenceMethod, out global::System.Reflection.MethodInfo method)
		{
			return global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil._inverseMap.TryGetValue(sequenceMethod, out method);
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x000B4FCC File Offset: 0x000B31CC
		internal static string GetCanonicalMethodDescription(global::System.Reflection.MethodInfo method)
		{
			global::System.Collections.Generic.Dictionary<global::System.Type, int> genericArgumentOrdinals = null;
			if (method.IsGenericMethodDefinition)
			{
				genericArgumentOrdinals = (from t in method.GetGenericArguments()
				where t.IsGenericParameter()
				select t).Select((global::System.Type t, int i) => new global::System.Collections.Generic.KeyValuePair<global::System.Type, int>(t, i)).ToDictionary((global::System.Collections.Generic.KeyValuePair<global::System.Type, int> r) => r.Key, (global::System.Collections.Generic.KeyValuePair<global::System.Type, int> r) => r.Value);
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(method.Name).Append("(");
			bool flag = true;
			foreach (global::System.Reflection.ParameterInfo parameterInfo in method.GetParameters())
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(", ");
				}
				global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil.AppendCanonicalTypeDescription(parameterInfo.ParameterType, genericArgumentOrdinals, stringBuilder);
			}
			stringBuilder.Append(")");
			if (null != method.ReturnType)
			{
				stringBuilder.Append("->");
				global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil.AppendCanonicalTypeDescription(method.ReturnType, genericArgumentOrdinals, stringBuilder);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x000B510C File Offset: 0x000B330C
		private static void AppendCanonicalTypeDescription(global::System.Type type, global::System.Collections.Generic.Dictionary<global::System.Type, int> genericArgumentOrdinals, global::System.Text.StringBuilder description)
		{
			int num;
			if (genericArgumentOrdinals != null && genericArgumentOrdinals.TryGetValue(type, out num))
			{
				description.Append("T").Append(num.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			}
			description.Append(type.Name);
			if (type.IsGenericType())
			{
				description.Append("<");
				bool flag = true;
				foreach (global::System.Type type2 in type.GetGenericArguments())
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						description.Append(", ");
					}
					global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil.AppendCanonicalTypeDescription(type2, genericArgumentOrdinals, description);
				}
				description.Append(">");
			}
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x000B51A6 File Offset: 0x000B33A6
		private static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetAllLinqOperators()
		{
			return typeof(global::System.Linq.Queryable).GetDeclaredMethods().Concat(typeof(global::System.Linq.Enumerable).GetDeclaredMethods());
		}

		// Token: 0x04001226 RID: 4646
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.MethodInfo, global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod> _methodMap;

		// Token: 0x04001227 RID: 4647
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod, global::System.Reflection.MethodInfo> _inverseMap;
	}
}
