using System;
using System.Collections.Generic;

namespace CefSharp.Event
{
	// Token: 0x02000116 RID: 278
	public class JavascriptBindingMultipleCompleteEventArgs : global::System.EventArgs
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0000CF9A File Offset: 0x0000B19A
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x0000CFA2 File Offset: 0x0000B1A2
		public global::CefSharp.IJavascriptObjectRepository ObjectRepository { get; private set; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x0000CFAB File Offset: 0x0000B1AB
		// (set) Token: 0x06000855 RID: 2133 RVA: 0x0000CFB3 File Offset: 0x0000B1B3
		public global::System.Collections.Generic.IList<string> ObjectNames { get; private set; }

		// Token: 0x06000856 RID: 2134 RVA: 0x0000CFBC File Offset: 0x0000B1BC
		public JavascriptBindingMultipleCompleteEventArgs(global::CefSharp.IJavascriptObjectRepository objectRepository, global::System.Collections.Generic.IList<string> names)
		{
			this.ObjectRepository = objectRepository;
			this.ObjectNames = names;
		}
	}
}
