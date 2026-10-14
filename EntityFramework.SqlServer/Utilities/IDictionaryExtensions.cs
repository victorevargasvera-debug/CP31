using System;
using System.Collections.Generic;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x0200001E RID: 30
	internal static class IDictionaryExtensions
	{
		// Token: 0x06000373 RID: 883 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		internal static void Add<TKey, TValue>(this global::System.Collections.Generic.IDictionary<TKey, global::System.Collections.Generic.IList<TValue>> map, TKey key, TValue value)
		{
			global::System.Collections.Generic.IList<TValue> list;
			if (!map.TryGetValue(key, out list))
			{
				list = new global::System.Collections.Generic.List<TValue>();
				map[key] = list;
			}
			list.Add(value);
		}
	}
}
