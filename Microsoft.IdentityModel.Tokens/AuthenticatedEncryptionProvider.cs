using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200000B RID: 11
	public class AuthenticatedEncryptionProvider
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00003BA0 File Offset: 0x00001DA0
		public AuthenticatedEncryptionProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			if (key == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
			}
			if (string.IsNullOrWhiteSpace(algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
			if (!this.IsSupportedAlgorithm(key, algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10668: Unable to create '{0}', algorithm '{1}'; key: '{2}' is not supported.", new object[]
				{
					base.GetType(),
					algorithm,
					key
				})));
			}
			this.ValidateKeySize(key, algorithm);
			this._authenticatedkeys = this.GetAlgorithmParameters(key, algorithm);
			this._hashAlgorithm = this.GetHashAlgorithm(algorithm);
			this._symmetricSignatureProvider = (key.CryptoProviderFactory.CreateForSigning(this._authenticatedkeys.HmacKey, this._hashAlgorithm) as global::Microsoft.IdentityModel.Tokens.SymmetricSignatureProvider);
			if (this._symmetricSignatureProvider == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10649: Failed to create a SymmetricSignatureProvider for the algorithm '{0}'.", new object[]
				{
					this.Algorithm
				})));
			}
			this.Key = key;
			this.Algorithm = algorithm;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003C8E File Offset: 0x00001E8E
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00003C96 File Offset: 0x00001E96
		public string Algorithm { get; private set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003C9F File Offset: 0x00001E9F
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00003CA7 File Offset: 0x00001EA7
		public string Context { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003CB0 File Offset: 0x00001EB0
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00003CB8 File Offset: 0x00001EB8
		public global::Microsoft.IdentityModel.Tokens.SecurityKey Key { get; private set; }

		// Token: 0x06000058 RID: 88 RVA: 0x00003CC1 File Offset: 0x00001EC1
		public virtual global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionResult Encrypt(byte[] plaintext, byte[] authenticatedData)
		{
			return this.Encrypt(plaintext, authenticatedData, null);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003CCC File Offset: 0x00001ECC
		public virtual global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionResult Encrypt(byte[] plaintext, byte[] authenticatedData, byte[] iv)
		{
			if (plaintext == null || plaintext.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("plaintext");
			}
			if (authenticatedData == null || authenticatedData.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("authenticatedData");
			}
			global::System.Security.Cryptography.Aes aes = global::System.Security.Cryptography.Aes.Create();
			aes.Mode = global::System.Security.Cryptography.CipherMode.CBC;
			aes.Padding = global::System.Security.Cryptography.PaddingMode.PKCS7;
			aes.Key = this._authenticatedkeys.AesKey.Key;
			if (iv != null)
			{
				aes.IV = iv;
			}
			byte[] array;
			try
			{
				array = global::Microsoft.IdentityModel.Tokens.Utility.Transform(aes.CreateEncryptor(), plaintext, 0, plaintext.Length);
			}
			catch (global::System.Exception ex)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10654: Decryption failed. Cryptographic operation exception: '{0}'.", new object[]
				{
					ex
				})));
			}
			byte[] array2 = global::Microsoft.IdentityModel.Tokens.Utility.ConvertToBigEndian((long)(authenticatedData.Length * 8));
			byte[] array3 = new byte[authenticatedData.Length + aes.IV.Length + array.Length + array2.Length];
			global::System.Array.Copy(authenticatedData, 0, array3, 0, authenticatedData.Length);
			global::System.Array.Copy(aes.IV, 0, array3, authenticatedData.Length, aes.IV.Length);
			global::System.Array.Copy(array, 0, array3, authenticatedData.Length + aes.IV.Length, array.Length);
			global::System.Array.Copy(array2, 0, array3, authenticatedData.Length + aes.IV.Length + array.Length, array2.Length);
			global::System.Array sourceArray = this._symmetricSignatureProvider.Sign(array3);
			byte[] array4 = new byte[this._authenticatedkeys.HmacKey.Key.Length];
			global::System.Array.Copy(sourceArray, array4, array4.Length);
			return new global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionResult(this.Key, array, aes.IV, array4);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003E38 File Offset: 0x00002038
		public virtual byte[] Decrypt(byte[] ciphertext, byte[] authenticatedData, byte[] iv, byte[] authenticationTag)
		{
			if (ciphertext == null || ciphertext.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("ciphertext");
			}
			if (authenticatedData == null || authenticatedData.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("authenticatedData");
			}
			if (iv == null || iv.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("iv");
			}
			if (authenticationTag == null || authenticationTag.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("authenticationTag");
			}
			byte[] array = global::Microsoft.IdentityModel.Tokens.Utility.ConvertToBigEndian((long)(authenticatedData.Length * 8));
			byte[] array2 = new byte[authenticatedData.Length + iv.Length + ciphertext.Length + array.Length];
			global::System.Array.Copy(authenticatedData, 0, array2, 0, authenticatedData.Length);
			global::System.Array.Copy(iv, 0, array2, authenticatedData.Length, iv.Length);
			global::System.Array.Copy(ciphertext, 0, array2, authenticatedData.Length + iv.Length, ciphertext.Length);
			global::System.Array.Copy(array, 0, array2, authenticatedData.Length + iv.Length + ciphertext.Length, array.Length);
			if (!this._symmetricSignatureProvider.Verify(array2, authenticationTag, this._authenticatedkeys.HmacKey.Key.Length))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenDecryptionFailedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10650: Failed to verify ciphertext with aad '{0}'; iv '{1}'; and authenticationTag '{2}'.", new object[]
				{
					global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedData),
					global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(iv),
					global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticationTag)
				})));
			}
			global::System.Security.Cryptography.Aes aes = global::System.Security.Cryptography.Aes.Create();
			aes.Mode = global::System.Security.Cryptography.CipherMode.CBC;
			aes.Padding = global::System.Security.Cryptography.PaddingMode.PKCS7;
			aes.Key = this._authenticatedkeys.AesKey.Key;
			aes.IV = iv;
			byte[] result;
			try
			{
				result = global::Microsoft.IdentityModel.Tokens.Utility.Transform(aes.CreateDecryptor(), ciphertext, 0, ciphertext.Length);
			}
			catch (global::System.Exception ex)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenDecryptionFailedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10654: Decryption failed. Cryptographic operation exception: '{0}'.", new object[]
				{
					ex
				})));
			}
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003FC4 File Offset: 0x000021C4
		protected virtual bool IsSupportedAlgorithm(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey;
			return key != null && !string.IsNullOrEmpty(algorithm) && (algorithm.Equals("A128CBC-HS256", global::System.StringComparison.Ordinal) || algorithm.Equals("A192CBC-HS384", global::System.StringComparison.Ordinal) || algorithm.Equals("A256CBC-HS512", global::System.StringComparison.Ordinal)) && (key is global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey || ((jsonWebKey = (key as global::Microsoft.IdentityModel.Tokens.JsonWebKey)) != null && jsonWebKey.K != null && jsonWebKey.Kty == "oct"));
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000403C File Offset: 0x0000223C
		private global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider.AuthenticatedKeys GetAlgorithmParameters(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			int num;
			if (algorithm.Equals("A256CBC-HS512", global::System.StringComparison.Ordinal))
			{
				num = 32;
			}
			else if (algorithm.Equals("A192CBC-HS384", global::System.StringComparison.Ordinal))
			{
				num = 24;
			}
			else
			{
				if (!algorithm.Equals("A128CBC-HS256", global::System.StringComparison.Ordinal))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10668: Unable to create '{0}', algorithm '{1}'; key: '{2}' is not supported.", new object[]
					{
						base.GetType(),
						algorithm,
						key
					})));
				}
				num = 16;
			}
			byte[] keyBytes = this.GetKeyBytes(key);
			byte[] array = new byte[num];
			byte[] array2 = new byte[num];
			global::System.Array.Copy(keyBytes, num, array, 0, num);
			global::System.Array.Copy(keyBytes, array2, num);
			return new global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider.AuthenticatedKeys
			{
				AesKey = new global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(array),
				HmacKey = new global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(array2)
			};
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000040FC File Offset: 0x000022FC
		private string GetHashAlgorithm(string algorithm)
		{
			if ("A128CBC-HS256".Equals(algorithm, global::System.StringComparison.Ordinal))
			{
				return "HS256";
			}
			if ("A192CBC-HS384".Equals(algorithm, global::System.StringComparison.Ordinal))
			{
				return "HS384";
			}
			if ("A256CBC-HS512".Equals(algorithm, global::System.StringComparison.Ordinal))
			{
				return "HS512";
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10652: The algorithm '{0}' is not supported.", new object[]
			{
				algorithm
			}), "algorithm"));
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004168 File Offset: 0x00002368
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

		// Token: 0x0600005F RID: 95 RVA: 0x000041E4 File Offset: 0x000023E4
		protected virtual void ValidateKeySize(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			if (key == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
			}
			if (string.IsNullOrEmpty(algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
			if ("A128CBC-HS256".Equals(algorithm, global::System.StringComparison.Ordinal))
			{
				if (key.KeySize < 256)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("key.KeySize", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10653: The encryption algorithm '{0}' requires a key size of at least '{1}' bits. Key '{2}', is of size: '{3}'.", new object[]
					{
						"A128CBC-HS256",
						256,
						key.KeyId,
						key.KeySize
					})));
				}
				return;
			}
			else if ("A192CBC-HS384".Equals(algorithm, global::System.StringComparison.Ordinal))
			{
				if (key.KeySize < 384)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("key.KeySize", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10653: The encryption algorithm '{0}' requires a key size of at least '{1}' bits. Key '{2}', is of size: '{3}'.", new object[]
					{
						"A192CBC-HS384",
						384,
						key.KeyId,
						key.KeySize
					})));
				}
				return;
			}
			else
			{
				if (!"A256CBC-HS512".Equals(algorithm, global::System.StringComparison.Ordinal))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10652: The algorithm '{0}' is not supported.", new object[]
					{
						algorithm
					})));
				}
				if (key.KeySize < 512)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("key.KeySize", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10653: The encryption algorithm '{0}' requires a key size of at least '{1}' bits. Key '{2}', is of size: '{3}'.", new object[]
					{
						"A256CBC-HS512",
						512,
						key.KeyId,
						key.KeySize
					})));
				}
				return;
			}
		}

		// Token: 0x04000023 RID: 35
		private global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider.AuthenticatedKeys _authenticatedkeys;

		// Token: 0x04000024 RID: 36
		private string _hashAlgorithm;

		// Token: 0x04000025 RID: 37
		private global::Microsoft.IdentityModel.Tokens.SymmetricSignatureProvider _symmetricSignatureProvider;

		// Token: 0x0200004E RID: 78
		private struct AuthenticatedKeys
		{
			// Token: 0x040001A6 RID: 422
			public global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey AesKey;

			// Token: 0x040001A7 RID: 423
			public global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey HmacKey;
		}
	}
}
