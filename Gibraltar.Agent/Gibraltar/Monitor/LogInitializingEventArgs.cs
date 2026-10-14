using System;

namespace Gibraltar.Monitor
{
	// Token: 0x02000194 RID: 404
	internal class LogInitializingEventArgs : global::System.EventArgs
	{
		// Token: 0x06001131 RID: 4401 RVA: 0x00031DDC File Offset: 0x0002FFDC
		internal LogInitializingEventArgs(global::Gibraltar.Monitor.AgentConfiguration configuration)
		{
			this.Configuration = configuration;
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00031DEC File Offset: 0x0002FFEC
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x00031DF4 File Offset: 0x0002FFF4
		public bool Cancel { get; set; }

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x00031E00 File Offset: 0x00030000
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x00031E08 File Offset: 0x00030008
		public global::Gibraltar.Monitor.AgentConfiguration Configuration { get; private set; }
	}
}
