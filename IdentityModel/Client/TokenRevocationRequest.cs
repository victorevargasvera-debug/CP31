using System;

namespace IdentityModel.Client
{
	// Token: 0x0200005B RID: 91
	public class TokenRevocationRequest
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00006B2C File Offset: 0x00004D2C
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00006B34 File Offset: 0x00004D34
		public string Token { get; set; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00006B40 File Offset: 0x00004D40
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00006B48 File Offset: 0x00004D48
		public string TokenTypeHint { get; set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00006B54 File Offset: 0x00004D54
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00006B5C File Offset: 0x00004D5C
		public string ClientId { get; set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00006B68 File Offset: 0x00004D68
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00006B70 File Offset: 0x00004D70
		public string ClientSecret { get; set; }
	}
}
