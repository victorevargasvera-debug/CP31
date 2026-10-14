using System;

namespace IdentityModel.OidcClient
{
	// Token: 0x02000004 RID: 4
	public class AuthorizeState
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000261C File Offset: 0x0000081C
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002624 File Offset: 0x00000824
		public string StartUrl { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002630 File Offset: 0x00000830
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002638 File Offset: 0x00000838
		public string Nonce { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002644 File Offset: 0x00000844
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000264C File Offset: 0x0000084C
		public string State { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002658 File Offset: 0x00000858
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002660 File Offset: 0x00000860
		public string CodeVerifier { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000266C File Offset: 0x0000086C
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002674 File Offset: 0x00000874
		public string RedirectUri { get; set; }
	}
}
