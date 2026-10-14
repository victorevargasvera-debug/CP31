using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200001D RID: 29
	public class SecurityTokenNotYetValidException : global::Microsoft.IdentityModel.Tokens.SecurityTokenValidationException
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000520A File Offset: 0x0000340A
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00005212 File Offset: 0x00003412
		public global::System.DateTime NotBefore { get; set; }

		// Token: 0x060000BF RID: 191 RVA: 0x0000521B File Offset: 0x0000341B
		public SecurityTokenNotYetValidException() : base("SecurityToken is not yet valid")
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005228 File Offset: 0x00003428
		public SecurityTokenNotYetValidException(string message) : base(message)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005231 File Offset: 0x00003431
		public SecurityTokenNotYetValidException(string message, global::System.Exception inner) : base(message, inner)
		{
		}
	}
}
