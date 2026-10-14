using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.Model;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200009A RID: 154
	public class XSSFRichTextString : global::NPOI.SS.UserModel.IRichTextString
	{
		// Token: 0x0600080C RID: 2060 RVA: 0x0001AF90 File Offset: 0x00019190
		public XSSFRichTextString(string str)
		{
			this.st = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst();
			this.st.t = str;
			global::NPOI.XSSF.UserModel.XSSFRichTextString.PreserveSpaces(this.st.t);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0001AFC0 File Offset: 0x000191C0
		public void SetStylesTableReference(global::NPOI.XSSF.Model.StylesTable stylestable)
		{
			this.styles = stylestable;
			if (this.st.sizeOfRArray() > 0)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt ct_RElt in this.st.r)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt rPr = ct_RElt.rPr;
					if (rPr != null && rPr.SizeOfRFontArray() > 0)
					{
						string val = rPr.GetRFontArray(0).val;
						if (val.StartsWith("#"))
						{
							int idx = int.Parse(val.Substring(1));
							global::NPOI.XSSF.UserModel.XSSFFont fontAt = this.styles.GetFontAt(idx);
							rPr.rFont = null;
							this.SetRunAttributes(fontAt.GetCTFont(), rPr);
						}
					}
				}
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0001B084 File Offset: 0x00019284
		public XSSFRichTextString()
		{
			this.st = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst();
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0001B097 File Offset: 0x00019297
		public XSSFRichTextString(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst st)
		{
			this.st = st;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0001B0A8 File Offset: 0x000192A8
		public void ApplyFont(int startIndex, int endIndex, short fontIndex)
		{
			global::NPOI.XSSF.UserModel.XSSFFont xssffont;
			if (this.styles == null)
			{
				xssffont = new global::NPOI.XSSF.UserModel.XSSFFont();
				xssffont.FontName = "#" + fontIndex.ToString();
			}
			else
			{
				xssffont = this.styles.GetFontAt((int)fontIndex);
			}
			this.ApplyFont(startIndex, endIndex, xssffont);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0001B0F4 File Offset: 0x000192F4
		internal void ApplyFont(global::System.Collections.Generic.SortedDictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt> formats, int startIndex, int endIndex, global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt fmt)
		{
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			foreach (int num in formats.Keys)
			{
				if (num >= startIndex && num < endIndex)
				{
					list.Add(num);
				}
			}
			foreach (int key in list)
			{
				formats.Remove(key);
			}
			if (startIndex > 0 && !formats.ContainsKey(startIndex))
			{
				foreach (global::System.Collections.Generic.KeyValuePair<int, global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt> keyValuePair in formats)
				{
					if (keyValuePair.Key > startIndex)
					{
						formats[startIndex] = keyValuePair.Value;
						break;
					}
				}
			}
			formats[endIndex] = fmt;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0001B1E4 File Offset: 0x000193E4
		public void ApplyFont(int startIndex, int endIndex, global::NPOI.SS.UserModel.IFont font)
		{
			if (startIndex > endIndex)
			{
				throw new global::System.ArgumentException("Start index must be less than end index, but had " + startIndex.ToString() + " and " + endIndex.ToString());
			}
			if (startIndex < 0 || endIndex > this.Length)
			{
				throw new global::System.ArgumentException("Start and end index not in range, but had " + startIndex.ToString() + " and " + endIndex.ToString());
			}
			if (startIndex == endIndex)
			{
				return;
			}
			if (this.st.sizeOfRArray() == 0 && this.st.IsSetT())
			{
				this.st.AddNewR().t = this.st.t;
				this.st.unsetT();
			}
			string @string = this.String;
			global::NPOI.XSSF.UserModel.XSSFFont xssffont = (global::NPOI.XSSF.UserModel.XSSFFont)font;
			global::System.Collections.Generic.SortedDictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt> formatMap = this.GetFormatMap(this.st);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt ct_RPrElt = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt();
			this.SetRunAttributes(xssffont.GetCTFont(), ct_RPrElt);
			this.ApplyFont(formatMap, startIndex, endIndex, ct_RPrElt);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst o = this.BuildCTRst(@string, formatMap);
			this.st.Set(o);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0001B2DC File Offset: 0x000194DC
		internal global::System.Collections.Generic.SortedDictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt> GetFormatMap(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst entry)
		{
			int num = 0;
			global::System.Collections.Generic.SortedDictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt> sortedDictionary = new global::System.Collections.Generic.SortedDictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt>();
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt ct_RElt in entry.r)
			{
				string t = ct_RElt.t;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt rPr = ct_RElt.rPr;
				num += t.Length;
				sortedDictionary[num] = rPr;
			}
			return sortedDictionary;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0001B350 File Offset: 0x00019550
		public void ApplyFont(global::NPOI.SS.UserModel.IFont font)
		{
			string @string = this.String;
			this.ApplyFont(0, @string.Length, font);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0001B374 File Offset: 0x00019574
		public void ApplyFont(short fontIndex)
		{
			global::NPOI.XSSF.UserModel.XSSFFont xssffont;
			if (this.styles == null)
			{
				xssffont = new global::NPOI.XSSF.UserModel.XSSFFont();
				xssffont.FontName = "#" + fontIndex.ToString();
			}
			else
			{
				xssffont = this.styles.GetFontAt((int)fontIndex);
			}
			string @string = this.String;
			this.ApplyFont(0, @string.Length, xssffont);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0001B3CC File Offset: 0x000195CC
		public void Append(string text, global::NPOI.XSSF.UserModel.XSSFFont font)
		{
			if (this.st.sizeOfRArray() == 0 && this.st.IsSetT())
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt ct_RElt = this.st.AddNewR();
				ct_RElt.t = this.st.t;
				global::NPOI.XSSF.UserModel.XSSFRichTextString.PreserveSpaces(ct_RElt.t);
				this.st.unsetT();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt ct_RElt2 = this.st.AddNewR();
			ct_RElt2.t = text;
			global::NPOI.XSSF.UserModel.XSSFRichTextString.PreserveSpaces(ct_RElt2.t);
			if (font != null)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt pr = ct_RElt2.AddNewRPr();
				this.SetRunAttributes(font.GetCTFont(), pr);
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0001B459 File Offset: 0x00019659
		public void Append(string text)
		{
			this.Append(text, null);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0001B464 File Offset: 0x00019664
		private void SetRunAttributes(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font ctFont, global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt pr)
		{
			if (ctFont.SizeOfBArray() > 0)
			{
				pr.AddNewB().val = ctFont.GetBArray(0).val;
			}
			if (ctFont.sizeOfUArray() > 0)
			{
				pr.AddNewU().val = ctFont.GetUArray(0).val;
			}
			if (ctFont.sizeOfIArray() > 0)
			{
				pr.AddNewI().val = ctFont.GetIArray(0).val;
			}
			if (ctFont.sizeOfColorArray() > 0)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color colorArray = ctFont.GetColorArray(0);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color = pr.AddNewColor();
				if (colorArray.IsSetAuto())
				{
					ct_Color.auto = colorArray.auto;
					ct_Color.autoSpecified = true;
				}
				if (colorArray.IsSetIndexed())
				{
					ct_Color.indexed = colorArray.indexed;
					ct_Color.indexedSpecified = true;
				}
				if (colorArray.IsSetRgb())
				{
					ct_Color.SetRgb(colorArray.rgb);
					ct_Color.rgbSpecified = true;
				}
				if (colorArray.IsSetTheme())
				{
					ct_Color.theme = colorArray.theme;
					ct_Color.themeSpecified = true;
				}
				if (colorArray.IsSetTint())
				{
					ct_Color.tint = colorArray.tint;
					ct_Color.tintSpecified = true;
				}
			}
			if (ctFont.sizeOfSzArray() > 0)
			{
				pr.AddNewSz().val = ctFont.GetSzArray(0).val;
			}
			if (ctFont.sizeOfNameArray() > 0)
			{
				pr.AddNewRFont().val = ctFont.name.val;
			}
			if (ctFont.sizeOfFamilyArray() > 0)
			{
				pr.AddNewFamily().val = ctFont.GetFamilyArray(0).val;
			}
			if (ctFont.sizeOfSchemeArray() > 0)
			{
				pr.AddNewScheme().val = ctFont.GetSchemeArray(0).val;
			}
			if (ctFont.sizeOfCharsetArray() > 0)
			{
				pr.AddNewCharset().val = ctFont.GetCharsetArray(0).val;
			}
			if (ctFont.sizeOfCondenseArray() > 0)
			{
				pr.AddNewCondense().val = ctFont.GetCondenseArray(0).val;
			}
			if (ctFont.sizeOfExtendArray() > 0)
			{
				pr.AddNewExtend().val = ctFont.GetExtendArray(0).val;
			}
			if (ctFont.sizeOfVertAlignArray() > 0)
			{
				pr.AddNewVertAlign().val = ctFont.GetVertAlignArray(0).val;
			}
			if (ctFont.sizeOfOutlineArray() > 0)
			{
				pr.AddNewOutline().val = ctFont.GetOutlineArray(0).val;
			}
			if (ctFont.sizeOfShadowArray() > 0)
			{
				pr.AddNewShadow().val = ctFont.GetShadowArray(0).val;
			}
			if (ctFont.sizeOfStrikeArray() > 0)
			{
				pr.AddNewStrike().val = ctFont.GetStrikeArray(0).val;
			}
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0001B6D4 File Offset: 0x000198D4
		public bool HasFormatting()
		{
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt> r = this.st.r;
			if (r == null || r.Count == 0)
			{
				return false;
			}
			using (global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt>.Enumerator enumerator = r.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.isSetRPr())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0001B744 File Offset: 0x00019944
		public void ClearFormatting()
		{
			string @string = this.String;
			this.st.r = null;
			this.st.t = @string;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0001B770 File Offset: 0x00019970
		public int GetIndexOfFormattingRun(int index)
		{
			if (this.st.sizeOfRArray() == 0)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < this.st.sizeOfRArray(); i++)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt rarray = this.st.GetRArray(i);
				if (i == index)
				{
					return num;
				}
				num += rarray.t.Length;
			}
			return -1;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0001B7C6 File Offset: 0x000199C6
		public int GetLengthOfFormattingRun(int index)
		{
			if (this.st.sizeOfRArray() == 0 || index >= this.st.sizeOfRArray())
			{
				return -1;
			}
			return this.st.GetRArray(index).t.Length;
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x0001B7FC File Offset: 0x000199FC
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x0001B88C File Offset: 0x00019A8C
		public string String
		{
			get
			{
				if (this.st.sizeOfRArray() == 0)
				{
					return global::NPOI.XSSF.UserModel.XSSFRichTextString.UtfDecode(this.st.t);
				}
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt ct_RElt in this.st.r)
				{
					stringBuilder.Append(ct_RElt.t);
				}
				return global::NPOI.XSSF.UserModel.XSSFRichTextString.UtfDecode(stringBuilder.ToString());
			}
			set
			{
				this.ClearFormatting();
				this.st.t = value;
				global::NPOI.XSSF.UserModel.XSSFRichTextString.PreserveSpaces(this.st.t);
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0001B8B0 File Offset: 0x00019AB0
		public override string ToString()
		{
			return this.String;
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0001B8B8 File Offset: 0x00019AB8
		public int Length
		{
			get
			{
				return this.String.Length;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0001B8C5 File Offset: 0x00019AC5
		public int NumFormattingRuns
		{
			get
			{
				return this.st.sizeOfRArray();
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0001B8D4 File Offset: 0x00019AD4
		public global::NPOI.SS.UserModel.IFont GetFontOfFormattingRun(int index)
		{
			if (this.st.sizeOfRArray() == 0 || index >= this.st.sizeOfRArray())
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt rarray = this.st.GetRArray(index);
			if (rarray.rPr != null)
			{
				global::NPOI.XSSF.UserModel.XSSFFont xssffont = new global::NPOI.XSSF.UserModel.XSSFFont(global::NPOI.XSSF.UserModel.XSSFRichTextString.ToCTFont(rarray.rPr));
				xssffont.SetThemesTable(this.GetThemesTable());
				return xssffont;
			}
			return null;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0001B934 File Offset: 0x00019B34
		public global::NPOI.XSSF.UserModel.XSSFFont GetFontAtIndex(int index)
		{
			global::NPOI.XSSF.Model.ThemesTable themesTable = this.GetThemesTable();
			int num = 0;
			if (this.st.r == null)
			{
				return null;
			}
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt ct_RElt in this.st.r)
			{
				int length = ct_RElt.t.Length;
				if (index >= num && index < num + length)
				{
					global::NPOI.XSSF.UserModel.XSSFFont xssffont = new global::NPOI.XSSF.UserModel.XSSFFont(global::NPOI.XSSF.UserModel.XSSFRichTextString.ToCTFont(ct_RElt.rPr));
					xssffont.SetThemesTable(themesTable);
					return xssffont;
				}
				num += length;
			}
			return null;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0001B9DC File Offset: 0x00019BDC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst GetCTRst()
		{
			return this.st;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0001B9E4 File Offset: 0x00019BE4
		protected static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font ToCTFont(global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt pr)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font ct_Font = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font();
			if (pr == null)
			{
				return ct_Font;
			}
			if (pr.SizeOfBArray() > 0)
			{
				ct_Font.AddNewB().val = pr.GetBArray(0).val;
			}
			if (pr.SizeOfUArray() > 0)
			{
				ct_Font.AddNewU().val = pr.GetUArray(0).val;
			}
			if (pr.SizeOfIArray() > 0)
			{
				ct_Font.AddNewI().val = pr.GetIArray(0).val;
			}
			if (pr.SizeOfColorArray() > 0)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color colorArray = pr.GetColorArray(0);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color = ct_Font.AddNewColor();
				if (colorArray.IsSetAuto())
				{
					ct_Color.auto = colorArray.auto;
					ct_Color.autoSpecified = true;
				}
				if (colorArray.IsSetIndexed())
				{
					ct_Color.indexed = colorArray.indexed;
					ct_Color.indexedSpecified = true;
				}
				if (colorArray.IsSetRgb())
				{
					ct_Color.SetRgb(colorArray.GetRgb());
					ct_Color.rgbSpecified = true;
				}
				if (colorArray.IsSetTheme())
				{
					ct_Color.theme = colorArray.theme;
					ct_Color.themeSpecified = true;
				}
				if (colorArray.IsSetTint())
				{
					ct_Color.tint = colorArray.tint;
					ct_Color.tintSpecified = true;
				}
			}
			if (pr.SizeOfSzArray() > 0)
			{
				ct_Font.AddNewSz().val = pr.GetSzArray(0).val;
			}
			if (pr.SizeOfRFontArray() > 0)
			{
				ct_Font.AddNewName().val = pr.GetRFontArray(0).val;
			}
			if (pr.SizeOfFamilyArray() > 0)
			{
				ct_Font.AddNewFamily().val = pr.GetFamilyArray(0).val;
			}
			if (pr.sizeOfSchemeArray() > 0)
			{
				ct_Font.AddNewScheme().val = pr.GetSchemeArray(0).val;
			}
			if (pr.sizeOfCharsetArray() > 0)
			{
				ct_Font.AddNewCharset().val = pr.GetCharsetArray(0).val;
			}
			if (pr.sizeOfCondenseArray() > 0)
			{
				ct_Font.AddNewCondense().val = pr.GetCondenseArray(0).val;
			}
			if (pr.sizeOfExtendArray() > 0)
			{
				ct_Font.AddNewExtend().val = pr.GetExtendArray(0).val;
			}
			if (pr.sizeOfVertAlignArray() > 0)
			{
				ct_Font.AddNewVertAlign().val = pr.GetVertAlignArray(0).val;
			}
			if (pr.sizeOfOutlineArray() > 0)
			{
				ct_Font.AddNewOutline().val = pr.GetOutlineArray(0).val;
			}
			if (pr.sizeOfShadowArray() > 0)
			{
				ct_Font.AddNewShadow().val = pr.GetShadowArray(0).val;
			}
			if (pr.sizeOfStrikeArray() > 0)
			{
				ct_Font.AddNewStrike().val = pr.GetStrikeArray(0).val;
			}
			return ct_Font;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0001BC60 File Offset: 0x00019E60
		protected static void PreserveSpaces(string xs)
		{
			if (xs != null && xs.Length > 0)
			{
				char c = xs[0];
				char c2 = xs[xs.Length - 1];
				if (!char.IsWhiteSpace(c))
				{
					char.IsWhiteSpace(c2);
				}
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0001BCA0 File Offset: 0x00019EA0
		private static string UtfDecode(string value)
		{
			if (value == null)
			{
				return null;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Text.RegularExpressions.MatchCollection matchCollection = global::NPOI.XSSF.UserModel.XSSFRichTextString.utfPtrn.Matches(value);
			int num = 0;
			for (int i = 0; i < matchCollection.Count; i++)
			{
				int index = matchCollection[i].Index;
				if (index > num)
				{
					stringBuilder.Append(value.Substring(num, index - num));
				}
				int num2 = int.Parse(matchCollection[i].Groups[1].Value, global::System.Globalization.NumberStyles.AllowHexSpecifier);
				stringBuilder.Append((char)num2);
				num = matchCollection[i].Index + matchCollection[i].Length;
			}
			if (num == 0)
			{
				return value;
			}
			stringBuilder.Append(value.Substring(num));
			return stringBuilder.ToString();
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0001BD5C File Offset: 0x00019F5C
		public int GetLastKey(global::System.Collections.Generic.SortedDictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt>.KeyCollection keys)
		{
			int num = 0;
			foreach (int result in keys)
			{
				if (num == keys.Count - 1)
				{
					return result;
				}
				num++;
			}
			throw new global::System.ArgumentOutOfRangeException("GetLastKey failed");
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0001BDC4 File Offset: 0x00019FC4
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst BuildCTRst(string text, global::System.Collections.Generic.SortedDictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt> formats)
		{
			if (text.Length != this.GetLastKey(formats.Keys))
			{
				throw new global::System.ArgumentException("Text length was " + text.Length.ToString() + " but the last format index was " + this.GetLastKey(formats.Keys).ToString());
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst ct_Rst = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst();
			int num = 0;
			foreach (global::System.Collections.Generic.KeyValuePair<int, global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt> keyValuePair in formats)
			{
				int key = keyValuePair.Key;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_RElt ct_RElt = ct_Rst.AddNewR();
				string t = text.Substring(num, key - num);
				ct_RElt.t = t;
				global::NPOI.XSSF.UserModel.XSSFRichTextString.PreserveSpaces(ct_RElt.t);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_RPrElt value = keyValuePair.Value;
				if (value != null)
				{
					ct_RElt.rPr = value;
				}
				num = key;
			}
			return ct_Rst;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0001BEAC File Offset: 0x0001A0AC
		private global::NPOI.XSSF.Model.ThemesTable GetThemesTable()
		{
			if (this.styles == null)
			{
				return null;
			}
			return this.styles.GetTheme();
		}

		// Token: 0x0400033D RID: 829
		private static global::System.Text.RegularExpressions.Regex utfPtrn = new global::System.Text.RegularExpressions.Regex("_x([0-9A-F]{4})_", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x0400033E RID: 830
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst st;

		// Token: 0x0400033F RID: 831
		private global::NPOI.XSSF.Model.StylesTable styles;
	}
}
