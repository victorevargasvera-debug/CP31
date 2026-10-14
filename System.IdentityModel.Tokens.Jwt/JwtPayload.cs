using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Claims;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace System.IdentityModel.Tokens.Jwt
{
	// Token: 0x0200000A RID: 10
	public class JwtPayload : global::System.Collections.Generic.Dictionary<string, object>
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000028F4 File Offset: 0x00000AF4
		public JwtPayload() : this(null, null, null, null, null)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000291C File Offset: 0x00000B1C
		public JwtPayload(global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> claims) : this(null, null, claims, null, null)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002944 File Offset: 0x00000B44
		public JwtPayload(string issuer, string audience, global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> claims, global::System.DateTime? notBefore, global::System.DateTime? expires) : this(issuer, audience, claims, notBefore, expires, null)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002968 File Offset: 0x00000B68
		public JwtPayload(string issuer, string audience, global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> claims, global::System.DateTime? notBefore, global::System.DateTime? expires, global::System.DateTime? issuedAt) : base(global::System.StringComparer.Ordinal)
		{
			if (claims != null)
			{
				this.AddClaims(claims);
			}
			if (expires != null)
			{
				if (notBefore != null)
				{
					if (notBefore.Value >= expires.Value)
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12401: Expires: '{0}' must be after NotBefore: '{1}'.", new object[]
						{
							expires.Value,
							notBefore.Value
						})));
					}
					base["nbf"] = global::Microsoft.IdentityModel.Tokens.EpochTime.GetIntDate(notBefore.Value.ToUniversalTime());
				}
				base["exp"] = global::Microsoft.IdentityModel.Tokens.EpochTime.GetIntDate(expires.Value.ToUniversalTime());
			}
			if (issuedAt != null)
			{
				base["iat"] = global::Microsoft.IdentityModel.Tokens.EpochTime.GetIntDate(issuedAt.Value.ToUniversalTime());
			}
			if (!string.IsNullOrEmpty(issuer))
			{
				base["iss"] = issuer;
			}
			if (!string.IsNullOrEmpty(audience))
			{
				this.AddClaim(new global::System.Security.Claims.Claim("aud", audience, "http://www.w3.org/2001/XMLSchema#string"));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002A94 File Offset: 0x00000C94
		public string Actort
		{
			get
			{
				return this.GetStandardClaim("actort");
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public string Acr
		{
			get
			{
				return this.GetStandardClaim("acr");
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002AAE File Offset: 0x00000CAE
		public global::System.Collections.Generic.IList<string> Amr
		{
			get
			{
				return this.GetIListClaims("amr");
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002ABB File Offset: 0x00000CBB
		public int? AuthTime
		{
			get
			{
				return this.GetIntClaim("auth_time");
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002AC8 File Offset: 0x00000CC8
		public global::System.Collections.Generic.IList<string> Aud
		{
			get
			{
				return this.GetIListClaims("aud");
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002AD5 File Offset: 0x00000CD5
		public string Azp
		{
			get
			{
				return this.GetStandardClaim("azp");
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002AE2 File Offset: 0x00000CE2
		public string CHash
		{
			get
			{
				return this.GetStandardClaim("c_hash");
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002AEF File Offset: 0x00000CEF
		public int? Exp
		{
			get
			{
				return this.GetIntClaim("exp");
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002AFC File Offset: 0x00000CFC
		public string Jti
		{
			get
			{
				return this.GetStandardClaim("jti");
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002B09 File Offset: 0x00000D09
		public int? Iat
		{
			get
			{
				return this.GetIntClaim("iat");
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002B16 File Offset: 0x00000D16
		public string Iss
		{
			get
			{
				return this.GetStandardClaim("iss");
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002B23 File Offset: 0x00000D23
		public int? Nbf
		{
			get
			{
				return this.GetIntClaim("nbf");
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002B30 File Offset: 0x00000D30
		public string Nonce
		{
			get
			{
				return this.GetStandardClaim("nonce");
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002B3D File Offset: 0x00000D3D
		public string Sub
		{
			get
			{
				return this.GetStandardClaim("sub");
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002B4A File Offset: 0x00000D4A
		public global::System.DateTime ValidFrom
		{
			get
			{
				return this.GetDateTime("nbf");
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002B57 File Offset: 0x00000D57
		public global::System.DateTime ValidTo
		{
			get
			{
				return this.GetDateTime("exp");
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002B64 File Offset: 0x00000D64
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> Claims
		{
			get
			{
				global::System.Collections.Generic.List<global::System.Security.Claims.Claim> list = new global::System.Collections.Generic.List<global::System.Security.Claims.Claim>();
				string text = this.Iss ?? "LOCAL AUTHORITY";
				foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in this)
				{
					if (keyValuePair.Value == null)
					{
						list.Add(new global::System.Security.Claims.Claim(keyValuePair.Key, string.Empty, "JSON_NULL", text, text));
					}
					else
					{
						string text2 = keyValuePair.Value as string;
						if (text2 != null)
						{
							list.Add(new global::System.Security.Claims.Claim(keyValuePair.Key, text2, "http://www.w3.org/2001/XMLSchema#string", text, text));
						}
						else
						{
							global::Newtonsoft.Json.Linq.JToken jtoken = keyValuePair.Value as global::Newtonsoft.Json.Linq.JToken;
							if (jtoken != null)
							{
								this.AddClaimsFromJToken(list, keyValuePair.Key, jtoken, text);
							}
							else
							{
								global::System.Collections.Generic.IEnumerable<object> enumerable = keyValuePair.Value as global::System.Collections.Generic.IEnumerable<object>;
								if (enumerable != null)
								{
									using (global::System.Collections.Generic.IEnumerator<object> enumerator2 = enumerable.GetEnumerator())
									{
										while (enumerator2.MoveNext())
										{
											object obj = enumerator2.Current;
											text2 = (obj as string);
											if (text2 != null)
											{
												list.Add(new global::System.Security.Claims.Claim(keyValuePair.Key, text2, "http://www.w3.org/2001/XMLSchema#string", text, text));
											}
											else
											{
												jtoken = (obj as global::Newtonsoft.Json.Linq.JToken);
												if (jtoken != null)
												{
													this.AddDefaultClaimFromJToken(list, keyValuePair.Key, jtoken, text);
												}
												else
												{
													list.Add(new global::System.Security.Claims.Claim(keyValuePair.Key, global::Newtonsoft.Json.JsonConvert.SerializeObject(obj), global::System.IdentityModel.Tokens.Jwt.JwtPayload.GetClaimValueType(obj), text, text));
												}
											}
										}
										continue;
									}
								}
								global::System.Collections.Generic.IDictionary<string, object> dictionary = keyValuePair.Value as global::System.Collections.Generic.IDictionary<string, object>;
								if (dictionary != null)
								{
									using (global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> enumerator3 = dictionary.GetEnumerator())
									{
										while (enumerator3.MoveNext())
										{
											global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair2 = enumerator3.Current;
											list.Add(new global::System.Security.Claims.Claim(keyValuePair.Key, string.Concat(new string[]
											{
												"{",
												keyValuePair2.Key,
												":",
												global::Newtonsoft.Json.JsonConvert.SerializeObject(keyValuePair2.Value),
												"}"
											}), global::System.IdentityModel.Tokens.Jwt.JwtPayload.GetClaimValueType(keyValuePair2.Value), text, text));
										}
										continue;
									}
								}
								list.Add(new global::System.Security.Claims.Claim(keyValuePair.Key, global::Newtonsoft.Json.JsonConvert.SerializeObject(keyValuePair.Value), global::System.IdentityModel.Tokens.Jwt.JwtPayload.GetClaimValueType(keyValuePair.Value), text, text));
							}
						}
					}
				}
				return list;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002E04 File Offset: 0x00001004
		private void AddClaimsFromJToken(global::System.Collections.Generic.List<global::System.Security.Claims.Claim> claims, string claimType, global::Newtonsoft.Json.Linq.JToken jtoken, string issuer)
		{
			if (jtoken.Type == global::Newtonsoft.Json.Linq.JTokenType.Object)
			{
				claims.Add(new global::System.Security.Claims.Claim(claimType, jtoken.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0]), "JSON", issuer, issuer));
				return;
			}
			if (jtoken.Type == global::Newtonsoft.Json.Linq.JTokenType.Array)
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

		// Token: 0x06000046 RID: 70 RVA: 0x00002EF4 File Offset: 0x000010F4
		private void AddDefaultClaimFromJToken(global::System.Collections.Generic.List<global::System.Security.Claims.Claim> claims, string claimType, global::Newtonsoft.Json.Linq.JToken jtoken, string issuer)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = jtoken as global::Newtonsoft.Json.Linq.JValue;
			if (jvalue == null)
			{
				claims.Add(new global::System.Security.Claims.Claim(claimType, jtoken.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0]), global::System.IdentityModel.Tokens.Jwt.JwtPayload.GetClaimValueType(jtoken), issuer, issuer));
				return;
			}
			if (jvalue.Type == global::Newtonsoft.Json.Linq.JTokenType.String)
			{
				claims.Add(new global::System.Security.Claims.Claim(claimType, jvalue.Value.ToString(), "http://www.w3.org/2001/XMLSchema#string", issuer, issuer));
				return;
			}
			claims.Add(new global::System.Security.Claims.Claim(claimType, jtoken.ToString(global::Newtonsoft.Json.Formatting.None, new global::Newtonsoft.Json.JsonConverter[0]), global::System.IdentityModel.Tokens.Jwt.JwtPayload.GetClaimValueType(jvalue.Value), issuer, issuer));
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002F81 File Offset: 0x00001181
		public void AddClaim(global::System.Security.Claims.Claim claim)
		{
			if (claim == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentNullException("claim"));
			}
			this.AddClaims(new global::System.Security.Claims.Claim[]
			{
				claim
			});
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002FA8 File Offset: 0x000011A8
		public void AddClaims(global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> claims)
		{
			if (claims == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentNullException("claims"));
			}
			foreach (global::System.Security.Claims.Claim claim in claims)
			{
				if (claim != null)
				{
					string type = claim.Type;
					object obj = claim.ValueType.Equals("http://www.w3.org/2001/XMLSchema#string", global::System.StringComparison.Ordinal) ? claim.Value : global::System.IdentityModel.Tokens.Jwt.JwtPayload.GetClaimValueUsingValueType(claim);
					object obj2;
					if (base.TryGetValue(type, out obj2))
					{
						global::System.Collections.Generic.IList<object> list = obj2 as global::System.Collections.Generic.IList<object>;
						if (list == null)
						{
							list = new global::System.Collections.Generic.List<object>();
							list.Add(obj2);
							base[type] = list;
						}
						list.Add(obj);
					}
					else
					{
						base[type] = obj;
					}
				}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000306C File Offset: 0x0000126C
		internal static object GetClaimValueUsingValueType(global::System.Security.Claims.Claim claim)
		{
			bool flag;
			if (claim.ValueType == "http://www.w3.org/2001/XMLSchema#boolean" && bool.TryParse(claim.Value, out flag))
			{
				return flag;
			}
			double num;
			if (claim.ValueType == "http://www.w3.org/2001/XMLSchema#double" && double.TryParse(claim.Value, out num))
			{
				return num;
			}
			int num2;
			if ((claim.ValueType == "http://www.w3.org/2001/XMLSchema#integer" || claim.ValueType == "http://www.w3.org/2001/XMLSchema#integer32") && int.TryParse(claim.Value, out num2))
			{
				return num2;
			}
			long num3;
			if (claim.ValueType == "http://www.w3.org/2001/XMLSchema#integer64" && long.TryParse(claim.Value, out num3))
			{
				return num3;
			}
			if (claim.ValueType == "JSON")
			{
				return global::Newtonsoft.Json.Linq.JObject.Parse(claim.Value);
			}
			if (claim.ValueType == "JSON_ARRAY")
			{
				return global::Newtonsoft.Json.Linq.JArray.Parse(claim.Value);
			}
			if (claim.ValueType == "JSON_NULL")
			{
				return string.Empty;
			}
			return claim.Value;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003188 File Offset: 0x00001388
		internal static string GetClaimValueType(object obj)
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

		// Token: 0x0600004B RID: 75 RVA: 0x00003274 File Offset: 0x00001474
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

		// Token: 0x0600004C RID: 76 RVA: 0x000032A8 File Offset: 0x000014A8
		internal int? GetIntClaim(string claimType)
		{
			int? result = null;
			object obj;
			if (base.TryGetValue(claimType, out obj))
			{
				global::System.Collections.Generic.IList<object> list = obj as global::System.Collections.Generic.IList<object>;
				if (list != null)
				{
					using (global::System.Collections.Generic.IEnumerator<object> enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							result = null;
							if (obj2 != null)
							{
								try
								{
									result = new int?(global::System.Convert.ToInt32(global::System.Math.Truncate(global::System.Convert.ToDouble(obj2, global::System.Globalization.CultureInfo.InvariantCulture))));
								}
								catch (global::System.FormatException)
								{
									result = null;
								}
								catch (global::System.InvalidCastException)
								{
									result = null;
								}
								catch (global::System.OverflowException)
								{
									result = null;
								}
								if (result != null)
								{
									return result;
								}
							}
						}
						return result;
					}
				}
				try
				{
					result = new int?(global::System.Convert.ToInt32(global::System.Math.Truncate(global::System.Convert.ToDouble(obj, global::System.Globalization.CultureInfo.InvariantCulture))));
				}
				catch (global::System.FormatException)
				{
					result = null;
				}
				catch (global::System.OverflowException)
				{
					result = null;
				}
				return result;
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000033DC File Offset: 0x000015DC
		internal global::System.Collections.Generic.IList<string> GetIListClaims(string claimType)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			object obj = null;
			if (!base.TryGetValue(claimType, out obj))
			{
				return list;
			}
			string text = obj as string;
			if (text != null)
			{
				list.Add(text);
				return list;
			}
			global::System.Collections.Generic.IEnumerable<object> enumerable = obj as global::System.Collections.Generic.IEnumerable<object>;
			if (enumerable != null)
			{
				using (global::System.Collections.Generic.IEnumerator<object> enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj2 = enumerator.Current;
						list.Add(obj2.ToString());
					}
					return list;
				}
			}
			list.Add(global::System.IdentityModel.Tokens.Jwt.JsonExtensions.SerializeToJson(obj));
			return list;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003470 File Offset: 0x00001670
		private global::System.DateTime GetDateTime(string key)
		{
			object obj;
			if (!base.TryGetValue(key, out obj))
			{
				return global::System.DateTime.MinValue;
			}
			global::System.DateTime result;
			try
			{
				global::System.Collections.Generic.IList<object> list = obj as global::System.Collections.Generic.IList<object>;
				if (list != null)
				{
					if (list.Count == 0)
					{
						return global::System.DateTime.MinValue;
					}
					obj = list[0];
				}
				result = global::Microsoft.IdentityModel.Tokens.EpochTime.DateTime(global::System.Convert.ToInt64(global::System.Math.Truncate(global::System.Convert.ToDouble(obj, global::System.Globalization.CultureInfo.InvariantCulture))));
			}
			catch (global::System.Exception ex)
			{
				if (ex is global::System.FormatException || ex is global::System.ArgumentException || ex is global::System.InvalidCastException)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12700: Error found while parsing date time. The '{0}' claim has value '{1}' which is could not be parsed to an integer.", new object[]
					{
						key,
						obj ?? "<null>"
					}), ex));
				}
				if (ex is global::System.OverflowException)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX12701: Error found while parsing date time. The '{0}' claim has value '{1}' does not lie in the valid range.", new object[]
					{
						key,
						obj ?? "<null>"
					}), ex));
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003560 File Offset: 0x00001760
		public virtual string SerializeToJson()
		{
			return global::System.IdentityModel.Tokens.Jwt.JsonExtensions.SerializeToJson(this);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003568 File Offset: 0x00001768
		public virtual string Base64UrlEncode()
		{
			return global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(this.SerializeToJson());
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003575 File Offset: 0x00001775
		public static global::System.IdentityModel.Tokens.Jwt.JwtPayload Base64UrlDeserialize(string base64UrlEncodedJsonString)
		{
			return global::System.IdentityModel.Tokens.Jwt.JsonExtensions.DeserializeJwtPayload(global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Decode(base64UrlEncodedJsonString));
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003582 File Offset: 0x00001782
		public static global::System.IdentityModel.Tokens.Jwt.JwtPayload Deserialize(string jsonString)
		{
			return global::System.IdentityModel.Tokens.Jwt.JsonExtensions.DeserializeJwtPayload(jsonString);
		}
	}
}
