using System;
using NLog.Common;
using NLog.Config;

namespace NLog.Targets.Wrappers
{
	// Token: 0x02000071 RID: 113
	public abstract class WrapperTargetBase : global::NLog.Targets.Target
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00015510 File Offset: 0x00013710
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00015518 File Offset: 0x00013718
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Targets.Target WrappedTarget { get; set; }

		// Token: 0x06000862 RID: 2146 RVA: 0x00015521 File Offset: 0x00013721
		public override string ToString()
		{
			return string.Format("{0}({1})", base.ToString(), this.WrappedTarget);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00015539 File Offset: 0x00013739
		protected override void FlushAsync(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			this.WrappedTarget.Flush(asyncContinuation);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00015547 File Offset: 0x00013747
		protected sealed override void Write(global::NLog.LogEventInfo logEvent)
		{
			throw new global::System.NotSupportedException("This target must not be invoked in a synchronous way.");
		}
	}
}
