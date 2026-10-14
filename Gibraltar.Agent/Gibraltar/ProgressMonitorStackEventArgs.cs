using System;

namespace Gibraltar
{
	// Token: 0x020000C5 RID: 197
	internal class ProgressMonitorStackEventArgs : global::System.EventArgs
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x00011DD4 File Offset: 0x0000FFD4
		public ProgressMonitorStackEventArgs(global::Gibraltar.ProgressMonitorStack progressMonitors, string statusMessage, int completedSteps, int maximumSteps)
		{
			this.m_ProgressMonitors = progressMonitors;
			this.m_StatusMessage = statusMessage;
			this.m_CompletedSteps = completedSteps;
			this.m_MaximumSteps = maximumSteps;
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00011DFC File Offset: 0x0000FFFC
		public global::Gibraltar.ProgressMonitorStack ProgressMonitors
		{
			get
			{
				return this.m_ProgressMonitors;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00011E04 File Offset: 0x00010004
		public string StatusMessage
		{
			get
			{
				return this.m_StatusMessage;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00011E0C File Offset: 0x0001000C
		public int CompletedSteps
		{
			get
			{
				return this.m_CompletedSteps;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00011E14 File Offset: 0x00010014
		public int MaximumSteps
		{
			get
			{
				return this.m_MaximumSteps;
			}
		}

		// Token: 0x040001CE RID: 462
		private readonly global::Gibraltar.ProgressMonitorStack m_ProgressMonitors;

		// Token: 0x040001CF RID: 463
		private readonly string m_StatusMessage;

		// Token: 0x040001D0 RID: 464
		private readonly int m_CompletedSteps;

		// Token: 0x040001D1 RID: 465
		private readonly int m_MaximumSteps;
	}
}
