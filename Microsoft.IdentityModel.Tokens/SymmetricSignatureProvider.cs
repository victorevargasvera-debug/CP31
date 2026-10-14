using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200003B RID: 59
	public class SymmetricSignatureProvider : global::Microsoft.IdentityModel.Tokens.SignatureProvider
	{
		// Token: 0x0600018E RID: 398 RVA: 0x00006EBA File Offset: 0x000050BA
		public SymmetricSignatureProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm) : this(key, algorithm, true)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00006EC8 File Offset: 0x000050C8
		public SymmetricSignatureProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm, bool willCreateSignatures) : base(key, algorithm)
		{
			if (!key.CryptoProviderFactory.IsSupportedAlgorithm(algorithm, key))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10634: Unable to create the SignatureProvider.\nAlgorithm: '{0}', SecurityKey: '{1}'\n is not supported.", new object[]
				{
					algorithm ?? "null",
					key
				})));
			}
			if (key.KeySize < this.MinimumSymmetricKeySizeInBits)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("KeySize", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10603: Decryption failed. Keys tried: '{0}'.\nExceptions caught:\n '{1}'.\ntoken: '{2}'", new object[]
				{
					algorithm ?? "null",
					this.MinimumSymmetricKeySizeInBits,
					key.KeySize
				})));
			}
			base.WillCreateSignatures = willCreateSignatures;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00006F81 File Offset: 0x00005181
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00006F89 File Offset: 0x00005189
		public int MinimumSymmetricKeySizeInBits
		{
			get
			{
				return this._minimumSymmetricKeySizeInBits;
			}
			set
			{
				if (value < global::Microsoft.IdentityModel.Tokens.SymmetricSignatureProvider.DefaultMinimumSymmetricKeySizeInBits)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("value", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10628: Cannot set the MinimumSymmetricKeySizeInBits to less than '{0}'.", new object[]
					{
						global::Microsoft.IdentityModel.Tokens.SymmetricSignatureProvider.DefaultMinimumSymmetricKeySizeInBits
					})));
				}
				this._minimumSymmetricKeySizeInBits = value;
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00006FC8 File Offset: 0x000051C8
		protected virtual byte[] GetKeyBytes(global::Microsoft.IdentityModel.Tokens.SecurityKey key)
		{
			if (key == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
			}
			global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey symmetricSecurityKey;
			if ((symmetricSecurityKey = (key as global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey)) != null)
			{
				return symmetricSecurityKey.Key;
			}
			global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey;
			if ((jsonWebKey = (key as global::Microsoft.IdentityModel.Tokens.JsonWebKey)) != null && jsonWebKey.K != null && jsonWebKey.Kty == "oct")
			{
				return global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(jsonWebKey.K);
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10667: Unable to obtain required byte array for KeyHashAlgorithm from SecurityKey: '{0}'.", new object[]
			{
				key
			})));
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00007044 File Offset: 0x00005244
		protected virtual global::System.Security.Cryptography.KeyedHashAlgorithm GetKeyedHashAlgorithm(byte[] keyBytes, string algorithm)
		{
			if (this._keyedHash == null)
			{
				try
				{
					this._keyedHash = base.Key.CryptoProviderFactory.CreateKeyedHashAlgorithm(keyBytes, algorithm);
				}
				catch (global::System.Exception innerException)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10677: GetKeyedHashAlgorithm threw, key: {0}, algorithm {1}.", new object[]
					{
						base.Key,
						algorithm ?? "null"
					}), innerException));
				}
			}
			return this._keyedHash;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000070BC File Offset: 0x000052BC
		private global::System.Security.Cryptography.KeyedHashAlgorithm KeyedHashAlgorithm
		{
			get
			{
				if (this._keyedHash == null)
				{
					try
					{
						this._keyedHash = this.GetKeyedHashAlgorithm(this.GetKeyBytes(base.Key), base.Algorithm);
					}
					catch (global::System.Exception innerException)
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10677: GetKeyedHashAlgorithm threw, key: {0}, algorithm {1}.", new object[]
						{
							base.Key,
							base.Algorithm ?? "null"
						}), innerException));
					}
				}
				return this._keyedHash;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00007140 File Offset: 0x00005340
		public override byte[] Sign(byte[] input)
		{
			if (input == null || input.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("input");
			}
			if (this._disposed)
			{
				global::Microsoft.IdentityModel.Tokens.CryptoProviderCache cryptoProviderCache = base.CryptoProviderCache;
				if (cryptoProviderCache != null)
				{
					cryptoProviderCache.TryRemove(this);
				}
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ObjectDisposedException(typeof(global::Microsoft.IdentityModel.Tokens.SymmetricSignatureProvider).ToString()));
			}
			global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10642: Creating signature using the input: '{0}'.", new object[]
			{
				input
			});
			byte[] result;
			try
			{
				result = this.KeyedHashAlgorithm.ComputeHash(input);
			}
			catch
			{
				global::Microsoft.IdentityModel.Tokens.CryptoProviderCache cryptoProviderCache2 = base.CryptoProviderCache;
				if (cryptoProviderCache2 != null)
				{
					cryptoProviderCache2.TryRemove(this);
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000071E0 File Offset: 0x000053E0
		public override bool Verify(byte[] input, byte[] signature)
		{
			if (input == null || input.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("input");
			}
			if (signature == null || signature.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("signature");
			}
			if (this._disposed)
			{
				global::Microsoft.IdentityModel.Tokens.CryptoProviderCache cryptoProviderCache = base.CryptoProviderCache;
				if (cryptoProviderCache != null)
				{
					cryptoProviderCache.TryRemove(this);
				}
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ObjectDisposedException(typeof(global::Microsoft.IdentityModel.Tokens.SymmetricSignatureProvider).ToString()));
			}
			global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10643: Comparing the signature created over the input with the token signature: '{0}'.", new object[]
			{
				input
			});
			bool result;
			try
			{
				result = global::Microsoft.IdentityModel.Tokens.Utility.AreEqual(signature, this.KeyedHashAlgorithm.ComputeHash(input));
			}
			catch
			{
				global::Microsoft.IdentityModel.Tokens.CryptoProviderCache cryptoProviderCache2 = base.CryptoProviderCache;
				if (cryptoProviderCache2 != null)
				{
					cryptoProviderCache2.TryRemove(this);
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00007298 File Offset: 0x00005498
		public bool Verify(byte[] input, byte[] signature, int length)
		{
			if (input == null || input.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("input");
			}
			if (signature == null || signature.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("signature");
			}
			if (length < 1)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10655: 'length' must be greater than 1: '{0}'", new object[]
				{
					length
				})));
			}
			if (this._disposed)
			{
				global::Microsoft.IdentityModel.Tokens.CryptoProviderCache cryptoProviderCache = base.CryptoProviderCache;
				if (cryptoProviderCache != null)
				{
					cryptoProviderCache.TryRemove(this);
				}
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ObjectDisposedException(typeof(global::Microsoft.IdentityModel.Tokens.SymmetricSignatureProvider).ToString()));
			}
			global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10643: Comparing the signature created over the input with the token signature: '{0}'.", new object[]
			{
				input
			});
			bool result;
			try
			{
				result = global::Microsoft.IdentityModel.Tokens.Utility.AreEqual(signature, this.KeyedHashAlgorithm.ComputeHash(input), length);
			}
			catch
			{
				global::Microsoft.IdentityModel.Tokens.CryptoProviderCache cryptoProviderCache2 = base.CryptoProviderCache;
				if (cryptoProviderCache2 != null)
				{
					cryptoProviderCache2.TryRemove(this);
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007378 File Offset: 0x00005578
		protected override void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				this._disposed = true;
				global::Microsoft.IdentityModel.Tokens.CryptoProviderCache cryptoProviderCache = base.CryptoProviderCache;
				if (cryptoProviderCache != null)
				{
					cryptoProviderCache.TryRemove(this);
				}
				if (disposing && this._keyedHash != null)
				{
					this._keyedHash.Dispose();
					this._keyedHash = null;
				}
			}
		}

		// Token: 0x04000164 RID: 356
		private bool _disposed;

		// Token: 0x04000165 RID: 357
		private global::System.Security.Cryptography.KeyedHashAlgorithm _keyedHash;

		// Token: 0x04000166 RID: 358
		public static readonly int DefaultMinimumSymmetricKeySizeInBits = 128;

		// Token: 0x04000167 RID: 359
		private int _minimumSymmetricKeySizeInBits = global::Microsoft.IdentityModel.Tokens.SymmetricSignatureProvider.DefaultMinimumSymmetricKeySizeInBits;
	}
}
