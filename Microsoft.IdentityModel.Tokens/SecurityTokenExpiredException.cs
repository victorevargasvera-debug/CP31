using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000015 RID: 21
	public class SecurityTokenExpiredException : global::Microsoft.IdentityModel.Tokens.SecurityTokenValidationException
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000050C2 File Offset: 0x000032C2
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000050CA File Offset: 0x000032CA
		public global::System.DateTime Expires { get; set; }

		// Token: 0x0600009B RID: 155 RVA: 0x000050D3 File Offset: 0x000032D3
		public SecurityTokenExpiredException() : base("SecurityToken has Expired")
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000050E0 File Offset: 0x000032E0
		public SecurityTokenExpiredException(string message) : base(message)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000050E9 File Offset: 0x000032E9
		public SecurityTokenExpiredException(string message, global::System.Exception inner) : base(message, inner)
		{
		}
	}
}
