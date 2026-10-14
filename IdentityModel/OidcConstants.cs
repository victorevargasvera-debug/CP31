using System;

namespace IdentityModel
{
	// Token: 0x0200000B RID: 11
	public static class OidcConstants
	{
		// Token: 0x0200000C RID: 12
		public static class AuthorizeRequest
		{
			// Token: 0x0400002D RID: 45
			public const string Scope = "scope";

			// Token: 0x0400002E RID: 46
			public const string ResponseType = "response_type";

			// Token: 0x0400002F RID: 47
			public const string ClientId = "client_id";

			// Token: 0x04000030 RID: 48
			public const string RedirectUri = "redirect_uri";

			// Token: 0x04000031 RID: 49
			public const string State = "state";

			// Token: 0x04000032 RID: 50
			public const string ResponseMode = "response_mode";

			// Token: 0x04000033 RID: 51
			public const string Nonce = "nonce";

			// Token: 0x04000034 RID: 52
			public const string Display = "display";

			// Token: 0x04000035 RID: 53
			public const string Prompt = "prompt";

			// Token: 0x04000036 RID: 54
			public const string MaxAge = "max_age";

			// Token: 0x04000037 RID: 55
			public const string UiLocales = "ui_locales";

			// Token: 0x04000038 RID: 56
			public const string IdTokenHint = "id_token_hint";

			// Token: 0x04000039 RID: 57
			public const string LoginHint = "login_hint";

			// Token: 0x0400003A RID: 58
			public const string AcrValues = "acr_values";

			// Token: 0x0400003B RID: 59
			public const string CodeChallenge = "code_challenge";

			// Token: 0x0400003C RID: 60
			public const string CodeChallengeMethod = "code_challenge_method";
		}

		// Token: 0x0200000D RID: 13
		public static class AuthorizeErrors
		{
			// Token: 0x0400003D RID: 61
			public const string InvalidRequest = "invalid_request";

			// Token: 0x0400003E RID: 62
			public const string UnauthorizedClient = "unauthorized_client";

			// Token: 0x0400003F RID: 63
			public const string AccessDenied = "access_denied";

			// Token: 0x04000040 RID: 64
			public const string UnsupportedResponseType = "unsupported_response_type";

			// Token: 0x04000041 RID: 65
			public const string InvalidScope = "invalid_scope";

			// Token: 0x04000042 RID: 66
			public const string ServerError = "server_error";

			// Token: 0x04000043 RID: 67
			public const string TemporarilyUnavailable = "temporarily_unavailable";

			// Token: 0x04000044 RID: 68
			public const string InteractionRequired = "interaction_required";

			// Token: 0x04000045 RID: 69
			public const string LoginRequired = "login_required";

			// Token: 0x04000046 RID: 70
			public const string AccountSelectionRequired = "account_selection_required";

			// Token: 0x04000047 RID: 71
			public const string ConsentRequired = "consent_required";

			// Token: 0x04000048 RID: 72
			public const string InvalidRequestUri = "invalid_request_uri";

			// Token: 0x04000049 RID: 73
			public const string InvalidRequestObject = "invalid_request_object";

			// Token: 0x0400004A RID: 74
			public const string RequestNotSupported = "request_not_supported";

			// Token: 0x0400004B RID: 75
			public const string RequestUriNotSupported = "request_uri_not_supported";

			// Token: 0x0400004C RID: 76
			public const string RegistrationNotSupported = "registration_not_supported";
		}

		// Token: 0x0200000E RID: 14
		public static class AuthorizeResponse
		{
			// Token: 0x0400004D RID: 77
			public const string Scope = "scope";

			// Token: 0x0400004E RID: 78
			public const string Code = "code";

			// Token: 0x0400004F RID: 79
			public const string AccessToken = "access_token";

			// Token: 0x04000050 RID: 80
			public const string ExpiresIn = "expires_in";

			// Token: 0x04000051 RID: 81
			public const string TokenType = "token_type";

			// Token: 0x04000052 RID: 82
			public const string RefreshToken = "refresh_token";

			// Token: 0x04000053 RID: 83
			public const string IdentityToken = "id_token";

			// Token: 0x04000054 RID: 84
			public const string State = "state";

			// Token: 0x04000055 RID: 85
			public const string Error = "error";

