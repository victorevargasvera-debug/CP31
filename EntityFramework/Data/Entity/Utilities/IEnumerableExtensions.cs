using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace System.Data.Entity.Utilities
{
	// Token: 0x0200008C RID: 140
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static class IEnumerableExtensions
	{
		// Token: 0x06000478 RID: 1144 RVA: 0x0000F8EC File Offset: 0x0000DAEC
		public static string Uniquify(this global::System.Collections.Generic.IEnumerable<string> inputStrings, string targetString)
		{
			global::System.Data.Entity.Utilities.IEnumerableExtensions.<>c__DisplayClass0_0 CS$<>8__locals1 = new global::System.Data.Entity.Utilities.IEnumerableExtensions.<>c__DisplayClass0_0();
			CS$<>8__locals1.uniqueString = targetString;
			int num = 0;
			while (inputStrings.Any((string n) => string.Equals(n, CS$<>8__locals1.uniqueString, global::System.StringComparison.Ordinal)))
			{
				global::System.Data.Entity.Utilities.IEnumerableExtensions.<>c__DisplayClass0_0 CS$<>8__locals2 = CS$<>8__locals1;
				int num2;
				num = (num2 = num + 1);
				CS$<>8__locals2.uniqueString = targetString + num2.ToString();
			}
			return CS$<>8__locals1.uniqueString;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000F940 File Offset: 0x0000DB40
		public static void Each<T>(this global::System.Collections.Generic.IEnumerable<T> ts, global::System.Action<T, int> action)
		{
			int num = 0;
			foreach (T arg in ts)
			{
				action(arg, num++);
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000F990 File Offset: 0x0000DB90
		public static void Each<T>(this global::System.Collections.Generic.IEnumerable<T> ts, global::System.Action<T> action)
		{
			foreach (T obj in ts)
			{
				action(obj);
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		public static void Each<T, S>(this global::System.Collections.Generic.IEnumerable<T> ts, global::System.Func<T, S> action)
		{
			foreach (T arg in ts)
			{
				action(arg);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000FA24 File Offset: 0x0000DC24
		public static string Join<T>(this global::System.Collections.Generic.IEnumerable<T> ts, global::System.Func<T, string> selector = null, string separator = ", ")
		{
			global::System.Func<T, string> func;
			if ((func = selector) == null && (func = global::System.Data.Entity.Utilities.IEnumerableExtensions.<>c__4<T>.<>9__4_0) == null)
			{
				func = (global::System.Data.Entity.Utilities.IEnumerableExtensions.<>c__4<T>.<>9__4_0 = ((T t) => t.ToString()));
			}
			selector = func;
			return string.Join(separator, (from t in ts
			where t != null
			select t).Select(selector));
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000FA88 File Offset: 0x0000DC88
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

		// Token: 0x0600047E RID: 1150 RVA: 0x0000FA9F File Offset: 0x0000DC9F
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
