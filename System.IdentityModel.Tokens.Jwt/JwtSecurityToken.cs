using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;

namespace System.IdentityModel.Tokens.Jwt
{
	// Token: 0x0200000C RID: 12
	public class JwtSecurityToken : global::Microsoft.IdentityModel.Tokens.SecurityToken
	{
		// Token: 0x06000053 RID: 83 RVA: 0x0000358C File Offset: 0x0000178C
		public JwtSecurityToken(string jwtEncodedString)
		{
			if (string.IsNullOrWhiteSpace(jwtEncodedString))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("jwtEncodedString");
			}
			string[] array = jwtEncodedString.Split(new char[]
			{
				'.'
			}, 6);
			if (array.Length == 3)
			{
				if (!global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.RegexJws.IsMatch(jwtEncodedString))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12739: JWT: '{0}' has three segments but is not in proper JWS format.", new object[]
					{
						jwtEncodedString
					})));
				}
			}
			else
			{
				if (array.Length != 5)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12741: JWT: '{0}' must have three segments (JWS) or five segments (JWE).", new object[]
					{
						jwtEncodedString
					})));
				}
				if (!global::Microsoft.IdentityModel.JsonWebTokens.JwtTokenUtilities.RegexJwe.IsMatch(jwtEncodedString))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12740: JWT: '{0}' has five segments but is not in proper JWE format.", new object[]
					{
						jwtEncodedString
					})));
				}
			}
			this.Decode(array, jwtEncodedString);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003650 File Offset: 0x00001850
		public JwtSecurityToken(global::System.IdentityModel.Tokens.Jwt.JwtHeader header, global::System.IdentityModel.Tokens.Jwt.JwtPayload payload, string rawHeader, string rawPayload, string rawSignature)
		{
			if (header == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("header");
			}
			if (payload == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("payload");
			}
			if (string.IsNullOrWhiteSpace(rawHeader))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("rawHeader");
			}
			if (string.IsNullOrWhiteSpace(rawPayload))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("rawPayload");
			}
			if (rawSignature == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("rawSignature");
			}
			this.Header = header;
			this.Payload = payload;
			this.RawData = string.Concat(new string[]
			{
				rawHeader,
				".",
				rawPayload,
				".",
				rawSignature
			});
			this.RawHeader = rawHeader;
			this.RawPayload = rawPayload;
			this.RawSignature = rawSignature;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000370C File Offset: 0x0000190C
		public JwtSecurityToken(global::System.IdentityModel.Tokens.Jwt.JwtHeader header, global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken innerToken, string rawHeader, string rawEncryptedKey, string rawInitializationVector, string rawCiphertext, string rawAuthenticationTag)
		{
			if (header == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("header");
			}
			if (innerToken == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("innerToken");
			}
			if (rawEncryptedKey == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("rawEncryptedKey");
			}
			if (string.IsNullOrEmpty(rawInitializationVector))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("rawInitializationVector");
			}
			if (string.IsNullOrEmpty(rawCiphertext))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("rawCiphertext");
			}
			if (string.IsNullOrEmpty(rawAuthenticationTag))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("rawAuthenticationTag");
			}
			this.Header = header;
			this.InnerToken = innerToken;
			this.RawData = string.Join(".", new string[]
			{
				rawHeader,
				rawEncryptedKey,
				rawInitializationVector,
				rawCiphertext,
				rawAuthenticationTag
			});
			this.RawHeader = rawHeader;
			this.RawEncryptedKey = rawEncryptedKey;
			this.RawInitializationVector = rawInitializationVector;
			this.RawCiphertext = rawCiphertext;
			this.RawAuthenticationTag = rawAuthenticationTag;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000037E9 File Offset: 0x000019E9
		public JwtSecurityToken(global::System.IdentityModel.Tokens.Jwt.JwtHeader header, global::System.IdentityModel.Tokens.Jwt.JwtPayload payload)
		{
			if (header == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("header");
			}
			if (payload == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("payload");
			}
			this.Header = header;
			this.Payload = payload;
			this.RawSignature = string.Empty;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003828 File Offset: 0x00001A28
		public JwtSecurityToken(string issuer = null, string audience = null, global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> claims = null, global::System.DateTime? notBefore = null, global::System.DateTime? expires = null, global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials = null)
		{
			if (expires != null && notBefore != null && notBefore >= expires)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12401: Expires: '{0}' must be after NotBefore: '{1}'.", new object[]
				{
					expires.Value,
					notBefore.Value
				})));
			}
			this.Payload = new global::System.IdentityModel.Tokens.Jwt.JwtPayload(issuer, audience, claims, notBefore, expires);
			this.Header = new global::System.IdentityModel.Tokens.Jwt.JwtHeader(signingCredentials);
			this.RawSignature = string.Empty;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000038DF File Offset: 0x00001ADF
		public string Actor
		{
			get
			{
				if (this.Payload != null)
				{
					return this.Payload.Actort;
				}
				return string.Empty;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000038FA File Offset: 0x00001AFA
		public global::System.Collections.Generic.IEnumerable<string> Audiences
		{
			get
			{
				if (this.Payload != null)
				{
					return this.Payload.Aud;
				}
				return new global::System.Collections.Generic.List<string>();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003915 File Offset: 0x00001B15
		public global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> Claims
		{
			get
			{
				if (this.Payload != null)
				{
					return this.Payload.Claims;
				}
				return new global::System.Collections.Generic.List<global::System.Security.Claims.Claim>();
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00003930 File Offset: 0x00001B30
		public virtual string EncodedHeader
		{
			get
			{
				return this.Header.Base64UrlEncode();
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000393D File Offset: 0x00001B3D
		public virtual string EncodedPayload
		{
			get
			{
				if (this.Payload != null)
				{
					return this.Payload.Base64UrlEncode();
				}
				return string.Empty;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00003958 File Offset: 0x00001B58
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00003960 File Offset: 0x00001B60
		public global::System.IdentityModel.Tokens.Jwt.JwtHeader Header { get; internal set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00003969 File Offset: 0x00001B69
		public override string Id
		{
			get
			{
				if (this.Payload != null)
				{
					return this.Payload.Jti;
				}
				return string.Empty;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00003984 File Offset: 0x00001B84
		public override string Issuer
		{
			get
			{
				if (this.Payload != null)
				{
					return this.Payload.Iss;
				}
				return string.Empty;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000399F File Offset: 0x00001B9F
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000039BB File Offset: 0x00001BBB
		public global::System.IdentityModel.Tokens.Jwt.JwtPayload Payload
		{
			get
			{
				if (this.InnerToken != null)
				{
					return this.InnerToken.Payload;
				}
				return this._payload;
			}
			internal set
			{
				this._payload = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000039C4 File Offset: 0x00001BC4
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000039CC File Offset: 0x00001BCC
		public global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken InnerToken { get; internal set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000039D5 File Offset: 0x00001BD5
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000039DD File Offset: 0x00001BDD
		public string RawAuthenticationTag { get; private set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000039E6 File Offset: 0x00001BE6
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000039EE File Offset: 0x00001BEE
		public string RawCiphertext { get; private set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000039F7 File Offset: 0x00001BF7
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000039FF File Offset: 0x00001BFF
		public string RawData { get; private set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00003A08 File Offset: 0x00001C08
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00003A10 File Offset: 0x00001C10
		public string RawEncryptedKey { get; private set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00003A19 File Offset: 0x00001C19
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00003A21 File Offset: 0x00001C21
		public string RawInitializationVector { get; private set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003A2A File Offset: 0x00001C2A
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00003A32 File Offset: 0x00001C32
		public string RawHeader { get; internal set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00003A3B File Offset: 0x00001C3B
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00003A43 File Offset: 0x00001C43
		public string RawPayload { get; internal set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003A4C File Offset: 0x00001C4C
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00003A54 File Offset: 0x00001C54
		public string RawSignature { get; internal set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00003A5D File Offset: 0x00001C5D
		public override global::Microsoft.IdentityModel.Tokens.SecurityKey SecurityKey
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00003A60 File Offset: 0x00001C60
		public string SignatureAlgorithm
		{
			get
			{
				return this.Header.Alg;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003A6D File Offset: 0x00001C6D
		public global::Microsoft.IdentityModel.Tokens.SigningCredentials SigningCredentials
		{
			get
			{
				return this.Header.SigningCredentials;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00003A7A File Offset: 0x00001C7A
		public global::Microsoft.IdentityModel.Tokens.EncryptingCredentials EncryptingCredentials
		{
			get
			{
				return this.Header.EncryptingCredentials;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00003A87 File Offset: 0x00001C87
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00003A8F File Offset: 0x00001C8F
		public override global::Microsoft.IdentityModel.Tokens.SecurityKey SigningKey { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00003A98 File Offset: 0x00001C98
		public string Subject
		{
			get
			{
				if (this.Payload != null)
				{
					return this.Payload.Sub;
				}
				return string.Empty;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003AB3 File Offset: 0x00001CB3
		public override global::System.DateTime ValidFrom
		{
			get
			{
				if (this.Payload != null)
				{
					return this.Payload.ValidFrom;
				}
				return global::System.DateTime.MinValue;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00003ACE File Offset: 0x00001CCE
		public override global::System.DateTime ValidTo
		{
			get
			{
				if (this.Payload != null)
				{
					return this.Payload.ValidTo;
				}
				return global::System.DateTime.MinValue;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003AE9 File Offset: 0x00001CE9
		public override string ToString()
		{
			if (this.Payload != null)
			{
				return this.Header.SerializeToJson() + "." + this.Payload.SerializeToJson();
			}
			return this.Header.SerializeToJson() + ".";
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003B2C File Offset: 0x00001D2C
		internal void Decode(string[] tokenParts, string rawData)
		{
			global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX12716: Decoding token: '{0}' into header, payload and signature.", new object[]
			{
				rawData
			});
			try
			{
				this.Header = global::System.IdentityModel.Tokens.Jwt.JwtHeader.Base64UrlDeserialize(tokenParts[0]);
			}
			catch (global::System.Exception innerException)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12729: Unable to decode the header '{0}' as Base64Url encoded string. jwtEncodedString: '{1}'.", new object[]
				{
					tokenParts[0],
					rawData
				}), innerException));
			}
			if (tokenParts.Length == 5)
			{
				this.DecodeJwe(tokenParts);
			}
			else
			{
				this.DecodeJws(tokenParts);
			}
			this.RawData = rawData;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003BB4 File Offset: 0x00001DB4
		private void DecodeJws(string[] tokenParts)
		{
			if (this.Header.Cty != null)
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12738: Header.Cty != null, assuming JWS. Cty: '{0}'.", new object[]
				{
					this.Header.Cty
				}), new object[0]);
			}
			try
			{
				this.Payload = global::System.IdentityModel.Tokens.Jwt.JwtPayload.Base64UrlDeserialize(tokenParts[1]);
			}
			catch (global::System.Exception innerException)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12723: Unable to decode the payload '{0}' as Base64Url encoded string. jwtEncodedString: '{1}'.", new object[]
				{
					tokenParts[1],
					this.RawData
				}), innerException));
			}
			this.RawHeader = tokenParts[0];
			this.RawPayload = tokenParts[1];
			this.RawSignature = tokenParts[2];
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003C60 File Offset: 0x00001E60
		private void DecodeJwe(string[] tokenParts)
		{
			this.RawHeader = tokenParts[0];
			this.RawEncryptedKey = tokenParts[1];
			this.RawInitializationVector = tokenParts[2];
			this.RawCiphertext = tokenParts[3];
			this.RawAuthenticationTag = tokenParts[4];
		}

		// Token: 0x0400003B RID: 59
		private global::System.IdentityModel.Tokens.Jwt.JwtPayload _payload;
	}
}
