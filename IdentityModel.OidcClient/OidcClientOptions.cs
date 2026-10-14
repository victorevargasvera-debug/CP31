using System;
using System.Collections.Generic;
using System.Net.Http;
using IdentityModel.Client;
using IdentityModel.OidcClient.Browser;
using Microsoft.Extensions.Logging;

namespace IdentityModel.OidcClient
{
	// Token: 0x02000015 RID: 21
	public class OidcClientOptions
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000045C0 File Offset: 0x000027C0
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000045C8 File Offset: 0x000027C8
		public string Authority { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000045D4 File Offset: 0x000027D4
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000045DC File Offset: 0x000027DC
		public global::IdentityModel.OidcClient.ProviderInformation ProviderInformation { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000045E8 File Offset: 0x000027E8
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000045F0 File Offset: 0x000027F0
		public string ClientId { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000045FC File Offset: 0x000027FC
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00004604 File Offset: 0x00002804
		public string ClientSecret { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00004610 File Offset: 0x00002810
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00004618 File Offset: 0x00002818
		public string Scope { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00004624 File Offset: 0x00002824
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000462C File Offset: 0x0000282C
		public string RedirectUri { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00004638 File Offset: 0x00002838
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00004640 File Offset: 0x00002840
		public global::IdentityModel.OidcClient.Browser.IBrowser Browser { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000464C File Offset: 0x0000284C
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00004654 File Offset: 0x00002854
		public global::System.TimeSpan BrowserTimeout { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00004660 File Offset: 0x00002860
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00004668 File Offset: 0x00002868
		public global::System.TimeSpan ClockSkew { get; set; } = global::System.TimeSpan.FromMinutes(5.0);

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00004674 File Offset: 0x00002874
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000467C File Offset: 0x0000287C
		public bool RefreshDiscoveryDocumentForLogin { get; set; } = true;

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00004688 File Offset: 0x00002888
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00004690 File Offset: 0x00002890
		public bool RefreshDiscoveryOnSignatureFailure { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000469C File Offset: 0x0000289C
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000046A4 File Offset: 0x000028A4
		public global::IdentityModel.OidcClient.OidcClientOptions.AuthorizeResponseMode ResponseMode { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000046B0 File Offset: 0x000028B0
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000046B8 File Offset: 0x000028B8
		public bool LoadProfile { get; set; } = true;

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000046C4 File Offset: 0x000028C4
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000046CC File Offset: 0x000028CC
		public bool FilterClaims { get; set; } = true;

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000046D8 File Offset: 0x000028D8
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000046E0 File Offset: 0x000028E0
		public global::IdentityModel.OidcClient.OidcClientOptions.AuthenticationFlow Flow { get; set; } = global::IdentityModel.OidcClient.OidcClientOptions.AuthenticationFlow.Hybrid;

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000046EC File Offset: 0x000028EC
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000046F4 File Offset: 0x000028F4
		public global::System.Net.Http.HttpMessageHandler BackchannelHandler { get; set; } = new global::System.Net.Http.HttpClientHandler();

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004700 File Offset: 0x00002900
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00004708 File Offset: 0x00002908
		public global::System.TimeSpan BackchannelTimeout { get; set; } = global::System.TimeSpan.FromSeconds(30.0);

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00004714 File Offset: 0x00002914
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000471C File Offset: 0x0000291C
		public global::IdentityModel.Client.AuthenticationStyle TokenClientAuthenticationStyle { get; set; } = global::IdentityModel.Client.AuthenticationStyle.PostValues;

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00004728 File Offset: 0x00002928
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00004730 File Offset: 0x00002930
		public global::IdentityModel.OidcClient.Policy Policy { get; set; } = new global::IdentityModel.OidcClient.Policy();

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000473C File Offset: 0x0000293C
		public global::Microsoft.Extensions.Logging.ILoggerFactory LoggerFactory { get; } = new global::Microsoft.Extensions.Logging.LoggerFactory();

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00004744 File Offset: 0x00002944
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000474C File Offset: 0x0000294C
		public global::System.Collections.Generic.ICollection<string> FilteredClaims { get; set; } = new global::System.Collections.Generic.HashSet<string>
		{
			"iss",
			"exp",
			"nbf",
			"aud",
			"nonce",
			"iat",
			"auth_time",
			"c_hash",
			"at_hash"
		};

		// Token: 0x06000073 RID: 115 RVA: 0x00004758 File Offset: 0x00002958
		public bool ShouldSerializeBrowser()
		{
			return false;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000475C File Offset: 0x0000295C
		public bool ShouldSerializeBackchannelHandler()
		{
			return false;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004760 File Offset: 0x00002960
		public bool ShouldSerializeLoggerFactory()
		{
			return false;
		}

		// Token: 0x02000016 RID: 22
		public enum AuthenticationFlow
		{
			// Token: 0x0400006F RID: 111
			AuthorizationCode,
			// Token: 0x04000070 RID: 112
			Hybrid
		}

		// Token: 0x02000017 RID: 23
		public enum AuthorizeResponseMode
		{
			// Token: 0x04000072 RID: 114
			FormPost,
			// Token: 0x04000073 RID: 115
			Redirect
		}
	}
}
