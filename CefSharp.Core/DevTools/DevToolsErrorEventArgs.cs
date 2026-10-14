using System;

namespace CefSharp.DevTools
{
	// Token: 0x02000026 RID: 38
	public class DevToolsErrorEventArgs : global::System.EventArgs
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00004CE4 File Offset: 0x00002EE4
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00004CEC File Offset: 0x00002EEC
		public string EventName { get; private set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00004CF5 File Offset: 0x00002EF5
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00004CFD File Offset: 0x00002EFD
		public string Json { get; private set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00004D06 File Offset: 0x00002F06
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00004D0E File Offset: 0x00002F0E
		public global::System.Exception Exception { get; private set; }

		// Token: 0x06000206 RID: 518 RVA: 0x00004D17 File Offset: 0x00002F17
		public DevToolsErrorEventArgs(string eventName, string json, global::System.Exception ex)
		{
			this.EventName = eventName;
			this.Json = json;
			this.Exception = ex;
		}
	}
}
