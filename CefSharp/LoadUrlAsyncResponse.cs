using System;

namespace CefSharp
{
	// Token: 0x0200008C RID: 140
	public class LoadUrlAsyncResponse
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000378B File Offset: 0x0000198B
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00003793 File Offset: 0x00001993
		public global::CefSharp.CefErrorCode ErrorCode { get; private set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000379C File Offset: 0x0000199C
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x000037A4 File Offset: 0x000019A4
		public int HttpStatusCode { get; private set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x000037AD File Offset: 0x000019AD
		public bool Success
		{
			get
			{
				return this.ErrorCode == global::CefSharp.CefErrorCode.None && this.HttpStatusCode == 200;
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000037C6 File Offset: 0x000019C6
		public LoadUrlAsyncResponse(global::CefSharp.CefErrorCode errorCode, int httpStatusCode)
		{
			this.ErrorCode = errorCode;
			this.HttpStatusCode = httpStatusCode;
		}
	}
}
