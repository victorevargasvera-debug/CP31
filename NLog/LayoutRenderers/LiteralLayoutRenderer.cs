using System;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000C1 RID: 193
	[global::NLog.LayoutRenderers.LayoutRenderer("literal")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	[global::NLog.Config.AppDomainFixedOutput]
	public class LiteralLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000B13 RID: 2835 RVA: 0x0001BF48 File Offset: 0x0001A148
		public LiteralLayoutRenderer()
		{
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0001BF50 File Offset: 0x0001A150
		public LiteralLayoutRenderer(string text)
		{
			this.Text = text;
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0001BF5F File Offset: 0x0001A15F
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x0001BF67 File Offset: 0x0001A167
		public string Text { get; set; }

		// Token: 0x06000B17 RID: 2839 RVA: 0x0001BF70 File Offset: 0x0001A170
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			builder.Append(this.Text);
		}
	}
}
