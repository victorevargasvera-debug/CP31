using System;

namespace CefSharp
{
	// Token: 0x0200004D RID: 77
	public class LoadingStateChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00003397 File Offset: 0x00001597
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000339F File Offset: 0x0000159F
		public bool CanGoForward { get; private set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000033A8 File Offset: 0x000015A8
		// (set) Token: 0x06000113 RID: 275 RVA: 0x000033B0 File Offset: 0x000015B0
		public bool CanGoBack { get; private set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000033B9 File Offset: 0x000015B9
		// (set) Token: 0x06000115 RID: 277 RVA: 0x000033C1 File Offset: 0x000015C1
		public bool CanReload { get; private set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000033CA File Offset: 0x000015CA
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000033D2 File Offset: 0x000015D2
		public bool IsLoading { get; private set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000033DB File Offset: 0x000015DB
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000033E3 File Offset: 0x000015E3
		public global::CefSharp.IBrowser Browser { get; private set; }

		// Token: 0x0600011A RID: 282 RVA: 0x000033EC File Offset: 0x000015EC
		public LoadingStateChangedEventArgs(global::CefSharp.IBrowser browser, bool canGoBack, bool canGoForward, bool isLoading)
		{
			this.Browser = browser;
			this.CanGoBack = canGoBack;
			this.CanGoForward = canGoForward;
			this.IsLoading = isLoading;
			this.CanReload = !isLoading;
		}
	}
}