			// Token: 0x04000056 RID: 86
			public const string ErrorDescription = "error_description";
		}

		// Token: 0x0200000F RID: 15
		public static class EndSessionRequest
		{
			// Token: 0x04000057 RID: 87
			public const string IdTokenHint = "id_token_hint";

			// Token: 0x04000058 RID: 88
			public const string PostLogoutRedirectUri = "post_logout_redirect_uri";

			// Token: 0x04000059 RID: 89
			public const string State = "state";

			// Token: 0x0400005A RID: 90
			public const string Sid = "sid";

			// Token: 0x0400005B RID: 91
			public const string Issuer = "iss";
		}

		// Token: 0x02000010 RID: 16
		public static class TokenRequest
		{
			// Token: 0x0400005C RID: 92
			public const string GrantType = "grant_type";

			// Token: 0x0400005D RID: 93
			public const string RedirectUri = "redirect_uri";

			// Token: 0x0400005E RID: 94
			public const string ClientId = "client_id";

			// Token: 0x0400005F RID: 95
			public const string ClientSecret = "client_secret";

			// Token: 0x04000060 RID: 96
			public const string ClientAssertion = "client_assertion";

			// Token: 0x04000061 RID: 97
			public const string ClientAssertionType = "client_assertion_type";

			// Token: 0x04000062 RID: 98
			public const string Assertion = "assertion";

			// Token: 0x04000063 RID: 99
			public const string Code = "code";

			// Token: 0x04000064 RID: 100
			public const string RefreshToken = "refresh_token";

			// Token: 0x04000065 RID: 101
			public const string Scope = "scope";

			// Token: 0x04000066 RID: 102
			public const string UserName = "username";

			// Token: 0x04000067 RID: 103
			public const string Password = "password";

			// Token: 0x04000068 RID: 104
			public const string CodeVerifier = "code_verifier";

			// Token: 0x04000069 RID: 105
			public const string TokenType = "token_type";

			// Token: 0x0400006A RID: 106
			public const string Algorithm = "alg";

			// Token: 0x0400006B RID: 107
			public const string Key = "key";
		}

		// Token: 0x02000011 RID: 17
		public static class TokenRequestTypes
		{
			// Token: 0x0400006C RID: 108
			public const string Bearer = "bearer";

			// Token: 0x0400006D RID: 109
			public const string Pop = "pop";
		}

		// Token: 0x02000012 RID: 18
		public static class TokenErrors
		{
			// Token: 0x0400006E RID: 110
			public const string InvalidRequest = "invalid_request";

			// Token: 0x0400006F RID: 111
			public const string InvalidClient = "invalid_client";

			// Token: 0x04000070 RID: 112
			public const string InvalidGrant = "invalid_grant";

			// Token: 0x04000071 RID: 113
			public const string UnauthorizedClient = "unauthorized_client";

			// Token: 0x04000072 RID: 114
			public const string UnsupportedGrantType = "unsupported_grant_type";

			// Token: 0x04000073 RID: 115
			public const string UnsupportedResponseType = "unsupported_response_type";

			// Token: 0x04000074 RID: 116
			public const string InvalidScope = "invalid_scope";
		}

		// Token: 0x02000013 RID: 19
		public static class TokenResponse
		{
			// Token: 0x04000075 RID: 117
			public const string AccessToken = "access_token";

			// Token: 0x04000076 RID: 118
			public const string ExpiresIn = "expires_in";

			// Token: 0x04000077 RID: 119
			public const string TokenType = "token_type";

			// Token: 0x04000078 RID: 120
			public const string RefreshToken = "refresh_token";

			// Token: 0x04000079 RID: 121
			public const string IdentityToken = "id_token";

			// Token: 0x0400007A RID: 122
			public const string Error = "error";

			// Token: 0x0400007B RID: 123
			public const string ErrorDescription = "error_description";

			// Token: 0x0400007C RID: 124
			public const string BearerTokenType = "Bearer";
		}

		// Token: 0x02000014 RID: 20
		public static class RegistrationResponse
		{
			// Token: 0x0400007D RID: 125
			public const string Error = "error";

			// Token: 0x0400007E RID: 126
			public const string ErrorDescription = "error_description";

			// Token: 0x0400007F RID: 127
			public const string ClientId = "client_id";

