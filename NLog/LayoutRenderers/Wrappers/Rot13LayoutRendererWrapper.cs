using System;
using System.Text;
using NLog.Config;
using NLog.Layouts;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000EC RID: 236
	[global::NLog.LayoutRenderers.LayoutRenderer("rot13")]
	[global::NLog.Config.AppDomainFixedOutput]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class Rot13LayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBuilderBase
	{
		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0001E665 File Offset: 0x0001C865
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x0001E66D File Offset: 0x0001C86D
		public global::NLog.Layouts.Layout Text
		{
			get
			{
				return base.Inner;
			}
			set
			{
				base.Inner = value;
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0001E676 File Offset: 0x0001C876
		public static string DecodeRot13(string encodedValue)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(encodedValue.Length);
			stringBuilder.Append(encodedValue);
			global::NLog.LayoutRenderers.Wrappers.Rot13LayoutRendererWrapper.DecodeRot13(stringBuilder, 0);
			return stringBuilder.ToString();
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0001E697 File Offset: 0x0001C897
		protected override void RenderInnerAndTransform(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, int orgLength)
		{
			base.Inner.RenderAppendBuilder(logEvent, builder, false);
			if (builder.Length > orgLength)
			{
				global::NLog.LayoutRenderers.Wrappers.Rot13LayoutRendererWrapper.DecodeRot13(builder, orgLength);
			}
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0001E6B7 File Offset: 0x0001C8B7
		protected override void TransformFormattedMesssage(global::System.Text.StringBuilder target)
		{
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0001E6BC File Offset: 0x0001C8BC
		internal static void DecodeRot13(global::System.Text.StringBuilder encodedValue, int startPos)
		{
			if (encodedValue == null)
			{
				return;
			}
			for (int i = startPos; i < encodedValue.Length; i++)
			{
				encodedValue[i] = global::NLog.LayoutRenderers.Wrappers.Rot13LayoutRendererWrapper.DecodeRot13Char(encodedValue[i]);
			}
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0001E6F4 File Offset: 0x0001C8F4
		private static char DecodeRot13Char(char c)
		{
			if (c >= 'A' && c <= 'M')
			{
				return 'N' + (c - 'A');
			}
			if (c >= 'a' && c <= 'm')
			{
				return 'n' + (c - 'a');
			}
			if (c >= 'N' && c <= 'Z')
			{
				return 'A' + (c - 'N');
			}
			if (c >= 'n' && c <= 'z')
			{
				return 'a' + (c - 'n');
			}
			return c;
		}
	}
}
