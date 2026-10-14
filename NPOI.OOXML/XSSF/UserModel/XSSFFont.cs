using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.Model;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000086 RID: 134
	public class XSSFFont : global::NPOI.SS.UserModel.IFont
	{
		// Token: 0x060006CE RID: 1742 RVA: 0x00017661 File Offset: 0x00015861
		public XSSFFont(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font font)
		{
			this._ctFont = font;
			this._index = 0;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00017677 File Offset: 0x00015877
		public XSSFFont(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font font, int index)
		{
			this._ctFont = font;
			this._index = (short)index;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001768E File Offset: 0x0001588E
		public XSSFFont()
		{
			this._ctFont = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font();
			this.FontName = "Calibri";
			this.FontHeightInPoints = 11.0;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000176BB File Offset: 0x000158BB
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font GetCTFont()
		{
			return this._ctFont;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x000176C4 File Offset: 0x000158C4
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x000176F9 File Offset: 0x000158F9
		public bool IsBold
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty = (this._ctFont.SizeOfBArray() == 0) ? null : this._ctFont.GetBArray(0);
				return ct_BooleanProperty != null && ct_BooleanProperty.val;
			}
			set
			{
				if (value)
				{
					((this._ctFont.SizeOfBArray() == 0) ? this._ctFont.AddNewB() : this._ctFont.GetBArray(0)).val = value;
					return;
				}
				this._ctFont.SetBArray(null);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00017738 File Offset: 0x00015938
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x000029BF File Offset: 0x00000BBF
		public short Charset
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty ct_IntProperty = (this._ctFont.sizeOfCharsetArray() == 0) ? null : this._ctFont.GetCharsetArray(0);
				return (short)((ct_IntProperty == null) ? global::NPOI.SS.UserModel.FontCharset.ANSI.Value : global::NPOI.SS.UserModel.FontCharset.ValueOf(ct_IntProperty.val).Value);
			}
			set
			{
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00017784 File Offset: 0x00015984
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x000177F4 File Offset: 0x000159F4
		public short Color
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color = (this._ctFont.sizeOfColorArray() == 0) ? null : this._ctFont.GetColorArray(0);
				if (ct_Color == null)
				{
					return global::NPOI.SS.UserModel.IndexedColors.Black.Index;
				}
				long num = (long)((ulong)ct_Color.indexed);
				if (num == (long)global::NPOI.XSSF.UserModel.XSSFFont.DEFAULT_FONT_COLOR)
				{
					return global::NPOI.SS.UserModel.IndexedColors.Black.Index;
				}
				if (num == (long)global::NPOI.SS.UserModel.IndexedColors.Red.Index)
				{
					return global::NPOI.SS.UserModel.IndexedColors.Red.Index;
				}
				return (short)num;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color = (this._ctFont.sizeOfColorArray() == 0) ? this._ctFont.AddNewColor() : this._ctFont.GetColorArray(0);
				if (value == 10)
				{
					ct_Color.indexed = (uint)global::NPOI.SS.UserModel.IndexedColors.Red.Index;
					ct_Color.indexedSpecified = true;
					return;
				}
				if (value == 32767)
				{
					ct_Color.indexed = (uint)global::NPOI.XSSF.UserModel.XSSFFont.DEFAULT_FONT_COLOR;
					ct_Color.indexedSpecified = true;
					return;
				}
				ct_Color.indexed = (uint)value;
				ct_Color.indexedSpecified = true;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00017870 File Offset: 0x00015A70
		public global::NPOI.XSSF.UserModel.XSSFColor GetXSSFColor()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color = (this._ctFont.sizeOfColorArray() == 0) ? null : this._ctFont.GetColorArray(0);
			if (ct_Color != null)
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = new global::NPOI.XSSF.UserModel.XSSFColor(ct_Color);
				if (this._themes != null)
				{
					this._themes.InheritFromThemeAsRequired(xssfcolor);
				}
				return xssfcolor;
			}
			return null;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000178BC File Offset: 0x00015ABC
		public short GetThemeColor()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color = (this._ctFont.sizeOfColorArray() == 0) ? null : this._ctFont.GetColorArray(0);
			return (short)((ulong)((ct_Color == null || !ct_Color.themeSpecified) ? 0U : ct_Color.theme));
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x000178FC File Offset: 0x00015AFC
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x0001790E File Offset: 0x00015B0E
		public double FontHeight
		{
			get
			{
				return this.FontHeightRaw * 20.0;
			}
			set
			{
				this.FontHeightRaw = value / 20.0;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00017921 File Offset: 0x00015B21
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00017929 File Offset: 0x00015B29
		public double FontHeightInPoints
		{
			get
			{
				return this.FontHeightRaw;
			}
			set
			{
				this.FontHeightRaw = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00017934 File Offset: 0x00015B34
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00017971 File Offset: 0x00015B71
		private double FontHeightRaw
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize ct_FontSize = (this._ctFont.sizeOfSzArray() == 0) ? null : this._ctFont.GetSzArray(0);
				if (ct_FontSize != null)
				{
					return ct_FontSize.val;
				}
				return 11.0;
			}
			set
			{
				((this._ctFont.sizeOfSzArray() == 0) ? this._ctFont.AddNewSz() : this._ctFont.GetSzArray(0)).val = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x000179A0 File Offset: 0x00015BA0
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x000179C8 File Offset: 0x00015BC8
		public string FontName
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontName name = this._ctFont.name;
				if (name != null)
				{
					return name.val;
				}
				return "Calibri";
			}
			set
			{
				((this._ctFont.name == null) ? this._ctFont.AddNewName() : this._ctFont.name).val = ((value == null) ? "Calibri" : value);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00017A00 File Offset: 0x00015C00
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00017A35 File Offset: 0x00015C35
		public bool IsItalic
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty = (this._ctFont.sizeOfIArray() == 0) ? null : this._ctFont.GetIArray(0);
				return ct_BooleanProperty != null && ct_BooleanProperty.val;
			}
			set
			{
				if (value)
				{
					((this._ctFont.sizeOfIArray() == 0) ? this._ctFont.AddNewI() : this._ctFont.GetIArray(0)).val = value;
					return;
				}
				this._ctFont.SetIArray(null);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00017A74 File Offset: 0x00015C74
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x00017AA9 File Offset: 0x00015CA9
		public bool IsStrikeout
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BooleanProperty ct_BooleanProperty = (this._ctFont.sizeOfStrikeArray() == 0) ? null : this._ctFont.GetStrikeArray(0);
				return ct_BooleanProperty != null && ct_BooleanProperty.val;
			}
			set
			{
				if (!value)
				{
					this._ctFont.SetStrikeArray(null);
					return;
				}
				((this._ctFont.sizeOfStrikeArray() == 0) ? this._ctFont.AddNewStrike() : this._ctFont.GetStrikeArray(0)).val = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00017AE8 File Offset: 0x00015CE8
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00017B54 File Offset: 0x00015D54
		public global::NPOI.SS.UserModel.FontSuperScript TypeOffset
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty ct_VerticalAlignFontProperty = (this._ctFont.sizeOfVertAlignArray() == 0) ? null : this._ctFont.GetVertAlignArray(0);
				if (ct_VerticalAlignFontProperty == null)
				{
					return global::NPOI.SS.UserModel.FontSuperScript.None;
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun val = ct_VerticalAlignFontProperty.val;
				switch (val)
				{
				case global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun.baseline:
					return global::NPOI.SS.UserModel.FontSuperScript.None;
				case global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun.superscript:
					return global::NPOI.SS.UserModel.FontSuperScript.Super;
				case global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun.subscript:
					return global::NPOI.SS.UserModel.FontSuperScript.Sub;
				default:
					throw new global::NPOI.POIXMLException("Wrong offset value " + val.ToString());
				}
			}
			set
			{
				if (value == global::NPOI.SS.UserModel.FontSuperScript.None)
				{
					this._ctFont.SetVertAlignArray(null);
					return;
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_VerticalAlignFontProperty ct_VerticalAlignFontProperty = (this._ctFont.sizeOfVertAlignArray() == 0) ? this._ctFont.AddNewVertAlign() : this._ctFont.GetVertAlignArray(0);
				switch (value)
				{
				case global::NPOI.SS.UserModel.FontSuperScript.None:
					ct_VerticalAlignFontProperty.val = global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun.baseline;
					return;
				case global::NPOI.SS.UserModel.FontSuperScript.Super:
					ct_VerticalAlignFontProperty.val = global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun.superscript;
					return;
				case global::NPOI.SS.UserModel.FontSuperScript.Sub:
					ct_VerticalAlignFontProperty.val = global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun.subscript;
					return;
				default:
					throw new global::System.InvalidOperationException("Invalid type offset: " + value.ToString());
				}
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00017BE0 File Offset: 0x00015DE0
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00017C28 File Offset: 0x00015E28
		public global::NPOI.SS.UserModel.FontUnderlineType Underline
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty ct_UnderlineProperty = (this._ctFont.sizeOfUArray() == 0) ? null : this._ctFont.GetUArray(0);
				if (ct_UnderlineProperty != null)
				{
					return (global::NPOI.SS.UserModel.FontUnderlineType)global::NPOI.SS.UserModel.FontUnderline.ValueOf((int)ct_UnderlineProperty.val).ByteValue;
				}
				return (global::NPOI.SS.UserModel.FontUnderlineType)global::NPOI.SS.UserModel.FontUnderline.NONE.ByteValue;
			}
			set
			{
				this.SetUnderline(value);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00017C31 File Offset: 0x00015E31
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00017C46 File Offset: 0x00015E46
		[global::System.Obsolete("deprecated POI 3.15 beta 2. Use IsBold instead.")]
		public short Boldweight
		{
			get
			{
				if (!this.IsBold)
				{
					return 400;
				}
				return 700;
			}
			set
			{
				this.IsBold = (value == 700);
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00017C58 File Offset: 0x00015E58
		public void SetCharSet(byte charset)
		{
			int charSet = (int)(charset & byte.MaxValue);
			this.SetCharSet(charSet);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00017C74 File Offset: 0x00015E74
		public void SetCharSet(int charset)
		{
			global::NPOI.SS.UserModel.FontCharset fontCharset = global::NPOI.SS.UserModel.FontCharset.ValueOf(charset);
			if (fontCharset != null)
			{
				this.SetCharSet(fontCharset);
				return;
			}
			throw new global::NPOI.POIXMLException("Attention: An attempt was made to set an unknown character set");
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00017CA0 File Offset: 0x00015EA0
		public void SetCharSet(global::NPOI.SS.UserModel.FontCharset charset)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty ct_IntProperty;
			if (this._ctFont.sizeOfCharsetArray() == 0)
			{
				ct_IntProperty = this._ctFont.AddNewCharset();
			}
			else
			{
				ct_IntProperty = this._ctFont.GetCharsetArray(0);
			}
			ct_IntProperty.val = charset.Value;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00017CE4 File Offset: 0x00015EE4
		public void SetColor(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			if (color == null)
			{
				this._ctFont.SetColorArray(null);
				return;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color = (this._ctFont.sizeOfColorArray() == 0) ? this._ctFont.AddNewColor() : this._ctFont.GetColorArray(0);
			if (ct_Color.IsSetIndexed())
			{
				ct_Color.UnsetIndexed();
			}
			ct_Color.SetRgb(color.RGB);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00017D42 File Offset: 0x00015F42
		public void SetThemeColor(short theme)
		{
			((this._ctFont.sizeOfColorArray() == 0) ? this._ctFont.AddNewColor() : this._ctFont.GetColorArray(0)).theme = (uint)theme;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00017D70 File Offset: 0x00015F70
		internal void SetUnderline(global::NPOI.SS.UserModel.FontUnderlineType underline)
		{
			if (underline == global::NPOI.SS.UserModel.FontUnderlineType.None)
			{
				this._ctFont.SetUArray(null);
				return;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_UnderlineProperty ct_UnderlineProperty = (this._ctFont.sizeOfUArray() == 0) ? this._ctFont.AddNewU() : this._ctFont.GetUArray(0);
			global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues value = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues)global::NPOI.SS.UserModel.FontUnderline.ValueOf(underline).Value;
			ct_UnderlineProperty.val = value;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00017DC5 File Offset: 0x00015FC5
		public override string ToString()
		{
			return this._ctFont.ToString();
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00017DD4 File Offset: 0x00015FD4
		public long RegisterTo(global::NPOI.XSSF.Model.StylesTable styles)
		{
			this._themes = styles.GetTheme();
			short num = (short)styles.PutFont(this, true);
			this._index = num;
			return (long)num;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00017E00 File Offset: 0x00016000
		public void SetThemesTable(global::NPOI.XSSF.Model.ThemesTable themes)
		{
			this._themes = themes;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00017E0C File Offset: 0x0001600C
		public global::NPOI.SS.UserModel.FontScheme GetScheme()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme ct_FontScheme = (this._ctFont.sizeOfSchemeArray() == 0) ? null : this._ctFont.GetSchemeArray(0);
			if (ct_FontScheme != null)
			{
				return global::NPOI.SS.UserModel.FontScheme.ValueOf((int)ct_FontScheme.val);
			}
			return global::NPOI.SS.UserModel.FontScheme.NONE;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00017E4C File Offset: 0x0001604C
		public void SetScheme(global::NPOI.SS.UserModel.FontScheme scheme)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontScheme ct_FontScheme = (this._ctFont.sizeOfSchemeArray() == 0) ? this._ctFont.AddNewScheme() : this._ctFont.GetSchemeArray(0);
			global::NPOI.OpenXmlFormats.Spreadsheet.ST_FontScheme value = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_FontScheme)scheme.Value;
			ct_FontScheme.val = value;
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00017E8C File Offset: 0x0001608C
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00017EDE File Offset: 0x000160DE
		public int Family
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_IntProperty ct_IntProperty = (this._ctFont.sizeOfFamilyArray() == 0) ? this._ctFont.AddNewFamily() : this._ctFont.GetFamilyArray(0);
				if (ct_IntProperty != null)
				{
					return global::NPOI.SS.UserModel.FontFamily.ValueOf(ct_IntProperty.val).Value;
				}
				return global::NPOI.SS.UserModel.FontFamily.NOT_APPLICABLE.Value;
			}
			set
			{
				((this._ctFont.sizeOfFamilyArray() == 0) ? this._ctFont.AddNewFamily() : this._ctFont.GetFamilyArray(0)).val = value;
			}
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00017F0C File Offset: 0x0001610C
		public void SetFamily(global::NPOI.SS.UserModel.FontFamily family)
		{
			this.Family = family.Value;
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00017F1A File Offset: 0x0001611A
		public short Index
		{
			get
			{
				return this._index;
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00017F22 File Offset: 0x00016122
		public override int GetHashCode()
		{
			return this._ctFont.ToString().GetHashCode();
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00017F34 File Offset: 0x00016134
		public override bool Equals(object o)
		{
			if (!(o is global::NPOI.XSSF.UserModel.XSSFFont))
			{
				return false;
			}
			global::NPOI.XSSF.UserModel.XSSFFont xssffont = (global::NPOI.XSSF.UserModel.XSSFFont)o;
			return this._ctFont.ToString().Equals(xssffont.GetCTFont().ToString());
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00017F70 File Offset: 0x00016170
		public void CloneStyleFrom(global::NPOI.SS.UserModel.IFont src)
		{
			if (src == null)
			{
				return;
			}
			this.FontName = src.FontName;
			this.FontHeight = src.FontHeight;
			this.IsBold = src.IsBold;
			this.Boldweight = src.Boldweight;
			this.IsItalic = src.IsItalic;
			this.IsStrikeout = src.IsStrikeout;
			this.Color = src.Color;
			this.Underline = src.Underline;
			this.Charset = src.Charset;
			this.TypeOffset = src.TypeOffset;
		}

		// Token: 0x040002DB RID: 731
		public const string DEFAULT_FONT_NAME = "Calibri";

		// Token: 0x040002DC RID: 732
		public const short DEFAULT_FONT_SIZE = 11;

		// Token: 0x040002DD RID: 733
		public static short DEFAULT_FONT_COLOR = global::NPOI.SS.UserModel.IndexedColors.Black.Index;

		// Token: 0x040002DE RID: 734
		private global::NPOI.XSSF.Model.ThemesTable _themes;

		// Token: 0x040002DF RID: 735
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font _ctFont;

		// Token: 0x040002E0 RID: 736
		private short _index;
	}
}
