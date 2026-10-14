using System;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000D6 RID: 214
	[global::NLog.LayoutRenderers.LayoutRenderer("sequenceid")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class SequenceIdLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000BC3 RID: 3011 RVA: 0x0001D820 File Offset: 0x0001BA20
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			builder.AppendInvariant(logEvent.SequenceID);
		}
	}
}
