using System;
using System.Collections.Generic;

namespace Autofac.Util
{
	// Token: 0x02000024 RID: 36
	internal static class Traverse
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00004E33 File Offset: 0x00003033
		public static global::System.Collections.Generic.IEnumerable<T> Across<T>(T first, global::System.Func<T, T> next) where T : class
		{
			for (T item = first; item != null; item = next(item))
			{
				yield return item;
			}
			yield break;
		}
	}
}
