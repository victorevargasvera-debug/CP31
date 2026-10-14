using System;
using System.Text;
using System.Threading;

namespace CefSharp.Internals
{
	// Token: 0x020000C9 RID: 201
	public sealed class BrowserRefCounter : global::CefSharp.Internals.IBrowserRefCounter, global::System.IDisposable
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x00009710 File Offset: 0x00007910
		public void AppendLineToLog(string line)
		{
			if (this.loggingEnabled)
			{
				this.logger.AppendLine(line);
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00009728 File Offset: 0x00007928
		void global::CefSharp.Internals.IBrowserRefCounter.Increment(global::System.Type type)
		{
			int num = global::System.Threading.Interlocked.Increment(ref this.count);
			if (num > 0)
			{
				this.manualResetEvent.Reset();
				this.AppendLineToLog(string.Format("{0} - Incremented (ManualResetEvent was reset)", type));
				return;
			}
			if (this.loggingEnabled)
			{
				this.logger.AppendLine(string.Format("New Count <= 0 - {0} ", num));
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00009788 File Offset: 0x00007988
		bool global::CefSharp.Internals.IBrowserRefCounter.Decrement(global::System.Type type)
		{
			int num = global::System.Threading.Interlocked.Decrement(ref this.count);
			this.AppendLineToLog(string.Format("{0} - Decremented (Current Count {1})", type, num));
			if (num == 0)
			{
				this.manualResetEvent.Set();
				return true;
			}
			if (num < 0)
			{
				this.AppendLineToLog(string.Format("{0} - Decremented (Less than 0 : Current Count {1})", type, num));
				global::System.Threading.Interlocked.Exchange(ref this.count, 0);
				this.manualResetEvent.Set();
			}
			return false;
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x000097FC File Offset: 0x000079FC
		int global::CefSharp.Internals.IBrowserRefCounter.Count
		{
			get
			{
				int num = this.count;
				if (num >= 0)
				{
					return num;
				}
				return 0;
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0000981C File Offset: 0x00007A1C
		void global::CefSharp.Internals.IBrowserRefCounter.WaitForBrowsersToClose(int timeoutInMiliseconds)
		{
			this.AppendLineToLog(string.Format("WaitForBrowsersToClose - Current Count {0}", this.count));
			if (!this.manualResetEvent.IsSet)
			{
				this.manualResetEvent.Wait(timeoutInMiliseconds);
			}
			this.AppendLineToLog(string.Format("WaitForBrowsersToClose - Updated Count {0}", this.count));
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00009880 File Offset: 0x00007A80
		void global::CefSharp.Internals.IBrowserRefCounter.WaitForBrowsersToClose(int timeoutInMiliseconds, global::System.Threading.CancellationToken cancellationToken)
		{
			this.AppendLineToLog(string.Format("WaitForBrowsersToClose - Current Count {0}", this.count));
			if (!this.manualResetEvent.IsSet)
			{
				this.manualResetEvent.Wait(timeoutInMiliseconds, cancellationToken);
			}
			this.AppendLineToLog(string.Format("WaitForBrowsersToClose - Updated Count {0}", this.count));
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x000098E2 File Offset: 0x00007AE2
		void global::CefSharp.Internals.IBrowserRefCounter.EnableLogging()
		{
			this.loggingEnabled = true;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000098EB File Offset: 0x00007AEB
		string global::CefSharp.Internals.IBrowserRefCounter.GetLog()
		{
			return this.logger.ToString();
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x000098F8 File Offset: 0x00007AF8
		public void Dispose()
		{
			this.manualResetEvent.Dispose();
		}

		// Token: 0x04000366 RID: 870
		private volatile int count;

		// Token: 0x04000367 RID: 871
		private global::System.Threading.ManualResetEventSlim manualResetEvent = new global::System.Threading.ManualResetEventSlim();

		// Token: 0x04000368 RID: 872
		private bool loggingEnabled;

		// Token: 0x04000369 RID: 873
		private global::System.Text.StringBuilder logger = new global::System.Text.StringBuilder();

		// Token: 0x0400036A RID: 874
		public static global::CefSharp.Internals.IBrowserRefCounter Instance = new global::CefSharp.Internals.NoOpBrowserRefCounter();
	}
}
