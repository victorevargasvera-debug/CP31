using System;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000CC RID: 204
	[global::NLog.LayoutRenderers.LayoutRenderer("newline")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	[global::NLog.Config.AppDomainFixedOutput]
	public class NewLineLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000B7B RID: 2939 RVA: 0x0001CF0E File Offset: 0x0001B10E
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			builder.Append(global::NLog.Internal.EnvironmentHelper.NewLine);
		}
	}
}
