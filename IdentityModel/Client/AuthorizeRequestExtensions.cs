using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace IdentityModel.Client
{
	// Token: 0x02000037 RID: 55
	public static class AuthorizeRequestExtensions
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00003030 File Offset: 0x00001230
		public static string Create(this global::IdentityModel.Client.AuthorizeRequest request, object values)
		{
			return request.Create(global::IdentityModel.Client.AuthorizeRequestExtensions.ObjectToDictionary(values));
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003040 File Offset: 0x00001240
		public static string CreateAuthorizeUrl(this global::IdentityModel.Client.AuthorizeRequest request, string clientId, string responseType, string scope = null, string redirectUri = null, string state = null, string nonce = null, string loginHint = null, string acrValues = null, string prompt = null, string responseMode = null, string codeChallenge = null, string codeChallengeMethod = null, object extra = null)
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"client_id",
					clientId
				},
				{
					"response_type",
					responseType
				}
			};
			if (!string.IsNullOrWhiteSpace(scope))
			{
				dictionary.Add("scope", scope);
			}
			if (!string.IsNullOrWhiteSpace(redirectUri))
			{
				dictionary.Add("redirect_uri", redirectUri);
			}
			if (!string.IsNullOrWhiteSpace(state))
			{
				dictionary.Add("state", state);
			}
			if (!string.IsNullOrWhiteSpace(nonce))
			{
				dictionary.Add("nonce", nonce);
			}
			if (!string.IsNullOrWhiteSpace(loginHint))
			{
				dictionary.Add("login_hint", loginHint);
			}
			if (!string.IsNullOrWhiteSpace(acrValues))
			{
				dictionary.Add("acr_values", acrValues);
			}
			if (!string.IsNullOrWhiteSpace(prompt))
			{
				dictionary.Add("prompt", prompt);
			}
			if (!string.IsNullOrWhiteSpace(responseMode))
			{
				dictionary.Add("response_mode", responseMode);
			}
			if (!string.IsNullOrWhiteSpace(codeChallenge))
			{
				dictionary.Add("code_challenge", codeChallenge);
			}
			if (!string.IsNullOrWhiteSpace(codeChallengeMethod))
			{
				dictionary.Add("code_challenge_method", codeChallengeMethod);
			}
			return request.Create(global::IdentityModel.Client.AuthorizeRequestExtensions.Merge(dictionary, global::IdentityModel.Client.AuthorizeRequestExtensions.ObjectToDictionary(extra)));
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003158 File Offset: 0x00001358
		private static global::System.Collections.Generic.Dictionary<string, string> ObjectToDictionary(object values)
		{
			if (values == null)
			{
				return null;
			}
			global::System.Collections.Generic.Dictionary<string, string> dictionary;
			if ((dictionary = (values as global::System.Collections.Generic.Dictionary<string, string>)) != null)
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

		// Token: 0x06000077 RID: 119 RVA: 0x000031E0 File Offset: 0x000013E0
		private static global::System.Collections.Generic.Dictionary<string, string> Merge(global::System.Collections.Generic.Dictionary<string, string> explicitValues, global::System.Collections.Generic.Dictionary<string, string> additionalValues = null)
		{
			global::System.Collections.Generic.Dictionary<string, string> result = explicitValues;
			if (additionalValues != null)
			{
				result = explicitValues.Concat(from add in additionalValues
				where !explicitValues.ContainsKey(add.Key)
				select add).ToDictionary((global::System.Collections.Generic.KeyValuePair<string, string> final) => final.Key, (global::System.Collections.Generic.KeyValuePair<string, string> final) => final.Value);
			}
			return result;
		}
	}
}
