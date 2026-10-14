using System;
using System.ComponentModel;
using NLog.Common;

namespace NLog.Targets.Wrappers
{
	// Token: 0x0200006B RID: 107
	[global::NLog.Targets.Target("RepeatingWrapper", IsWrapper = true)]
	public class RepeatingTargetWrapper : global::NLog.Targets.Wrappers.WrapperTargetBase
	{
		// Token: 0x06000844 RID: 2116 RVA: 0x00015084 File Offset: 0x00013284
		public RepeatingTargetWrapper() : this(null, 3)
		{
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0001508E File Offset: 0x0001328E
		public RepeatingTargetWrapper(string name, global::NLog.Targets.Target wrappedTarget, int repeatCount) : this(wrappedTarget, repeatCount)
		{
			base.Name = name;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0001509F File Offset: 0x0001329F
		public RepeatingTargetWrapper(global::NLog.Targets.Target wrappedTarget, int repeatCount)
		{
			base.WrappedTarget = wrappedTarget;
			this.RepeatCount = repeatCount;
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.Wrappers.RepeatingTargetWrapper));
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x000150D0 File Offset: 0x000132D0
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x000150D8 File Offset: 0x000132D8
		[global::System.ComponentModel.DefaultValue(3)]
		public int RepeatCount { get; set; }

		// Token: 0x06000849 RID: 2121 RVA: 0x000150E4 File Offset: 0x000132E4
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			global::NLog.Common.AsyncHelpers.Repeat(this.RepeatCount, logEvent.Continuation, delegate(global::NLog.Common.AsyncContinuation cont)
			{
				this.WrappedTarget.WriteAsyncLogEvent(logEvent.LogEvent.WithContinuation(cont));
			});
		}
	}
}
