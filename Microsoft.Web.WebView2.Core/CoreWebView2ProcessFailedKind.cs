using System;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000018 RID: 24
	public enum CoreWebView2ProcessFailedKind
	{
		// Token: 0x0400007D RID: 125
		BrowserProcessExited,
		// Token: 0x0400007E RID: 126
		RenderProcessExited,
		// Token: 0x0400007F RID: 127
		RenderProcessUnresponsive,
		// Token: 0x04000080 RID: 128
		FrameRenderProcessExited,
		// Token: 0x04000081 RID: 129
		UtilityProcessExited,
		// Token: 0x04000082 RID: 130
		SandboxHelperProcessExited,
		// Token: 0x04000083 RID: 131
		GpuProcessExited,
		// Token: 0x04000084 RID: 132
		PpapiPluginProcessExited,
		// Token: 0x04000085 RID: 133
		PpapiBrokerProcessExited,
		// Token: 0x04000086 RID: 134
		UnknownProcessExited
	}
}