			// Token: 0x04000080 RID: 128
			public const string ClientSecret = "client_secret";

			// Token: 0x04000081 RID: 129
			public const string RegistrationAccessToken = "registration_access_token";

			// Token: 0x04000082 RID: 130
			public const string RegistrationClientUri = "registration_client_uri";

			// Token: 0x04000083 RID: 131
			public const string ClientIdIssuedAt = "client_id_issued_at";

			// Token: 0x04000084 RID: 132
			public const string ClientSecretExpiresAt = "client_secret_expires_at";
		}

		// Token: 0x02000015 RID: 21
		public static class ClientMetadata
		{
			// Token: 0x04000085 RID: 133
			public const string RedirectUris = "redirect_uris";

			// Token: 0x04000086 RID: 134
			public const string ResponseTypes = "response_types";

			// Token: 0x04000087 RID: 135
			public const string GrantTypes = "grant_types";

			// Token: 0x04000088 RID: 136
			public const string ApplicationType = "application_type";

			// Token: 0x04000089 RID: 137
			public const string Contacts = "contacts";

			// Token: 0x0400008A RID: 138
			public const string ClientName = "client_name";

			// Token: 0x0400008B RID: 139
			public const string LogoUri = "logo_uri";

			// Token: 0x0400008C RID: 140
			public const string ClientUri = "client_uri";

			// Token: 0x0400008D RID: 141
			public const string PolicyUri = "policy_uri";

			// Token: 0x0400008E RID: 142
			public const string TosUri = "tos_uri";

			// Token: 0x0400008F RID: 143
			public const string JwksUri = "jwks_uri";

			// Token: 0x04000090 RID: 144
			public const string Jwks = "jwks";

			// Token: 0x04000091 RID: 145
			public const string SectorIdentifierUri = "sector_identifier_uri";

			// Token: 0x04000092 RID: 146
			public const string SubjectType = "subject_type";

			// Token: 0x04000093 RID: 147
			public const string TokenEndpointAuthenticationMethod = "token_endpoint_auth_method";

			// Token: 0x04000094 RID: 148
			public const string TokenEndpointAuthenticationSigningAlgorithm = "token_endpoint_auth_signing_alg";

			// Token: 0x04000095 RID: 149
			public const string DefaultMaxAge = "default_max_age";

			// Token: 0x04000096 RID: 150
			public const string RequireAuthenticationTime = "require_auth_time";

			// Token: 0x04000097 RID: 151
			public const string DefaultAcrValues = "default_acr_values";

			// Token: 0x04000098 RID: 152
			public const string InitiateLoginUris = "initiate_login_uri";

			// Token: 0x04000099 RID: 153
			public const string RequestUris = "request_uris";

			// Token: 0x0400009A RID: 154
			public const string IdentityTokenSignedResponseAlgorithm = "id_token_signed_response_alg";

			// Token: 0x0400009B RID: 155
			public const string IdentityTokenEncryptedResponseAlgorithm = "id_token_encrypted_response_alg";

			// Token: 0x0400009C RID: 156
			public const string IdentityTokenEncryptedResponseEncryption = "id_token_encrypted_response_enc";

			// Token: 0x0400009D RID: 157
			public const string UserinfoSignedResponseAlgorithm = "userinfo_signed_response_alg";

			// Token: 0x0400009E RID: 158
			public const string UserInfoEncryptedResponseAlgorithm = "userinfo_encrypted_response_alg";

			// Token: 0x0400009F RID: 159
			public const string UserinfoEncryptedResponseEncryption = "userinfo_encrypted_response_enc";

			// Token: 0x040000A0 RID: 160
			public const string RequestObjectSigningAlgorithm = "request_object_signing_alg";

			// Token: 0x040000A1 RID: 161
			public const string RequestObjectEncryptionAlgorithm = "request_object_encryption_alg";

			// Token: 0x040000A2 RID: 162
			public const string RequestObjectEncryptionEncryption = "request_object_encryption_enc";
		}

		// Token: 0x02000016 RID: 22
		public static class TokenTypes
		{
			// Token: 0x040000A3 RID: 163
			public const string AccessToken = "access_token";

			// Token: 0x040000A4 RID: 164
			public const string IdentityToken = "id_token";

			// Token: 0x040000A5 RID: 165
			public const string RefreshToken = "refresh_token";
		}

