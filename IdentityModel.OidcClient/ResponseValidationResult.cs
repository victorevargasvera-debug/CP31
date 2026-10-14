using System;
using System.Security.Claims;
using IdentityModel.Client;

namespace IdentityModel.OidcClient
{
	// Token: 0x02000021 RID: 33
	public class ResponseValidationResult : global::IdentityModel.OidcClient.Result
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00005884 File Offset: 0x00003A84
		public ResponseValidationResult()
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000588C File Offset: 0x00003A8C
		public ResponseValidationResult(string error)
		{
			base.Error = error;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000589C File Offset: 0x00003A9C
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000058A4 File Offset: 0x00003AA4
		public global::IdentityModel.Client.AuthorizeResponse AuthorizeResponse { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000058B0 File Offset: 0x00003AB0
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000058B8 File Offset: 0x00003AB8
		public global::IdentityModel.Client.TokenResponse TokenResponse { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000058C4 File Offset: 0x00003AC4
		// (set) Token: 0x060000BE RID: 190 RVA: 0x000058CC File Offset: 0x00003ACC
		public global::System.Security.Claims.ClaimsPrincipal User { get; set; }
	}
}
