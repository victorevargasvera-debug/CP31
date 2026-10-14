using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;

namespace System.IdentityModel.Tokens.Jwt
{
	// Token: 0x0200000D RID: 13
	public class JwtSecurityTokenHandler : global::Microsoft.IdentityModel.Tokens.SecurityTokenHandler
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00003C90 File Offset: 0x00001E90
		static JwtSecurityTokenHandler()
		{
			global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose("Assembly version info: " + typeof(global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler).AssemblyQualifiedName, new object[0]);
			global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler.DefaultOutboundAlgorithmMap = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha256",
					"ES256"
				},
				{
					"http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha384",
					"ES384"
				},
				{
					"http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha512",
					"ES512"
				},
				{
					"http://www.w3.org/2001/04/xmldsig-more#hmac-sha256",
					"HS256"
				},
				{
					"http://www.w3.org/2001/04/xmldsig-more#hmac-sha384",
					"HS384"
				},
				{
					"http://www.w3.org/2001/04/xmldsig-more#hmac-sha512",
					"HS512"
				},
				{
					"http://www.w3.org/2001/04/xmldsig-more#rsa-sha256",
					"RS256"
				},
				{
					"http://www.w3.org/2001/04/xmldsig-more#rsa-sha384",
					"RS384"
				},
				{
					"http://www.w3.org/2001/04/xmldsig-more#rsa-sha512",
					"RS512"
				}
			};
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003D9C File Offset: 0x00001F9C
		public JwtSecurityTokenHandler()
		{
			if (this._mapInboundClaims)
			{
				this._inboundClaimTypeMap = new global::System.Collections.Generic.Dictionary<string, string>(global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler.DefaultInboundClaimTypeMap);
			}
			else
			{
				this._inboundClaimTypeMap = new global::System.Collections.Generic.Dictionary<string, string>();
			}
			this._outboundClaimTypeMap = new global::System.Collections.Generic.Dictionary<string, string>(global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler.DefaultOutboundClaimTypeMap);
			this._inboundClaimFilter = new global::System.Collections.Generic.HashSet<string>(global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler.DefaultInboundClaimFilter);
			this._outboundAlgorithmMap = new global::System.Collections.Generic.Dictionary<string, string>(global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler.DefaultOutboundAlgorithmMap);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003E21 File Offset: 0x00002021
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00003E29 File Offset: 0x00002029
		public bool MapInboundClaims
		{
			get
			{
				return this._mapInboundClaims;
			}
			set
			{
				if (!this._mapInboundClaims && value && this._inboundClaimTypeMap.Count == 0)
				{
					this._inboundClaimTypeMap = new global::System.Collections.Generic.Dictionary<string, string>(global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler.DefaultInboundClaimTypeMap);
				}
				this._mapInboundClaims = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003E5C File Offset: 0x0000205C
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00003E64 File Offset: 0x00002064
		public global::System.Collections.Generic.IDictionary<string, string> InboundClaimTypeMap
		{
			get
			{
				return this._inboundClaimTypeMap;
			}
			set
			{
				if (value == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("value");
				}
				this._inboundClaimTypeMap = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003E7C File Offset: 0x0000207C
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00003E84 File Offset: 0x00002084
		public global::System.Collections.Generic.IDictionary<string, string> OutboundClaimTypeMap
		{
			get
			{
				return this._outboundClaimTypeMap;
			}
			set
			{
				if (value == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("value");
				}
				this._outboundClaimTypeMap = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00003E9B File Offset: 0x0000209B
		public global::System.Collections.Generic.IDictionary<string, string> OutboundAlgorithmMap
		{
			get
			{
				return this._outboundAlgorithmMap;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00003EA3 File Offset: 0x000020A3
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00003EAB File Offset: 0x000020AB
		public global::System.Collections.Generic.ISet<string> InboundClaimFilter
		{
			get
			{
				return this._inboundClaimFilter;
			}
			set
			{
				if (value == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("value");
				}
				this._inboundClaimFilter = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00003EC2 File Offset: 0x000020C2
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00003EC9 File Offset: 0x000020C9
		public static string ShortClaimTypeProperty
		{
			get
			{
				return global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler._shortClaimType;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("value");
				}
				global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler._shortClaimType = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003EE4 File Offset: 0x000020E4
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00003EEB File Offset: 0x000020EB
		public static string JsonClaimTypeProperty
		{
			get
			{
				return global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler._jsonClaimType;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("value");
				}
				global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler._jsonClaimType = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00003F06 File Offset: 0x00002106
		public override bool CanValidateToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00003F09 File Offset: 0x00002109
		public override bool CanWriteToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00003F0C File Offset: 0x0000210C
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00003F14 File Offset: 0x00002114
		public int TokenLifetimeInMinutes
		{
			get
			{
				return this._defaultTokenLifetimeInMinutes;
			}
			set
			{
				if (value < 1)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("value", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10104: TokenLifetimeInMinutes must be greater than zero. value: '{0}'", new object[]
					{
						value
					})));
				}
				this._defaultTokenLifetimeInMinutes = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003F4A File Offset: 0x0000214A
		public override global::System.Type TokenType
		{
			get
			{
				return typeof(global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003F58 File Offset: 0x00002158
		public override bool CanReadToken(string token)
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
			string[] array = token.Split(new char[]
			{
				'.'
			}, 6);
			if (array.Length == 3)
			{
				return global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.RegexJws.IsMatch(token);
			}
			if (array.Length == 5)
			{
				return global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.RegexJwe.IsMatch(token);
			}
			global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX12720: Token string does not match the token formats: JWE (header.encryptedKey.iv.ciphertext.tag) or JWS (header.payload.signature)", new object[0]);
			return false;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003FF3 File Offset: 0x000021F3
		public virtual string CreateEncodedJwt(global::Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor)
		{
			if (tokenDescriptor == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("tokenDescriptor");
			}
			return this.CreateJwtSecurityToken(tokenDescriptor).RawData;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004010 File Offset: 0x00002210
		public virtual string CreateEncodedJwt(string issuer, string audience, global::System.Security.Claims.ClaimsIdentity subject, global::System.DateTime? notBefore, global::System.DateTime? expires, global::System.DateTime? issuedAt, global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials)
		{
			return this.CreateJwtSecurityTokenPrivate(issuer, audience, subject, notBefore, expires, issuedAt, signingCredentials, null).RawData;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004034 File Offset: 0x00002234
		public virtual string CreateEncodedJwt(string issuer, string audience, global::System.Security.Claims.ClaimsIdentity subject, global::System.DateTime? notBefore, global::System.DateTime? expires, global::System.DateTime? issuedAt, global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials, global::Microsoft.IdentityModel.Tokens.EncryptingCredentials encryptingCredentials)
		{
			return this.CreateJwtSecurityTokenPrivate(issuer, audience, subject, notBefore, expires, issuedAt, signingCredentials, encryptingCredentials).RawData;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000405C File Offset: 0x0000225C
		public virtual global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken CreateJwtSecurityToken(global::Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor)
		{
			if (tokenDescriptor == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("tokenDescriptor");
			}
			return this.CreateJwtSecurityTokenPrivate(tokenDescriptor.Issuer, tokenDescriptor.Audience, tokenDescriptor.Subject, tokenDescriptor.NotBefore, tokenDescriptor.Expires, tokenDescriptor.IssuedAt, tokenDescriptor.SigningCredentials, tokenDescriptor.EncryptingCredentials);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000040B0 File Offset: 0x000022B0
		public virtual global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken CreateJwtSecurityToken(string issuer, string audience, global::System.Security.Claims.ClaimsIdentity subject, global::System.DateTime? notBefore, global::System.DateTime? expires, global::System.DateTime? issuedAt, global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials, global::Microsoft.IdentityModel.Tokens.EncryptingCredentials encryptingCredentials)
		{
			return this.CreateJwtSecurityTokenPrivate(issuer, audience, subject, notBefore, expires, issuedAt, signingCredentials, encryptingCredentials);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000040D0 File Offset: 0x000022D0
		public virtual global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken CreateJwtSecurityToken(string issuer = null, string audience = null, global::System.Security.Claims.ClaimsIdentity subject = null, global::System.DateTime? notBefore = null, global::System.DateTime? expires = null, global::System.DateTime? issuedAt = null, global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials = null)
		{
			return this.CreateJwtSecurityTokenPrivate(issuer, audience, subject, notBefore, expires, issuedAt, signingCredentials, null);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000040F0 File Offset: 0x000022F0
		public override global::Microsoft.IdentityModel.Tokens.SecurityToken CreateToken(global::Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor)
		{
			if (tokenDescriptor == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("tokenDescriptor");
			}
			return this.CreateJwtSecurityTokenPrivate(tokenDescriptor.Issuer, tokenDescriptor.Audience, tokenDescriptor.Subject, tokenDescriptor.NotBefore, tokenDescriptor.Expires, tokenDescriptor.IssuedAt, tokenDescriptor.SigningCredentials, tokenDescriptor.EncryptingCredentials);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004144 File Offset: 0x00002344
		private global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken CreateJwtSecurityTokenPrivate(string issuer, string audience, global::System.Security.Claims.ClaimsIdentity subject, global::System.DateTime? notBefore, global::System.DateTime? expires, global::System.DateTime? issuedAt, global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials, global::Microsoft.IdentityModel.Tokens.EncryptingCredentials encryptingCredentials)
		{
			if (this.SetDefaultTimesOnTokenCreation && (expires == null || issuedAt == null || notBefore == null))
			{
				global::System.DateTime utcNow = global::System.DateTime.UtcNow;
				if (expires == null)
				{
					expires = new global::System.DateTime?(utcNow + global::System.TimeSpan.FromMinutes((double)this.TokenLifetimeInMinutes));
				}
				if (issuedAt == null)
				{
					issuedAt = new global::System.DateTime?(utcNow);
				}
				if (notBefore == null)
				{
					notBefore = new global::System.DateTime?(utcNow);
				}
			}
			global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose("IDX12721: Creating JwtSecurityToken: Issuer: '{0}', Audience: '{1}'", new object[]
			{
				audience ?? "null",
				issuer ?? "null"
			});
			global::System.IdentityModel.Tokens.Jwt.JwtPayload jwtPayload = new global::System.IdentityModel.Tokens.Jwt.JwtPayload(issuer, audience, (subject == null) ? null : this.OutboundClaimTypeTransform(subject.Claims), notBefore, expires, issuedAt);
			global::System.IdentityModel.Tokens.Jwt.JwtHeader jwtHeader = (signingCredentials == null) ? new global::System.IdentityModel.Tokens.Jwt.JwtHeader() : new global::System.IdentityModel.Tokens.Jwt.JwtHeader(signingCredentials, this.OutboundAlgorithmMap);
			if (((subject != null) ? subject.Actor : null) != null)
			{
				jwtPayload.AddClaim(new global::System.Security.Claims.Claim("actort", this.CreateActorValue(subject.Actor)));
			}
			string text = jwtHeader.Base64UrlEncode();
			string text2 = jwtPayload.Base64UrlEncode();
			string text3 = (signingCredentials == null) ? string.Empty : global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.CreateEncodedSignature(text + "." + text2, signingCredentials);
			global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX12722: Creating security token from the header: '{0}', payload: '{1}' and raw signature: '{2}'.", new object[]
			{
				text,
				text2,
				text3
			});
			if (encryptingCredentials != null)
			{
				return this.EncryptToken(new global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken(jwtHeader, jwtPayload, text, text2, text3), encryptingCredentials);
			}
			return new global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken(jwtHeader, jwtPayload, text, text2, text3);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000042C0 File Offset: 0x000024C0
		private global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken EncryptToken(global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken innerJwt, global::Microsoft.IdentityModel.Tokens.EncryptingCredentials encryptingCredentials)
		{
			global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory cryptoProviderFactory = encryptingCredentials.CryptoProviderFactory ?? encryptingCredentials.Key.CryptoProviderFactory;
			if (cryptoProviderFactory == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException("IDX12733: Unable to obtain a CryptoProviderFactory, both EncryptingCredentials.CryptoProviderFactory and EncryptingCredentials.Key.CrypoProviderFactory are both null."));
			}
			if (encryptingCredentials == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("encryptingCredentials");
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
				global::System.IdentityModel.Tokens.Jwt.JwtHeader jwtHeader = new global::System.IdentityModel.Tokens.Jwt.JwtHeader(encryptingCredentials, this.OutboundAlgorithmMap);
				global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider authenticatedEncryptionProvider = cryptoProviderFactory.CreateAuthenticatedEncryptionProvider(encryptingCredentials.Key, encryptingCredentials.Enc);
				if (authenticatedEncryptionProvider == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException("IDX12730: Failed to create the token encryption provider."));
				}
				try
				{
					global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionResult authenticatedEncryptionResult = authenticatedEncryptionProvider.Encrypt(global::System.Text.Encoding.UTF8.GetBytes(innerJwt.RawData), global::System.Text.Encoding.ASCII.GetBytes(jwtHeader.Base64UrlEncode()));
					return new global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken(jwtHeader, innerJwt, jwtHeader.Base64UrlEncode(), string.Empty, global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedEncryptionResult.IV), global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedEncryptionResult.Ciphertext), global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedEncryptionResult.AuthenticationTag));
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
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException("IDX12730: Failed to create the token encryption provider."));
			}
			global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken result;
			try
			{
				global::System.IdentityModel.Tokens.Jwt.JwtHeader jwtHeader2 = new global::System.IdentityModel.Tokens.Jwt.JwtHeader(encryptingCredentials, this.OutboundAlgorithmMap);
				global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionResult authenticatedEncryptionResult2 = authenticatedEncryptionProvider2.Encrypt(global::System.Text.Encoding.UTF8.GetBytes(innerJwt.RawData), global::System.Text.Encoding.ASCII.GetBytes(jwtHeader2.Base64UrlEncode()));
				result = new global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken(jwtHeader2, innerJwt, jwtHeader2.Base64UrlEncode(), global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(inArray), global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedEncryptionResult2.IV), global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedEncryptionResult2.Ciphertext), global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(authenticatedEncryptionResult2.AuthenticationTag));
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

		// Token: 0x060000A0 RID: 160 RVA: 0x00004620 File Offset: 0x00002820
		private global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> OutboundClaimTypeTransform(global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> claims)
		{
			foreach (global::System.Security.Claims.Claim claim in claims)
			{
				string type = null;
				if (this._outboundClaimTypeMap.TryGetValue(claim.Type, out type))
				{
					yield return new global::System.Security.Claims.Claim(type, claim.Value, claim.ValueType, claim.Issuer, claim.OriginalIssuer, claim.Subject);
				}
				else
				{
					yield return claim;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Security.Claims.Claim> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004638 File Offset: 0x00002838
		public global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken ReadJwtToken(string token)
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
			if (!this.CanReadToken(token))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12709: CanReadToken() returned false. JWT is not well formed: '{0}'.\nThe token needs to be in JWS or JWE Compact Serialization Format. (JWS): 'EncodedHeader.EndcodedPayload.EncodedSignature'. (JWE): 'EncodedProtectedHeader.EncodedEncryptedKey.EncodedInitializationVector.EncodedCiphertext.EncodedAuthenticationTag'.", new object[]
				{
					token
				})));
			}
			global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtSecurityToken = new global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken(null, null, null, null, null, null);
			jwtSecurityToken.Decode(token.Split(new char[]
			{
				'.'
			}), token);
			return jwtSecurityToken;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000046FA File Offset: 0x000028FA
		public override global::Microsoft.IdentityModel.Tokens.SecurityToken ReadToken(string token)
		{
			return this.ReadJwtToken(token);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004703 File Offset: 0x00002903
		public override global::Microsoft.IdentityModel.Tokens.SecurityToken ReadToken(global::System.Xml.XmlReader reader, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000470C File Offset: 0x0000290C
		public override global::System.Security.Claims.ClaimsPrincipal ValidateToken(string token, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters, out global::Microsoft.IdentityModel.Tokens.SecurityToken validatedToken)
		{
			if (string.IsNullOrWhiteSpace(token))
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
			string[] array = token.Split(new char[]
			{
				'.'
			}, 6);
			if (array.Length != 3 && array.Length != 5)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12741: JWT: '{0}' must have three segments (JWS) or five segments (JWE).", new object[]
				{
					token
				})));
			}
			if (array.Length == 5)
			{
				global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtSecurityToken = this.ReadJwtToken(token);
				string token2 = this.DecryptToken(jwtSecurityToken, validationParameters);
				global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtSecurityToken2 = this.ValidateSignature(token2, validationParameters);
				jwtSecurityToken.InnerToken = jwtSecurityToken2;
				validatedToken = jwtSecurityToken;
				return this.ValidateTokenPayload(jwtSecurityToken2, validationParameters);
			}
			validatedToken = this.ValidateSignature(token, validationParameters);
			return this.ValidateTokenPayload(validatedToken as global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken, validationParameters);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004808 File Offset: 0x00002A08
		protected global::System.Security.Claims.ClaimsPrincipal ValidateTokenPayload(global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::System.DateTime? expires = (jwtToken.Payload.Exp == null) ? null : new global::System.DateTime?(jwtToken.ValidTo);
			global::System.DateTime? notBefore = (jwtToken.Payload.Nbf == null) ? null : new global::System.DateTime?(jwtToken.ValidFrom);
			this.ValidateLifetime(notBefore, expires, jwtToken, validationParameters);
			this.ValidateAudience(jwtToken.Audiences, jwtToken, validationParameters);
			string issuer = this.ValidateIssuer(jwtToken.Issuer, jwtToken, validationParameters);
			this.ValidateTokenReplay(expires, jwtToken.RawData, validationParameters);
			if (validationParameters.ValidateActor && !string.IsNullOrWhiteSpace(jwtToken.Actor))
			{
				global::Microsoft.IdentityModel.Tokens.SecurityToken securityToken = null;
				this.ValidateToken(jwtToken.Actor, validationParameters.ActorValidationParameters ?? validationParameters, out securityToken);
			}
			this.ValidateIssuerSecurityKey(jwtToken.SigningKey, jwtToken, validationParameters);
			global::System.Security.Claims.ClaimsIdentity claimsIdentity = this.CreateClaimsIdentity(jwtToken, issuer, validationParameters);
			if (validationParameters.SaveSigninToken)
			{
				claimsIdentity.BootstrapContext = jwtToken.RawData;
			}
			global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10241: Security token validated. token: '{0}'.", new object[]
			{
				jwtToken.RawData
			});
			return new global::System.Security.Claims.ClaimsPrincipal(claimsIdentity);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004924 File Offset: 0x00002B24
		public override string WriteToken(global::Microsoft.IdentityModel.Tokens.SecurityToken token)
		{
			if (token == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("token");
			}
			global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtSecurityToken = token as global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken;
			if (jwtSecurityToken == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12706: '{0}' can only write SecurityTokens of type: '{1}', 'token' type is: '{2}'.", new object[]
				{
					base.GetType(),
					typeof(global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken),
					token.GetType()
				}), "token"));
			}
			string encodedPayload = jwtSecurityToken.EncodedPayload;
			string text = string.Empty;
			string text2 = string.Empty;
			if (jwtSecurityToken.InnerToken != null)
			{
				if (jwtSecurityToken.SigningCredentials != null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException("IDX12736: JwtSecurityToken.SigningCredentials is not supported when JwtSecurityToken.InnerToken is set."));
				}
				if (jwtSecurityToken.InnerToken.Header.EncryptingCredentials != null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException("IDX12737: EncryptingCredentials set on JwtSecurityToken.InnerToken is not supported."));
				}
				if (jwtSecurityToken.Header.EncryptingCredentials == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenEncryptionFailedException("IDX12735: If JwtSecurityToken.InnerToken != null, then JwtSecurityToken.Header.EncryptingCredentials must be set."));
				}
				if (jwtSecurityToken.InnerToken.SigningCredentials != null)
				{
					text = global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.CreateEncodedSignature(jwtSecurityToken.InnerToken.EncodedHeader + "." + jwtSecurityToken.EncodedPayload, jwtSecurityToken.InnerToken.SigningCredentials);
				}
				return this.EncryptToken(new global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken(jwtSecurityToken.InnerToken.Header, jwtSecurityToken.InnerToken.Payload, jwtSecurityToken.InnerToken.EncodedHeader, encodedPayload, text), jwtSecurityToken.EncryptingCredentials).RawData;
			}
			else
			{
				global::System.IdentityModel.Tokens.Jwt.JwtHeader jwtHeader = (jwtSecurityToken.EncryptingCredentials == null) ? jwtSecurityToken.Header : new global::System.IdentityModel.Tokens.Jwt.JwtHeader(jwtSecurityToken.SigningCredentials);
				text2 = jwtHeader.Base64UrlEncode();
				if (jwtSecurityToken.SigningCredentials != null)
				{
					text = global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.CreateEncodedSignature(text2 + "." + encodedPayload, jwtSecurityToken.SigningCredentials);
				}
				if (jwtSecurityToken.EncryptingCredentials != null)
				{
					return this.EncryptToken(new global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken(jwtHeader, jwtSecurityToken.Payload, text2, encodedPayload, text), jwtSecurityToken.EncryptingCredentials).RawData;
				}
				return string.Concat(new string[]
				{
					text2,
					".",
					encodedPayload,
					".",
					text
				});
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004B08 File Offset: 0x00002D08
		private bool ValidateSignature(byte[] encodedBytes, byte[] signature, global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory cryptoProviderFactory = validationParameters.CryptoProviderFactory ?? key.CryptoProviderFactory;
			if (!cryptoProviderFactory.IsSupportedAlgorithm(algorithm, key))
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX12508: Signing JWT is not supported for: Algorithm: '{0}', SecurityKey: '{1}'.", new object[]
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

		// Token: 0x060000A8 RID: 168 RVA: 0x00004BC0 File Offset: 0x00002DC0
		protected virtual global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken ValidateSignature(string token, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
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
				global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtSecurityToken = securityToken as global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken;
				if (jwtSecurityToken == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSignatureException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10506: Signature validation failed. The user defined 'Delegate' specified on TokenValidationParameters did not return a '{0}', but returned a '{1}' when validating token: '{2}'.", new object[]
					{
						typeof(global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken),
						securityToken.GetType(),
						token
					})));
				}
				return jwtSecurityToken;
			}
			else
			{
				global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtSecurityToken2 = null;
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
					jwtSecurityToken2 = (securityToken2 as global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken);
					if (jwtSecurityToken2 == null)
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSignatureException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10509: Signature validation failed. The user defined 'Delegate' specified in TokenValidationParameters did not return a '{0}', but returned a '{1}' when reading token: '{2}'.", new object[]
						{
							typeof(global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken),
							securityToken2.GetType(),
							token
						})));
					}
				}
				else
				{
					jwtSecurityToken2 = this.ReadJwtToken(token);
				}
				byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(jwtSecurityToken2.RawHeader + "." + jwtSecurityToken2.RawPayload);
				if (!string.IsNullOrEmpty(jwtSecurityToken2.RawSignature))
				{
					bool flag = false;
					global::System.Collections.Generic.IEnumerable<global::Microsoft.IdentityModel.Tokens.SecurityKey> enumerable = null;
					if (validationParameters.IssuerSigningKeyResolver != null)
					{
						enumerable = validationParameters.IssuerSigningKeyResolver(token, jwtSecurityToken2, jwtSecurityToken2.Header.Kid, validationParameters);
					}
					else
					{
						global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey = this.ResolveIssuerSigningKey(token, jwtSecurityToken2, validationParameters);
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
						enumerable = this.GetAllSigningKeys(token, jwtSecurityToken2, jwtSecurityToken2.Header.Kid, validationParameters);
					}
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
					bool flag2 = !string.IsNullOrEmpty(jwtSecurityToken2.Header.Kid);
					byte[] signature;
					try
					{
						signature = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(jwtSecurityToken2.RawSignature);
					}
					catch (global::System.FormatException innerException)
					{
						throw new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSignatureException("IDX10508: Signature validation failed. Signature is improperly formatted.", innerException);
					}
					foreach (global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey2 in enumerable)
					{
						try
						{
							if (this.ValidateSignature(bytes, signature, securityKey2, jwtSecurityToken2.Header.Alg, validationParameters))
							{
								global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10242: Security token: '{0}' has a valid signature.", new object[]
								{
									token
								});
								jwtSecurityToken2.SigningKey = securityKey2;
								return jwtSecurityToken2;
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
								flag = jwtSecurityToken2.Header.Kid.Equals(securityKey2.KeyId, (securityKey2 is global::Microsoft.IdentityModel.Tokens.X509SecurityKey) ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal);
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
								jwtSecurityToken2.Header.Kid,
								stringBuilder,
								jwtSecurityToken2
							})));
						}
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenSignatureKeyNotFoundException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10501: Signature validation failed. Unable to match keys: \nkid: '{0}', \ntoken: '{1}'.", new object[]
						{
							jwtSecurityToken2.Header.Kid,
							jwtSecurityToken2
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
								jwtSecurityToken2
							})));
						}
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenSignatureKeyNotFoundException("IDX10500: Signature validation failed. No security keys were provided to validate the signature."));
					}
					global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken result;
					return result;
				}
				if (validationParameters.RequireSignedTokens)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSignatureException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10504: Unable to validate signature, token does not have a signature: '{0}'.", new object[]
					{
						token
					})));
				}
				return jwtSecurityToken2;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004FA0 File Offset: 0x000031A0
		private global::System.Collections.Generic.IEnumerable<global::Microsoft.IdentityModel.Tokens.SecurityKey> GetAllSigningKeys(string token, global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken securityToken, string kid, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
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

		// Token: 0x060000AA RID: 170 RVA: 0x00004FB1 File Offset: 0x000031B1
		private global::System.Collections.Generic.IEnumerable<global::Microsoft.IdentityModel.Tokens.SecurityKey> GetAllDecryptionKeys(global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (validationParameters.TokenDecryptionKey != null)
			{
				yield return validationParameters.TokenDecryptionKey;
			}
			if (validationParameters.TokenDecryptionKeys != null)
			{
				foreach (global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey in validationParameters.TokenDecryptionKeys)
				{
					yield return securityKey;
				}
				global::System.Collections.Generic.IEnumerator<global::Microsoft.IdentityModel.Tokens.SecurityKey> enumerator = null;
			}
			yield break;
			yield break;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004FC4 File Offset: 0x000031C4
		protected virtual global::System.Security.Claims.ClaimsIdentity CreateClaimsIdentity(global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken, string issuer, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (jwtToken == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("jwtToken");
			}
			if (validationParameters == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("validationParameters");
			}
			string actualIssuer = issuer;
			if (string.IsNullOrWhiteSpace(issuer))
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose("IDX10244: Issuer is null or empty. Using runtime default for creating claims '{0}'.", new object[]
				{
					"LOCAL AUTHORITY"
				});
				actualIssuer = "LOCAL AUTHORITY";
			}
			if (!this.MapInboundClaims)
			{
				return this.CreateClaimsIdentityWithoutMapping(jwtToken, actualIssuer, validationParameters);
			}
			return this.CreateClaimsIdentityWithMapping(jwtToken, actualIssuer, validationParameters);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005030 File Offset: 0x00003230
		private global::System.Security.Claims.ClaimsIdentity CreateClaimsIdentityWithMapping(global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken, string actualIssuer, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::System.Security.Claims.ClaimsIdentity claimsIdentity = validationParameters.CreateClaimsIdentity(jwtToken, actualIssuer);
			foreach (global::System.Security.Claims.Claim claim in jwtToken.Claims)
			{
				if (!this._inboundClaimFilter.Contains(claim.Type))
				{
					bool flag = true;
					string type;
					if (!this._inboundClaimTypeMap.TryGetValue(claim.Type, out type))
					{
						type = claim.Type;
						flag = false;
					}
					if (type == "http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor")
					{
						if (claimsIdentity.Actor != null)
						{
							throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12710: Only a single 'Actor' is supported. Found second claim of type: '{0}', value: '{1}'", new object[]
							{
								"actort",
								claim.Value
							})));
						}
						if (this.CanReadToken(claim.Value))
						{
							global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken2 = this.ReadToken(claim.Value) as global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken;
							claimsIdentity.Actor = this.CreateClaimsIdentity(jwtToken2, actualIssuer, validationParameters);
						}
					}
					global::System.Security.Claims.Claim claim2 = new global::System.Security.Claims.Claim(type, claim.Value, claim.ValueType, actualIssuer, actualIssuer, claimsIdentity);
					if (claim.Properties.Count > 0)
					{
						foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in claim.Properties)
						{
							claim2.Properties[keyValuePair.Key] = keyValuePair.Value;
						}
					}
					if (flag)
					{
						claim2.Properties[global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler.ShortClaimTypeProperty] = claim.Type;
					}
					claimsIdentity.AddClaim(claim2);
				}
			}
			return claimsIdentity;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000051E8 File Offset: 0x000033E8
		private global::System.Security.Claims.ClaimsIdentity CreateClaimsIdentityWithoutMapping(global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken, string actualIssuer, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::System.Security.Claims.ClaimsIdentity claimsIdentity = validationParameters.CreateClaimsIdentity(jwtToken, actualIssuer);
			foreach (global::System.Security.Claims.Claim claim in jwtToken.Claims)
			{
				if (!this._inboundClaimFilter.Contains(claim.Type))
				{
					string type = claim.Type;
					if (type == "http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor")
					{
						if (claimsIdentity.Actor != null)
						{
							throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12710: Only a single 'Actor' is supported. Found second claim of type: '{0}', value: '{1}'", new object[]
							{
								"actort",
								claim.Value
							})));
						}
						if (this.CanReadToken(claim.Value))
						{
							global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken2 = this.ReadToken(claim.Value) as global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken;
							claimsIdentity.Actor = this.CreateClaimsIdentity(jwtToken2, actualIssuer, validationParameters);
						}
					}
					global::System.Security.Claims.Claim claim2 = new global::System.Security.Claims.Claim(type, claim.Value, claim.ValueType, actualIssuer, actualIssuer, claimsIdentity);
					if (claim.Properties.Count > 0)
					{
						foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in claim.Properties)
						{
							claim2.Properties[keyValuePair.Key] = keyValuePair.Value;
						}
					}
					claimsIdentity.AddClaim(claim2);
				}
			}
			return claimsIdentity;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005368 File Offset: 0x00003568
		protected virtual string CreateActorValue(global::System.Security.Claims.ClaimsIdentity actor)
		{
			if (actor == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("actor");
			}
			if (actor.BootstrapContext != null)
			{
				string text = actor.BootstrapContext as string;
				if (text != null)
				{
					global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose("IDX12713: Creating actor value using actor.BootstrapContext(as string)", new object[0]);
					return text;
				}
				global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtSecurityToken = actor.BootstrapContext as global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken;
				if (jwtSecurityToken != null)
				{
					if (jwtSecurityToken.RawData != null)
					{
						global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose("IDX12714: Creating actor value using actor.BootstrapContext.rawData", new object[0]);
						return jwtSecurityToken.RawData;
					}
					global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose("IDX12715: Creating actor value by writing the JwtSecurityToken created from actor.BootstrapContext", new object[0]);
					return this.WriteToken(jwtSecurityToken);
				}
				else
				{
					global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose("IDX12711: actor.BootstrapContext is not a string AND actor.BootstrapContext is not a JWT", new object[0]);
				}
			}
			global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose("IDX12712: actor.BootstrapContext is null. Creating the token using actor.Claims.", new object[0]);
			return this.WriteToken(new global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken(null, null, actor.Claims, null, null, null));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005438 File Offset: 0x00003638
		protected virtual void ValidateAudience(global::System.Collections.Generic.IEnumerable<string> audiences, global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::Microsoft.IdentityModel.Tokens.Validators.ValidateAudience(audiences, jwtToken, validationParameters);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005442 File Offset: 0x00003642
		protected virtual void ValidateLifetime(global::System.DateTime? notBefore, global::System.DateTime? expires, global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::Microsoft.IdentityModel.Tokens.Validators.ValidateLifetime(notBefore, expires, jwtToken, validationParameters);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000544E File Offset: 0x0000364E
		protected virtual string ValidateIssuer(string issuer, global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			return global::Microsoft.IdentityModel.Tokens.Validators.ValidateIssuer(issuer, jwtToken, validationParameters);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005458 File Offset: 0x00003658
		protected virtual void ValidateTokenReplay(global::System.DateTime? expires, string securityToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::Microsoft.IdentityModel.Tokens.Validators.ValidateTokenReplay(expires, securityToken, validationParameters);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005464 File Offset: 0x00003664
		protected virtual global::Microsoft.IdentityModel.Tokens.SecurityKey ResolveIssuerSigningKey(string token, global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (validationParameters == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("validationParameters");
			}
			if (jwtToken == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("jwtToken");
			}
			if (!string.IsNullOrEmpty(jwtToken.Header.Kid))
			{
				string kid = jwtToken.Header.Kid;
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
			if (!string.IsNullOrEmpty(jwtToken.Header.X5t))
			{
				string x5t = jwtToken.Header.X5t;
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
						if (securityKey2 != null && string.Equals(securityKey2.KeyId, x5t, global::System.StringComparison.Ordinal))
						{
							return securityKey2;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00005620 File Offset: 0x00003820
		protected virtual global::Microsoft.IdentityModel.Tokens.SecurityKey ResolveTokenDecryptionKey(string token, global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (jwtToken == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("jwtToken");
			}
			if (validationParameters == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("validationParameters");
			}
			if (!string.IsNullOrEmpty(jwtToken.Header.Kid))
			{
				if (validationParameters.TokenDecryptionKey != null && string.Equals(validationParameters.TokenDecryptionKey.KeyId, jwtToken.Header.Kid, (validationParameters.TokenDecryptionKey is global::Microsoft.IdentityModel.Tokens.X509SecurityKey) ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal))
				{
					return validationParameters.TokenDecryptionKey;
				}
				if (validationParameters.TokenDecryptionKeys != null)
				{
					foreach (global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey in validationParameters.TokenDecryptionKeys)
					{
						if (securityKey != null && string.Equals(securityKey.KeyId, jwtToken.Header.Kid, (securityKey is global::Microsoft.IdentityModel.Tokens.X509SecurityKey) ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal))
						{
							return securityKey;
						}
					}
				}
				if (string.IsNullOrEmpty(jwtToken.Header.X5t))
				{
					goto IL_1DE;
				}
				if (validationParameters.TokenDecryptionKey != null)
				{
					if (string.Equals(validationParameters.TokenDecryptionKey.KeyId, jwtToken.Header.X5t, (validationParameters.TokenDecryptionKey is global::Microsoft.IdentityModel.Tokens.X509SecurityKey) ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal))
					{
						return validationParameters.TokenDecryptionKey;
					}
					global::Microsoft.IdentityModel.Tokens.X509SecurityKey x509SecurityKey = validationParameters.TokenDecryptionKey as global::Microsoft.IdentityModel.Tokens.X509SecurityKey;
					if (x509SecurityKey != null && string.Equals(x509SecurityKey.X5t, jwtToken.Header.X5t, global::System.StringComparison.OrdinalIgnoreCase))
					{
						return validationParameters.TokenDecryptionKey;
					}
				}
				if (validationParameters.TokenDecryptionKeys != null)
				{
					foreach (global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey2 in validationParameters.TokenDecryptionKeys)
					{
						if (securityKey2 != null && string.Equals(securityKey2.KeyId, jwtToken.Header.X5t, (securityKey2 is global::Microsoft.IdentityModel.Tokens.X509SecurityKey) ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal))
						{
							return securityKey2;
						}
						global::Microsoft.IdentityModel.Tokens.X509SecurityKey x509SecurityKey2 = securityKey2 as global::Microsoft.IdentityModel.Tokens.X509SecurityKey;
						if (x509SecurityKey2 != null && string.Equals(x509SecurityKey2.X5t, jwtToken.Header.X5t, global::System.StringComparison.OrdinalIgnoreCase))
						{
							return securityKey2;
						}
					}
				}
			}
			IL_1DE:
			return null;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000582C File Offset: 0x00003A2C
		private string DecryptToken(global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken, global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory cryptoProviderFactory, global::Microsoft.IdentityModel.Tokens.SecurityKey key)
		{
			global::Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider authenticatedEncryptionProvider = cryptoProviderFactory.CreateAuthenticatedEncryptionProvider(key, jwtToken.Header.Enc);
			if (authenticatedEncryptionProvider == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10610: Decryption failed. Could not create decryption provider. Key: '{0}', Algorithm: '{1}'.", new object[]
				{
					key,
					jwtToken.Header.Enc
				})));
			}
			return global::System.Text.Encoding.UTF8.GetString(authenticatedEncryptionProvider.Decrypt(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(jwtToken.RawCiphertext), global::System.Text.Encoding.ASCII.GetBytes(jwtToken.RawHeader), global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(jwtToken.RawInitializationVector), global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(jwtToken.RawAuthenticationTag)));
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000058C0 File Offset: 0x00003AC0
		protected string DecryptToken(global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (jwtToken == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("jwtToken");
			}
			if (validationParameters == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("validationParameters");
			}
			if (string.IsNullOrEmpty(jwtToken.Header.Enc))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10612: Decryption failed. Header.Enc is null or empty, it must be specified.", new object[0])));
			}
			global::System.Collections.Generic.IEnumerable<global::Microsoft.IdentityModel.Tokens.SecurityKey> contentEncryptionKeys = this.GetContentEncryptionKeys(jwtToken, validationParameters);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
			foreach (global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey in contentEncryptionKeys)
			{
				global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory cryptoProviderFactory = validationParameters.CryptoProviderFactory ?? securityKey.CryptoProviderFactory;
				if (cryptoProviderFactory == null)
				{
					global::Microsoft.IdentityModel.Logging.LogHelper.LogWarning("IDX10607: Decryption skipping key: '{0}', both validationParameters.CryptoProviderFactory and key.CryptoProviderFactory are null.", new object[]
					{
						securityKey
					});
				}
				else if (!cryptoProviderFactory.IsSupportedAlgorithm(jwtToken.Header.Enc, securityKey))
				{
					global::Microsoft.IdentityModel.Logging.LogHelper.LogWarning("IDX10611: Decryption failed. Encryption is not supported for: Algorithm: '{0}', SecurityKey: '{1}'.", new object[]
					{
						jwtToken.Header.Enc,
						securityKey
					});
				}
				else
				{
					try
					{
						return this.DecryptToken(jwtToken, cryptoProviderFactory, securityKey);
					}
					catch (global::System.Exception ex)
					{
						stringBuilder.AppendLine(ex.ToString());
					}
					if (securityKey != null)
					{
						stringBuilder2.AppendLine(securityKey.ToString());
					}
				}
			}
			if (stringBuilder2.Length > 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenDecryptionFailedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10603: Decryption failed. Keys tried: '{0}'.\nExceptions caught:\n '{1}'.\ntoken: '{2}'", new object[]
				{
					stringBuilder2,
					stringBuilder,
					jwtToken.RawData
				})));
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenDecryptionFailedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10609: Decryption failed. No Keys tried: token: '{0}'.", new object[]
			{
				jwtToken.RawData
			})));
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00005A64 File Offset: 0x00003C64
		private global::System.Collections.Generic.IEnumerable<global::Microsoft.IdentityModel.Tokens.SecurityKey> GetContentEncryptionKeys(global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwtToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::System.Collections.Generic.IEnumerable<global::Microsoft.IdentityModel.Tokens.SecurityKey> enumerable = null;
			if (validationParameters.TokenDecryptionKeyResolver != null)
			{
				enumerable = validationParameters.TokenDecryptionKeyResolver(jwtToken.RawData, jwtToken, jwtToken.Header.Kid, validationParameters);
			}
			else
			{
				global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey = this.ResolveTokenDecryptionKey(jwtToken.RawData, jwtToken, validationParameters);
				if (securityKey != null)
				{
					enumerable = new global::System.Collections.Generic.List<global::Microsoft.IdentityModel.Tokens.SecurityKey>
					{
						securityKey
					};
				}
			}
			if (enumerable == null)
			{
				enumerable = this.GetAllDecryptionKeys(validationParameters);
			}
			if (jwtToken.Header.Alg.Equals("dir"))
			{
				return enumerable;
			}
			global::System.Collections.Generic.List<global::Microsoft.IdentityModel.Tokens.SecurityKey> list = new global::System.Collections.Generic.List<global::Microsoft.IdentityModel.Tokens.SecurityKey>();
			foreach (global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey2 in enumerable)
			{
				if (securityKey2.CryptoProviderFactory.IsSupportedAlgorithm(jwtToken.Header.Alg, securityKey2))
				{
					byte[] key = securityKey2.CryptoProviderFactory.CreateKeyWrapProviderForUnwrap(securityKey2, jwtToken.Header.Alg).UnwrapKey(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(jwtToken.RawEncryptedKey));
					list.Add(new global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(key));
				}
			}
			return list;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005B70 File Offset: 0x00003D70
		private byte[] GetSymmetricSecurityKey(global::Microsoft.IdentityModel.Tokens.SecurityKey key)
		{
			if (key == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
			}
			global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey symmetricSecurityKey = key as global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey;
			if (symmetricSecurityKey != null)
			{
				return symmetricSecurityKey.Key;
			}
			global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey = key as global::Microsoft.IdentityModel.Tokens.JsonWebKey;
			if (jsonWebKey != null && jsonWebKey.K != null)
			{
				return global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(jsonWebKey.K);
			}
			return null;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00005BBB File Offset: 0x00003DBB
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00005BC3 File Offset: 0x00003DC3
		[global::System.ComponentModel.DefaultValue(true)]
		public bool SetDefaultTimesOnTokenCreation { get; set; } = true;

		// Token: 0x060000BB RID: 187 RVA: 0x00005BCC File Offset: 0x00003DCC
		protected virtual void ValidateIssuerSecurityKey(global::Microsoft.IdentityModel.Tokens.SecurityKey key, global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken securityToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::Microsoft.IdentityModel.Tokens.Validators.ValidateIssuerSecurityKey(key, securityToken, validationParameters);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public override void WriteToken(global::System.Xml.XmlWriter writer, global::Microsoft.IdentityModel.Tokens.SecurityToken token)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000047 RID: 71
		private int _defaultTokenLifetimeInMinutes = global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler.DefaultTokenLifetimeInMinutes;

		// Token: 0x04000048 RID: 72
		private global::System.Collections.Generic.ISet<string> _inboundClaimFilter;

		// Token: 0x04000049 RID: 73
		private global::System.Collections.Generic.IDictionary<string, string> _inboundClaimTypeMap;

		// Token: 0x0400004A RID: 74
		private static string _jsonClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/json_type";

		// Token: 0x0400004B RID: 75
		private const string _namespace = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties";

		// Token: 0x0400004C RID: 76
		private global::System.Collections.Generic.IDictionary<string, string> _outboundClaimTypeMap;

		// Token: 0x0400004D RID: 77
		private global::System.Collections.Generic.IDictionary<string, string> _outboundAlgorithmMap;

		// Token: 0x0400004E RID: 78
		private static string _shortClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/ShortTypeName";

		// Token: 0x0400004F RID: 79
		private bool _mapInboundClaims = global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler.DefaultMapInboundClaims;

		// Token: 0x04000050 RID: 80
		public static readonly int DefaultTokenLifetimeInMinutes = 60;

		// Token: 0x04000051 RID: 81
		public static global::System.Collections.Generic.IDictionary<string, string> DefaultInboundClaimTypeMap = global::System.IdentityModel.Tokens.Jwt.ClaimTypeMapping.InboundClaimTypeMap;

		// Token: 0x04000052 RID: 82
		public static bool DefaultMapInboundClaims = true;

		// Token: 0x04000053 RID: 83
		public static global::System.Collections.Generic.IDictionary<string, string> DefaultOutboundClaimTypeMap = global::System.IdentityModel.Tokens.Jwt.ClaimTypeMapping.OutboundClaimTypeMap;

		// Token: 0x04000054 RID: 84
		public static global::System.Collections.Generic.ISet<string> DefaultInboundClaimFilter = global::System.IdentityModel.Tokens.Jwt.ClaimTypeMapping.InboundClaimFilter;

		// Token: 0x04000055 RID: 85
		public static global::System.Collections.Generic.IDictionary<string, string> DefaultOutboundAlgorithmMap;

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x060000BE RID: 190
		private delegate bool CertMatcher(global::System.Security.Cryptography.X509Certificates.X509Certificate2 cert);
	}
}
