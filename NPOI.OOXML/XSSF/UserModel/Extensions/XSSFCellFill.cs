using System;
using NPOI.OpenXmlFormats.Spreadsheet;

namespace NPOI.XSSF.UserModel.Extensions
{
	// Token: 0x020000B4 RID: 180
	public class XSSFCellFill
	{
		// Token: 0x06000B4C RID: 2892 RVA: 0x0002A965 File Offset: 0x00028B65
		public XSSFCellFill(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill fill)
		{
			this._fill = fill;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0002A974 File Offset: 0x00028B74
		public XSSFCellFill()
		{
			this._fill = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill();
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0002A988 File Offset: 0x00028B88
		public global::NPOI.XSSF.UserModel.XSSFColor GetFillBackgroundColor()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill patternFill = this._fill.GetPatternFill();
			if (patternFill == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color bgColor = patternFill.bgColor;
			if (bgColor != null)
			{
				return new global::NPOI.XSSF.UserModel.XSSFColor(bgColor);
			}
			return null;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0002A9B8 File Offset: 0x00028BB8
		public void SetFillBackgroundColor(int index)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill ct_PatternFill = this.EnsureCTPatternFill();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ct_Color = ct_PatternFill.IsSetBgColor() ? ct_PatternFill.bgColor : ct_PatternFill.AddNewBgColor();
			ct_Color.indexed = (uint)index;
			ct_Color.indexedSpecified = true;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0002A9EF File Offset: 0x00028BEF
		public void SetFillBackgroundColor(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			this.EnsureCTPatternFill().bgColor = color.GetCTColor();
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0002AA04 File Offset: 0x00028C04
		public global::NPOI.XSSF.UserModel.XSSFColor GetFillForegroundColor()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill patternFill = this._fill.GetPatternFill();
			if (patternFill == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color fgColor = patternFill.fgColor;
			if (fgColor != null)
			{
				return new global::NPOI.XSSF.UserModel.XSSFColor(fgColor);
			}
			return null;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0002AA34 File Offset: 0x00028C34
		public void SetFillForegroundColor(int index)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill ct_PatternFill = this.EnsureCTPatternFill();
			(ct_PatternFill.IsSetFgColor() ? ct_PatternFill.fgColor : ct_PatternFill.AddNewFgColor()).indexed = (uint)index;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0002AA64 File Offset: 0x00028C64
		public void SetFillForegroundColor(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			this.EnsureCTPatternFill().fgColor = color.GetCTColor();
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0002AA78 File Offset: 0x00028C78
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType GetPatternType()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill patternFill = this._fill.GetPatternFill();
			if (patternFill != null)
			{
				return patternFill.patternType.Value;
			}
			return global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType.none;
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0002AAA4 File Offset: 0x00028CA4
		public void SetPatternType(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType patternType)
		{
			this.EnsureCTPatternFill().patternType = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType?(patternType);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0002AAB8 File Offset: 0x00028CB8
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill EnsureCTPatternFill()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill ct_PatternFill = this._fill.GetPatternFill();
			if (ct_PatternFill == null)
			{
				ct_PatternFill = this._fill.AddNewPatternFill();
			}
			return ct_PatternFill;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0002AAE1 File Offset: 0x00028CE1
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill GetCTFill()
		{
			return this._fill;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0002AAE9 File Offset: 0x00028CE9
		public override int GetHashCode()
		{
			return this._fill.ToString().GetHashCode();
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0002AAFC File Offset: 0x00028CFC
		public override bool Equals(object o)
		{
			if (!(o is global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill))
			{
				return false;
			}
			global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill xssfcellFill = (global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill)o;
			return this._fill.ToString().Equals(xssfcellFill.GetCTFill().ToString());
		}

		// Token: 0x040003B9 RID: 953
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill _fill;
	}
}
