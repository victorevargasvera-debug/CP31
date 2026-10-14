using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000E6 RID: 230
	[global::NLog.LayoutRenderers.LayoutRenderer("lowercase")]
	[global::NLog.LayoutRenderers.AmbientProperty("Lowercase")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class LowercaseLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBuilderBase
	{
		// Token: 0x06000C1C RID: 3100 RVA: 0x0001E1B5 File Offset: 0x0001C3B5
		public LowercaseLayoutRendererWrapper()
		{
			this.Culture = global::System.Globalization.CultureInfo.InvariantCulture;
			this.Lowercase = true;
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0001E1CF File Offset: 0x0001C3CF
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x0001E1D7 File Offset: 0x0001C3D7
		[global::System.ComponentModel.DefaultValue(true)]
		public bool Lowercase { get; set; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x0001E1E0 File Offset: 0x0001C3E0
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x0001E1E8 File Offset: 0x0001C3E8
		public global::System.Globalization.CultureInfo Culture { get; set; }

		// Token: 0x06000C21 RID: 3105 RVA: 0x0001E1F1 File Offset: 0x0001C3F1
		protected override void RenderInnerAndTransform(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, int orgLength)
		{
			base.Inner.RenderAppendBuilder(logEvent, builder, false);
			if (this.Lowercase && builder.Length > orgLength)
			{
				this.TransformToLowerCase(builder, orgLength);
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0001E21A File Offset: 0x0001C41A
		protected override void TransformFormattedMesssage(global::System.Text.StringBuilder target)
		{
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0001E21C File Offset: 0x0001C41C
		private void TransformToLowerCase(global::System.Text.StringBuilder target, int startPos)
		{
			global::System.Globalization.CultureInfo culture = this.Culture;
			for (int i = startPos; i < target.Length; i++)
			{
				target[i] = char.ToLower(target[i], culture);
			}
		}
	}
}
