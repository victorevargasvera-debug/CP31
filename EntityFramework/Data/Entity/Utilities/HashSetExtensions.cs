using System;
using System.Collections.Generic;

namespace System.Data.Entity.Utilities
{
	// Token: 0x0200007F RID: 127
	internal static class HashSetExtensions
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x0000F118 File Offset: 0x0000D318
		public static void AddRange<T>(this global::System.Collections.Generic.HashSet<T> set, global::System.Collections.Generic.IEnumerable<T> items)
		{
			foreach (T item in items)
			{
				set.Add(item);
			}
		}
	}
}
