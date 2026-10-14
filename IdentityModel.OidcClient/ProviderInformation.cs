using System;
using System.Collections.Generic;
using IdentityModel.Jwk;

namespace IdentityModel.OidcClient
{
	// Token: 0x02000019 RID: 25
	public class ProviderInformation
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00004938 File Offset: 0x00002B38
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00004940 File Offset: 0x00002B40
		public string IssuerName { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000494C File Offset: 0x00002B4C
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00004954 File Offset: 0x00002B54
		public global::IdentityModel.Jwk.JsonWebKeySet KeySet { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00004960 File Offset: 0x00002B60
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00004968 File Offset: 0x00002B68
		public string TokenEndpoint { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00004974 File Offset: 0x00002B74
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000497C File Offset: 0x00002B7C
		public string AuthorizeEndpoint { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004988 File Offset: 0x00002B88
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00004990 File Offset: 0x00002B90
		public string EndSessionEndpoint { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000499C File Offset: 0x00002B9C
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000049A4 File Offset: 0x00002BA4
		public string UserInfoEndpoint { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000049B0 File Offset: 0x00002BB0
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000049B8 File Offset: 0x00002BB8
		public global::System.Collections.Generic.IEnumerable<string> TokenEndPointAuthenticationMethods { get; set; } = new string[0];

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000049C4 File Offset: 0x00002BC4
		public bool SupportsUserInfo
		{
			get
			{
				return this.UserInfoEndpoint.IsPresent();
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000049D4 File Offset: 0x00002BD4
		public bool SupportsEndSession
		{
			get
			{
				return this.EndSessionEndpoint.IsPresent();
			}
		}
	}
}
