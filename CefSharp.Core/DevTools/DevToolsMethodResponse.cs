using System;

namespace CefSharp.DevTools
{
	// Token: 0x02000028 RID: 40
	public class DevToolsMethodResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00004D6C File Offset: 0x00002F6C
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00004D74 File Offset: 0x00002F74
		public int MessageId { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00004D7D File Offset: 0x00002F7D
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00004D85 File Offset: 0x00002F85
		public bool Success { get; set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00004D8E File Offset: 0x00002F8E
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00004D96 File Offset: 0x00002F96
		public string ResponseAsJsonString { get; set; }
	}
}
