using System;
using NLog.Config;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x0200004A RID: 74
	[global::NLog.Config.NLogConfigurationItem]
	public class NLogViewerParameterInfo
	{
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00011108 File Offset: 0x0000F308
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00011110 File Offset: 0x0000F310
		[global::NLog.Config.RequiredParameter]
		public string Name { get; set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00011119 File Offset: 0x0000F319
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00011121 File Offset: 0x0000F321
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout Layout { get; set; }
	}
}
