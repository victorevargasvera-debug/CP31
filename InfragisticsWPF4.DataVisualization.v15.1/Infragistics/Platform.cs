using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000A5 RID: 165
	public static class Platform
	{
		// Token: 0x0600073E RID: 1854 RVA: 0x00022BE8 File Offset: 0x00020DE8
		public static global::System.Windows.Size GetStringBounds(string text, double angle, global::System.Windows.Media.FontFamily fontFamily, double fontSize, global::System.Windows.FontStretch fontStretch, global::System.Windows.FontStyle fontStyle, global::System.Windows.FontWeight fontWeight)
		{
			global::System.Windows.Size stringSizePixels = global::Infragistics.Platform.GetStringSizePixels(text, fontFamily, fontSize, fontStretch, fontStyle, fontWeight);
			double num = global::Infragistics.MathUtil.Radians(angle);
			double width = global::System.Math.Abs(stringSizePixels.Width * global::System.Math.Cos(num) + stringSizePixels.Height * global::System.Math.Sin(num));
			double height = global::System.Math.Abs(stringSizePixels.Width * global::System.Math.Sin(num) + stringSizePixels.Height * global::System.Math.Cos(num));
			return new global::System.Windows.Size(width, height);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00022C58 File Offset: 0x00020E58
		public static global::System.Windows.Size GetStringSizePixels(string text, global::System.Windows.Media.FontFamily fontFamily, double fontSize, global::System.Windows.FontStretch fontStretch, global::System.Windows.FontStyle fontStyle, global::System.Windows.FontWeight fontWeight)
		{
			global::System.Windows.Controls.TextBlock textBlock = new global::System.Windows.Controls.TextBlock();
			textBlock.Text = text;
			textBlock.FontFamily = fontFamily;
			textBlock.FontSize = fontSize;
			textBlock.FontStretch = fontStretch;
			textBlock.FontStyle = fontStyle;
			textBlock.FontWeight = fontWeight;
			return new global::System.Windows.Size(textBlock.ActualWidth, textBlock.ActualHeight);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00022CA8 File Offset: 0x00020EA8
		public static int GetBestFitStringSize(string text, double width, global::System.Windows.Media.FontFamily fontFamily, double fontSize, global::System.Windows.FontStretch fontStretch, global::System.Windows.FontStyle fontStyle, global::System.Windows.FontWeight fontWeight)
		{
			int num = 0;
			double num2 = 0.0;
			foreach (char c in text.ToCharArray())
			{
				num2 += global::Infragistics.Platform.GetStringSizePixels(c.ToString(), fontFamily, fontSize, fontStretch, fontStyle, fontWeight).Width;
				if (num2 > width)
				{
					return num;
				}
				num++;
			}
			return num;
		}
	}
}
