using System;

namespace CefSharp
{
	// Token: 0x020000A4 RID: 164
	public class WaitForNavigationAsyncResponse
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00006E93 File Offset: 0x00005093
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00006E9B File Offset: 0x0000509B
		public global::CefSharp.CefErrorCode ErrorCode { get; private set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00006EA4 File Offset: 0x000050A4
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00006EAC File Offset: 0x000050AC
		public int HttpStatusCode { get; private set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00006EB5 File Offset: 0x000050B5
		public bool Success
		{
			get
			{
				return this.ErrorCode == global::CefSharp.CefErrorCode.None && this.HttpStatusCode == 200;
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00006ECE File Offset: 0x000050CE
		public WaitForNavigationAsyncResponse(global::CefSharp.CefErrorCode errorCode, int httpStatusCode)
		{
			this.ErrorCode = errorCode;
			this.HttpStatusCode = httpStatusCode;
		}
	}
}
