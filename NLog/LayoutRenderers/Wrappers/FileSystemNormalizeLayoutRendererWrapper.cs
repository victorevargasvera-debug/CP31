using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000E4 RID: 228
	[global::NLog.LayoutRenderers.LayoutRenderer("filesystem-normalize")]
	[global::NLog.LayoutRenderers.AmbientProperty("FSNormalize")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class FileSystemNormalizeLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBuilderBase
	{
		// Token: 0x06000C0D RID: 3085 RVA: 0x0001E049 File Offset: 0x0001C249
		public FileSystemNormalizeLayoutRendererWrapper()
		{
			this.FSNormalize = true;
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0001E058 File Offset: 0x0001C258
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x0001E060 File Offset: 0x0001C260
		[global::System.ComponentModel.DefaultValue(true)]
		public bool FSNormalize { get; set; }

		// Token: 0x06000C10 RID: 3088 RVA: 0x0001E069 File Offset: 0x0001C269
		protected override void RenderInnerAndTransform(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, int orgLength)
		{
			base.Inner.RenderAppendBuilder(logEvent, builder, false);
			if (this.FSNormalize && builder.Length > orgLength)
			{
				global::NLog.LayoutRenderers.Wrappers.FileSystemNormalizeLayoutRendererWrapper.TransformFileSystemNormalize(builder, orgLength);
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0001E091 File Offset: 0x0001C291
		protected override void TransformFormattedMesssage(global::System.Text.StringBuilder target)
		{
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0001E094 File Offset: 0x0001C294
		private static void TransformFileSystemNormalize(global::System.Text.StringBuilder builder, int startPos)
		{
			for (int i = startPos; i < builder.Length; i++)
			{
				if (!global::NLog.LayoutRenderers.Wrappers.FileSystemNormalizeLayoutRendererWrapper.IsSafeCharacter(builder[i]))
				{
					builder[i] = '_';
				}
			}
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0001E0C9 File Offset: 0x0001C2C9
		private static bool IsSafeCharacter(char c)
		{
			return char.IsLetterOrDigit(c) || c == '_' || c == '-' || c == '.' || c == ' ';
		}
	}
}
