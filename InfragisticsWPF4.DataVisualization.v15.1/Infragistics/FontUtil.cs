using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics
{
	// Token: 0x0200009B RID: 155
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public static class FontUtil
	{
		// Token: 0x060006C9 RID: 1737 RVA: 0x0001E5E8 File Offset: 0x0001C7E8
		public static global::Infragistics.FontInfo GetFontInfo(global::System.Windows.FrameworkElement fe, object fontDescriptor)
		{
			global::Infragistics.FontInfo fontInfo = new global::Infragistics.FontInfo();
			global::System.Windows.Controls.TextBlock textBlock = fe as global::System.Windows.Controls.TextBlock;
			if (textBlock != null)
			{
				fontInfo.FontFamily = textBlock.FontFamily.Source;
				fontInfo.FontSize = textBlock.FontSize;
				fontInfo.FontStyle = textBlock.FontStyle.ToString();
				fontInfo.FontStretch = textBlock.FontStretch.ToString();
				fontInfo.LineHeight = textBlock.LineHeight;
				fontInfo.FontWeight = textBlock.FontWeight.ToString();
			}
			return fontInfo;
		}
	}
}
