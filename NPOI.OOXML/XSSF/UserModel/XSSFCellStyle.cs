using System;
using System.Xml;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.Model;
using NPOI.XSSF.UserModel.Extensions;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200006A RID: 106
	public class XSSFCellStyle : global::NPOI.SS.UserModel.ICellStyle
	{
		// Token: 0x060004AB RID: 1195 RVA: 0x000127E8 File Offset: 0x000109E8
		public XSSFCellStyle(int cellXfId, int cellStyleXfId, global::NPOI.XSSF.Model.StylesTable stylesSource, global::NPOI.XSSF.Model.ThemesTable theme)
		{
			this._cellXfId = cellXfId;
			this._stylesSource = stylesSource;
			this._cellXf = stylesSource.GetCellXfAt(this._cellXfId);
			this._cellStyleXf = ((cellStyleXfId == -1) ? null : stylesSource.GetCellStyleXfAt(cellStyleXfId));
			this._theme = theme;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00012837 File Offset: 0x00010A37
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf GetCoreXf()
		{
			return this._cellXf;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001283F File Offset: 0x00010A3F
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf GetStyleXf()
		{
			return this._cellStyleXf;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00012847 File Offset: 0x00010A47
		public XSSFCellStyle(global::NPOI.XSSF.Model.StylesTable stylesSource)
		{
			this._stylesSource = stylesSource;
			this._cellXf = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf();
			this._cellStyleXf = null;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00012868 File Offset: 0x00010A68
		public void VerifyBelongsToStylesSource(global::NPOI.XSSF.Model.StylesTable src)
		{
			if (this._stylesSource != src)
			{
				throw new global::System.ArgumentException("This Style does not belong to the supplied Workbook Styles Source. Are you trying to assign a style from one workbook to the cell of a different workbook?");
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00012880 File Offset: 0x00010A80
		public void CloneStyleFrom(global::NPOI.SS.UserModel.ICellStyle source)
		{
			if (source is global::NPOI.XSSF.UserModel.XSSFCellStyle)
			{
				global::NPOI.XSSF.UserModel.XSSFCellStyle xssfcellStyle = (global::NPOI.XSSF.UserModel.XSSFCellStyle)source;
				if (xssfcellStyle._stylesSource == this._stylesSource)
				{
					this._cellXf = xssfcellStyle.GetCoreXf().Copy();
					this._cellStyleXf = xssfcellStyle.GetStyleXf().Copy();
				}
				else
				{
					try
					{
						if (this._cellXf.IsSetAlignment())
						{
							this._cellXf.UnsetAlignment();
						}
						if (this._cellXf.IsSetExtLst())
						{
							this._cellXf.UnsetExtLst();
						}
						this._cellXf = xssfcellStyle.GetCoreXf().Copy();
						if (this._cellXf.applyBorder)
						{
							this._cellXf.borderId = this.FindAddBorder(xssfcellStyle._stylesSource.GetBorderAt((int)this._cellXf.borderId).GetCTBorder());
						}
						global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill fill = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill.Parse(xssfcellStyle.GetCTFill().ToString());
						this.AddFill(fill);
						global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border border = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border.Parse(xssfcellStyle.GetCTBorder(false).ToString());
						this.AddBorder(border);
						if (xssfcellStyle._cellStyleXf.applyBorder)
						{
							this._cellStyleXf.borderId = this.FindAddBorder(xssfcellStyle.GetCTBorder(false));
						}
						this._stylesSource.ReplaceCellXfAt(this._cellXfId, this._cellXf);
					}
					catch (global::System.Xml.XmlException ex)
					{
						throw new global::NPOI.POIXMLException(ex);
					}
					string dataFormatString = xssfcellStyle.GetDataFormatString();
					this.DataFormat = new global::NPOI.XSSF.UserModel.XSSFDataFormat(this._stylesSource).GetFormat(dataFormatString);
					try
					{
						global::NPOI.XSSF.UserModel.XSSFFont xssffont = new global::NPOI.XSSF.UserModel.XSSFFont(xssfcellStyle.GetFont().GetCTFont().Clone());
						xssffont.RegisterTo(this._stylesSource);
						this.SetFont(xssffont);
					}
					catch (global::System.Xml.XmlException ex2)
					{
						throw new global::NPOI.POIXMLException(ex2);
					}
				}
				this._font = null;
				this._cellAlignment = null;
				return;
			}
			throw new global::System.ArgumentException("Can only clone from one XSSFCellStyle to another, not between HSSFCellStyle and XSSFCellStyle");
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00012A4C File Offset: 0x00010C4C
		private void AddFill(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill fill)
		{
			int fillId = this._stylesSource.PutFill(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill(fill));
			this._cellXf.fillId = (uint)fillId;
			this._cellXf.applyFill = true;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00012A84 File Offset: 0x00010C84
		private void AddBorder(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border border)
		{
			int borderId = this._stylesSource.PutBorder(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(border, this._theme));
			this._cellXf.borderId = (uint)borderId;
			this._cellXf.applyBorder = true;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00012AC4 File Offset: 0x00010CC4
		private uint FindAddBorder(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border border)
		{
			int hashCode = border.ToString().GetHashCode();
			uint num = 0U;
			foreach (global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder xssfcellBorder in this._stylesSource.GetBorders())
			{
				if (hashCode == xssfcellBorder.GetCTBorder().ToString().GetHashCode())
				{
					return num;
				}
				num += 1U;
			}
			return (uint)this._stylesSource.PutBorder(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(border.Copy()));
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00012B54 File Offset: 0x00010D54
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00012B5C File Offset: 0x00010D5C
		public global::NPOI.SS.UserModel.HorizontalAlignment Alignment
		{
			get
			{
				return this.GetAlignmentEnum();
			}
			set
			{
				this.GetCellAlignment().Horizontal = value;
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00012B6C File Offset: 0x00010D6C
		internal global::NPOI.SS.UserModel.HorizontalAlignment GetAlignmentEnum()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment alignment = this._cellXf.alignment;
			if (alignment != null && alignment.IsSetHorizontal())
			{
				return (global::NPOI.SS.UserModel.HorizontalAlignment)alignment.horizontal;
			}
			return global::NPOI.SS.UserModel.HorizontalAlignment.General;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00012B98 File Offset: 0x00010D98
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00012BE8 File Offset: 0x00010DE8
		public global::NPOI.SS.UserModel.BorderStyle BorderBottom
		{
			get
			{
				if (!this._cellXf.applyBorder)
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				int borderId = (int)this._cellXf.borderId;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this._stylesSource.GetBorderAt(borderId).GetCTBorder();
				if (!ctborder.IsSetBottom())
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				return (global::NPOI.SS.UserModel.BorderStyle)ctborder.bottom.style;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this.GetCTBorder(true);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = ctborder.IsSetBottom() ? ctborder.bottom : ctborder.AddNewBottom();
				if (value == global::NPOI.SS.UserModel.BorderStyle.None)
				{
					ctborder.UnsetBottom();
				}
				else
				{
					ct_BorderPr.style = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)value;
				}
				int borderId = this._stylesSource.PutBorder(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(ctborder, this._theme));
				this._cellXf.borderId = (uint)borderId;
				this._cellXf.applyBorder = true;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00012C58 File Offset: 0x00010E58
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00012CA8 File Offset: 0x00010EA8
		public global::NPOI.SS.UserModel.BorderStyle BorderLeft
		{
			get
			{
				if (!this._cellXf.applyBorder)
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				int borderId = (int)this._cellXf.borderId;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this._stylesSource.GetBorderAt(borderId).GetCTBorder();
				if (!ctborder.IsSetLeft())
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				return (global::NPOI.SS.UserModel.BorderStyle)ctborder.left.style;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this.GetCTBorder(true);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = ctborder.IsSetLeft() ? ctborder.left : ctborder.AddNewLeft();
				if (value == global::NPOI.SS.UserModel.BorderStyle.None)
				{
					ctborder.unsetLeft();
				}
				else
				{
					ct_BorderPr.style = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)value;
				}
				int borderId = this._stylesSource.PutBorder(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(ctborder, this._theme));
				this._cellXf.borderId = (uint)borderId;
				this._cellXf.applyBorder = true;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00012D18 File Offset: 0x00010F18
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00012D68 File Offset: 0x00010F68
		public global::NPOI.SS.UserModel.BorderStyle BorderRight
		{
			get
			{
				if (!this._cellXf.applyBorder)
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				int borderId = (int)this._cellXf.borderId;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this._stylesSource.GetBorderAt(borderId).GetCTBorder();
				if (!ctborder.IsSetRight())
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				return (global::NPOI.SS.UserModel.BorderStyle)ctborder.right.style;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this.GetCTBorder(true);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = ctborder.IsSetRight() ? ctborder.right : ctborder.AddNewRight();
				if (value == global::NPOI.SS.UserModel.BorderStyle.None)
				{
					ctborder.unsetRight();
				}
				else
				{
					ct_BorderPr.style = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)value;
				}
				int borderId = this._stylesSource.PutBorder(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(ctborder, this._theme));
				this._cellXf.borderId = (uint)borderId;
				this._cellXf.applyBorder = true;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00012DD8 File Offset: 0x00010FD8
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x00012E28 File Offset: 0x00011028
		public global::NPOI.SS.UserModel.BorderStyle BorderTop
		{
			get
			{
				if (!this._cellXf.applyBorder)
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				int borderId = (int)this._cellXf.borderId;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this._stylesSource.GetBorderAt(borderId).GetCTBorder();
				if (!ctborder.IsSetTop())
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				return (global::NPOI.SS.UserModel.BorderStyle)ctborder.top.style;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this.GetCTBorder(true);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = ctborder.IsSetTop() ? ctborder.top : ctborder.AddNewTop();
				if (value == global::NPOI.SS.UserModel.BorderStyle.None)
				{
					ctborder.unsetTop();
				}
				else
				{
					ct_BorderPr.style = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)value;
				}
				int borderId = this._stylesSource.PutBorder(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(ctborder, this._theme));
				this._cellXf.borderId = (uint)borderId;
				this._cellXf.applyBorder = true;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00012E98 File Offset: 0x00011098
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00012EC0 File Offset: 0x000110C0
		public short BottomBorderColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFColor bottomBorderXSSFColor = this.BottomBorderXSSFColor;
				if (bottomBorderXSSFColor != null)
				{
					return bottomBorderXSSFColor.Indexed;
				}
				return global::NPOI.SS.UserModel.IndexedColors.Black.Index;
			}
			set
			{
				this.SetBottomBorderColor(new global::NPOI.XSSF.UserModel.XSSFColor
				{
					Indexed = value
				});
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00012EE4 File Offset: 0x000110E4
		public global::NPOI.XSSF.UserModel.XSSFColor BottomBorderXSSFColor
		{
			get
			{
				if (!this._cellXf.applyBorder)
				{
					return null;
				}
				int borderId = (int)this._cellXf.borderId;
				return this._stylesSource.GetBorderAt(borderId).GetBorderColor(global::NPOI.XSSF.UserModel.Extensions.BorderSide.BOTTOM);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00012F1E File Offset: 0x0001111E
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00012F2C File Offset: 0x0001112C
		public short DataFormat
		{
			get
			{
				return (short)this._cellXf.numFmtId;
			}
			set
			{
				this.SetDataFormat((int)value & 65535);
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00012F3B File Offset: 0x0001113B
		public void SetDataFormat(int fmt)
		{
			this._cellXf.applyNumberFormat = true;
			this._cellXf.numFmtId = (uint)fmt;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00012F58 File Offset: 0x00011158
		public string GetDataFormatString()
		{
			int dataFormat = (int)this.DataFormat;
			return new global::NPOI.XSSF.UserModel.XSSFDataFormat(this._stylesSource).GetFormat((short)dataFormat);
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00012F80 File Offset: 0x00011180
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00012FB0 File Offset: 0x000111B0
		public short FillBackgroundColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = (global::NPOI.XSSF.UserModel.XSSFColor)this.FillBackgroundColorColor;
				if (xssfcolor != null)
				{
					return xssfcolor.Indexed;
				}
				return global::NPOI.SS.UserModel.IndexedColors.Automatic.Index;
			}
			set
			{
				this.SetFillBackgroundColor(new global::NPOI.XSSF.UserModel.XSSFColor
				{
					Indexed = value
				});
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00012FD1 File Offset: 0x000111D1
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00012FD9 File Offset: 0x000111D9
		public global::NPOI.SS.UserModel.IColor FillBackgroundColorColor
		{
			get
			{
				return this.FillBackgroundXSSFColor;
			}
			set
			{
				this.FillBackgroundXSSFColor = (global::NPOI.XSSF.UserModel.XSSFColor)value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00012FE8 File Offset: 0x000111E8
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00013048 File Offset: 0x00011248
		public global::NPOI.XSSF.UserModel.XSSFColor FillBackgroundXSSFColor
		{
			get
			{
				if (this._cellXf.IsSetApplyFill() && !this._cellXf.applyFill)
				{
					return null;
				}
				int fillId = (int)this._cellXf.fillId;
				global::NPOI.XSSF.UserModel.XSSFColor fillBackgroundColor = this._stylesSource.GetFillAt(fillId).GetFillBackgroundColor();
				if (fillBackgroundColor != null && this._theme != null)
				{
					this._theme.InheritFromThemeAsRequired(fillBackgroundColor);
				}
				return fillBackgroundColor;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill ctfill = this.GetCTFill();
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill ct_PatternFill = ctfill.patternFill;
				if (value == null)
				{
					if (ct_PatternFill != null && ct_PatternFill.IsSetBgColor())
					{
						ct_PatternFill.UnsetBgColor();
					}
				}
				else
				{
					if (ct_PatternFill == null)
					{
						ct_PatternFill = ctfill.AddNewPatternFill();
					}
					ct_PatternFill.bgColor = value.GetCTColor();
				}
				this.AddFill(ctfill);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00013098 File Offset: 0x00011298
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x000130C8 File Offset: 0x000112C8
		public short FillForegroundColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = (global::NPOI.XSSF.UserModel.XSSFColor)this.FillForegroundColorColor;
				if (xssfcolor != null)
				{
					return xssfcolor.Indexed;
				}
				return global::NPOI.SS.UserModel.IndexedColors.Automatic.Index;
			}
			set
			{
				this.SetFillForegroundColor(new global::NPOI.XSSF.UserModel.XSSFColor
				{
					Indexed = value
				});
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x000130E9 File Offset: 0x000112E9
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x000130F1 File Offset: 0x000112F1
		public global::NPOI.SS.UserModel.IColor FillForegroundColorColor
		{
			get
			{
				return this.FillForegroundXSSFColor;
			}
			set
			{
				this.FillForegroundXSSFColor = (global::NPOI.XSSF.UserModel.XSSFColor)value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00013100 File Offset: 0x00011300
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00013160 File Offset: 0x00011360
		public global::NPOI.XSSF.UserModel.XSSFColor FillForegroundXSSFColor
		{
			get
			{
				if (this._cellXf.IsSetApplyFill() && !this._cellXf.applyFill)
				{
					return null;
				}
				int fillId = (int)this._cellXf.fillId;
				global::NPOI.XSSF.UserModel.XSSFColor fillForegroundColor = this._stylesSource.GetFillAt(fillId).GetFillForegroundColor();
				if (fillForegroundColor != null && this._theme != null)
				{
					this._theme.InheritFromThemeAsRequired(fillForegroundColor);
				}
				return fillForegroundColor;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill ctfill = this.GetCTFill();
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill ct_PatternFill = ctfill.patternFill;
				if (value == null)
				{
					if (ct_PatternFill != null && ct_PatternFill.IsSetFgColor())
					{
						ct_PatternFill.UnsetFgColor();
					}
				}
				else
				{
					if (ct_PatternFill == null)
					{
						ct_PatternFill = ctfill.AddNewPatternFill();
					}
					ct_PatternFill.fgColor = value.GetCTColor();
				}
				this.AddFill(ctfill);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x000131B0 File Offset: 0x000113B0
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00013200 File Offset: 0x00011400
		public global::NPOI.SS.UserModel.FillPattern FillPattern
		{
			get
			{
				if (this._cellXf.IsSetApplyFill() && !this._cellXf.applyFill)
				{
					return global::NPOI.SS.UserModel.FillPattern.NoFill;
				}
				int fillId = (int)this._cellXf.fillId;
				global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType patternType = this._stylesSource.GetFillAt(fillId).GetPatternType();
				if (patternType == global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType.none)
				{
					return global::NPOI.SS.UserModel.FillPattern.NoFill;
				}
				return (global::NPOI.SS.UserModel.FillPattern)patternType;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill ctfill = this.GetCTFill();
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill ct_PatternFill = ctfill.IsSetPatternFill() ? ctfill.GetPatternFill() : ctfill.AddNewPatternFill();
				if (value == global::NPOI.SS.UserModel.FillPattern.NoFill && ct_PatternFill.IsSetPatternType())
				{
					ct_PatternFill.UnsetPatternType();
				}
				else
				{
					ct_PatternFill.patternType = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType?((global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType)value);
				}
				this.AddFill(ctfill);
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00013251 File Offset: 0x00011451
		public global::NPOI.XSSF.UserModel.XSSFFont GetFont()
		{
			if (this._font == null)
			{
				this._font = this._stylesSource.GetFontAt(this.FontId);
			}
			return this._font;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00013278 File Offset: 0x00011478
		public short FontIndex
		{
			get
			{
				return (short)this.FontId;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00013281 File Offset: 0x00011481
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x000132B4 File Offset: 0x000114B4
		public bool IsHidden
		{
			get
			{
				return this._cellXf.IsSetProtection() && this._cellXf.protection.IsSetHidden() && this._cellXf.protection.hidden;
			}
			set
			{
				if (!this._cellXf.IsSetProtection())
				{
					this._cellXf.AddNewProtection();
				}
				this._cellXf.protection.hidden = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x000132E0 File Offset: 0x000114E0
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00013307 File Offset: 0x00011507
		public short Indention
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment alignment = this._cellXf.alignment;
				return (short)((alignment == null) ? 0L : alignment.indent);
			}
			set
			{
				this.GetCellAlignment().Indent = (long)value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00013316 File Offset: 0x00011516
		public short Index
		{
			get
			{
				return (short)this._cellXfId;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0001331F File Offset: 0x0001151F
		protected internal int UIndex
		{
			get
			{
				return this._cellXfId;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00013328 File Offset: 0x00011528
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00013350 File Offset: 0x00011550
		public short LeftBorderColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFColor leftBorderXSSFColor = this.LeftBorderXSSFColor;
				if (leftBorderXSSFColor != null)
				{
					return leftBorderXSSFColor.Indexed;
				}
				return global::NPOI.SS.UserModel.IndexedColors.Black.Index;
			}
			set
			{
				this.SetLeftBorderColor(new global::NPOI.XSSF.UserModel.XSSFColor
				{
					Indexed = value
				});
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00013374 File Offset: 0x00011574
		public global::NPOI.XSSF.UserModel.XSSFColor DiagonalBorderXSSFColor
		{
			get
			{
				if (!this._cellXf.applyBorder)
				{
					return null;
				}
				int borderId = (int)this._cellXf.borderId;
				return this._stylesSource.GetBorderAt(borderId).GetBorderColor(global::NPOI.XSSF.UserModel.Extensions.BorderSide.DIAGONAL);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x000133B0 File Offset: 0x000115B0
		public global::NPOI.XSSF.UserModel.XSSFColor LeftBorderXSSFColor
		{
			get
			{
				if (!this._cellXf.applyBorder)
				{
					return null;
				}
				int borderId = (int)this._cellXf.borderId;
				return this._stylesSource.GetBorderAt(borderId).GetBorderColor(global::NPOI.XSSF.UserModel.Extensions.BorderSide.LEFT);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x000133EA File Offset: 0x000115EA
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x0001340B File Offset: 0x0001160B
		public bool IsLocked
		{
			get
			{
				return !this._cellXf.IsSetProtection() || this._cellXf.protection.locked;
			}
			set
			{
				if (!this._cellXf.IsSetProtection())
				{
					this._cellXf.AddNewProtection();
				}
				this._cellXf.protection.locked = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00013438 File Offset: 0x00011638
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00013460 File Offset: 0x00011660
		public short RightBorderColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFColor rightBorderXSSFColor = this.RightBorderXSSFColor;
				if (rightBorderXSSFColor != null)
				{
					return rightBorderXSSFColor.Indexed;
				}
				return global::NPOI.SS.UserModel.IndexedColors.Black.Index;
			}
			set
			{
				this.SetRightBorderColor(new global::NPOI.XSSF.UserModel.XSSFColor
				{
					Indexed = value
				});
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00013484 File Offset: 0x00011684
		public global::NPOI.XSSF.UserModel.XSSFColor RightBorderXSSFColor
		{
			get
			{
				if (!this._cellXf.applyBorder)
				{
					return null;
				}
				int borderId = (int)this._cellXf.borderId;
				return this._stylesSource.GetBorderAt(borderId).GetBorderColor(global::NPOI.XSSF.UserModel.Extensions.BorderSide.RIGHT);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x000134C0 File Offset: 0x000116C0
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x000134E7 File Offset: 0x000116E7
		public short Rotation
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment alignment = this._cellXf.alignment;
				return (short)((alignment == null) ? 0L : alignment.textRotation);
			}
			set
			{
				this.GetCellAlignment().TextRotation = (long)value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x000134F8 File Offset: 0x000116F8
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00013520 File Offset: 0x00011720
		public short TopBorderColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFColor topBorderXSSFColor = this.TopBorderXSSFColor;
				if (topBorderXSSFColor != null)
				{
					return topBorderXSSFColor.Indexed;
				}
				return global::NPOI.SS.UserModel.IndexedColors.Black.Index;
			}
			set
			{
				this.SetTopBorderColor(new global::NPOI.XSSF.UserModel.XSSFColor
				{
					Indexed = value
				});
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00013544 File Offset: 0x00011744
		public global::NPOI.XSSF.UserModel.XSSFColor TopBorderXSSFColor
		{
			get
			{
				if (!this._cellXf.applyBorder)
				{
					return null;
				}
				int borderId = (int)this._cellXf.borderId;
				return this._stylesSource.GetBorderAt(borderId).GetBorderColor(global::NPOI.XSSF.UserModel.Extensions.BorderSide.TOP);
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x0001357E File Offset: 0x0001177E
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00013586 File Offset: 0x00011786
		public global::NPOI.SS.UserModel.VerticalAlignment VerticalAlignment
		{
			get
			{
				return this.GetVerticalAlignmentEnum();
			}
			set
			{
				this.GetCellAlignment().Vertical = value;
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00013594 File Offset: 0x00011794
		internal global::NPOI.SS.UserModel.VerticalAlignment GetVerticalAlignmentEnum()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment alignment = this._cellXf.alignment;
			if (alignment != null && alignment.IsSetVertical())
			{
				return (global::NPOI.SS.UserModel.VerticalAlignment)alignment.vertical;
			}
			return global::NPOI.SS.UserModel.VerticalAlignment.Bottom;
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x000135C0 File Offset: 0x000117C0
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x000135E4 File Offset: 0x000117E4
		public bool WrapText
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment alignment = this._cellXf.alignment;
				return alignment != null && alignment.wrapText;
			}
			set
			{
				this.GetCellAlignment().WrapText = value;
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000135F4 File Offset: 0x000117F4
		public void SetBottomBorderColor(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this.GetCTBorder(true);
			if (color == null && !ctborder.IsSetBottom())
			{
				return;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = ctborder.IsSetBottom() ? ctborder.bottom : ctborder.AddNewBottom();
			if (color != null)
			{
				ct_BorderPr.SetColor(color.GetCTColor());
			}
			else
			{
				ct_BorderPr.UnsetColor();
			}
			int borderId = this._stylesSource.PutBorder(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(ctborder, this._theme));
			this._cellXf.borderId = (uint)borderId;
			this._cellXf.applyBorder = true;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00013674 File Offset: 0x00011874
		public void SetFillBackgroundColor(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill ctfill = this.GetCTFill();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill ct_PatternFill = ctfill.GetPatternFill();
			if (color == null)
			{
				if (ct_PatternFill != null)
				{
					ct_PatternFill.UnsetBgColor();
				}
			}
			else
			{
				if (ct_PatternFill == null)
				{
					ct_PatternFill = ctfill.AddNewPatternFill();
				}
				ct_PatternFill.bgColor = color.GetCTColor();
			}
			int fillId = this._stylesSource.PutFill(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill(ctfill));
			this._cellXf.fillId = (uint)fillId;
			this._cellXf.applyFill = true;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000136E0 File Offset: 0x000118E0
		public void SetFillForegroundColor(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill ctfill = this.GetCTFill();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill ct_PatternFill = ctfill.GetPatternFill();
			if (color == null)
			{
				if (ct_PatternFill != null)
				{
					ct_PatternFill.UnsetFgColor();
				}
			}
			else
			{
				if (ct_PatternFill == null)
				{
					ct_PatternFill = ctfill.AddNewPatternFill();
				}
				ct_PatternFill.fgColor = color.GetCTColor();
			}
			int fillId = this._stylesSource.PutFill(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellFill(ctfill));
			this._cellXf.fillId = (uint)fillId;
			this._cellXf.applyFill = true;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0001374C File Offset: 0x0001194C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill GetCTFill()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill result;
			if (!this._cellXf.IsSetApplyFill() || this._cellXf.applyFill)
			{
				int fillId = (int)this._cellXf.fillId;
				result = this._stylesSource.GetFillAt(fillId).GetCTFill().Copy();
			}
			else
			{
				result = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill();
			}
			return result;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000137A0 File Offset: 0x000119A0
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border GetCTBorder(bool copy = false)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ct_Border;
			if (this._cellXf.applyBorder)
			{
				int borderId = (int)this._cellXf.borderId;
				ct_Border = this._stylesSource.GetBorderAt(borderId).GetCTBorder();
				if (copy)
				{
					ct_Border = ct_Border.Copy();
				}
			}
			else
			{
				ct_Border = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border();
				ct_Border.AddNewLeft();
				ct_Border.AddNewRight();
				ct_Border.AddNewTop();
				ct_Border.AddNewBottom();
				ct_Border.AddNewDiagonal();
			}
			return ct_Border;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00013810 File Offset: 0x00011A10
		public void SetFont(global::NPOI.SS.UserModel.IFont font)
		{
			if (font != null)
			{
				long num = (long)font.Index;
				this._cellXf.fontId = (uint)num;
				this._cellXf.fontIdSpecified = true;
				this._cellXf.applyFont = true;
				return;
			}
			this._cellXf.applyFont = false;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0001385C File Offset: 0x00011A5C
		public void SetDiagonalBorderColor(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this.GetCTBorder(true);
			if (color == null && !ctborder.IsSetDiagonal())
			{
				return;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = ctborder.IsSetDiagonal() ? ctborder.diagonal : ctborder.AddNewDiagonal();
			if (color != null)
			{
				ct_BorderPr.color = color.GetCTColor();
			}
			else
			{
				ct_BorderPr.UnsetColor();
			}
			int borderId = this._stylesSource.PutBorder(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(ctborder, this._theme));
			this._cellXf.borderId = (uint)borderId;
			this._cellXf.applyBorder = true;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000138DC File Offset: 0x00011ADC
		public void SetLeftBorderColor(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this.GetCTBorder(true);
			if (color == null && !ctborder.IsSetLeft())
			{
				return;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = ctborder.IsSetLeft() ? ctborder.left : ctborder.AddNewLeft();
			if (color != null)
			{
				ct_BorderPr.color = color.GetCTColor();
			}
			else
			{
				ct_BorderPr.UnsetColor();
			}
			int borderId = this._stylesSource.PutBorder(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(ctborder, this._theme));
			this._cellXf.borderId = (uint)borderId;
			this._cellXf.applyBorder = true;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001395C File Offset: 0x00011B5C
		public void SetRightBorderColor(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this.GetCTBorder(true);
			if (color == null && !ctborder.IsSetRight())
			{
				return;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = ctborder.IsSetRight() ? ctborder.right : ctborder.AddNewRight();
			if (color != null)
			{
				ct_BorderPr.color = color.GetCTColor();
			}
			else
			{
				ct_BorderPr.UnsetColor();
			}
			int borderId = this._stylesSource.PutBorder(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(ctborder, this._theme));
			this._cellXf.borderId = (uint)borderId;
			this._cellXf.applyBorder = true;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000139DC File Offset: 0x00011BDC
		public void SetTopBorderColor(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this.GetCTBorder(true);
			if (color == null && !ctborder.IsSetTop())
			{
				return;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = ctborder.IsSetTop() ? ctborder.top : ctborder.AddNewTop();
			if (color != null)
			{
				ct_BorderPr.color = color.GetCTColor();
			}
			else
			{
				ct_BorderPr.UnsetColor();
			}
			int borderId = this._stylesSource.PutBorder(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(ctborder, this._theme));
			this._cellXf.borderId = (uint)borderId;
			this._cellXf.applyBorder = true;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00013586 File Offset: 0x00011786
		public void SetVerticalAlignment(short align)
		{
			this.GetCellAlignment().Vertical = (global::NPOI.SS.UserModel.VerticalAlignment)align;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00013A5C File Offset: 0x00011C5C
		public global::NPOI.XSSF.UserModel.XSSFColor GetBorderColor(global::NPOI.XSSF.UserModel.Extensions.BorderSide side)
		{
			switch (side)
			{
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.TOP:
				return this.TopBorderXSSFColor;
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.RIGHT:
				return this.RightBorderXSSFColor;
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.BOTTOM:
				return this.BottomBorderXSSFColor;
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.LEFT:
				return this.LeftBorderXSSFColor;
			default:
				throw new global::System.ArgumentException("Unknown border: " + side.ToString());
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00013AB9 File Offset: 0x00011CB9
		public void SetBorderColor(global::NPOI.XSSF.UserModel.Extensions.BorderSide side, global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			switch (side)
			{
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.TOP:
				this.SetTopBorderColor(color);
				return;
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.RIGHT:
				this.SetRightBorderColor(color);
				return;
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.BOTTOM:
				this.SetBottomBorderColor(color);
				return;
			case global::NPOI.XSSF.UserModel.Extensions.BorderSide.LEFT:
				this.SetLeftBorderColor(color);
				return;
			default:
				return;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00013AF1 File Offset: 0x00011CF1
		private int FontId
		{
			get
			{
				if (this._cellXf.IsSetFontId())
				{
					return (int)this._cellXf.fontId;
				}
				return (int)this._cellStyleXf.fontId;
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00013B17 File Offset: 0x00011D17
		internal global::NPOI.XSSF.UserModel.Extensions.XSSFCellAlignment GetCellAlignment()
		{
			if (this._cellAlignment == null)
			{
				this._cellAlignment = new global::NPOI.XSSF.UserModel.Extensions.XSSFCellAlignment(this.GetCTCellAlignment());
			}
			return this._cellAlignment;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00013B38 File Offset: 0x00011D38
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment GetCTCellAlignment()
		{
			if (this._cellXf.alignment == null)
			{
				this._cellXf.alignment = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment();
			}
			return this._cellXf.alignment;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00013B62 File Offset: 0x00011D62
		public override int GetHashCode()
		{
			return this._cellXf.ToString().GetHashCode();
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00013B74 File Offset: 0x00011D74
		public override bool Equals(object o)
		{
			if (o == null || !(o is global::NPOI.XSSF.UserModel.XSSFCellStyle))
			{
				return false;
			}
			global::NPOI.XSSF.UserModel.XSSFCellStyle xssfcellStyle = (global::NPOI.XSSF.UserModel.XSSFCellStyle)o;
			return this._cellXf.ToString().Equals(xssfcellStyle.GetCoreXf().ToString());
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00013BB0 File Offset: 0x00011DB0
		public object Clone()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf cellXf = this._cellXf.Copy();
			int styleXfsSize = this._stylesSource.StyleXfsSize;
			return new global::NPOI.XSSF.UserModel.XSSFCellStyle(this._stylesSource.PutCellXf(cellXf) - 1, styleXfsSize - 1, this._stylesSource, this._theme);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00013BF7 File Offset: 0x00011DF7
		public global::NPOI.SS.UserModel.IFont GetFont(global::NPOI.SS.UserModel.IWorkbook parentWorkbook)
		{
			return this.GetFont();
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00013C00 File Offset: 0x00011E00
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00013C24 File Offset: 0x00011E24
		public bool ShrinkToFit
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment alignment = this._cellXf.alignment;
				return alignment != null && alignment.shrinkToFit;
			}
			set
			{
				this.GetCTCellAlignment().shrinkToFit = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00013C34 File Offset: 0x00011E34
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00013C5C File Offset: 0x00011E5C
		public short BorderDiagonalColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFColor diagonalBorderXSSFColor = this.DiagonalBorderXSSFColor;
				if (diagonalBorderXSSFColor != null)
				{
					return diagonalBorderXSSFColor.Indexed;
				}
				return global::NPOI.SS.UserModel.IndexedColors.Black.Index;
			}
			set
			{
				this.SetDiagonalBorderColor(new global::NPOI.XSSF.UserModel.XSSFColor
				{
					Indexed = value
				});
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00013C80 File Offset: 0x00011E80
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00013CD0 File Offset: 0x00011ED0
		public global::NPOI.SS.UserModel.BorderStyle BorderDiagonalLineStyle
		{
			get
			{
				if (!this._cellXf.applyBorder)
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				int borderId = (int)this._cellXf.borderId;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this._stylesSource.GetBorderAt(borderId).GetCTBorder();
				if (!ctborder.IsSetDiagonal())
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				return (global::NPOI.SS.UserModel.BorderStyle)ctborder.diagonal.style;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this.GetCTBorder(true);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = ctborder.IsSetDiagonal() ? ctborder.diagonal : ctborder.AddNewDiagonal();
				if (value == global::NPOI.SS.UserModel.BorderStyle.None)
				{
					ctborder.unsetDiagonal();
				}
				else
				{
					ct_BorderPr.style = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)value;
				}
				int borderId = this._stylesSource.PutBorder(new global::NPOI.XSSF.UserModel.Extensions.XSSFCellBorder(ctborder, this._theme));
				this._cellXf.borderId = (uint)borderId;
				this._cellXf.applyBorder = true;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00013D40 File Offset: 0x00011F40
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00013D7C File Offset: 0x00011F7C
		public global::NPOI.SS.UserModel.BorderDiagonal BorderDiagonal
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this.GetCTBorder(false);
				if (ctborder.diagonalDown && ctborder.diagonalUp)
				{
					return global::NPOI.SS.UserModel.BorderDiagonal.Both;
				}
				if (ctborder.diagonalDown)
				{
					return global::NPOI.SS.UserModel.BorderDiagonal.Backward;
				}
				if (ctborder.diagonalUp)
				{
					return global::NPOI.SS.UserModel.BorderDiagonal.Forward;
				}
				return global::NPOI.SS.UserModel.BorderDiagonal.None;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ctborder = this.GetCTBorder(false);
				if (value == global::NPOI.SS.UserModel.BorderDiagonal.Both)
				{
					ctborder.diagonalDown = true;
					ctborder.diagonalDownSpecified = true;
					ctborder.diagonalUp = true;
					ctborder.diagonalUpSpecified = true;
					return;
				}
				if (value == global::NPOI.SS.UserModel.BorderDiagonal.Forward)
				{
					ctborder.diagonalDown = false;
					ctborder.diagonalDownSpecified = false;
					ctborder.diagonalUp = true;
					ctborder.diagonalUpSpecified = true;
					return;
				}
				if (value == global::NPOI.SS.UserModel.BorderDiagonal.Backward)
				{
					ctborder.diagonalDown = true;
					ctborder.diagonalDownSpecified = true;
					ctborder.diagonalUp = false;
					ctborder.diagonalUpSpecified = false;
					return;
				}
				ctborder.unsetDiagonal();
				ctborder.diagonalDown = false;
				ctborder.diagonalDownSpecified = false;
				ctborder.diagonalUp = false;
				ctborder.diagonalUpSpecified = false;
			}
		}

		// Token: 0x0400029D RID: 669
		private int _cellXfId;

		// Token: 0x0400029E RID: 670
		private global::NPOI.XSSF.Model.StylesTable _stylesSource;

		// Token: 0x0400029F RID: 671
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf _cellXf;

		// Token: 0x040002A0 RID: 672
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Xf _cellStyleXf;

		// Token: 0x040002A1 RID: 673
		private global::NPOI.XSSF.UserModel.XSSFFont _font;

		// Token: 0x040002A2 RID: 674
		private global::NPOI.XSSF.UserModel.Extensions.XSSFCellAlignment _cellAlignment;

		// Token: 0x040002A3 RID: 675
		private global::NPOI.XSSF.Model.ThemesTable _theme;
	}
}
