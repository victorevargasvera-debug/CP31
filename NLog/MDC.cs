using System;

namespace NLog
{
	// Token: 0x02000016 RID: 22
	[global::System.Obsolete("Use MappedDiagnosticsContext class instead. Marked obsolete on NLog 2.0")]
	public static class MDC
	{
		// Token: 0x0600042D RID: 1069 RVA: 0x000084E0 File Offset: 0x000066E0
		public static void Set(string item, string value)
		{
			global::NLog.MappedDiagnosticsContext.Set(item, value);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000084E9 File Offset: 0x000066E9
		public static string Get(string item)
		{
			return global::NLog.MappedDiagnosticsContext.Get(item);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000084F1 File Offset: 0x000066F1
		public static object GetObject(string item)
		{
			return global::NLog.MappedDiagnosticsContext.GetObject(item);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000084F9 File Offset: 0x000066F9
		public static bool Contains(string item)
		{
			return global::NLog.MappedDiagnosticsContext.Contains(item);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00008501 File Offset: 0x00006701
		public static void Remove(string item)
		{
			global::NLog.MappedDiagnosticsContext.Remove(item);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00008509 File Offset: 0x00006709
		public static void Clear()
		{
			global::NLog.MappedDiagnosticsContext.Clear();
		}
	}
}
