using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000224 RID: 548
	internal class ScheduleUtilities
	{
		// Token: 0x06002072 RID: 8306 RVA: 0x0008D493 File Offset: 0x0008B693
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

		// Token: 0x06002073 RID: 8307 RVA: 0x0008D4B0 File Offset: 0x0008B6B0
		internal static string GetString(string name)
		{
			return global::SR.GetString(name);
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x0008D4B8 File Offset: 0x0008B6B8
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x0008D4C4 File Offset: 0x0008B6C4
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
