using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200001F RID: 31
	public class SecurityTokenReplayDetectedException : global::Microsoft.IdentityModel.Tokens.SecurityTokenValidationException
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00005256 File Offset: 0x00003456
		public SecurityTokenReplayDetectedException() : base("SecurityToken replay detected")
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005263 File Offset: 0x00003463
		public SecurityTokenReplayDetectedException(string message) : base(message)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000526C File Offset: 0x0000346C
		public SecurityTokenReplayDetectedException(string message, global::System.Exception inner) : base(message, inner)
		{
		}
	}
}
