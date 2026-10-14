using System;
using System.Threading;
using NLog.Common;

namespace NLog.Targets.Wrappers
{
	// Token: 0x02000063 RID: 99
	[global::NLog.Targets.Target("FallbackGroup", IsCompound = true)]
	public class FallbackGroupTarget : global::NLog.Targets.Wrappers.CompoundTargetBase
	{
		// Token: 0x060007FA RID: 2042 RVA: 0x000146B5 File Offset: 0x000128B5
		public FallbackGroupTarget() : this(new global::NLog.Targets.Target[0])
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000146C3 File Offset: 0x000128C3
		public FallbackGroupTarget(string name, params global::NLog.Targets.Target[] targets) : this(targets)
		{
			base.Name = name;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000146D3 File Offset: 0x000128D3
		public FallbackGroupTarget(params global::NLog.Targets.Target[] targets) : base(targets)
		{
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.Wrappers.FallbackGroupTarget));
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x000146F7 File Offset: 0x000128F7
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x000146FF File Offset: 0x000128FF
		public bool ReturnToFirstOnSuccess { get; set; }

		// Token: 0x060007FF RID: 2047 RVA: 0x00014708 File Offset: 0x00012908
		protected override void WriteAsyncThreadSafe(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			this.Write(logEvent);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00014714 File Offset: 0x00012914
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			global::NLog.Common.AsyncContinuation continuation = null;
			int tryCounter = 0;
			int targetToInvoke = 0;
			continuation = delegate(global::System.Exception ex)
			{
				if (ex == null)
				{
					if (this.ReturnToFirstOnSuccess && global::System.Threading.Interlocked.Read(ref this._currentTarget) != 0L)
					{
						global::NLog.Common.InternalLogger.Debug<string, global::NLog.Targets.Target>("FallbackGroup(Name={0}): Target '{1}' succeeded. Returning to the first one.", this.Name, this.Targets[targetToInvoke]);
						global::System.Threading.Interlocked.Exchange(ref this._currentTarget, 0L);
					}
					logEvent.Continuation(null);
					return;
				}
				global::NLog.Common.InternalLogger.Warn(ex, "FallbackGroup(Name={0}): Target '{1}' failed. Proceeding to the next one.", new object[]
				{
					this.Name,
					this.Targets[targetToInvoke]
				});
				int tryCounter = tryCounter;
				tryCounter++;
				int num = (targetToInvoke + 1) % this.Targets.Count;
				global::System.Threading.Interlocked.CompareExchange(ref this._currentTarget, (long)num, (long)targetToInvoke);
				if (tryCounter >= this.Targets.Count)
				{
					targetToInvoke = -1;
				}
				else
				{
					targetToInvoke = num;
				}
				if (targetToInvoke >= 0)
				{
					this.Targets[targetToInvoke].WriteAsyncLogEvent(logEvent.LogEvent.WithContinuation(continuation));
					return;
				}
				logEvent.Continuation(ex);
			};
			targetToInvoke = (int)global::System.Threading.Interlocked.Read(ref this._currentTarget);
			for (int i = 0; i < base.Targets.Count; i++)
			{
				if (i != targetToInvoke)
				{
					base.Targets[i].PrecalculateVolatileLayouts(logEvent.LogEvent);
				}
			}
			base.Targets[targetToInvoke].WriteAsyncLogEvent(logEvent.LogEvent.WithContinuation(continuation));
		}

		// Token: 0x040001CA RID: 458
		private long _currentTarget;
	}
}
