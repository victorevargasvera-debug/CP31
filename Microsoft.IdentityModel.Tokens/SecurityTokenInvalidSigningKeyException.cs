using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200001A RID: 26
	public class SecurityTokenInvalidSigningKeyException : global::Microsoft.IdentityModel.Tokens.SecurityTokenValidationException
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000051A3 File Offset: 0x000033A3
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000051AB File Offset: 0x000033AB
		public global::Microsoft.IdentityModel.Tokens.SecurityKey SigningKey { get; set; }

		// Token: 0x060000B4 RID: 180 RVA: 0x000051B4 File Offset: 0x000033B4
		public SecurityTokenInvalidSigningKeyException() : base("SecurityToken has invalid issuer signing key.")
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000051C1 File Offset: 0x000033C1
		public SecurityTokenInvalidSigningKeyException(string message) : base(message)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000051CA File Offset: 0x000033CA
		public SecurityTokenInvalidSigningKeyException(string message, global::System.Exception inner) : base(message, inner)
		{
		}
	}
}
