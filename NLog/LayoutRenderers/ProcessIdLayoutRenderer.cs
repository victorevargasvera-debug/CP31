using System;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000CF RID: 207
	[global::NLog.LayoutRenderers.LayoutRenderer("processid")]
	[global::NLog.Config.AppDomainFixedOutput]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class ProcessIdLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000B94 RID: 2964 RVA: 0x0001D105 File Offset: 0x0001B305
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			builder.AppendInvariant(global::NLog.Internal.ThreadIDHelper.Instance.CurrentProcessID);
		}
	}
}
