using System;
using System.ComponentModel;
using NLog.Config;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000E9 RID: 233
	[global::NLog.LayoutRenderers.LayoutRenderer("pad")]
	[global::NLog.LayoutRenderers.AmbientProperty("Padding")]
	[global::NLog.LayoutRenderers.AmbientProperty("PadCharacter")]
	[global::NLog.LayoutRenderers.AmbientProperty("FixedLength")]
	[global::NLog.LayoutRenderers.AmbientProperty("AlignmentOnTruncation")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class PaddingLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBase
	{
		// Token: 0x06000C27 RID: 3111 RVA: 0x0001E278 File Offset: 0x0001C478
		public PaddingLayoutRendererWrapper()
		{
			this.PadCharacter = ' ';
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0001E288 File Offset: 0x0001C488
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x0001E290 File Offset: 0x0001C490
		public int Padding { get; set; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0001E299 File Offset: 0x0001C499
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x0001E2A1 File Offset: 0x0001C4A1
		[global::System.ComponentModel.DefaultValue(' ')]
		public char PadCharacter { get; set; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0001E2AA File Offset: 0x0001C4AA
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x0001E2B2 File Offset: 0x0001C4B2
		[global::System.ComponentModel.DefaultValue(false)]
		public bool FixedLength { get; set; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x0001E2BB File Offset: 0x0001C4BB
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x0001E2C3 File Offset: 0x0001C4C3
		[global::System.ComponentModel.DefaultValue(global::NLog.LayoutRenderers.Wrappers.PaddingHorizontalAlignment.Left)]
		public global::NLog.LayoutRenderers.Wrappers.PaddingHorizontalAlignment AlignmentOnTruncation { get; set; }

		// Token: 0x06000C30 RID: 3120 RVA: 0x0001E2CC File Offset: 0x0001C4CC
		protected override string Transform(string text)
		{
			string text2 = text ?? string.Empty;
			if (this.Padding != 0)
			{
				if (this.Padding > 0)
				{
					text2 = text2.PadLeft(this.Padding, this.PadCharacter);
				}
				else
				{
					text2 = text2.PadRight(-this.Padding, this.PadCharacter);
				}
				int num = this.Padding;
				if (num < 0)
				{
					num = -num;
				}
				if (this.FixedLength && text2.Length > num)
				{
					if (this.AlignmentOnTruncation == global::NLog.LayoutRenderers.Wrappers.PaddingHorizontalAlignment.Right)
					{
						text2 = text2.Substring(text2.Length - num);
					}
					else
					{
						text2 = text2.Substring(0, num);
					}
				}
			}
			return text2;
		}
	}
}
