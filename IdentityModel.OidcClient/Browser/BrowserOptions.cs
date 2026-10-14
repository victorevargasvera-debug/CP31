using System;

namespace IdentityModel.OidcClient.Browser
{
	// Token: 0x0200002B RID: 43
	public class BrowserOptions
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00005AF8 File Offset: 0x00003CF8
		public string StartUrl { get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00005B00 File Offset: 0x00003D00
		public string EndUrl { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00005B08 File Offset: 0x00003D08
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00005B10 File Offset: 0x00003D10
		public global::IdentityModel.OidcClient.OidcClientOptions.AuthorizeResponseMode ResponseMode { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005B1C File Offset: 0x00003D1C
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00005B24 File Offset: 0x00003D24
		public global::IdentityModel.OidcClient.Browser.DisplayMode DisplayMode { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00005B30 File Offset: 0x00003D30
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00005B38 File Offset: 0x00003D38
		public global::System.TimeSpan Timeout { get; set; } = global::System.TimeSpan.FromMinutes(5.0);

		// Token: 0x060000EC RID: 236 RVA: 0x00005B44 File Offset: 0x00003D44
		public BrowserOptions(string startUrl, string endUrl)
		{
			this.StartUrl = startUrl;
			this.EndUrl = endUrl;
		}
	}
}
