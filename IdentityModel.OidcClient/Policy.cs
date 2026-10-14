using System;
using System.Collections.Generic;
using IdentityModel.Client;

namespace IdentityModel.OidcClient
{
	// Token: 0x02000018 RID: 24
	public class Policy
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000485C File Offset: 0x00002A5C
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00004864 File Offset: 0x00002A64
		public global::IdentityModel.Client.DiscoveryPolicy Discovery { get; set; } = new global::IdentityModel.Client.DiscoveryPolicy();

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00004870 File Offset: 0x00002A70
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00004878 File Offset: 0x00002A78
		public bool RequireAuthorizationCodeHash { get; set; } = true;

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00004884 File Offset: 0x00002A84
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000488C File Offset: 0x00002A8C
		public bool RequireAccessTokenHash { get; set; } = true;

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00004898 File Offset: 0x00002A98
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000048A0 File Offset: 0x00002AA0
		public bool RequireIdentityTokenOnRefreshTokenResponse { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000048AC File Offset: 0x00002AAC
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000048B4 File Offset: 0x00002AB4
		public bool RequireIdentityTokenSignature { get; set; } = true;

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000048C0 File Offset: 0x00002AC0
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000048C8 File Offset: 0x00002AC8
		public global::System.Collections.Generic.ICollection<string> ValidSignatureAlgorithms { get; set; } = new global::System.Collections.Generic.HashSet<string>
		{
			"RS256",
			"RS384",
			"RS512"
		};
	}
}
