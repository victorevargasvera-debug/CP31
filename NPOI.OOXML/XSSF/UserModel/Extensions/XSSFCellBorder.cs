using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.Model;

namespace NPOI.XSSF.UserModel.Extensions
{
	// Token: 0x020000B3 RID: 179
	public class XSSFCellBorder
	{
		// Token: 0x06000B3F RID: 2879 RVA: 0x0002A71D File Offset: 0x0002891D
		public XSSFCellBorder(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border border, global::NPOI.XSSF.Model.ThemesTable theme) : this(border)
		{
			this._theme = theme;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0002A72D File Offset: 0x0002892D
		public XSSFCellBorder(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border border)
		{
			this.border = border;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0002A73C File Offset: 0x0002893C
		public XSSFCellBorder()
		{
			this.border = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border();
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0002A74F File Offset: 0x0002894F
		public void SetThemesTable(global::NPOI.XSSF.Model.ThemesTable themes)
		{
			this._theme = themes;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0002A758 File Offset: 0x00028958
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border GetCTBorder()
		{
			return this.border;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0002A760 File Offset: 0x00028960
		public global::NPOI.SS.UserModel.BorderStyle GetBorderStyle(global::NPOI.XSSF.UserModel.Extensions.BorderSide side)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this.GetBorder(side);
			global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle? st_BorderStyle = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle?((ct_BorderPr == null) ? global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle.none : ct_BorderPr.style);
			return (global::NPOI.SS.UserModel.BorderStyle)st_BorderStyle.Value;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0002A790 File Offset: 0x00028990
		public void SetBorderStyle(global::NPOI.XSSF.UserModel.Extensions.BorderSide side, global::NPOI.SS.UserModel.BorderStyle style)
		{
			this.GetBorder(side, true).style = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)global::System.Enum.GetValues(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)).GetValue((int)(style + 1));
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0002A7BC File Offset: 0x000289BC
		public global::NPOI.XSSF.UserModel.XSSFColor GetBorderColor(global::NPOI.XSSF.UserModel.Extensions.BorderSide side)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this.GetBorder(side);
			if (ct_BorderPr != null && ct_BorderPr.IsSetColor())
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = new global::NPOI.XSSF.UserModel.XSSFColor(ct_BorderPr.color);
				if (this._theme != null)
				{
					this._theme.InheritFromThemeAsRequired(xssfcolor);
				}
				return xssfcolor;
			}
			return null;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0002A800 File Offset: 0x00028A00
		public void SetBorderColor(global::NPOI.XSSF.UserModel.Extensions.BorderSide side, global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this.GetBorder(side, true);
			if (color == null)
			{
				ct_BorderPr.UnsetColor();
				return;
			}
			ct_BorderPr.color = color.GetCTColor();
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0002A82C File Offset: 0x00028A2C
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr GetBorder(global::NPOI.XSSF.UserModel.Extensions.BorderSide side)
		{
			return this.GetBorder(side, false);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0002A838 File Offset: 0x00028A38
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr GetBorder(global::NPOI.XSSF.UserModel.Extensions.BorderSide side, bool ensure)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr;
			switch (side)
			{
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.TOP:
				ct_BorderPr = this.border.top;
				if (ensure && ct_BorderPr == null)
				{
					ct_BorderPr = this.border.AddNewTop();
				}
				break;
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.RIGHT:
				ct_BorderPr = this.border.right;
				if (ensure && ct_BorderPr == null)
				{
					ct_BorderPr = this.border.AddNewRight();
				}
				break;
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.BOTTOM:
				ct_BorderPr = this.border.bottom;
				if (ensure && ct_BorderPr == null)
				{
					ct_BorderPr = this.border.AddNewBottom();
				}
				break;
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.LEFT:
				ct_BorderPr = this.border.left;
				if (ensure && ct_BorderPr == null)
				{
					ct_BorderPr = this.border.AddNewLeft();
				}
				break;
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.DIAGONAL:
				ct_BorderPr = this.border.diagonal;
				if (ensure && ct_BorderPr == null)
				{
					ct_BorderPr = this.border.AddNewDiagonal();
				}
				break;
			default:
				throw new global::System.ArgumentException("No suitable side specified for the border");
			}
			return ct_BorderPr;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0002A919 File Offset: 0x00028B19
		public override int GetHashCode()
		{
			return this.border.ToString().GetHashCode();
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0002A92C File Offset: 0x00028B2C
		public override bool Equals(object o)
		{
			if (!(o is global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder))
			{
				return false;
			}
			global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder xssfcellBorder = (global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder)o;
			return this.border.ToString().Equals(xssfcellBorder.GetCTBorder().ToString());
		}

		// Token: 0x040003B7 RID: 951
		private global::NPOI.XSSF.Model.ThemesTable _theme;

		// Token: 0x040003B8 RID: 952
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border border;
	}
}
