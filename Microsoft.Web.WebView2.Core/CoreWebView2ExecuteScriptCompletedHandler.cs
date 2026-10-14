using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000046 RID: 70
	internal class CoreWebView2ExecuteScriptCompletedHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ExecuteScriptCompletedHandler, global::System.Runtime.CompilerServices.INotifyCompletion
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000115E0 File Offset: 0x0000F7E0
		// (set) Token: 0x0600029D RID: 669 RVA: 0x000115E8 File Offset: 0x0000F7E8
		public string resultObjectAsJson { get; private set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600029E RID: 670 RVA: 0x000115F1 File Offset: 0x0000F7F1
		// (set) Token: 0x0600029F RID: 671 RVA: 0x000115F9 File Offset: 0x0000F7F9
		public int errCode { get; private set; }

		// Token: 0x060002A0 RID: 672 RVA: 0x00011602 File Offset: 0x0000F802
		public CoreWebView2ExecuteScriptCompletedHandler()
		{
			this.IsCompleted = false;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00011614 File Offset: 0x0000F814
		public void Invoke(int errCode, string resultObjectAsJson)
		{
			this.resultObjectAsJson = resultObjectAsJson;
			this.errCode = errCode;
			this.IsCompleted = true;
			bool flag = this.continuation != null;
			if (flag)
			{
				this.continuation();
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00011658 File Offset: 0x0000F858
		public global::Microsoft.Web.WebView2.Core.CoreWebView2ExecuteScriptCompletedHandler GetAwaiter()
		{
			return this;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0001166B File Offset: 0x0000F86B
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00011673 File Offset: 0x0000F873
		public bool IsCompleted { get; private set; }

		// Token: 0x060002A5 RID: 677 RVA: 0x0001167C File Offset: 0x0000F87C
		public void OnCompleted(global::System.Action continuation)
		{
			this.continuation = continuation;
			bool isCompleted = this.IsCompleted;
			if (isCompleted)
			{
				continuation();
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000116A4 File Offset: 0x0000F8A4
		public string GetResult()
		{
			return this.resultObjectAsJson;
		}

		// Token: 0x04000171 RID: 369
		private global::System.Action continuation;
	}
}
