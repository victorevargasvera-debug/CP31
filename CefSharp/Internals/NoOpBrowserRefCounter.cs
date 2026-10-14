using System;
using System.Threading;

namespace CefSharp.Internals
{
	// Token: 0x020000EC RID: 236
	public sealed class NoOpBrowserRefCounter : global::CefSharp.Internals.IBrowserRefCounter, global::System.IDisposable
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x0000B801 File Offset: 0x00009A01
		int global::CefSharp.Internals.IBrowserRefCounter.Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0000B804 File Offset: 0x00009A04
		public void Dispose()
		{
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0000B806 File Offset: 0x00009A06
		void global::CefSharp.Internals.IBrowserRefCounter.EnableLogging()
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0000B808 File Offset: 0x00009A08
		string global::CefSharp.Internals.IBrowserRefCounter.GetLog()
		{
			return string.Empty;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0000B80F File Offset: 0x00009A0F
		bool global::CefSharp.Internals.IBrowserRefCounter.Decrement(global::System.Type type)
		{
			return false;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0000B812 File Offset: 0x00009A12
		void global::CefSharp.Internals.IBrowserRefCounter.Increment(global::System.Type type)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0000B814 File Offset: 0x00009A14
		void global::CefSharp.Internals.IBrowserRefCounter.WaitForBrowsersToClose(int timeoutInMiliseconds)
		{
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0000B816 File Offset: 0x00009A16
		void global::CefSharp.Internals.IBrowserRefCounter.WaitForBrowsersToClose(int timeoutInMiliseconds, global::System.Threading.CancellationToken cancellationToken)
		{
		}
	}
}
