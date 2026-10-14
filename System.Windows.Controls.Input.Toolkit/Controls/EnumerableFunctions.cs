using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Windows.Controls
{
	// Token: 0x02000021 RID: 33
	internal static class EnumerableFunctions
	{
		// Token: 0x060001C6 RID: 454 RVA: 0x00007544 File Offset: 0x00005744
		public static global::System.Collections.Generic.IEnumerable<R> Scan<T, R>(this global::System.Collections.Generic.IEnumerable<T> that, global::System.Func<R, T, R> func, R initialValue)
		{
			R acc = initialValue;
			yield return acc;
			foreach (T arg in that)
			{
				acc = func(acc, arg);
				yield return acc;
			}
			yield break;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000076B8 File Offset: 0x000058B8
		public static global::System.Collections.Generic.IEnumerable<R> Zip<T0, T1, R>(global::System.Collections.Generic.IEnumerable<T0> enumerable0, global::System.Collections.Generic.IEnumerable<T1> enumerable1, global::System.Func<T0, T1, R> func)
		{
			global::System.Collections.Generic.IEnumerator<T0> enumerator0 = enumerable0.GetEnumerator();
			global::System.Collections.Generic.IEnumerator<T1> enumerator = enumerable1.GetEnumerator();
			while (enumerator0.MoveNext() && enumerator.MoveNext())
			{
				yield return func(enumerator0.Current, enumerator.Current);
			}
			yield break;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000076E4 File Offset: 0x000058E4
		public static int? IndexOf<T>(this global::System.Collections.Generic.IEnumerable<T> that, T item)
		{
			global::System.Collections.Generic.IEnumerator<T> enumerator = that.GetEnumerator();
			int num = 0;
			while (enumerator.MoveNext())
			{
				if (object.ReferenceEquals(enumerator.Current, item))
				{
					return new int?(num);
				}
				num++;
			}
			return null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000077D0 File Offset: 0x000059D0
		public static global::System.Collections.Generic.IEnumerable<double> GetWeightedValues(this global::System.Collections.Generic.IEnumerable<double> values, double percent)
		{
			double total = values.Sum();
			if (total == 0.0)
			{
				return from _ in values
				select 0.0;
			}
			return (from tuple in global::System.Windows.Controls.EnumerableFunctions.Zip<double, double, global::System.Windows.Controls.Tuple<double, double>>(values.Scan((double acc, double current) => acc + current, 0.0), values, (double acc, double current) => global::System.Windows.Controls.Tuple.Create<double, double>(acc, current))
			select global::System.Windows.Controls.Tuple.Create<double, double>(tuple.First / total, tuple.Second / total)).Select(delegate(global::System.Windows.Controls.Tuple<double, double> tuple)
			{
				double first = tuple.First;
				double second = tuple.Second;
				if (percent > first && first + second > percent)
				{
					return (percent - first) * total;
				}
				if (percent <= first)
				{
					return 0.0;
				}
				return 1.0;
			});
		}
	}
}
