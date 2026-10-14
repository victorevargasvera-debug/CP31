using System;
using System.Collections;
using System.Globalization;
using NPOI.Util.Collections;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000365 RID: 869
	public class FontDetails
	{
		// Token: 0x06001A3C RID: 6716 RVA: 0x00050D15 File Offset: 0x0004EF15
		public FontDetails(string fontName, int height)
		{
			this.fontName = fontName;
			this.height = height;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00050D36 File Offset: 0x0004EF36
		public string GetFontName()
		{
			return this.fontName;
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00050D3E File Offset: 0x0004EF3E
		public int GetHeight()
		{
			return this.height;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00050D46 File Offset: 0x0004EF46
		public void AddChar(char c, int width)
		{
			this.charWidths[c] = width;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x00050D60 File Offset: 0x0004EF60
		public int GetCharWidth(char c)
		{
			object obj = this.charWidths[c];
			if (obj != null)
			{
				return (int)obj;
			}
			if ('W' != c)
			{
				return this.GetCharWidth('W');
			}
			return 0;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00050D98 File Offset: 0x0004EF98
		public void AddChars(char[] Chars, int[] widths)
		{
			for (int i = 0; i < Chars.Length; i++)
			{
				if (Chars[i] != ' ')
				{
					this.charWidths[Chars[i]] = widths[i];
				}
			}
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00050DD5 File Offset: 0x0004EFD5
		public static string BuildFontHeightProperty(string fontName)
		{
			return "font." + fontName + ".height";
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00050DE7 File Offset: 0x0004EFE7
		public static string BuildFontWidthsProperty(string fontName)
		{
			return "font." + fontName + ".widths";
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00050DF9 File Offset: 0x0004EFF9
		public static string BuildFontCharsProperty(string fontName)
		{
			return "font." + fontName + ".characters";
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00050E0C File Offset: 0x0004F00C
		public static global::NPOI.HSSF.UserModel.FontDetails Create(string fontName, global::NPOI.Util.Collections.Properties fontMetricsProps)
		{
			string text = fontMetricsProps[global::NPOI.HSSF.UserModel.FontDetails.BuildFontHeightProperty(fontName)];
			string text2 = fontMetricsProps[global::NPOI.HSSF.UserModel.FontDetails.BuildFontWidthsProperty(fontName)];
			string text3 = fontMetricsProps[global::NPOI.HSSF.UserModel.FontDetails.BuildFontCharsProperty(fontName)];
			if (text == null || text2 == null || text3 == null)
			{
				throw new global::System.ArgumentException("The supplied FontMetrics doesn't know about the font '" + fontName + "', so we can't use it. Please Add it to your font metrics file (see StaticFontMetrics.GetFontDetails");
			}
			int num = int.Parse(text, global::System.Globalization.CultureInfo.InvariantCulture);
			global::NPOI.HSSF.UserModel.FontDetails fontDetails = new global::NPOI.HSSF.UserModel.FontDetails(fontName, num);
			string[] array = global::NPOI.HSSF.UserModel.FontDetails.Split(text3, ",", -1);
			string[] array2 = global::NPOI.HSSF.UserModel.FontDetails.Split(text2, ",", -1);
			if (array.Length != array2.Length)
			{
				throw new global::System.Exception("Number of Chars does not number of widths for font " + fontName);
			}
			for (int i = 0; i < array2.Length; i++)
			{
				if (array[i].Trim().Length != 0)
				{
					fontDetails.AddChar(array[i].Trim()[0], int.Parse(array2[i], global::System.Globalization.CultureInfo.InvariantCulture));
				}
			}
			return fontDetails;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00050EF4 File Offset: 0x0004F0F4
		public int GetStringWidth(string str)
		{
			int num = 0;
			for (int i = 0; i < str.Length; i++)
			{
				num += this.GetCharWidth(str[i]);
			}
			return num;
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00050F25 File Offset: 0x0004F125
		private static string[] Split(string text, string separator, int max)
		{
			return text.Split(separator.ToCharArray());
		}

		// Token: 0x04000B16 RID: 2838
		private string fontName;

		// Token: 0x04000B17 RID: 2839
		private int height;

		// Token: 0x04000B18 RID: 2840
		private global::System.Collections.Hashtable charWidths = new global::System.Collections.Hashtable();
	}
}
