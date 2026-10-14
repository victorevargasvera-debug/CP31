using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using NPOI.DDF;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Aggregates;
using NPOI.HSSF.Record.AutoFilter;
using NPOI.HSSF.UserModel.helpers;
using NPOI.HSSF.Util;
using NPOI.SS;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200038B RID: 907
	[global::System.Serializable]
	public class HSSFSheet : global::NPOI.SS.UserModel.ISheet
	{
		// Token: 0x06001D98 RID: 7576 RVA: 0x00059C91 File Offset: 0x00057E91
		public HSSFSheet(global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			this._sheet = global::NPOI.HSSF.Model.InternalSheet.CreateSheet();
			this.rows = new global::System.Collections.Generic.Dictionary<int, global::NPOI.SS.UserModel.IRow>();
			this._workbook = workbook;
			this.book = workbook.Workbook;
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00059CC2 File Offset: 0x00057EC2
		public HSSFSheet(global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, global::NPOI.HSSF.Model.InternalSheet sheet)
		{
			this._sheet = sheet;
			this.rows = new global::System.Collections.Generic.Dictionary<int, global::NPOI.SS.UserModel.IRow>();
			this._workbook = workbook;
			this.book = this._workbook.Workbook;
			this.SetPropertiesFromSheet(this._sheet);
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00059D00 File Offset: 0x00057F00
		public global::NPOI.SS.UserModel.ISheet CloneSheet(global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			global::NPOI.SS.UserModel.IDrawing drawingPatriarch = this.DrawingPatriarch;
			global::NPOI.HSSF.UserModel.HSSFSheet hssfsheet = new global::NPOI.HSSF.UserModel.HSSFSheet(workbook, this._sheet.CloneSheet());
			int index = hssfsheet._sheet.FindFirstRecordLocBySid(236);
			global::NPOI.HSSF.Record.DrawingRecord drawingRecord = (global::NPOI.HSSF.Record.DrawingRecord)hssfsheet._sheet.FindFirstRecordBySid(236);
			if (drawingRecord != null)
			{
				hssfsheet._sheet.Records.Remove(drawingRecord);
			}
			if (this.DrawingPatriarch != null)
			{
				global::NPOI.HSSF.UserModel.HSSFPatriarch hssfpatriarch = global::NPOI.HSSF.UserModel.HSSFPatriarch.CreatePatriarch(this.DrawingPatriarch as global::NPOI.HSSF.UserModel.HSSFPatriarch, hssfsheet);
				hssfsheet._sheet.Records.Insert(index, hssfpatriarch.GetBoundAggregate());
				hssfsheet._patriarch = hssfpatriarch;
			}
			return hssfsheet;
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00059D9B File Offset: 0x00057F9B
		internal void PreSerialize()
		{
			if (this._patriarch != null)
			{
				this._patriarch.PreSerialize();
			}
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00059DB0 File Offset: 0x00057FB0
		public global::NPOI.SS.UserModel.IRow CopyRow(int sourceIndex, int targetIndex)
		{
			return global::NPOI.SS.Util.SheetUtil.CopyRow(this, sourceIndex, targetIndex);
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00059DBC File Offset: 0x00057FBC
		private void SetPropertiesFromSheet(global::NPOI.HSSF.Model.InternalSheet sheet)
		{
			for (global::NPOI.HSSF.Record.RowRecord nextRow = sheet.NextRow; nextRow != null; nextRow = sheet.NextRow)
			{
				this.CreateRowFromRecord(nextRow);
			}
			global::System.Collections.Generic.IEnumerator<global::NPOI.HSSF.Record.CellValueRecordInterface> cellValueIterator = sheet.GetCellValueIterator();
			int millisecond = global::System.DateTime.Now.Millisecond;
			global::NPOI.HSSF.UserModel.HSSFRow hssfrow = null;
			while (cellValueIterator.MoveNext())
			{
				global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecordInterface = cellValueIterator.Current;
				int millisecond2 = global::System.DateTime.Now.Millisecond;
				global::NPOI.HSSF.UserModel.HSSFRow hssfrow2 = hssfrow;
				if (hssfrow == null || hssfrow.RowNum != cellValueRecordInterface.Row)
				{
					hssfrow2 = (global::NPOI.HSSF.UserModel.HSSFRow)this.GetRow(cellValueRecordInterface.Row);
					if (hssfrow2 == null)
					{
						global::NPOI.HSSF.Record.RowRecord row = new global::NPOI.HSSF.Record.RowRecord(cellValueRecordInterface.Row);
						this._sheet.AddRow(row);
						hssfrow2 = this.CreateRowFromRecord(row);
					}
				}
				if (hssfrow2 != null)
				{
					hssfrow = hssfrow2;
					hssfrow2.CreateCellFromRecord(cellValueRecordInterface);
				}
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x00059E86 File Offset: 0x00058086
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x00059E98 File Offset: 0x00058098
		public bool DisplayZeros
		{
			get
			{
				return this._sheet.WindowTwo.DisplayZeros;
			}
			set
			{
				this._sheet.WindowTwo.DisplayZeros = value;
			}
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00059EAC File Offset: 0x000580AC
		public global::NPOI.SS.UserModel.IRow CreateRow(int rownum)
		{
			global::NPOI.HSSF.UserModel.HSSFRow hssfrow = new global::NPOI.HSSF.UserModel.HSSFRow(this._workbook, this, rownum);
			hssfrow.Height = this.DefaultRowHeight;
			hssfrow.RowRecord.BadFontHeight = false;
			this.AddRow(hssfrow, true);
			return hssfrow;
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00059EE8 File Offset: 0x000580E8
		private global::NPOI.HSSF.UserModel.HSSFRow CreateRowFromRecord(global::NPOI.HSSF.Record.RowRecord row)
		{
			global::NPOI.HSSF.UserModel.HSSFRow hssfrow = new global::NPOI.HSSF.UserModel.HSSFRow(this._workbook, this, row);
			this.AddRow(hssfrow, false);
			return hssfrow;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00059F0C File Offset: 0x0005810C
		public void RemoveRow(global::NPOI.SS.UserModel.IRow row)
		{
			global::NPOI.HSSF.UserModel.HSSFRow hssfrow = (global::NPOI.HSSF.UserModel.HSSFRow)row;
			if (row.Sheet != this)
			{
				throw new global::System.ArgumentException("Specified row does not belong to this sheet");
			}
			foreach (global::NPOI.SS.UserModel.ICell cell in row)
			{
				global::NPOI.HSSF.UserModel.HSSFCell hssfcell = (global::NPOI.HSSF.UserModel.HSSFCell)cell;
				if (hssfcell.IsPartOfArrayFormulaGroup)
				{
					string msg = "Row[rownum=" + row.RowNum.ToString() + "] contains cell(s) included in a multi-cell array formula. You cannot change part of an array.";
					hssfcell.NotifyArrayFormulaChanging(msg);
				}
			}
			if (this.rows.Count > 0)
			{
				int rowNum = row.RowNum;
				global::NPOI.HSSF.UserModel.HSSFRow hssfrow2 = (global::NPOI.HSSF.UserModel.HSSFRow)this.rows[rowNum];
				this.rows.Remove(rowNum);
				if (hssfrow2 != row)
				{
					if (hssfrow2 != null)
					{
						this.rows[rowNum] = hssfrow2;
					}
					throw new global::System.InvalidOperationException("Specified row does not belong to this _sheet");
				}
				if (hssfrow.RowNum == this.LastRowNum)
				{
					this.lastrow = this.FindLastRow(this.lastrow);
				}
				if (hssfrow.RowNum == this.FirstRowNum)
				{
					this.firstrow = this.FindFirstRow(this.firstrow);
				}
				this._sheet.RemoveRow(hssfrow.RowRecord);
			}
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x0005A04C File Offset: 0x0005824C
		private int FindLastRow(int lastrow)
		{
			if (lastrow < 1)
			{
				return 0;
			}
			int num = lastrow - 1;
			global::NPOI.SS.UserModel.IRow row = this.GetRow(num);
			while (row == null && num > 0)
			{
				row = this.GetRow(--num);
			}
			if (row == null)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x0005A088 File Offset: 0x00058288
		private int FindFirstRow(int firstrow)
		{
			int num = firstrow + 1;
			global::NPOI.SS.UserModel.IRow row = this.GetRow(num);
			while (row == null && num <= this.LastRowNum)
			{
				row = this.GetRow(++num);
			}
			if (num > this.LastRowNum)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x0005A0C8 File Offset: 0x000582C8
		private void AddRow(global::NPOI.HSSF.UserModel.HSSFRow row, bool addLow)
		{
			this.rows[row.RowNum] = row;
			if (addLow)
			{
				this._sheet.AddRow(row.RowRecord);
			}
			bool flag = this.rows.Count == 1;
			if (row.RowNum > this.LastRowNum || flag)
			{
				this.lastrow = row.RowNum;
			}
			if (row.RowNum < this.FirstRowNum || flag)
			{
				this.firstrow = row.RowNum;
			}
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x0005A148 File Offset: 0x00058348
		public global::NPOI.SS.UserModel.ICellStyle GetColumnStyle(int column)
		{
			short xfindexForColAt = this._sheet.GetXFIndexForColAt((short)column);
			if (xfindexForColAt == 15)
			{
				return null;
			}
			global::NPOI.HSSF.Record.ExtendedFormatRecord exFormatAt = this.book.GetExFormatAt((int)xfindexForColAt);
			return new global::NPOI.HSSF.UserModel.HSSFCellStyle(xfindexForColAt, exFormatAt, this.book);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x0005A184 File Offset: 0x00058384
		public global::NPOI.SS.UserModel.IRow GetRow(int rowIndex)
		{
			if (!this.rows.ContainsKey(rowIndex))
			{
				return null;
			}
			return (global::NPOI.HSSF.UserModel.HSSFRow)this.rows[rowIndex];
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x0005A1A7 File Offset: 0x000583A7
		public int PhysicalNumberOfRows
		{
			get
			{
				return this.rows.Count;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x0005A1B4 File Offset: 0x000583B4
		public int FirstRowNum
		{
			get
			{
				return this.firstrow;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x0005A1BC File Offset: 0x000583BC
		public int LastRowNum
		{
			get
			{
				return this.lastrow;
			}
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x0005A1C4 File Offset: 0x000583C4
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IDataValidation> GetDataValidations()
		{
			global::NPOI.HSSF.Record.Aggregates.DataValidityTable orCreateDataValidityTable = this._sheet.GetOrCreateDataValidityTable();
			global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IDataValidation> list = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IDataValidation>();
			global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv = new global::NPOI.HSSF.UserModel.HSSFSheet.RecordVisitor1(list, this.Workbook);
			orCreateDataValidityTable.VisitContainedRecords(rv);
			return list;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x0005A1F8 File Offset: 0x000583F8
		public void AddValidationData(global::NPOI.SS.UserModel.IDataValidation dataValidation)
		{
			if (dataValidation == null)
			{
				throw new global::System.ArgumentException("objValidation must not be null");
			}
			global::NPOI.HSSF.UserModel.HSSFDataValidation hssfdataValidation = (global::NPOI.HSSF.UserModel.HSSFDataValidation)dataValidation;
			global::NPOI.HSSF.Record.Aggregates.DataValidityTable orCreateDataValidityTable = this._sheet.GetOrCreateDataValidityTable();
			global::NPOI.HSSF.Record.DVRecord dvRecord = hssfdataValidation.CreateDVRecord(this);
			orCreateDataValidityTable.AddDataValidation(dvRecord);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x0005A233 File Offset: 0x00058433
		public void SetColumnHidden(int column, bool hidden)
		{
			this._sheet.SetColumnHidden(column, hidden);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x0005A242 File Offset: 0x00058442
		public bool IsColumnHidden(int column)
		{
			return this._sheet.IsColumnHidden(column);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x0005A250 File Offset: 0x00058450
		public void SetColumnWidth(int column, int width)
		{
			this._sheet.SetColumnWidth(column, width);
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x0005A25F File Offset: 0x0005845F
		public int GetColumnWidth(int column)
		{
			return this._sheet.GetColumnWidth(column);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x0005A270 File Offset: 0x00058470
		public float GetColumnWidthInPixels(int column)
		{
			int columnWidth = this.GetColumnWidth(column);
			int num = this.DefaultColumnWidth * 256;
			float num2 = (columnWidth == num) ? global::NPOI.HSSF.UserModel.HSSFSheet.PX_DEFAULT : global::NPOI.HSSF.UserModel.HSSFSheet.PX_MODIFIED;
			return (float)columnWidth / num2;
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x0005A2A5 File Offset: 0x000584A5
		// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x0005A2B2 File Offset: 0x000584B2
		public int DefaultColumnWidth
		{
			get
			{
				return this._sheet.DefaultColumnWidth;
			}
			set
			{
				this._sheet.DefaultColumnWidth = value;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x0005A2C0 File Offset: 0x000584C0
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x0005A2CD File Offset: 0x000584CD
		public short DefaultRowHeight
		{
			get
			{
				return this._sheet.DefaultRowHeight;
			}
			set
			{
				this._sheet.DefaultRowHeight = value;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x0005A2DB File Offset: 0x000584DB
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x0005A2F4 File Offset: 0x000584F4
		public float DefaultRowHeightInPoints
		{
			get
			{
				return (float)((double)this._sheet.DefaultRowHeight / 20.0);
			}
			set
			{
				this._sheet.DefaultRowHeight = (short)((double)value * 20.0);
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x0005A30E File Offset: 0x0005850E
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x0005A31B File Offset: 0x0005851B
		[global::System.Obsolete("Please use IsPrintGridlines instead")]
		public bool IsGridsPrinted
		{
			get
			{
				return this._sheet.IsGridsPrinted;
			}
			set
			{
				this._sheet.IsGridsPrinted = value;
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x0005A329 File Offset: 0x00058529
		public int AddMergedRegion(global::NPOI.SS.Util.CellRangeAddress region)
		{
			return this.AddMergedRegion(region, true);
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x0005A333 File Offset: 0x00058533
		public int AddMergedRegionUnsafe(global::NPOI.SS.Util.CellRangeAddress region)
		{
			return this.AddMergedRegion(region, false);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x0005A33D File Offset: 0x0005853D
		public void ValidateMergedRegions()
		{
			this.CheckForMergedRegionsIntersectingArrayFormulas();
			this.CheckForIntersectingMergedRegions();
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x0005A34C File Offset: 0x0005854C
		private int AddMergedRegion(global::NPOI.SS.Util.CellRangeAddress region, bool validate)
		{
			if (region.NumberOfCells < 2)
			{
				throw new global::System.ArgumentException("Merged region " + region.FormatAsString() + " must contain 2 or more cells");
			}
			if (validate)
			{
				region.Validate(global::NPOI.SS.SpreadsheetVersion.EXCEL97);
				this.ValidateArrayFormulas(region);
				this.ValidateMergedRegions(region);
			}
			return this._sheet.AddMergedRegion(region.FirstRow, region.FirstColumn, region.LastRow, region.LastColumn);
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x0005A3BC File Offset: 0x000585BC
		private void ValidateArrayFormulas(global::NPOI.SS.Util.CellRangeAddress region)
		{
			int firstRow = region.FirstRow;
			int firstColumn = region.FirstColumn;
			int lastRow = region.LastRow;
			int lastColumn = region.LastColumn;
			for (int i = firstRow; i <= lastRow; i++)
			{
				global::NPOI.HSSF.UserModel.HSSFRow hssfrow = (global::NPOI.HSSF.UserModel.HSSFRow)this.GetRow(i);
				if (hssfrow != null)
				{
					for (int j = firstColumn; j <= lastColumn; j++)
					{
						global::NPOI.HSSF.UserModel.HSSFCell hssfcell = (global::NPOI.HSSF.UserModel.HSSFCell)hssfrow.GetCell(j);
						if (hssfcell != null && hssfcell.IsPartOfArrayFormulaGroup)
						{
							global::NPOI.SS.Util.CellRangeAddress arrayFormulaRange = hssfcell.ArrayFormulaRange;
							if (arrayFormulaRange.NumberOfCells > 1 && region.Intersects(arrayFormulaRange))
							{
								throw new global::System.InvalidOperationException("The range " + region.FormatAsString() + " intersects with a multi-cell array formula. You cannot merge cells of an array.");
							}
						}
					}
				}
			}
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0005A468 File Offset: 0x00058668
		private void CheckForMergedRegionsIntersectingArrayFormulas()
		{
			foreach (global::NPOI.SS.Util.CellRangeAddress region in this.MergedRegions)
			{
				this.ValidateArrayFormulas(region);
			}
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0005A4BC File Offset: 0x000586BC
		private void ValidateMergedRegions(global::NPOI.SS.Util.CellRangeAddress candidateRegion)
		{
			foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in this.MergedRegions)
			{
				if (cellRangeAddress.Intersects(candidateRegion))
				{
					throw new global::System.InvalidOperationException(string.Concat(new string[]
					{
						"Cannot add merged region ",
						candidateRegion.FormatAsString(),
						" to sheet because it overlaps with an existing merged region (",
						cellRangeAddress.FormatAsString(),
						")."
					}));
				}
			}
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0005A54C File Offset: 0x0005874C
		private void CheckForIntersectingMergedRegions()
		{
			global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> mergedRegions = this.MergedRegions;
			int count = mergedRegions.Count;
			for (int i = 0; i < count; i++)
			{
				global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = mergedRegions[i];
				foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress2 in mergedRegions.GetRange(i + 1, mergedRegions.Count - i - 1))
				{
					if (cellRangeAddress.Intersects(cellRangeAddress2))
					{
						throw new global::System.InvalidOperationException(string.Concat(new string[]
						{
							"The range ",
							cellRangeAddress.FormatAsString(),
							" intersects with another merged region ",
							cellRangeAddress2.FormatAsString(),
							" in this sheet"
						}));
					}
				}
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x0005A618 File Offset: 0x00058818
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x0005A625 File Offset: 0x00058825
		public bool ForceFormulaRecalculation
		{
			get
			{
				return this._sheet.IsUncalced;
			}
			set
			{
				this._sheet.IsUncalced = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x0005A633 File Offset: 0x00058833
		// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x0005A64A File Offset: 0x0005884A
		public bool VerticallyCenter
		{
			get
			{
				return this._sheet.PageSettings.VCenter.VCenter;
			}
			set
			{
				this._sheet.PageSettings.VCenter.VCenter = value;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x0005A662 File Offset: 0x00058862
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x0005A679 File Offset: 0x00058879
		public bool HorizontallyCenter
		{
			get
			{
				return this._sheet.PageSettings.HCenter.HCenter;
			}
			set
			{
				this._sheet.PageSettings.HCenter.HCenter = value;
			}
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x0005A691 File Offset: 0x00058891
		public void RemoveMergedRegion(int index)
		{
			this._sheet.RemoveMergedRegion(index);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x0005A6A0 File Offset: 0x000588A0
		public void RemoveMergedRegions(global::System.Collections.Generic.IList<int> indices)
		{
			foreach (int index in new global::System.Collections.Generic.SortedSet<int>(indices, new global::NPOI.HSSF.UserModel.HSSFSheet.Int32Comparer()))
			{
				this._sheet.RemoveMergedRegion(index);
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x0005A700 File Offset: 0x00058900
		public int NumMergedRegions
		{
			get
			{
				return this._sheet.NumMergedRegions;
			}
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x0005A70D File Offset: 0x0005890D
		public global::System.Collections.IEnumerator GetRowEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0005A715 File Offset: 0x00058915
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this.rows.Values.GetEnumerator();
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x0005A72C File Offset: 0x0005892C
		public global::NPOI.HSSF.Model.InternalSheet Sheet
		{
			get
			{
				return this._sheet;
			}
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x0005A734 File Offset: 0x00058934
		public void SetActiveCell(int row, int column)
		{
			this._sheet.SetActiveCellRange(row, row, column, column);
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x0005A745 File Offset: 0x00058945
		public void SetActiveCellRange(int firstRow, int lastRow, int firstColumn, int lastColumn)
		{
			this._sheet.SetActiveCellRange(firstRow, lastRow, firstColumn, lastColumn);
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0005A757 File Offset: 0x00058957
		public void SetActiveCellRange(global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress8Bit> cellranges, int activeRange, int activeRow, int activeColumn)
		{
			this._sheet.SetActiveCellRange(cellranges, activeRange, activeRow, activeColumn);
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x0005A769 File Offset: 0x00058969
		// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x0005A785 File Offset: 0x00058985
		public bool AlternativeExpression
		{
			get
			{
				return ((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).AlternateExpression;
			}
			set
			{
				((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).AlternateExpression = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x0005A7A2 File Offset: 0x000589A2
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x0005A7BE File Offset: 0x000589BE
		public bool AlternativeFormula
		{
			get
			{
				return ((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).AlternateFormula;
			}
			set
			{
				((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).AlternateFormula = value;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x0005A7DB File Offset: 0x000589DB
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x0005A7F7 File Offset: 0x000589F7
		public bool Autobreaks
		{
			get
			{
				return ((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).Autobreaks;
			}
			set
			{
				((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).Autobreaks = value;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x0005A814 File Offset: 0x00058A14
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x0005A830 File Offset: 0x00058A30
		public bool Dialog
		{
			get
			{
				return ((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).Dialog;
			}
			set
			{
				((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).Dialog = value;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x0005A84D File Offset: 0x00058A4D
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x0005A869 File Offset: 0x00058A69
		public bool DisplayGuts
		{
			get
			{
				return ((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).DisplayGuts;
			}
			set
			{
				((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).DisplayGuts = value;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x0005A886 File Offset: 0x00058A86
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x0005A8A2 File Offset: 0x00058AA2
		public bool FitToPage
		{
			get
			{
				return ((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).FitToPage;
			}
			set
			{
				((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).FitToPage = value;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0005A8BF File Offset: 0x00058ABF
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x0005A8DB File Offset: 0x00058ADB
		public bool RowSumsBelow
		{
			get
			{
				return ((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).RowSumsBelow;
			}
			set
			{
				((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).RowSumsBelow = value;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x0005A8F8 File Offset: 0x00058AF8
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x0005A914 File Offset: 0x00058B14
		public bool RowSumsRight
		{
			get
			{
				return ((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).RowSumsRight;
			}
			set
			{
				((global::NPOI.HSSF.Record.WSBoolRecord)this._sheet.FindFirstRecordBySid(129)).RowSumsRight = value;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x0005A931 File Offset: 0x00058B31
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x0005A943 File Offset: 0x00058B43
		public bool IsPrintGridlines
		{
			get
			{
				return this.Sheet.PrintGridlines.PrintGridlines;
			}
			set
			{
				this.Sheet.PrintGridlines.PrintGridlines = value;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x0005A956 File Offset: 0x00058B56
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x0005A968 File Offset: 0x00058B68
		public bool IsPrintRowAndColumnHeadings
		{
			get
			{
				return this.Sheet.PrintHeaders.PrintHeaders;
			}
			set
			{
				this.Sheet.PrintHeaders.PrintHeaders = value;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x0005A97B File Offset: 0x00058B7B
		public global::NPOI.SS.UserModel.IPrintSetup PrintSetup
		{
			get
			{
				return new global::NPOI.HSSF.UserModel.HSSFPrintSetup(this._sheet.PageSettings.PrintSetup);
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x0005A992 File Offset: 0x00058B92
		public global::NPOI.SS.UserModel.IHeader Header
		{
			get
			{
				return new global::NPOI.HSSF.UserModel.HSSFHeader(this._sheet.PageSettings);
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x0005A9A4 File Offset: 0x00058BA4
		public global::NPOI.SS.UserModel.IFooter Footer
		{
			get
			{
				return new global::NPOI.HSSF.UserModel.HSSFFooter(this._sheet.PageSettings);
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x0005A9B6 File Offset: 0x00058BB6
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x0005A9C8 File Offset: 0x00058BC8
		public bool IsRightToLeft
		{
			get
			{
				return this._sheet.WindowTwo.Arabic;
			}
			set
			{
				this._sheet.WindowTwo.Arabic = value;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x0005A9DB File Offset: 0x00058BDB
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x0005A9ED File Offset: 0x00058BED
		public bool IsSelected
		{
			get
			{
				return this.Sheet.GetWindowTwo().IsSelected;
			}
			set
			{
				this.Sheet.GetWindowTwo().IsSelected = value;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x0005AA00 File Offset: 0x00058C00
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x0005AA12 File Offset: 0x00058C12
		public bool IsActive
		{
			get
			{
				return this.Sheet.GetWindowTwo().IsActive;
			}
			set
			{
				this.Sheet.GetWindowTwo().IsActive = value;
			}
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0005AA25 File Offset: 0x00058C25
		public void SetActive(bool sel)
		{
			this.Sheet.WindowTwo.IsActive = sel;
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x0005AA38 File Offset: 0x00058C38
		private global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock ProtectionBlock
		{
			get
			{
				return this._sheet.ProtectionBlock;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x0005AA45 File Offset: 0x00058C45
		public bool Protect
		{
			get
			{
				return this.ProtectionBlock.IsSheetProtected;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x0005AA52 File Offset: 0x00058C52
		public short Password
		{
			get
			{
				return (short)this.ProtectionBlock.PasswordHash;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x0005AA60 File Offset: 0x00058C60
		public bool ObjectProtect
		{
			get
			{
				return this.ProtectionBlock.IsObjectProtected;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x0005AA6D File Offset: 0x00058C6D
		public bool ScenarioProtect
		{
			get
			{
				return this.ProtectionBlock.IsScenarioProtected;
			}
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0005AA7A File Offset: 0x00058C7A
		public void ProtectSheet(string password)
		{
			this.ProtectionBlock.ProtectSheet(password, true, true);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0005AA8C File Offset: 0x00058C8C
		[global::System.Obsolete("deprecated 2015-11-23 (circa POI 3.14beta1). Use {@link #setZoom(int)} instead.")]
		public void SetZoom(int numerator, int denominator)
		{
			if (numerator < 1 || numerator > 65535)
			{
				throw new global::System.ArgumentException("Numerator must be greater than 0 and less than 65536");
			}
			if (denominator < 1 || denominator > 65535)
			{
				throw new global::System.ArgumentException("Denominator must be greater than 0 and less than 65536");
			}
			global::NPOI.HSSF.Record.SCLRecord sclrecord = new global::NPOI.HSSF.Record.SCLRecord();
			sclrecord.Numerator = (short)numerator;
			sclrecord.Denominator = (short)denominator;
			this.Sheet.SetSCLRecord(sclrecord);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x0005AAE9 File Offset: 0x00058CE9
		public void SetZoom(int scale)
		{
			this.SetZoom(scale, 100);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0005AAF4 File Offset: 0x00058CF4
		public void SetEnclosedBorderOfRegion(global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.BorderStyle borderType, short color)
		{
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetRightBorderColor((int)color, region, this, this._workbook);
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetBorderRight(borderType, region, this, this._workbook);
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetLeftBorderColor((int)color, region, this, this._workbook);
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetBorderLeft(borderType, region, this, this._workbook);
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetTopBorderColor((int)color, region, this, this._workbook);
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetBorderTop(borderType, region, this, this._workbook);
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetBottomBorderColor((int)color, region, this, this._workbook);
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetBorderBottom(borderType, region, this, this._workbook);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0005AB71 File Offset: 0x00058D71
		public void SetBorderRightOfRegion(global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.BorderStyle borderType, short color)
		{
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetRightBorderColor((int)color, region, this, this._workbook);
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetBorderRight(borderType, region, this, this._workbook);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x0005AB8F File Offset: 0x00058D8F
		public void SetBorderLeftOfRegion(global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.BorderStyle borderType, short color)
		{
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetLeftBorderColor((int)color, region, this, this._workbook);
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetBorderLeft(borderType, region, this, this._workbook);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x0005ABAD File Offset: 0x00058DAD
		public void SetBorderTopOfRegion(global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.BorderStyle borderType, short color)
		{
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetTopBorderColor((int)color, region, this, this._workbook);
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetBorderTop(borderType, region, this, this._workbook);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x0005ABCB File Offset: 0x00058DCB
		public void SetBorderBottomOfRegion(global::NPOI.SS.Util.CellRangeAddress region, global::NPOI.SS.UserModel.BorderStyle borderType, short color)
		{
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetBottomBorderColor((int)color, region, this, this._workbook);
			global::NPOI.HSSF.Util.HSSFRegionUtil.SetBorderBottom(borderType, region, this, this._workbook);
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x0005ABE9 File Offset: 0x00058DE9
		// (set) Token: 0x06001DFD RID: 7677 RVA: 0x0005ABF6 File Offset: 0x00058DF6
		public short TopRow
		{
			get
			{
				return this._sheet.TopRow;
			}
			set
			{
				this._sheet.TopRow = value;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x0005AC04 File Offset: 0x00058E04
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x0005AC11 File Offset: 0x00058E11
		public short LeftCol
		{
			get
			{
				return this._sheet.LeftCol;
			}
			set
			{
				this._sheet.LeftCol = value;
			}
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x0005AC20 File Offset: 0x00058E20
		public void ShowInPane(int toprow, int leftcol)
		{
			int lastRowIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastRowIndex;
			if (toprow > lastRowIndex)
			{
				throw new global::System.ArgumentException("Maximum row number is " + lastRowIndex.ToString());
			}
			this.ShowInPane((short)toprow, (short)leftcol);
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0005AC5D File Offset: 0x00058E5D
		public void ShowInPane(short toprow, short leftcol)
		{
			this._sheet.TopRow = toprow;
			this._sheet.LeftCol = leftcol;
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0005AC77 File Offset: 0x00058E77
		[global::System.Obsolete("deprecated POI 3.15 beta 2. This will be made private in future releases.")]
		protected void ShiftMerged(int startRow, int endRow, int n, bool IsRow)
		{
			new global::NPOI.HSSF.UserModel.helpers.HSSFRowShifter(this).ShiftMergedRegions(startRow, endRow, n);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0005AC88 File Offset: 0x00058E88
		public void ShiftRows(int startRow, int endRow, int n)
		{
			this.ShiftRows(startRow, endRow, n, false, false);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x0005AC95 File Offset: 0x00058E95
		public void ShiftRows(int startRow, int endRow, int n, bool copyRowHeight, bool resetOriginalRowHeight)
		{
			this.ShiftRows(startRow, endRow, n, copyRowHeight, resetOriginalRowHeight, true);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0005ACA8 File Offset: 0x00058EA8
		public void ShiftRows(int startRow, int endRow, int n, bool copyRowHeight, bool resetOriginalRowHeight, bool moveComments)
		{
			if (endRow < startRow)
			{
				throw new global::System.ArgumentException("startRow must be less than or equal to endRow. To shift rows up, use n<0.");
			}
			int num;
			int num2;
			if (n < 0)
			{
				num = startRow;
				num2 = 1;
			}
			else
			{
				if (n <= 0)
				{
					return;
				}
				num = endRow;
				num2 = -1;
			}
			if (moveComments)
			{
				this._sheet.GetNoteRecords();
			}
			else
			{
				global::NPOI.HSSF.Record.NoteRecord[] empty_ARRAY = global::NPOI.HSSF.Record.NoteRecord.EMPTY_ARRAY;
			}
			new global::NPOI.HSSF.UserModel.helpers.HSSFRowShifter(this).ShiftMergedRegions(startRow, endRow, n);
			this._sheet.PageSettings.ShiftRowBreaks(startRow, endRow, n);
			int num3 = startRow + n;
			int num4 = endRow + n;
			foreach (global::NPOI.SS.UserModel.IHyperlink hyperlink in this.GetHyperlinkList())
			{
				global::NPOI.HSSF.UserModel.HSSFHyperlink hssfhyperlink = (global::NPOI.HSSF.UserModel.HSSFHyperlink)hyperlink;
				if (num3 <= hssfhyperlink.FirstRow && hssfhyperlink.FirstRow <= num4 && num4 <= hssfhyperlink.LastRow && hssfhyperlink.LastRow <= num4)
				{
					this.RemoveHyperlink(hssfhyperlink);
				}
			}
			int num5 = num;
			while (num5 >= startRow && num5 <= endRow && num5 >= 0 && num5 < 65536)
			{
				global::NPOI.HSSF.UserModel.HSSFRow hssfrow = (global::NPOI.HSSF.UserModel.HSSFRow)this.GetRow(num5);
				if (hssfrow != null)
				{
					this.NotifyRowShifting(hssfrow);
				}
				global::NPOI.HSSF.UserModel.HSSFRow hssfrow2 = (global::NPOI.HSSF.UserModel.HSSFRow)this.GetRow(num5 + n);
				if (hssfrow2 == null)
				{
					hssfrow2 = (global::NPOI.HSSF.UserModel.HSSFRow)this.CreateRow(num5 + n);
				}
				hssfrow2.RemoveAllCells();
				if (hssfrow != null)
				{
					if (copyRowHeight)
					{
						hssfrow2.Height = hssfrow.Height;
					}
					if (resetOriginalRowHeight)
					{
						hssfrow.Height = 255;
					}
					foreach (global::NPOI.SS.UserModel.ICell cell in hssfrow.Cells)
					{
						hssfrow.RemoveCell(cell);
						global::NPOI.SS.UserModel.IHyperlink hyperlink2 = cell.Hyperlink;
						global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecord = ((global::NPOI.HSSF.UserModel.HSSFCell)cell).CellValueRecord;
						cellValueRecord.Row = num5 + n;
						hssfrow2.CreateCellFromRecord(cellValueRecord);
						this._sheet.AddValueRecord(num5 + n, cellValueRecord);
						if (hyperlink2 != null)
						{
							hyperlink2.FirstRow += n;
							hyperlink2.LastRow += n;
						}
					}
					hssfrow.RemoveAllCells();
					if (moveComments)
					{
						global::NPOI.HSSF.UserModel.HSSFPatriarch hssfpatriarch = this.CreateDrawingPatriarch() as global::NPOI.HSSF.UserModel.HSSFPatriarch;
						for (int i = hssfpatriarch.Children.Count - 1; i >= 0; i--)
						{
							global::NPOI.HSSF.UserModel.HSSFShape hssfshape = hssfpatriarch.Children[i];
							if (hssfshape is global::NPOI.HSSF.UserModel.HSSFComment)
							{
								global::NPOI.HSSF.UserModel.HSSFComment hssfcomment = (global::NPOI.HSSF.UserModel.HSSFComment)hssfshape;
								if (hssfcomment.Row == num5)
								{
									hssfcomment.Row = num5 + n;
								}
							}
						}
					}
				}
				num5 += num2;
			}
			if (n > 0)
			{
				if (startRow == this.firstrow)
				{
					this.firstrow = global::System.Math.Max(startRow + n, 0);
					for (int j = startRow + 1; j < startRow + n; j++)
					{
						if (this.GetRow(j) != null)
						{
							this.firstrow = j;
							break;
						}
					}
				}
				if (endRow + n > this.lastrow)
				{
					this.lastrow = global::System.Math.Min(endRow + n, global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastRowIndex);
				}
			}
			else
			{
				if (startRow + n < this.firstrow)
				{
					this.firstrow = global::System.Math.Max(startRow + n, 0);
				}
				if (endRow == this.lastrow)
				{
					this.lastrow = global::System.Math.Min(endRow + n, global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastRowIndex);
					for (int k = endRow - 1; k > endRow + n; k++)
					{
						if (this.GetRow(k) != null)
						{
							this.lastrow = k;
							break;
						}
					}
				}
			}
			int sheetIndex = this._workbook.GetSheetIndex(this);
			string sheetName = this._workbook.GetSheetName(sheetIndex);
			int externSheetIndex = this.book.CheckExternSheet(sheetIndex);
			global::NPOI.SS.Formula.FormulaShifter shifter = global::NPOI.SS.Formula.FormulaShifter.CreateForRowShift(externSheetIndex, sheetName, startRow, endRow, n, global::NPOI.SS.SpreadsheetVersion.EXCEL97);
			this._sheet.UpdateFormulasAfterCellShift(shifter, externSheetIndex);
			int numberOfSheets = this._workbook.NumberOfSheets;
			for (int l = 0; l < numberOfSheets; l++)
			{
				global::NPOI.HSSF.Model.InternalSheet sheet = ((global::NPOI.HSSF.UserModel.HSSFSheet)this._workbook.GetSheetAt(l)).Sheet;
				if (sheet != this._sheet)
				{
					int externSheetIndex2 = this.book.CheckExternSheet(l);
					sheet.UpdateFormulasAfterCellShift(shifter, externSheetIndex2);
				}
			}
			this._workbook.Workbook.UpdateNamesAfterCellShift(shifter);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x0005B0C8 File Offset: 0x000592C8
		public void InsertChartRecords(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records)
		{
			int index = this._sheet.FindFirstRecordLocBySid(574);
			this._sheet.Records.InsertRange(index, records);
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x0005B0F8 File Offset: 0x000592F8
		private void NotifyRowShifting(global::NPOI.HSSF.UserModel.HSSFRow row)
		{
			string msg = "Row[rownum=" + row.RowNum.ToString() + "] contains cell(s) included in a multi-cell array formula. You cannot change part of an array.";
			foreach (global::NPOI.SS.UserModel.ICell cell in row.Cells)
			{
				global::NPOI.HSSF.UserModel.HSSFCell hssfcell = (global::NPOI.HSSF.UserModel.HSSFCell)cell;
				if (hssfcell.IsPartOfArrayFormulaGroup)
				{
					hssfcell.NotifyArrayFormulaChanging(msg);
				}
			}
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0005B178 File Offset: 0x00059378
		public void CreateFreezePane(int colSplit, int rowSplit, int leftmostColumn, int topRow)
		{
			this.ValidateColumn(colSplit);
			this.ValidateRow(rowSplit);
			if (leftmostColumn < colSplit)
			{
				throw new global::System.ArgumentException("leftmostColumn parameter must not be less than colSplit parameter");
			}
			if (topRow < rowSplit)
			{
				throw new global::System.ArgumentException("topRow parameter must not be less than leftmostColumn parameter");
			}
			this.Sheet.CreateFreezePane(colSplit, rowSplit, topRow, leftmostColumn);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x0005B1B7 File Offset: 0x000593B7
		public void CreateFreezePane(int colSplit, int rowSplit)
		{
			this.CreateFreezePane(colSplit, rowSplit, colSplit, rowSplit);
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x0005B1C3 File Offset: 0x000593C3
		public void CreateSplitPane(int xSplitPos, int ySplitPos, int leftmostColumn, int topRow, global::NPOI.SS.UserModel.PanePosition activePane)
		{
			this.Sheet.CreateSplitPane(xSplitPos, ySplitPos, topRow, leftmostColumn, activePane);
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x0005B1D7 File Offset: 0x000593D7
		public global::NPOI.SS.Util.PaneInformation PaneInformation
		{
			get
			{
				return this.Sheet.PaneInformation;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x0005B1E4 File Offset: 0x000593E4
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x0005B1F1 File Offset: 0x000593F1
		public bool DisplayGridlines
		{
			get
			{
				return this._sheet.DisplayGridlines;
			}
			set
			{
				this._sheet.DisplayGridlines = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x0005B1FF File Offset: 0x000593FF
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x0005B20C File Offset: 0x0005940C
		public bool DisplayFormulas
		{
			get
			{
				return this._sheet.DisplayFormulas;
			}
			set
			{
				this._sheet.DisplayFormulas = value;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x0005B21A File Offset: 0x0005941A
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x0005B227 File Offset: 0x00059427
		public bool DisplayRowColHeadings
		{
			get
			{
				return this._sheet.DisplayRowColHeadings;
			}
			set
			{
				this._sheet.DisplayRowColHeadings = value;
			}
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0005B238 File Offset: 0x00059438
		public double GetMargin(global::NPOI.SS.UserModel.MarginType margin)
		{
			if (margin == global::NPOI.SS.UserModel.MarginType.HeaderMargin)
			{
				return this._sheet.PageSettings.PrintSetup.HeaderMargin;
			}
			if (margin == global::NPOI.SS.UserModel.MarginType.FooterMargin)
			{
				return this._sheet.PageSettings.PrintSetup.FooterMargin;
			}
			return this._sheet.PageSettings.GetMargin(margin);
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x0005B28C File Offset: 0x0005948C
		public void SetMargin(global::NPOI.SS.UserModel.MarginType margin, double size)
		{
			if (margin == global::NPOI.SS.UserModel.MarginType.HeaderMargin)
			{
				this._sheet.PageSettings.PrintSetup.HeaderMargin = size;
				return;
			}
			if (margin == global::NPOI.SS.UserModel.MarginType.FooterMargin)
			{
				this._sheet.PageSettings.PrintSetup.FooterMargin = size;
				return;
			}
			this._sheet.PageSettings.SetMargin(margin, size);
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0005B2E1 File Offset: 0x000594E1
		public void SetRowBreak(int row)
		{
			this.ValidateRow(row);
			this._sheet.PageSettings.SetRowBreak(row, 0, 255);
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x0005B301 File Offset: 0x00059501
		public bool IsRowBroken(int row)
		{
			return this._sheet.PageSettings.IsRowBroken(row);
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0005B314 File Offset: 0x00059514
		public void RemoveRowBreak(int row)
		{
			this._sheet.PageSettings.RemoveRowBreak(row);
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x0005B327 File Offset: 0x00059527
		public int[] RowBreaks
		{
			get
			{
				return this._sheet.PageSettings.RowBreaks;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x0005B339 File Offset: 0x00059539
		public int[] ColumnBreaks
		{
			get
			{
				return this._sheet.PageSettings.ColumnBreaks;
			}
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0005B34B File Offset: 0x0005954B
		public void SetColumnBreak(int column)
		{
			this.ValidateColumn(column);
			this._sheet.PageSettings.SetColumnBreak(column, 0, -1);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0005B367 File Offset: 0x00059567
		public bool IsColumnBroken(int column)
		{
			return this._sheet.PageSettings.IsColumnBroken(column);
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x0005B37A File Offset: 0x0005957A
		public void RemoveColumnBreak(int column)
		{
			this._sheet.PageSettings.RemoveColumnBreak(column);
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0005B390 File Offset: 0x00059590
		protected void ValidateRow(int row)
		{
			int lastRowIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastRowIndex;
			if (row > lastRowIndex)
			{
				throw new global::System.ArgumentException("Maximum row number is " + lastRowIndex.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
			}
			if (row < 0)
			{
				throw new global::System.ArgumentException("Minumum row number is 0");
			}
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x0005B3D8 File Offset: 0x000595D8
		protected void ValidateColumn(int column)
		{
			int lastColumnIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastColumnIndex;
			if (column > lastColumnIndex)
			{
				throw new global::System.ArgumentException("Maximum column number is " + lastColumnIndex.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
			}
			if (column < 0)
			{
				throw new global::System.ArgumentException("Minimum column number is 0");
			}
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0005B420 File Offset: 0x00059620
		public void DumpDrawingRecords(bool fat)
		{
			this._sheet.AggregateDrawingRecords(this.book.DrawingManager, false);
			foreach (global::NPOI.DDF.EscherRecord escherRecord in ((global::NPOI.HSSF.Record.EscherAggregate)this.Sheet.FindFirstRecordBySid(9876)).EscherRecords)
			{
				if (fat)
				{
					global::System.Console.WriteLine(escherRecord.ToString());
				}
				else
				{
					escherRecord.Display(0);
				}
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x0005B4B0 File Offset: 0x000596B0
		public global::NPOI.HSSF.Record.EscherAggregate DrawingEscherAggregate
		{
			get
			{
				this.book.FindDrawingGroup();
				if (this.book.DrawingManager == null)
				{
					return null;
				}
				if (this._sheet.AggregateDrawingRecords(this.book.DrawingManager, false) == -1)
				{
					return null;
				}
				return (global::NPOI.HSSF.Record.EscherAggregate)this._sheet.FindFirstRecordBySid(9876);
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x0005B509 File Offset: 0x00059709
		public global::NPOI.SS.UserModel.IDrawing DrawingPatriarch
		{
			get
			{
				this._patriarch = this.GetPatriarch(false);
				return this._patriarch;
			}
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x0005B51E File Offset: 0x0005971E
		public global::NPOI.SS.UserModel.IDrawing CreateDrawingPatriarch()
		{
			this._patriarch = this.GetPatriarch(true);
			return this._patriarch;
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0005B534 File Offset: 0x00059734
		private global::NPOI.HSSF.UserModel.HSSFPatriarch GetPatriarch(bool createIfMissing)
		{
			if (this._patriarch != null)
			{
				return this._patriarch;
			}
			global::NPOI.HSSF.Model.DrawingManager2 drawingManager = this.book.FindDrawingGroup();
			if (drawingManager == null)
			{
				if (!createIfMissing)
				{
					return null;
				}
				this.book.CreateDrawingGroup();
				drawingManager = this.book.DrawingManager;
			}
			global::NPOI.HSSF.Record.EscherAggregate escherAggregate = (global::NPOI.HSSF.Record.EscherAggregate)this._sheet.FindFirstRecordBySid(9876);
			if (escherAggregate == null || escherAggregate.GetEscherContainer() == null)
			{
				int num = this._sheet.AggregateDrawingRecords(drawingManager, false);
				if (-1 == num || (escherAggregate = (global::NPOI.HSSF.Record.EscherAggregate)this._sheet.Records[num]) == null || escherAggregate.GetEscherContainer() == null)
				{
					if (createIfMissing)
					{
						num = this._sheet.AggregateDrawingRecords(drawingManager, true);
						escherAggregate = (global::NPOI.HSSF.Record.EscherAggregate)this._sheet.Records[num];
						global::NPOI.HSSF.UserModel.HSSFPatriarch hssfpatriarch = new global::NPOI.HSSF.UserModel.HSSFPatriarch(this, escherAggregate);
						hssfpatriarch.AfterCreate();
						return hssfpatriarch;
					}
					return null;
				}
			}
			return new global::NPOI.HSSF.UserModel.HSSFPatriarch(this, escherAggregate);
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x0005B60F File Offset: 0x0005980F
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x0005B61C File Offset: 0x0005981C
		public short TabColorIndex
		{
			get
			{
				return this._sheet.TabColorIndex;
			}
			set
			{
				this._sheet.TabColorIndex = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x0005B62A File Offset: 0x0005982A
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x0005B637 File Offset: 0x00059837
		public bool IsAutoTabColor
		{
			get
			{
				return this._sheet.IsAutoTabColor;
			}
			set
			{
				this._sheet.IsAutoTabColor = value;
			}
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0005B645 File Offset: 0x00059845
		public void SetColumnGroupCollapsed(int columnNumber, bool collapsed)
		{
			this._sheet.SetColumnGroupCollapsed(columnNumber, collapsed);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0005B654 File Offset: 0x00059854
		public void GroupColumn(int fromColumn, int toColumn)
		{
			this._sheet.GroupColumnRange(fromColumn, toColumn, true);
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0005B664 File Offset: 0x00059864
		public void UngroupColumn(int fromColumn, int toColumn)
		{
			this._sheet.GroupColumnRange(fromColumn, toColumn, false);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0005B674 File Offset: 0x00059874
		public void GroupRow(int fromRow, int toRow)
		{
			this._sheet.GroupRowRange(fromRow, toRow, true);
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0005B684 File Offset: 0x00059884
		public global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> RemoveArrayFormula(global::NPOI.SS.UserModel.ICell cell)
		{
			if (cell.Sheet != this)
			{
				throw new global::System.ArgumentException("Specified cell does not belong to this sheet.");
			}
			global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecord = ((global::NPOI.HSSF.UserModel.HSSFCell)cell).CellValueRecord;
			if (!(cellValueRecord is global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate))
			{
				string str = new global::NPOI.SS.Util.CellReference(cell).FormatAsString();
				throw new global::System.ArgumentException("Cell " + str + " is not part of an array formula.");
			}
			global::NPOI.SS.Util.CellRangeAddress range = ((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)cellValueRecord).RemoveArrayFormula(cell.RowIndex, cell.ColumnIndex);
			global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> cellRange = this.GetCellRange(range);
			foreach (global::NPOI.SS.UserModel.ICell cell2 in cellRange)
			{
				cell2.SetCellType(global::NPOI.SS.UserModel.CellType.Blank);
			}
			return cellRange;
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0005B734 File Offset: 0x00059934
		private global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> GetCellRange(global::NPOI.SS.Util.CellRangeAddress range)
		{
			int firstRow = range.FirstRow;
			int firstColumn = range.FirstColumn;
			int lastRow = range.LastRow;
			int lastColumn = range.LastColumn;
			int num = lastRow - firstRow + 1;
			int num2 = lastColumn - firstColumn + 1;
			global::System.Collections.Generic.List<global::NPOI.SS.UserModel.ICell> list = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.ICell>(num * num2);
			for (int i = firstRow; i <= lastRow; i++)
			{
				for (int j = firstColumn; j <= lastColumn; j++)
				{
					global::NPOI.SS.UserModel.IRow row = this.GetRow(i);
					if (row == null)
					{
						row = this.CreateRow(i);
					}
					global::NPOI.SS.UserModel.ICell cell = row.GetCell(j);
					if (cell == null)
					{
						cell = row.CreateCell(j);
					}
					list.Add(cell);
				}
			}
			return global::NPOI.SS.Util.SSCellRange<global::NPOI.SS.UserModel.ICell>.Create(firstRow, firstColumn, num, num2, list, typeof(global::NPOI.HSSF.UserModel.HSSFCell));
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0005B7EC File Offset: 0x000599EC
		public global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> SetArrayFormula(string formula, global::NPOI.SS.Util.CellRangeAddress range)
		{
			int sheetIndex = this._workbook.GetSheetIndex(this);
			global::NPOI.SS.Formula.PTG.Ptg[] ptgs = global::NPOI.HSSF.Model.HSSFFormulaParser.Parse(formula, this._workbook, global::NPOI.SS.Formula.FormulaType.Array, sheetIndex);
			global::NPOI.SS.UserModel.ICellRange<global::NPOI.SS.UserModel.ICell> cellRange = this.GetCellRange(range);
			foreach (global::NPOI.SS.UserModel.ICell cell in cellRange)
			{
				((global::NPOI.HSSF.UserModel.HSSFCell)cell).SetCellArrayFormula(range);
			}
			((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)((global::NPOI.HSSF.UserModel.HSSFCell)cellRange.TopLeftCell).CellValueRecord).SetArrayFormula(range, ptgs);
			return cellRange;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0005B878 File Offset: 0x00059A78
		public void UngroupRow(int fromRow, int toRow)
		{
			this._sheet.GroupRowRange(fromRow, toRow, false);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0005B888 File Offset: 0x00059A88
		public void SetRowGroupCollapsed(int row, bool collapse)
		{
			if (collapse)
			{
				this._sheet.RowsAggregate.CollapseRow(row);
				return;
			}
			this._sheet.RowsAggregate.ExpandRow(row);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0005B8B0 File Offset: 0x00059AB0
		public void SetDefaultColumnStyle(int column, global::NPOI.SS.UserModel.ICellStyle style)
		{
			this._sheet.SetDefaultColumnStyle(column, (int)style.Index);
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0005B8C4 File Offset: 0x00059AC4
		public void AutoSizeColumn(int column)
		{
			this.AutoSizeColumn(column, false);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0005B8D0 File Offset: 0x00059AD0
		public void AutoSizeColumn(int column, bool useMergedCells)
		{
			double num = global::NPOI.SS.Util.SheetUtil.GetColumnWidth(this, column, useMergedCells);
			if (num != -1.0)
			{
				num *= 256.0;
				int num2 = 65280;
				if (num > (double)num2)
				{
					num = (double)num2;
				}
				this.SetColumnWidth(column, (int)num);
			}
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0005B918 File Offset: 0x00059B18
		public bool IsMergedRegion(global::NPOI.SS.Util.CellRangeAddress mergedRegion)
		{
			foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in this._sheet.MergedRecords.MergedRegions)
			{
				if (cellRangeAddress.FirstColumn <= mergedRegion.FirstColumn && cellRangeAddress.LastColumn >= mergedRegion.LastColumn && cellRangeAddress.FirstRow <= mergedRegion.FirstRow && cellRangeAddress.LastRow >= mergedRegion.LastRow)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x0005B9B0 File Offset: 0x00059BB0
		public global::NPOI.SS.Util.CellRangeAddress GetMergedRegion(int index)
		{
			return this._sheet.GetMergedRegionAt(index);
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x0005B9C0 File Offset: 0x00059BC0
		public global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> MergedRegions
		{
			get
			{
				global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> list = new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress>();
				int numMergedRegions = this._sheet.NumMergedRegions;
				for (int i = 0; i < numMergedRegions; i++)
				{
					list.Add(this._sheet.GetMergedRegionAt(i));
				}
				return list;
			}
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0005B9FE File Offset: 0x00059BFE
		public global::System.Drawing.Font HSSFFont2Font(global::NPOI.HSSF.UserModel.HSSFFont font1)
		{
			return new global::System.Drawing.Font(font1.FontName, (float)font1.FontHeightInPoints);
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0005BA12 File Offset: 0x00059C12
		[global::System.Obsolete("deprecated as of 2015-11-23 (circa POI 3.14beta1). Use {@link #getCellComment(CellAddress)} instead.")]
		public global::NPOI.SS.UserModel.IComment GetCellComment(int row, int column)
		{
			return this.FindCellComment(row, column);
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0005BA1C File Offset: 0x00059C1C
		public global::NPOI.SS.UserModel.IComment GetCellComment(global::NPOI.SS.Util.CellAddress ref1)
		{
			return this.FindCellComment(ref1.Row, ref1.Column);
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0005BA30 File Offset: 0x00059C30
		public global::NPOI.SS.UserModel.IHyperlink GetHyperlink(int row, int column)
		{
			foreach (global::NPOI.HSSF.Record.RecordBase recordBase in this._sheet.Records)
			{
				if (recordBase is global::NPOI.HSSF.Record.HyperlinkRecord)
				{
					global::NPOI.HSSF.Record.HyperlinkRecord hyperlinkRecord = (global::NPOI.HSSF.Record.HyperlinkRecord)recordBase;
					if (hyperlinkRecord.FirstColumn == column && hyperlinkRecord.FirstRow == row)
					{
						return new global::NPOI.HSSF.UserModel.HSSFHyperlink(hyperlinkRecord);
					}
				}
			}
			return null;
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x0005BAB0 File Offset: 0x00059CB0
		public global::NPOI.SS.UserModel.IHyperlink GetHyperlink(global::NPOI.SS.Util.CellAddress addr)
		{
			return this.GetHyperlink(addr.Row, addr.Column);
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0005BAC4 File Offset: 0x00059CC4
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IHyperlink> GetHyperlinkList()
		{
			global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IHyperlink> list = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IHyperlink>();
			foreach (global::NPOI.HSSF.Record.RecordBase recordBase in this._sheet.Records)
			{
				if (recordBase is global::NPOI.HSSF.Record.HyperlinkRecord)
				{
					global::NPOI.HSSF.Record.HyperlinkRecord record = (global::NPOI.HSSF.Record.HyperlinkRecord)recordBase;
					list.Add(new global::NPOI.HSSF.UserModel.HSSFHyperlink(record));
				}
			}
			return list;
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x0005BB38 File Offset: 0x00059D38
		protected void RemoveHyperlink(global::NPOI.HSSF.UserModel.HSSFHyperlink link)
		{
			this.RemoveHyperlink(link.record);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0005BB48 File Offset: 0x00059D48
		protected void RemoveHyperlink(global::NPOI.HSSF.Record.HyperlinkRecord link)
		{
			for (int i = 0; i < this._sheet.Records.Count; i++)
			{
				global::NPOI.HSSF.Record.RecordBase recordBase = this._sheet.Records[i];
				if (recordBase is global::NPOI.HSSF.Record.HyperlinkRecord)
				{
					global::NPOI.HSSF.Record.HyperlinkRecord hyperlinkRecord = (global::NPOI.HSSF.Record.HyperlinkRecord)recordBase;
					if (link == hyperlinkRecord)
					{
						this._sheet.Records.RemoveAt(i);
						return;
					}
				}
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x0005BBA7 File Offset: 0x00059DA7
		public global::NPOI.SS.UserModel.ISheetConditionalFormatting SheetConditionalFormatting
		{
			get
			{
				return new global::NPOI.HSSF.UserModel.HSSFSheetConditionalFormatting(this);
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x0005BBB0 File Offset: 0x00059DB0
		public global::System.Collections.IList DVRecords
		{
			get
			{
				global::System.Collections.IList list = new global::System.Collections.ArrayList();
				global::System.Collections.IList records = this._sheet.Records;
				for (int i = 0; i < records.Count; i++)
				{
					if (records[i] is global::NPOI.HSSF.Record.DVRecord)
					{
						list.Add(records[i]);
					}
				}
				return list;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x0005BBFD File Offset: 0x00059DFD
		public global::NPOI.SS.UserModel.IWorkbook Workbook
		{
			get
			{
				return this._workbook;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x0005BC08 File Offset: 0x00059E08
		public string SheetName
		{
			get
			{
				global::NPOI.SS.UserModel.IWorkbook workbook = this.Workbook;
				int sheetIndex = workbook.GetSheetIndex(this);
				return workbook.GetSheetName(sheetIndex);
			}
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x0005BC29 File Offset: 0x00059E29
		public global::NPOI.SS.UserModel.IDataValidationHelper GetDataValidationHelper()
		{
			return new global::NPOI.HSSF.UserModel.HSSFDataValidationHelper(this);
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0005BC34 File Offset: 0x00059E34
		public global::NPOI.SS.UserModel.IAutoFilter SetAutoFilter(global::NPOI.SS.Util.CellRangeAddress range)
		{
			global::NPOI.HSSF.Model.InternalWorkbook workbook = this._workbook.Workbook;
			int sheetIndex = this._workbook.GetSheetIndex(this);
			global::NPOI.HSSF.Record.NameRecord nameRecord = workbook.GetSpecificBuiltinRecord(13, sheetIndex + 1);
			if (nameRecord == null)
			{
				nameRecord = workbook.CreateBuiltInName(13, sheetIndex + 1);
			}
			int num = range.FirstRow;
			if (num == -1)
			{
				num = 0;
			}
			global::NPOI.SS.Formula.PTG.Area3DPtg area3DPtg = new global::NPOI.SS.Formula.PTG.Area3DPtg(num, range.LastRow, range.FirstColumn, range.LastColumn, false, false, false, false, sheetIndex);
			nameRecord.NameDefinition = new global::NPOI.SS.Formula.PTG.Ptg[]
			{
				area3DPtg
			};
			global::NPOI.HSSF.Record.AutoFilter.AutoFilterInfoRecord autoFilterInfoRecord = new global::NPOI.HSSF.Record.AutoFilter.AutoFilterInfoRecord();
			int num2 = 1 + range.LastColumn - range.FirstColumn;
			autoFilterInfoRecord.NumEntries = (short)num2;
			int index = this._sheet.FindFirstRecordLocBySid(512);
			this._sheet.Records.Insert(index, autoFilterInfoRecord);
			global::NPOI.HSSF.UserModel.HSSFPatriarch hssfpatriarch = (global::NPOI.HSSF.UserModel.HSSFPatriarch)this.CreateDrawingPatriarch();
			int firstColumn = range.FirstColumn;
			int lastColumn = range.LastColumn;
			for (int i = firstColumn; i <= lastColumn; i++)
			{
				hssfpatriarch.CreateComboBox(new global::NPOI.HSSF.UserModel.HSSFClientAnchor(0, 0, 0, 0, (int)((short)i), num, (int)((short)(i + 1)), num + 1));
			}
			return new global::NPOI.HSSF.UserModel.HSSFAutoFilter(this);
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0005BD48 File Offset: 0x00059F48
		protected internal global::NPOI.HSSF.UserModel.HSSFComment FindCellComment(int row, int column)
		{
			global::NPOI.HSSF.UserModel.HSSFPatriarch hssfpatriarch = this.DrawingPatriarch as global::NPOI.HSSF.UserModel.HSSFPatriarch;
			if (hssfpatriarch == null)
			{
				hssfpatriarch = (this.CreateDrawingPatriarch() as global::NPOI.HSSF.UserModel.HSSFPatriarch);
			}
			return this.LookForComment(hssfpatriarch, row, column);
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0005BD7C File Offset: 0x00059F7C
		private global::NPOI.HSSF.UserModel.HSSFComment LookForComment(global::NPOI.HSSF.UserModel.HSSFShapeContainer container, int row, int column)
		{
			foreach (global::NPOI.HSSF.UserModel.HSSFShape hssfshape in container.Children)
			{
				global::NPOI.HSSF.UserModel.HSSFShape hssfshape2 = (global::NPOI.HSSF.UserModel.HSSFShape)hssfshape;
				if (hssfshape2 is global::NPOI.HSSF.UserModel.HSSFShapeGroup)
				{
					global::NPOI.HSSF.UserModel.HSSFShape hssfshape3 = this.LookForComment((global::NPOI.HSSF.UserModel.HSSFShapeContainer)hssfshape2, row, column);
					if (hssfshape3 != null)
					{
						return (global::NPOI.HSSF.UserModel.HSSFComment)hssfshape3;
					}
				}
				else if (hssfshape2 is global::NPOI.HSSF.UserModel.HSSFComment)
				{
					global::NPOI.HSSF.UserModel.HSSFComment hssfcomment = (global::NPOI.HSSF.UserModel.HSSFComment)hssfshape2;
					if (hssfcomment.HasPosition && hssfcomment.Column == column && hssfcomment.Row == row)
					{
						return hssfcomment;
					}
				}
			}
			return null;
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0005BE20 File Offset: 0x0005A020
		public global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.SS.UserModel.IComment> GetCellComments()
		{
			global::NPOI.HSSF.UserModel.HSSFPatriarch hssfpatriarch = this.DrawingPatriarch as global::NPOI.HSSF.UserModel.HSSFPatriarch;
			if (hssfpatriarch == null)
			{
				hssfpatriarch = (this.CreateDrawingPatriarch() as global::NPOI.HSSF.UserModel.HSSFPatriarch);
			}
			global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.SS.UserModel.IComment> dictionary = new global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.SS.UserModel.IComment>();
			this.FindCellCommentLocations(hssfpatriarch, dictionary);
			return dictionary;
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x0005BE58 File Offset: 0x0005A058
		private void FindCellCommentLocations(global::NPOI.HSSF.UserModel.HSSFShapeContainer container, global::System.Collections.Generic.Dictionary<global::NPOI.SS.Util.CellAddress, global::NPOI.SS.UserModel.IComment> locations)
		{
			foreach (global::NPOI.HSSF.UserModel.HSSFShape hssfshape in container.Children)
			{
				global::NPOI.HSSF.UserModel.HSSFShape hssfshape2 = (global::NPOI.HSSF.UserModel.HSSFShape)hssfshape;
				if (hssfshape2 is global::NPOI.HSSF.UserModel.HSSFShapeGroup)
				{
					this.FindCellCommentLocations((global::NPOI.HSSF.UserModel.HSSFShapeGroup)hssfshape2, locations);
				}
				else if (hssfshape2 is global::NPOI.HSSF.UserModel.HSSFComment)
				{
					global::NPOI.HSSF.UserModel.HSSFComment hssfcomment = (global::NPOI.HSSF.UserModel.HSSFComment)hssfshape2;
					if (hssfcomment.HasPosition)
					{
						locations.Add(new global::NPOI.SS.Util.CellAddress(hssfcomment.Row, hssfcomment.Column), hssfcomment);
					}
				}
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x0005BEEC File Offset: 0x0005A0EC
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x0005BEF8 File Offset: 0x0005A0F8
		public global::NPOI.SS.Util.CellRangeAddress RepeatingRows
		{
			get
			{
				return this.GetRepeatingRowsOrColums(true);
			}
			set
			{
				global::NPOI.SS.Util.CellRangeAddress repeatingColumns = this.RepeatingColumns;
				this.SetRepeatingRowsAndColumns(value, repeatingColumns);
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0005BF14 File Offset: 0x0005A114
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x0005BF20 File Offset: 0x0005A120
		public global::NPOI.SS.Util.CellRangeAddress RepeatingColumns
		{
			get
			{
				return this.GetRepeatingRowsOrColums(false);
			}
			set
			{
				global::NPOI.SS.Util.CellRangeAddress repeatingRows = this.RepeatingRows;
				this.SetRepeatingRowsAndColumns(repeatingRows, value);
			}
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x0005BF3C File Offset: 0x0005A13C
		private void SetRepeatingRowsAndColumns(global::NPOI.SS.Util.CellRangeAddress rowDef, global::NPOI.SS.Util.CellRangeAddress colDef)
		{
			int sheetIndex = this._workbook.GetSheetIndex(this);
			int lastRowIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastRowIndex;
			int lastColumnIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastColumnIndex;
			int num = -1;
			int num2 = -1;
			int num3 = -1;
			int num4 = -1;
			if (rowDef != null)
			{
				num3 = rowDef.FirstRow;
				num4 = rowDef.LastRow;
				if ((num3 == -1 && num4 != -1) || num3 > num4 || num3 < 0 || num3 > lastRowIndex || num4 < 0 || num4 > lastRowIndex)
				{
					throw new global::System.ArgumentException("Invalid row range specification");
				}
			}
			if (colDef != null)
			{
				num = colDef.FirstColumn;
				num2 = colDef.LastColumn;
				if ((num == -1 && num2 != -1) || num > num2 || num < 0 || num > lastColumnIndex || num2 < 0 || num2 > lastColumnIndex)
				{
					throw new global::System.ArgumentException("Invalid column range specification");
				}
			}
			short externalSheetIndex = (short)this._workbook.Workbook.CheckExternSheet(sheetIndex);
			bool flag = rowDef != null && colDef != null;
			bool flag2 = rowDef == null && colDef == null;
			global::NPOI.HSSF.UserModel.HSSFName hssfname = this._workbook.GetBuiltInName(7, sheetIndex);
			if (flag2)
			{
				if (hssfname != null)
				{
					this._workbook.RemoveName(hssfname);
				}
				return;
			}
			if (hssfname == null)
			{
				hssfname = this._workbook.CreateBuiltInName(7, sheetIndex);
			}
			global::System.Collections.Generic.List<global::NPOI.SS.Formula.PTG.Ptg> list = new global::System.Collections.Generic.List<global::NPOI.SS.Formula.PTG.Ptg>();
			if (flag)
			{
				int subExprLen = 23;
				list.Add(new global::NPOI.SS.Formula.PTG.MemFuncPtg(subExprLen));
			}
			if (colDef != null)
			{
				global::NPOI.SS.Formula.PTG.Area3DPtg item = new global::NPOI.SS.Formula.PTG.Area3DPtg(0, lastRowIndex, num, num2, false, false, false, false, (int)externalSheetIndex);
				list.Add(item);
			}
			if (rowDef != null)
			{
				global::NPOI.SS.Formula.PTG.Area3DPtg item2 = new global::NPOI.SS.Formula.PTG.Area3DPtg(num3, num4, 0, lastColumnIndex, false, false, false, false, (int)externalSheetIndex);
				list.Add(item2);
			}
			if (flag)
			{
				list.Add(global::NPOI.SS.Formula.PTG.UnionPtg.instance);
			}
			global::NPOI.SS.Formula.PTG.Ptg[] nameDefinition = list.ToArray();
			hssfname.SetNameDefinition(nameDefinition);
			((global::NPOI.HSSF.UserModel.HSSFPrintSetup)this.PrintSetup).ValidSettings = false;
			this.SetActive(true);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x0005C0EC File Offset: 0x0005A2EC
		private global::NPOI.SS.Util.CellRangeAddress GetRepeatingRowsOrColums(bool rows)
		{
			global::NPOI.HSSF.Record.NameRecord builtinNameRecord = this.GetBuiltinNameRecord(7);
			if (builtinNameRecord == null)
			{
				return null;
			}
			global::NPOI.SS.Formula.PTG.Ptg[] nameDefinition = builtinNameRecord.NameDefinition;
			if (builtinNameRecord.NameDefinition == null)
			{
				return null;
			}
			int lastRowIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastRowIndex;
			int lastColumnIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastColumnIndex;
			foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in nameDefinition)
			{
				if (ptg is global::NPOI.SS.Formula.PTG.Area3DPtg)
				{
					global::NPOI.SS.Formula.PTG.Area3DPtg area3DPtg = (global::NPOI.SS.Formula.PTG.Area3DPtg)ptg;
					if (area3DPtg.FirstColumn == 0 && area3DPtg.LastColumn == lastColumnIndex)
					{
						if (rows)
						{
							return new global::NPOI.SS.Util.CellRangeAddress(area3DPtg.FirstRow, area3DPtg.LastRow, -1, -1);
						}
					}
					else if (area3DPtg.FirstRow == 0 && area3DPtg.LastRow == lastRowIndex && !rows)
					{
						return new global::NPOI.SS.Util.CellRangeAddress(-1, -1, area3DPtg.FirstColumn, area3DPtg.LastColumn);
					}
				}
			}
			return null;
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x0005C1B8 File Offset: 0x0005A3B8
		private global::NPOI.HSSF.Record.NameRecord GetBuiltinNameRecord(byte builtinCode)
		{
			int sheetIndex = this._workbook.GetSheetIndex(this);
			int num = this._workbook.FindExistingBuiltinNameRecordIdx(sheetIndex, builtinCode);
			if (num == -1)
			{
				return null;
			}
			return this._workbook.GetNameRecord(num);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x0005C1F2 File Offset: 0x0005A3F2
		public int GetColumnOutlineLevel(int columnIndex)
		{
			return this._sheet.GetColumnOutlineLevel(columnIndex);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x0005C200 File Offset: 0x0005A400
		public global::NPOI.SS.UserModel.ISheet CopySheet()
		{
			return this.CopySheet(this.SheetName + " - Copy", true);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x0005C219 File Offset: 0x0005A419
		public global::NPOI.SS.UserModel.ISheet CopySheet(bool CopyStyle)
		{
			return this.CopySheet(this.SheetName + " - Copy", CopyStyle);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x0005C232 File Offset: 0x0005A432
		public global::NPOI.SS.UserModel.ISheet CopySheet(string Name)
		{
			return this.CopySheet(Name, true);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0005C23C File Offset: 0x0005A43C
		public global::NPOI.SS.UserModel.ISheet CopySheet(string Name, bool copyStyle)
		{
			int num = 0;
			global::NPOI.HSSF.UserModel.HSSFSheet hssfsheet = (global::NPOI.HSSF.UserModel.HSSFSheet)this.Workbook.CreateSheet(Name);
			hssfsheet._sheet = this.Sheet.CloneSheet();
			global::System.Collections.Generic.IDictionary<int, global::NPOI.HSSF.UserModel.HSSFCellStyle> styleMap = copyStyle ? new global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.UserModel.HSSFCellStyle>() : null;
			for (int i = this.FirstRowNum; i <= this.LastRowNum; i++)
			{
				global::NPOI.HSSF.UserModel.HSSFRow hssfrow = (global::NPOI.HSSF.UserModel.HSSFRow)this.GetRow(i);
				global::NPOI.HSSF.UserModel.HSSFRow destRow = (global::NPOI.HSSF.UserModel.HSSFRow)hssfsheet.CreateRow(i);
				if (hssfrow != null)
				{
					global::NPOI.HSSF.UserModel.HSSFSheet.CopyRow(this, hssfsheet, hssfrow, destRow, styleMap, new global::System.Collections.Generic.Dictionary<short, short>(), true);
					if ((int)hssfrow.LastCellNum > num)
					{
						num = (int)hssfrow.LastCellNum;
					}
				}
			}
			for (int j = 0; j <= num; j++)
			{
				hssfsheet.SetColumnWidth(j, this.GetColumnWidth(j));
			}
			hssfsheet.ForceFormulaRecalculation = true;
			hssfsheet.PrintSetup.Landscape = this.PrintSetup.Landscape;
			hssfsheet.PrintSetup.HResolution = this.PrintSetup.HResolution;
			hssfsheet.PrintSetup.VResolution = this.PrintSetup.VResolution;
			hssfsheet.SetMargin(global::NPOI.SS.UserModel.MarginType.LeftMargin, this.GetMargin(global::NPOI.SS.UserModel.MarginType.LeftMargin));
			hssfsheet.SetMargin(global::NPOI.SS.UserModel.MarginType.RightMargin, this.GetMargin(global::NPOI.SS.UserModel.MarginType.RightMargin));
			hssfsheet.SetMargin(global::NPOI.SS.UserModel.MarginType.TopMargin, this.GetMargin(global::NPOI.SS.UserModel.MarginType.TopMargin));
			hssfsheet.SetMargin(global::NPOI.SS.UserModel.MarginType.BottomMargin, this.GetMargin(global::NPOI.SS.UserModel.MarginType.BottomMargin));
			hssfsheet.PrintSetup.HeaderMargin = this.PrintSetup.HeaderMargin;
			hssfsheet.PrintSetup.FooterMargin = this.PrintSetup.FooterMargin;
			hssfsheet.Header.Left = this.Header.Left;
			hssfsheet.Header.Center = this.Header.Center;
			hssfsheet.Header.Right = this.Header.Right;
			hssfsheet.Footer.Left = this.Footer.Left;
			hssfsheet.Footer.Center = this.Footer.Center;
			hssfsheet.Footer.Right = this.Footer.Right;
			hssfsheet.PrintSetup.Scale = this.PrintSetup.Scale;
			hssfsheet.PrintSetup.FitHeight = this.PrintSetup.FitHeight;
			hssfsheet.PrintSetup.FitWidth = this.PrintSetup.FitWidth;
			return hssfsheet;
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x0005C468 File Offset: 0x0005A668
		public void CopyTo(global::NPOI.SS.UserModel.IWorkbook dest, string name, bool copyStyle, bool keepFormulas)
		{
			int num = 0;
			global::NPOI.HSSF.UserModel.HSSFSheet hssfsheet = (global::NPOI.HSSF.UserModel.HSSFSheet)dest.CreateSheet(name);
			hssfsheet._sheet = this.Sheet.CloneSheet();
			global::NPOI.HSSF.Model.InternalWorkbook workbook = ((global::NPOI.HSSF.UserModel.HSSFWorkbook)dest).Workbook;
			global::System.Collections.Generic.Dictionary<short, short> paletteMap = new global::System.Collections.Generic.Dictionary<short, short>();
			if (dest.NumberOfSheets == 1)
			{
				workbook.CustomPalette.ClearColors();
				paletteMap = global::NPOI.HSSF.UserModel.HSSFSheet.MergePalettes(this.Workbook as global::NPOI.HSSF.UserModel.HSSFWorkbook, dest as global::NPOI.HSSF.UserModel.HSSFWorkbook);
			}
			else if (dest != this.Workbook)
			{
				paletteMap = global::NPOI.HSSF.UserModel.HSSFSheet.MergePalettes(this.Workbook as global::NPOI.HSSF.UserModel.HSSFWorkbook, dest as global::NPOI.HSSF.UserModel.HSSFWorkbook);
			}
			global::System.Collections.Generic.IDictionary<int, global::NPOI.HSSF.UserModel.HSSFCellStyle> styleMap = copyStyle ? new global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.UserModel.HSSFCellStyle>() : null;
			for (int i = this.FirstRowNum; i <= this.LastRowNum; i++)
			{
				global::NPOI.HSSF.UserModel.HSSFRow hssfrow = (global::NPOI.HSSF.UserModel.HSSFRow)this.GetRow(i);
				global::NPOI.HSSF.UserModel.HSSFRow destRow = (global::NPOI.HSSF.UserModel.HSSFRow)hssfsheet.CreateRow(i);
				if (hssfrow != null)
				{
					global::NPOI.HSSF.UserModel.HSSFSheet.CopyRow(this, hssfsheet, hssfrow, destRow, styleMap, paletteMap, keepFormulas);
					if ((int)hssfrow.LastCellNum > num)
					{
						num = (int)hssfrow.LastCellNum;
					}
				}
			}
			for (int j = 0; j < num; j++)
			{
				hssfsheet.SetColumnWidth(j, this.GetColumnWidth(j));
			}
			hssfsheet.ForceFormulaRecalculation = true;
			hssfsheet.PrintSetup.Landscape = this.PrintSetup.Landscape;
			hssfsheet.PrintSetup.HResolution = this.PrintSetup.HResolution;
			hssfsheet.PrintSetup.VResolution = this.PrintSetup.VResolution;
			hssfsheet.SetMargin(global::NPOI.SS.UserModel.MarginType.LeftMargin, this.GetMargin(global::NPOI.SS.UserModel.MarginType.LeftMargin));
			hssfsheet.SetMargin(global::NPOI.SS.UserModel.MarginType.RightMargin, this.GetMargin(global::NPOI.SS.UserModel.MarginType.RightMargin));
			hssfsheet.SetMargin(global::NPOI.SS.UserModel.MarginType.TopMargin, this.GetMargin(global::NPOI.SS.UserModel.MarginType.TopMargin));
			hssfsheet.SetMargin(global::NPOI.SS.UserModel.MarginType.BottomMargin, this.GetMargin(global::NPOI.SS.UserModel.MarginType.BottomMargin));
			hssfsheet.PrintSetup.HeaderMargin = this.PrintSetup.HeaderMargin;
			hssfsheet.PrintSetup.FooterMargin = this.PrintSetup.FooterMargin;
			hssfsheet.Header.Left = this.Header.Left;
			hssfsheet.Header.Center = this.Header.Center;
			hssfsheet.Header.Right = this.Header.Right;
			hssfsheet.Footer.Left = this.Footer.Left;
			hssfsheet.Footer.Center = this.Footer.Center;
			hssfsheet.Footer.Right = this.Footer.Right;
			hssfsheet.PrintSetup.Scale = this.PrintSetup.Scale;
			hssfsheet.PrintSetup.FitHeight = this.PrintSetup.FitHeight;
			hssfsheet.PrintSetup.FitWidth = this.PrintSetup.FitWidth;
			global::NPOI.HSSF.Record.EscherAggregate drawingEscherAggregate = this.DrawingEscherAggregate;
			if (drawingEscherAggregate != null)
			{
				if (workbook.DrawingManager == null)
				{
					workbook.CreateDrawingGroup();
				}
				global::NPOI.HSSF.Record.EscherAggregate drawingEscherAggregate2 = hssfsheet.DrawingEscherAggregate;
				global::System.Collections.Generic.IEnumerable<int> enumerable = this.FindUsedPictures(drawingEscherAggregate.EscherRecords);
				global::System.Collections.Generic.Dictionary<int, int> dictionary = new global::System.Collections.Generic.Dictionary<int, int>();
				global::System.Collections.IList allPictures = this.Workbook.GetAllPictures();
				foreach (int num2 in enumerable)
				{
					if (num2 <= allPictures.Count)
					{
						global::NPOI.HSSF.UserModel.HSSFPictureData hssfpictureData = (global::NPOI.HSSF.UserModel.HSSFPictureData)allPictures[num2 - 1];
						int value = dest.AddPicture(hssfpictureData.Data, (global::NPOI.SS.UserModel.PictureType)hssfpictureData.Format);
						dictionary.Add(num2, value);
					}
				}
				foreach (global::NPOI.DDF.EscherRecord parent in drawingEscherAggregate2.EscherRecords)
				{
					this.ApplyEscherRemap(parent, dictionary);
				}
			}
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0005C7F8 File Offset: 0x0005A9F8
		private global::System.Collections.Generic.IEnumerable<int> FindUsedPictures(global::System.Collections.Generic.IEnumerable<global::NPOI.DDF.EscherRecord> escherRecords)
		{
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			foreach (global::NPOI.DDF.EscherRecord parent in escherRecords)
			{
				this.GetSheetImageIds(parent, list);
			}
			return list;
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0005C848 File Offset: 0x0005AA48
		private void GetSheetImageIds(global::NPOI.DDF.EscherRecord parent, global::System.Collections.Generic.List<int> usedIds)
		{
			foreach (global::NPOI.DDF.EscherRecord escherRecord in parent.ChildRecords)
			{
				if (escherRecord is global::NPOI.DDF.EscherOptRecord)
				{
					foreach (global::NPOI.DDF.EscherProperty escherProperty in ((global::NPOI.DDF.EscherOptRecord)escherRecord).EscherProperties)
					{
						if (escherProperty.PropertyNumber == 260)
						{
							int propertyValue = ((global::NPOI.DDF.EscherSimpleProperty)escherProperty).PropertyValue;
							if (!usedIds.Contains(propertyValue))
							{
								usedIds.Add(propertyValue);
								break;
							}
							break;
						}
					}
				}
				if (escherRecord.ChildRecords.Count > 0)
				{
					foreach (global::NPOI.DDF.EscherRecord parent2 in escherRecord.ChildRecords)
					{
						this.GetSheetImageIds(parent2, usedIds);
					}
				}
			}
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0005C964 File Offset: 0x0005AB64
		private void ApplyEscherRemap(global::NPOI.DDF.EscherRecord parent, global::System.Collections.Generic.Dictionary<int, int> mappings)
		{
			foreach (global::NPOI.DDF.EscherRecord escherRecord in parent.ChildRecords)
			{
				if (escherRecord is global::NPOI.DDF.EscherOptRecord)
				{
					foreach (global::NPOI.DDF.EscherProperty escherProperty in ((global::NPOI.DDF.EscherOptRecord)escherRecord).EscherProperties)
					{
						if (escherProperty.PropertyNumber == 260)
						{
							int propertyValue = ((global::NPOI.DDF.EscherSimpleProperty)escherProperty).PropertyValue;
							if (mappings.ContainsKey(propertyValue))
							{
								((global::NPOI.DDF.EscherSimpleProperty)escherProperty).PropertyValue = mappings[propertyValue];
								break;
							}
							break;
						}
					}
				}
				if (escherRecord.ChildRecords.Count > 0)
				{
					foreach (global::NPOI.DDF.EscherRecord parent2 in escherRecord.ChildRecords)
					{
						this.ApplyEscherRemap(parent2, mappings);
					}
				}
			}
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0005CA8C File Offset: 0x0005AC8C
		private static global::System.Collections.Generic.Dictionary<short, short> MergePalettes(global::NPOI.HSSF.UserModel.HSSFWorkbook source, global::NPOI.HSSF.UserModel.HSSFWorkbook dest)
		{
			global::System.Collections.Generic.Dictionary<short, short> dictionary = new global::System.Collections.Generic.Dictionary<short, short>();
			for (short num = 0; num < source.Workbook.CustomPalette.NumColors; num += 1)
			{
				byte[] color = source.Workbook.CustomPalette.GetColor(num + 8);
				bool flag = false;
				for (short num2 = 0; num2 < dest.Workbook.CustomPalette.NumColors; num2 += 1)
				{
					byte[] color2 = dest.Workbook.CustomPalette.GetColor(num2 + 8);
					if (color[0] == color2[0] && color[1] == color2[1] && color[2] == color2[2])
					{
						flag = true;
						dictionary.Add(num + 8, num2 + 8);
						break;
					}
				}
				if (!flag)
				{
					short numColors = dest.Workbook.CustomPalette.NumColors;
					dest.Workbook.CustomPalette.SetColor(numColors + 8, color[0], color[1], color[2]);
					dictionary.Add(num + 8, numColors + 8);
				}
			}
			return dictionary;
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0005CB80 File Offset: 0x0005AD80
		private static void CopyRow(global::NPOI.HSSF.UserModel.HSSFSheet srcSheet, global::NPOI.HSSF.UserModel.HSSFSheet destSheet, global::NPOI.HSSF.UserModel.HSSFRow srcRow, global::NPOI.HSSF.UserModel.HSSFRow destRow, global::System.Collections.Generic.IDictionary<int, global::NPOI.HSSF.UserModel.HSSFCellStyle> styleMap, global::System.Collections.Generic.Dictionary<short, short> paletteMap, bool keepFormulas)
		{
			global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> mergedRegions = destSheet.Sheet.MergedRecords.MergedRegions;
			destRow.Height = srcRow.Height;
			destRow.IsHidden = srcRow.IsHidden;
			destRow.RowRecord.OptionFlags = srcRow.RowRecord.OptionFlags;
			for (int i = (int)srcRow.FirstCellNum; i <= (int)srcRow.LastCellNum; i++)
			{
				global::NPOI.HSSF.UserModel.HSSFCell hssfcell = (global::NPOI.HSSF.UserModel.HSSFCell)srcRow.GetCell(i);
				global::NPOI.HSSF.UserModel.HSSFCell hssfcell2 = (global::NPOI.HSSF.UserModel.HSSFCell)destRow.GetCell(i);
				if (srcSheet.Workbook == destSheet.Workbook)
				{
					hssfcell2 = (global::NPOI.HSSF.UserModel.HSSFCell)destRow.GetCell(i);
				}
				if (hssfcell != null)
				{
					if (hssfcell2 == null)
					{
						hssfcell2 = (global::NPOI.HSSF.UserModel.HSSFCell)destRow.CreateCell(i);
					}
					global::NPOI.HSSF.Util.HSSFCellUtil.CopyCell(hssfcell, hssfcell2, styleMap, paletteMap, keepFormulas);
					global::NPOI.SS.Util.CellRangeAddress mergedRegion = global::NPOI.HSSF.UserModel.HSSFSheet.GetMergedRegion(srcSheet, srcRow.RowNum, (short)hssfcell.ColumnIndex);
					if (mergedRegion != null)
					{
						global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = new global::NPOI.SS.Util.CellRangeAddress(mergedRegion.FirstRow, mergedRegion.LastRow, mergedRegion.FirstColumn, mergedRegion.LastColumn);
						if (global::NPOI.HSSF.UserModel.HSSFSheet.IsNewMergedRegion(cellRangeAddress, mergedRegions))
						{
							mergedRegions.Add(cellRangeAddress);
						}
					}
				}
			}
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x0005CC8C File Offset: 0x0005AE8C
		public static global::NPOI.SS.Util.CellRangeAddress GetMergedRegion(global::NPOI.HSSF.UserModel.HSSFSheet sheet, int rowNum, short cellNum)
		{
			for (int i = 0; i < sheet.NumMergedRegions; i++)
			{
				global::NPOI.SS.Util.CellRangeAddress mergedRegion = sheet.GetMergedRegion(i);
				if (rowNum >= mergedRegion.FirstRow && rowNum <= mergedRegion.LastRow && (int)cellNum >= mergedRegion.FirstColumn && (int)cellNum <= mergedRegion.LastColumn)
				{
					return mergedRegion;
				}
			}
			return null;
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x0005CCDC File Offset: 0x0005AEDC
		private static bool AreAllTrue(params bool[] values)
		{
			for (int i = 0; i < values.Length; i++)
			{
				if (!values[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x0005CD00 File Offset: 0x0005AF00
		private static bool IsNewMergedRegion(global::NPOI.SS.Util.CellRangeAddress newMergedRegion, global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> mergedRegions)
		{
			bool result = true;
			foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in mergedRegions)
			{
				bool flag = cellRangeAddress.FirstRow == newMergedRegion.FirstRow;
				bool flag2 = cellRangeAddress.LastRow == newMergedRegion.LastRow;
				bool flag3 = cellRangeAddress.FirstColumn == newMergedRegion.FirstColumn;
				bool flag4 = cellRangeAddress.LastColumn == newMergedRegion.LastColumn;
				if (global::NPOI.HSSF.UserModel.HSSFSheet.AreAllTrue(new bool[]
				{
					flag,
					flag2,
					flag3,
					flag4
				}))
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00008C75 File Offset: 0x00006E75
		public bool IsDate1904()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x0005CDA8 File Offset: 0x0005AFA8
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0005CDD4 File Offset: 0x0005AFD4
		public global::NPOI.SS.Util.CellAddress ActiveCell
		{
			get
			{
				int activeCellRow = this._sheet.ActiveCellRow;
				int activeCellCol = this._sheet.ActiveCellCol;
				return new global::NPOI.SS.Util.CellAddress(activeCellRow, activeCellCol);
			}
			set
			{
				int row = value.Row;
				short activeCellCol = (short)value.Column;
				this._sheet.ActiveCellRow = row;
				this._sheet.ActiveCellCol = (int)activeCellCol;
			}
		}

		// Token: 0x04000BA0 RID: 2976
		private static float PX_DEFAULT = 32f;

		// Token: 0x04000BA1 RID: 2977
		private static float PX_MODIFIED = 36.56f;

		// Token: 0x04000BA2 RID: 2978
		public const int INITIAL_CAPACITY = 20;

		// Token: 0x04000BA3 RID: 2979
		private global::NPOI.HSSF.Model.InternalSheet _sheet;

		// Token: 0x04000BA4 RID: 2980
		private global::System.Collections.Generic.Dictionary<int, global::NPOI.SS.UserModel.IRow> rows;

		// Token: 0x04000BA5 RID: 2981
		public global::NPOI.HSSF.Model.InternalWorkbook book;

		// Token: 0x04000BA6 RID: 2982
		protected global::NPOI.HSSF.UserModel.HSSFWorkbook _workbook;

		// Token: 0x04000BA7 RID: 2983
		private int firstrow;

		// Token: 0x04000BA8 RID: 2984
		private int lastrow;

		// Token: 0x04000BA9 RID: 2985
		[global::System.NonSerialized]
		private global::NPOI.HSSF.UserModel.HSSFPatriarch _patriarch;

		// Token: 0x02000604 RID: 1540
		private class RecordVisitor1 : global::NPOI.HSSF.Record.Aggregates.RecordVisitor
		{
			// Token: 0x06003642 RID: 13890 RVA: 0x000A5D02 File Offset: 0x000A3F02
			public RecordVisitor1(global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IDataValidation> hssfValidations, global::NPOI.SS.UserModel.IWorkbook workbook)
			{
				this.hssfValidations = hssfValidations;
				this.workbook = workbook;
				this.book = global::NPOI.HSSF.UserModel.HSSFEvaluationWorkbook.Create(workbook);
			}

			// Token: 0x06003643 RID: 13891 RVA: 0x000A5D24 File Offset: 0x000A3F24
			public void VisitRecord(global::NPOI.HSSF.Record.Record r)
			{
				if (!(r is global::NPOI.HSSF.Record.DVRecord))
				{
					return;
				}
				global::NPOI.HSSF.Record.DVRecord dvrecord = (global::NPOI.HSSF.Record.DVRecord)r;
				global::NPOI.SS.Util.CellRangeAddressList regions = dvrecord.CellRangeAddress.Copy();
				global::NPOI.HSSF.UserModel.DVConstraint constraint = global::NPOI.HSSF.UserModel.DVConstraint.CreateDVConstraint(dvrecord, this.book);
				global::NPOI.HSSF.UserModel.HSSFDataValidation hssfdataValidation = new global::NPOI.HSSF.UserModel.HSSFDataValidation(regions, constraint);
				hssfdataValidation.ErrorStyle = dvrecord.ErrorStyle;
				hssfdataValidation.EmptyCellAllowed = dvrecord.EmptyCellAllowed;
				hssfdataValidation.SuppressDropDownArrow = dvrecord.SuppressDropdownArrow;
				hssfdataValidation.CreatePromptBox(dvrecord.PromptTitle, dvrecord.PromptText);
				hssfdataValidation.ShowPromptBox = dvrecord.ShowPromptOnCellSelected;
				hssfdataValidation.CreateErrorBox(dvrecord.ErrorTitle, dvrecord.ErrorText);
				hssfdataValidation.ShowErrorBox = dvrecord.ShowErrorOnInvalidValue;
				this.hssfValidations.Add(hssfdataValidation);
			}

			// Token: 0x04001A4B RID: 6731
			private global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IDataValidation> hssfValidations;

			// Token: 0x04001A4C RID: 6732
			private global::NPOI.SS.UserModel.IWorkbook workbook;

			// Token: 0x04001A4D RID: 6733
			private global::NPOI.HSSF.UserModel.HSSFEvaluationWorkbook book;
		}

		// Token: 0x02000605 RID: 1541
		private class Int32Comparer : global::System.Collections.Generic.IComparer<int>
		{
			// Token: 0x06003644 RID: 13892 RVA: 0x000A5DCC File Offset: 0x000A3FCC
			public int Compare(int x, int y)
			{
				if (x < y)
				{
					return 1;
				}
				if (x > y)
				{
					return -1;
				}
				return 0;
			}
		}
	}
}
