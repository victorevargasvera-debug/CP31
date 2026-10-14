using System;

namespace IdentityModel.OidcClient.Browser
{
	// Token: 0x0200002C RID: 44
	public class BrowserResult : global::IdentityModel.OidcClient.Result
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00005B70 File Offset: 0x00003D70
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00005B78 File Offset: 0x00003D78
		public global::IdentityModel.OidcClient.Browser.BrowserResultType ResultType { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00005B84 File Offset: 0x00003D84
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00005B8C File Offset: 0x00003D8C
		public string Response { get; set; }
	}
}
