using System;

namespace CefSharp
{
	// Token: 0x0200004F RID: 79
	public class TitleChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00003454 File Offset: 0x00001654
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0000345C File Offset: 0x0000165C
		public global::CefSharp.IBrowser Browser { get; private set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00003465 File Offset: 0x00001665
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000346D File Offset: 0x0000166D
		public string Title { get; private set; }

		// Token: 0x06000124 RID: 292 RVA: 0x00003476 File Offset: 0x00001676
		public TitleChangedEventArgs(global::CefSharp.IBrowser browser, string title)
		{
			this.Browser = browser;
			this.Title = title;
		}
	}
}