		// Token: 0x02000017 RID: 23
		public static class AuthenticationSchemes
		{
			// Token: 0x040000A6 RID: 166
			public const string AuthorizationHeaderBearer = "Bearer";

			// Token: 0x040000A7 RID: 167
			public const string FormPostBearer = "access_token";

			// Token: 0x040000A8 RID: 168
			public const string QueryStringBearer = "access_token";

			// Token: 0x040000A9 RID: 169
			public const string AuthorizationHeaderPop = "PoP";

			// Token: 0x040000AA RID: 170
			public const string FormPostPop = "pop_access_token";

			// Token: 0x040000AB RID: 171
			public const string QueryStringPop = "pop_access_token";
		}

		// Token: 0x02000018 RID: 24
		public static class GrantTypes
		{
			// Token: 0x040000AC RID: 172
			public const string Password = "password";

			// Token: 0x040000AD RID: 173
			public const string AuthorizationCode = "authorization_code";

			// Token: 0x040000AE RID: 174
			public const string ClientCredentials = "client_credentials";

			// Token: 0x040000AF RID: 175
			public const string RefreshToken = "refresh_token";

			// Token: 0x040000B0 RID: 176
			public const string Implicit = "implicit";

			// Token: 0x040000B1 RID: 177
			public const string Saml2Bearer = "urn:ietf:params:oauth:grant-type:saml2-bearer";

			// Token: 0x040000B2 RID: 178
			public const string JwtBearer = "urn:ietf:params:oauth:grant-type:jwt-bearer";
		}

		// Token: 0x02000019 RID: 25
		public static class ClientAssertionTypes
		{
			// Token: 0x040000B3 RID: 179
			public const string JwtBearer = "urn:ietf:params:oauth:client-assertion-type:jwt-bearer";
		}

		// Token: 0x0200001A RID: 26
		public static class ResponseTypes
		{
			// Token: 0x040000B4 RID: 180
			public const string Code = "code";

			// Token: 0x040000B5 RID: 181
			public const string Token = "token";

			// Token: 0x040000B6 RID: 182
			public const string IdToken = "id_token";

			// Token: 0x040000B7 RID: 183
			public const string IdTokenToken = "id_token token";

			// Token: 0x040000B8 RID: 184
			public const string CodeIdToken = "code id_token";

			// Token: 0x040000B9 RID: 185
			public const string CodeToken = "code token";

			// Token: 0x040000BA RID: 186
			public const string CodeIdTokenToken = "code id_token token";
		}

		// Token: 0x0200001B RID: 27
		public static class ResponseModes
		{
			// Token: 0x040000BB RID: 187
			public const string FormPost = "form_post";

			// Token: 0x040000BC RID: 188
			public const string Query = "query";

			// Token: 0x040000BD RID: 189
			public const string Fragment = "fragment";
		}

		// Token: 0x0200001C RID: 28
		public static class DisplayModes
		{
			// Token: 0x040000BE RID: 190
			public const string Page = "page";

			// Token: 0x040000BF RID: 191
			public const string Popup = "popup";

			// Token: 0x040000C0 RID: 192
			public const string Touch = "touch";

			// Token: 0x040000C1 RID: 193
			public const string Wap = "wap";
		}

		// Token: 0x0200001D RID: 29
		public static class PromptModes
		{
			// Token: 0x040000C2 RID: 194
			public const string None = "none";

			// Token: 0x040000C3 RID: 195
			public const string Login = "login";

			// Token: 0x040000C4 RID: 196
			public const string Consent = "consent";

			// Token: 0x040000C5 RID: 197
			public const string SelectAccount = "select_account";
		}

		// Token: 0x0200001E RID: 30
		public static class CodeChallengeMethods
		{
			// Token: 0x040000C6 RID: 198
			public const string Plain = "plain";

			// Token: 0x040000C7 RID: 199
			public const string Sha256 = "S256";
		}

		// Token: 0x0200001F RID: 31
		public static class ProtectedResourceErrors
		{
			// Token: 0x040000C8 RID: 200
			public const string InvalidToken = "invalid_token";

			// Token: 0x040000C9 RID: 201
			public const string ExpiredToken = "expired_token";

			// Token: 0x040000CA RID: 202
			public const string InvalidRequest = "invalid_request";

