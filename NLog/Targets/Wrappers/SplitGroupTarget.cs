using System;
using System.Collections.Generic;
using System.Threading;
using NLog.Common;

namespace NLog.Targets.Wrappers
{
	// Token: 0x02000070 RID: 112
	[global::NLog.Targets.Target("SplitGroup", IsCompound = true)]
	public class SplitGroupTarget : global::NLog.Targets.Wrappers.CompoundTargetBase
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x0001537D File Offset: 0x0001357D
		public SplitGroupTarget() : this(new global::NLog.Targets.Target[0])
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0001538B File Offset: 0x0001358B
		public SplitGroupTarget(string name, params global::NLog.Targets.Target[] targets) : this(targets)
		{
			base.Name = name;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0001539B File Offset: 0x0001359B
		public SplitGroupTarget(params global::NLog.Targets.Target[] targets) : base(targets)
		{
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x000153A4 File Offset: 0x000135A4
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			global::NLog.Common.AsyncHelpers.ForEachItemSequentially<global::NLog.Targets.Target>(base.Targets, logEvent.Continuation, delegate(global::NLog.Targets.Target t, global::NLog.Common.AsyncContinuation cont)
			{
				t.WriteAsyncLogEvent(logEvent.LogEvent.WithContinuation(cont));
			});
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000153E0 File Offset: 0x000135E0
		[global::System.Obsolete("Instead override Write(IList<AsyncLogEventInfo> logEvents. Marked obsolete on NLog 4.5")]
		protected override void Write(global::NLog.Common.AsyncLogEventInfo[] logEvents)
		{
			this.Write(logEvents);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000153EC File Offset: 0x000135EC
		protected override void Write(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents)
		{
			global::NLog.Common.InternalLogger.Trace<string, int>("SplitGroup(Name={0}): Writing {1} events", base.Name, logEvents.Count);
			for (int i = 0; i < logEvents.Count; i++)
			{
				global::NLog.Common.AsyncLogEventInfo asyncLogEventInfo = logEvents[i];
				logEvents[i] = new global::NLog.Common.AsyncLogEventInfo(asyncLogEventInfo.LogEvent, global::NLog.Targets.Wrappers.SplitGroupTarget.CountedWrap(asyncLogEventInfo.Continuation, base.Targets.Count));
			}
			for (int j = 0; j < base.Targets.Count; j++)
			{
				global::NLog.Common.InternalLogger.Trace<string, int, global::NLog.Targets.Target>("SplitGroup(Name={0}): Sending {1} events to {2}", base.Name, logEvents.Count, base.Targets[j]);
				global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents2 = logEvents;
				if (j < base.Targets.Count - 1)
				{
					global::NLog.Common.AsyncLogEventInfo[] array = new global::NLog.Common.AsyncLogEventInfo[logEvents.Count];
					logEvents.CopyTo(array, 0);
					logEvents2 = array;
				}
				base.Targets[j].WriteAsyncLogEvents(logEvents2);
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000154C8 File Offset: 0x000136C8
		private static global::NLog.Common.AsyncContinuation CountedWrap(global::NLog.Common.AsyncContinuation originalContinuation, int counter)
		{
			if (counter == 1)
			{
				return originalContinuation;
			}
			global::System.Collections.Generic.List<global::System.Exception> exceptions = new global::System.Collections.Generic.List<global::System.Exception>();
			return delegate(global::System.Exception ex)
			{
				global::System.Collections.Generic.List<global::System.Exception> exceptions;
				if (ex != null)
				{
					exceptions = exceptions;
					lock (exceptions)
					{
						exceptions.Add(ex);
					}
				}
				int num = global::System.Threading.Interlocked.Decrement(ref counter);
				if (num == 0)
				{
					global::System.Exception combinedException = global::NLog.Common.AsyncHelpers.GetCombinedException(exceptions);
					global::NLog.Common.InternalLogger.Trace<global::System.Exception>("Combined exception: {0}", combinedException);
					originalContinuation(combinedException);
					return;
				}
				global::NLog.Common.InternalLogger.Trace<int>("{0} remaining.", num);
			};
		}
	}
}
