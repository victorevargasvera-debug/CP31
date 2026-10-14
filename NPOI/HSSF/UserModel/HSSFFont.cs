using System;
using NPOI.HSSF.Record;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000376 RID: 886
	public class HSSFFont : global::NPOI.SS.UserModel.IFont
	{
		// Token: 0x06001BE9 RID: 7145 RVA: 0x000551F4 File Offset: 0x000533F4
		public HSSFFont(short index, global::NPOI.HSSF.Record.FontRecord rec)
		{
			this.font = rec;
			this.index = index;
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x0005520A File Offset: 0x0005340A
		// (set) Token: 0x06001BEB RID: 7147 RVA: 0x00055217 File Offset: 0x00053417
		public string FontName
		{
			get
			{
				return this.font.FontName;
			}
			set
			{
				this.font.FontName = value;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x00055225 File Offset: 0x00053425
		public short Index
		{
			get
			{
				return this.index;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x0005522D File Offset: 0x0005342D
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x0005523B File Offset: 0x0005343B
		public double FontHeight
		{
			get
			{
				return (double)this.font.FontHeight;
			}
			set
			{
				this.font.FontHeight = (short)value;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x0005524A File Offset: 0x0005344A
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x00055262 File Offset: 0x00053462
		public double FontHeightInPoints
		{
			get
			{
				return (double)this.font.FontHeight / 20.0;
			}
			set
			{
				this.font.FontHeight = (short)(value * 20.0);
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x0005527B File Offset: 0x0005347B
		// (set) Token: 0x06001BF2 RID: 7154 RVA: 0x00055288 File Offset: 0x00053488
		public bool IsItalic
		{
			get
			{
				return this.font.IsItalic;
			}
			set
			{
				this.font.IsItalic = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00055296 File Offset: 0x00053496
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x000552A3 File Offset: 0x000534A3
		public bool IsStrikeout
		{
			get
			{
				return this.font.IsStrikeout;
			}
			set
			{
				this.font.IsStrikeout = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x000552B1 File Offset: 0x000534B1
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x000552BE File Offset: 0x000534BE
		public short Color
		{
			get
			{
				return this.font.ColorPaletteIndex;
			}
			set
			{
				this.font.ColorPaletteIndex = value;
			}
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x000552CC File Offset: 0x000534CC
		public global::NPOI.HSSF.Util.HSSFColor GetHSSFColor(global::NPOI.HSSF.UserModel.HSSFWorkbook wb)
		{
			return wb.GetCustomPalette().GetColor(this.Color);
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x000552DF File Offset: 0x000534DF
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x000552EC File Offset: 0x000534EC
		[global::System.Obsolete("deprecated POI 3.15 beta 2. Use IsBold instead.")]
		public short Boldweight
		{
			get
			{
				return this.font.BoldWeight;
			}
			set
			{
				this.font.BoldWeight = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x000552FA File Offset: 0x000534FA
		// (set) Token: 0x06001BFB RID: 7163 RVA: 0x0005530E File Offset: 0x0005350E
		public bool IsBold
		{
			get
			{
				return this.font.BoldWeight == 700;
			}
			set
			{
				if (value)
				{
					this.font.BoldWeight = 700;
					return;
				}
				this.font.BoldWeight = 400;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x00055334 File Offset: 0x00053534
		// (set) Token: 0x06001BFD RID: 7165 RVA: 0x00055341 File Offset: 0x00053541
		public global::NPOI.SS.UserModel.FontSuperScript TypeOffset
		{
			get
			{
				return this.font.SuperSubScript;
			}
			set
			{
				this.font.SuperSubScript = value;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x0005534F File Offset: 0x0005354F
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x0005535C File Offset: 0x0005355C
		public global::NPOI.SS.UserModel.FontUnderlineType Underline
		{
			get
			{
				return this.font.Underline;
			}
			set
			{
				this.font.Underline = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x0005536A File Offset: 0x0005356A
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x00055377 File Offset: 0x00053577
		public short Charset
		{
			get
			{
				return (short)this.font.Charset;
			}
			set
			{
				this.font.Charset = (byte)value;
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00055386 File Offset: 0x00053586
		public override string ToString()
		{
			string str = "NPOI.HSSF.UserModel.HSSFFont{";
			global::NPOI.HSSF.Record.FontRecord fontRecord = this.font;
			return str + ((fontRecord != null) ? fontRecord.ToString() : null) + "}";
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x000553AC File Offset: 0x000535AC
		public override int GetHashCode()
		{
			int num = 31;
			int num2 = 1;
			num2 = num * num2 + ((this.font == null) ? 0 : this.font.GetHashCode());
			return num * num2 + (int)this.index;
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x000553E4 File Offset: 0x000535E4
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			if (obj == null)
			{
				return false;
			}
			if (obj is global::NPOI.HSSF.UserModel.HSSFFont)
			{
				global::NPOI.HSSF.UserModel.HSSFFont hssffont = (global::NPOI.HSSF.UserModel.HSSFFont)obj;
				if (this.font == null)
				{
					if (hssffont.font != null)
					{
						return false;
					}
				}
				else if (!this.font.Equals(hssffont.font))
				{
					return false;
				}
				return this.index == hssffont.index;
			}
			return false;
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00055448 File Offset: 0x00053648
		public void CloneStyleFrom(global::NPOI.SS.UserModel.IFont src)
		{
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

		// Token: 0x04000B50 RID: 2896
		public const string FONT_ARIAL = "Arial";

		// Token: 0x04000B51 RID: 2897
		private global::NPOI.HSSF.Record.FontRecord font;

		// Token: 0x04000B52 RID: 2898
		private short index;
	}
}
