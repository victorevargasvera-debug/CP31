using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityModel.Client
{
	// Token: 0x02000054 RID: 84
	public static class TokenClientExtensions
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00006170 File Offset: 0x00004370
		public static global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenResponse> RequestClientCredentialsAsync(this global::IdentityModel.Client.TokenClient client, string scope = null, object extra = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"grant_type",
					"client_credentials"
				}
			};
			if (!string.IsNullOrWhiteSpace(scope))
			{
				dictionary.Add("scope", scope);
			}
			return client.RequestAsync(global::IdentityModel.Client.TokenClientExtensions.Merge(client, dictionary, extra), cancellationToken);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000061B8 File Offset: 0x000043B8
		public static global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenResponse> RequestResourceOwnerPasswordAsync(this global::IdentityModel.Client.TokenClient client, string userName, string password, string scope = null, object extra = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"grant_type",
					"password"
				},
				{
					"username",
					userName
				},
				{
					"password",
					password
				}
			};
			if (!string.IsNullOrWhiteSpace(scope))
			{
				dictionary.Add("scope", scope);
			}
			return client.RequestAsync(global::IdentityModel.Client.TokenClientExtensions.Merge(client, dictionary, extra), cancellationToken);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00006218 File Offset: 0x00004418
		public static global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenResponse> RequestAuthorizationCodeAsync(this global::IdentityModel.Client.TokenClient client, string code, string redirectUri, string codeVerifier = null, object extra = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"grant_type",
					"authorization_code"
				},
				{
					"code",
					code
				},
				{
					"redirect_uri",
					redirectUri
				}
			};
			if (!string.IsNullOrWhiteSpace(codeVerifier))
			{
				dictionary.Add("code_verifier", codeVerifier);
			}
			return client.RequestAsync(global::IdentityModel.Client.TokenClientExtensions.Merge(client, dictionary, extra), cancellationToken);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00006278 File Offset: 0x00004478
		public static global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenResponse> RequestAuthorizationCodePopAsync(this global::IdentityModel.Client.TokenClient client, string code, string redirectUri, string codeVerifier = null, string algorithm = null, string key = null, object extra = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"token_type",
					"pop"
				},
				{
					"grant_type",
					"authorization_code"
				},
				{
					"code",
					code
				},
				{
					"redirect_uri",
					redirectUri
				}
			};
			if (!string.IsNullOrWhiteSpace(codeVerifier))
			{
				dictionary.Add("code_verifier", codeVerifier);
			}
			if (!string.IsNullOrWhiteSpace(algorithm))
			{
				dictionary.Add("alg", algorithm);
			}
			if (!string.IsNullOrWhiteSpace(key))
			{
				dictionary.Add("key", key);
			}
			return client.RequestAsync(global::IdentityModel.Client.TokenClientExtensions.Merge(client, dictionary, extra), cancellationToken);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00006314 File Offset: 0x00004514
		public static global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenResponse> RequestRefreshTokenAsync(this global::IdentityModel.Client.TokenClient client, string refreshToken, object extra = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::System.Collections.Generic.Dictionary<string, string> explicitValues = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"grant_type",
					"refresh_token"
				},
				{
					"refresh_token",
					refreshToken
				}
			};
			return client.RequestAsync(global::IdentityModel.Client.TokenClientExtensions.Merge(client, explicitValues, extra), cancellationToken);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00006354 File Offset: 0x00004554
		public static global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenResponse> RequestRefreshTokenPopAsync(this global::IdentityModel.Client.TokenClient client, string refreshToken, string algorithm = null, string key = null, object extra = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"token_type",
					"pop"
				},
				{
					"grant_type",
					"refresh_token"
				},
				{
					"refresh_token",
					refreshToken
				}
			};
			if (!string.IsNullOrWhiteSpace(algorithm))
			{
				dictionary.Add("alg", algorithm);
			}
			if (!string.IsNullOrWhiteSpace(key))
			{
				dictionary.Add("key", key);
			}
			return client.RequestAsync(global::IdentityModel.Client.TokenClientExtensions.Merge(client, dictionary, extra), cancellationToken);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000063CC File Offset: 0x000045CC
		public static global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenResponse> RequestAssertionAsync(this global::IdentityModel.Client.TokenClient client, string assertionType, string assertion, string scope = null, object extra = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"grant_type",
					assertionType
				},
				{
					"assertion",
					assertion
				}
			};
			if (!string.IsNullOrWhiteSpace(scope))
			{
				dictionary.Add("scope", scope);
			}
			return client.RequestAsync(global::IdentityModel.Client.TokenClientExtensions.Merge(client, dictionary, extra), cancellationToken);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000641C File Offset: 0x0000461C
		public static global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenResponse> RequestCustomGrantAsync(this global::IdentityModel.Client.TokenClient client, string grantType, string scope = null, object extra = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"grant_type",
					grantType
				}
			};
			if (!string.IsNullOrWhiteSpace(scope))
			{
				dictionary.Add("scope", scope);
			}
			return client.RequestAsync(global::IdentityModel.Client.TokenClientExtensions.Merge(client, dictionary, extra), cancellationToken);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00006460 File Offset: 0x00004660
		public static global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenResponse> RequestCustomAsync(this global::IdentityModel.Client.TokenClient client, object values, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return client.RequestAsync(global::IdentityModel.Client.TokenClientExtensions.Merge(client, global::IdentityModel.Client.TokenClientExtensions.ObjectToDictionary(values), null), cancellationToken);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00006478 File Offset: 0x00004678
		private static global::System.Collections.Generic.Dictionary<string, string> Merge(global::IdentityModel.Client.TokenClient client, global::System.Collections.Generic.Dictionary<string, string> explicitValues, object extra = null)
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = explicitValues;
			if (client.AuthenticationStyle == global::IdentityModel.Client.AuthenticationStyle.PostValues)
			{
				dictionary.Add("client_id", client.ClientId);
				if (!string.IsNullOrEmpty(client.ClientSecret))
				{
					dictionary.Add("client_secret", client.ClientSecret);
				}
			}
			global::System.Collections.Generic.Dictionary<string, string> dictionary2 = global::IdentityModel.Client.TokenClientExtensions.ObjectToDictionary(extra);
			if (dictionary2 != null)
			{
				dictionary = explicitValues.Concat(from add in dictionary2
				where !explicitValues.ContainsKey(add.Key)
				select add).ToDictionary((global::System.Collections.Generic.KeyValuePair<string, string> final) => final.Key, (global::System.Collections.Generic.KeyValuePair<string, string> final) => final.Value);
			}
			return dictionary;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00006540 File Offset: 0x00004740
		private static global::System.Collections.Generic.Dictionary<string, string> ObjectToDictionary(object values)
		{
			if (values == null)
			{
				return null;
			}
			global::System.Collections.Generic.Dictionary<string, string> dictionary = values as global::System.Collections.Generic.Dictionary<string, string>;
			if (dictionary != null)
			{
				return dictionary;
			}
			dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
			foreach (global::System.Reflection.PropertyInfo propertyInfo in values.GetType().GetRuntimeProperties())
			{
				string value = propertyInfo.GetValue(values) as string;
				if (!string.IsNullOrEmpty(value))
				{
					dictionary.Add(propertyInfo.Name, value);
				}
			}
			return dictionary;
		}
	}
}
