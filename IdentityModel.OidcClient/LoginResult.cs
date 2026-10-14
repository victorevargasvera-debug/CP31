using System;
using System.Net.Http;
using System.Security.Claims;

namespace IdentityModel.OidcClient
{
	// Token: 0x02000020 RID: 32
	public class LoginResult : global::IdentityModel.OidcClient.Result
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x000057E0 File Offset: 0x000039E0
		public LoginResult()
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000057E8 File Offset: 0x000039E8
		public LoginResult(string error)
		{
			base.Error = error;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000057F8 File Offset: 0x000039F8
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00005800 File Offset: 0x00003A00
		public global::System.Security.Claims.ClaimsPrincipal User { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000580C File Offset: 0x00003A0C
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00005814 File Offset: 0x00003A14
		public string AccessToken { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00005820 File Offset: 0x00003A20
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00005828 File Offset: 0x00003A28
		public string IdentityToken { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00005834 File Offset: 0x00003A34
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000583C File Offset: 0x00003A3C
		public string RefreshToken { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00005848 File Offset: 0x00003A48
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00005850 File Offset: 0x00003A50
		public global::System.DateTime AccessTokenExpiration { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000585C File Offset: 0x00003A5C
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00005864 File Offset: 0x00003A64
		public global::System.DateTime AuthenticationTime { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00005870 File Offset: 0x00003A70
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00005878 File Offset: 0x00003A78
		public global::System.Net.Http.HttpMessageHandler RefreshTokenHandler { get; set; }
	}
}
