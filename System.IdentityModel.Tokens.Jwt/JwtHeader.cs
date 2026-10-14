using System;
using System.Collections.Generic;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;

namespace System.IdentityModel.Tokens.Jwt
{
	// Token: 0x02000008 RID: 8
	public class JwtHeader : global::System.Collections.Generic.Dictionary<string, object>
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002657 File Offset: 0x00000857
		public JwtHeader() : base(global::System.StringComparer.Ordinal)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002664 File Offset: 0x00000864
		public JwtHeader(global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials) : this(signingCredentials, null)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000266E File Offset: 0x0000086E
		public JwtHeader(global::Microsoft.IdentityModel.Tokens.EncryptingCredentials encryptingCredentials) : this(encryptingCredentials, null)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002678 File Offset: 0x00000878
		public JwtHeader(global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials, global::System.Collections.Generic.IDictionary<string, string> outboundAlgorithmMap) : base(global::System.StringComparer.Ordinal)
		{
			if (signingCredentials == null)
			{
				base["alg"] = "none";
			}
			else
			{
				string alg;
				if (outboundAlgorithmMap != null && outboundAlgorithmMap.TryGetValue(signingCredentials.Algorithm, out alg))
				{
					this.Alg = alg;
				}
				else
				{
					this.Alg = signingCredentials.Algorithm;
				}
				if (!string.IsNullOrEmpty(signingCredentials.Key.KeyId))
				{
					this.Kid = signingCredentials.Key.KeyId;
				}
				global::Microsoft.IdentityModel.Tokens.X509SigningCredentials x509SigningCredentials;
				if ((x509SigningCredentials = (signingCredentials as global::Microsoft.IdentityModel.Tokens.X509SigningCredentials)) != null)
				{
					base["x5t"] = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(x509SigningCredentials.Certificate.GetCertHash());
				}
			}
			this.Typ = "JWT";
			this.SigningCredentials = signingCredentials;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002728 File Offset: 0x00000928
		public JwtHeader(global::Microsoft.IdentityModel.Tokens.EncryptingCredentials encryptingCredentials, global::System.Collections.Generic.IDictionary<string, string> outboundAlgorithmMap) : base(global::System.StringComparer.Ordinal)
		{
			if (encryptingCredentials == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("encryptingCredentials");
			}
			string text;
			if (outboundAlgorithmMap != null && outboundAlgorithmMap.TryGetValue(encryptingCredentials.Alg, out text))
			{
				this.Alg = text;
			}
			else
			{
				this.Alg = encryptingCredentials.Alg;
			}
			if (outboundAlgorithmMap != null && outboundAlgorithmMap.TryGetValue(encryptingCredentials.Enc, out text))
			{
				this.Enc = text;
			}
			else
			{
				this.Enc = encryptingCredentials.Enc;
			}
			if (!string.IsNullOrEmpty(encryptingCredentials.Key.KeyId))
			{
				this.Kid = encryptingCredentials.Key.KeyId;
			}
			this.Typ = "JWT";
			this.EncryptingCredentials = encryptingCredentials;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000027D3 File Offset: 0x000009D3
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000027E0 File Offset: 0x000009E0
		public string Alg
		{
			get
			{
				return this.GetStandardClaim("alg");
			}
			private set
			{
				base["alg"] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000027EE File Offset: 0x000009EE
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000027FB File Offset: 0x000009FB
		public string Cty
		{
			get
			{
				return this.GetStandardClaim("cty");
			}
			private set
			{
				base["cty"] = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002809 File Offset: 0x00000A09
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002816 File Offset: 0x00000A16
		public string Enc
		{
			get
			{
				return this.GetStandardClaim("enc");
			}
			private set
			{
				base["enc"] = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002824 File Offset: 0x00000A24
		// (set) Token: 0x06000022 RID: 34 RVA: 0x0000282C File Offset: 0x00000A2C
		public global::Microsoft.IdentityModel.Tokens.EncryptingCredentials EncryptingCredentials { get; private set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002835 File Offset: 0x00000A35
		public string IV
		{
			get
			{
				return this.GetStandardClaim("iv");
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002842 File Offset: 0x00000A42
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000284F File Offset: 0x00000A4F
		public string Kid
		{
			get
			{
				return this.GetStandardClaim("kid");
			}
			private set
			{
				base["kid"] = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000285D File Offset: 0x00000A5D
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002865 File Offset: 0x00000A65
		public global::Microsoft.IdentityModel.Tokens.SigningCredentials SigningCredentials { get; private set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000286E File Offset: 0x00000A6E
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000287B File Offset: 0x00000A7B
		public string Typ
		{
			get
			{
				return this.GetStandardClaim("typ");
			}
			private set
			{
				base["typ"] = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002889 File Offset: 0x00000A89
		public string X5t
		{
			get
			{
				return this.GetStandardClaim("x5t");
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002896 File Offset: 0x00000A96
		public static global::System.IdentityModel.Tokens.Jwt.JwtHeader Base64UrlDeserialize(string base64UrlEncodedJsonString)
		{
			return global::System.IdentityModel.Tokens.Jwt.JsonExtensions.DeserializeJwtHeader(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Decode(base64UrlEncodedJsonString));
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000028A3 File Offset: 0x00000AA3
		public virtual string Base64UrlEncode()
		{
			return global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(this.SerializeToJson());
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000028B0 File Offset: 0x00000AB0
		public static global::System.IdentityModel.Tokens.Jwt.JwtHeader Deserialize(string jsonString)
		{
			return global::System.IdentityModel.Tokens.Jwt.JsonExtensions.DeserializeJwtHeader(jsonString);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000028B8 File Offset: 0x00000AB8
		internal string GetStandardClaim(string claimType)
		{
			object obj;
			if (!base.TryGetValue(claimType, out obj))
			{
				return null;
			}
			if (obj == null)
			{
				return null;
			}
			string result;
			if ((result = (obj as string)) != null)
			{
				return result;
			}
			return global::System.IdentityModel.Tokens.Jwt.JsonExtensions.SerializeToJson(obj);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000028E9 File Offset: 0x00000AE9
		public virtual string SerializeToJson()
		{
			return global::System.IdentityModel.Tokens.Jwt.JsonExtensions.SerializeToJson(this);
		}
	}
}
