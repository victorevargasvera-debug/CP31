using System;
using System.Collections.Generic;
using System.Linq;

namespace Autofac.Util
{
	// Token: 0x02000022 RID: 34
	internal static class SequenceExtensions
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00004D51 File Offset: 0x00002F51
		public static string JoinWith(this global::System.Collections.Generic.IEnumerable<string> elements, string separator)
		{
			if (elements == null)
			{
				throw new global::System.ArgumentNullException("elements");
			}
			if (separator == null)
			{
				throw new global::System.ArgumentNullException("separator");
			}
			return string.Join(separator, elements.ToArray<string>());
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00004D7B File Offset: 0x00002F7B
		public static global::System.Collections.Generic.IEnumerable<T> AppendItem<T>(this global::System.Collections.Generic.IEnumerable<T> sequence, T trailingItem)
		{
			if (sequence == null)
			{
				throw new global::System.ArgumentNullException("sequence");
			}
			foreach (T t in sequence)
			{
				yield return t;
			}
			global::System.Collections.Generic.IEnumerator<T> enumerator = null;
			yield return trailingItem;
			yield break;
			yield break;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00004D92 File Offset: 0x00002F92
		public static global::System.Collections.Generic.IEnumerable<T> Prepend<T>(this global::System.Collections.Generic.IEnumerable<T> sequence, T leadingItem)
		{
			if (sequence == null)
			{
				throw new global::System.ArgumentNullException("sequence");
			}
			yield return leadingItem;
			foreach (T t in sequence)
			{
				yield return t;
			}
			global::System.Collections.Generic.IEnumerator<T> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00004DAC File Offset: 0x00002FAC
		public static void AddRange<T>(this global::System.Collections.Generic.ICollection<T> collection, global::System.Collections.Generic.IEnumerable<T> items)
		{
			foreach (T item in items)
			{
				collection.Add(item);
			}
		}
	}
}
