using System;
using System.Collections.Generic;

namespace IdentityModel.Client
{
	// Token: 0x02000040 RID: 64
	public class DiscoveryPolicy
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003DE4 File Offset: 0x00001FE4
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00003DEC File Offset: 0x00001FEC
		public bool RequireHttps { get; set; } = true;

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00003DF8 File Offset: 0x00001FF8
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00003E00 File Offset: 0x00002000
		public bool AllowHttpOnLoopback { get; set; } = true;

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00003E0C File Offset: 0x0000200C
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00003E14 File Offset: 0x00002014
		public bool ValidateIssuerName { get; set; } = true;

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00003E20 File Offset: 0x00002020
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00003E28 File Offset: 0x00002028
		public bool ValidateEndpoints { get; set; } = true;

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003E34 File Offset: 0x00002034
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00003E3C File Offset: 0x0000203C
		public global::System.Collections.Generic.ICollection<string> EndpointValidationExcludeList { get; set; } = new global::System.Collections.Generic.HashSet<string>();

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00003E48 File Offset: 0x00002048
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00003E50 File Offset: 0x00002050
		public global::System.Collections.Generic.ICollection<string> AdditionalEndpointBaseAddresses { get; set; } = new global::System.Collections.Generic.HashSet<string>();

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00003E5C File Offset: 0x0000205C
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00003E64 File Offset: 0x00002064
		public bool RequireKeySet { get; set; } = true;

		// Token: 0x04000176 RID: 374
		internal string Authority;

		// Token: 0x04000179 RID: 377
		public global::System.Collections.Generic.ICollection<string> LoopbackAddresses = new global::System.Collections.Generic.HashSet<string>
		{
			"localhost",
			"127.0.0.1"
		};
	}
}
