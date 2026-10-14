using System;
using Gibraltar.Agent.Configuration;

namespace Gibraltar.Agent
{
	// Token: 0x02000007 RID: 7
	public class LogInitializingEventArgs : global::System.EventArgs
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00003764 File Offset: 0x00001964
		internal LogInitializingEventArgs(global::Gibraltar.Agent.Configuration.AgentConfiguration configuration)
		{
			this.Configuration = configuration;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003774 File Offset: 0x00001974
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000377C File Offset: 0x0000197C
		public bool Cancel { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003788 File Offset: 0x00001988
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00003790 File Offset: 0x00001990
		public global::Gibraltar.Agent.Configuration.AgentConfiguration Configuration { get; private set; }
	}
}
