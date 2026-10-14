using System;

namespace CefSharp.Event
{
	// Token: 0x02000114 RID: 276
	public class JavascriptBindingCompleteEventArgs : global::System.EventArgs
	{
		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x0000CEF9 File Offset: 0x0000B0F9
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x0000CF01 File Offset: 0x0000B101
		public global::CefSharp.IJavascriptObjectRepository ObjectRepository { get; private set; }

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0000CF0A File Offset: 0x0000B10A
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x0000CF12 File Offset: 0x0000B112
		public string ObjectName { get; private set; }

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x0000CF1B File Offset: 0x0000B11B
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x0000CF23 File Offset: 0x0000B123
		public bool AlreadyBound { get; private set; }

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x0000CF2C File Offset: 0x0000B12C
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x0000CF34 File Offset: 0x0000B134
		public bool IsCached { get; private set; }

		// Token: 0x0600084C RID: 2124 RVA: 0x0000CF3D File Offset: 0x0000B13D
		public JavascriptBindingCompleteEventArgs(global::CefSharp.IJavascriptObjectRepository objectRepository, string name, bool alreadyBound, bool isCached)
		{
			this.ObjectRepository = objectRepository;
			this.ObjectName = name;
			this.AlreadyBound = alreadyBound;
			this.IsCached = isCached;
		}
	}
}
