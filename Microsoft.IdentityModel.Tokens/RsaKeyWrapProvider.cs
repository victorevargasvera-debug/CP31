using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200000E RID: 14
	public class RsaKeyWrapProvider : global::Microsoft.IdentityModel.Tokens.KeyWrapProvider
	{
		// Token: 0x06000072 RID: 114 RVA: 0x000043E8 File Offset: 0x000025E8
		public RsaKeyWrapProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm, bool willUnwrap)
		{
			if (key == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
			}
			if (string.IsNullOrEmpty(algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
			if (!this.IsSupportedAlgorithm(key, algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10661: Unable to create the KeyWrapProvider.\nKeyWrapAlgorithm: '{0}', SecurityKey: '{1}'\n is not supported.", new object[]
				{
					algorithm,
					key
				})));
			}
			this.Algorithm = algorithm;
			this.Key = key;
			global::Microsoft.IdentityModel.Tokens.RsaAlgorithm rsaAlgorithm = global::Microsoft.IdentityModel.Tokens.Utility.ResolveRsaAlgorithm(key, algorithm, willUnwrap);
			if (rsaAlgorithm != null)
			{
				if (rsaAlgorithm.RsaCryptoServiceProvider != null)
				{
					this._rsaCryptoServiceProvider = rsaAlgorithm.RsaCryptoServiceProvider;
					this._shouldDisposeRsa = rsaAlgorithm.ShouldDispose;
					return;
				}
				if (rsaAlgorithm.RsaCryptoServiceProviderProxy != null)
				{
					this._rsaCryptoServiceProviderProxy = rsaAlgorithm.RsaCryptoServiceProviderProxy;
					this._shouldDisposeRsa = rsaAlgorithm.ShouldDispose;
					return;
				}
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10661: Unable to create the KeyWrapProvider.\nKeyWrapAlgorithm: '{0}', SecurityKey: '{1}'\n is not supported.", new object[]
			{
				algorithm,
				key
			})));
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000044C7 File Offset: 0x000026C7
		public override string Algorithm { get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000044CF File Offset: 0x000026CF
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000044D7 File Offset: 0x000026D7
		public override string Context { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000044E0 File Offset: 0x000026E0
		public override global::Microsoft.IdentityModel.Tokens.SecurityKey Key { get; }

		// Token: 0x06000077 RID: 119 RVA: 0x000044E8 File Offset: 0x000026E8
		protected override void Dispose(bool disposing)
		{
			if (!this._disposed && disposing)
			{
				if (this._rsaCryptoServiceProvider != null && this._shouldDisposeRsa)
				{
					this._rsaCryptoServiceProvider.Dispose();
				}
				if (this._rsaCryptoServiceProviderProxy != null)
				{
					this._rsaCryptoServiceProviderProxy.Dispose();
				}
				this._disposed = true;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004538 File Offset: 0x00002738
		protected virtual bool IsSupportedAlgorithm(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			if (key == null)
			{
				return false;
			}
			if (string.IsNullOrEmpty(algorithm))
			{
				return false;
			}
			if (key.KeySize < 2048)
			{
				return false;
			}
			if (algorithm.Equals("RSA1_5", global::System.StringComparison.Ordinal) || algorithm.Equals("RSA-OAEP", global::System.StringComparison.Ordinal) || algorithm.Equals("http://www.w3.org/2001/04/xmlenc#rsa-oaep", global::System.StringComparison.Ordinal))
			{
				if (key is global::Microsoft.IdentityModel.Tokens.RsaSecurityKey)
				{
					return true;
				}
				global::Microsoft.IdentityModel.Tokens.X509SecurityKey x509SecurityKey = key as global::Microsoft.IdentityModel.Tokens.X509SecurityKey;
				if (x509SecurityKey != null)
				{
					return x509SecurityKey.PublicKey is global::System.Security.Cryptography.RSACryptoServiceProvider;
				}
				global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey = key as global::Microsoft.IdentityModel.Tokens.JsonWebKey;
				if (jsonWebKey != null && jsonWebKey.Kty == "RSA")
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000045D4 File Offset: 0x000027D4
		public override byte[] UnwrapKey(byte[] keyBytes)
		{
			if (keyBytes == null || keyBytes.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("wrappedKey");
			}
			if (this._disposed)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ObjectDisposedException(base.GetType().ToString()));
			}
			bool fOAEP = this.Algorithm.Equals("RSA-OAEP", global::System.StringComparison.Ordinal) || this.Algorithm.Equals("http://www.w3.org/2001/04/xmlenc#rsa-oaep", global::System.StringComparison.Ordinal);
			try
			{
				if (this._rsaCryptoServiceProvider != null)
				{
					return this._rsaCryptoServiceProvider.Decrypt(keyBytes, fOAEP);
				}
				if (this._rsaCryptoServiceProviderProxy != null)
				{
					return this._rsaCryptoServiceProviderProxy.Decrypt(keyBytes, fOAEP);
				}
			}
			catch (global::System.Exception ex)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenKeyWrapException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10659: UnwrapKey failed, exception from cryptographic operation: '{0}'", new object[]
				{
					ex
				})));
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10644: UnwrapKey failed. Algorithm: '{0}'.", new object[]
			{
				this.Algorithm
			})));
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000046C0 File Offset: 0x000028C0
		public override byte[] WrapKey(byte[] keyBytes)
		{
			if (keyBytes == null || keyBytes.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("keyBytes");
			}
			if (this._disposed)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ObjectDisposedException(base.GetType().ToString()));
			}
			bool fOAEP = this.Algorithm.Equals("RSA-OAEP", global::System.StringComparison.Ordinal) || this.Algorithm.Equals("http://www.w3.org/2001/04/xmlenc#rsa-oaep", global::System.StringComparison.Ordinal);
			try
			{
				if (this._rsaCryptoServiceProvider != null)
				{
					return this._rsaCryptoServiceProvider.Encrypt(keyBytes, fOAEP);
				}
				if (this._rsaCryptoServiceProviderProxy != null)
				{
					return this._rsaCryptoServiceProviderProxy.Encrypt(keyBytes, fOAEP);
				}
			}
			catch (global::System.Exception ex)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenKeyWrapException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10658: WrapKey failed, exception from cryptographic operation: '{0}'", new object[]
				{
					ex
				})));
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10644: UnwrapKey failed. Algorithm: '{0}'.", new object[]
			{
				this.Algorithm
			})));
		}

		// Token: 0x0400002D RID: 45
		private global::System.Security.Cryptography.RSACryptoServiceProvider _rsaCryptoServiceProvider;

		// Token: 0x0400002E RID: 46
		private global::Microsoft.IdentityModel.Tokens.RSACryptoServiceProviderProxy _rsaCryptoServiceProviderProxy;

		// Token: 0x0400002F RID: 47
		private bool _shouldDisposeRsa;

		// Token: 0x04000030 RID: 48
		private bool _disposed;
	}
}
