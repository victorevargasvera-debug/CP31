using System;
using System.Threading;
using NLog.Common;

namespace NLog.Targets.Wrappers
{
	// Token: 0x0200006D RID: 109
	[global::NLog.Targets.Target("RoundRobinGroup", IsCompound = true)]
	public class RoundRobinGroupTarget : global::NLog.Targets.Wrappers.CompoundTargetBase
	{
		// Token: 0x06000854 RID: 2132 RVA: 0x000152D6 File Offset: 0x000134D6
		public RoundRobinGroupTarget() : this(new global::NLog.Targets.Target[0])
		{
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000152E4 File Offset: 0x000134E4
		public RoundRobinGroupTarget(string name, params global::NLog.Targets.Target[] targets) : this(targets)
		{
			base.Name = name;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x000152F4 File Offset: 0x000134F4
		public RoundRobinGroupTarget(params global::NLog.Targets.Target[] targets) : base(targets)
		{
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.Wrappers.RoundRobinGroupTarget));
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0001531F File Offset: 0x0001351F
		protected override void WriteAsyncThreadSafe(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			this.Write(logEvent);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00015328 File Offset: 0x00013528
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			if (base.Targets.Count == 0)
			{
				logEvent.Continuation(null);
				return;
			}
			int index = (int)((ulong)global::System.Threading.Interlocked.Increment(ref this._currentTarget) % (ulong)((long)base.Targets.Count));
			base.Targets[index].WriteAsyncLogEvent(logEvent);
		}

		// Token: 0x040001E7 RID: 487
		private int _currentTarget = -1;
	}
}
