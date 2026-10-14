using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using IdentityModel.Internal;
using IdentityModel.Jwk;
using Newtonsoft.Json.Linq;

namespace IdentityModel.Client
{
	// Token: 0x02000041 RID: 65
	public class DiscoveryResponse
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003EE0 File Offset: 0x000020E0
		public string Raw { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003EE8 File Offset: 0x000020E8
		public global::Newtonsoft.Json.Linq.JObject Json { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00003EF0 File Offset: 0x000020F0
		public bool IsError { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00003EF8 File Offset: 0x000020F8
		public global::System.Net.HttpStatusCode StatusCode { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00003F00 File Offset: 0x00002100
		public string Error { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00003F08 File Offset: 0x00002108
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00003F10 File Offset: 0x00002110
		public global::IdentityModel.Client.ResponseErrorType ErrorType { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00003F1C File Offset: 0x0000211C
		public global::System.Exception Exception { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00003F24 File Offset: 0x00002124
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00003F2C File Offset: 0x0000212C
		public global::IdentityModel.Jwk.JsonWebKeySet KeySet { get; set; }

		// Token: 0x060000BE RID: 190 RVA: 0x00003F38 File Offset: 0x00002138
		public DiscoveryResponse(string raw, global::IdentityModel.Client.DiscoveryPolicy policy = null)
		{
			if (policy == null)
			{
				policy = new global::IdentityModel.Client.DiscoveryPolicy();
			}
			this.IsError = 0;
			this.StatusCode = 200;
			this.Raw = raw;
			try
			{
				this.Json = global::Newtonsoft.Json.Linq.JObject.Parse(raw);
				string text = this.Validate(policy);
				if (!string.IsNullOrEmpty(text))
				{
					this.IsError = 1;
					this.Json = null;
					this.ErrorType = global::IdentityModel.Client.ResponseErrorType.PolicyViolation;
					this.Error = text;
				}
			}
			catch (global::System.Exception ex)
			{
				this.IsError = 1;
				this.ErrorType = global::IdentityModel.Client.ResponseErrorType.Exception;
				this.Error = ex.Message;
				this.Exception = ex;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003FDC File Offset: 0x000021DC
		public DiscoveryResponse(global::System.Net.HttpStatusCode statusCode, string reason)
		{
			this.IsError = 1;
			this.ErrorType = global::IdentityModel.Client.ResponseErrorType.Http;
			this.StatusCode = statusCode;
			this.Error = reason;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004000 File Offset: 0x00002200
		public DiscoveryResponse(global::System.Exception exception, string errorMessage)
		{
			this.IsError = 1;
			this.ErrorType = global::IdentityModel.Client.ResponseErrorType.Exception;
			this.Exception = exception;
			this.Error = string.Format("{0}: {1}", errorMessage, exception.Message);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00004034 File Offset: 0x00002234
		public string Issuer
		{
			get
			{
				return this.TryGetString("issuer");
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004044 File Offset: 0x00002244
		public string AuthorizeEndpoint
		{
			get
			{
				return this.TryGetString("authorization_endpoint");
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00004054 File Offset: 0x00002254
		public string TokenEndpoint
		{
			get
			{
				return this.TryGetString("token_endpoint");
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00004064 File Offset: 0x00002264
		public string UserInfoEndpoint
		{
			get
			{
				return this.TryGetString("userinfo_endpoint");
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00004074 File Offset: 0x00002274
		public string IntrospectionEndpoint
		{
			get
			{
				return this.TryGetString("introspection_endpoint");
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00004084 File Offset: 0x00002284
		public string RevocationEndpoint
		{
			get
			{
				return this.TryGetString("revocation_endpoint");
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00004094 File Offset: 0x00002294
		public string JwksUri
		{
			get
			{
				return this.TryGetString("jwks_uri");
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000040A4 File Offset: 0x000022A4
		public string EndSessionEndpoint
		{
			get
			{
				return this.TryGetString("end_session_endpoint");
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000040B4 File Offset: 0x000022B4
		public string CheckSessionIframe
		{
			get
			{
				return this.TryGetString("check_session_iframe");
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000040C4 File Offset: 0x000022C4
		public string RegistrationEndpoint
		{
			get
			{
				return this.TryGetString("registration_endpoint");
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000040D4 File Offset: 0x000022D4
		public bool? FrontChannelLogoutSupported
		{
			get
			{
				return this.TryGetBoolean("frontchannel_logout_supported");
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000040E4 File Offset: 0x000022E4
		public bool? FrontChannelLogoutSessionSupported
		{
			get
			{
				return this.TryGetBoolean("frontchannel_logout_session_supported");
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000040F4 File Offset: 0x000022F4
		public global::System.Collections.Generic.IEnumerable<string> GrantTypesSupported
		{
			get
			{
				return this.TryGetStringArray("grant_types_supported");
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00004104 File Offset: 0x00002304
		public global::System.Collections.Generic.IEnumerable<string> CodeChallengeMethodsSupported
		{
			get
			{
				return this.TryGetStringArray("code_challenge_methods_supported");
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00004114 File Offset: 0x00002314
		public global::System.Collections.Generic.IEnumerable<string> ScopesSupported
		{
			get
			{
				return this.TryGetStringArray("scopes_supported");
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00004124 File Offset: 0x00002324
		public global::System.Collections.Generic.IEnumerable<string> SubjectTypesSupported
		{
			get
			{
				return this.TryGetStringArray("subject_types_supported");
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00004134 File Offset: 0x00002334
		public global::System.Collections.Generic.IEnumerable<string> ResponseModesSupported
		{
			get
			{
				return this.TryGetStringArray("response_modes_supported");
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00004144 File Offset: 0x00002344
		public global::System.Collections.Generic.IEnumerable<string> ResponseTypesSupported
		{
			get
			{
				return this.TryGetStringArray("response_types_supported");
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00004154 File Offset: 0x00002354
		public global::System.Collections.Generic.IEnumerable<string> ClaimsSupported
		{
			get
			{
				return this.TryGetStringArray("claims_supported");
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00004164 File Offset: 0x00002364
		public global::System.Collections.Generic.IEnumerable<string> TokenEndpointAuthenticationMethodsSupported
		{
			get
			{
				return this.TryGetStringArray("token_endpoint_auth_methods_supported");
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004174 File Offset: 0x00002374
		public global::Newtonsoft.Json.Linq.JToken TryGetValue(string name)
		{
			return this.Json.TryGetValue(name);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004184 File Offset: 0x00002384
		public string TryGetString(string name)
		{
			return this.Json.TryGetString(name);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004194 File Offset: 0x00002394
		public bool? TryGetBoolean(string name)
		{
			return this.Json.TryGetBoolean(name);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000041A4 File Offset: 0x000023A4
		public global::System.Collections.Generic.IEnumerable<string> TryGetStringArray(string name)
		{
			return this.Json.TryGetStringArray(name);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000041B4 File Offset: 0x000023B4
		private string Validate(global::IdentityModel.Client.DiscoveryPolicy policy)
		{
			if (policy.ValidateIssuerName)
			{
				if (string.IsNullOrWhiteSpace(this.Issuer))
				{
					return "Issuer name is missing";
				}
				if (!this.ValidateIssuerName(this.Issuer.RemoveTrailingSlash(), policy.Authority.RemoveTrailingSlash()))
				{
					return "Issuer name does not match authority: " + this.Issuer;
				}
			}
			string text = this.ValidateEndoints(this.Json, policy);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return string.Empty;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004228 File Offset: 0x00002428
		public bool ValidateIssuerName(string issuer, string authority)
		{
			return string.Equals(issuer, authority, global::System.StringComparison.Ordinal);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004234 File Offset: 0x00002434
		public string ValidateEndoints(global::Newtonsoft.Json.Linq.JObject json, global::IdentityModel.Client.DiscoveryPolicy policy)
		{
			global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>(from e in policy.AdditionalEndpointBaseAddresses
			select new global::System.Uri(e).Authority);
			hashSet.Add(new global::System.Uri(policy.Authority).Authority);
			global::System.Collections.Generic.HashSet<string> hashSet2 = new global::System.Collections.Generic.HashSet<string>(policy.AdditionalEndpointBaseAddresses);
			hashSet2.Add(policy.Authority);
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken> keyValuePair in json)
			{
				if (keyValuePair.Key.EndsWith("endpoint", global::System.StringComparison.OrdinalIgnoreCase) || keyValuePair.Key.Equals("jwks_uri", global::System.StringComparison.OrdinalIgnoreCase) || keyValuePair.Key.Equals("check_session_iframe", global::System.StringComparison.OrdinalIgnoreCase))
				{
					string text = keyValuePair.Value.ToString();
					global::System.Uri uri;
					if (!global::System.Uri.TryCreate(text, global::System.UriKind.Absolute, out uri))
					{
						return string.Format("Malformed endpoint: {0}", text);
					}
					if (!global::IdentityModel.Internal.DiscoveryUrlHelper.IsValidScheme(uri))
					{
						return string.Format("Malformed endpoint: {0}", text);
					}
					if (!global::IdentityModel.Internal.DiscoveryUrlHelper.IsSecureScheme(uri, policy))
					{
						return string.Format("Endpoint does not use HTTPS: {0}", text);
					}
					if (policy.ValidateEndpoints && !policy.EndpointValidationExcludeList.Contains(keyValuePair.Key))
					{
						bool flag = false;
						using (global::System.Collections.Generic.HashSet<string>.Enumerator enumerator2 = hashSet.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (string.Equals(enumerator2.Current, uri.Authority))
								{
									flag = true;
								}
							}
						}
						if (!flag)
						{
							return string.Format("Endpoint is on a different host than authority: {0}", text);
						}
						flag = false;
						foreach (string value in hashSet2)
						{
							if (text.StartsWith(value, global::System.StringComparison.Ordinal))
							{
								flag = true;
							}
						}
						if (!flag)
						{
							return string.Format("Endpoint belongs to different authority: {0}", text);
						}
					}
				}
			}
			if (policy.RequireKeySet && string.IsNullOrWhiteSpace(this.JwksUri))
			{
				return "Keyset is missing";
			}
			return string.Empty;
		}
	}
}
