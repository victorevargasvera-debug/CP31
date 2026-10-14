using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000018 RID: 24
	public class SecurityTokenInvalidLifetimeException : global::Microsoft.IdentityModel.Tokens.SecurityTokenValidationException
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000514B File Offset: 0x0000334B
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00005153 File Offset: 0x00003353
		public global::System.DateTime? NotBefore { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000515C File Offset: 0x0000335C
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00005164 File Offset: 0x00003364
		public global::System.DateTime? Expires { get; set; }

		// Token: 0x060000AC RID: 172 RVA: 0x0000516D File Offset: 0x0000336D
		public SecurityTokenInvalidLifetimeException()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005175 File Offset: 0x00003375
		public SecurityTokenInvalidLifetimeException(string message) : base(message)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000517E File Offset: 0x0000337E
		public SecurityTokenInvalidLifetimeException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
