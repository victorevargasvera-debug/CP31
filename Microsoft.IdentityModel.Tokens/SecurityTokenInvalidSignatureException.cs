using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000019 RID: 25
	public class SecurityTokenInvalidSignatureException : global::Microsoft.IdentityModel.Tokens.SecurityTokenValidationException
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00005188 File Offset: 0x00003388
		public SecurityTokenInvalidSignatureException()
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005190 File Offset: 0x00003390
		public SecurityTokenInvalidSignatureException(string message) : base(message)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005199 File Offset: 0x00003399
		public SecurityTokenInvalidSignatureException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
