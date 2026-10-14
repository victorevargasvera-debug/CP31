using System;
using System.Text;
using NLog.Config;
using NLog.Layouts;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000F0 RID: 240
	[global::NLog.LayoutRenderers.LayoutRenderer("whenEmpty")]
	[global::NLog.LayoutRenderers.AmbientProperty("WhenEmpty")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class WhenEmptyLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBuilderBase
	{
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x0001E968 File Offset: 0x0001CB68
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x0001E970 File Offset: 0x0001CB70
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout WhenEmpty { get; set; }

		// Token: 0x06000C67 RID: 3175 RVA: 0x0001E979 File Offset: 0x0001CB79
		protected override void RenderInnerAndTransform(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, int orgLength)
		{
			base.Inner.RenderAppendBuilder(logEvent, builder, false);
			if (builder.Length > orgLength)
			{
				return;
			}
			this.WhenEmpty.RenderAppendBuilder(logEvent, builder, false);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0001E9A1 File Offset: 0x0001CBA1
		protected override void TransformFormattedMesssage(global::System.Text.StringBuilder target)
		{
		}
	}
}
