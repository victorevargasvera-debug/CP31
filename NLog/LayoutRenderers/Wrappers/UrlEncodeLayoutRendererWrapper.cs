using System;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000EF RID: 239
	[global::NLog.LayoutRenderers.LayoutRenderer("url-encode")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class UrlEncodeLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBase
	{
		// Token: 0x06000C5D RID: 3165 RVA: 0x0001E8D5 File Offset: 0x0001CAD5
		public UrlEncodeLayoutRendererWrapper()
		{
			this.SpaceAsPlus = true;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0001E8E4 File Offset: 0x0001CAE4
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x0001E8EC File Offset: 0x0001CAEC
		public bool SpaceAsPlus { get; set; }

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0001E8F5 File Offset: 0x0001CAF5
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x0001E8FD File Offset: 0x0001CAFD
		public bool EscapeDataRfc3986 { get; set; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0001E906 File Offset: 0x0001CB06
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x0001E90E File Offset: 0x0001CB0E
		public bool EscapeDataNLogLegacy { get; set; }

		// Token: 0x06000C64 RID: 3172 RVA: 0x0001E918 File Offset: 0x0001CB18
		protected override string Transform(string text)
		{
			if (!string.IsNullOrEmpty(text))
			{
				global::NLog.Internal.UrlHelper.EscapeEncodingFlag uriStringEncodingFlags = global::NLog.Internal.UrlHelper.GetUriStringEncodingFlags(this.EscapeDataNLogLegacy, this.SpaceAsPlus, this.EscapeDataRfc3986);
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(text.Length + 20);
				global::NLog.Internal.UrlHelper.EscapeDataEncode(text, stringBuilder, uriStringEncodingFlags);
				return stringBuilder.ToString();
			}
			return string.Empty;
		}
	}
}
