using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Claims;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000045 RID: 69
	public class TokenValidationParameters
	{
		// Token: 0x060001BE RID: 446 RVA: 0x000073D0 File Offset: 0x000055D0
		protected TokenValidationParameters(global::Microsoft.IdentityModel.Tokens.TokenValidationParameters other)
		{
			if (other == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentNullException("other"));
			}
			global::Microsoft.IdentityModel.Tokens.TokenValidationParameters actorValidationParameters = other.ActorValidationParameters;
			this.ActorValidationParameters = ((actorValidationParameters != null) ? actorValidationParameters.Clone() : null);
			this.AudienceValidator = other.AudienceValidator;
			this._authenticationType = other._authenticationType;
			this.ClockSkew = other.ClockSkew;
			this.CryptoProviderFactory = other.CryptoProviderFactory;
			this.IssuerSigningKey = other.IssuerSigningKey;
			this.IssuerSigningKeyResolver = other.IssuerSigningKeyResolver;
			this.IssuerSigningKeys = other.IssuerSigningKeys;
			this.IssuerSigningKeyValidator = other.IssuerSigningKeyValidator;
			this.IssuerValidator = other.IssuerValidator;
			this.LifetimeValidator = other.LifetimeValidator;
			this.TokenReplayValidator = other.TokenReplayValidator;
			this.NameClaimType = other.NameClaimType;
			this.NameClaimTypeRetriever = other.NameClaimTypeRetriever;
			this.RequireExpirationTime = other.RequireExpirationTime;
			this.RequireSignedTokens = other.RequireSignedTokens;
			this.RoleClaimType = other.RoleClaimType;
			this.RoleClaimTypeRetriever = other.RoleClaimTypeRetriever;
			this.SaveSigninToken = other.SaveSigninToken;
			this.SignatureValidator = other.SignatureValidator;
			this.TokenDecryptionKey = other.TokenDecryptionKey;
			this.TokenDecryptionKeyResolver = other.TokenDecryptionKeyResolver;
			this.TokenDecryptionKeys = other.TokenDecryptionKeys;
			this.TokenReader = other.TokenReader;
			this.TokenReplayCache = other.TokenReplayCache;
			this.ValidateActor = other.ValidateActor;
			this.ValidateAudience = other.ValidateAudience;
			this.ValidateIssuer = other.ValidateIssuer;
			this.ValidateIssuerSigningKey = other.ValidateIssuerSigningKey;
			this.ValidateLifetime = other.ValidateLifetime;
			this.ValidateTokenReplay = other.ValidateTokenReplay;
			this.ValidAudience = other.ValidAudience;
			this.ValidAudiences = other.ValidAudiences;
			this.ValidIssuer = other.ValidIssuer;
			this.ValidIssuers = other.ValidIssuers;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000075C8 File Offset: 0x000057C8
		public TokenValidationParameters()
		{
			this.RequireExpirationTime = true;
			this.RequireSignedTokens = true;
			this.SaveSigninToken = false;
			this.ValidateActor = false;
			this.ValidateAudience = true;
			this.ValidateIssuer = true;
			this.ValidateIssuerSigningKey = false;
			this.ValidateLifetime = true;
			this.ValidateTokenReplay = false;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000763B File Offset: 0x0000583B
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00007643 File Offset: 0x00005843
		public global::Microsoft.IdentityModel.Tokens.TokenValidationParameters ActorValidationParameters { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000764C File Offset: 0x0000584C
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00007654 File Offset: 0x00005854
		public global::Microsoft.IdentityModel.Tokens.AudienceValidator AudienceValidator { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000765D File Offset: 0x0000585D
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00007665 File Offset: 0x00005865
		public global::Microsoft.IdentityModel.Tokens.TokenReader TokenReader { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000766E File Offset: 0x0000586E
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00007676 File Offset: 0x00005876
		public string AuthenticationType
		{
			get
			{
				return this._authenticationType;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentNullException("AuthenticationType"));
				}
				this._authenticationType = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00007697 File Offset: 0x00005897
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000769F File Offset: 0x0000589F
		[global::System.ComponentModel.DefaultValue(300)]
		public global::System.TimeSpan ClockSkew
		{
			get
			{
				return this._clockSkew;
			}
			set
			{
				if (value < global::System.TimeSpan.Zero)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("value", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10100: ClockSkew must be greater than TimeSpan.Zero. value: '{0}'", new object[]
					{
						value
					})));
				}
				this._clockSkew = value;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000076DE File Offset: 0x000058DE
		public virtual global::Microsoft.IdentityModel.Tokens.TokenValidationParameters Clone()
		{
			return new global::Microsoft.IdentityModel.Tokens.TokenValidationParameters(this);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000076E8 File Offset: 0x000058E8
		public virtual global::System.Security.Claims.ClaimsIdentity CreateClaimsIdentity(global::Microsoft.IdentityModel.Tokens.SecurityToken securityToken, string issuer)
		{
			string text;
			if (this.NameClaimTypeRetriever != null)
			{
				text = this.NameClaimTypeRetriever(securityToken, issuer);
			}
			else
			{
				text = this.NameClaimType;
			}
			string text2;
			if (this.RoleClaimTypeRetriever != null)
			{
				text2 = this.RoleClaimTypeRetriever(securityToken, issuer);
			}
			else
			{
				text2 = this.RoleClaimType;
			}
			global::Microsoft.IdentityModel.Logging.LogHelper.LogInformation("IDX10245: Creating claims identity from the validated token: '{0}'.", new object[]
			{
				securityToken
			});
			return new global::System.Security.Claims.ClaimsIdentity(this.AuthenticationType ?? global::Microsoft.IdentityModel.Tokens.TokenValidationParameters.DefaultAuthenticationType, text ?? "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", text2 ?? "http://schemas.microsoft.com/ws/2008/06/identity/claims/role");
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00007773 File Offset: 0x00005973
		// (set) Token: 0x060001CD RID: 461 RVA: 0x0000777B File Offset: 0x0000597B
		public global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory CryptoProviderFactory { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00007784 File Offset: 0x00005984
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0000778C File Offset: 0x0000598C
		public global::Microsoft.IdentityModel.Tokens.SecurityKey TokenDecryptionKey { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00007795 File Offset: 0x00005995
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x0000779D File Offset: 0x0000599D
		public global::Microsoft.IdentityModel.Tokens.TokenDecryptionKeyResolver TokenDecryptionKeyResolver { get; set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000077A6 File Offset: 0x000059A6
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x000077AE File Offset: 0x000059AE
		public global::Microsoft.IdentityModel.Tokens.IssuerSigningKeyValidator IssuerSigningKeyValidator { get; set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000077B7 File Offset: 0x000059B7
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x000077BF File Offset: 0x000059BF
		public global::Microsoft.IdentityModel.Tokens.SecurityKey IssuerSigningKey { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000077C8 File Offset: 0x000059C8
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x000077D0 File Offset: 0x000059D0
		public global::Microsoft.IdentityModel.Tokens.IssuerSigningKeyResolver IssuerSigningKeyResolver { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000077D9 File Offset: 0x000059D9
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x000077E1 File Offset: 0x000059E1
		public global::System.Collections.Generic.IEnumerable<global::Microsoft.IdentityModel.Tokens.SecurityKey> IssuerSigningKeys { get; set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000077EA File Offset: 0x000059EA
		// (set) Token: 0x060001DB RID: 475 RVA: 0x000077F2 File Offset: 0x000059F2
		public global::Microsoft.IdentityModel.Tokens.IssuerValidator IssuerValidator { get; set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001DC RID: 476 RVA: 0x000077FB File Offset: 0x000059FB
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00007803 File Offset: 0x00005A03
		public global::Microsoft.IdentityModel.Tokens.LifetimeValidator LifetimeValidator { get; set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000780C File Offset: 0x00005A0C
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00007814 File Offset: 0x00005A14
		public global::Microsoft.IdentityModel.Tokens.TokenReplayValidator TokenReplayValidator { get; set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000781D File Offset: 0x00005A1D
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00007825 File Offset: 0x00005A25
		public string NameClaimType
		{
			get
			{
				return this._nameClaimType;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("value", "IDX10102: NameClaimType cannot be null or whitespace."));
				}
				this._nameClaimType = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000784B File Offset: 0x00005A4B
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00007853 File Offset: 0x00005A53
		public string RoleClaimType
		{
			get
			{
				return this._roleClaimType;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("value", "IDX10103: RoleClaimType cannot be null or whitespace."));
				}
				this._roleClaimType = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00007879 File Offset: 0x00005A79
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00007881 File Offset: 0x00005A81
		public global::System.Func<global::Microsoft.IdentityModel.Tokens.SecurityToken, string, string> NameClaimTypeRetriever { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000788A File Offset: 0x00005A8A
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00007892 File Offset: 0x00005A92
		[global::System.ComponentModel.DefaultValue(true)]
		public bool RequireExpirationTime { get; set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000789B File Offset: 0x00005A9B
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x000078A3 File Offset: 0x00005AA3
		[global::System.ComponentModel.DefaultValue(true)]
		public bool RequireSignedTokens { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000078AC File Offset: 0x00005AAC
		// (set) Token: 0x060001EB RID: 491 RVA: 0x000078B4 File Offset: 0x00005AB4
		public global::System.Func<global::Microsoft.IdentityModel.Tokens.SecurityToken, string, string> RoleClaimTypeRetriever { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000078BD File Offset: 0x00005ABD
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000078C5 File Offset: 0x00005AC5
		[global::System.ComponentModel.DefaultValue(false)]
		public bool SaveSigninToken { get; set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000078CE File Offset: 0x00005ACE
		// (set) Token: 0x060001EF RID: 495 RVA: 0x000078D6 File Offset: 0x00005AD6
		public global::Microsoft.IdentityModel.Tokens.SignatureValidator SignatureValidator { get; set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x000078DF File Offset: 0x00005ADF
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x000078E7 File Offset: 0x00005AE7
		public global::System.Collections.Generic.IEnumerable<global::Microsoft.IdentityModel.Tokens.SecurityKey> TokenDecryptionKeys { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x000078F0 File Offset: 0x00005AF0
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x000078F8 File Offset: 0x00005AF8
		public global::Microsoft.IdentityModel.Tokens.ITokenReplayCache TokenReplayCache { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00007901 File Offset: 0x00005B01
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00007909 File Offset: 0x00005B09
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ValidateActor { get; set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00007912 File Offset: 0x00005B12
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000791A File Offset: 0x00005B1A
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ValidateAudience { get; set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00007923 File Offset: 0x00005B23
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000792B File Offset: 0x00005B2B
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ValidateIssuer { get; set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00007934 File Offset: 0x00005B34
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0000793C File Offset: 0x00005B3C
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ValidateLifetime { get; set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00007945 File Offset: 0x00005B45
		// (set) Token: 0x060001FD RID: 509 RVA: 0x0000794D File Offset: 0x00005B4D
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ValidateIssuerSigningKey { get; set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00007956 File Offset: 0x00005B56
		// (set) Token: 0x060001FF RID: 511 RVA: 0x0000795E File Offset: 0x00005B5E
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ValidateTokenReplay { get; set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00007967 File Offset: 0x00005B67
		// (set) Token: 0x06000201 RID: 513 RVA: 0x0000796F File Offset: 0x00005B6F
		public string ValidAudience { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00007978 File Offset: 0x00005B78
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00007980 File Offset: 0x00005B80
		public global::System.Collections.Generic.IEnumerable<string> ValidAudiences { get; set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00007989 File Offset: 0x00005B89
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00007991 File Offset: 0x00005B91
		public string ValidIssuer { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000799A File Offset: 0x00005B9A
		// (set) Token: 0x06000207 RID: 519 RVA: 0x000079A2 File Offset: 0x00005BA2
		public global::System.Collections.Generic.IEnumerable<string> ValidIssuers { get; set; }

		// Token: 0x04000168 RID: 360
		private string _authenticationType;

		// Token: 0x04000169 RID: 361
		private global::System.TimeSpan _clockSkew = global::Microsoft.IdentityModel.Tokens.TokenValidationParameters.DefaultClockSkew;

		// Token: 0x0400016A RID: 362
		private string _nameClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";

		// Token: 0x0400016B RID: 363
		private string _roleClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";

		// Token: 0x0400016C RID: 364
		public static readonly string DefaultAuthenticationType = "AuthenticationTypes.Federation";

		// Token: 0x0400016D RID: 365
		public static readonly global::System.TimeSpan DefaultClockSkew = global::System.TimeSpan.FromSeconds(300.0);

		// Token: 0x0400016E RID: 366
		public const int DefaultMaximumTokenSizeInBytes = 2097152;
	}
}
