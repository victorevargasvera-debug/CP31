using System;
using System.Text;
using System.Threading;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000DD RID: 221
	[global::NLog.LayoutRenderers.LayoutRenderer("threadname")]
	[global::NLog.Config.ThreadSafe]
	public class ThreadNameLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000BE8 RID: 3048 RVA: 0x0001DBE9 File Offset: 0x0001BDE9
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			builder.Append(global::System.Threading.Thread.CurrentThread.Name);
		}
	}
}
