using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Utilities
{
	// Token: 0x0200007C RID: 124
	internal static class DynamicEqualityComparerLinqIntegration
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x0000ECA1 File Offset: 0x0000CEA1
		public static global::System.Collections.Generic.IEnumerable<T> Distinct<T>(this global::System.Collections.Generic.IEnumerable<T> source, global::System.Func<T, T, bool> func) where T : class
		{
			return source.Distinct(new global::System.Data.Entity.Utilities.DynamicEqualityComparer<T>(func));
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000ECAF File Offset: 0x0000CEAF
		public static global::System.Collections.Generic.IEnumerable<global::System.Linq.IGrouping<TSource, TSource>> GroupBy<TSource>(this global::System.Collections.Generic.IEnumerable<TSource> source, global::System.Func<TSource, TSource, bool> func) where TSource : class
		{
			return source.GroupBy((TSource t) => t, new global::System.Data.Entity.Utilities.DynamicEqualityComparer<TSource>(func));
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000ECDC File Offset: 0x0000CEDC
		public static global::System.Collections.Generic.IEnumerable<T> Intersect<T>(this global::System.Collections.Generic.IEnumerable<T> first, global::System.Collections.Generic.IEnumerable<T> second, global::System.Func<T, T, bool> func) where T : class
		{
			return first.Intersect(second, new global::System.Data.Entity.Utilities.DynamicEqualityComparer<T>(func));
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000ECEB File Offset: 0x0000CEEB
		public static global::System.Collections.Generic.IEnumerable<T> Except<T>(this global::System.Collections.Generic.IEnumerable<T> first, global::System.Collections.Generic.IEnumerable<T> second, global::System.Func<T, T, bool> func) where T : class
		{
			return first.Except(second, new global::System.Data.Entity.Utilities.DynamicEqualityComparer<T>(func));
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000ECFA File Offset: 0x0000CEFA
		public static bool Contains<T>(this global::System.Collections.Generic.IEnumerable<T> source, T value, global::System.Func<T, T, bool> func) where T : class
		{
			return source.Contains(value, new global::System.Data.Entity.Utilities.DynamicEqualityComparer<T>(func));
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000ED09 File Offset: 0x0000CF09
		public static bool SequenceEqual<TSource>(this global::System.Collections.Generic.IEnumerable<TSource> source, global::System.Collections.Generic.IEnumerable<TSource> other, global::System.Func<TSource, TSource, bool> func) where TSource : class
		{
			return source.SequenceEqual(other, new global::System.Data.Entity.Utilities.DynamicEqualityComparer<TSource>(func));
		}
	}
}
