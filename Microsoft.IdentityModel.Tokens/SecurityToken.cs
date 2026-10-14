using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000035 RID: 53
	public abstract class SecurityToken
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000147 RID: 327
		public abstract string Id { get; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000148 RID: 328
		public abstract string Issuer { get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000149 RID: 329
		public abstract global::Microsoft.IdentityModel.Tokens.SecurityKey SecurityKey { get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600014A RID: 330
		// (set) Token: 0x0600014B RID: 331
		public abstract global::Microsoft.IdentityModel.Tokens.SecurityKey SigningKey { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600014C RID: 332
		public abstract global::System.DateTime ValidFrom { get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600014D RID: 333
		public abstract global::System.DateTime ValidTo { get; }
	}
}
