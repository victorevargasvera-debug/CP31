using System;

namespace CefSharp
{
	// Token: 0x02000049 RID: 73
	public class FrameLoadEndEventArgs : global::System.EventArgs
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00003177 File Offset: 0x00001377
		public FrameLoadEndEventArgs(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, int httpStatusCode)
		{
			this.Browser = browser;
			this.Frame = frame;
			if (frame.IsValid)
			{
				this.Url = frame.Url;
			}
			this.HttpStatusCode = httpStatusCode;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000031A8 File Offset: 0x000013A8
		// (set) Token: 0x060000EB RID: 235 RVA: 0x000031B0 File Offset: 0x000013B0
		public global::CefSharp.IBrowser Browser { get; private set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000031B9 File Offset: 0x000013B9
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000031C1 File Offset: 0x000013C1
		public global::CefSharp.IFrame Frame { get; private set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000031CA File Offset: 0x000013CA
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000031D2 File Offset: 0x000013D2
		public string Url { get; private set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000031DB File Offset: 0x000013DB
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x000031E3 File Offset: 0x000013E3
		public int HttpStatusCode { get; set; }
	}
}
