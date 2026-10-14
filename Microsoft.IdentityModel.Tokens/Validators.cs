using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200004A RID: 74
	public static class Validators
	{
		// Token: 0x06000229 RID: 553 RVA: 0x0000806C File Offset: 0x0000626C
		public static void ValidateAudience(global::System.Collections.Generic.IEnumerable<string> audiences, global::Microsoft.IdentityModel.Tokens.SecurityToken securityToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (validationParameters == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("validationParameters");
			}
			if (!validationParameters.ValidateAudience)
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogWarning("IDX10233: ValidateAudience property on ValidationParameters is set to false. Exiting without validating the audience.", new object[0]);
				return;
			}
			if (validationParameters.AudienceValidator != null)
			{
				validationParameters.AudienceValidator(audiences, securityToken, validationParameters);
				if (!validationParameters.AudienceValidator(audiences, securityToken, validationParameters))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidAudienceException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10231: Audience validation failed. Delegate returned false, securitytoken: '{0}'.", new object[]
					{
						securityToken
					}))
					{
						InvalidAudience = global::Microsoft.IdentityModel.Tokens.Utility.SerializeAsSingleCommaDelimitedString(audiences)
					});
				}
				return;
			}
			else
			{
				if (audiences == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidAudienceException("IDX10207: Unable to validate audience. The 'audiences' parameter is null.")
					{
						InvalidAudience = null
					});
				}
				if (string.IsNullOrWhiteSpace(validationParameters.ValidAudience) && validationParameters.ValidAudiences == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidAudienceException("IDX10208: Unable to validate audience. validationParameters.ValidAudience is null or whitespace and validationParameters.ValidAudiences is null.")
					{
						InvalidAudience = global::Microsoft.IdentityModel.Tokens.Utility.SerializeAsSingleCommaDelimitedString(audiences)
					});
				}
				foreach (string text in audiences)
				{
					if (!string.IsNullOrWhiteSpace(text))
					{
						if (validationParameters.ValidAudiences != null)
						{
							foreach (string b in validationParameters.ValidAudiences)
							{
								if (string.Equals(text, b, global::System.StringComparison.Ordinal))
								{
									global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10234: Audience Validated.Audience: '{0}'", new object[]
									{
										text
									});
									return;
								}
							}
						}
						if (!string.IsNullOrWhiteSpace(validationParameters.ValidAudience) && string.Equals(text, validationParameters.ValidAudience, global::System.StringComparison.Ordinal))
						{
							global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10234: Audience Validated.Audience: '{0}'", new object[]
							{
								text
							});
							return;
						}
					}
				}
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidAudienceException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10214: Audience validation failed. Audiences: '{0}'. Did not match: validationParameters.ValidAudience: '{1}' or validationParameters.ValidAudiences: '{2}'.", new object[]
				{
					global::Microsoft.IdentityModel.Tokens.Utility.SerializeAsSingleCommaDelimitedString(audiences),
					validationParameters.ValidAudience ?? "null",
					global::Microsoft.IdentityModel.Tokens.Utility.SerializeAsSingleCommaDelimitedString(validationParameters.ValidAudiences)
				}))
				{
					InvalidAudience = global::Microsoft.IdentityModel.Tokens.Utility.SerializeAsSingleCommaDelimitedString(audiences)
				});
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00008268 File Offset: 0x00006468
		public static string ValidateIssuer(string issuer, global::Microsoft.IdentityModel.Tokens.SecurityToken securityToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (validationParameters == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("validationParameters");
			}
			if (!validationParameters.ValidateIssuer)
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10235: ValidateIssuer property on ValidationParameters is set to false. Exiting without validating the issuer.", new object[0]);
				return issuer;
			}
			if (validationParameters.IssuerValidator != null)
			{
				return validationParameters.IssuerValidator(issuer, securityToken, validationParameters);
			}
			if (string.IsNullOrWhiteSpace(issuer))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidIssuerException("IDX10211: Unable to validate issuer. The 'issuer' parameter is null or whitespace")
				{
					InvalidIssuer = issuer
				});
			}
			if (string.IsNullOrWhiteSpace(validationParameters.ValidIssuer) && validationParameters.ValidIssuers == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidIssuerException("IDX10204: Unable to validate issuer. validationParameters.ValidIssuer is null or whitespace AND validationParameters.ValidIssuers is null.")
				{
					InvalidIssuer = issuer
				});
			}
			if (string.Equals(validationParameters.ValidIssuer, issuer, global::System.StringComparison.Ordinal))
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10236: Issuer Validated.Issuer: '{0}'", new object[]
				{
					issuer
				});
				return issuer;
			}
			if (validationParameters.ValidIssuers != null)
			{
				foreach (string text in validationParameters.ValidIssuers)
				{
					if (string.IsNullOrEmpty(text))
					{
						global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10235: ValidateIssuer property on ValidationParameters is set to false. Exiting without validating the issuer.", new object[0]);
					}
					else if (string.Equals(text, issuer, global::System.StringComparison.Ordinal))
					{
						global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10236: Issuer Validated.Issuer: '{0}'", new object[]
						{
							issuer
						});
						return issuer;
					}
				}
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidIssuerException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10205: Issuer validation failed. Issuer: '{0}'. Did not match: validationParameters.ValidIssuer: '{1}' or validationParameters.ValidIssuers: '{2}'.", new object[]
			{
				issuer,
				validationParameters.ValidIssuer ?? "null",
				global::Microsoft.IdentityModel.Tokens.Utility.SerializeAsSingleCommaDelimitedString(validationParameters.ValidIssuers)
			}))
			{
				InvalidIssuer = issuer
			});
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000083E8 File Offset: 0x000065E8
		public static void ValidateIssuerSecurityKey(global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey, global::Microsoft.IdentityModel.Tokens.SecurityToken securityToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (validationParameters == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("validationParameters");
			}
			if (!validationParameters.ValidateIssuerSigningKey)
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10237: ValidateIssuerSigningKey property on ValidationParameters is set to false. Exiting without validating the issuer signing key.", new object[0]);
				return;
			}
			if (validationParameters.IssuerSigningKeyValidator != null && !validationParameters.IssuerSigningKeyValidator(securityKey, securityToken, validationParameters))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSigningKeyException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10232: IssuerSigningKey validation failed. Delegate returned false, securityKey: '{0}'.", new object[]
				{
					securityKey
				}))
				{
					SigningKey = securityKey
				});
			}
			if (securityKey == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("securityKey");
			}
			if (securityToken == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("securityToken");
			}
			global::Microsoft.IdentityModel.Tokens.X509SecurityKey x509SecurityKey = securityKey as global::Microsoft.IdentityModel.Tokens.X509SecurityKey;
			if (x509SecurityKey != null)
			{
				global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate = x509SecurityKey.Certificate;
				global::System.DateTime utcNow = global::System.DateTime.UtcNow;
				global::System.DateTime notBefore = certificate.NotBefore;
				if (certificate.NotBefore > global::Microsoft.IdentityModel.Tokens.DateTimeUtil.Add(utcNow, validationParameters.ClockSkew))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSigningKeyException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10248: X509SecurityKey validation failed. The associated certificate is not yet valid. ValidFrom: '{0}', Current time: '{1}'.", new object[]
					{
						certificate.NotBefore,
						utcNow
					})));
				}
				global::System.DateTime notAfter = certificate.NotAfter;
				if (certificate.NotAfter < global::Microsoft.IdentityModel.Tokens.DateTimeUtil.Add(utcNow, validationParameters.ClockSkew.Negate()))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidSigningKeyException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10249: X509SecurityKey validation failed. The associated certificate has expired. ValidTo: '{0}', Current time: '{1}'.", new object[]
					{
						certificate.NotAfter,
						utcNow
					})));
				}
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000853C File Offset: 0x0000673C
		public static void ValidateLifetime(global::System.DateTime? notBefore, global::System.DateTime? expires, global::Microsoft.IdentityModel.Tokens.SecurityToken securityToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (validationParameters == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("validationParameters");
			}
			if (!validationParameters.ValidateLifetime)
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10238: ValidateLifetime property on ValidationParameters is set to false. Exiting without validating the lifetime.", new object[0]);
				return;
			}
			if (validationParameters.LifetimeValidator != null)
			{
				if (!validationParameters.LifetimeValidator(notBefore, expires, securityToken, validationParameters))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidLifetimeException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10230: Lifetime validation failed. Delegate returned false, securitytoken: '{0}'.", new object[]
					{
						securityToken
					}))
					{
						NotBefore = notBefore,
						Expires = expires
					});
				}
				return;
			}
			else
			{
				if (expires == null && validationParameters.RequireExpirationTime)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenNoExpirationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10225: Lifetime validation failed. The token is missing an Expiration Time. Tokentype: '{0}'.", new object[]
					{
						(securityToken == null) ? "null" : securityToken.GetType().ToString()
					})));
				}
				if (notBefore != null && expires != null && notBefore.Value > expires.Value)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenInvalidLifetimeException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10224: Lifetime validation failed. The NotBefore: '{0}' is after Expires: '{1}'.", new object[]
					{
						notBefore.Value,
						expires.Value
					}))
					{
						NotBefore = notBefore,
						Expires = expires
					});
				}
				global::System.DateTime utcNow = global::System.DateTime.UtcNow;
				if (notBefore != null && notBefore.Value > global::Microsoft.IdentityModel.Tokens.DateTimeUtil.Add(utcNow, validationParameters.ClockSkew))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenNotYetValidException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10222: Lifetime validation failed. The token is not yet valid. ValidFrom: '{0}', Current time: '{1}'.", new object[]
					{
						notBefore.Value,
						utcNow
					}))
					{
						NotBefore = notBefore.Value
					});
				}
				if (expires != null && expires.Value < global::Microsoft.IdentityModel.Tokens.DateTimeUtil.Add(utcNow, validationParameters.ClockSkew.Negate()))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenExpiredException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10223: Lifetime validation failed. The token is expired. ValidTo: '{0}', Current time: '{1}'.", new object[]
					{
						expires.Value,
						utcNow
					}))
					{
						Expires = expires.Value
					});
				}
				global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10239: Lifetime of the token is valid.", new object[0]);
				return;
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00008750 File Offset: 0x00006950
		public static void ValidateTokenReplay(global::System.DateTime? expirationTime, string securityToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			if (string.IsNullOrWhiteSpace(securityToken))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("securityToken");
			}
			if (validationParameters == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("validationParameters");
			}
			if (!validationParameters.ValidateTokenReplay)
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10246: ValidateTokenReplay property on ValidationParameters is set to false. Exiting without validating the token replay.", new object[0]);
				return;
			}
			if (validationParameters.TokenReplayValidator == null)
			{
				if (validationParameters.TokenReplayCache != null)
				{
					if (expirationTime == null)
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenNoExpirationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10227: TokenValidationParameters.TokenReplayCache is not null, indicating to check for token replay but the security token has no expiration time: token '{0}'.", new object[]
						{
							securityToken
						})));
					}
					if (validationParameters.TokenReplayCache.TryFind(securityToken))
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenReplayDetectedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10228: The securityToken has previously been validated, securityToken: '{0}'.", new object[]
						{
							securityToken
						})));
					}
					if (!validationParameters.TokenReplayCache.TryAdd(securityToken, expirationTime.Value))
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenReplayAddFailedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10229: TokenValidationParameters.TokenReplayCache was unable to add the securityToken: '{0}'.", new object[]
						{
							securityToken
						})));
					}
				}
				global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10240: No token replay is detected.", new object[0]);
				return;
			}
			if (!validationParameters.TokenReplayValidator(expirationTime, securityToken, validationParameters))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenReplayDetectedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10228: The securityToken has previously been validated, securityToken: '{0}'.", new object[]
				{
					securityToken
				})));
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00008873 File Offset: 0x00006A73
		public static void ValidateTokenReplay(string securityToken, global::System.DateTime? expirationTime, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters)
		{
			global::Microsoft.IdentityModel.Tokens.Validators.ValidateTokenReplay(expirationTime, securityToken, validationParameters);
		}
	}
}
