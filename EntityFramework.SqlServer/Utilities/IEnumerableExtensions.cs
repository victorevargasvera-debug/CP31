using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x0200002A RID: 42
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static class IEnumerableExtensions
	{
		// Token: 0x06000433 RID: 1075 RVA: 0x00010384 File Offset: 0x0000E584
		public static string Uniquify(this global::System.Collections.Generic.IEnumerable<string> inputStrings, string targetString)
		{
			global::System.Data.Entity.SqlServer.Utilities.IEnumerableExtensions.<>c__DisplayClass0_0 CS$<>8__locals1 = new global::System.Data.Entity.SqlServer.Utilities.IEnumerableExtensions.<>c__DisplayClass0_0();
			CS$<>8__locals1.uniqueString = targetString;
			int num = 0;
			while (inputStrings.Any((string n) => string.Equals(n, CS$<>8__locals1.uniqueString, global::System.StringComparison.Ordinal)))
			{
				global::System.Data.Entity.SqlServer.Utilities.IEnumerableExtensions.<>c__DisplayClass0_0 CS$<>8__locals2 = CS$<>8__locals1;
				int num2;
				num = (num2 = num + 1);
				CS$<>8__locals2.uniqueString = targetString + num2.ToString();
			}
			return CS$<>8__locals1.uniqueString;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000103D8 File Offset: 0x0000E5D8
		public static void Each<T>(this global::System.Collections.Generic.IEnumerable<T> ts, global::System.Action<T, int> action)
		{
			int num = 0;
			foreach (T arg in ts)
			{
				action(arg, num++);
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00010428 File Offset: 0x0000E628
		public static void Each<T>(this global::System.Collections.Generic.IEnumerable<T> ts, global::System.Action<T> action)
		{
			foreach (T obj in ts)
			{
				action(obj);
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00010470 File Offset: 0x0000E670
		public static void Each<T, S>(this global::System.Collections.Generic.IEnumerable<T> ts, global::System.Func<T, S> action)
		{
			foreach (T arg in ts)
			{
				action(arg);
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000104BC File Offset: 0x0000E6BC
		public static string Join<T>(this global::System.Collections.Generic.IEnumerable<T> ts, global::System.Func<T, string> selector = null, string separator = ", ")
		{
			global::System.Func<T, string> func;
			if ((func = selector) == null && (func = global::System.Data.Entity.SqlServer.Utilities.IEnumerableExtensions.<>c__4<T>.<>9__4_0) == null)
			{
				func = (global::System.Data.Entity.SqlServer.Utilities.IEnumerableExtensions.<>c__4<T>.<>9__4_0 = ((T t) => t.ToString()));
			}
			selector = func;
			return string.Join(separator, (from t in ts
			where t != null
			select t).Select(selector));
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00010520 File Offset: 0x0000E720
		public static global::System.Collections.Generic.IEnumerable<TSource> Prepend<TSource>(this global::System.Collections.Generic.IEnumerable<TSource> source, TSource value)
		{
			yield return value;
			foreach (TSource tsource in source)
			{
				yield return tsource;
			}
			global::System.Collections.Generic.IEnumerator<TSource> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00010537 File Offset: 0x0000E737
		public static global::System.Collections.Generic.IEnumerable<TSource> Append<TSource>(this global::System.Collections.Generic.IEnumerable<TSource> source, TSource value)
		{
			foreach (TSource tsource in source)
			{
				yield return tsource;
			}
			global::System.Collections.Generic.IEnumerator<TSource> enumerator = null;
			yield return value;
			yield break;
			yield break;
		}
	}
}
