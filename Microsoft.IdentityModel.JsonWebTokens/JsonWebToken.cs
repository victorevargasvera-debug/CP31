using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Claims;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.IdentityModel.JsonWebTokens
{
	// Token: 0x02000003 RID: 3
	public class JsonWebToken : global::Microsoft.IdentityModel.Tokens.SecurityToken
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public JsonWebToken(string jwtEncodedString)
		{
			if (string.IsNullOrEmpty(jwtEncodedString))
			{
				throw new global::System.ArgumentNullException("jwtEncodedString");
			}
			int num = 1;
			int num2 = -1;
			while ((num2 = jwtEncodedString.IndexOf('.', num2 + 1)) != -1)
			{
				num++;
				if (num >= 3)
				{
					break;
				}
			}
			if (num == 3)
			{
				string[] tokenParts = jwtEncodedString.Split(new char[]
				{
					'.'
				});
				this.Decode(tokenParts, jwtEncodedString);
				return;
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX14100: JWT is not well formed: '{0}'.\nThe token needs to be in JWS or JWE Compact Serialization Format. (JWS): 'EncodedHeader.EndcodedPayload.EncodedSignature'. (JWE): 'EncodedProtectedHeader.EncodedEncryptedKey.EncodedInitializationVector.EncodedCiphertext.EncodedAuthenticationTag'.", new object[]
			{
				jwtEncodedString
			})));
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020D1 File Offset: 0x000002D1
		public JsonWebToken(global::Newtonsoft.Json.Linq.JObject header, global::Newtonsoft.Json.Linq.JObject payload)
		{
			if (header == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("header");
			}
			this.Header = header;
			if (payload == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("payload");
			}
			this.Payload = payload;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002105 File Offset: 0x00000305
		public string Actor
		{
			get
			{
				return this.Payload.Value<string>("actort") ?? string.Empty;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002120 File Offset: 0x00000320
		public string Alg
		{
			get
			{
				return this.Header.Value<string>("alg") ?? string.Empty;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000213C File Offset: 0x0000033C
		public global::System.Collections.Generic.IEnumerable<string> Audiences
		{
			get
			{
				if (this.Payload != null)
				{
					global::Newtonsoft.Json.Linq.JToken value = this.Payload.GetValue("aud");
					if (object.Equals(global::Newtonsoft.Json.Linq.JTokenType.String, value.Type))
					{
						return new global::System.Collections.Generic.List<string>
						{
							value.ToObject<string>()
						};
					}
					if (object.Equals(global::Newtonsoft.Json.Linq.JTokenType.Array, value.Type))
					{
						return value.ToObject<global::System.Collections.Generic.List<string>>();
					}
				}
				return new global::System.Collections.Generic.List<string>();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000021B0 File Offset: 0x000003B0
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> Claims
		{
			get
			{
				global::System.Collections.Generic.List<global::System.Security.Claims.Claim> list = new global::System.Collections.Generic.List<global::System.Security.Claims.Claim>();
				string text = this.Issuer ?? "LOCAL AUTHORITY";
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken> keyValuePair in this.Payload)
				{
					if (keyValuePair.Value == null)
					{
						list.Add(new global::System.Security.Claims.Claim(keyValuePair.Key, string.Empty, "JSON_NULL", text, text));
					}
					else if (object.Equals(global::Newtonsoft.Json.Linq.JTokenType.String, keyValuePair.Value.Type))
					{
						string value = keyValuePair.Value.ToObject<string>();
						list.Add(new global::System.Security.Claims.Claim(keyValuePair.Key, value, "http://www.w3.org/2001/XMLSchema#string", text, text));
					}
					else
					{
						global::Newtonsoft.Json.Linq.JToken value2 = keyValuePair.Value;
						if (value2 != null)
						{
							this.AddClaimsFromJToken(list, keyValuePair.Key, value2, text);
						}
					}
				}
				return list;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000022A4 File Offset: 0x000004A4
		public string Cty
		{
			get
			{
				return this.Header.Value<string>("cty") ?? string.Empty;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000022BF File Offset: 0x000004BF
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000022C7 File Offset: 0x000004C7
		public global::Newtonsoft.Json.Linq.JObject Header { get; private set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000022D0 File Offset: 0x000004D0
		public override string Id
		{
			get
			{
				return this.Payload.Value<string>("jti") ?? string.Empty;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000022EB File Offset: 0x000004EB
		public global::System.DateTime IssuedAt
		{
			get
			{
				return this.GetDateTime("iat");
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000022F8 File Offset: 0x000004F8
		public override string Issuer
		{
			get
			{
				return this.Payload.Value<string>("iss") ?? string.Empty;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002313 File Offset: 0x00000513
		public string Kid
		{
			get
			{
				return this.Header.Value<string>("kid") ?? string.Empty;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000232E File Offset: 0x0000052E
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002336 File Offset: 0x00000536
		public global::Newtonsoft.Json.Linq.JObject Payload { get; private set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000233F File Offset: 0x0000053F
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002347 File Offset: 0x00000547
		public string EncodedToken { get; private set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002350 File Offset: 0x00000550
		public override global::Microsoft.IdentityModel.Tokens.SecurityKey SecurityKey { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002361 File Offset: 0x00000561
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002358 File Offset: 0x00000558
		public override global::Microsoft.IdentityModel.Tokens.SecurityKey SigningKey { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002369 File Offset: 0x00000569
		public string Subject
		{
			get
			{
				return this.Payload.Value<string>("sub") ?? string.Empty;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002384 File Offset: 0x00000584
		public string Typ
		{
			get
			{
				return this.Header.Value<string>("typ") ?? string.Empty;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0000239F File Offset: 0x0000059F
		public override global::System.DateTime ValidFrom
		{
			get
			{
				return this.GetDateTime("nbf");
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000023AC File Offset: 0x000005AC
		public override global::System.DateTime ValidTo
		{
			get
			{
				return this.GetDateTime("exp");
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000023B9 File Offset: 0x000005B9
		public string X5t
		{
			get
			{
				return this.Header.Value<string>("x5t") ?? string.Empty;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000023D4 File Offset: 0x000005D4
		private void Decode(string[] tokenParts, string rawData)
		{
			global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX14106: Decoding token: '{0}' into header, payload and signature.", new object[]
			{
				rawData
			});
			global::Newtonsoft.Json.Linq.JObject header;
			if (!global::Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenManager.RawHeaderToJObjectCache.TryGetValue(tokenParts[0], out header))
			{
				try
				{
					this.Header = global::Newtonsoft.Json.Linq.JObject.Parse(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Decode(tokenParts[0]));
					global::Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenManager.RawHeaderToJObjectCache.TryAdd(tokenParts[0], this.Header);
					goto IL_7C;
				}
				catch (global::System.Exception innerException)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX14102: Unable to decode the header '{0}' as Base64Url encoded string. jwtEncodedString: '{1}'.", new object[]
					{
						tokenParts[0],
						rawData
					}), innerException));
				}
			}
			this.Header = header;
			IL_7C:
			this.DecodeJws(tokenParts);
			this.EncodedToken = rawData;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000247C File Offset: 0x0000067C
		private void AddClaimsFromJToken(global::System.Collections.Generic.List<global::System.Security.Claims.Claim> claims, string claimType, global::Newtonsoft.Json.Linq.JToken jtoken, string issuer)
		{
			if (object.Equals(global::Newtonsoft.Json.Linq.JTokenType.Object, jtoken.Type))
			{
				claims.Add(new global::System.Security.Claims.Claim(claimType, jtoken.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0]), "JSON", issuer, issuer));
				return;
			}
			if (object.Equals(global::Newtonsoft.Json.Linq.JTokenType.Array, jtoken.Type))
			{
				using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = (jtoken as global::Newtonsoft.Json.Linq.JArray).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Newtonsoft.Json.Linq.JToken jtoken2 = enumerator.Current;
						global::Newtonsoft.Json.Linq.JTokenType type = jtoken2.Type;
						if (type != global::Newtonsoft.Json.Linq.JTokenType.Object)
						{
							if (type != global::Newtonsoft.Json.Linq.JTokenType.Array)
							{
								this.AddDefaultClaimFromJToken(claims, claimType, jtoken2, issuer);
							}
							else
							{
								claims.Add(new global::System.Security.Claims.Claim(claimType, jtoken2.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0]), "JSON_ARRAY", issuer, issuer));
							}
						}
						else
						{
							claims.Add(new global::System.Security.Claims.Claim(claimType, jtoken2.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0]), "JSON", issuer, issuer));
						}
					}
					return;
				}
			}
			this.AddDefaultClaimFromJToken(claims, claimType, jtoken, issuer);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002588 File Offset: 0x00000788
		private void AddDefaultClaimFromJToken(global::System.Collections.Generic.List<global::System.Security.Claims.Claim> claims, string claimType, global::Newtonsoft.Json.Linq.JToken jtoken, string issuer)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = jtoken as global::Newtonsoft.Json.Linq.JValue;
			if (jvalue == null)
			{
				claims.Add(new global::System.Security.Claims.Claim(claimType, jtoken.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0]), global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken.GetClaimValueType(jtoken), issuer, issuer));
				return;
			}
			if (object.Equals(global::Newtonsoft.Json.Linq.JTokenType.String, jvalue.Type))
			{
				claims.Add(new global::System.Security.Claims.Claim(claimType, jvalue.Value.ToString(), "http://www.w3.org/2001/XMLSchema#string", issuer, issuer));
				return;
			}
			claims.Add(new global::System.Security.Claims.Claim(claimType, jtoken.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0]), global::Microsoft.IdentityModel.JsonWebTokens.JsonWebToken.GetClaimValueType(jvalue.Value), issuer, issuer));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002624 File Offset: 0x00000824
		private void DecodeJws(string[] tokenParts)
		{
			if (this.Cty != string.Empty)
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX14105: Header.Cty != null, assuming JWS. Cty: '{0}'.", new object[]
				{
					this.Payload.Value<string>("cty")
				}), new object[0]);
			}
			try
			{
				this.Payload = global::Newtonsoft.Json.Linq.JObject.Parse(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Decode(tokenParts[1]));
			}
			catch (global::System.Exception innerException)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX14101: Unable to decode the payload '{0}' as Base64Url encoded string. jwtEncodedString: '{1}'.", new object[]
				{
					tokenParts[1],
					this.EncodedToken
				}), innerException));
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000026C4 File Offset: 0x000008C4
		private static string GetClaimValueType(object obj)
		{
			if (obj == null)
			{
				return "JSON_NULL";
			}
			global::System.Type type = obj.GetType();
			if (type == typeof(string))
			{
				return "http://www.w3.org/2001/XMLSchema#string";
			}
			if (type == typeof(int))
			{
				return "http://www.w3.org/2001/XMLSchema#integer";
			}
			if (type == typeof(bool))
			{
				return "http://www.w3.org/2001/XMLSchema#boolean";
			}
			if (type == typeof(double))
			{
				return "http://www.w3.org/2001/XMLSchema#double";
			}
			if (type == typeof(long))
			{
				long num = (long)obj;
				if (num >= -2147483648L && num <= 2147483647L)
				{
					return "http://www.w3.org/2001/XMLSchema#integer";
				}
				return "http://www.w3.org/2001/XMLSchema#integer64";
			}
			else
			{
				if (type == typeof(global::Newtonsoft.Json.Linq.JObject))
				{
					return "JSON";
				}
				if (type == typeof(global::Newtonsoft.Json.Linq.JArray))
				{
					return "JSON_ARRAY";
				}
				return type.ToString();
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000027B0 File Offset: 0x000009B0
		private global::System.DateTime GetDateTime(string key)
		{
			global::Newtonsoft.Json.Linq.JToken jToken;
			if (!this.Payload.TryGetValue(key, out jToken))
			{
				return global::System.DateTime.MinValue;
			}
			return global::Microsoft.IdentityModel.Tokens.EpochTime.DateTime(global::System.Convert.ToInt64(global::System.Math.Truncate(global::System.Convert.ToDouble(this.ParseTimeValue(jToken, key), global::System.Globalization.CultureInfo.InvariantCulture))));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000027FC File Offset: 0x000009FC
		private long ParseTimeValue(global::Newtonsoft.Json.Linq.JToken jToken, string claimName)
		{
			if (jToken.Type == global::Newtonsoft.Json.Linq.JTokenType.Integer || jToken.Type == global::Newtonsoft.Json.Linq.JTokenType.Float)
			{
				return (long)jToken;
			}
			if (jToken.Type == global::Newtonsoft.Json.Linq.JTokenType.String)
			{
				long result;
				if (long.TryParse((string)jToken, out result))
				{
					return result;
				}
				float num;
				if (float.TryParse((string)jToken, out num))
				{
					return (long)num;
				}
				double num2;
				if (double.TryParse((string)jToken, out num2))
				{
					return (long)num2;
				}
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.FormatException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX14300: Could not parse '{0}' : '{1}' as a '{2}'.", new object[]
			{
				claimName,
				jToken.ToString(),
				typeof(long)
			})));
		}
	}
}
