using System;
using System.Security.Claims;

namespace IdentityModel.OidcClient.Results
{
	// Token: 0x02000025 RID: 37
	public class IdentityTokenValidationResult : global::IdentityModel.OidcClient.Result
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00005950 File Offset: 0x00003B50
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00005958 File Offset: 0x00003B58
		public global::System.Security.Claims.ClaimsPrincipal User { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00005964 File Offset: 0x00003B64
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000596C File Offset: 0x00003B6C
		public string SignatureAlgorithm { get; set; }
	}
}