			// Token: 0x040000CB RID: 203
			public const string InsufficientScope = "insufficient_scope";
		}

		// Token: 0x02000020 RID: 32
		public static class EndpointAuthenticationMethods
		{
			// Token: 0x040000CC RID: 204
			public const string PostBody = "client_secret_post";

			// Token: 0x040000CD RID: 205
			public const string BasicAuthentication = "client_secret_basic";

			// Token: 0x040000CE RID: 206
			public const string PrivateKeyJwt = "private_key_jwt";
		}

		// Token: 0x02000021 RID: 33
		public static class AuthenticationMethods
		{
			// Token: 0x040000CF RID: 207
			public const string Password = "pwd";

			// Token: 0x040000D0 RID: 208
			public const string ProofOfPossion = "pop";

			// Token: 0x040000D1 RID: 209
			public const string OneTimePassword = "otp";

			// Token: 0x040000D2 RID: 210
			public const string FingerprintBiometric = "fpt";

			// Token: 0x040000D3 RID: 211
			public const string RetinaScanBiometric = "eye";

			// Token: 0x040000D4 RID: 212
			public const string VoiceBiometric = "vbm";

			// Token: 0x040000D5 RID: 213
			public const string ConfirmationByTelephone = "tel";

			// Token: 0x040000D6 RID: 214
			public const string ConfirmationBySms = "sms";

			// Token: 0x040000D7 RID: 215
			public const string KnowledgeBasedAuthentication = "kba";

			// Token: 0x040000D8 RID: 216
			public const string WindowsIntegratedAuthentication = "wia";

			// Token: 0x040000D9 RID: 217
			public const string MultiFactorAuthentication = "mfa";

			// Token: 0x040000DA RID: 218
			public const string UserPresenceTest = "user";

			// Token: 0x040000DB RID: 219
			public const string RiskBasedAuthentication = "risk";

			// Token: 0x040000DC RID: 220
			public const string MultipleChannelAuthentication = "mfa";
		}

		// Token: 0x02000022 RID: 34
		public static class Algorithms
		{
			// Token: 0x040000DD RID: 221
			public const string None = "none";

			// Token: 0x02000023 RID: 35
			public static class Symmetric
			{
				// Token: 0x040000DE RID: 222
				public const string HS256 = "HS256";

				// Token: 0x040000DF RID: 223
				public const string HS384 = "HS284";

				// Token: 0x040000E0 RID: 224
				public const string HS512 = "HS512";
			}

			// Token: 0x02000024 RID: 36
			public static class Asymmetric
			{
				// Token: 0x040000E1 RID: 225
				public const string RS256 = "RS256";

				// Token: 0x040000E2 RID: 226
				public const string RS384 = "RS384";

				// Token: 0x040000E3 RID: 227
				public const string RS512 = "RS512";

				// Token: 0x040000E4 RID: 228
				public const string ES256 = "ES256";

				// Token: 0x040000E5 RID: 229
				public const string ES384 = "ES384";

				// Token: 0x040000E6 RID: 230
				public const string ES512 = "ES512";

				// Token: 0x040000E7 RID: 231
				public const string PS256 = "PS256";

				// Token: 0x040000E8 RID: 232
				public const string PS384 = "PS384";

				// Token: 0x040000E9 RID: 233
				public const string PS512 = "PS512";
			}
		}

		// Token: 0x02000025 RID: 37
		public static class Discovery
		{
			// Token: 0x040000EA RID: 234
			public const string Issuer = "issuer";

			// Token: 0x040000EB RID: 235
			public const string AuthorizationEndpoint = "authorization_endpoint";

			// Token: 0x040000EC RID: 236
			public const string TokenEndpoint = "token_endpoint";

			// Token: 0x040000ED RID: 237
			public const string UserInfoEndpoint = "userinfo_endpoint";

			// Token: 0x040000EE RID: 238
			public const string IntrospectionEndpoint = "introspection_endpoint";

			// Token: 0x040000EF RID: 239
			public const string RevocationEndpoint = "revocation_endpoint";

			// Token: 0x040000F0 RID: 240
			public const string DiscoveryEndpoint = ".well-known/openid-configuration";

			// Token: 0x040000F1 RID: 241
			public const string JwksUri = "jwks_uri";

			// Token: 0x040000F2 RID: 242
			public const string EndSessionEndpoint = "end_session_endpoint";

