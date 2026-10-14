using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000068 RID: 104
	public class XSSFBorderFormatting : global::NPOI.SS.UserModel.IBorderFormatting
	{
		// Token: 0x06000445 RID: 1093 RVA: 0x00010D50 File Offset: 0x0000EF50
		internal XSSFBorderFormatting(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border border)
		{
			this._border = border;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00010D5F File Offset: 0x0000EF5F
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x00010D84 File Offset: 0x0000EF84
		public global::NPOI.SS.UserModel.BorderStyle BorderBottom
		{
			get
			{
				if (!this._border.IsSetBottom())
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				return (global::NPOI.SS.UserModel.BorderStyle)this._border.bottom.style;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this._border.IsSetBottom() ? this._border.bottom : this._border.AddNewBottom();
				if (value == global::NPOI.SS.UserModel.BorderStyle.None)
				{
					this._border.UnsetBottom();
					return;
				}
				ct_BorderPr.style = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00010DCD File Offset: 0x0000EFCD
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		public global::NPOI.SS.UserModel.BorderStyle BorderDiagonal
		{
			get
			{
				if (!this._border.IsSetDiagonal())
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				return (global::NPOI.SS.UserModel.BorderStyle)this._border.diagonal.style;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this._border.IsSetDiagonal() ? this._border.diagonal : this._border.AddNewDiagonal();
				if (value == global::NPOI.SS.UserModel.BorderStyle.None)
				{
					this._border.unsetDiagonal();
					return;
				}
				ct_BorderPr.style = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00010E39 File Offset: 0x0000F039
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00010E5C File Offset: 0x0000F05C
		public global::NPOI.SS.UserModel.BorderStyle BorderLeft
		{
			get
			{
				if (!this._border.IsSetLeft())
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				return (global::NPOI.SS.UserModel.BorderStyle)this._border.left.style;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this._border.IsSetLeft() ? this._border.left : this._border.AddNewLeft();
				if (value == global::NPOI.SS.UserModel.BorderStyle.None)
				{
					this._border.unsetLeft();
					return;
				}
				ct_BorderPr.style = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00010EA5 File Offset: 0x0000F0A5
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00010EC8 File Offset: 0x0000F0C8
		public global::NPOI.SS.UserModel.BorderStyle BorderRight
		{
			get
			{
				if (!this._border.IsSetRight())
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				return (global::NPOI.SS.UserModel.BorderStyle)this._border.right.style;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this._border.IsSetRight() ? this._border.right : this._border.AddNewRight();
				if (value == global::NPOI.SS.UserModel.BorderStyle.None)
				{
					this._border.unsetRight();
					return;
				}
				ct_BorderPr.style = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00010F11 File Offset: 0x0000F111
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x00010F34 File Offset: 0x0000F134
		public global::NPOI.SS.UserModel.BorderStyle BorderTop
		{
			get
			{
				if (!this._border.IsSetTop())
				{
					return global::NPOI.SS.UserModel.BorderStyle.None;
				}
				return (global::NPOI.SS.UserModel.BorderStyle)this._border.top.style;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this._border.IsSetTop() ? this._border.top : this._border.AddNewTop();
				if (value == global::NPOI.SS.UserModel.BorderStyle.None)
				{
					this._border.unsetTop();
					return;
				}
				ct_BorderPr.style = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_BorderStyle)value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00010F80 File Offset: 0x0000F180
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00010FA4 File Offset: 0x0000F1A4
		public short BottomBorderColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = this.BottomBorderColorColor as global::NPOI.XSSF.UserModel.XSSFColor;
				if (xssfcolor == null)
				{
					return 0;
				}
				return xssfcolor.Indexed;
			}
			set
			{
				this.setBottomBorderColor(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color
				{
					indexed = (uint)value,
					indexedSpecified = true
				});
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00010FCC File Offset: 0x0000F1CC
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00010FF0 File Offset: 0x0000F1F0
		public short DiagonalBorderColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = this.DiagonalBorderColorColor as global::NPOI.XSSF.UserModel.XSSFColor;
				if (xssfcolor == null)
				{
					return 0;
				}
				return xssfcolor.Indexed;
			}
			set
			{
				this.setDiagonalBorderColor(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color
				{
					indexed = (uint)value,
					indexedSpecified = true
				});
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00011018 File Offset: 0x0000F218
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x0001103C File Offset: 0x0000F23C
		public short LeftBorderColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = this.LeftBorderColorColor as global::NPOI.XSSF.UserModel.XSSFColor;
				if (xssfcolor == null)
				{
					return 0;
				}
				return xssfcolor.Indexed;
			}
			set
			{
				this.setLeftBorderColor(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color
				{
					indexed = (uint)value,
					indexedSpecified = true
				});
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00011064 File Offset: 0x0000F264
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00011088 File Offset: 0x0000F288
		public short RightBorderColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = this.RightBorderColorColor as global::NPOI.XSSF.UserModel.XSSFColor;
				if (xssfcolor == null)
				{
					return 0;
				}
				return xssfcolor.Indexed;
			}
			set
			{
				this.setRightBorderColor(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color
				{
					indexed = (uint)value,
					indexedSpecified = true
				});
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000110B0 File Offset: 0x0000F2B0
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x000110D4 File Offset: 0x0000F2D4
		public short TopBorderColor
		{
			get
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = this.RightBorderColorColor as global::NPOI.XSSF.UserModel.XSSFColor;
				if (xssfcolor == null)
				{
					return 0;
				}
				return xssfcolor.Indexed;
			}
			set
			{
				this.setTopBorderColor(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color
				{
					indexed = (uint)value,
					indexedSpecified = true
				});
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x000110FC File Offset: 0x0000F2FC
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00011124 File Offset: 0x0000F324
		public global::NPOI.SS.UserModel.IColor BottomBorderColorColor
		{
			get
			{
				if (!this._border.IsSetBottom())
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFColor(this._border.bottom.color);
			}
			set
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = global::NPOI.XSSF.UserModel.XSSFColor.ToXSSFColor(value);
				if (xssfcolor == null)
				{
					this.setBottomBorderColor(null);
					return;
				}
				this.setBottomBorderColor(xssfcolor.GetCTColor());
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00011150 File Offset: 0x0000F350
		public void setBottomBorderColor(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this._border.IsSetBottom() ? this._border.bottom : this._border.AddNewBottom();
			if (color == null)
			{
				ct_BorderPr.UnsetColor();
				return;
			}
			ct_BorderPr.color = color;
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00011194 File Offset: 0x0000F394
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x000111BC File Offset: 0x0000F3BC
		public global::NPOI.SS.UserModel.IColor DiagonalBorderColorColor
		{
			get
			{
				if (!this._border.IsSetDiagonal())
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFColor(this._border.diagonal.color);
			}
			set
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = global::NPOI.XSSF.UserModel.XSSFColor.ToXSSFColor(value);
				if (xssfcolor == null)
				{
					this.setDiagonalBorderColor(null);
					return;
				}
				this.setDiagonalBorderColor(xssfcolor.GetCTColor());
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000111E8 File Offset: 0x0000F3E8
		public void setDiagonalBorderColor(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this._border.IsSetDiagonal() ? this._border.diagonal : this._border.AddNewDiagonal();
			if (color == null)
			{
				ct_BorderPr.UnsetColor();
				return;
			}
			ct_BorderPr.color = color;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0001122C File Offset: 0x0000F42C
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00011254 File Offset: 0x0000F454
		public global::NPOI.SS.UserModel.IColor LeftBorderColorColor
		{
			get
			{
				if (!this._border.IsSetLeft())
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFColor(this._border.left.color);
			}
			set
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = global::NPOI.XSSF.UserModel.XSSFColor.ToXSSFColor(value);
				if (xssfcolor == null)
				{
					this.setLeftBorderColor(null);
					return;
				}
				this.setLeftBorderColor(xssfcolor.GetCTColor());
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00011280 File Offset: 0x0000F480
		public void setLeftBorderColor(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this._border.IsSetLeft() ? this._border.left : this._border.AddNewLeft();
			if (color == null)
			{
				ct_BorderPr.UnsetColor();
				return;
			}
			ct_BorderPr.color = color;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000112C4 File Offset: 0x0000F4C4
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x000112EC File Offset: 0x0000F4EC
		public global::NPOI.SS.UserModel.IColor RightBorderColorColor
		{
			get
			{
				if (!this._border.IsSetRight())
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFColor(this._border.right.color);
			}
			set
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = global::NPOI.XSSF.UserModel.XSSFColor.ToXSSFColor(value);
				if (xssfcolor == null)
				{
					this.setRightBorderColor(null);
					return;
				}
				this.setRightBorderColor(xssfcolor.GetCTColor());
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00011318 File Offset: 0x0000F518
		public void setRightBorderColor(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this._border.IsSetRight() ? this._border.right : this._border.AddNewRight();
			if (color == null)
			{
				ct_BorderPr.UnsetColor();
				return;
			}
			ct_BorderPr.color = color;
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0001135C File Offset: 0x0000F55C
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00011384 File Offset: 0x0000F584
		public global::NPOI.SS.UserModel.IColor TopBorderColorColor
		{
			get
			{
				if (!this._border.IsSetTop())
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFColor(this._border.top.color);
			}
			set
			{
				global::NPOI.XSSF.UserModel.XSSFColor xssfcolor = global::NPOI.XSSF.UserModel.XSSFColor.ToXSSFColor(value);
				if (xssfcolor == null)
				{
					this.setTopBorderColor(null);
					return;
				}
				this.setTopBorderColor(xssfcolor.GetCTColor());
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000113B0 File Offset: 0x0000F5B0
		public void setTopBorderColor(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color color)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_BorderPr ct_BorderPr = this._border.IsSetTop() ? this._border.top : this._border.AddNewTop();
			if (color == null)
			{
				ct_BorderPr.UnsetColor();
				return;
			}
			ct_BorderPr.color = color;
		}

		// Token: 0x04000295 RID: 661
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border _border;
	}
}
