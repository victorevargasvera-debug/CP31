using System;

namespace CefSharp.DevTools
{
	// Token: 0x02000027 RID: 39
	public class DevToolsEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00004D34 File Offset: 0x00002F34
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00004D3C File Offset: 0x00002F3C
		public string EventName { get; private set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00004D45 File Offset: 0x00002F45
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00004D4D File Offset: 0x00002F4D
		public string ParametersAsJsonString { get; private set; }

		// Token: 0x0600020B RID: 523 RVA: 0x00004D56 File Offset: 0x00002F56
		public DevToolsEventArgs(string eventName, string paramsAsJsonString)
		{
			this.EventName = eventName;
			this.ParametersAsJsonString = paramsAsJsonString;
		}
	}
}
