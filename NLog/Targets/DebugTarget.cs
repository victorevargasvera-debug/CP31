using System;

namespace NLog.Targets
{
	// Token: 0x02000034 RID: 52
	[global::NLog.Targets.Target("Debug")]
	public sealed class DebugTarget : global::NLog.Targets.TargetWithLayout
	{
		// Token: 0x0600054C RID: 1356 RVA: 0x0000B360 File Offset: 0x00009560
		public DebugTarget()
		{
			this.LastMessage = string.Empty;
			this.Counter = 0;
			base.OptimizeBufferReuse = true;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0000B381 File Offset: 0x00009581
		public DebugTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0000B390 File Offset: 0x00009590
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x0000B398 File Offset: 0x00009598
		public int Counter { get; private set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0000B3A1 File Offset: 0x000095A1
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x0000B3A9 File Offset: 0x000095A9
		public string LastMessage { get; private set; }

		// Token: 0x06000552 RID: 1362 RVA: 0x0000B3B4 File Offset: 0x000095B4
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			int counter = this.Counter;
			this.Counter = counter + 1;
			this.LastMessage = base.RenderLogEvent(this.Layout, logEvent);
		}
	}
}
