using System;

namespace NLog
{
	// Token: 0x02000018 RID: 24
	[global::System.Obsolete("Use NestedDiagnosticsContext class instead. Marked obsolete on NLog 2.0")]
	public static class NDC
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00008527 File Offset: 0x00006727
		public static string TopMessage
		{
			get
			{
				return global::NLog.NestedDiagnosticsContext.TopMessage;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0000852E File Offset: 0x0000672E
		public static object TopObject
		{
			get
			{
				return global::NLog.NestedDiagnosticsContext.TopObject;
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00008535 File Offset: 0x00006735
		public static global::System.IDisposable Push(string text)
		{
			return global::NLog.NestedDiagnosticsContext.Push(text);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000853D File Offset: 0x0000673D
		public static string Pop()
		{
			return global::NLog.NestedDiagnosticsContext.Pop();
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00008544 File Offset: 0x00006744
		public static object PopObject()
		{
			return global::NLog.NestedDiagnosticsContext.PopObject();
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000854B File Offset: 0x0000674B
		public static void Clear()
		{
			global::NLog.NestedDiagnosticsContext.Clear();
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00008552 File Offset: 0x00006752
		public static string[] GetAllMessages()
		{
			return global::NLog.NestedDiagnosticsContext.GetAllMessages();
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00008559 File Offset: 0x00006759
		public static object[] GetAllObjects()
		{
			return global::NLog.NestedDiagnosticsContext.GetAllObjects();
		}
	}
}
