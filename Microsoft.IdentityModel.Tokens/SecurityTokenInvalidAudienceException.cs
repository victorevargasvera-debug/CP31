using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000016 RID: 22
	public class SecurityTokenInvalidAudienceException : global::Microsoft.IdentityModel.Tokens.SecurityTokenValidationException
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000050F3 File Offset: 0x000032F3
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000050FB File Offset: 0x000032FB
		public string InvalidAudience { get; set; }

		// Token: 0x060000A0 RID: 160 RVA: 0x00005104 File Offset: 0x00003304
		public SecurityTokenInvalidAudienceException()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000510C File Offset: 0x0000330C
		public SecurityTokenInvalidAudienceException(string message) : base(message)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005115 File Offset: 0x00003315
		public SecurityTokenInvalidAudienceException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
