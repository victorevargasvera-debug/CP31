using System;
using System.Collections.Generic;
using System.Linq;
using IdentityModel.Jwk;
using Newtonsoft.Json;

namespace IdentityModel.Client
{
	// Token: 0x0200004E RID: 78
	public class RegistrationRequest
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000585C File Offset: 0x00003A5C
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00005864 File Offset: 0x00003A64
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "redirect_uris", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.ICollection<string> RedirectUris { get; set; } = new global::System.Collections.Generic.HashSet<string>();

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00005870 File Offset: 0x00003A70
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00005878 File Offset: 0x00003A78
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "response_types", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.ICollection<string> ResponseTypes { get; set; } = new global::System.Collections.Generic.HashSet<string>();

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00005884 File Offset: 0x00003A84
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000588C File Offset: 0x00003A8C
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "grant_types", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.ICollection<string> GrantTypes { get; set; } = new global::System.Collections.Generic.HashSet<string>();

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00005898 File Offset: 0x00003A98
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000058A0 File Offset: 0x00003AA0
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "application_type", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string ApplicationType { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000058AC File Offset: 0x00003AAC
		// (set) Token: 0x0600011D RID: 285 RVA: 0x000058B4 File Offset: 0x00003AB4
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "contacts", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.ICollection<string> Contacts { get; set; } = new global::System.Collections.Generic.HashSet<string>();

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000058C0 File Offset: 0x00003AC0
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000058C8 File Offset: 0x00003AC8
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "client_name", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string ClientName { get; set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000058D4 File Offset: 0x00003AD4
		// (set) Token: 0x06000121 RID: 289 RVA: 0x000058DC File Offset: 0x00003ADC
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "logo_uri", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string LogoUri { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000058E8 File Offset: 0x00003AE8
		// (set) Token: 0x06000123 RID: 291 RVA: 0x000058F0 File Offset: 0x00003AF0
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "client_uri", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string ClientUri { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000058FC File Offset: 0x00003AFC
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00005904 File Offset: 0x00003B04
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "policy_uri", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string PolicyUri { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00005910 File Offset: 0x00003B10
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00005918 File Offset: 0x00003B18
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "tos_uri", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string TosUri { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00005924 File Offset: 0x00003B24
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0000592C File Offset: 0x00003B2C
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "jwks_uri", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string JwksUri { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00005938 File Offset: 0x00003B38
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00005940 File Offset: 0x00003B40
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "jwks", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public global::IdentityModel.Jwk.JsonWebKeySet Jwks { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000594C File Offset: 0x00003B4C
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00005954 File Offset: 0x00003B54
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "sector_identifier_uri", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string SectorIdentifierUri { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00005960 File Offset: 0x00003B60
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00005968 File Offset: 0x00003B68
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "subject_type", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string SubjectType { get; set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00005974 File Offset: 0x00003B74
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0000597C File Offset: 0x00003B7C
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "id_token_signed_response_alg", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string IdentityTokenSignedResponseAlgorithm { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00005988 File Offset: 0x00003B88
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00005990 File Offset: 0x00003B90
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "id_token_encrypted_response_alg", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string IdentityTokenEncryptedResponseAlgorithm { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000599C File Offset: 0x00003B9C
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000059A4 File Offset: 0x00003BA4
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "id_token_encrypted_response_enc", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string IdentityTokenEncryptedResponseEncryption { get; set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000059B0 File Offset: 0x00003BB0
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000059B8 File Offset: 0x00003BB8
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "userinfo_signed_response_alg", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string UserinfoSignedResponseAlgorithm { get; set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000059C4 File Offset: 0x00003BC4
		// (set) Token: 0x06000139 RID: 313 RVA: 0x000059CC File Offset: 0x00003BCC
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "userinfo_encrypted_response_alg", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string UserInfoEncryptedResponseAlgorithm { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000059D8 File Offset: 0x00003BD8
		// (set) Token: 0x0600013B RID: 315 RVA: 0x000059E0 File Offset: 0x00003BE0
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "userinfo_encrypted_response_enc", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string UserinfoEncryptedResponseEncryption { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000059EC File Offset: 0x00003BEC
		// (set) Token: 0x0600013D RID: 317 RVA: 0x000059F4 File Offset: 0x00003BF4
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "request_object_signing_alg", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string RequestObjectSigningAlgorithm { get; set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00005A00 File Offset: 0x00003C00
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00005A08 File Offset: 0x00003C08
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "request_object_encryption_alg", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string RequestObjectEncryptionAlgorithm { get; set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00005A14 File Offset: 0x00003C14
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00005A1C File Offset: 0x00003C1C
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "request_object_encryption_enc", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string RequestObjectEncryptionEncryption { get; set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00005A28 File Offset: 0x00003C28
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00005A30 File Offset: 0x00003C30
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "token_endpoint_auth_method", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string TokenEndpointAuthenticationMethod { get; set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00005A3C File Offset: 0x00003C3C
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00005A44 File Offset: 0x00003C44
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "token_endpoint_auth_signing_alg", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string TokenEndpointAuthenticationSigningAlgorithm { get; set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00005A50 File Offset: 0x00003C50
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00005A58 File Offset: 0x00003C58
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "default_max_age", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public int DefaultMaxAge { get; set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00005A64 File Offset: 0x00003C64
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00005A6C File Offset: 0x00003C6C
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "require_auth_time", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public bool RequireAuthenticationTime { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00005A78 File Offset: 0x00003C78
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00005A80 File Offset: 0x00003C80
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "default_acr_values", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.ICollection<string> DefaultAcrValues { get; set; } = new global::System.Collections.Generic.HashSet<string>();

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00005A8C File Offset: 0x00003C8C
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00005A94 File Offset: 0x00003C94
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "initiate_login_uri", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public string InitiateLoginUri { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00005AA0 File Offset: 0x00003CA0
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[global::Newtonsoft.Json.JsonProperty(PropertyName = "request_uris", DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.ICollection<string> RequestUris { get; set; } = new global::System.Collections.Generic.HashSet<string>();

		// Token: 0x06000150 RID: 336 RVA: 0x00005AB4 File Offset: 0x00003CB4
		public bool ShouldSerializeRequestUris()
		{
			return this.RequestUris.Any<string>();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00005AC4 File Offset: 0x00003CC4
		public bool ShouldSerializeDefaultAcrValues()
		{
			return this.DefaultAcrValues.Any<string>();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00005AD4 File Offset: 0x00003CD4
		public bool ShouldSerializeResponseTypes()
		{
			return this.ResponseTypes.Any<string>();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00005AE4 File Offset: 0x00003CE4
		public bool ShouldSerializeGrantTypes()
		{
			return this.GrantTypes.Any<string>();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00005AF4 File Offset: 0x00003CF4
		public bool ShouldSerializeContacts()
		{
			return this.Contacts.Any<string>();
		}
	}
}
