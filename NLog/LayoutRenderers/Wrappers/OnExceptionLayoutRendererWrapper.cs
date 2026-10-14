using System;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000E7 RID: 231
	[global::NLog.LayoutRenderers.LayoutRenderer("onexception")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class OnExceptionLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBase
	{
		// Token: 0x06000C24 RID: 3108 RVA: 0x0001E255 File Offset: 0x0001C455
		protected override void RenderInnerAndTransform(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, int orgLength)
		{
			if (logEvent.Exception != null)
			{
				base.Inner.RenderAppendBuilder(logEvent, builder, false);
			}
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0001E26D File Offset: 0x0001C46D
		protected override string Transform(string text)
		{
			return text;
		}
	}
}
