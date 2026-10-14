using System;
using System.Threading;
using NLog.Common;

namespace NLog.Internal
{
	// Token: 0x0200012E RID: 302
	internal class TimeoutContinuation : global::System.IDisposable
	{
		// Token: 0x06000DD9 RID: 3545 RVA: 0x0002309F File Offset: 0x0002129F
		public TimeoutContinuation(global::NLog.Common.AsyncContinuation asyncContinuation, global::System.TimeSpan timeout)
		{
			this._asyncContinuation = asyncContinuation;
			this._timeoutTimer = new global::System.Threading.Timer(new global::System.Threading.TimerCallback(this.TimerElapsed), null, timeout, global::System.TimeSpan.FromMilliseconds(-1.0));
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000230D8 File Offset: 0x000212D8
		public void Function(global::System.Exception exception)
		{
			try
			{
				this.StopTimer();
				global::NLog.Common.AsyncContinuation asyncContinuation = global::System.Threading.Interlocked.Exchange<global::NLog.Common.AsyncContinuation>(ref this._asyncContinuation, null);
				if (asyncContinuation != null)
				{
					asyncContinuation(exception);
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "Exception in asynchronous handler.");
				if (ex.MustBeRethrown())
				{
					throw;
				}
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0002312C File Offset: 0x0002132C
		public void Dispose()
		{
			this.StopTimer();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0002313C File Offset: 0x0002133C
		private void StopTimer()
		{
			lock (this)
			{
				global::System.Threading.Timer timeoutTimer = this._timeoutTimer;
				if (timeoutTimer != null)
				{
					this._timeoutTimer = null;
					timeoutTimer.WaitForDispose(global::System.TimeSpan.Zero);
				}
			}
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00023190 File Offset: 0x00021390
		private void TimerElapsed(object state)
		{
			this.Function(new global::System.TimeoutException("Timeout."));
		}

		// Token: 0x040003CD RID: 973
		private global::NLog.Common.AsyncContinuation _asyncContinuation;

		// Token: 0x040003CE RID: 974
		private global::System.Threading.Timer _timeoutTimer;
	}
}
