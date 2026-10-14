using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200004C RID: 76
	internal class CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler, global::System.Runtime.CompilerServices.INotifyCompletion
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00011AE4 File Offset: 0x0000FCE4
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00011AEC File Offset: 0x0000FCEC
		public string id { get; private set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00011AF5 File Offset: 0x0000FCF5
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00011AFD File Offset: 0x0000FCFD
		public int errCode { get; private set; }

		// Token: 0x060002E0 RID: 736 RVA: 0x00011B06 File Offset: 0x0000FD06
		public CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler()
		{
			this.IsCompleted = false;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00011B18 File Offset: 0x0000FD18
		public void Invoke(int errCode, string id)
		{
			this.id = id;
			this.errCode = errCode;
			this.IsCompleted = true;
			bool flag = this.continuation != null;
			if (flag)
			{
				this.continuation();
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00011B5C File Offset: 0x0000FD5C
		public global::Microsoft.Web.WebView2.Core.CoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler GetAwaiter()
		{
			return this;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00011B6F File Offset: 0x0000FD6F
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00011B77 File Offset: 0x0000FD77
		public bool IsCompleted { get; private set; }

		// Token: 0x060002E5 RID: 741 RVA: 0x00011B80 File Offset: 0x0000FD80
		public void OnCompleted(global::System.Action continuation)
		{
			this.continuation = continuation;
			bool isCompleted = this.IsCompleted;
			if (isCompleted)
			{
				continuation();
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00011BA8 File Offset: 0x0000FDA8
		public string GetResult()
		{
			return this.id;
		}

		// Token: 0x04000188 RID: 392
		private global::System.Action continuation;
	}
}
