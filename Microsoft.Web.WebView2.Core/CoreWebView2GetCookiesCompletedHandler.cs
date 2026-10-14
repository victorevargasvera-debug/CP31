using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000045 RID: 69
	internal class CoreWebView2GetCookiesCompletedHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2GetCookiesCompletedHandler, global::System.Runtime.CompilerServices.INotifyCompletion
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000291 RID: 657 RVA: 0x000114F8 File Offset: 0x0000F6F8
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00011500 File Offset: 0x0000F700
		public global::System.Collections.Generic.List<global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie> cookieList { get; private set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00011509 File Offset: 0x0000F709
		// (set) Token: 0x06000294 RID: 660 RVA: 0x00011511 File Offset: 0x0000F711
		public int errCode { get; private set; }

		// Token: 0x06000295 RID: 661 RVA: 0x0001151A File Offset: 0x0000F71A
		public CoreWebView2GetCookiesCompletedHandler()
		{
			this.IsCompleted = false;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001152C File Offset: 0x0000F72C
		public void Invoke(int errCode, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CookieList cookieList)
		{
			this.cookieList = ((cookieList == null) ? new global::System.Collections.Generic.List<global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie>() : global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.CookieListCOMToNet(cookieList));
			this.errCode = errCode;
			this.IsCompleted = true;
			bool flag = this.continuation != null;
			if (flag)
			{
				this.continuation();
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001157C File Offset: 0x0000F77C
		public global::Microsoft.Web.WebView2.Core.CoreWebView2GetCookiesCompletedHandler GetAwaiter()
		{
			return this;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0001158F File Offset: 0x0000F78F
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00011597 File Offset: 0x0000F797
		public bool IsCompleted { get; private set; }

		// Token: 0x0600029A RID: 666 RVA: 0x000115A0 File Offset: 0x0000F7A0
		public void OnCompleted(global::System.Action continuation)
		{
			this.continuation = continuation;
			bool isCompleted = this.IsCompleted;
			if (isCompleted)
			{
				continuation();
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000115C8 File Offset: 0x0000F7C8
		public global::System.Collections.Generic.List<global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie> GetResult()
		{
			return this.cookieList;
		}

		// Token: 0x0400016D RID: 365
		private global::System.Action continuation;
	}
}
