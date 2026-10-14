using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000043 RID: 67
	internal class CoreWebView2WebResourceResponseViewGetContentCompletedHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseViewGetContentCompletedHandler, global::System.Runtime.CompilerServices.INotifyCompletion
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00011333 File Offset: 0x0000F533
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0001133B File Offset: 0x0000F53B
		public global::System.IO.Stream Content { get; private set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00011344 File Offset: 0x0000F544
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0001134C File Offset: 0x0000F54C
		public int errCode { get; private set; }

		// Token: 0x0600027F RID: 639 RVA: 0x00011355 File Offset: 0x0000F555
		public CoreWebView2WebResourceResponseViewGetContentCompletedHandler()
		{
			this.IsCompleted = false;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00011368 File Offset: 0x0000F568
		public void Invoke(int errCode, global::System.Runtime.InteropServices.ComTypes.IStream Content)
		{
			this.Content = ((Content == null) ? null : new global::Microsoft.Web.WebView2.Core.COMStreamWrapper(Content));
			this.errCode = errCode;
			this.IsCompleted = true;
			bool flag = this.continuation != null;
			if (flag)
			{
				this.continuation();
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000113B4 File Offset: 0x0000F5B4
		public global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseViewGetContentCompletedHandler GetAwaiter()
		{
			return this;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000113C7 File Offset: 0x0000F5C7
		// (set) Token: 0x06000283 RID: 643 RVA: 0x000113CF File Offset: 0x0000F5CF
		public bool IsCompleted { get; private set; }

		// Token: 0x06000284 RID: 644 RVA: 0x000113D8 File Offset: 0x0000F5D8
		public void OnCompleted(global::System.Action continuation)
		{
			this.continuation = continuation;
			bool isCompleted = this.IsCompleted;
			if (isCompleted)
			{
				continuation();
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00011400 File Offset: 0x0000F600
		public global::System.IO.Stream GetResult()
		{
			return this.Content;
		}

		// Token: 0x04000165 RID: 357
		private global::System.Action continuation;
	}
}
