using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000098 RID: 152
	public class XSSFPrintSetup : global::NPOI.SS.UserModel.IPrintSetup
	{
		// Token: 0x060007D6 RID: 2006 RVA: 0x0001A514 File Offset: 0x00018714
		public XSSFPrintSetup(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet worksheet)
		{
			this.ctWorksheet = worksheet;
			if (this.ctWorksheet.IsSetPageSetup())
			{
				this.pageSetup = this.ctWorksheet.pageSetup;
			}
			else
			{
				this.pageSetup = this.ctWorksheet.AddNewPageSetup();
			}
			if (this.ctWorksheet.IsSetPageMargins())
			{
				this.pageMargins = this.ctWorksheet.pageMargins;
				return;
			}
			this.pageMargins = this.ctWorksheet.AddNewPageMargins();
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0001A58F File Offset: 0x0001878F
		public void SetPaperSize(global::NPOI.SS.UserModel.PaperSize size)
		{
			this.PaperSize = (short)(size + 1);
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0001A59C File Offset: 0x0001879C
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x0001A5D8 File Offset: 0x000187D8
		public global::NPOI.SS.UserModel.PrintOrientation Orientation
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation? st_Orientation = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation?(this.pageSetup.orientation);
				if (st_Orientation != null)
				{
					return global::NPOI.SS.UserModel.PrintOrientation.ValueOf((int)st_Orientation.Value);
				}
				return global::NPOI.SS.UserModel.PrintOrientation.DEFAULT;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation value2 = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_Orientation)value.Value;
				this.pageSetup.orientation = value2;
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0001A5F8 File Offset: 0x000187F8
		public global::NPOI.SS.UserModel.PrintCellComments GetCellComment()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellComments? st_CellComments = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellComments?(this.pageSetup.cellComments);
			if (st_CellComments != null)
			{
				return global::NPOI.SS.UserModel.PrintCellComments.ValueOf((int)st_CellComments.Value);
			}
			return global::NPOI.SS.UserModel.PrintCellComments.NONE;
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x0001A632 File Offset: 0x00018832
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x0001A644 File Offset: 0x00018844
		public global::NPOI.SS.UserModel.PageOrder PageOrder
		{
			get
			{
				return global::NPOI.SS.UserModel.PageOrder.ValueOf((int)this.pageSetup.pageOrder);
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.ST_PageOrder value2 = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_PageOrder)value.Value;
				this.pageSetup.pageOrder = value2;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x0001A664 File Offset: 0x00018864
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x0001A672 File Offset: 0x00018872
		public short PaperSize
		{
			get
			{
				return (short)this.pageSetup.paperSize;
			}
			set
			{
				this.pageSetup.paperSize = (uint)value;
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0001A680 File Offset: 0x00018880
		public global::NPOI.SS.UserModel.PaperSize GetPaperSizeEnum()
		{
			return (global::NPOI.SS.UserModel.PaperSize)(this.PaperSize - 1);
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0001A68B File Offset: 0x0001888B
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x0001A6A9 File Offset: 0x000188A9
		public short Scale
		{
			get
			{
				if (this.pageSetup.scale == 0U)
				{
					return 100;
				}
				return (short)this.pageSetup.scale;
			}
			set
			{
				if (value < 10 || value > 400)
				{
					throw new global::NPOI.POIXMLException("Scale value not accepted: you must choose a value between 10 and 400.");
				}
				this.pageSetup.scale = (uint)value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0001A6CF File Offset: 0x000188CF
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x0001A6DD File Offset: 0x000188DD
		public short PageStart
		{
			get
			{
				return (short)this.pageSetup.firstPageNumber;
			}
			set
			{
				this.pageSetup.firstPageNumber = (uint)value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0001A6EB File Offset: 0x000188EB
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x0001A6F9 File Offset: 0x000188F9
		public short FitWidth
		{
			get
			{
				return (short)this.pageSetup.fitToWidth;
			}
			set
			{
				this.pageSetup.fitToWidth = (uint)value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0001A707 File Offset: 0x00018907
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x0001A715 File Offset: 0x00018915
		public short FitHeight
		{
			get
			{
				return (short)this.pageSetup.fitToHeight;
			}
			set
			{
				this.pageSetup.fitToHeight = (uint)value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0001A723 File Offset: 0x00018923
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x0001A732 File Offset: 0x00018932
		public bool LeftToRight
		{
			get
			{
				return this.PageOrder == global::NPOI.SS.UserModel.PageOrder.OVER_THEN_DOWN;
			}
			set
			{
				if (value)
				{
					this.PageOrder = global::NPOI.SS.UserModel.PageOrder.OVER_THEN_DOWN;
					return;
				}
				this.PageOrder = global::NPOI.SS.UserModel.PageOrder.DOWN_THEN_OVER;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x0001A74E File Offset: 0x0001894E
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x0001A75D File Offset: 0x0001895D
		public bool Landscape
		{
			get
			{
				return this.Orientation == global::NPOI.SS.UserModel.PrintOrientation.LANDSCAPE;
			}
			set
			{
				if (value)
				{
					this.Orientation = global::NPOI.SS.UserModel.PrintOrientation.LANDSCAPE;
					return;
				}
				this.Orientation = global::NPOI.SS.UserModel.PrintOrientation.PORTRAIT;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0001A779 File Offset: 0x00018979
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x0001A786 File Offset: 0x00018986
		public bool ValidSettings
		{
			get
			{
				return this.pageSetup.usePrinterDefaults;
			}
			set
			{
				this.pageSetup.usePrinterDefaults = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x0001A794 File Offset: 0x00018994
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x0001A7A1 File Offset: 0x000189A1
		public bool NoColor
		{
			get
			{
				return this.pageSetup.blackAndWhite;
			}
			set
			{
				this.pageSetup.blackAndWhite = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0001A7AF File Offset: 0x000189AF
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x0001A7BC File Offset: 0x000189BC
		public bool Draft
		{
			get
			{
				return this.pageSetup.draft;
			}
			set
			{
				this.pageSetup.draft = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0001A7CA File Offset: 0x000189CA
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x0001A7D9 File Offset: 0x000189D9
		public bool Notes
		{
			get
			{
				return this.GetCellComment() == global::NPOI.SS.UserModel.PrintCellComments.AS_DISPLAYED;
			}
			set
			{
				if (value)
				{
					this.pageSetup.cellComments = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellComments.asDisplayed;
				}
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0001A7EA File Offset: 0x000189EA
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x0001A7F9 File Offset: 0x000189F9
		public bool NoOrientation
		{
			get
			{
				return this.Orientation == global::NPOI.SS.UserModel.PrintOrientation.DEFAULT;
			}
			set
			{
				if (value)
				{
					this.Orientation = global::NPOI.SS.UserModel.PrintOrientation.DEFAULT;
				}
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0001A809 File Offset: 0x00018A09
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0001A816 File Offset: 0x00018A16
		public bool UsePage
		{
			get
			{
				return this.pageSetup.useFirstPageNumber;
			}
			set
			{
				this.pageSetup.useFirstPageNumber = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0001A824 File Offset: 0x00018A24
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x0001A832 File Offset: 0x00018A32
		public short HResolution
		{
			get
			{
				return (short)this.pageSetup.horizontalDpi;
			}
			set
			{
				this.pageSetup.horizontalDpi = (uint)value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0001A840 File Offset: 0x00018A40
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x0001A84E File Offset: 0x00018A4E
		public short VResolution
		{
			get
			{
				return (short)this.pageSetup.verticalDpi;
			}
			set
			{
				this.pageSetup.verticalDpi = (uint)value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0001A85C File Offset: 0x00018A5C
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x0001A869 File Offset: 0x00018A69
		public double HeaderMargin
		{
			get
			{
				return this.pageMargins.header;
			}
			set
			{
				this.pageMargins.header = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0001A877 File Offset: 0x00018A77
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x0001A884 File Offset: 0x00018A84
		public double FooterMargin
		{
			get
			{
				return this.pageMargins.footer;
			}
			set
			{
				this.pageMargins.footer = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0001A892 File Offset: 0x00018A92
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x0001A8A0 File Offset: 0x00018AA0
		public short Copies
		{
			get
			{
				return (short)this.pageSetup.copies;
			}
			set
			{
				this.pageSetup.copies = (uint)value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0001A8AE File Offset: 0x00018AAE
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x0001A8BC File Offset: 0x00018ABC
		public global::NPOI.SS.UserModel.DisplayCellErrorType CellError
		{
			get
			{
				return (global::NPOI.SS.UserModel.DisplayCellErrorType)this.pageSetup.errors;
			}
			set
			{
				this.pageSetup.errors = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_PrintError)value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x000065E4 File Offset: 0x000047E4
		public bool EndNote
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x04000309 RID: 777
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet ctWorksheet;

		// Token: 0x0400030A RID: 778
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageSetup pageSetup;

		// Token: 0x0400030B RID: 779
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins pageMargins;
	}
}
