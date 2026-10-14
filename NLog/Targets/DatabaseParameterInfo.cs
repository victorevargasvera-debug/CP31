using System;
using System.ComponentModel;
using NLog.Config;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x02000030 RID: 48
	[global::NLog.Config.NLogConfigurationItem]
	public class DatabaseParameterInfo
	{
		// Token: 0x060004FC RID: 1276 RVA: 0x0000A3E8 File Offset: 0x000085E8
		public DatabaseParameterInfo() : this(null, null)
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0000A3F2 File Offset: 0x000085F2
		public DatabaseParameterInfo(string parameterName, global::NLog.Layouts.Layout parameterLayout)
		{
			this.Name = parameterName;
			this.Layout = parameterLayout;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x0000A408 File Offset: 0x00008608
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x0000A410 File Offset: 0x00008610
		[global::NLog.Config.RequiredParameter]
		public string Name { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x0000A419 File Offset: 0x00008619
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x0000A421 File Offset: 0x00008621
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout Layout { get; set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0000A42A File Offset: 0x0000862A
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x0000A432 File Offset: 0x00008632
		[global::System.ComponentModel.DefaultValue(0)]
		public int Size { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0000A43B File Offset: 0x0000863B
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x0000A443 File Offset: 0x00008643
		[global::System.ComponentModel.DefaultValue(0)]
		public byte Precision { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0000A44C File Offset: 0x0000864C
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x0000A454 File Offset: 0x00008654
		[global::System.ComponentModel.DefaultValue(0)]
		public byte Scale { get; set; }
	}
}
