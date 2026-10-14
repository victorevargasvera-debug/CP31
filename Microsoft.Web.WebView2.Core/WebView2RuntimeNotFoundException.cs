using System;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000013 RID: 19
	[global::System.Serializable]
	public class WebView2RuntimeNotFoundException : global::System.Exception
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00006FC3 File Offset: 0x000051C3
		public WebView2RuntimeNotFoundException() : this(null)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00006FCE File Offset: 0x000051CE
		public WebView2RuntimeNotFoundException(string message) : base(message)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00006FD9 File Offset: 0x000051D9
		public WebView2RuntimeNotFoundException(global::System.Exception inner) : base("Couldn't find a compatible Webview2 Runtime installation to host WebViews.", inner)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00006FE9 File Offset: 0x000051E9
		public WebView2RuntimeNotFoundException(string message, global::System.Exception inner) : base(message, inner)
		{
		}
	}
}
