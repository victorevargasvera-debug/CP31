using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS;
using NPOI.SS.Formula;
using NPOI.SS.UserModel;
using NPOI.SS.UserModel.Helpers;
using NPOI.SS.Util;
using NPOI.Util;
using NPOI.XSSF.Model;
using NPOI.XSSF.UserModel.Helpers;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200009B RID: 155
	public class XSSFRow : global::NPOI.SS.UserModel.IRow, global::System.Collections.Generic.IEnumerable<global::NPOI.SS.UserModel.ICell>, global::System.Collections.IEnumerable, global::System.IComparable<global::NPOI.XSSF.UserModel.XSSFRow>
	{
		// Token: 0x0600082C RID: 2092 RVA: 0x0001BED8 File Offset: 0x0001A0D8
		public XSSFRow(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row row, global::NPOI.XSSF.UserModel.XSSFSheet sheet)
		{
			this._row = row;
			this._sheet = sheet;
			this._cells = new global::System.Collections.Generic.SortedDictionary<int, global::NPOI.SS.UserModel.ICell>();
			if (0 < row.SizeOfCArray())
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell cell in row.c)
				{
					global::NPOI.XSSF.UserModel.XSSFCell xssfcell = new global::NPOI.XSSF.UserModel.XSSFCell(this, cell);
					this._cells.Add(xssfcell.ColumnIndex, xssfcell);
					sheet.OnReadCell(xssfcell);
				}
			}
			if (!row.IsSetR())
			{
				int num = sheet.LastRowNum + 2;
				if (num == 2 && sheet.PhysicalNumberOfRows == 0)
				{
					num = 1;
				}
				row.r = (uint)num;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x0001BF94 File Offset: 0x0001A194
		public global::NPOI.SS.UserModel.ISheet Sheet
		{
			get
			{
				return this._sheet;
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0001BF9C File Offset: 0x0001A19C
		public global::System.Collections.Generic.SortedDictionary<int, global::NPOI.SS.UserModel.ICell>.ValueCollection.Enumerator CellIterator()
		{
			return this._cells.Values.GetEnumerator();
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0001BFAE File Offset: 0x0001A1AE
		public global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ICell> GetEnumerator()
		{
			return this.CellIterator();
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0001BFBC File Offset: 0x0001A1BC
		public int CompareTo(global::NPOI.XSSF.UserModel.XSSFRow other)
		{
			if (this.Sheet != other.Sheet)
			{
				throw new global::System.ArgumentException("The compared rows must belong to the same sheet");
			}
			return this.RowNum.CompareTo(other.RowNum);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0001BFF8 File Offset: 0x0001A1F8
		public override bool Equals(object obj)
		{
			if (!(obj is global::NPOI.XSSF.UserModel.XSSFRow))
			{
				return false;
			}
			global::NPOI.XSSF.UserModel.XSSFRow xssfrow = (global::NPOI.XSSF.UserModel.XSSFRow)obj;
			return this.RowNum == xssfrow.RowNum && this.Sheet == xssfrow.Sheet;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0001C034 File Offset: 0x0001A234
		public override int GetHashCode()
		{
			return this._row.GetHashCode();
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0001C041 File Offset: 0x0001A241
		public global::NPOI.SS.UserModel.ICell CreateCell(int columnIndex)
		{
			return this.CreateCell(columnIndex, global::NPOI.SS.UserModel.CellType.Blank);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0001C04C File Offset: 0x0001A24C
		public global::NPOI.SS.UserModel.ICell CreateCell(int columnIndex, global::NPOI.SS.UserModel.CellType type)
		{
			global::NPOI.XSSF.UserModel.XSSFCell xssfcell = this._cells.ContainsKey(columnIndex) ? ((global::NPOI.XSSF.UserModel.XSSFCell)this._cells[columnIndex]) : null;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell ct_Cell;
			if (xssfcell != null)
			{
				ct_Cell = xssfcell.GetCTCell();
				ct_Cell.Set(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell());
			}
			else
			{
				ct_Cell = this._row.AddNewC();
			}
			global::NPOI.XSSF.UserModel.XSSFCell xssfcell2 = new global::NPOI.XSSF.UserModel.XSSFCell(this, ct_Cell);
			xssfcell2.SetCellNum(columnIndex);
			if (type != global::NPOI.SS.UserModel.CellType.Blank)
			{
				xssfcell2.SetCellType(type);
			}
			this._cells[columnIndex] = xssfcell2;
			return xssfcell2;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0001C0C7 File Offset: 0x0001A2C7
		public global::NPOI.SS.UserModel.ICell GetCell(int cellnum)
		{
			return this.GetCell(cellnum, this._sheet.Workbook.MissingCellPolicy);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
		private global::NPOI.SS.UserModel.ICell RetrieveCell(int cellnum)
		{
			if (!this._cells.ContainsKey(cellnum))
			{
				return null;
			}
			return this._cells[cellnum];
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0001C100 File Offset: 0x0001A300
		public global::NPOI.SS.UserModel.ICell GetCell(int cellnum, global::NPOI.SS.UserModel.MissingCellPolicy policy)
		{
			if (cellnum < 0)
			{
				throw new global::System.ArgumentException("Cell index must be >= 0");
			}
			global::NPOI.XSSF.UserModel.XSSFCell xssfcell = (global::NPOI.XSSF.UserModel.XSSFCell)this.RetrieveCell(cellnum);
			switch (policy)
			{
			case global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_NULL_AND_BLANK:
				return xssfcell;
			case global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_BLANK_AS_NULL:
				if (xssfcell == null || xssfcell.CellType != global::NPOI.SS.UserModel.CellType.Blank)
				{
					return xssfcell;
				}
				return null;
			case global::NPOI.SS.UserModel.MissingCellPolicy.CREATE_NULL_AS_BLANK:
				if (xssfcell != null)
				{
					return xssfcell;
				}
				return this.CreateCell(cellnum, global::NPOI.SS.UserModel.CellType.Blank);
			default:
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Illegal policy ",
					policy.ToString(),
					" (",
					policy.ToString(),
					")"
				}));
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0001C1AE File Offset: 0x0001A3AE
		private int GetFirstKey()
		{
			return this._cells.Keys.Min();
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0001C1C0 File Offset: 0x0001A3C0
		private int GetLastKey()
		{
			return this._cells.Keys.Max();
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0001C1D2 File Offset: 0x0001A3D2
		public short FirstCellNum
		{
			get
			{
				return (short)((this._cells.Count == 0) ? -1 : this.GetFirstKey());
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0001C1EB File Offset: 0x0001A3EB
		public short LastCellNum
		{
			get
			{
				return (short)((this._cells.Count == 0) ? -1 : (this.GetLastKey() + 1));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x0001C206 File Offset: 0x0001A406
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x0001C218 File Offset: 0x0001A418
		public short Height
		{
			get
			{
				return (short)(this.HeightInPoints * 20f);
			}
			set
			{
				if (value < 0)
				{
					if (this._row.IsSetHt())
					{
						this._row.UnsetHt();
					}
					if (this._row.IsSetCustomHeight())
					{
						this._row.UnsetCustomHeight();
						return;
					}
				}
				else
				{
					this._row.ht = (double)value / 20.0;
					this._row.customHeight = true;
				}
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x0001C27D File Offset: 0x0001A47D
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x0001C2A4 File Offset: 0x0001A4A4
		public float HeightInPoints
		{
			get
			{
				if (this._row.IsSetHt())
				{
					return (float)this._row.ht;
				}
				return this._sheet.DefaultRowHeightInPoints;
			}
			set
			{
				this.Height = (short)((value == -1f) ? -1f : (value * 20f));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x0001C2C3 File Offset: 0x0001A4C3
		public int PhysicalNumberOfCells
		{
			get
			{
				return this._cells.Count;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0001C2D0 File Offset: 0x0001A4D0
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x0001C2E0 File Offset: 0x0001A4E0
		public int RowNum
		{
			get
			{
				return (int)(this._row.r - 1U);
			}
			set
			{
				int lastRowIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL2007.LastRowIndex;
				if (value < 0 || value > lastRowIndex)
				{
					throw new global::System.ArgumentException(string.Concat(new string[]
					{
						"Invalid row number (",
						value.ToString(),
						") outside allowable range (0..",
						lastRowIndex.ToString(),
						")"
					}));
				}
				this._row.r = (uint)(value + 1);
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x0001C34B File Offset: 0x0001A54B
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x0001C358 File Offset: 0x0001A558
		public bool ZeroHeight
		{
			get
			{
				return this._row.hidden;
			}
			set
			{
				this._row.hidden = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x0001C366 File Offset: 0x0001A566
		public bool IsFormatted
		{
			get
			{
				return this._row.IsSetS();
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0001C374 File Offset: 0x0001A574
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x0001C3C0 File Offset: 0x0001A5C0
		public global::NPOI.SS.UserModel.ICellStyle RowStyle
		{
			get
			{
				if (!this.IsFormatted)
				{
					return null;
				}
				global::NPOI.XSSF.Model.StylesTable stylesSource = ((global::NPOI.XSSF.UserModel.XSSFWorkbook)this.Sheet.Workbook).GetStylesSource();
				if (stylesSource.NumCellStyles > 0)
				{
					return stylesSource.GetStyleAt((int)this._row.s);
				}
				return null;
			}
			set
			{
				if (value == null)
				{
					if (this._row.IsSetS())
					{
						this._row.UnsetS();
						this._row.UnsetCustomFormat();
						return;
					}
				}
				else
				{
					global::NPOI.XSSF.Model.StylesTable stylesSource = ((global::NPOI.XSSF.UserModel.XSSFWorkbook)this.Sheet.Workbook).GetStylesSource();
					global::NPOI.XSSF.UserModel.XSSFCellStyle xssfcellStyle = (global::NPOI.XSSF.UserModel.XSSFCellStyle)value;
					xssfcellStyle.VerifyBelongsToStylesSource(stylesSource);
					long num = (long)stylesSource.PutStyle(xssfcellStyle);
					this._row.s = (uint)num;
					this._row.customFormat = true;
				}
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000029BF File Offset: 0x00000BBF
		public void SetRowStyle(global::NPOI.SS.UserModel.ICellStyle style)
		{
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0001C43C File Offset: 0x0001A63C
		public void RemoveCell(global::NPOI.SS.UserModel.ICell cell)
		{
			if (cell.Row != this)
			{
				throw new global::System.ArgumentException("Specified cell does not belong to this row");
			}
			global::NPOI.XSSF.UserModel.XSSFCell xssfcell = (global::NPOI.XSSF.UserModel.XSSFCell)cell;
			if (xssfcell.IsPartOfArrayFormulaGroup)
			{
				xssfcell.NotifyArrayFormulaChanging();
			}
			if (cell.CellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				((global::NPOI.XSSF.UserModel.XSSFWorkbook)this._sheet.Workbook).OnDeleteFormula(xssfcell);
			}
			this._cells.Remove(cell.ColumnIndex);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0001C4A3 File Offset: 0x0001A6A3
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row GetCTRow()
		{
			return this._row;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0001C4AC File Offset: 0x0001A6AC
		internal void OnDocumentWrite()
		{
			bool flag = true;
			if (this._row.SizeOfCArray() != this._cells.Count)
			{
				flag = false;
			}
			else
			{
				int num = 0;
				foreach (global::NPOI.SS.UserModel.ICell cell in this._cells.Values)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell ctcell = ((global::NPOI.XSSF.UserModel.XSSFCell)cell).GetCTCell();
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell carray = this._row.GetCArray(num++);
					string r = ctcell.r;
					string r2 = carray.r;
					if (!((r == null) ? (r2 == null) : r.Equals(r2)))
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell[] array = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell[this._cells.Count];
				int num2 = 0;
				foreach (global::NPOI.SS.UserModel.ICell cell2 in this._cells.Values)
				{
					global::NPOI.XSSF.UserModel.XSSFCell xssfcell = (global::NPOI.XSSF.UserModel.XSSFCell)cell2;
					array[num2++] = xssfcell.GetCTCell();
				}
				this._row.SetCArray(array);
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0001C5DC File Offset: 0x0001A7DC
		public override string ToString()
		{
			return this._row.ToString();
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0001C5EC File Offset: 0x0001A7EC
		internal void Shift(int n)
		{
			int num = this.RowNum + n;
			global::NPOI.XSSF.Model.CalculationChain calculationChain = ((global::NPOI.XSSF.UserModel.XSSFWorkbook)this._sheet.Workbook).GetCalculationChain();
			int sheetId = (int)this._sheet.sheet.sheetId;
			string msg = "Row[rownum=" + this.RowNum.ToString() + "] contains cell(s) included in a multi-cell array formula. You cannot change part of an array.";
			foreach (global::NPOI.SS.UserModel.ICell cell in this)
			{
				global::NPOI.XSSF.UserModel.XSSFCell xssfcell = (global::NPOI.XSSF.UserModel.XSSFCell)cell;
				if (xssfcell.IsPartOfArrayFormulaGroup)
				{
					xssfcell.NotifyArrayFormulaChanging(msg);
				}
				if (calculationChain != null)
				{
					calculationChain.RemoveItem(sheetId, xssfcell.GetReference());
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell ctcell = xssfcell.GetCTCell();
				string r = new global::NPOI.SS.Util.CellReference(num, xssfcell.ColumnIndex).FormatAsString();
				ctcell.r = r;
			}
			this.RowNum = num;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0001C6D4 File Offset: 0x0001A8D4
		public void CopyRowFrom(global::NPOI.SS.UserModel.IRow srcRow, global::NPOI.SS.UserModel.CellCopyPolicy policy)
		{
			if (srcRow == null)
			{
				foreach (global::NPOI.SS.UserModel.ICell cell in this)
				{
					global::NPOI.XSSF.UserModel.XSSFCell srcCell = null;
					((global::NPOI.XSSF.UserModel.XSSFCell)cell).CopyCellFrom(srcCell, policy);
				}
				if (policy.IsCopyMergedRegions)
				{
					int rowNum = this.RowNum;
					int num = 0;
					global::System.Collections.Generic.HashSet<int> hashSet = new global::System.Collections.Generic.HashSet<int>();
					foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in this.Sheet.MergedRegions)
					{
						if (rowNum == cellRangeAddress.FirstRow && rowNum == cellRangeAddress.LastRow)
						{
							hashSet.Add(num);
						}
						num++;
					}
					(this.Sheet as global::NPOI.XSSF.UserModel.XSSFSheet).RemoveMergedRegions(hashSet.ToList<int>());
				}
				if (policy.IsCopyRowHeight)
				{
					this.Height = -1;
					return;
				}
			}
			else
			{
				foreach (global::NPOI.SS.UserModel.ICell cell2 in srcRow)
				{
					global::NPOI.XSSF.UserModel.XSSFCell xssfcell = (global::NPOI.XSSF.UserModel.XSSFCell)cell2;
					(this.CreateCell(xssfcell.ColumnIndex, xssfcell.CellType) as global::NPOI.XSSF.UserModel.XSSFCell).CopyCellFrom(xssfcell, policy);
				}
				global::NPOI.SS.UserModel.Helpers.RowShifter rowShifter = new global::NPOI.XSSF.UserModel.Helpers.XSSFRowShifter(this._sheet);
				int sheetIndex = this._sheet.Workbook.GetSheetIndex(this._sheet);
				string sheetName = this._sheet.Workbook.GetSheetName(sheetIndex);
				int rowNum2 = srcRow.RowNum;
				int rowNum3 = this.RowNum;
				int numberOfRowsToMove = rowNum3 - rowNum2;
				global::NPOI.SS.Formula.FormulaShifter shifter = global::NPOI.SS.Formula.FormulaShifter.CreateForRowCopy(sheetIndex, sheetName, rowNum2, rowNum2, numberOfRowsToMove, global::NPOI.SS.SpreadsheetVersion.EXCEL2007);
				rowShifter.UpdateRowFormulas(this, shifter);
				if (policy.IsCopyMergedRegions)
				{
					foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress2 in srcRow.Sheet.MergedRegions)
					{
						if (rowNum2 == cellRangeAddress2.FirstRow && rowNum2 == cellRangeAddress2.LastRow)
						{
							global::NPOI.SS.Util.CellRangeAddress cellRangeAddress3 = cellRangeAddress2.Copy();
							cellRangeAddress3.FirstRow = rowNum3;
							cellRangeAddress3.LastRow = rowNum3;
							this.Sheet.AddMergedRegion(cellRangeAddress3);
						}
					}
				}
				if (policy.IsCopyRowHeight)
				{
					this.Height = srcRow.Height;
				}
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0001C930 File Offset: 0x0001AB30
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.ICell> Cells
		{
			get
			{
				global::System.Collections.Generic.List<global::NPOI.SS.UserModel.ICell> list = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.ICell>();
				foreach (global::NPOI.SS.UserModel.ICell item in this._cells.Values)
				{
					list.Add(item);
				}
				return list;
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000065E4 File Offset: 0x000047E4
		public void MoveCell(global::NPOI.SS.UserModel.ICell cell, int newColumn)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0001C990 File Offset: 0x0001AB90
		public global::NPOI.SS.UserModel.IRow CopyRowTo(int targetIndex)
		{
			return this.Sheet.CopyRow(this.RowNum, targetIndex);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0001C9A4 File Offset: 0x0001ABA4
		public global::NPOI.SS.UserModel.ICell CopyCell(int sourceIndex, int targetIndex)
		{
			return global::NPOI.SS.Util.CellUtil.CopyCell(this, sourceIndex, targetIndex);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0001C9AE File Offset: 0x0001ABAE
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000065E4 File Offset: 0x000047E4
		public bool HasCustomHeight()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0001C9B6 File Offset: 0x0001ABB6
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x0001C9C3 File Offset: 0x0001ABC3
		public int OutlineLevel
		{
			get
			{
				return (int)this._row.outlineLevel;
			}
			set
			{
				this._row.outlineLevel = (byte)value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0001C9D2 File Offset: 0x0001ABD2
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x0001C9E4 File Offset: 0x0001ABE4
		public bool? Hidden
		{
			get
			{
				return new bool?(this._row.hidden);
			}
			set
			{
				this._row.hidden = value.GetValueOrDefault();
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0001C9F8 File Offset: 0x0001ABF8
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x0001CA0A File Offset: 0x0001AC0A
		public bool? Collapsed
		{
			get
			{
				return new bool?(this._row.collapsed);
			}
			set
			{
				this._row.collapsed = value.GetValueOrDefault();
			}
		}

		// Token: 0x04000340 RID: 832
		private static global::NPOI.Util.POILogger _logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.XSSF.UserModel.XSSFRow));

		// Token: 0x04000341 RID: 833
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Row _row;

		// Token: 0x04000342 RID: 834
		private global::System.Collections.Generic.SortedDictionary<int, global::NPOI.SS.UserModel.ICell> _cells;

		// Token: 0x04000343 RID: 835
		private global::NPOI.XSSF.UserModel.XSSFSheet _sheet;
	}
}
