using System;
using System.Globalization;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000DE RID: 222
	[global::NLog.LayoutRenderers.LayoutRenderer("ticks")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class TicksLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000BEA RID: 3050 RVA: 0x0001DC04 File Offset: 0x0001BE04
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			builder.Append(logEvent.TimeStamp.Ticks.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
		}
	}
}
