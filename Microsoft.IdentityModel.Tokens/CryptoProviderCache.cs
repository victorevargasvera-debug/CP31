using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000006 RID: 6
	public abstract class CryptoProviderCache
	{
		// Token: 0x06000016 RID: 22
		protected abstract string GetCacheKey(global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider);

		// Token: 0x06000017 RID: 23
		protected abstract string GetCacheKey(global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey, string algorithm, string typeofProvider);

		// Token: 0x06000018 RID: 24
		public abstract bool TryAdd(global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider);

		// Token: 0x06000019 RID: 25
		public abstract bool TryGetSignatureProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey, string algorithm, string typeofProvider, bool willCreateSignatures, out global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider);

		// Token: 0x0600001A RID: 26
		public abstract bool TryRemove(global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider);
	}
}
