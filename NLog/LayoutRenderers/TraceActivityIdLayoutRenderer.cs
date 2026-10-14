using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000E0 RID: 224
	[global::NLog.LayoutRenderers.LayoutRenderer("activityid")]
	[global::NLog.Config.ThreadSafe]
	public class TraceActivityIdLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000BF2 RID: 3058 RVA: 0x0001DD20 File Offset: 0x0001BF20
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.Guid activityId = global::System.Diagnostics.Trace.CorrelationManager.ActivityId;
			builder.Append(global::System.Guid.Empty.Equals(activityId) ? string.Empty : activityId.ToString("D", global::System.Globalization.CultureInfo.InvariantCulture));
		}
	}
}
