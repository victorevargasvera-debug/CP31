using System;
using System.Threading;
using NLog.Common;

namespace NLog.Internal
{
	// Token: 0x02000122 RID: 290
	internal class SingleCallContinuation
	{
		// Token: 0x06000D91 RID: 3473 RVA: 0x000220BF File Offset: 0x000202BF
		public SingleCallContinuation(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			this._asyncContinuation = asyncContinuation;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x000220D0 File Offset: 0x000202D0
		public void Function(global::System.Exception exception)
		{
			try
			{
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

		// Token: 0x040003BE RID: 958
		private global::NLog.Common.AsyncContinuation _asyncContinuation;
	}
}