			// Token: 0x040000F3 RID: 243
			public const string CheckSessionIframe = "check_session_iframe";

			// Token: 0x040000F4 RID: 244
			public const string RegistrationEndpoint = "registration_endpoint";

			// Token: 0x040000F5 RID: 245
			public const string FrontChannelLogoutSupported = "frontchannel_logout_supported";

			// Token: 0x040000F6 RID: 246
			public const string FrontChannelLogoutSessionSupported = "frontchannel_logout_session_supported";

			// Token: 0x040000F7 RID: 247
			public const string GrantTypesSupported = "grant_types_supported";

			// Token: 0x040000F8 RID: 248
			public const string CodeChallengeMethodsSupported = "code_challenge_methods_supported";

			// Token: 0x040000F9 RID: 249
			public const string ScopesSupported = "scopes_supported";

			// Token: 0x040000FA RID: 250
			public const string SubjectTypesSupported = "subject_types_supported";

			// Token: 0x040000FB RID: 251
			public const string ResponseModesSupported = "response_modes_supported";

			// Token: 0x040000FC RID: 252
			public const string ResponseTypesSupported = "response_types_supported";

			// Token: 0x040000FD RID: 253
			public const string ClaimsSupported = "claims_supported";

			// Token: 0x040000FE RID: 254
			public const string TokenEndpointAuthenticationMethodsSupported = "token_endpoint_auth_methods_supported";

			// Token: 0x040000FF RID: 255
			public const string ClaimsLocalesSupported = "claims_locales_supported";

			// Token: 0x04000100 RID: 256
			public const string ClaimsParameterSupported = "claims_parameter_supported";

			// Token: 0x04000101 RID: 257
			public const string ClaimTypesSupported = "claim_types_supported";

			// Token: 0x04000102 RID: 258
			public const string DisplayValuesSupported = "display_values_supported";

			// Token: 0x04000103 RID: 259
			public const string AcrValuesSupported = "acr_values_supported";

			// Token: 0x04000104 RID: 260
			public const string IdTokenEncryptionAlgorithmsSupported = "id_token_encryption_alg_values_supported";

			// Token: 0x04000105 RID: 261
			public const string IdTokenEncryptionEncValuesSupported = "id_token_encryption_enc_values_supported";

			// Token: 0x04000106 RID: 262
			public const string IdTokenSigningAlgorithmsSupported = "id_token_signing_alg_values_supported";

			// Token: 0x04000107 RID: 263
			public const string OpPolicyUri = "op_policy_uri";

			// Token: 0x04000108 RID: 264
			public const string OpTosUri = "op_tos_uri";

			// Token: 0x04000109 RID: 265
			public const string RequestObjectEncryptionAlgorithmsSupported = "request_object_encryption_alg_values_supported";

			// Token: 0x0400010A RID: 266
			public const string RequestObjectEncryptionEncValuesSupported = "request_object_encryption_enc_values_supported";

			// Token: 0x0400010B RID: 267
			public const string RequestObjectSigningAlgorithmsSupported = "request_object_signing_alg_values_supported";

			// Token: 0x0400010C RID: 268
			public const string RequestParameterSupported = "request_parameter_supported";

			// Token: 0x0400010D RID: 269
			public const string RequestUriParameterSupported = "request_uri_parameter_supported";

			// Token: 0x0400010E RID: 270
			public const string RequireRequestUriRegistration = "require_request_uri_registration";

			// Token: 0x0400010F RID: 271
			public const string ServiceDocumentation = "service_documentation";

			// Token: 0x04000110 RID: 272
			public const string TokenEndpointAuthSigningAlgorithmsSupported = "token_endpoint_auth_signing_alg_values_supported";

			// Token: 0x04000111 RID: 273
			public const string UILocalesSupported = "ui_locales_supported";

			// Token: 0x04000112 RID: 274
			public const string UserInfoEncryptionAlgorithmsSupported = "userinfo_encryption_alg_values_supported";

			// Token: 0x04000113 RID: 275
			public const string UserInfoEncryptionEncValuesSupported = "userinfo_encryption_enc_values_supported";

			// Token: 0x04000114 RID: 276
			public const string UserInfoSigningAlgorithmsSupported = "userinfo_signing_alg_values_supported";
		}
	}
}
