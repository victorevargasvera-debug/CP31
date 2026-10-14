using System;

namespace IdentityModel.OidcClient.Results
{
	// Token: 0x02000027 RID: 39
	internal class TokenResponseValidationResult : global::IdentityModel.OidcClient.Result
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x000059D8 File Offset: 0x00003BD8
		public TokenResponseValidationResult(string error)
		{
			base.Error = error;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000059E8 File Offset: 0x00003BE8
		public TokenResponseValidationResult(global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult result)
		{
			this.IdentityTokenValidationResult = result;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000059F8 File Offset: 0x00003BF8
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00005A00 File Offset: 0x00003C00
		public global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult IdentityTokenValidationResult { get; set; }
	}
}
