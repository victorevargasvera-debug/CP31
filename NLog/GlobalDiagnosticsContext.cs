using System;
using System.Collections.Generic;
using NLog.Internal;

namespace NLog
{
	// Token: 0x02000003 RID: 3
	public static class GlobalDiagnosticsContext
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000208C File Offset: 0x0000028C
		public static void Set(string item, string value)
		{
			global::System.Collections.Generic.Dictionary<string, object> obj = global::NLog.GlobalDiagnosticsContext.dict;
			lock (obj)
			{
				global::NLog.GlobalDiagnosticsContext.dict[item] = value;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020D4 File Offset: 0x000002D4
		public static void Set(string item, object value)
		{
			global::System.Collections.Generic.Dictionary<string, object> obj = global::NLog.GlobalDiagnosticsContext.dict;
			lock (obj)
			{
				global::NLog.GlobalDiagnosticsContext.dict[item] = value;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000211C File Offset: 0x0000031C
		public static string Get(string item)
		{
			return global::NLog.GlobalDiagnosticsContext.Get(item, null);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002125 File Offset: 0x00000325
		public static string Get(string item, global::System.IFormatProvider formatProvider)
		{
			return global::NLog.Internal.FormatHelper.ConvertToString(global::NLog.GlobalDiagnosticsContext.GetObject(item), formatProvider);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002134 File Offset: 0x00000334
		public static object GetObject(string item)
		{
			global::System.Collections.Generic.Dictionary<string, object> obj = global::NLog.GlobalDiagnosticsContext.dict;
			object result;
			lock (obj)
			{
				object obj2;
				if (!global::NLog.GlobalDiagnosticsContext.dict.TryGetValue(item, out obj2))
				{
					obj2 = null;
				}
				result = obj2;
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002184 File Offset: 0x00000384
		public static global::System.Collections.Generic.ICollection<string> GetNames()
		{
			global::System.Collections.Generic.Dictionary<string, object> obj = global::NLog.GlobalDiagnosticsContext.dict;
			global::System.Collections.Generic.ICollection<string> keys;
			lock (obj)
			{
				keys = global::NLog.GlobalDiagnosticsContext.dict.Keys;
			}
			return keys;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021CC File Offset: 0x000003CC
		public static bool Contains(string item)
		{
			global::System.Collections.Generic.Dictionary<string, object> obj = global::NLog.GlobalDiagnosticsContext.dict;
			bool result;
			lock (obj)
			{
				result = global::NLog.GlobalDiagnosticsContext.dict.ContainsKey(item);
			}
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002214 File Offset: 0x00000414
		public static void Remove(string item)
		{
			global::System.Collections.Generic.Dictionary<string, object> obj = global::NLog.GlobalDiagnosticsContext.dict;
			lock (obj)
			{
				global::NLog.GlobalDiagnosticsContext.dict.Remove(item);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000225C File Offset: 0x0000045C
		public static void Clear()
		{
			global::System.Collections.Generic.Dictionary<string, object> obj = global::NLog.GlobalDiagnosticsContext.dict;
			lock (obj)
			{
				global::NLog.GlobalDiagnosticsContext.dict.Clear();
			}
		}

		// Token: 0x04000001 RID: 1
		private static global::System.Collections.Generic.Dictionary<string, object> dict = new global::System.Collections.Generic.Dictionary<string, object>();
	}
}
