using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using NLog.Config;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x0200002F RID: 47
	[global::NLog.Config.NLogConfigurationItem]
	public class DatabaseCommandInfo
	{
		// Token: 0x060004F1 RID: 1265 RVA: 0x0000A379 File Offset: 0x00008579
		public DatabaseCommandInfo()
		{
			this.Parameters = new global::System.Collections.Generic.List<global::NLog.Targets.DatabaseParameterInfo>();
			this.CommandType = global::System.Data.CommandType.Text;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0000A393 File Offset: 0x00008593
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x0000A39B File Offset: 0x0000859B
		[global::NLog.Config.RequiredParameter]
		[global::System.ComponentModel.DefaultValue(global::System.Data.CommandType.Text)]
		public global::System.Data.CommandType CommandType { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0000A3A4 File Offset: 0x000085A4
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x0000A3AC File Offset: 0x000085AC
		public global::NLog.Layouts.Layout ConnectionString { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0000A3B5 File Offset: 0x000085B5
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x0000A3BD File Offset: 0x000085BD
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout Text { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0000A3C6 File Offset: 0x000085C6
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x0000A3CE File Offset: 0x000085CE
		public bool IgnoreFailures { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0000A3D7 File Offset: 0x000085D7
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x0000A3DF File Offset: 0x000085DF
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Targets.DatabaseParameterInfo), "parameter")]
		public global::System.Collections.Generic.IList<global::NLog.Targets.DatabaseParameterInfo> Parameters { get; private set; }
	}
}
