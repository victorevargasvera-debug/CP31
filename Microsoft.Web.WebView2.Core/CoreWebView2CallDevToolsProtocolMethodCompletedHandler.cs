using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200004B RID: 75
	internal class CoreWebView2CallDevToolsProtocolMethodCompletedHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CallDevToolsProtocolMethodCompletedHandler, global::System.Runtime.CompilerServices.INotifyCompletion
	{
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00011A08 File Offset: 0x0000FC08
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00011A10 File Offset: 0x0000FC10
		public string returnObjectAsJson { get; private set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00011A19 File Offset: 0x0000FC19
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00011A21 File Offset: 0x0000FC21
		public int errCode { get; private set; }

		// Token: 0x060002D5 RID: 725 RVA: 0x00011A2A File Offset: 0x0000FC2A
		public CoreWebView2CallDevToolsProtocolMethodCompletedHandler()
		{
			this.IsCompleted = false;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00011A3C File Offset: 0x0000FC3C
		public void Invoke(int errCode, string returnObjectAsJson)
		{
			this.returnObjectAsJson = returnObjectAsJson;
			this.errCode = errCode;
			this.IsCompleted = true;
			bool flag = this.continuation != null;
			if (flag)
			{
				this.continuation();
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00011A80 File Offset: 0x0000FC80
		public global::Microsoft.Web.WebView2.Core.CoreWebView2CallDevToolsProtocolMethodCompletedHandler GetAwaiter()
		{
			return this;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00011A93 File Offset: 0x0000FC93
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00011A9B File Offset: 0x0000FC9B
		public bool IsCompleted { get; private set; }

		// Token: 0x060002DA RID: 730 RVA: 0x00011AA4 File Offset: 0x0000FCA4
		public void OnCompleted(global::System.Action continuation)
		{
			this.continuation = continuation;
			bool isCompleted = this.IsCompleted;
			if (isCompleted)
			{
				continuation();
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00011ACC File Offset: 0x0000FCCC
		public string GetResult()
		{
			return this.returnObjectAsJson;
		}

		// Token: 0x04000184 RID: 388
		private global::System.Action continuation;
	}
}
