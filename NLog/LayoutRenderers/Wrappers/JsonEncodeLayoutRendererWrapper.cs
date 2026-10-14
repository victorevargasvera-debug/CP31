using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;
using NLog.Targets;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000E5 RID: 229
	[global::NLog.LayoutRenderers.LayoutRenderer("json-encode")]
	[global::NLog.LayoutRenderers.AmbientProperty("JsonEncode")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class JsonEncodeLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBuilderBase
	{
		// Token: 0x06000C14 RID: 3092 RVA: 0x0001E0E9 File Offset: 0x0001C2E9
		public JsonEncodeLayoutRendererWrapper()
		{
			this.JsonEncode = true;
			this.EscapeUnicode = true;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x0001E0FF File Offset: 0x0001C2FF
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x0001E107 File Offset: 0x0001C307
		[global::System.ComponentModel.DefaultValue(true)]
		public bool JsonEncode { get; set; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x0001E110 File Offset: 0x0001C310
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x0001E118 File Offset: 0x0001C318
		[global::System.ComponentModel.DefaultValue(true)]
		public bool EscapeUnicode { get; set; }

		// Token: 0x06000C19 RID: 3097 RVA: 0x0001E124 File Offset: 0x0001C324
		protected override void RenderInnerAndTransform(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, int orgLength)
		{
			base.Inner.RenderAppendBuilder(logEvent, builder, false);
			if (this.JsonEncode && builder.Length > orgLength && this.RequiresJsonEncode(builder, orgLength))
			{
				string text = builder.ToString(orgLength, builder.Length - orgLength);
				builder.Length = orgLength;
				global::NLog.Targets.DefaultJsonSerializer.AppendStringEscape(builder, text, this.EscapeUnicode);
			}
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0001E17E File Offset: 0x0001C37E
		protected override void TransformFormattedMesssage(global::System.Text.StringBuilder target)
		{
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0001E180 File Offset: 0x0001C380
		private bool RequiresJsonEncode(global::System.Text.StringBuilder target, int startPos = 0)
		{
			for (int i = startPos; i < target.Length; i++)
			{
				if (global::NLog.Targets.DefaultJsonSerializer.RequiresJsonEscape(target[i], this.EscapeUnicode))
				{
					return true;
				}
			}
			return false;
		}
	}
}
