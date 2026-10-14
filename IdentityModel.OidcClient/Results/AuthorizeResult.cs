using System;

namespace IdentityModel.OidcClient.Results
{
	// Token: 0x02000023 RID: 35
	public class AuthorizeResult : global::IdentityModel.OidcClient.Result
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00005904 File Offset: 0x00003B04
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000590C File Offset: 0x00003B0C
		public string Data { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00005918 File Offset: 0x00003B18
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00005920 File Offset: 0x00003B20
		public global::IdentityModel.OidcClient.AuthorizeState State { get; set; }
	}
}
