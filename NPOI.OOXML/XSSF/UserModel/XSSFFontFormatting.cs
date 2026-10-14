using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000087 RID: 135
	public class XSSFFontFormatting : global::NPOI.SS.UserModel.IFontFormatting
	{
		// Token: 0x060006FF RID: 1791 RVA: 0x0001800A File Offset: 0x0001620A
		internal XSSFFontFormatting(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font font)
		{
			this._font = font;
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00018019 File Offset: 0x00016219
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x0001803E File Offset: 0x0001623E
		public global::NPOI.SS.UserModel.FontSuperScript EscapementType
		{
			get
			{
				if (this._font.sizeOfVertAlignArray() == 0)
				{
					return global::NPOI.SS.UserModel.FontSuperScript.None;
				}
				return (global::NPOI.SS.UserModel.FontSuperScript)(this._font.GetVertAlignArray(0).val - global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun.superscript);
			}
			set
			{
				this._font.SetVertAlignArray(null);
				if (value != global::NPOI.SS.UserModel.FontSuperScript.None)
				{
					this._font.AddNewVertAlign().val = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignRun)((short)(value + 1));
				}
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00018064 File Offset: 0x00016264
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x000180A0 File Offset: 0x000162A0
		public short FontColorIndex
		{
			get
			{
				if (this._font.sizeOfColorArray() == 0)
				{
					return -1;
				}
				int num = 0;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color colorArray = this._font.GetColorArray(0);
				if (colorArray.IsSetIndexed())
				{
					num = (int)colorArray.indexed;
				}
				return (short)num;
			}
			set
			{
				this._font.SetColorArray(null);
				if (value != -1)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color = this._font.AddNewColor();
					ct_Color.indexed = (uint)value;
					ct_Color.indexedSpecified = true;
				}
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x000180CA File Offset: 0x000162CA
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x000180EC File Offset: 0x000162EC
		public global::NPOI.SS.UserModel.IColor FontColor
		{
			get
			{
				if (this._font.sizeOfColorArray() == 0)
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFColor(this._font.GetColorArray(0));
			}
			set
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = global::NPOI.XSSF.UserModel.XSSFColor.ToXSSFColor(value);
				if (xssfcolor == null)
				{
					this._font.color.Clear();
					return;
				}
				this._font.SetColorArray(0, xssfcolor.GetCTColor());
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00018128 File Offset: 0x00016328
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00018162 File Offset: 0x00016362
		public int FontHeight
		{
			get
			{
				if (this._font.sizeOfSzArray() == 0)
				{
					return -1;
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_FontSize szArray = this._font.GetSzArray(0);
				return (int)((short)(20.0 * szArray.val));
			}
			set
			{
				this._font.SetSzArray(null);
				if (value != -1)
				{
					this._font.AddNewSz().val = (double)value / 20.0;
				}
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00018190 File Offset: 0x00016390
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x000181E4 File Offset: 0x000163E4
		public global::NPOI.SS.UserModel.FontUnderlineType UnderlineType
		{
			get
			{
				if (this._font.sizeOfUArray() == 0)
				{
					return global::NPOI.SS.UserModel.FontUnderlineType.None;
				}
				switch (this._font.GetUArray(0).val)
				{
				case global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues.single:
					return global::NPOI.SS.UserModel.FontUnderlineType.Single;
				case global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues.@double:
					return global::NPOI.SS.UserModel.FontUnderlineType.Double;
				case global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues.singleAccounting:
					return global::NPOI.SS.UserModel.FontUnderlineType.SingleAccounting;
				case global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues.doubleAccounting:
					return global::NPOI.SS.UserModel.FontUnderlineType.DoubleAccounting;
				default:
					return global::NPOI.SS.UserModel.FontUnderlineType.None;
				}
			}
			set
			{
				this._font.SetUArray(null);
				if (value != global::NPOI.SS.UserModel.FontUnderlineType.None)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues value2 = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_UnderlineValues)global::NPOI.SS.UserModel.FontUnderline.ValueOf(value).Value;
					this._font.AddNewU().val = value2;
				}
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x0001821D File Offset: 0x0001641D
		public bool IsBold
		{
			get
			{
				return this._font.SizeOfBArray() == 1 && this._font.GetBArray(0).val;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00018240 File Offset: 0x00016440
		public bool IsItalic
		{
			get
			{
				return this._font.sizeOfIArray() == 1 && this._font.GetIArray(0).val;
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00018264 File Offset: 0x00016464
		public void SetFontStyle(bool italic, bool bold)
		{
			this._font.SetIArray(null);
			this._font.SetBArray(null);
			if (italic)
			{
				this._font.AddNewI().val = true;
			}
			if (bold)
			{
				this._font.AddNewB().val = true;
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000182B1 File Offset: 0x000164B1
		public void ResetFontStyle()
		{
			this._font = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font();
		}

		// Token: 0x040002E1 RID: 737
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font _font;
	}
}
