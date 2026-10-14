using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000F2 RID: 242
	[global::NLog.LayoutRenderers.LayoutRenderer("wrapline")]
	[global::NLog.LayoutRenderers.AmbientProperty("WrapLine")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class WrapLineLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBase
	{
		// Token: 0x06000C71 RID: 3185 RVA: 0x0001EA2B File Offset: 0x0001CC2B
		public WrapLineLayoutRendererWrapper()
		{
			this.WrapLine = 80;
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x0001EA3B File Offset: 0x0001CC3B
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x0001EA43 File Offset: 0x0001CC43
		[global::System.ComponentModel.DefaultValue(80)]
		public int WrapLine { get; set; }

		// Token: 0x06000C74 RID: 3188 RVA: 0x0001EA4C File Offset: 0x0001CC4C
		protected override string Transform(string text)
		{
			if (this.WrapLine <= 0)
			{
				return text;
			}
			int num = this.WrapLine;
			if (text.Length <= num)
			{
				return text;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(text.Length + text.Length / num * global::System.Environment.NewLine.Length);
			for (int i = 0; i < text.Length; i += num)
			{
				if (num + i > text.Length)
				{
					num = text.Length - i;
				}
				stringBuilder.Append(text.Substring(i, num));
				if (num + i < text.Length)
				{
					stringBuilder.Append(global::System.Environment.NewLine);
				}
			}
			return stringBuilder.ToString();
		}
	}
}
