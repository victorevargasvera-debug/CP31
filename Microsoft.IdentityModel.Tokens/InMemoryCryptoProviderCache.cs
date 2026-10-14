using System;
using System.Collections.Concurrent;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000023 RID: 35
	public class InMemoryCryptoProviderCache : global::Microsoft.IdentityModel.Tokens.CryptoProviderCache
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x000052AC File Offset: 0x000034AC
		protected override string GetCacheKey(global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider)
		{
			if (signatureProvider == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("signatureProvider");
			}
			return this.GetCacheKeyPrivate(signatureProvider.Key, signatureProvider.Algorithm, signatureProvider.GetType().ToString());
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000052D9 File Offset: 0x000034D9
		protected override string GetCacheKey(global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey, string algorithm, string typeofProvider)
		{
			if (securityKey == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("securityKey");
			}
			if (string.IsNullOrEmpty(algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
			if (string.IsNullOrEmpty(typeofProvider))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("typeofProvider");
			}
			return this.GetCacheKeyPrivate(securityKey, algorithm, typeofProvider);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00005318 File Offset: 0x00003518
		private string GetCacheKeyPrivate(global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey, string algorithm, string typeofProvider)
		{
			return string.Format("{0}-{1}-{2}-{3}", new object[]
			{
				securityKey.GetType(),
				securityKey.KeyId,
				algorithm,
				typeofProvider
			});
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005344 File Offset: 0x00003544
		public override bool TryAdd(global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider)
		{
			if (signatureProvider == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("signatureProvider");
			}
			string cacheKey = this.GetCacheKey(signatureProvider);
			if (signatureProvider.WillCreateSignatures)
			{
				if (this._signingSignatureProviders.TryAdd(cacheKey, signatureProvider))
				{
					signatureProvider.CryptoProviderCache = this;
					return true;
				}
			}
			else if (this._verifyingSignatureProviders.TryAdd(cacheKey, signatureProvider))
			{
				signatureProvider.CryptoProviderCache = this;
				return true;
			}
			return false;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000053A0 File Offset: 0x000035A0
		public override bool TryGetSignatureProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey, string algorithm, string typeofProvider, bool willCreateSignatures, out global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider)
		{
			if (securityKey == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("securityKey");
			}
			if (string.IsNullOrEmpty(algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
			if (string.IsNullOrEmpty(typeofProvider))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("typeofProvider");
			}
			string cacheKeyPrivate = this.GetCacheKeyPrivate(securityKey, algorithm, typeofProvider);
			if (willCreateSignatures)
			{
				return this._signingSignatureProviders.TryGetValue(cacheKeyPrivate, out signatureProvider);
			}
			return this._verifyingSignatureProviders.TryGetValue(cacheKeyPrivate, out signatureProvider);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000540C File Offset: 0x0000360C
		public override bool TryRemove(global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider)
		{
			if (signatureProvider == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("signatureProvider");
			}
			if (signatureProvider.CryptoProviderCache != this)
			{
				return false;
			}
			string cacheKey = this.GetCacheKey(signatureProvider);
			global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider3;
			if (signatureProvider.WillCreateSignatures)
			{
				global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider2;
				if (this._signingSignatureProviders.TryRemove(cacheKey, out signatureProvider2))
				{
					signatureProvider2.CryptoProviderCache = null;
					return true;
				}
			}
			else if (this._verifyingSignatureProviders.TryRemove(cacheKey, out signatureProvider3))
			{
				signatureProvider3.CryptoProviderCache = null;
				return true;
			}
			return false;
		}

		// Token: 0x04000048 RID: 72
		private global::System.Collections.Concurrent.ConcurrentDictionary<string, global::Microsoft.IdentityModel.Tokens.SignatureProvider> _signingSignatureProviders = new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::Microsoft.IdentityModel.Tokens.SignatureProvider>();

		// Token: 0x04000049 RID: 73
		private global::System.Collections.Concurrent.ConcurrentDictionary<string, global::Microsoft.IdentityModel.Tokens.SignatureProvider> _verifyingSignatureProviders = new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::Microsoft.IdentityModel.Tokens.SignatureProvider>();
	}
}
