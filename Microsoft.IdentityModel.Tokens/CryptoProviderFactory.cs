using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000007 RID: 7
	public class CryptoProviderFactory
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002ACE File Offset: 0x00000CCE
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002AD5 File Offset: 0x00000CD5
		public static global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory Default
		{
			get
			{
				return global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory._default;
			}
			set
			{
				if (value == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("value");
				}
				global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory._default = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002AEC File Offset: 0x00000CEC
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002AF3 File Offset: 0x00000CF3
		[global::System.ComponentModel.DefaultValue(false)]
		public static bool DefaultCacheSignatureProviders { get; set; } = false;

		// Token: 0x06000020 RID: 32 RVA: 0x00002AFB File Offset: 0x00000CFB
		static CryptoProviderFactory()
		{
			global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory.Default = new global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002B17 File Offset: 0x00000D17
		public CryptoProviderFactory()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002B35 File Offset: 0x00000D35
		public CryptoProviderFactory(global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory other)
		{
			if (other == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("other");
			}
			this.CustomCryptoProvider = other.CustomCryptoProvider;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002B6D File Offset: 0x00000D6D
		public global::Microsoft.IdentityModel.Tokens.CryptoProviderCache CryptoProviderCache { get; } = new global::Microsoft.IdentityModel.Tokens.InMemoryCryptoProviderCache();

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002B75 File Offset: 0x00000D75
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002B7D File Offset: 0x00000D7D
		public global::Microsoft.IdentityModel.Tokens.ICryptoProvider CustomCryptoProvider { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002B86 File Offset: 0x00000D86
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002B8E File Offset: 0x00000D8E
		[global::System.ComponentModel.DefaultValue(false)]
		public bool CacheSignatureProviders { get; set; } = global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory.DefaultCacheSignatureProviders;

		// Token: 0x06000028 RID: 40 RVA: 0x00002B98 File Offset: 0x00000D98
		public virtual global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider CreateAuthenticatedEncryptionProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			if (key == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
			}
			if (string.IsNullOrEmpty(algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
			if (this.CustomCryptoProvider != null && this.CustomCryptoProvider.IsSupportedAlgorithm(algorithm, new object[]
			{
				key
			}))
			{
				global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider authenticatedEncryptionProvider = this.CustomCryptoProvider.Create(algorithm, new object[]
				{
					key
				}) as global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider;
				if (authenticatedEncryptionProvider == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10646: A CustomCryptoProvider was set and returned 'true' for IsSupportedAlgorithm(Algorithm: '{0}', Key: '{1}'), but Create.(algorithm, args) as '{2}' == NULL.", new object[]
					{
						algorithm,
						key,
						typeof(global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider)
					})));
				}
				return authenticatedEncryptionProvider;
			}
			else
			{
				if (this.IsSupportedAuthenticatedEncryptionAlgorithm(algorithm, key))
				{
					return new global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider(key, algorithm);
				}
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10652: The algorithm '{0}' is not supported.", new object[]
				{
					algorithm
				}), "algorithm"));
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002C6C File Offset: 0x00000E6C
		public virtual global::Microsoft.IdentityModel.Tokens.KeyWrapProvider CreateKeyWrapProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			return this.CreateKeyWrapProvider(key, algorithm, false);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002C78 File Offset: 0x00000E78
		private global::Microsoft.IdentityModel.Tokens.KeyWrapProvider CreateKeyWrapProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm, bool willUnwrap)
		{
			if (key == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
			}
			if (string.IsNullOrEmpty(algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
			if (this.CustomCryptoProvider != null && this.CustomCryptoProvider.IsSupportedAlgorithm(algorithm, new object[]
			{
				key,
				willUnwrap
			}))
			{
				global::Microsoft.IdentityModel.Tokens.KeyWrapProvider result;
				if ((result = (this.CustomCryptoProvider.Create(algorithm, new object[]
				{
					key,
					willUnwrap
				}) as global::Microsoft.IdentityModel.Tokens.KeyWrapProvider)) == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10646: A CustomCryptoProvider was set and returned 'true' for IsSupportedAlgorithm(Algorithm: '{0}', Key: '{1}'), but Create.(algorithm, args) as '{2}' == NULL.", new object[]
					{
						algorithm,
						key,
						typeof(global::Microsoft.IdentityModel.Tokens.SignatureProvider)
					})));
				}
				return result;
			}
			else
			{
				if (key is global::Microsoft.IdentityModel.Tokens.RsaSecurityKey && this.IsSupportedRsaAlgorithm(algorithm))
				{
					return new global::Microsoft.IdentityModel.Tokens.RsaKeyWrapProvider(key, algorithm, willUnwrap);
				}
				global::Microsoft.IdentityModel.Tokens.X509SecurityKey key2;
				if ((key2 = (key as global::Microsoft.IdentityModel.Tokens.X509SecurityKey)) != null && this.IsSupportedRsaAlgorithm(algorithm))
				{
					return new global::Microsoft.IdentityModel.Tokens.RsaKeyWrapProvider(key2, algorithm, willUnwrap);
				}
				global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey;
				if ((jsonWebKey = (key as global::Microsoft.IdentityModel.Tokens.JsonWebKey)) != null)
				{
					if (jsonWebKey.Kty == "RSA" && this.IsSupportedRsaAlgorithm(algorithm))
					{
						return new global::Microsoft.IdentityModel.Tokens.RsaKeyWrapProvider(jsonWebKey, algorithm, willUnwrap);
					}
					if (jsonWebKey.Kty == "oct" && this.IsSupportedSymmetricAlgorithm(algorithm))
					{
						return new global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider(jsonWebKey, algorithm);
					}
				}
				global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey key3;
				if ((key3 = (key as global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey)) != null && this.IsSupportedSymmetricAlgorithm(algorithm))
				{
					return new global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider(key3, algorithm);
				}
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10661: Unable to create the KeyWrapProvider.\nKeyWrapAlgorithm: '{0}', SecurityKey: '{1}'\n is not supported.", new object[]
				{
					algorithm,
					key
				})));
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002DED File Offset: 0x00000FED
		public virtual global::Microsoft.IdentityModel.Tokens.KeyWrapProvider CreateKeyWrapProviderForUnwrap(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			return this.CreateKeyWrapProvider(key, algorithm, true);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002DF8 File Offset: 0x00000FF8
		public virtual global::Microsoft.IdentityModel.Tokens.SignatureProvider CreateForSigning(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			return this.CreateSignatureProvider(key, algorithm, true);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002E03 File Offset: 0x00001003
		public virtual global::Microsoft.IdentityModel.Tokens.SignatureProvider CreateForVerifying(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			return this.CreateSignatureProvider(key, algorithm, false);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002E10 File Offset: 0x00001010
		public virtual global::System.Security.Cryptography.HashAlgorithm CreateHashAlgorithm(string algorithm)
		{
			if (string.IsNullOrEmpty(algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
			if (this.CustomCryptoProvider != null && this.CustomCryptoProvider.IsSupportedAlgorithm(algorithm, new object[0]))
			{
				global::System.Security.Cryptography.HashAlgorithm hashAlgorithm = this.CustomCryptoProvider.Create(algorithm, new object[0]) as global::System.Security.Cryptography.HashAlgorithm;
				if (hashAlgorithm == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10647: A CustomCryptoProvider was set and returned 'true' for IsSupportedAlgorithm(Algorithm: '{0}'), but Create.(algorithm, args) as '{1}' == NULL.", new object[]
					{
						algorithm,
						typeof(global::System.Security.Cryptography.HashAlgorithm)
					})));
				}
				global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory._typeToAlgorithmMap[hashAlgorithm.GetType().ToString()] = algorithm;
				return hashAlgorithm;
			}
			else
			{
				if (algorithm == "SHA256" || algorithm == "http://www.w3.org/2001/04/xmlenc#sha256")
				{
					return global::System.Security.Cryptography.SHA256.Create();
				}
				if (algorithm == "SHA384" || algorithm == "http://www.w3.org/2001/04/xmldsig-more#sha384")
				{
					return global::System.Security.Cryptography.SHA384.Create();
				}
				if (!(algorithm == "SHA512") && !(algorithm == "http://www.w3.org/2001/04/xmlenc#sha512"))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10640: Algorithm is not supported: '{0}'.", new object[]
					{
						algorithm
					})));
				}
				return global::System.Security.Cryptography.SHA512.Create();
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002F2C File Offset: 0x0000112C
		public virtual global::System.Security.Cryptography.KeyedHashAlgorithm CreateKeyedHashAlgorithm(byte[] keyBytes, string algorithm)
		{
			if (keyBytes == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("keyBytes");
			}
			if (string.IsNullOrEmpty(algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
			if (this.CustomCryptoProvider != null && this.CustomCryptoProvider.IsSupportedAlgorithm(algorithm, new object[]
			{
				keyBytes
			}))
			{
				global::System.Security.Cryptography.KeyedHashAlgorithm keyedHashAlgorithm = this.CustomCryptoProvider.Create(algorithm, new object[]
				{
					keyBytes
				}) as global::System.Security.Cryptography.KeyedHashAlgorithm;
				if (keyedHashAlgorithm == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10647: A CustomCryptoProvider was set and returned 'true' for IsSupportedAlgorithm(Algorithm: '{0}'), but Create.(algorithm, args) as '{1}' == NULL.", new object[]
					{
						algorithm,
						typeof(global::System.Security.Cryptography.KeyedHashAlgorithm)
					})));
				}
				return keyedHashAlgorithm;
			}
			else
			{
				if (algorithm == "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256" || algorithm == "HS256")
				{
					return new global::System.Security.Cryptography.HMACSHA256(keyBytes);
				}
				if (algorithm == "http://www.w3.org/2001/04/xmldsig-more#hmac-sha384" || algorithm == "HS384")
				{
					return new global::System.Security.Cryptography.HMACSHA384(keyBytes);
				}
				if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#hmac-sha512") && !(algorithm == "HS512"))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10666: Unable to create KeyedHashAlgorithm for algorithm '{0}'.", new object[]
					{
						algorithm
					})));
				}
				return new global::System.Security.Cryptography.HMACSHA512(keyBytes);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000304C File Offset: 0x0000124C
		private global::Microsoft.IdentityModel.Tokens.SignatureProvider CreateSignatureProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm, bool willCreateSignatures)
		{
			if (key == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
			}
			if (string.IsNullOrEmpty(algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
			global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider = null;
			if (this.CustomCryptoProvider != null && this.CustomCryptoProvider.IsSupportedAlgorithm(algorithm, new object[]
			{
				key,
				willCreateSignatures
			}))
			{
				signatureProvider = (this.CustomCryptoProvider.Create(algorithm, new object[]
				{
					key,
					willCreateSignatures
				}) as global::Microsoft.IdentityModel.Tokens.SignatureProvider);
				if (signatureProvider == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10646: A CustomCryptoProvider was set and returned 'true' for IsSupportedAlgorithm(Algorithm: '{0}', Key: '{1}'), but Create.(algorithm, args) as '{2}' == NULL.", new object[]
					{
						algorithm,
						key,
						typeof(global::Microsoft.IdentityModel.Tokens.SignatureProvider)
					})));
				}
				return signatureProvider;
			}
			else
			{
				string text = null;
				bool flag = true;
				global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey;
				if (key is global::Microsoft.IdentityModel.Tokens.AsymmetricSecurityKey)
				{
					text = typeof(global::Microsoft.IdentityModel.Tokens.AsymmetricSignatureProvider).ToString();
				}
				else if ((jsonWebKey = (key as global::Microsoft.IdentityModel.Tokens.JsonWebKey)) != null)
				{
					if (jsonWebKey.Kty != null)
					{
						if (jsonWebKey.Kty == "RSA" || jsonWebKey.Kty == "EC")
						{
							text = typeof(global::Microsoft.IdentityModel.Tokens.AsymmetricSignatureProvider).ToString();
						}
						if (jsonWebKey.Kty == "oct")
						{
							text = typeof(global::Microsoft.IdentityModel.Tokens.SymmetricSignatureProvider).ToString();
							flag = false;
						}
					}
				}
				else if (key is global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey)
				{
					text = typeof(global::Microsoft.IdentityModel.Tokens.SymmetricSignatureProvider).ToString();
					flag = false;
				}
				if (text == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10621: '{0}' supports: '{1}' of types: '{2}' or '{3}'. SecurityKey received was of type '{4}'.", new object[]
					{
						typeof(global::Microsoft.IdentityModel.Tokens.SymmetricSignatureProvider),
						typeof(global::Microsoft.IdentityModel.Tokens.SecurityKey),
						typeof(global::Microsoft.IdentityModel.Tokens.AsymmetricSecurityKey),
						typeof(global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey),
						key.GetType()
					})));
				}
				if (this.CacheSignatureProviders && this.CryptoProviderCache.TryGetSignatureProvider(key, algorithm, text, willCreateSignatures, out signatureProvider))
				{
					return signatureProvider;
				}
				if (!this.IsSupportedAlgorithm(algorithm, key))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10634: Unable to create the SignatureProvider.\nAlgorithm: '{0}', SecurityKey: '{1}'\n is not supported.", new object[]
					{
						algorithm,
						key
					})));
				}
				if (flag)
				{
					signatureProvider = new global::Microsoft.IdentityModel.Tokens.AsymmetricSignatureProvider(key, algorithm, willCreateSignatures);
				}
				else
				{
					signatureProvider = new global::Microsoft.IdentityModel.Tokens.SymmetricSignatureProvider(key, algorithm, willCreateSignatures);
				}
				if (this.CacheSignatureProviders)
				{
					this.CryptoProviderCache.TryAdd(signatureProvider);
				}
				return signatureProvider;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003278 File Offset: 0x00001478
		public virtual bool IsSupportedAlgorithm(string algorithm)
		{
			return (this.CustomCryptoProvider != null && this.CustomCryptoProvider.IsSupportedAlgorithm(algorithm, new object[0])) || this.IsSupportedHashAlgorithm(algorithm);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000032A0 File Offset: 0x000014A0
		public virtual bool IsSupportedAlgorithm(string algorithm, global::Microsoft.IdentityModel.Tokens.SecurityKey key)
		{
			if (this.CustomCryptoProvider != null && this.CustomCryptoProvider.IsSupportedAlgorithm(algorithm, new object[]
			{
				key
			}))
			{
				return true;
			}
			if (key is global::Microsoft.IdentityModel.Tokens.RsaSecurityKey)
			{
				return this.IsSupportedRsaAlgorithm(algorithm);
			}
			global::Microsoft.IdentityModel.Tokens.X509SecurityKey x509SecurityKey;
			if ((x509SecurityKey = (key as global::Microsoft.IdentityModel.Tokens.X509SecurityKey)) != null)
			{
				return x509SecurityKey.PublicKey is global::System.Security.Cryptography.RSACryptoServiceProvider && this.IsSupportedRsaAlgorithm(algorithm);
			}
			global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey;
			if ((jsonWebKey = (key as global::Microsoft.IdentityModel.Tokens.JsonWebKey)) != null)
			{
				if (jsonWebKey.Kty == "RSA")
				{
					return this.IsSupportedRsaAlgorithm(algorithm);
				}
				if (jsonWebKey.Kty == "EC")
				{
					return this.IsSupportedEcdsaAlgorithm(algorithm);
				}
				return jsonWebKey.Kty == "oct" && this.IsSupportedSymmetricAlgorithm(algorithm);
			}
			else
			{
				if (key is global::Microsoft.IdentityModel.Tokens.ECDsaSecurityKey)
				{
					return this.IsSupportedEcdsaAlgorithm(algorithm);
				}
				return key is global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey && this.IsSupportedSymmetricAlgorithm(algorithm);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000337C File Offset: 0x0000157C
		private bool IsSupportedAuthenticatedEncryptionAlgorithm(string algorithm, global::Microsoft.IdentityModel.Tokens.SecurityKey key)
		{
			global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey;
			return key != null && !string.IsNullOrEmpty(algorithm) && (algorithm.Equals("A128CBC-HS256", global::System.StringComparison.Ordinal) || algorithm.Equals("A192CBC-HS384", global::System.StringComparison.Ordinal) || algorithm.Equals("A256CBC-HS512", global::System.StringComparison.Ordinal)) && (key is global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey || ((jsonWebKey = (key as global::Microsoft.IdentityModel.Tokens.JsonWebKey)) != null && jsonWebKey.K != null && jsonWebKey.Kty == "oct"));
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000033F4 File Offset: 0x000015F4
		private bool IsSupportedEcdsaAlgorithm(string algorithm)
		{
			return algorithm == "ES256" || algorithm == "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha256" || algorithm == "ES384" || algorithm == "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha384" || algorithm == "ES512" || algorithm == "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha512";
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003454 File Offset: 0x00001654
		private bool IsSupportedHashAlgorithm(string algorithm)
		{
			return algorithm == "SHA256" || algorithm == "http://www.w3.org/2001/04/xmlenc#sha256" || algorithm == "SHA384" || algorithm == "http://www.w3.org/2001/04/xmldsig-more#sha384" || algorithm == "SHA512" || algorithm == "http://www.w3.org/2001/04/xmlenc#sha512";
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000034B4 File Offset: 0x000016B4
		private bool IsSupportedKeyWrapAlgorithm(string algorithm, global::Microsoft.IdentityModel.Tokens.SecurityKey key)
		{
			global::Microsoft.IdentityModel.Tokens.X509SecurityKey x509SecurityKey;
			global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey;
			return key != null && !string.IsNullOrEmpty(algorithm) && (algorithm.Equals("RSA1_5", global::System.StringComparison.Ordinal) || algorithm.Equals("RSA-OAEP", global::System.StringComparison.Ordinal) || algorithm.Equals("http://www.w3.org/2001/04/xmlenc#rsa-oaep", global::System.StringComparison.Ordinal)) && (key is global::Microsoft.IdentityModel.Tokens.RsaSecurityKey || (((x509SecurityKey = (key as global::Microsoft.IdentityModel.Tokens.X509SecurityKey)) == null || x509SecurityKey.PublicKey is global::System.Security.Cryptography.RSACryptoServiceProvider) && ((jsonWebKey = (key as global::Microsoft.IdentityModel.Tokens.JsonWebKey)) != null && jsonWebKey.Kty == "RSA")));
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003540 File Offset: 0x00001740
		private bool IsSupportedRsaAlgorithm(string algorithm)
		{
			uint num = global::<PrivateImplementationDetails>.ComputeStringHash(algorithm);
			if (num <= 1835397900U)
			{
				if (num <= 1073032197U)
				{
					if (num != 758925578U)
					{
						if (num != 1073032197U)
						{
							return false;
						}
						if (!(algorithm == "RSA-OAEP"))
						{
							return false;
						}
					}
					else if (!(algorithm == "RS512"))
					{
						return false;
					}
				}
				else if (num != 1618611968U)
				{
					if (num != 1835397900U)
					{
						return false;
					}
					if (!(algorithm == "http://www.w3.org/2001/04/xmlenc#rsa-oaep"))
					{
						return false;
					}
				}
				else if (!(algorithm == "RSA1_5"))
				{
					return false;
				}
			}
			else if (num <= 2824063256U)
			{
				if (num != 2342223295U)
				{
					if (num != 2824063256U)
					{
						return false;
					}
					if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#rsa-sha512"))
					{
						return false;
					}
				}
				else if (!(algorithm == "RS384"))
				{
					return false;
				}
			}
			else if (num != 2969357051U)
			{
				if (num != 3339968437U)
				{
					if (num != 3880483293U)
					{
						return false;
					}
					if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256"))
					{
						return false;
					}
				}
				else if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#rsa-sha384"))
				{
					return false;
				}
			}
			else if (!(algorithm == "RS256"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000365C File Offset: 0x0000185C
		private bool IsSupportedSymmetricAlgorithm(string algorithm)
		{
			uint num = global::<PrivateImplementationDetails>.ComputeStringHash(algorithm);
			if (num <= 911044869U)
			{
				if (num <= 572088812U)
				{
					if (num != 550229268U)
					{
						if (num != 572088812U)
						{
							return false;
						}
						if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#hmac-sha384"))
						{
							return false;
						}
					}
					else if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256"))
					{
						return false;
					}
				}
				else if (num != 626597179U)
				{
					if (num != 774710634U)
					{
						if (num != 911044869U)
						{
							return false;
						}
						if (!(algorithm == "A192CBC-HS384"))
						{
							return false;
						}
					}
					else if (!(algorithm == "A128CBC-HS256"))
					{
						return false;
					}
				}
				else if (!(algorithm == "A256KW"))
				{
					return false;
				}
			}
			else if (num <= 2930374873U)
			{
				if (num != 1009163908U)
				{
					if (num != 1238143233U)
					{
						if (num != 2930374873U)
						{
							return false;
						}
						if (!(algorithm == "http://www.w3.org/2001/04/xmldsig-more#hmac-sha512"))
						{
							return false;
						}
					}
					else if (!(algorithm == "HS384"))
					{
						return false;
					}
				}
				else if (!(algorithm == "HS512"))
				{
					return false;
				}
			}
			else if (num != 3659031345U)
			{
				if (num != 3666050767U)
				{
					if (num != 4289675895U)
					{
						return false;
					}
					if (!(algorithm == "A128KW"))
					{
						return false;
					}
				}
				else if (!(algorithm == "A256CBC-HS512"))
				{
					return false;
				}
			}
			else if (!(algorithm == "HS256"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000037BC File Offset: 0x000019BC
		public virtual void ReleaseHashAlgorithm(global::System.Security.Cryptography.HashAlgorithm hashAlgorithm)
		{
			if (hashAlgorithm == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("hashAlgorithm");
			}
			string algorithm;
			if (this.CustomCryptoProvider != null && global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory._typeToAlgorithmMap.TryGetValue(hashAlgorithm.GetType().ToString(), out algorithm) && this.CustomCryptoProvider.IsSupportedAlgorithm(algorithm, new object[0]))
			{
				this.CustomCryptoProvider.Release(hashAlgorithm);
				return;
			}
			hashAlgorithm.Dispose();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003820 File Offset: 0x00001A20
		public virtual void ReleaseKeyWrapProvider(global::Microsoft.IdentityModel.Tokens.KeyWrapProvider provider)
		{
			if (provider == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("provider");
			}
			if (this.CustomCryptoProvider != null && this.CustomCryptoProvider.IsSupportedAlgorithm(provider.Algorithm, new object[0]))
			{
				this.CustomCryptoProvider.Release(provider);
				return;
			}
			provider.Dispose();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003870 File Offset: 0x00001A70
		public virtual void ReleaseRsaKeyWrapProvider(global::Microsoft.IdentityModel.Tokens.RsaKeyWrapProvider provider)
		{
			if (provider == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("provider");
			}
			if (this.CustomCryptoProvider != null && this.CustomCryptoProvider.IsSupportedAlgorithm(provider.Algorithm, new object[0]))
			{
				this.CustomCryptoProvider.Release(provider);
				return;
			}
			provider.Dispose();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000038C0 File Offset: 0x00001AC0
		public virtual void ReleaseSignatureProvider(global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider)
		{
			if (signatureProvider == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("signatureProvider");
			}
			if (this.CustomCryptoProvider != null && this.CustomCryptoProvider.IsSupportedAlgorithm(signatureProvider.Algorithm, new object[0]))
			{
				this.CustomCryptoProvider.Release(signatureProvider);
				return;
			}
			if (signatureProvider.CryptoProviderCache == null)
			{
				signatureProvider.Dispose();
			}
		}

		// Token: 0x04000017 RID: 23
		private static global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory _default;

		// Token: 0x04000018 RID: 24
		private static global::System.Collections.Concurrent.ConcurrentDictionary<string, string> _typeToAlgorithmMap = new global::System.Collections.Concurrent.ConcurrentDictionary<string, string>();
	}
}
