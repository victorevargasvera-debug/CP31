using System;

namespace IdentityModel.OidcClient.Results
{
	// Token: 0x02000026 RID: 38
	public class RefreshTokenResult : global::IdentityModel.OidcClient.Result
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005980 File Offset: 0x00003B80
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00005988 File Offset: 0x00003B88
		public string IdentityToken { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005994 File Offset: 0x00003B94
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000599C File Offset: 0x00003B9C
		public string AccessToken { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000059A8 File Offset: 0x00003BA8
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x000059B0 File Offset: 0x00003BB0
		public string RefreshToken { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000059BC File Offset: 0x00003BBC
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000059C4 File Offset: 0x00003BC4
		public int ExpiresIn { get; set; }
	}
}
