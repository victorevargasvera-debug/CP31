using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using IdentityModel.Client;
using IdentityModel.OidcClient.Browser;
using IdentityModel.OidcClient.Infrastructure;
using IdentityModel.OidcClient.Results;
using Microsoft.Extensions.Logging;

namespace IdentityModel.OidcClient
{
	// Token: 0x02000002 RID: 2
	internal class AuthorizeClient
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public AuthorizeClient(global::IdentityModel.OidcClient.OidcClientOptions options)
		{
			this._options = options;
			this._logger = options.LoggerFactory.CreateLogger<global::IdentityModel.OidcClient.AuthorizeClient>();
			this._crypto = new global::IdentityModel.OidcClient.CryptoHelper(options);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000207C File Offset: 0x0000027C
		public async global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.Results.AuthorizeResult> AuthorizeAsync(global::IdentityModel.OidcClient.Browser.DisplayMode displayMode = global::IdentityModel.OidcClient.Browser.DisplayMode.Visible, int timeout = 300, object extraParameters = null)
		{
			this._logger.LogTrace("AuthorizeAsync", new object[0]);
			if (this._options.Browser == null)
			{
				throw new global::System.InvalidOperationException("No browser configured.");
			}
			global::IdentityModel.OidcClient.Results.AuthorizeResult result = new global::IdentityModel.OidcClient.Results.AuthorizeResult
			{
				State = this.CreateAuthorizeState(extraParameters)
			};
			global::IdentityModel.OidcClient.Browser.BrowserOptions browserOptions = new global::IdentityModel.OidcClient.Browser.BrowserOptions(result.State.StartUrl, this._options.RedirectUri)
			{
				Timeout = global::System.TimeSpan.FromSeconds((double)timeout),
				DisplayMode = displayMode
			};
			if (this._options.ResponseMode == global::IdentityModel.OidcClient.OidcClientOptions.AuthorizeResponseMode.FormPost)
			{
				browserOptions.ResponseMode = global::IdentityModel.OidcClient.OidcClientOptions.AuthorizeResponseMode.FormPost;
			}
			else
			{
				browserOptions.ResponseMode = global::IdentityModel.OidcClient.OidcClientOptions.AuthorizeResponseMode.Redirect;
			}
			global::IdentityModel.OidcClient.Browser.BrowserResult browserResult = await this._options.Browser.InvokeAsync(browserOptions);
			global::IdentityModel.OidcClient.Results.AuthorizeResult result2;
			if (browserResult.ResultType == global::IdentityModel.OidcClient.Browser.BrowserResultType.Success)
			{
				result.Data = browserResult.Response;
				result2 = result;
			}
			else
			{
				result.Error = browserResult.ResultType.ToString();
				result2 = result;
			}
			return result2;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020DC File Offset: 0x000002DC
		public global::IdentityModel.OidcClient.AuthorizeState CreateAuthorizeState(object extraParameters = null)
		{
			this._logger.LogTrace("CreateAuthorizeStateAsync", new object[0]);
			global::IdentityModel.OidcClient.CryptoHelper.Pkce pkce = this._crypto.CreatePkceData();
			global::IdentityModel.OidcClient.AuthorizeState authorizeState = new global::IdentityModel.OidcClient.AuthorizeState
			{
				Nonce = this._crypto.CreateNonce(),
				State = this._crypto.CreateState(),
				RedirectUri = this._options.RedirectUri,
				CodeVerifier = pkce.CodeVerifier
			};
			authorizeState.StartUrl = this.CreateUrl(authorizeState.State, authorizeState.Nonce, pkce.CodeChallenge, extraParameters);
			this._logger.LogDebug(global::IdentityModel.OidcClient.Infrastructure.LogSerializer.Serialize(authorizeState), new object[0]);
			return authorizeState;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002188 File Offset: 0x00000388
		internal string CreateUrl(string state, string nonce, string codeChallenge, object extraParameters)
		{
			this._logger.LogTrace("CreateUrl", new object[0]);
			global::System.Collections.Generic.Dictionary<string, string> values = this.CreateParameters(state, nonce, codeChallenge, extraParameters);
			return new global::IdentityModel.Client.AuthorizeRequest(this._options.ProviderInformation.AuthorizeEndpoint).Create(values);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021D4 File Offset: 0x000003D4
		internal global::System.Collections.Generic.Dictionary<string, string> CreateParameters(string state, string nonce, string codeChallenge, object extraParameters)
		{
			this._logger.LogTrace("CreateParameters", new object[0]);
			global::IdentityModel.OidcClient.OidcClientOptions.AuthenticationFlow flow = this._options.Flow;
			string value;
			if (flow != global::IdentityModel.OidcClient.OidcClientOptions.AuthenticationFlow.AuthorizationCode)
			{
				if (flow != global::IdentityModel.OidcClient.OidcClientOptions.AuthenticationFlow.Hybrid)
				{
					throw new global::System.ArgumentOutOfRangeException("Flow", "Unsupported authentication flow");
				}
				value = "code id_token";
			}
			else
			{
				value = "code";
			}
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"response_type",
					value
				},
				{
					"nonce",
					nonce
				},
				{
					"state",
					state
				},
				{
					"code_challenge",
					codeChallenge
				},
				{
					"code_challenge_method",
					"S256"
				}
			};
			if (this._options.ClientId.IsPresent())
			{
				dictionary.Add("client_id", this._options.ClientId);
			}
			if (this._options.Scope.IsPresent())
			{
				dictionary.Add("scope", this._options.Scope);
			}
			if (this._options.RedirectUri.IsPresent())
			{
				dictionary.Add("redirect_uri", this._options.RedirectUri);
			}
			if (this._options.ResponseMode == global::IdentityModel.OidcClient.OidcClientOptions.AuthorizeResponseMode.FormPost)
			{
				dictionary.Add("response_mode", "form_post");
			}
			global::System.Collections.Generic.Dictionary<string, string> dictionary2 = this.ObjectToDictionary(extraParameters);
			if (dictionary2 != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in dictionary2)
				{
					if (!string.IsNullOrWhiteSpace(keyValuePair.Value))
					{
						if (dictionary.ContainsKey(keyValuePair.Key))
						{
							dictionary[keyValuePair.Key] = keyValuePair.Value;
						}
						else
						{
							dictionary.Add(keyValuePair.Key, keyValuePair.Value);
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000239C File Offset: 0x0000059C
		private global::System.Collections.Generic.Dictionary<string, string> ObjectToDictionary(object values)
		{
			this._logger.LogTrace("ObjectToDictionary", new object[0]);
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

		// Token: 0x04000001 RID: 1
		private readonly global::IdentityModel.OidcClient.CryptoHelper _crypto;

		// Token: 0x04000002 RID: 2
		private readonly global::Microsoft.Extensions.Logging.ILogger<global::IdentityModel.OidcClient.AuthorizeClient> _logger;

		// Token: 0x04000003 RID: 3
		private readonly global::IdentityModel.OidcClient.OidcClientOptions _options;
	}
}
