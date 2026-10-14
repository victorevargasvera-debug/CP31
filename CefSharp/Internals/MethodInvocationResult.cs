using System;
using CefSharp.JavascriptBinding;

namespace CefSharp.Internals
{
	// Token: 0x020000E7 RID: 231
	public sealed class MethodInvocationResult
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x0000B4BE File Offset: 0x000096BE
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x0000B4C6 File Offset: 0x000096C6
		public int BrowserId { get; set; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x0000B4CF File Offset: 0x000096CF
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x0000B4D7 File Offset: 0x000096D7
		public long? CallbackId { get; set; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0000B4E0 File Offset: 0x000096E0
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x0000B4E8 File Offset: 0x000096E8
		public long FrameId { get; set; }

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x0000B4F1 File Offset: 0x000096F1
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x0000B4F9 File Offset: 0x000096F9
		public string Message { get; set; }

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x0000B502 File Offset: 0x00009702
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x0000B50A File Offset: 0x0000970A
		public bool Success { get; set; }

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0000B513 File Offset: 0x00009713
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x0000B51B File Offset: 0x0000971B
		public object Result { get; set; }

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x0000B524 File Offset: 0x00009724
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x0000B52C File Offset: 0x0000972C
		public global::CefSharp.JavascriptBinding.IJavascriptNameConverter NameConverter { get; set; }
	}
}
