using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using IdentityModel.Jwk;
using IdentityModel.OidcClient.Results;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace IdentityModel.OidcClient
{
	// Token: 0x02000007 RID: 7
	internal class IdentityTokenValidator
	{
		// Token: 0x0600001F RID: 31 RVA: 0x0000291C File Offset: 0x00000B1C
		public IdentityTokenValidator(global::IdentityModel.OidcClient.OidcClientOptions options, global::System.Func<global::System.Threading.Tasks.Task> refreshKeysAsync)
		{
			this._options = options;
			this._logger = options.LoggerFactory.CreateLogger<global::IdentityModel.OidcClient.IdentityTokenValidator>();
			this._refreshKeysAsync = refreshKeysAsync;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002944 File Offset: 0x00000B44
		public async global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult> ValidateAsync(string identityToken)
		{
			this._logger.LogTrace("Validate", new object[0]);
			global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler handler = new global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
			handler.InboundClaimTypeMap.Clear();
			global::Microsoft.IdentityModel.Tokens.TokenValidationParameters parameters = new global::Microsoft.IdentityModel.Tokens.TokenValidationParameters
			{
				ValidIssuer = this._options.ProviderInformation.IssuerName,
				ValidAudience = this._options.ClientId,
				NameClaimType = "name",
				RoleClaimType = "role",
				ClockSkew = this._options.ClockSkew
			};
			global::System.IdentityModel.Tokens.Jwt.JwtSecurityToken jwt;
			try
			{
				jwt = handler.ReadJwtToken(identityToken);
			}
			catch (global::System.Exception ex)
			{
				return new global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult
				{
					Error = string.Format("Error validating identity token: {0}", ex.ToString())
				};
			}
			string algorithm = jwt.Header.Alg;
			if (string.Equals(algorithm, "none"))
			{
				if (this._options.Policy.RequireIdentityTokenSignature)
				{
					return new global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult
					{
						Error = "Identity token is not singed. Signatures are required by policy"
					};
				}
				this._logger.LogInformation("Identity token is not signed. This is allowed by configuration.", new object[0]);
				parameters.RequireSignedTokens = false;
			}
			else if (!this._options.Policy.ValidSignatureAlgorithms.Contains(algorithm))
			{
				return new global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult
				{
					Error = string.Format("Identity token uses invalid algorithm: {0}", algorithm)
				};
			}
			int num = 0;
			global::System.Security.Claims.ClaimsPrincipal user;
			try
			{
				user = this.ValidateSignature(identityToken, handler, parameters);
			}
			catch (global::Microsoft.IdentityModel.Tokens.SecurityTokenSignatureKeyNotFoundException obj)
			{
				num = 1;
			}
			catch (global::System.Exception ex2)
			{
				return new global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult
				{
					Error = string.Format("Error validating identity token: {0}", ex2.ToString())
				};
			}
			if (num == 1)
			{
				object obj;
				global::Microsoft.IdentityModel.Tokens.SecurityTokenSignatureKeyNotFoundException sigEx = (global::Microsoft.IdentityModel.Tokens.SecurityTokenSignatureKeyNotFoundException)obj;
				if (this._options.RefreshDiscoveryOnSignatureFailure)
				{
					this._logger.LogWarning("Key for validating token signature cannot be found. Refreshing keyset.", new object[0]);
					await this._refreshKeysAsync();
					try
					{
						user = this.ValidateSignature(identityToken, handler, parameters);
						goto IL_2E8;
					}
					catch (global::System.Exception ex3)
					{
						return new global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult
						{
							Error = string.Format("Error validating identity token: {0}", ex3.ToString())
						};
					}
					goto IL_2C5;
					IL_2E8:
					sigEx = null;
					goto IL_2EF;
				}
				IL_2C5:
				return new global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult
				{
					Error = string.Format("Error validating identity token: {0}", sigEx.ToString())
				};
			}
			IL_2EF:
			string text = this.CheckRequiredClaim(user);
			global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult result;
			if (text.IsPresent())
			{
				result = new global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult
				{
					Error = text
				};
			}
			else
			{
				result = new global::IdentityModel.OidcClient.Results.IdentityTokenValidationResult
				{
					User = user,
					SignatureAlgorithm = algorithm
				};
			}
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002994 File Offset: 0x00000B94
		private global::System.Security.Claims.ClaimsPrincipal ValidateSignature(string identityToken, global::System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler handler, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters parameters)
		{
			if (parameters.RequireSignedTokens)
			{
				global::System.Collections.Generic.List<global::Microsoft.IdentityModel.Tokens.SecurityKey> list = new global::System.Collections.Generic.List<global::Microsoft.IdentityModel.Tokens.SecurityKey>();
				foreach (global::IdentityModel.Jwk.JsonWebKey jsonWebKey in this._options.ProviderInformation.KeySet.Keys)
				{
					if (jsonWebKey.E.IsPresent() && jsonWebKey.N.IsPresent())
					{
						if (jsonWebKey.Use == "sig")
						{
							byte[] exponent = global::IdentityModel.Base64Url.Decode(jsonWebKey.E);
							byte[] modulus = global::IdentityModel.Base64Url.Decode(jsonWebKey.N);
							global::Microsoft.IdentityModel.Tokens.RsaSecurityKey rsaSecurityKey = new global::Microsoft.IdentityModel.Tokens.RsaSecurityKey(new global::System.Security.Cryptography.RSAParameters
							{
								Exponent = exponent,
								Modulus = modulus
							});
							rsaSecurityKey.KeyId = jsonWebKey.Kid;
							list.Add(rsaSecurityKey);
							this._logger.LogDebug("Added signing key with kid: {kid}", new object[]
							{
								((rsaSecurityKey != null) ? rsaSecurityKey.KeyId : null) ?? "not set"
							});
						}
					}
					else
					{
						this._logger.LogDebug("Signing key with kid: {kid} currently not supported", new object[]
						{
							jsonWebKey.Kid ?? "not set"
						});
					}
				}
				parameters.IssuerSigningKeys = list;
			}
			global::Microsoft.IdentityModel.Tokens.SecurityToken securityToken;
			return handler.ValidateToken(identityToken, parameters, out securityToken);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002AF4 File Offset: 0x00000CF4
		private string CheckRequiredClaim(global::System.Security.Claims.ClaimsPrincipal user)
		{
			foreach (string text in new global::System.Collections.Generic.List<string>
			{
				"iss",
				"sub",
				"iat",
				"aud",
				"exp"
			})
			{
				if (user.FindFirst(text) == null)
				{
					return string.Format("{0} claim is missing", text);
				}
			}
			return null;
		}

		// Token: 0x04000015 RID: 21
		private readonly global::Microsoft.Extensions.Logging.ILogger _logger;

		// Token: 0x04000016 RID: 22
		private readonly global::IdentityModel.OidcClient.OidcClientOptions _options;

		// Token: 0x04000017 RID: 23
		private readonly global::System.Func<global::System.Threading.Tasks.Task> _refreshKeysAsync;
	}
}
