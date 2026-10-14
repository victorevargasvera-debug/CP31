using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000002 RID: 2
	public abstract class AsymmetricSecurityKey : global::Microsoft.IdentityModel.Tokens.SecurityKey
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1
		[global::System.Obsolete("HasPrivateKey method is deprecated, please use PrivateKeyStatus instead.")]
		public abstract bool HasPrivateKey { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2
		public abstract global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus PrivateKeyStatus { get; }
	}
}
