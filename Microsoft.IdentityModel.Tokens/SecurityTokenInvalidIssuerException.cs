using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000017 RID: 23
	public class SecurityTokenInvalidIssuerException : global::Microsoft.IdentityModel.Tokens.SecurityTokenValidationException
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000511F File Offset: 0x0000331F
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00005127 File Offset: 0x00003327
		public string InvalidIssuer { get; set; }

		// Token: 0x060000A5 RID: 165 RVA: 0x00005130 File Offset: 0x00003330
		public SecurityTokenInvalidIssuerException()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00005138 File Offset: 0x00003338
		public SecurityTokenInvalidIssuerException(string message) : base(message)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005141 File Offset: 0x00003341
		public SecurityTokenInvalidIssuerException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
