using System;
using System.Collections.Generic;

namespace NLog.Targets
{
	// Token: 0x02000043 RID: 67
	[global::NLog.Targets.Target("Memory")]
	public sealed class MemoryTarget : global::NLog.Targets.TargetWithLayout
	{
		// Token: 0x0600068C RID: 1676 RVA: 0x00010396 File Offset: 0x0000E596
		public MemoryTarget()
		{
			this.Logs = new global::System.Collections.Generic.List<string>();
			base.OptimizeBufferReuse = true;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000103B0 File Offset: 0x0000E5B0
		public MemoryTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x000103BF File Offset: 0x0000E5BF
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x000103C7 File Offset: 0x0000E5C7
		public global::System.Collections.Generic.IList<string> Logs { get; private set; }

		// Token: 0x06000690 RID: 1680 RVA: 0x000103D0 File Offset: 0x0000E5D0
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			this.Logs.Add(base.RenderLogEvent(this.Layout, logEvent));
		}
	}
}
