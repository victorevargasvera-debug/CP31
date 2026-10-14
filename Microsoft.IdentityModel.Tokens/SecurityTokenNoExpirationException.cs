using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200001C RID: 28
	public class SecurityTokenNoExpirationException : global::Microsoft.IdentityModel.Tokens.SecurityTokenValidationException
	{
		// Token: 0x060000BA RID: 186 RVA: 0x000051EF File Offset: 0x000033EF
		public SecurityTokenNoExpirationException()
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000051F7 File Offset: 0x000033F7
		public SecurityTokenNoExpirationException(string message) : base(message)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005200 File Offset: 0x00003400
		public SecurityTokenNoExpirationException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
