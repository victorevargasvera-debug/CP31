using System;

namespace CefSharp.Event
{
	// Token: 0x02000115 RID: 277
	public class JavascriptBindingEventArgs : global::System.EventArgs
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0000CF62 File Offset: 0x0000B162
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0000CF6A File Offset: 0x0000B16A
		public global::CefSharp.IJavascriptObjectRepository ObjectRepository { get; private set; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0000CF73 File Offset: 0x0000B173
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x0000CF7B File Offset: 0x0000B17B
		public string ObjectName { get; private set; }

		// Token: 0x06000851 RID: 2129 RVA: 0x0000CF84 File Offset: 0x0000B184
		public JavascriptBindingEventArgs(global::CefSharp.IJavascriptObjectRepository objectRepository, string name)
		{
			this.ObjectRepository = objectRepository;
			this.ObjectName = name;
		}
	}
}
