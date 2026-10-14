using System;

namespace CefSharp.Handler
{
	// Token: 0x02000101 RID: 257
	public class BrowserProcessHandler : global::CefSharp.IBrowserProcessHandler, global::System.IDisposable
	{
		// Token: 0x0600078C RID: 1932 RVA: 0x0000C6F6 File Offset: 0x0000A8F6
		void global::CefSharp.IBrowserProcessHandler.OnContextInitialized()
		{
			this.OnContextInitialized();
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0000C6FE File Offset: 0x0000A8FE
		protected virtual void OnContextInitialized()
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0000C700 File Offset: 0x0000A900
		void global::CefSharp.IBrowserProcessHandler.OnScheduleMessagePumpWork(long delay)
		{
			this.OnScheduleMessagePumpWork(delay);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0000C709 File Offset: 0x0000A909
		protected virtual void OnScheduleMessagePumpWork(long delay)
		{
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0000C70B File Offset: 0x0000A90B
		public bool IsDisposed
		{
			get
			{
				return this.isDisposed;
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0000C713 File Offset: 0x0000A913
		protected virtual void Dispose(bool disposing)
		{
			this.isDisposed = true;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0000C71C File Offset: 0x0000A91C
		void global::System.IDisposable.Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040003DC RID: 988
		private bool isDisposed;
	}
}
