using System;
using System.Collections.Generic;

namespace IdentityModel.Client
{
	// Token: 0x02000047 RID: 71
	public class IntrospectionRequest
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00004C3C File Offset: 0x00002E3C
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00004C44 File Offset: 0x00002E44
		public string Token { get; set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00004C50 File Offset: 0x00002E50
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00004C58 File Offset: 0x00002E58
		public string TokenTypeHint { get; set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00004C64 File Offset: 0x00002E64
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00004C6C File Offset: 0x00002E6C
		public string ClientId { get; set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00004C78 File Offset: 0x00002E78
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00004C80 File Offset: 0x00002E80
		public string ClientSecret { get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00004C8C File Offset: 0x00002E8C
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00004C94 File Offset: 0x00002E94
		public global::System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }
	}
}
