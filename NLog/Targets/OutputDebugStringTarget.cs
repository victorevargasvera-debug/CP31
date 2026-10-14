using System;
using NLog.Internal;

namespace NLog.Targets
{
	// Token: 0x0200004D RID: 77
	[global::NLog.Targets.Target("OutputDebugString")]
	public sealed class OutputDebugStringTarget : global::NLog.Targets.TargetWithLayout
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x00011359 File Offset: 0x0000F559
		public OutputDebugStringTarget()
		{
			base.OptimizeBufferReuse = true;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00011368 File Offset: 0x0000F568
		public OutputDebugStringTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00011377 File Offset: 0x0000F577
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			global::NLog.Internal.NativeMethods.OutputDebugString(base.RenderLogEvent(this.Layout, logEvent));
		}
	}
}
