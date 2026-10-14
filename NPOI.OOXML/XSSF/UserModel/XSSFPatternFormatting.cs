using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000091 RID: 145
	public class XSSFPatternFormatting : global::NPOI.SS.UserModel.IPatternFormatting
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x00019106 File Offset: 0x00017306
		public XSSFPatternFormatting(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill fill)
		{
			this._fill = fill;
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00019115 File Offset: 0x00017315
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x0001913C File Offset: 0x0001733C
		public global::NPOI.SS.UserModel.IColor FillBackgroundColorColor
		{
			get
			{
				if (!this._fill.IsSetPatternFill())
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFColor(this._fill.GetPatternFill().bgColor);
			}
			set
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = global::NPOI.XSSF.UserModel.XSSFColor.ToXSSFColor(value);
				if (value == null)
				{
					this.SetFillBackgroundColor(null);
					return;
				}
				this.SetFillBackgroundColor(xssfcolor.GetCTColor());
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00019168 File Offset: 0x00017368
		private void SetFillBackgroundColor(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill ct_PatternFill = this._fill.IsSetPatternFill() ? this._fill.patternFill : this._fill.AddNewPatternFill();
			if (color == null)
			{
				ct_PatternFill.UnsetBgColor();
				return;
			}
			ct_PatternFill.bgColor = color;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x000191AC File Offset: 0x000173AC
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x000191E4 File Offset: 0x000173E4
		public global::NPOI.SS.UserModel.IColor FillForegroundColorColor
		{
			get
			{
				if (!this._fill.IsSetPatternFill() || !this._fill.GetPatternFill().IsSetFgColor())
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFColor(this._fill.GetPatternFill().bgColor);
			}
			set
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = global::NPOI.XSSF.UserModel.XSSFColor.ToXSSFColor(value);
				if (value == null)
				{
					this.SetFillForegroundColor(null);
					return;
				}
				this.SetFillForegroundColor(xssfcolor.GetCTColor());
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00019210 File Offset: 0x00017410
		private void SetFillForegroundColor(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill ct_PatternFill = this._fill.IsSetPatternFill() ? this._fill.GetPatternFill() : this._fill.AddNewPatternFill();
			if (color == null)
			{
				ct_PatternFill.UnsetFgColor();
				return;
			}
			ct_PatternFill.fgColor = color;
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x00019254 File Offset: 0x00017454
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x00019294 File Offset: 0x00017494
		public short FillBackgroundColor
		{
			get
			{
				if (!this._fill.IsSetPatternFill())
				{
					return 0;
				}
				if (!this._fill.GetPatternFill().bgColor.indexedSpecified)
				{
					return 0;
				}
				return (short)this._fill.GetPatternFill().bgColor.indexed;
			}
			set
			{
				(this._fill.IsSetPatternFill() ? this._fill.GetPatternFill() : this._fill.AddNewPatternFill()).bgColor = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color
				{
					indexed = (uint)value,
					indexedSpecified = true
				};
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x000192E0 File Offset: 0x000174E0
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00019340 File Offset: 0x00017540
		public short FillForegroundColor
		{
			get
			{
				if (!this._fill.IsSetPatternFill() || !this._fill.GetPatternFill().IsSetFgColor())
				{
					return 0;
				}
				if (!this._fill.GetPatternFill().fgColor.indexedSpecified)
				{
					return 0;
				}
				return (short)this._fill.GetPatternFill().fgColor.indexed;
			}
			set
			{
				(this._fill.IsSetPatternFill() ? this._fill.GetPatternFill() : this._fill.AddNewPatternFill()).fgColor = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color
				{
					indexed = (uint)value,
					indexedSpecified = true
				};
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x0001938C File Offset: 0x0001758C
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x000193D3 File Offset: 0x000175D3
		public global::NPOI.SS.UserModel.FillPattern FillPattern
		{
			get
			{
				if (!this._fill.IsSetPatternFill() || !this._fill.GetPatternFill().IsSetPatternType())
				{
					return global::NPOI.SS.UserModel.FillPattern.NoFill;
				}
				return (global::NPOI.SS.UserModel.FillPattern)this._fill.GetPatternFill().patternType.Value;
			}
			set
			{
				(this._fill.IsSetPatternFill() ? this._fill.GetPatternFill() : this._fill.AddNewPatternFill()).patternType = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType?((global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType)value);
			}
		}

		// Token: 0x040002F8 RID: 760
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill _fill;
	}
}
