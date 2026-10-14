using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using NLog.Common;

namespace NLog.Targets.Wrappers
{
	// Token: 0x0200006C RID: 108
	[global::NLog.Targets.Target("RetryingWrapper", IsWrapper = true)]
	public class RetryingTargetWrapper : global::NLog.Targets.Wrappers.WrapperTargetBase
	{
		// Token: 0x0600084A RID: 2122 RVA: 0x00015127 File Offset: 0x00013327
		public RetryingTargetWrapper() : this(null, 3, 100)
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00015133 File Offset: 0x00013333
		public RetryingTargetWrapper(string name, global::NLog.Targets.Target wrappedTarget, int retryCount, int retryDelayMilliseconds) : this(wrappedTarget, retryCount, retryDelayMilliseconds)
		{
			base.Name = name;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00015148 File Offset: 0x00013348
		public RetryingTargetWrapper(global::NLog.Targets.Target wrappedTarget, int retryCount, int retryDelayMilliseconds)
		{
			base.WrappedTarget = wrappedTarget;
			this.RetryCount = retryCount;
			this.RetryDelayMilliseconds = retryDelayMilliseconds;
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.Wrappers.RetryingTargetWrapper));
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00015196 File Offset: 0x00013396
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0001519E File Offset: 0x0001339E
		[global::System.ComponentModel.DefaultValue(3)]
		public int RetryCount { get; set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x000151A7 File Offset: 0x000133A7
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x000151AF File Offset: 0x000133AF
		[global::System.ComponentModel.DefaultValue(100)]
		public int RetryDelayMilliseconds { get; set; }

		// Token: 0x06000851 RID: 2129 RVA: 0x000151B8 File Offset: 0x000133B8
		protected override void WriteAsyncThreadSafe(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents)
		{
			object retrySyncObject = this._retrySyncObject;
			lock (retrySyncObject)
			{
				for (int i = 0; i < logEvents.Count; i++)
				{
					if (!base.IsInitialized)
					{
						logEvents[i].Continuation(null);
					}
					else
					{
						this.WriteAsyncThreadSafe(logEvents[i]);
					}
				}
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00015230 File Offset: 0x00013430
		protected override void WriteAsyncThreadSafe(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			object retrySyncObject = this._retrySyncObject;
			lock (retrySyncObject)
			{
				this.Write(logEvent);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00015274 File Offset: 0x00013474
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			global::NLog.Common.AsyncContinuation continuation = null;
			int counter = 0;
			continuation = delegate(global::System.Exception ex)
			{
				if (ex == null)
				{
					logEvent.Continuation(null);
					return;
				}
				int num = global::System.Threading.Interlocked.Increment(ref counter);
				global::NLog.Common.InternalLogger.Warn(ex, "RetryingWrapper(Name={0}): Error while writing to '{1}'. Try {2}/{3}", new object[]
				{
					this.Name,
					this.WrappedTarget,
					num,
					this.RetryCount
				});
				if (num >= this.RetryCount)
				{
					global::NLog.Common.InternalLogger.Warn("Too many retries. Aborting.");
					logEvent.Continuation(ex);
					return;
				}
				int i = 0;
				while (i < this.RetryDelayMilliseconds)
				{
					int num2 = global::System.Math.Min(100, this.RetryDelayMilliseconds - i);
					global::NLog.Common.AsyncHelpers.WaitForDelay(global::System.TimeSpan.FromMilliseconds((double)num2));
					i += num2;
					if (!this.IsInitialized)
					{
						global::NLog.Common.InternalLogger.Warn<string>("RetryingWrapper(Name={0}): Target closed. Aborting.", this.Name);
						logEvent.Continuation(ex);
						return;
					}
				}
				this.WrappedTarget.WriteAsyncLogEvent(logEvent.LogEvent.WithContinuation(continuation));
			};
			base.WrappedTarget.WriteAsyncLogEvent(logEvent.LogEvent.WithContinuation(continuation));
		}

		// Token: 0x040001E6 RID: 486
		private readonly object _retrySyncObject = new object();
	}
}
