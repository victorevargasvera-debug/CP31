using System;

namespace Gibraltar
{
	// Token: 0x020000C3 RID: 195
	internal class ProgressMonitorEventArgs : global::System.EventArgs
	{
		// Token: 0x06000830 RID: 2096 RVA: 0x00011488 File Offset: 0x0000F688
		public ProgressMonitorEventArgs(global::Gibraltar.ProgressMonitorStack progressMonitors, global::Gibraltar.ProgressMonitor progressMonitor)
		{
			this.m_ProgressMonitors = progressMonitors;
			this.m_ProgressMonitor = progressMonitor;
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x000114A0 File Offset: 0x0000F6A0
		public global::Gibraltar.ProgressMonitorStack ProgressMonitors
		{
			get
			{
				return this.m_ProgressMonitors;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x000114A8 File Offset: 0x0000F6A8
		public global::Gibraltar.ProgressMonitor ProgressMonitor
		{
			get
			{
				return this.m_ProgressMonitor;
			}
		}

		// Token: 0x040001BE RID: 446
		private readonly global::Gibraltar.ProgressMonitorStack m_ProgressMonitors;

		// Token: 0x040001BF RID: 447
		private readonly global::Gibraltar.ProgressMonitor m_ProgressMonitor;
	}
}
