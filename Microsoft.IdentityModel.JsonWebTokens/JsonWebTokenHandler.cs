using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.IdentityModel.JsonWebTokens
{
	// Token: 0x02000004 RID: 4
	public class JsonWebTokenHandler
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002894 File Offset: 0x00000A94
		// (set) Token: 0x06000022 RID: 34 RVA: 0x0000289C File Offset: 0x00000A9C
		internal virtual int MaximumTokenSizeInBytes
		{
			get
			{
				return this._maximumTokenSizeInBytes;
			}
			set
			{
				if (value < 1)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("value", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10101: MaximumTokenSizeInBytes must be greater than zero. value: '{0}'", new object[]
					{
						value
					})));
				}
				this._maximumTokenSizeInBytes = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000028D2 File Offset: 0x00000AD2
		public global::System.Type TokenType
		{
			get
			{
				return typeof(global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000028E0 File Offset: 0x00000AE0
		public bool CanReadToken(string token)
		{
			if (string.IsNullOrWhiteSpace(token))
			{
				return false;
			}
			if (token.Length > this.MaximumTokenSizeInBytes)
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10209: token has length: '{0}' which is larger than the MaximumTokenSizeInBytes: '{1}'.", new object[]
				{
					token.Length,
					this.MaximumTokenSizeInBytes
				});
				return false;
			}
			if (token.Split(new char[]
			{
				'.'
			}, 6).Length == 3)
			{
				return global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.RegexJws.IsMatch(token);
			}
			global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX14107: Token string does not match the token formats: JWE (header.encryptedKey.iv.ciphertext.tag) or JWS (header.payload.signature)", new object[0]);
			return false;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002967 File Offset: 0x00000B67
		public bool CanValidateToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000296A File Offset: 0x00000B6A
		public string CreateToken(global::Newtonsoft.Json.Linq.JObject payload, global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials)
		{
			return this.CreateJsonWebToken(payload, signingCredentials, null);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002978 File Offset: 0x00000B78
		private string CreateJsonWebToken(global::Newtonsoft.Json.Linq.JObject payload, global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials, global::Microsoft.IdentityModel.Tokens.EncryptingCredentials encryptingCredentials)
		{
			if (payload == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("payload");
			}
			string text;
			if (!global::Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenManager.KeyToHeaderCache.TryGetValue(global::Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenManager.GetHeaderCacheKey(signingCredentials), out text))
			{
				global::Newtonsoft.Json.Linq.JObject jobject2;
				if (signingCredentials != null)
				{
					global::Newtonsoft.Json.Linq.JObject jobject = new global::Newtonsoft.Json.Linq.JObject();
					jobject.Add("alg", signingCredentials.Algorithm);
					jobject.Add("kid", signingCredentials.Key.KeyId);
					jobject2 = jobject;
					jobject.Add("typ", "JWT");
				}
				else
				{
					jobject2 = new global::Newtonsoft.Json.Linq.JObject();
				}
				global::Newtonsoft.Json.Linq.JObject jobject3 = jobject2;
				text = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(global::System.Text.Encoding.UTF8.GetBytes(jobject3.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0])));
				global::Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenManager.KeyToHeaderCache.TryAdd(global::Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenManager.GetHeaderCacheKey(signingCredentials), text);
			}
			string text2 = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(global::System.Text.Encoding.UTF8.GetBytes(payload.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0])));
			string text3 = (signingCredentials == null) ? string.Empty : global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.CreateEncodedSignature(text + "." + text2, signingCredentials);
			string text4 = string.Concat(new string[]
			{
				text,
				".",
				text2,
				".",
				text3
			});
			if (encryptingCredentials != null)
			{
				return this.EncryptToken(text4, encryptingCredentials);
			}
			return text4;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002AA0 File Offset: 0x00000CA0
		private string CreateJsonWebToken(global::Newtonsoft.Json.Linq.JObject payload, global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials, global::Microsoft.IdentityModel.Tokens.EncryptingCredentials encryptingCredentials, string rawHeader)
		{
			if (payload == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("payload");
			}
			if (rawHeader == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("rawHeader");
			}
			string text = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(global::System.Text.Encoding.UTF8.GetBytes(payload.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0])));
			string text2 = (signingCredentials == null) ? string.Empty : global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.CreateEncodedSignature(rawHeader + "." + text, signingCredentials);
			string text3 = string.Concat(new string[]
			{
				rawHeader,
				".",
				text,
				".",
				text2
			});
			if (encryptingCredentials != null)
			{
				return this.EncryptToken(text3, encryptingCredentials);
			}
			return text3;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002B3C File Offset: 0x00000D3C
		private string EncryptToken(string innerJwt, global::Microsoft.IdentityModel.Tokens.EncryptingCredentials encryptingCredentials)
		{
			global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory cryptoProviderFactory = encryptingCredentials.CryptoProviderFactory ?? encryptingCredentials.Key.CryptoProviderFactory;
			if (cryptoProviderFactory == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException("IDX14104: Unable to obtain a CryptoProviderFactory, both EncryptingCredentials.CryptoProviderFactory and EncryptingCredentials.Key.CrypoProviderFactory are both null."));
			}
			if ("dir".Equals(encryptingCredentials.Alg, global::System.StringComparison.Ordinal))
			{
				if (!cryptoProviderFactory.IsSupportedAlgorithm(encryptingCredentials.Enc, encryptingCredentials.Key))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10615: Encryption failed. No support for: Algorithm: '{0}', SecurityKey: '{1}'.", new object[]
					{
						encryptingCredentials.Enc,
						encryptingCredentials.Key
					})));
				}
				global::Newtonsoft.Json.Linq.JObject jobject = new global::Newtonsoft.Json.Linq.JObject();
				if (!string.IsNullOrEmpty(encryptingCredentials.Alg))
				{
					jobject.Add("alg", encryptingCredentials.Alg);
				}
				if (!string.IsNullOrEmpty(encryptingCredentials.Enc))
				{
					jobject.Add("enc", encryptingCredentials.Enc);
				}
				if (!string.IsNullOrEmpty(encryptingCredentials.Key.KeyId))
				{
					jobject.Add("kid", encryptingCredentials.Key.KeyId);
				}
				jobject.Add("typ", "JWT");
				global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider authenticatedEncryptionProvider = cryptoProviderFactory.CreateAuthenticatedEncryptionProvider(encryptingCredentials.Key, encryptingCredentials.Enc);
				if (authenticatedEncryptionProvider == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException("IDX14103: Failed to create the token encryption provider."));
				}
				try
				{
					string text = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(global::System.Text.Encoding.UTF8.GetBytes(jobject.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0])));
					global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionResult authenticatedEncryptionResult = authenticatedEncryptionProvider.Encrypt(global::System.Text.Encoding.UTF8.GetBytes(innerJwt), global::System.Text.Encoding.ASCII.GetBytes(text));
					return string.Join(".", new string[]
					{
						text,
						string.Empty,
						global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedEncryptionResult.IV),
						global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedEncryptionResult.Ciphertext),
						global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedEncryptionResult.AuthenticationTag)
					});
				}
				catch (global::System.Exception innerException)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10616: Encryption failed. EncryptionProvider failed for: Algorithm: '{0}', SecurityKey: '{1}'. See inner exception.", new object[]
					{
						encryptingCredentials.Enc,
						encryptingCredentials.Key
					}), innerException));
				}
			}
			if (!cryptoProviderFactory.IsSupportedAlgorithm(encryptingCredentials.Alg, encryptingCredentials.Key))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10615: Encryption failed. No support for: Algorithm: '{0}', SecurityKey: '{1}'.", new object[]
				{
					encryptingCredentials.Alg,
					encryptingCredentials.Key
				})));
			}
			global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey symmetricSecurityKey;
			if ("A128CBC-HS256".Equals(encryptingCredentials.Enc, global::System.StringComparison.Ordinal))
			{
				symmetricSecurityKey = new global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.GenerateKeyBytes(256));
			}
			else if ("A192CBC-HS384".Equals(encryptingCredentials.Enc, global::System.StringComparison.Ordinal))
			{
				symmetricSecurityKey = new global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.GenerateKeyBytes(384));
			}
			else
			{
				if (!"A256CBC-HS512".Equals(encryptingCredentials.Enc, global::System.StringComparison.Ordinal))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10617: Encryption failed. Keywrap is only supported for: '{0}', '{1}' and '{2}'. The content encryption specified is: '{3}'.", new object[]
					{
						"A128CBC-HS256",
						"A192CBC-HS384",
						"A256CBC-HS512",
						encryptingCredentials.Enc
					})));
				}
				symmetricSecurityKey = new global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.GenerateKeyBytes(512));
			}
			byte[] inArray = cryptoProviderFactory.CreateKeyWrapProvider(encryptingCredentials.Key, encryptingCredentials.Alg).WrapKey(symmetricSecurityKey.Key);
			global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider authenticatedEncryptionProvider2 = cryptoProviderFactory.CreateAuthenticatedEncryptionProvider(symmetricSecurityKey, encryptingCredentials.Enc);
			if (authenticatedEncryptionProvider2 == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException("IDX14103: Failed to create the token encryption provider."));
			}
			string result;
			try
			{
				global::Newtonsoft.Json.Linq.JObject jobject2 = new global::Newtonsoft.Json.Linq.JObject();
				if (!string.IsNullOrEmpty(encryptingCredentials.Alg))
				{
					jobject2.Add("alg", encryptingCredentials.Alg);
				}
				if (!string.IsNullOrEmpty(encryptingCredentials.Enc))
				{
					jobject2.Add("enc", encryptingCredentials.Enc);
				}
				if (!string.IsNullOrEmpty(encryptingCredentials.Key.KeyId))
				{
					jobject2.Add("kid", encryptingCredentials.Key.KeyId);
				}
				jobject2.Add("typ", "JWT");
				string text2 = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(global::System.Text.Encoding.UTF8.GetBytes(jobject2.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0])));
				global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionResult authenticatedEncryptionResult2 = authenticatedEncryptionProvider2.Encrypt(global::System.Text.Encoding.UTF8.GetBytes(innerJwt), global::System.Text.Encoding.ASCII.GetBytes(text2));
				result = string.Join(".", new string[]
				{
					text2,
					global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(inArray),
					global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedEncryptionResult2.IV),
					global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedEncryptionResult2.Ciphertext),
					global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedEncryptionResult2.AuthenticationTag)
				});
			}
			catch (global::System.Exception innerException2)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10616: Encryption failed. EncryptionProvider failed for: Algorithm: '{0}', SecurityKey: '{1}'. See inner exception.", new object[]
				{
					encryptingCredentials.Enc,
					encryptingCredentials.Key
				}), innerException2));
			}
			return result;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003000 File Offset: 0x00001200
		private global::System.Collections.Generic.IEnumerable<global::Microsoft.IdentityModel.Tokens.SecurityKey> GetAllSigningKeys(string token, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10243: Reading issuer signing keys from validation parameters.", new object[0]);
			if (validationParameters.IssuerSigningKey != null)
			{
				yield return validationParameters.IssuerSigningKey;
			}
			if (validationParameters.IssuerSigningKeys != null)
			{
				foreach (global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey in validationParameters.IssuerSigningKeys)
				{
					yield return securityKey;
				}
				global::System.Collections.Generic.IEnumerator<global::Microsoft.IdentityModel.Tokens.SecurityKey> enumerator = null;
			}
			yield break;
			yield break;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003010 File Offset: 0x00001210
		internal virtual global::Microsoft.IdentityModel.Tokens.SecurityKey ResolveIssuerSigningKey(global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken jwtToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (validationParameters == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("validationParameters");
			}
			if (jwtToken == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("jwtToken");
			}
			if (!string.IsNullOrEmpty(jwtToken.Kid))
			{
				string kid = jwtToken.Kid;
				if (validationParameters.IssuerSigningKey != null && string.Equals(validationParameters.IssuerSigningKey.KeyId, kid, (validationParameters.IssuerSigningKey is global::Microsoft.IdentityModel.Tokens.X509SecurityKey) ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal))
				{
					return validationParameters.IssuerSigningKey;
				}
				if (validationParameters.IssuerSigningKeys != null)
				{
					foreach (global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey in validationParameters.IssuerSigningKeys)
					{
						if (securityKey != null && string.Equals(securityKey.KeyId, kid, (securityKey is global::Microsoft.IdentityModel.Tokens.X509SecurityKey) ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal))
						{
							return securityKey;
						}
					}
				}
			}
			if (!string.IsNullOrEmpty(jwtToken.X5t))
			{
				string x5t = jwtToken.X5t;
				if (validationParameters.IssuerSigningKey != null)
				{
					if (string.Equals(validationParameters.IssuerSigningKey.KeyId, x5t, (validationParameters.IssuerSigningKey is global::Microsoft.IdentityModel.Tokens.X509SecurityKey) ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal))
					{
						return validationParameters.IssuerSigningKey;
					}
					global::Microsoft.IdentityModel.Tokens.X509SecurityKey x509SecurityKey = validationParameters.IssuerSigningKey as global::Microsoft.IdentityModel.Tokens.X509SecurityKey;
					if (x509SecurityKey != null && string.Equals(x509SecurityKey.X5t, x5t, global::System.StringComparison.OrdinalIgnoreCase))
					{
						return validationParameters.IssuerSigningKey;
					}
				}
				if (validationParameters.IssuerSigningKeys != null)
				{
					foreach (global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey2 in validationParameters.IssuerSigningKeys)
					{
						if (securityKey2 != null && string.Equals(securityKey2.KeyId, x5t, (securityKey2 is global::Microsoft.IdentityModel.Tokens.X509SecurityKey) ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal))
						{
							return securityKey2;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000031C4 File Offset: 0x000013C4
		public global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken ReadJsonWebToken(string token)
		{
			if (string.IsNullOrEmpty(token))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("token");
			}
			if (token.Length > this.MaximumTokenSizeInBytes)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10209: token has length: '{0}' which is larger than the MaximumTokenSizeInBytes: '{1}'.", new object[]
				{
					token.Length,
					this.MaximumTokenSizeInBytes
				})));
			}
			return new global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken(token);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000322F File Offset: 0x0000142F
		public global::Microsoft.IdentityModel.Tokens.SecurityToken ReadToken(string token)
		{
			return this.ReadJsonWebToken(token);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003238 File Offset: 0x00001438
		public global::Microsoft.IdentityModel.JsonWebTokens.TokenValidationResult ValidateToken(string token, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (string.IsNullOrEmpty(token))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("token");
			}
			if (validationParameters == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("validationParameters");
			}
			if (token.Length > this.MaximumTokenSizeInBytes)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10209: token has length: '{0}' which is larger than the MaximumTokenSizeInBytes: '{1}'.", new object[]
				{
					token.Length,
					this.MaximumTokenSizeInBytes
				})));
			}
			global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken jsonWebToken = this.ValidateSignature(token, validationParameters);
			return this.ValidateTokenPayload(jsonWebToken, validationParameters);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000032BC File Offset: 0x000014BC
		private global::Microsoft.IdentityModel.JsonWebTokens.TokenValidationResult ValidateTokenPayload(global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken jsonWebToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::System.DateTime validTo = jsonWebToken.ValidTo;
			global::System.DateTime? dateTime = new global::System.DateTime?(jsonWebToken.ValidTo);
			global::System.DateTime validFrom = jsonWebToken.ValidFrom;
			global::Microsoft.IdentityModel.Tokens.Validators.ValidateLifetime(new global::System.DateTime?(jsonWebToken.ValidFrom), dateTime, jsonWebToken, validationParameters);
			global::Microsoft.IdentityModel.Tokens.Validators.ValidateAudience(jsonWebToken.Audiences, jsonWebToken, validationParameters);
			global::Microsoft.IdentityModel.Tokens.Validators.ValidateIssuer(jsonWebToken.Issuer, jsonWebToken, validationParameters);
			global::Microsoft.IdentityModel.Tokens.Validators.ValidateTokenReplay(dateTime, jsonWebToken.EncodedToken, validationParameters);
			if (validationParameters.ValidateActor && !string.IsNullOrWhiteSpace(jsonWebToken.Actor))
			{
				this.ValidateToken(jsonWebToken.Actor, validationParameters.ActorValidationParameters ?? validationParameters);
			}
			global::Microsoft.IdentityModel.Tokens.Validators.ValidateIssuerSecurityKey(jsonWebToken.SigningKey, jsonWebToken, validationParameters);
			return new global::Microsoft.IdentityModel.JsonWebTokens.TokenValidationResult
			{
				SecurityToken = jsonWebToken
			};
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003364 File Offset: 0x00001564
		private global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken ValidateSignature(string token, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (string.IsNullOrWhiteSpace(token))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("token");
			}
			if (validationParameters == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("validationParameters");
			}
			if (validationParameters.SignatureValidator != null)
			{
				global::Microsoft.IdentityModel.Tokens.SecurityToken securityToken = validationParameters.SignatureValidator(token, validationParameters);
				if (securityToken == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSignatureException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10505: Signature validation failed. The user defined 'Delegate' specified on TokenValidationParameters returned null when validating token: '{0}'.", new object[]
					{
						token
					})));
				}
				global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken jsonWebToken = securityToken as global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken;
				if (jsonWebToken == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSignatureException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10506: Signature validation failed. The user defined 'Delegate' specified on TokenValidationParameters did not return a '{0}', but returned a '{1}' when validating token: '{2}'.", new object[]
					{
						typeof(global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken),
						jsonWebToken.GetType(),
						token
					})));
				}
				return jsonWebToken;
			}
			else
			{
				global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken jsonWebToken2 = null;
				if (validationParameters.TokenReader != null)
				{
					global::Microsoft.IdentityModel.Tokens.SecurityToken securityToken2 = validationParameters.TokenReader(token, validationParameters);
					if (securityToken2 == null)
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSignatureException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10510: Signature validation failed. The user defined 'Delegate' specified in TokenValidationParameters returned null when reading token: '{0}'.", new object[]
						{
							token
						})));
					}
					jsonWebToken2 = (securityToken2 as global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken);
					if (jsonWebToken2 == null)
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSignatureException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10509: Signature validation failed. The user defined 'Delegate' specified in TokenValidationParameters did not return a '{0}', but returned a '{1}' when reading token: '{2}'.", new object[]
						{
							typeof(global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken),
							securityToken2.GetType(),
							token
						})));
					}
				}
				else
				{
					jsonWebToken2 = new global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken(token);
				}
				string[] array = jsonWebToken2.EncodedToken.Split(new char[]
				{
					'.'
				}, 6);
				byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(array[0] + "." + array[1]);
				if (!string.IsNullOrEmpty(array[2]))
				{
					bool flag = false;
					global::System.Collections.Generic.IEnumerable<global::Microsoft.IdentityModel.Tokens.SecurityKey> enumerable = null;
					if (validationParameters.IssuerSigningKeyResolver != null)
					{
						enumerable = validationParameters.IssuerSigningKeyResolver(token, jsonWebToken2, jsonWebToken2.Kid, validationParameters);
					}
					else
					{
						global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey = this.ResolveIssuerSigningKey(jsonWebToken2, validationParameters);
						if (securityKey != null)
						{
							flag = true;
							enumerable = new global::System.Collections.Generic.List<global::Microsoft.IdentityModel.Tokens.SecurityKey>
							{
								securityKey
							};
						}
					}
					if (enumerable == null)
					{
						enumerable = this.GetAllSigningKeys(token, validationParameters);
					}
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
					bool flag2 = !string.IsNullOrEmpty(jsonWebToken2.Kid);
					byte[] signature;
					try
					{
						signature = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(array[2]);
					}
					catch (global::System.FormatException innerException)
					{
						throw new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSignatureException("IDX10508: Signature validation failed. Signature is improperly formatted.", innerException);
					}
					foreach (global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey2 in enumerable)
					{
						try
						{
							if (this.ValidateSignature(bytes, signature, securityKey2, jsonWebToken2.Alg, validationParameters))
							{
								global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10242: Security token: '{0}' has a valid signature.", new object[]
								{
									token
								});
								jsonWebToken2.SigningKey = securityKey2;
								return jsonWebToken2;
							}
						}
						catch (global::System.Exception ex)
						{
							stringBuilder.AppendLine(ex.ToString());
						}
						if (securityKey2 != null)
						{
							stringBuilder2.AppendLine(securityKey2.ToString() + " , KeyId: " + securityKey2.KeyId);
							if (flag2 && !flag && securityKey2.KeyId != null)
							{
								flag = jsonWebToken2.Kid.Equals(securityKey2.KeyId, (securityKey2 is global::Microsoft.IdentityModel.Tokens.X509SecurityKey) ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal);
							}
						}
					}
					if (flag2)
					{
						if (flag)
						{
							throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSignatureException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10511: Signature validation failed. Keys tried: '{0}'. \nkid: '{1}'. \nExceptions caught:\n '{2}'.\ntoken: '{3}'.", new object[]
							{
								stringBuilder2,
								jsonWebToken2.Kid,
								stringBuilder,
								jsonWebToken2
							})));
						}
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenSignatureKeyNotFoundException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10501: Signature validation failed. Unable to match keys: \nkid: '{0}', \ntoken: '{1}'.", new object[]
						{
							jsonWebToken2.Kid,
							jsonWebToken2
						})));
					}
					else
					{
						if (stringBuilder2.Length > 0)
						{
							throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSignatureException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10503: Signature validation failed. Keys tried: '{0}'.\nExceptions caught:\n '{1}'.\ntoken: '{2}'.", new object[]
							{
								stringBuilder2,
								stringBuilder,
								jsonWebToken2
							})));
						}
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenSignatureKeyNotFoundException("IDX10500: Signature validation failed. No security keys were provided to validate the signature."));
					}
					global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken result;
					return result;
				}
				if (validationParameters.RequireSignedTokens)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSignatureException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10504: Unable to validate signature, token does not have a signature: '{0}'.", new object[]
					{
						token
					})));
				}
				return jsonWebToken2;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003728 File Offset: 0x00001928
		private bool ValidateSignature(byte[] encodedBytes, byte[] signature, global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory cryptoProviderFactory = validationParameters.CryptoProviderFactory ?? key.CryptoProviderFactory;
			if (!cryptoProviderFactory.IsSupportedAlgorithm(algorithm, key))
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX1400: Signing JWT is not supported for: Algorithm: '{0}', SecurityKey: '{1}'.", new object[]
				{
					algorithm,
					key
				});
				return false;
			}
			global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider = cryptoProviderFactory.CreateForVerifying(key, algorithm);
			if (signatureProvider == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10647: A CustomCryptoProvider was set and returned 'true' for IsSupportedAlgorithm(Algorithm: '{0}'), but Create.(algorithm, args) as '{1}' == NULL.", new object[]
				{
					(key == null) ? "Null" : key.ToString(),
					(algorithm == null) ? "Null" : algorithm
				})));
			}
			bool result;
			try
			{
				result = signatureProvider.Verify(encodedBytes, signature);
			}
			finally
			{
				cryptoProviderFactory.ReleaseSignatureProvider(signatureProvider);
			}
			return result;
		}

		// Token: 0x04000009 RID: 9
		private int _maximumTokenSizeInBytes = 2097152;
	}
}
