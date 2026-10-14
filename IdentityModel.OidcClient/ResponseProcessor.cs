using System;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using IdentityModel.Client;
using IdentityModel.OidcClient.Infrastructure;
using IdentityModel.OidcClient.Results;
using Microsoft.Extensions.Logging;

namespace IdentityModel.OidcClient
{
	// Token: 0x0200001A RID: 26
	internal class ResponseProcessor
	{
		// Token: 0x06000095 RID: 149 RVA: 0x000049F8 File Offset: 0x00002BF8
		public ResponseProcessor(global::IdentityModel.OidcClient.OidcClientOptions options, global::System.Func<global::System.Threading.Tasks.Task> refreshKeysAsync)
		{
			this._options = options;
			this._refreshKeysAsync = refreshKeysAsync;
			this._logger = options.LoggerFactory.CreateLogger<global::IdentityModel.OidcClient.ResponseProcessor>();
			this._tokenValidator = new global::IdentityModel.OidcClient.IdentityTokenValidator(options, refreshKeysAsync);
			this._crypto = new global::IdentityModel.OidcClient.CryptoHelper(options);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004A38 File Offset: 0x00002C38
		public async global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.ResponseValidationResult> ProcessResponseAsync(global::IdentityModel.Client.AuthorizeResponse authorizeResponse, global::IdentityModel.OidcClient.AuthorizeState state)
		{
			this._logger.LogTrace("ProcessResponseAsync", new object[0]);
			global::IdentityModel.OidcClient.ResponseValidationResult result;
			if (string.IsNullOrEmpty(authorizeResponse.Code))
			{
				result = new global::IdentityModel.OidcClient.ResponseValidationResult("Missing authorization code.");
			}
			else if (string.IsNullOrEmpty(authorizeResponse.State))
			{
				result = new global::IdentityModel.OidcClient.ResponseValidationResult("Missing state.");
			}
			else if (!string.Equals(state.State, authorizeResponse.State, global::System.StringComparison.Ordinal))
			{
				result = new global::IdentityModel.OidcClient.ResponseValidationResult("Invalid state.");
			}
			else
			{
				global::IdentityModel.OidcClient.OidcClientOptions.AuthenticationFlow flow = this._options.Flow;
				if (flow != global::IdentityModel.OidcClient.OidcClientOptions.AuthenticationFlow.AuthorizationCode)
				{
					if (flow != global::IdentityModel.OidcClient.OidcClientOptions.AuthenticationFlow.Hybrid)
					{
						throw new global::System.ArgumentOutOfRangeException("Flow", "Invalid authentication style.");
					}
					result = await this.ProcessHybridFlowResponseAsync(authorizeResponse, state);
				}
				else
				{
					result = await this.ProcessCodeFlowResponseAsync(authorizeResponse, state);
				}
			}
			return result;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004A90 File Offset: 0x00002C90
		private async global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.ResponseValidationResult> ProcessHybridFlowResponseAsync(global::IdentityModel.Client.AuthorizeResponse authorizeResponse, global::IdentityModel.OidcClient.AuthorizeState state)
		{
			this._logger.LogTrace("ProcessHybridFlowResponseAsync", new object[0]);
			global::IdentityModel.OidcClient.ResponseValidationResult result;
			if (authorizeResponse.IdentityToken.IsMissing())
			{
				result = new global::IdentityModel.OidcClient.ResponseValidationResult("Missing identity token.");
			}
			else
			{
				global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult identityTokenValidationResult = await this._tokenValidator.ValidateAsync(authorizeResponse.IdentityToken);
				global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult frontChannelValidationResult = identityTokenValidationResult;
				if (frontChannelValidationResult.IsError)
				{
					result = new global::IdentityModel.OidcClient.ResponseValidationResult(frontChannelValidationResult.Error ?? "Identity token validation error.");
				}
				else if (!this.ValidateNonce(state.Nonce, frontChannelValidationResult.User))
				{
					result = new global::IdentityModel.OidcClient.ResponseValidationResult("Invalid nonce.");
				}
				else
				{
					global::System.Security.Claims.Claim claim = frontChannelValidationResult.User.FindFirst("c_hash");
					if (claim == null)
					{
						if (this._options.Policy.RequireAuthorizationCodeHash)
						{
							return new global::IdentityModel.OidcClient.ResponseValidationResult("c_hash is missing.");
						}
					}
					else if (!this._crypto.ValidateHash(authorizeResponse.Code, claim.Value, frontChannelValidationResult.SignatureAlgorithm))
					{
						return new global::IdentityModel.OidcClient.ResponseValidationResult("Invalid c_hash.");
					}
					global::IdentityModel.Client.TokenResponse tokenResponse = await this.RedeemCodeAsync(authorizeResponse.Code, state);
					if (tokenResponse.IsError)
					{
						result = new global::IdentityModel.OidcClient.ResponseValidationResult(tokenResponse.Error);
					}
					else
					{
						global::IdentityModel.OidcClient.Results.TokenResponseValidationResult tokenResponseValidationResult = await this.ValidateTokenResponseAsync(tokenResponse, state, true);
						if (tokenResponseValidationResult.IsError)
						{
							result = new global::IdentityModel.OidcClient.ResponseValidationResult(tokenResponseValidationResult.Error);
						}
						else
						{
							string value = frontChannelValidationResult.User.FindFirst("sub").Value;
							string value2 = tokenResponseValidationResult.IdentityTokenValidationResult.User.FindFirst("sub").Value;
							if (!string.Equals(value, value2, global::System.StringComparison.Ordinal))
							{
								result = new global::IdentityModel.OidcClient.ResponseValidationResult(string.Format("Subject on front-channel ({0}) does not match subject on back-channel ({1}).", value, value2));
							}
							else
							{
								result = new global::IdentityModel.OidcClient.ResponseValidationResult
								{
									AuthorizeResponse = authorizeResponse,
									TokenResponse = tokenResponse,
									User = tokenResponseValidationResult.IdentityTokenValidationResult.User
								};
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004AE8 File Offset: 0x00002CE8
		private async global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.ResponseValidationResult> ProcessCodeFlowResponseAsync(global::IdentityModel.Client.AuthorizeResponse authorizeResponse, global::IdentityModel.OidcClient.AuthorizeState state)
		{
			this._logger.LogTrace("ProcessCodeFlowResponseAsync", new object[0]);
			global::IdentityModel.Client.TokenResponse tokenResponse2 = await this.RedeemCodeAsync(authorizeResponse.Code, state);
			global::IdentityModel.Client.TokenResponse tokenResponse = tokenResponse2;
			global::IdentityModel.OidcClient.ResponseValidationResult result;
			if (tokenResponse.IsError)
			{
				result = new global::IdentityModel.OidcClient.ResponseValidationResult(string.Format("Error redeeming code: {0} / {1}", tokenResponse.Error ?? "no error code", tokenResponse.ErrorDescription ?? "no description"));
			}
			else
			{
				global::IdentityModel.OidcClient.Results.TokenResponseValidationResult tokenResponseValidationResult = await this.ValidateTokenResponseAsync(tokenResponse, state, true);
				if (tokenResponseValidationResult.IsError)
				{
					result = new global::IdentityModel.OidcClient.ResponseValidationResult(string.Format("Error validating token response: {0}", tokenResponseValidationResult.Error));
				}
				else
				{
					result = new global::IdentityModel.OidcClient.ResponseValidationResult
					{
						AuthorizeResponse = authorizeResponse,
						TokenResponse = tokenResponse,
						User = tokenResponseValidationResult.IdentityTokenValidationResult.User
					};
				}
			}
			return result;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004B40 File Offset: 0x00002D40
		internal async global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.Results.TokenResponseValidationResult> ValidateTokenResponseAsync(global::IdentityModel.Client.TokenResponse response, global::IdentityModel.OidcClient.AuthorizeState state, bool requireIdentityToken = true)
		{
			this._logger.LogTrace("ValidateTokenResponse", new object[0]);
			global::IdentityModel.OidcClient.Results.TokenResponseValidationResult result;
			if (response.AccessToken.IsMissing())
			{
				result = new global::IdentityModel.OidcClient.Results.TokenResponseValidationResult("Access token is missing on token response.");
			}
			else if (requireIdentityToken && response.IdentityToken.IsMissing())
			{
				result = new global::IdentityModel.OidcClient.Results.TokenResponseValidationResult("Identity token is missing on token response.");
			}
			else if (response.IdentityToken.IsPresent())
			{
				global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult identityTokenValidationResult = await this._tokenValidator.ValidateAsync(response.IdentityToken);
				if (identityTokenValidationResult.IsError)
				{
					result = new global::IdentityModel.OidcClient.Results.TokenResponseValidationResult(identityTokenValidationResult.Error ?? "Identity token validation error");
				}
				else if (state != null && !this.ValidateNonce(state.Nonce, identityTokenValidationResult.User))
				{
					result = new global::IdentityModel.OidcClient.Results.TokenResponseValidationResult("Invalid nonce.");
				}
				else
				{
					global::System.Security.Claims.Claim claim = identityTokenValidationResult.User.FindFirst("at_hash");
					if (claim == null)
					{
						if (this._options.Policy.RequireAccessTokenHash)
						{
							return new global::IdentityModel.OidcClient.Results.TokenResponseValidationResult("at_hash is missing.");
						}
					}
					else if (!this._crypto.ValidateHash(response.AccessToken, claim.Value, identityTokenValidationResult.SignatureAlgorithm))
					{
						return new global::IdentityModel.OidcClient.Results.TokenResponseValidationResult("Invalid access token hash.");
					}
					result = new global::IdentityModel.OidcClient.Results.TokenResponseValidationResult(identityTokenValidationResult);
				}
			}
			else
			{
				result = new global::IdentityModel.OidcClient.Results.TokenResponseValidationResult(null);
			}
			return result;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004BA0 File Offset: 0x00002DA0
		private bool ValidateNonce(string nonce, global::System.Security.Claims.ClaimsPrincipal user)
		{
			this._logger.LogTrace("ValidateNonce", new object[0]);
			global::System.Security.Claims.Claim claim = user.FindFirst("nonce");
			string text = ((claim != null) ? claim.Value : null) ?? "";
			bool flag = string.Equals(nonce, text, global::System.StringComparison.Ordinal);
			if (!flag)
			{
				this._logger.LogError(string.Format("nonce ({0}) does not match nonce from token ({1})", nonce, text), new object[0]);
			}
			return flag;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004C10 File Offset: 0x00002E10
		private async global::System.Threading.Tasks.Task<global::IdentityModel.Client.TokenResponse> RedeemCodeAsync(string code, global::IdentityModel.OidcClient.AuthorizeState state)
		{
			this._logger.LogTrace("RedeemCodeAsync", new object[0]);
			return await this.GetTokenClient().RequestAuthorizationCodeAsync(code, state.RedirectUri, state.CodeVerifier, null, default(global::System.Threading.CancellationToken));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004C68 File Offset: 0x00002E68
		private global::IdentityModel.Client.TokenClient GetTokenClient()
		{
			if (this._tokenClient == null)
			{
				this._tokenClient = global::IdentityModel.OidcClient.Infrastructure.TokenClientFactory.Create(this._options);
			}
			return this._tokenClient;
		}

		// Token: 0x04000081 RID: 129
		private readonly global::IdentityModel.OidcClient.OidcClientOptions _options;

		// Token: 0x04000082 RID: 130
		private global::IdentityModel.Client.TokenClient _tokenClient;

		// Token: 0x04000083 RID: 131
		private global::Microsoft.Extensions.Logging.ILogger<global::IdentityModel.OidcClient.ResponseProcessor> _logger;

		// Token: 0x04000084 RID: 132
		private readonly global::IdentityModel.OidcClient.IdentityTokenValidator _tokenValidator;

		// Token: 0x04000085 RID: 133
		private readonly global::IdentityModel.OidcClient.CryptoHelper _crypto;

		// Token: 0x04000086 RID: 134
		private readonly global::System.Func<global::System.Threading.Tasks.Task> _refreshKeysAsync;
	}
}
