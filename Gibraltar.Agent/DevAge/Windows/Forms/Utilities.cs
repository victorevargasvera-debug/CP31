using System;
using System.Windows.Forms;
using DevAge.Drawing;

namespace DevAge.Windows.Forms
{
	// Token: 0x02000331 RID: 817
	internal class Utilities
	{
		// Token: 0x06002671 RID: 9841 RVA: 0x00085284 File Offset: 0x00083484
		public static global::System.Windows.Forms.HorizontalAlignment ContentToHorizontalAlignment(global::DevAge.Drawing.ContentAlignment a)
		{
			if (global::DevAge.Drawing.Utilities.IsLeft(a))
			{
				return global::System.Windows.Forms.HorizontalAlignment.Left;
			}
			if (global::DevAge.Drawing.Utilities.IsRight(a))
			{
				return global::System.Windows.Forms.HorizontalAlignment.Right;
			}
			return global::System.Windows.Forms.HorizontalAlignment.Center;
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000852A4 File Offset: 0x000834A4
		public static global::System.Windows.Forms.TextFormatFlags ContentAligmentToTextFormatFlags(global::DevAge.Drawing.ContentAlignment a)
		{
			global::System.Windows.Forms.TextFormatFlags textFormatFlags = global::System.Windows.Forms.TextFormatFlags.Default;
			if (global::DevAge.Drawing.Utilities.IsBottom(a))
			{
				textFormatFlags |= global::System.Windows.Forms.TextFormatFlags.Bottom;
			}
			else if (global::DevAge.Drawing.Utilities.IsTop(a))
			{
				textFormatFlags = textFormatFlags;
			}
			else
			{
				textFormatFlags |= global::System.Windows.Forms.TextFormatFlags.VerticalCenter;
			}
			if (global::DevAge.Drawing.Utilities.IsLeft(a))
			{
				textFormatFlags = textFormatFlags;
			}
			else if (global::DevAge.Drawing.Utilities.IsRight(a))
			{
				textFormatFlags |= global::System.Windows.Forms.TextFormatFlags.Right;
			}
			else
			{
				textFormatFlags |= global::System.Windows.Forms.TextFormatFlags.HorizontalCenter;
			}
			return textFormatFlags;
		}
	}
}
