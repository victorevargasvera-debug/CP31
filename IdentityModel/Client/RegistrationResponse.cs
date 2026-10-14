using System;
using System.Net;

namespace IdentityModel.Client
{
	// Token: 0x0200004F RID: 79
	public class RegistrationResponse : global::IdentityModel.Client.Response
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00005B5C File Offset: 0x00003D5C
		public RegistrationResponse(string raw) : base(raw)
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00005B68 File Offset: 0x00003D68
		public RegistrationResponse(global::System.Exception exception) : base(exception)
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00005B74 File Offset: 0x00003D74
		public RegistrationResponse(global::System.Net.HttpStatusCode statusCode, string reason) : base(statusCode, reason)
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00005B80 File Offset: 0x00003D80
		public string ErrorDescription
		{
			get
			{
				return base.Json.TryGetString("error_description");
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00005B94 File Offset: 0x00003D94
		public string ClientId
		{
			get
			{
				return base.Json.TryGetString("client_id");
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00005BA8 File Offset: 0x00003DA8
		public string ClientSecret
		{
			get
			{
				return base.Json.TryGetString("client_secret");
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00005BBC File Offset: 0x00003DBC
		public string RegistrationAccessToken
		{
			get
			{
				return base.Json.TryGetString("registration_access_token");
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00005BD0 File Offset: 0x00003DD0
		public string RegistrationClientUri
		{
			get
			{
				return base.Json.TryGetString("registration_client_uri");
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00005BE4 File Offset: 0x00003DE4
		public int? ClientIdIssuedAt
		{
			get
			{
				return base.Json.TryGetInt("client_id_issued_at");
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00005BF8 File Offset: 0x00003DF8
		public int? ClientSecretExpiresAt
		{
			get
			{
				return base.Json.TryGetInt("client_secret_expires_at");
			}
		}
	}
}
