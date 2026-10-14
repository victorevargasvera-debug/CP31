using System;
using System.ComponentModel;

namespace NLog.Targets
{
	// Token: 0x0200004C RID: 76
	[global::NLog.Targets.Target("Null")]
	public sealed class NullTarget : global::NLog.Targets.TargetWithLayout
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00011312 File Offset: 0x0000F512
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x0001131A File Offset: 0x0000F51A
		[global::System.ComponentModel.DefaultValue(false)]
		public bool FormatMessage { get; set; }

		// Token: 0x060006F7 RID: 1783 RVA: 0x00011323 File Offset: 0x0000F523
		public NullTarget()
		{
			base.OptimizeBufferReuse = true;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00011332 File Offset: 0x0000F532
		public NullTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00011341 File Offset: 0x0000F541
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			if (this.FormatMessage)
			{
				base.RenderLogEvent(this.Layout, logEvent);
			}
		}
	}
}
