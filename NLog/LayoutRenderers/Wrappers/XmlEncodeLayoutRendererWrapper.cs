using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000F5 RID: 245
	[global::NLog.LayoutRenderers.LayoutRenderer("xml-encode")]
	[global::NLog.LayoutRenderers.AmbientProperty("XmlEncode")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class XmlEncodeLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBase
	{
		// Token: 0x06000C85 RID: 3205 RVA: 0x0001EC11 File Offset: 0x0001CE11
		public XmlEncodeLayoutRendererWrapper()
		{
			this.XmlEncode = true;
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x0001EC20 File Offset: 0x0001CE20
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x0001EC28 File Offset: 0x0001CE28
		[global::System.ComponentModel.DefaultValue(true)]
		public bool XmlEncode { get; set; }

		// Token: 0x06000C88 RID: 3208 RVA: 0x0001EC31 File Offset: 0x0001CE31
		protected override string Transform(string text)
		{
			if (!this.XmlEncode)
			{
				return text;
			}
			return global::NLog.LayoutRenderers.Wrappers.XmlEncodeLayoutRendererWrapper.DoXmlEscape(text);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0001EC44 File Offset: 0x0001CE44
		private static string DoXmlEscape(string text)
		{
			if (text.Length < 4096 && text.IndexOfAny(global::NLog.LayoutRenderers.Wrappers.XmlEncodeLayoutRendererWrapper.XmlEscapeChars) < 0)
			{
				return text;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(text.Length);
			int i = 0;
			while (i < text.Length)
			{
				char c = text[i];
				if (c <= '&')
				{
					if (c != '"')
					{
						if (c != '&')
						{
							goto IL_A0;
						}
						stringBuilder.Append("&amp;");
					}
					else
					{
						stringBuilder.Append("&quot;");
					}
				}
				else if (c != '\'')
				{
					if (c != '<')
					{
						if (c != '>')
						{
							goto IL_A0;
						}
						stringBuilder.Append("&gt;");
					}
					else
					{
						stringBuilder.Append("&lt;");
					}
				}
				else
				{
					stringBuilder.Append("&apos;");
				}
				IL_AE:
				i++;
				continue;
				IL_A0:
				stringBuilder.Append(text[i]);
				goto IL_AE;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000379 RID: 889
		private static readonly char[] XmlEscapeChars = new char[]
		{
			'<',
			'>',
			'&',
			'\'',
			'"'
		};
	}
}
