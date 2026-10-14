using System;
using System.Security.Claims;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000036 RID: 54
	public class SecurityTokenDescriptor
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00006B9A File Offset: 0x00004D9A
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00006BA2 File Offset: 0x00004DA2
		public string Audience { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00006BAB File Offset: 0x00004DAB
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00006BB3 File Offset: 0x00004DB3
		public global::Microsoft.IdentityModel.Tokens.EncryptingCredentials EncryptingCredentials { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00006BBC File Offset: 0x00004DBC
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00006BC4 File Offset: 0x00004DC4
		public global::System.DateTime? Expires { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00006BCD File Offset: 0x00004DCD
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00006BD5 File Offset: 0x00004DD5
		public string Issuer { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00006BDE File Offset: 0x00004DDE
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00006BE6 File Offset: 0x00004DE6
		public global::System.DateTime? IssuedAt { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00006BEF File Offset: 0x00004DEF
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00006BF7 File Offset: 0x00004DF7
		public global::System.DateTime? NotBefore { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00006C00 File Offset: 0x00004E00
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00006C08 File Offset: 0x00004E08
		public global::Microsoft.IdentityModel.Tokens.SigningCredentials SigningCredentials { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00006C11 File Offset: 0x00004E11
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00006C19 File Offset: 0x00004E19
		public global::System.Security.Claims.ClaimsIdentity Subject { get; set; }
	}
}
