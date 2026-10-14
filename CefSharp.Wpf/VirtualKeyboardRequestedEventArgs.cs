using System;
using CefSharp.Enums;

namespace CefSharp.Wpf
{
	// Token: 0x02000009 RID: 9
	public class VirtualKeyboardRequestedEventArgs : global::System.EventArgs
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00005205 File Offset: 0x00003405
		// (set) Token: 0x0600014B RID: 331 RVA: 0x0000520D File Offset: 0x0000340D
		public global::CefSharp.Enums.TextInputMode TextInputMode { get; private set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00005216 File Offset: 0x00003416
		// (set) Token: 0x0600014D RID: 333 RVA: 0x0000521E File Offset: 0x0000341E
		public global::CefSharp.IBrowser Browser { get; private set; }

		// Token: 0x0600014E RID: 334 RVA: 0x00005227 File Offset: 0x00003427
		public VirtualKeyboardRequestedEventArgs(global::CefSharp.IBrowser browser, global::CefSharp.Enums.TextInputMode inputMode)
		{
			this.Browser = browser;
			this.TextInputMode = inputMode;
		}
	}
}
