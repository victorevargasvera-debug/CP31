using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200007C RID: 124
	public class XSSFDialogsheet : global::NPOI.XSSF.UserModel.XSSFSheet, global::NPOI.SS.UserModel.ISheet
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x0001694F File Offset: 0x00014B4F
		public XSSFDialogsheet(global::NPOI.XSSF.UserModel.XSSFSheet sheet, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : base(sheet.GetPackagePart(), rel)
		{
			this.dialogsheet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dialogsheet();
			this.worksheet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet();
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00004FF8 File Offset: 0x000031F8
		public override global::NPOI.SS.UserModel.IRow CreateRow(int rowNum)
		{
			return null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00016974 File Offset: 0x00014B74
		protected global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter GetSheetTypeHeaderFooter()
		{
			if (this.dialogsheet.headerFooter == null)
			{
				this.dialogsheet.headerFooter = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter();
			}
			return this.dialogsheet.headerFooter;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0001699E File Offset: 0x00014B9E
		protected global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr GetSheetTypeSheetPr()
		{
			if (this.dialogsheet.sheetPr == null)
			{
				this.dialogsheet.sheetPr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetPr();
			}
			return this.dialogsheet.sheetPr;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00004FF8 File Offset: 0x000031F8
		protected global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak GetSheetTypeColumnBreaks()
		{
			return null;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000169C8 File Offset: 0x00014BC8
		protected global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr GetSheetTypeSheetFormatPr()
		{
			if (this.dialogsheet.sheetFormatPr == null)
			{
				this.dialogsheet.sheetFormatPr = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetFormatPr();
			}
			return this.dialogsheet.sheetFormatPr;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000169F2 File Offset: 0x00014BF2
		protected global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins GetSheetTypePageMargins()
		{
			if (this.dialogsheet.pageMargins == null)
			{
				this.dialogsheet.pageMargins = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageMargins();
			}
			return this.dialogsheet.pageMargins;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00004FF8 File Offset: 0x000031F8
		protected global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageBreak GetSheetTypeRowBreaks()
		{
			return null;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00016A1C File Offset: 0x00014C1C
		protected global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews GetSheetTypeSheetViews()
		{
			if (this.dialogsheet.sheetViews == null)
			{
				this.dialogsheet.sheetViews = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetViews();
				this.dialogsheet.sheetViews.AddNewSheetView();
			}
			return this.dialogsheet.sheetViews;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00016A57 File Offset: 0x00014C57
		protected global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions GetSheetTypePrintOptions()
		{
			if (this.dialogsheet.printOptions == null)
			{
				this.dialogsheet.printOptions = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PrintOptions();
			}
			return this.dialogsheet.printOptions;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00016A81 File Offset: 0x00014C81
		protected global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection GetSheetTypeProtection()
		{
			if (this.dialogsheet.sheetProtection == null)
			{
				this.dialogsheet.sheetProtection = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection();
			}
			return this.dialogsheet.sheetProtection;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00006FBA File Offset: 0x000051BA
		public bool GetDialog()
		{
			return true;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.IRow global::NPOI.SS.UserModel.ISheet.CreateRow(int rownum)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.RemoveRow(global::NPOI.SS.UserModel.IRow row)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.IRow global::NPOI.SS.UserModel.ISheet.GetRow(int rownum)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x000065E4 File Offset: 0x000047E4
		int global::NPOI.SS.UserModel.ISheet.PhysicalNumberOfRows
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x000065E4 File Offset: 0x000047E4
		int global::NPOI.SS.UserModel.ISheet.FirstRowNum
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x000065E4 File Offset: 0x000047E4
		int global::NPOI.SS.UserModel.ISheet.LastRowNum
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.ForceFormulaRecalculation
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

		// Token: 0x06000628 RID: 1576 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.SetColumnHidden(int columnIndex, bool hidden)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.IsColumnHidden(int columnIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.SetColumnWidth(int columnIndex, int width)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000065E4 File Offset: 0x000047E4
		int global::NPOI.SS.UserModel.ISheet.GetColumnWidth(int columnIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x000065E4 File Offset: 0x000047E4
		int global::NPOI.SS.UserModel.ISheet.DefaultColumnWidth
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

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x000065E4 File Offset: 0x000047E4
		short global::NPOI.SS.UserModel.ISheet.DefaultRowHeight
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

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x000065E4 File Offset: 0x000047E4
		float global::NPOI.SS.UserModel.ISheet.DefaultRowHeightInPoints
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

		// Token: 0x06000632 RID: 1586 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.ICellStyle global::NPOI.SS.UserModel.ISheet.GetColumnStyle(int column)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000065E4 File Offset: 0x000047E4
		int global::NPOI.SS.UserModel.ISheet.AddMergedRegion(global::NPOI.SS.Util.CellRangeAddress region)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.HorizontallyCenter
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

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.VerticallyCenter
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

		// Token: 0x06000638 RID: 1592 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.RemoveMergedRegion(int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x000065E4 File Offset: 0x000047E4
		int global::NPOI.SS.UserModel.ISheet.NumMergedRegions
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.Util.CellRangeAddress global::NPOI.SS.UserModel.ISheet.GetMergedRegion(int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000065E4 File Offset: 0x000047E4
		global::System.Collections.IEnumerator global::NPOI.SS.UserModel.ISheet.GetRowEnumerator()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.DisplayZeros
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

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.Autobreaks
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

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.DisplayGuts
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

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.FitToPage
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

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.RowSumsBelow
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

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.RowSumsRight
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

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.IsPrintGridlines
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

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.IPrintSetup global::NPOI.SS.UserModel.ISheet.PrintSetup
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.IHeader global::NPOI.SS.UserModel.ISheet.Header
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.IFooter global::NPOI.SS.UserModel.ISheet.Footer
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000065E4 File Offset: 0x000047E4
		double global::NPOI.SS.UserModel.ISheet.GetMargin(global::NPOI.SS.UserModel.MarginType margin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.SetMargin(global::NPOI.SS.UserModel.MarginType margin, double size)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.Protect
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.ProtectSheet(string password)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.ScenarioProtect
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x000065E4 File Offset: 0x000047E4
		short global::NPOI.SS.UserModel.ISheet.TabColorIndex
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

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.IDrawing global::NPOI.SS.UserModel.ISheet.DrawingPatriarch
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.SetZoom(int numerator, int denominator)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x000065E4 File Offset: 0x000047E4
		short global::NPOI.SS.UserModel.ISheet.TopRow
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

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x000065E4 File Offset: 0x000047E4
		short global::NPOI.SS.UserModel.ISheet.LeftCol
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

		// Token: 0x0600065A RID: 1626 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.ShiftRows(int startRow, int endRow, int n)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.ShiftRows(int startRow, int endRow, int n, bool copyRowHeight, bool resetOriginalRowHeight)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.CreateFreezePane(int colSplit, int rowSplit, int leftmostColumn, int topRow)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.CreateFreezePane(int colSplit, int rowSplit)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.CreateSplitPane(int xSplitPos, int ySplitPos, int leftmostColumn, int topRow, global::NPOI.SS.UserModel.PanePosition activePane)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.Util.PaneInformation global::NPOI.SS.UserModel.ISheet.PaneInformation
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.DisplayGridlines
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.DisplayFormulas
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.DisplayRowColHeadings
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.IsActive
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

		// Token: 0x06000668 RID: 1640 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.IsRowBroken(int row)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.RemoveRowBreak(int row)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x000065E4 File Offset: 0x000047E4
		int[] global::NPOI.SS.UserModel.ISheet.RowBreaks
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000065E4 File Offset: 0x000047E4
		int[] global::NPOI.SS.UserModel.ISheet.ColumnBreaks
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.SetActiveCellRange(int firstRow, int lastRow, int firstColumn, int lastColumn)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.SetActiveCellRange(global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress8Bit> cellranges, int activeRange, int activeRow, int activeColumn)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.SetColumnBreak(int column)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.SetRowBreak(int row)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.IsColumnBroken(int column)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.RemoveColumnBreak(int column)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.SetColumnGroupCollapsed(int columnNumber, bool collapsed)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.GroupColumn(int fromColumn, int toColumn)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.UngroupColumn(int fromColumn, int toColumn)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.GroupRow(int fromRow, int toRow)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.UngroupRow(int fromRow, int toRow)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.SetRowGroupCollapsed(int row, bool collapse)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.SetDefaultColumnStyle(int column, global::NPOI.SS.UserModel.ICellStyle style)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.AutoSizeColumn(int column)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.AutoSizeColumn(int column, bool useMergedCells)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.IComment global::NPOI.SS.UserModel.ISheet.GetCellComment(int row, int column)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.IDrawing global::NPOI.SS.UserModel.ISheet.CreateDrawingPatriarch()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.IWorkbook global::NPOI.SS.UserModel.ISheet.Workbook
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000065E4 File Offset: 0x000047E4
		string global::NPOI.SS.UserModel.ISheet.SheetName
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.IsSelected
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

		// Token: 0x06000681 RID: 1665 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.SetActive(bool sel)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> global::NPOI.SS.UserModel.ISheet.SetArrayFormula(string formula, global::NPOI.SS.Util.CellRangeAddress range)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> global::NPOI.SS.UserModel.ISheet.RemoveArrayFormula(global::NPOI.SS.UserModel.ICell cell)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000065E4 File Offset: 0x000047E4
		bool global::NPOI.SS.UserModel.ISheet.IsMergedRegion(global::NPOI.SS.Util.CellRangeAddress mergedRegion)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.IDataValidationHelper global::NPOI.SS.UserModel.ISheet.GetDataValidationHelper()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000065E4 File Offset: 0x000047E4
		void global::NPOI.SS.UserModel.ISheet.AddValidationData(global::NPOI.SS.UserModel.IDataValidation dataValidation)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.IAutoFilter global::NPOI.SS.UserModel.ISheet.SetAutoFilter(global::NPOI.SS.Util.CellRangeAddress range)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x000065E4 File Offset: 0x000047E4
		global::NPOI.SS.UserModel.ISheetConditionalFormatting global::NPOI.SS.UserModel.ISheet.SheetConditionalFormatting
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x000065E4 File Offset: 0x000047E4
		private new bool IsRightToLeft
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

		// Token: 0x040002CF RID: 719
		protected global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dialogsheet dialogsheet;
	}
}
