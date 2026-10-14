using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using IdentityModel.Client;
using IdentityModel.Jwk;
using IdentityModel.OidcClient.Browser;
using IdentityModel.OidcClient.Infrastructure;
using IdentityModel.OidcClient.Results;
using Microsoft.Extensions.Logging;

namespace IdentityModel.OidcClient
{
	// Token: 0x0200000B RID: 11
	public class OidcClient
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003030 File Offset: 0x00001230
		public global::IdentityModel.OidcClient.OidcClientOptions Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003038 File Offset: 0x00001238
		public OidcClient(global::IdentityModel.OidcClient.OidcClientOptions options)
		{
			if (options == null)
			{
				throw new global::System.ArgumentNullException("options");
			}
			if (options.ProviderInformation == null)
			{
				if (options.Authority.IsMissing())
				{
					throw new global::System.ArgumentException("No authority specified", "Authority");
				}
				this.useDiscovery = true;
			}
			this._options = options;
			this._logger = options.LoggerFactory.CreateLogger<global::IdentityModel.OidcClient.OidcClient>();
			this._authorizeClient = new global::IdentityModel.OidcClient.AuthorizeClient(options);
			this._processor = new global::IdentityModel.OidcClient.ResponseProcessor(options, new global::System.Func<global::System.Threading.Tasks.Task>(this.EnsureProviderInformationAsync));
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000030C4 File Offset: 0x000012C4
		public async global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.LoginResult> LoginAsync(global::IdentityModel.OidcClient.Browser.DisplayMode displayMode = global::IdentityModel.OidcClient.Browser.DisplayMode.Visible, int timeout = 300, object extraParameters = null)
		{
			this._logger.LogTrace("LoginAsync", new object[0]);
			this._logger.LogInformation("Starting authentication request.", new object[0]);
			await this.EnsureConfigurationAsync();
			global::IdentityModel.OidcClient.Results.AuthorizeResult authorizeResult = await this._authorizeClient.AuthorizeAsync(displayMode, timeout, extraParameters);
			global::IdentityModel.OidcClient.LoginResult result;
			if (authorizeResult.IsError)
			{
				result = new global::IdentityModel.OidcClient.LoginResult(authorizeResult.Error);
			}
			else
			{
				global::IdentityModel.OidcClient.LoginResult loginResult = await this.ProcessResponseAsync(authorizeResult.Data, authorizeResult.State);
				if (!loginResult.IsError)
				{
					this._logger.LogInformation("Authentication request success.", new object[0]);
				}
				result = loginResult;
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003124 File Offset: 0x00001324
		public async global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.AuthorizeState> PrepareLoginAsync(object extraParameters = null)
		{
			this._logger.LogTrace("PrepareLoginAsync", new object[0]);
			await this.EnsureConfigurationAsync();
			return this._authorizeClient.CreateAuthorizeState(extraParameters);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003174 File Offset: 0x00001374
		public async global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.LoginResult> ProcessResponseAsync(string data, global::IdentityModel.OidcClient.AuthorizeState state)
		{
			this._logger.LogTrace("ProcessResponseAsync", new object[0]);
			this._logger.LogInformation("Processing response.", new object[0]);
			await this.EnsureConfigurationAsync();
			this._logger.LogDebug("Authorize response: {response}", new object[]
			{
				data
			});
			global::IdentityModel.Client.AuthorizeResponse authorizeResponse = new global::IdentityModel.Client.AuthorizeResponse(data);
			global::IdentityModel.OidcClient.LoginResult result2;
			if (authorizeResponse.IsError)
			{
				this._logger.LogError(authorizeResponse.Error, new object[0]);
				result2 = new global::IdentityModel.OidcClient.LoginResult(authorizeResponse.Error);
			}
			else
			{
				global::IdentityModel.OidcClient.ResponseValidationResult result = await this._processor.ProcessResponseAsync(authorizeResponse, state);
				if (result.IsError)
				{
					this._logger.LogError(result.Error, new object[0]);
					result2 = new global::IdentityModel.OidcClient.LoginResult(result.Error);
				}
				else
				{
					global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> enumerable = global::System.Linq.Enumerable.Empty<global::System.Security.Claims.Claim>();
					if (this._options.LoadProfile)
					{
						global::IdentityModel.OidcClient.Results.UserInfoResult userInfoResult = await this.GetUserInfoAsync(result.TokenResponse.AccessToken);
						if (userInfoResult.IsError)
						{
							string text = string.Format("Error contacting userinfo endpoint: {0}", userInfoResult.Error);
							this._logger.LogError(text, new object[0]);
							return new global::IdentityModel.OidcClient.LoginResult(text);
						}
						enumerable = userInfoResult.Claims;
						global::System.Security.Claims.Claim claim = enumerable.FirstOrDefault((global::System.Security.Claims.Claim c) => c.Type == "sub");
						if (claim == null)
						{
							string text2 = "sub claim is missing from userinfo endpoint";
							this._logger.LogError(text2, new object[0]);
							return new global::IdentityModel.OidcClient.LoginResult(text2);
						}
						if (!string.Equals(claim.Value, result.User.FindFirst("sub").Value))
						{
							string text3 = "sub claim from userinfo endpoint is different than sub claim from identity token.";
							this._logger.LogError(text3, new object[0]);
							return new global::IdentityModel.OidcClient.LoginResult(text3);
						}
					}
					global::System.Security.Claims.ClaimsPrincipal user = this.ProcessClaims(result.User, enumerable);
					global::IdentityModel.OidcClient.LoginResult loginResult = new global::IdentityModel.OidcClient.LoginResult
					{
						User = user,
						AccessToken = result.TokenResponse.AccessToken,
						RefreshToken = result.TokenResponse.RefreshToken,
						AccessTokenExpiration = global::System.DateTime.Now.AddSeconds((double)result.TokenResponse.ExpiresIn),
						IdentityToken = result.TokenResponse.IdentityToken,
						AuthenticationTime = global::System.DateTime.Now
					};
					if (!string.IsNullOrWhiteSpace(loginResult.RefreshToken))
					{
						loginResult.RefreshTokenHandler = new global::IdentityModel.Client.RefreshTokenHandler(global::IdentityModel.OidcClient.Infrastructure.TokenClientFactory.Create(this._options), loginResult.RefreshToken, loginResult.AccessToken, null);
					}
					result2 = loginResult;
				}
			}
			return result2;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000031CC File Offset: 0x000013CC
		public async global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.Results.UserInfoResult> GetUserInfoAsync(string accessToken)
		{
			this._logger.LogTrace("GetUserInfoAsync", new object[0]);
			await this.EnsureConfigurationAsync();
			if (accessToken.IsMissing())
			{
				throw new global::System.ArgumentNullException("accessToken");
			}
			if (!this._options.ProviderInformation.SupportsUserInfo)
			{
				throw new global::System.InvalidOperationException("No userinfo endpoint specified");
			}
			global::IdentityModel.Client.UserInfoResponse userInfoResponse = await new global::IdentityModel.Client.UserInfoClient(this._options.ProviderInformation.UserInfoEndpoint, this._options.BackchannelHandler)
			{
				Timeout = this._options.BackchannelTimeout
			}.GetAsync(accessToken, default(global::System.Threading.CancellationToken));
			global::IdentityModel.OidcClient.Results.UserInfoResult result;
			if (userInfoResponse.IsError)
			{
				result = new global::IdentityModel.OidcClient.Results.UserInfoResult
				{
					Error = userInfoResponse.Error
				};
			}
			else
			{
				result = new global::IdentityModel.OidcClient.Results.UserInfoResult
				{
					Claims = userInfoResponse.Claims
				};
			}
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000321C File Offset: 0x0000141C
		public async global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.Results.RefreshTokenResult> RefreshTokenAsync(string refreshToken)
		{
			this._logger.LogTrace("RefreshTokenAsync", new object[0]);
			await this.EnsureConfigurationAsync();
			global::IdentityModel.Client.TokenResponse response = await global::IdentityModel.OidcClient.Infrastructure.TokenClientFactory.Create(this._options).RequestRefreshTokenAsync(refreshToken, null, default(global::System.Threading.CancellationToken));
			global::IdentityModel.OidcClient.Results.RefreshTokenResult result;
			if (response.IsError)
			{
				result = new global::IdentityModel.OidcClient.Results.RefreshTokenResult
				{
					Error = response.Error
				};
			}
			else
			{
				global::IdentityModel.OidcClient.Results.TokenResponseValidationResult tokenResponseValidationResult = await this._processor.ValidateTokenResponseAsync(response, null, this._options.Policy.RequireIdentityTokenOnRefreshTokenResponse);
				if (tokenResponseValidationResult.IsError)
				{
					result = new global::IdentityModel.OidcClient.Results.RefreshTokenResult
					{
						Error = tokenResponseValidationResult.Error
					};
				}
				else
				{
					result = new global::IdentityModel.OidcClient.Results.RefreshTokenResult
					{
						IdentityToken = response.IdentityToken,
						AccessToken = response.AccessToken,
						RefreshToken = response.RefreshToken,
						ExpiresIn = (int)response.ExpiresIn
					};
				}
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000326C File Offset: 0x0000146C
		internal async global::System.Threading.Tasks.Task EnsureConfigurationAsync()
		{
			if (this._options.Flow == global::IdentityModel.OidcClient.OidcClientOptions.AuthenticationFlow.Hybrid && !this._options.Policy.RequireIdentityTokenSignature)
			{
				string message = "Allowing unsigned identity tokens is not allowed for hybrid flow";
				this._logger.LogError(message, new object[0]);
				throw new global::System.InvalidOperationException(message);
			}
			await this.EnsureProviderInformationAsync();
			this._logger.LogTrace("Effective options:", new object[0]);
			this._logger.LogTrace(global::IdentityModel.OidcClient.Infrastructure.LogSerializer.Serialize(this._options), new object[0]);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000032B4 File Offset: 0x000014B4
		internal async global::System.Threading.Tasks.Task EnsureProviderInformationAsync()
		{
			this._logger.LogTrace("EnsureProviderInformation", new object[0]);
			if (this.useDiscovery)
			{
				if (!this._options.RefreshDiscoveryDocumentForLogin && this._options.ProviderInformation != null)
				{
					this._logger.LogDebug("Skipping refresh of discovery document.", new object[0]);
					return;
				}
				global::IdentityModel.Client.DiscoveryResponse discoveryResponse = await new global::IdentityModel.Client.DiscoveryClient(this._options.Authority, this._options.BackchannelHandler)
				{
					Policy = this._options.Policy.Discovery,
					Timeout = this._options.BackchannelTimeout
				}.GetAsync(default(global::System.Threading.CancellationToken)).ConfigureAwait(false);
				if (discoveryResponse.IsError)
				{
					this._logger.LogError("Error loading discovery document: {errorType} - {error}", new object[]
					{
						discoveryResponse.ErrorType.ToString(),
						discoveryResponse.Error
					});
					if (discoveryResponse.ErrorType == global::IdentityModel.Client.ResponseErrorType.Exception)
					{
						throw new global::System.InvalidOperationException("Error loading discovery document: " + discoveryResponse.Error, discoveryResponse.Exception);
					}
					throw new global::System.InvalidOperationException("Error loading discovery document: " + discoveryResponse.Error);
				}
				else
				{
					this._logger.LogDebug("Successfully loaded discovery document", new object[0]);
					this._logger.LogDebug("Loaded keyset from {jwks_uri}", new object[]
					{
						discoveryResponse.JwksUri
					});
					global::Microsoft.Extensions.Logging.ILogger logger = this._logger;
					string message = "Keyet contains the following kids: {kids}";
					object[] array = new object[1];
					array[0] = from k in discoveryResponse.KeySet.Keys
					select k.Kid ?? "unspecified";
					logger.LogDebug(message, array);
					this._options.ProviderInformation = new global::IdentityModel.OidcClient.ProviderInformation
					{
						IssuerName = discoveryResponse.Issuer,
						KeySet = discoveryResponse.KeySet,
						AuthorizeEndpoint = discoveryResponse.AuthorizeEndpoint,
						TokenEndpoint = discoveryResponse.TokenEndpoint,
						EndSessionEndpoint = discoveryResponse.EndSessionEndpoint,
						UserInfoEndpoint = discoveryResponse.UserInfoEndpoint,
						TokenEndPointAuthenticationMethods = discoveryResponse.TokenEndpointAuthenticationMethodsSupported
					};
				}
			}
			if (this._options.ProviderInformation.IssuerName.IsMissing())
			{
				string message2 = "Issuer name is missing in provider information";
				this._logger.LogError(message2, new object[0]);
				throw new global::System.InvalidOperationException(message2);
			}
			if (this._options.ProviderInformation.AuthorizeEndpoint.IsMissing())
			{
				string message3 = "Authorize endpoint is missing in provider information";
				this._logger.LogError(message3, new object[0]);
				throw new global::System.InvalidOperationException(message3);
			}
			if (this._options.ProviderInformation.TokenEndpoint.IsMissing())
			{
				string message4 = "Token endpoint is missing in provider information";
				this._logger.LogError(message4, new object[0]);
				throw new global::System.InvalidOperationException(message4);
			}
			if (this._options.ProviderInformation.KeySet == null)
			{
				string message5 = "Key set is missing in provider information";
				this._logger.LogError(message5, new object[0]);
				throw new global::System.InvalidOperationException(message5);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000032FC File Offset: 0x000014FC
		internal global::System.Security.Claims.ClaimsPrincipal ProcessClaims(global::System.Security.Claims.ClaimsPrincipal user, global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> userInfoClaims)
		{
			this._logger.LogTrace("ProcessClaims", new object[0]);
			global::System.Collections.Generic.HashSet<global::System.Security.Claims.Claim> combinedClaims = new global::System.Collections.Generic.HashSet<global::System.Security.Claims.Claim>(new global::IdentityModel.ClaimComparer(true));
			user.Claims.ToList<global::System.Security.Claims.Claim>().ForEach(delegate(global::System.Security.Claims.Claim c)
			{
				combinedClaims.Add(c);
			});
			userInfoClaims.ToList<global::System.Security.Claims.Claim>().ForEach(delegate(global::System.Security.Claims.Claim c)
			{
				combinedClaims.Add(c);
			});
			global::System.Collections.Generic.List<global::System.Security.Claims.Claim> claims = new global::System.Collections.Generic.List<global::System.Security.Claims.Claim>();
			if (this._options.FilterClaims)
			{
				claims = (from c in combinedClaims
				where !this._options.FilteredClaims.Contains(c.Type)
				select c).ToList<global::System.Security.Claims.Claim>();
			}
			else
			{
				claims = combinedClaims.ToList<global::System.Security.Claims.Claim>();
			}
			return new global::System.Security.Claims.ClaimsPrincipal(new global::System.Security.Claims.ClaimsIdentity(claims, user.Identity.AuthenticationType, user.Identities.First<global::System.Security.Claims.ClaimsIdentity>().NameClaimType, user.Identities.First<global::System.Security.Claims.ClaimsIdentity>().RoleClaimType));
		}

		// Token: 0x04000023 RID: 35
		private readonly global::IdentityModel.OidcClient.OidcClientOptions _options;

		// Token: 0x04000024 RID: 36
		private readonly global::Microsoft.Extensions.Logging.ILogger _logger;

		// Token: 0x04000025 RID: 37
		private readonly global::IdentityModel.OidcClient.AuthorizeClient _authorizeClient;

		// Token: 0x04000026 RID: 38
		private readonly bool useDiscovery;

		// Token: 0x04000027 RID: 39
		private readonly global::IdentityModel.OidcClient.ResponseProcessor _processor;
	}
}
