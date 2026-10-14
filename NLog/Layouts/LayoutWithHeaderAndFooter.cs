using System;
using System.Text;
using NLog.Config;

namespace NLog.Layouts
{
	// Token: 0x020000A2 RID: 162
	[global::NLog.Layouts.Layout("LayoutWithHeaderAndFooter")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	[global::NLog.Config.AppDomainFixedOutput]
	public class LayoutWithHeaderAndFooter : global::NLog.Layouts.Layout
	{
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00019F22 File Offset: 0x00018122
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x00019F2A File Offset: 0x0001812A
		public global::NLog.Layouts.Layout Layout { get; set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00019F33 File Offset: 0x00018133
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00019F3B File Offset: 0x0001813B
		public global::NLog.Layouts.Layout Header { get; set; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00019F44 File Offset: 0x00018144
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00019F4C File Offset: 0x0001814C
		public global::NLog.Layouts.Layout Footer { get; set; }

		// Token: 0x06000A11 RID: 2577 RVA: 0x00019F55 File Offset: 0x00018155
		protected override string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
		{
			return this.Layout.Render(logEvent);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00019F63 File Offset: 0x00018163
		protected override void RenderFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			this.Layout.RenderAppendBuilder(logEvent, target, false);
		}
	}
}
