using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000ED RID: 237
	[global::NLog.LayoutRenderers.LayoutRenderer("trim-whitespace")]
	[global::NLog.LayoutRenderers.AmbientProperty("TrimWhiteSpace")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class TrimWhiteSpaceLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBuilderBase
	{
		// Token: 0x06000C4E RID: 3150 RVA: 0x0001E756 File Offset: 0x0001C956
		public TrimWhiteSpaceLayoutRendererWrapper()
		{
			this.TrimWhiteSpace = true;
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0001E765 File Offset: 0x0001C965
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x0001E76D File Offset: 0x0001C96D
		[global::System.ComponentModel.DefaultValue(true)]
		public bool TrimWhiteSpace { get; set; }

		// Token: 0x06000C51 RID: 3153 RVA: 0x0001E776 File Offset: 0x0001C976
		protected override void RenderInnerAndTransform(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, int orgLength)
		{
			base.Inner.RenderAppendBuilder(logEvent, builder, false);
			if (this.TrimWhiteSpace && builder.Length > orgLength)
			{
				global::NLog.LayoutRenderers.Wrappers.TrimWhiteSpaceLayoutRendererWrapper.TransformTrimWhiteSpaces(builder, orgLength);
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0001E79E File Offset: 0x0001C99E
		protected override void TransformFormattedMesssage(global::System.Text.StringBuilder target)
		{
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0001E7A0 File Offset: 0x0001C9A0
		private static void TransformTrimWhiteSpaces(global::System.Text.StringBuilder builder, int startPos)
		{
			global::NLog.LayoutRenderers.Wrappers.TrimWhiteSpaceLayoutRendererWrapper.TrimRight(builder, startPos);
			if (builder.Length > startPos && char.IsWhiteSpace(builder[startPos]))
			{
				string text = builder.ToString(startPos, builder.Length - startPos);
				builder.Length = startPos;
				builder.Append(text.Trim());
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0001E7F0 File Offset: 0x0001C9F0
		private static void TrimRight(global::System.Text.StringBuilder sb, int startPos)
		{
			int num = sb.Length - 1;
			while (num >= startPos && char.IsWhiteSpace(sb[num]))
			{
				num--;
			}
			if (num < sb.Length - 1)
			{
				sb.Length = num + 1;
			}
		}
	}
}
