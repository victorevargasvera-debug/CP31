using System;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200000D RID: 13
	public class CoreWebView2InitializationCompletedEventArgs : global::System.EventArgs
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x00006814 File Offset: 0x00004A14
		public CoreWebView2InitializationCompletedEventArgs(global::System.Exception ex = null)
		{
			this.InitializationException = ex;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00006826 File Offset: 0x00004A26
		public bool IsSuccess
		{
			get
			{
				return this.InitializationException == null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00006831 File Offset: 0x00004A31
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00006839 File Offset: 0x00004A39
		public global::System.Exception InitializationException { get; private set; }
	}
}
