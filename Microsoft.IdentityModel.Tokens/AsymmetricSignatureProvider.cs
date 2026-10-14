using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000004 RID: 4
	public class AsymmetricSignatureProvider : global::Microsoft.IdentityModel.Tokens.SignatureProvider
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002058 File Offset: 0x00000258
		public AsymmetricSignatureProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm) : this(key, algorithm, false)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002064 File Offset: 0x00000264
		public AsymmetricSignatureProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm, bool willCreateSignatures) : base(key, algorithm)
		{
			this._minimumAsymmetricKeySizeInBitsForSigningMap = new global::System.Collections.Generic.Dictionary<string, int>(global::Microsoft.IdentityModel.Tokens.AsymmetricSignatureProvider.DefaultMinimumAsymmetricKeySizeInBitsForSigningMap);
			this._minimumAsymmetricKeySizeInBitsForVerifyingMap = new global::System.Collections.Generic.Dictionary<string, int>(global::Microsoft.IdentityModel.Tokens.AsymmetricSignatureProvider.DefaultMinimumAsymmetricKeySizeInBitsForVerifyingMap);
			if (willCreateSignatures && this.FoundPrivateKey(key) == global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.DoesNotExist)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10638: Cannot create the SignatureProvider, 'key.HasPrivateKey' is false, cannot create signatures. Key: {0}.", new object[]
				{
					key
				})));
			}
			if (!key.CryptoProviderFactory.IsSupportedAlgorithm(algorithm, key))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10634: Unable to create the SignatureProvider.\nAlgorithm: '{0}', SecurityKey: '{1}'\n is not supported.", new object[]
				{
					algorithm ?? "null",
					key
				})));
			}
			this.ValidateAsymmetricSecurityKeySize(key, algorithm, willCreateSignatures);
			this.ResolveAsymmetricAlgorithm(key, algorithm, willCreateSignatures);
			base.WillCreateSignatures = willCreateSignatures;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002119 File Offset: 0x00000319
		public global::System.Collections.Generic.IReadOnlyDictionary<string, int> MinimumAsymmetricKeySizeInBitsForSigningMap
		{
			get
			{
				return this._minimumAsymmetricKeySizeInBitsForSigningMap;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002121 File Offset: 0x00000321
		public global::System.Collections.Generic.IReadOnlyDictionary<string, int> MinimumAsymmetricKeySizeInBitsForVerifyingMap
		{
			get
			{
				return this._minimumAsymmetricKeySizeInBitsForVerifyingMap;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000212C File Offset: 0x0000032C
		private global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus FoundPrivateKey(global::Microsoft.IdentityModel.Tokens.SecurityKey key)
		{
			global::Microsoft.IdentityModel.Tokens.AsymmetricSecurityKey asymmetricSecurityKey;
			if ((asymmetricSecurityKey = (key as global::Microsoft.IdentityModel.Tokens.AsymmetricSecurityKey)) != null)
			{
				return asymmetricSecurityKey.PrivateKeyStatus;
			}
			global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey;
			if ((jsonWebKey = (key as global::Microsoft.IdentityModel.Tokens.JsonWebKey)) == null)
			{
				return global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.Unknown;
			}
			if (!jsonWebKey.HasPrivateKey)
			{
				return global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.DoesNotExist;
			}
			return global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.Exists;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002164 File Offset: 0x00000364
		protected virtual string GetHashAlgorithmString(string algorithm)
		{
			if (string.IsNullOrWhiteSpace(algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
			uint num = global::<PrivateImplementationDetails>.ComputeStringHash(algorithm);
			if (num <= 2033227867U)
			{
				if (num <= 892573150U)
				{
					if (num != 667263607U)
					{
						if (num != 758925578U)
						{
							if (num != 892573150U)
							{
								goto IL_196;
							}
							if (!(algorithm == "ES256"))
							{
								goto IL_196;
							}
						}
						else
						{
							if (!(algorithm == "RS512"))
							{
								goto IL_196;
							}
							goto IL_190;
						}
					}
					else
					{
						if (!(algorithm == "ES512"))
						{
							goto IL_196;
						}
						goto IL_190;
					}
				}
				else if (num != 1406094111U)
				{
					if (num != 1970331626U)
					{
						if (num != 2033227867U)
						{
							goto IL_196;
						}
						if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha256"))
						{
							goto IL_196;
						}
					}
					else
					{
						if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha512"))
						{
							goto IL_196;
						}
						goto IL_190;
					}
				}
				else
				{
					if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha384"))
					{
						goto IL_196;
					}
					goto IL_18A;
				}
			}
			else if (num <= 2969357051U)
			{
				if (num != 2342223295U)
				{
					if (num != 2824063256U)
					{
						if (num != 2969357051U)
						{
							goto IL_196;
						}
						if (!(algorithm == "RS256"))
						{
							goto IL_196;
						}
					}
					else
					{
						if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#rsa-sha512"))
						{
							goto IL_196;
						}
						goto IL_190;
					}
				}
				else
				{
					if (!(algorithm == "RS384"))
					{
						goto IL_196;
					}
					goto IL_18A;
				}
			}
			else if (num != 3113409762U)
			{
				if (num != 3339968437U)
				{
					if (num != 3880483293U)
					{
						goto IL_196;
					}
					if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256"))
					{
						goto IL_196;
					}
				}
				else
				{
					if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#rsa-sha384"))
					{
						goto IL_196;
					}
					goto IL_18A;
				}
			}
			else
			{
				if (!(algorithm == "ES384"))
				{
					goto IL_196;
				}
				goto IL_18A;
			}
			return "SHA256";
			IL_18A:
			return "SHA384";
			IL_190:
			return "SHA512";
			IL_196:
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10652: The algorithm '{0}' is not supported.", new object[]
			{
				algorithm
			}), "algorithm"));
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000232C File Offset: 0x0000052C
		private void ResolveAsymmetricAlgorithm(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm, bool willCreateSignatures)
		{
			this._hashAlgorithm = this.GetHashAlgorithmString(algorithm);
			global::Microsoft.IdentityModel.Tokens.RsaAlgorithm rsaAlgorithm = global::Microsoft.IdentityModel.Tokens.Utility.ResolveRsaAlgorithm(key, algorithm, willCreateSignatures);
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
				if (rsaAlgorithm.RsaCngAdapter != null)
				{
					this._rsaCngAdapter = rsaAlgorithm.RsaCngAdapter;
					this._shouldDisposeRsa = rsaAlgorithm.ShouldDispose;
					return;
				}
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10641: Key is not supported: '{0}'.", new object[]
				{
					key
				})));
			}
			else
			{
				global::Microsoft.IdentityModel.Tokens.ECDsaAlgorithm ecdsaAlgorithm = global::Microsoft.IdentityModel.Tokens.Utility.ResolveECDsaAlgorithm(key, algorithm, willCreateSignatures);
				if (ecdsaAlgorithm != null && ecdsaAlgorithm.ECDsa != null)
				{
					this._ecdsa = (ecdsaAlgorithm.ECDsa as global::System.Security.Cryptography.ECDsaCng);
					this._ecdsa.HashAlgorithm = new global::System.Security.Cryptography.CngAlgorithm(this._hashAlgorithm);
					this._shouldDisposeEcdsa = ecdsaAlgorithm.ShouldDispose;
					return;
				}
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10641: Key is not supported: '{0}'.", new object[]
				{
					key
				})));
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002440 File Offset: 0x00000640
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
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ObjectDisposedException(base.GetType().ToString()));
			}
			try
			{
				if (this._rsaCryptoServiceProvider != null)
				{
					return this._rsaCryptoServiceProvider.SignData(input, this._hashAlgorithm);
				}
				if (this._rsaCryptoServiceProviderProxy != null)
				{
					return this._rsaCryptoServiceProviderProxy.SignData(input, this._hashAlgorithm);
				}
				if (this._rsaCngAdapter != null)
				{
					return this._rsaCngAdapter.Pkcs1SignData(input, this._hashAlgorithm);
				}
				if (this._ecdsa != null)
				{
					return this._ecdsa.SignData(input);
				}
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
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10678: Unable to Sign, provider is not available, Algorithm, Key: '{0}', '{1}'.", new object[]
			{
				base.Algorithm,
				base.Key
			})));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002558 File Offset: 0x00000758
		public virtual void ValidateAsymmetricSecurityKeySize(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm, bool willCreateSignatures)
		{
			if (willCreateSignatures && this.MinimumAsymmetricKeySizeInBitsForSigningMap.ContainsKey(algorithm) && key.KeySize < this.MinimumAsymmetricKeySizeInBitsForSigningMap[algorithm])
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("key.KeySize", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10630: The '{0}' for signing cannot be smaller than '{1}' bits. KeySize: '{2}'.", new object[]
				{
					key,
					this.MinimumAsymmetricKeySizeInBitsForSigningMap[algorithm],
					key.KeySize
				})));
			}
			if (this.MinimumAsymmetricKeySizeInBitsForVerifyingMap.ContainsKey(algorithm) && key.KeySize < this.MinimumAsymmetricKeySizeInBitsForVerifyingMap[algorithm])
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("key.KeySize", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10631: The '{0}' for verifying cannot be smaller than '{1}' bits. KeySize: '{2}'.", new object[]
				{
					key,
					this.MinimumAsymmetricKeySizeInBitsForVerifyingMap[algorithm],
					key.KeySize
				})));
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002638 File Offset: 0x00000838
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
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ObjectDisposedException(base.GetType().ToString()));
			}
			try
			{
				if (this._rsaCryptoServiceProvider != null)
				{
					return this._rsaCryptoServiceProvider.VerifyData(input, this._hashAlgorithm, signature);
				}
				if (this._rsaCryptoServiceProviderProxy != null)
				{
					return this._rsaCryptoServiceProviderProxy.VerifyData(input, this._hashAlgorithm, signature);
				}
				if (this._rsaCngAdapter != null)
				{
					return this._rsaCngAdapter.Pkcs1VerifyData(input, signature, this._hashAlgorithm);
				}
				if (this._ecdsa != null)
				{
					return this._ecdsa.VerifyData(input, signature);
				}
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
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException("IDX10644: UnwrapKey failed. Algorithm: '{0}'."));
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002748 File Offset: 0x00000948
		protected override void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				this._disposed = true;
				if (disposing)
				{
					global::Microsoft.IdentityModel.Tokens.CryptoProviderCache cryptoProviderCache = base.CryptoProviderCache;
					if (cryptoProviderCache != null)
					{
						cryptoProviderCache.TryRemove(this);
					}
					if (this._rsaCryptoServiceProvider != null && this._shouldDisposeRsa)
					{
						this._rsaCryptoServiceProvider.Dispose();
					}
					if (this._rsaCryptoServiceProviderProxy != null)
					{
						this._rsaCryptoServiceProviderProxy.Dispose();
					}
					if (this._ecdsa != null && this._shouldDisposeEcdsa)
					{
						this._ecdsa.Dispose();
					}
				}
			}
		}

		// Token: 0x04000005 RID: 5
		private global::System.Security.Cryptography.ECDsaCng _ecdsa;

		// Token: 0x04000006 RID: 6
		private string _hashAlgorithm;

		// Token: 0x04000007 RID: 7
		private global::System.Security.Cryptography.RSACryptoServiceProvider _rsaCryptoServiceProvider;

		// Token: 0x04000008 RID: 8
		private global::Microsoft.IdentityModel.Tokens.RSACryptoServiceProviderProxy _rsaCryptoServiceProviderProxy;

		// Token: 0x04000009 RID: 9
		private global::Microsoft.IdentityModel.Tokens.RsaCngAdapter _rsaCngAdapter;

		// Token: 0x0400000A RID: 10
		private bool _shouldDisposeRsa;

		// Token: 0x0400000B RID: 11
		private bool _shouldDisposeEcdsa;

		// Token: 0x0400000C RID: 12
		private bool _disposed;

		// Token: 0x0400000D RID: 13
		private global::System.Collections.Generic.IReadOnlyDictionary<string, int> _minimumAsymmetricKeySizeInBitsForSigningMap;

		// Token: 0x0400000E RID: 14
		private global::System.Collections.Generic.IReadOnlyDictionary<string, int> _minimumAsymmetricKeySizeInBitsForVerifyingMap;

		// Token: 0x0400000F RID: 15
		public static readonly global::System.Collections.Generic.Dictionary<string, int> DefaultMinimumAsymmetricKeySizeInBitsForSigningMap = new global::System.Collections.Generic.Dictionary<string, int>
		{
			{
				"ES256",
				256
			},
			{
				"ES384",
				256
			},
			{
				"ES512",
				256
			},
			{
				"RS256",
				2048
			},
			{
				"RS384",
				2048
			},
			{
				"RS512",
				2048
			},
			{
				"http://www.w3.org/2001/04/xmldsig-more#rsa-sha256",
				2048
			},
			{
				"http://www.w3.org/2001/04/xmldsig-more#rsa-sha384",
				2048
			},
			{
				"http://www.w3.org/2001/04/xmldsig-more#rsa-sha512",
				2048
			}
		};

		// Token: 0x04000010 RID: 16
		public static readonly global::System.Collections.Generic.Dictionary<string, int> DefaultMinimumAsymmetricKeySizeInBitsForVerifyingMap = new global::System.Collections.Generic.Dictionary<string, int>
		{
			{
				"ES256",
				256
			},
			{
				"ES384",
				256
			},
			{
				"ES512",
				256
			},
			{
				"RS256",
				1024
			},
			{
				"RS384",
				1024
			},
			{
				"RS512",
				1024
			},
			{
				"http://www.w3.org/2001/04/xmldsig-more#rsa-sha256",
				1024
			},
			{
				"http://www.w3.org/2001/04/xmldsig-more#rsa-sha384",
				1024
			},
			{
				"http://www.w3.org/2001/04/xmldsig-more#rsa-sha512",
				1024
			}
		};
	}
}
