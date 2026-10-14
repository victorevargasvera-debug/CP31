using System;

namespace Loupe.Extensibility
{
	// Token: 0x0200004B RID: 75
	internal class LoupeExtensionAttribute : global::System.Attribute
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0000BF74 File Offset: 0x0000A174
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x0000BF7C File Offset: 0x0000A17C
		public global::System.Type ConfigurationEditor { get; set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0000BF88 File Offset: 0x0000A188
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x0000BF90 File Offset: 0x0000A190
		public global::System.Type ServerConfiguration { get; set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0000BF9C File Offset: 0x0000A19C
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		public global::System.Type MachineConfiguration { get; set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000BFB0 File Offset: 0x0000A1B0
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		public global::System.Type UserConfiguration { get; set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0000BFC4 File Offset: 0x0000A1C4
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		public global::System.Type CommonConfiguration { get; set; }
	}
}
