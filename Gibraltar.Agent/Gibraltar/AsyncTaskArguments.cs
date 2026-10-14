using System;

namespace Gibraltar
{
	// Token: 0x020000AD RID: 173
	internal class AsyncTaskArguments : global::System.IDisposable
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x0000CFF4 File Offset: 0x0000B1F4
		public AsyncTaskArguments(string title, object state)
		{
			this.m_Title = title;
			this.m_State = state;
			this.m_ProgressMonitors = new global::Gibraltar.ProgressMonitorStack(title);
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x0000D018 File Offset: 0x0000B218
		public global::Gibraltar.ProgressMonitorStack ProgressMonitors
		{
			get
			{
				return this.m_ProgressMonitors;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0000D020 File Offset: 0x0000B220
		public object State
		{
			get
			{
				return this.m_State;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x0000D028 File Offset: 0x0000B228
		public string Title
		{
			get
			{
				return this.m_Title;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x0000D030 File Offset: 0x0000B230
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x0000D038 File Offset: 0x0000B238
		public global::Gibraltar.AsyncTaskResultEventArgs TaskResult { get; set; }

		// Token: 0x0600072C RID: 1836 RVA: 0x0000D044 File Offset: 0x0000B244
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0000D054 File Offset: 0x0000B254
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_WeAreDisposed)
			{
				this.m_WeAreDisposed = true;
				if (releaseManaged)
				{
					this.m_ProgressMonitors.Dispose();
				}
			}
		}

		// Token: 0x04000148 RID: 328
		private readonly string m_Title;

		// Token: 0x04000149 RID: 329
		private readonly global::Gibraltar.ProgressMonitorStack m_ProgressMonitors;

		// Token: 0x0400014A RID: 330
		private readonly object m_State;

		// Token: 0x0400014B RID: 331
		private bool m_WeAreDisposed;
	}
}
