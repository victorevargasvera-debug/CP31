using System;

namespace CefSharp
{
	// Token: 0x02000044 RID: 68
	[global::System.Flags]
	public enum UrlRequestFlags
	{
		// Token: 0x04000256 RID: 598
		None = 0,
		// Token: 0x04000257 RID: 599
		SkipCache = 1,
		// Token: 0x04000258 RID: 600
		OnlyFromCache = 2,
		// Token: 0x04000259 RID: 601
		DisableCache = 4,
		// Token: 0x0400025A RID: 602
		AllowStoredCredentials = 8,
		// Token: 0x0400025B RID: 603
		ReportUploadProgress = 16,
		// Token: 0x0400025C RID: 604
		NoDownloadData = 32,
		// Token: 0x0400025D RID: 605
		NoRetryOn5XX = 64,
		// Token: 0x0400025E RID: 606
		StopOnRedirect = 128
	}
}
