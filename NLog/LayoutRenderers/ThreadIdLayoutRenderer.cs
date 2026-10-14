using System;
using System.Text;
using NLog.Common;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000DC RID: 220
	[global::NLog.LayoutRenderers.LayoutRenderer("threadid")]
	[global::NLog.Config.ThreadSafe]
	public class ThreadIdLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000BE6 RID: 3046 RVA: 0x0001DBD4 File Offset: 0x0001BDD4
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			builder.AppendInvariant(global::NLog.Common.AsyncHelpers.GetManagedThreadId());
		}
	}
}
