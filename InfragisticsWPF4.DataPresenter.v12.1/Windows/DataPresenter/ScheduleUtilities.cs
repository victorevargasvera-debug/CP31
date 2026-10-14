using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001F0 RID: 496
	internal class ScheduleUtilities
	{
		// Token: 0x06001BF4 RID: 7156 RVA: 0x000770BF File Offset: 0x000752BF
		internal static global::System.Collections.Generic.Dictionary<TKey, TValue> AddEntryHelper<TKey, TValue>(global::System.Collections.Generic.Dictionary<TKey, TValue> map, TKey key, TValue value)
		{
			if (value != null)
			{
				if (map == null)
				{
					map = new global::System.Collections.Generic.Dictionary<TKey, TValue>();
				}
				map[key] = value;
			}
			return map;
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x000770DC File Offset: 0x000752DC
		internal static string GetString(string name)
		{
			return global::SR.GetString(name);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000770E4 File Offset: 0x000752E4
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x000770F0 File Offset: 0x000752F0
		internal static T[] GetNonNullValues<T>(params T[] values) where T : class
		{
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			foreach (T t in values)
			{
				if (t != null)
				{
					list.Add(t);
				}
			}
			return list.ToArray();
		}
	}
}
