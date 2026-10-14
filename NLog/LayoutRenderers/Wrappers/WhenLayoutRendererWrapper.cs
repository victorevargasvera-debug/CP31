using System;
using System.Text;
using NLog.Conditions;
using NLog.Config;
using NLog.Layouts;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000F1 RID: 241
	[global::NLog.LayoutRenderers.LayoutRenderer("when")]
	[global::NLog.LayoutRenderers.AmbientProperty("When")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class WhenLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBuilderBase
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x0001E9AB File Offset: 0x0001CBAB
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x0001E9B3 File Offset: 0x0001CBB3
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Conditions.ConditionExpression When { get; set; }

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0001E9BC File Offset: 0x0001CBBC
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x0001E9C4 File Offset: 0x0001CBC4
		public global::NLog.Layouts.Layout Else { get; set; }

		// Token: 0x06000C6E RID: 3182 RVA: 0x0001E9D0 File Offset: 0x0001CBD0
		protected override void RenderInnerAndTransform(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, int orgLength)
		{
			if (this.When == null || true.Equals(this.When.Evaluate(logEvent)))
			{
				base.Inner.RenderAppendBuilder(logEvent, builder, false);
				return;
			}
			if (this.Else != null)
			{
				this.Else.RenderAppendBuilder(logEvent, builder, false);
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0001EA21 File Offset: 0x0001CC21
		protected override void TransformFormattedMesssage(global::System.Text.StringBuilder target)
		{
		}
	}
}
