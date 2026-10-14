using System;

namespace CefSharp
{
	// Token: 0x0200004E RID: 78
	public class StatusMessageEventArgs : global::System.EventArgs
	{
		// Token: 0x0600011B RID: 283 RVA: 0x0000341C File Offset: 0x0000161C
		public StatusMessageEventArgs(global::CefSharp.IBrowser browser, string value)
		{
			this.Browser = browser;
			this.Value = value;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00003432 File Offset: 0x00001632
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000343A File Offset: 0x0000163A
		public global::CefSharp.IBrowser Browser { get; private set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00003443 File Offset: 0x00001643
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000344B File Offset: 0x0000164B
		public string Value { get; private set; }
	}
}
