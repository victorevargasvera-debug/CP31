using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000EE RID: 238
	[global::NLog.LayoutRenderers.LayoutRenderer("uppercase")]
	[global::NLog.LayoutRenderers.AmbientProperty("Uppercase")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class UppercaseLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBuilderBase
	{
		// Token: 0x06000C55 RID: 3157 RVA: 0x0001E832 File Offset: 0x0001CA32
		public UppercaseLayoutRendererWrapper()
		{
			this.Culture = global::System.Globalization.CultureInfo.InvariantCulture;
			this.Uppercase = true;
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0001E84C File Offset: 0x0001CA4C
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x0001E854 File Offset: 0x0001CA54
		[global::System.ComponentModel.DefaultValue(true)]
		public bool Uppercase { get; set; }

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0001E85D File Offset: 0x0001CA5D
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0001E865 File Offset: 0x0001CA65
		public global::System.Globalization.CultureInfo Culture { get; set; }

		// Token: 0x06000C5A RID: 3162 RVA: 0x0001E86E File Offset: 0x0001CA6E
		protected override void RenderInnerAndTransform(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, int orgLength)
		{
			base.Inner.RenderAppendBuilder(logEvent, builder, false);
			if (this.Uppercase && builder.Length > orgLength)
			{
				this.TransformToUpperCase(builder, orgLength);
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0001E897 File Offset: 0x0001CA97
		protected override void TransformFormattedMesssage(global::System.Text.StringBuilder target)
		{
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0001E89C File Offset: 0x0001CA9C
		private void TransformToUpperCase(global::System.Text.StringBuilder target, int startPos)
		{
			global::System.Globalization.CultureInfo culture = this.Culture;
			for (int i = startPos; i < target.Length; i++)
			{
				target[i] = char.ToUpper(target[i], culture);
			}
		}
	}
}
