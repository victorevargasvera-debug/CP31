using System;

namespace CefSharp
{
	// Token: 0x0200004C RID: 76
	public class LoadErrorEventArgs : global::System.EventArgs
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00003315 File Offset: 0x00001515
		public LoadErrorEventArgs(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.CefErrorCode errorCode, string errorText, string failedUrl)
		{
			this.Browser = browser;
			this.Frame = frame;
			this.ErrorCode = errorCode;
			this.ErrorText = errorText;
			this.FailedUrl = failedUrl;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00003342 File Offset: 0x00001542
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000334A File Offset: 0x0000154A
		public global::CefSharp.IBrowser Browser { get; private set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00003353 File Offset: 0x00001553
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0000335B File Offset: 0x0000155B
		public global::CefSharp.IFrame Frame { get; private set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000336C File Offset: 0x0000156C
		public string FailedUrl { get; private set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00003375 File Offset: 0x00001575
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000337D File Offset: 0x0000157D
		public global::CefSharp.CefErrorCode ErrorCode { get; private set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00003386 File Offset: 0x00001586
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000338E File Offset: 0x0000158E
		public string ErrorText { get; private set; }
	}
}
