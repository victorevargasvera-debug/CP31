using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000047 RID: 71
	internal class CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler, global::System.Runtime.CompilerServices.INotifyCompletion
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x000116BC File Offset: 0x0000F8BC
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x000116C4 File Offset: 0x0000F8C4
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Environment createdEnvironment { get; private set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x000116CD File Offset: 0x0000F8CD
		// (set) Token: 0x060002AA RID: 682 RVA: 0x000116D5 File Offset: 0x0000F8D5
		public int errCode { get; private set; }

		// Token: 0x060002AB RID: 683 RVA: 0x000116DE File Offset: 0x0000F8DE
		public CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler()
		{
			this.IsCompleted = false;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000116F0 File Offset: 0x0000F8F0
		public void Invoke(int errCode, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment createdEnvironment)
		{
			this.createdEnvironment = new global::Microsoft.Web.WebView2.Core.CoreWebView2Environment(createdEnvironment);
			this.errCode = errCode;
			this.IsCompleted = true;
			bool flag = this.continuation != null;
			if (flag)
			{
				this.continuation();
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00011738 File Offset: 0x0000F938
		public global::Microsoft.Web.WebView2.Core.CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler GetAwaiter()
		{
			return this;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0001174B File Offset: 0x0000F94B
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00011753 File Offset: 0x0000F953
		public bool IsCompleted { get; private set; }

		// Token: 0x060002B0 RID: 688 RVA: 0x0001175C File Offset: 0x0000F95C
		public void OnCompleted(global::System.Action continuation)
		{
			this.continuation = continuation;
			bool isCompleted = this.IsCompleted;
			if (isCompleted)
			{
				continuation();
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00011784 File Offset: 0x0000F984
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Environment GetResult()
		{
			return this.createdEnvironment;
		}

		// Token: 0x04000175 RID: 373
		private global::System.Action continuation;
	}
}
