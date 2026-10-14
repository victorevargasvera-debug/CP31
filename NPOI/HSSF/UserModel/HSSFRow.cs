using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.HSSF.Record;
using NPOI.SS;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000387 RID: 903
	[global::System.Serializable]
	public class HSSFRow : global::NPOI.SS.UserModel.IRow, global::System.Collections.Generic.IEnumerable<global::NPOI.SS.UserModel.ICell>, global::System.Collections.IEnumerable, global::System.IComparable<global::NPOI.HSSF.UserModel.HSSFRow>
	{
		// Token: 0x06001D1C RID: 7452 RVA: 0x000584ED File Offset: 0x000566ED
		[global::System.Obsolete]
		public HSSFRow()
		{
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00058500 File Offset: 0x00056700
		public HSSFRow(global::NPOI.HSSF.UserModel.HSSFWorkbook book, global::NPOI.HSSF.UserModel.HSSFSheet sheet, int rowNum) : this(book, sheet, new global::NPOI.HSSF.Record.RowRecord(rowNum))
		{
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00058510 File Offset: 0x00056710
		public HSSFRow(global::NPOI.HSSF.UserModel.HSSFWorkbook book, global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.Record.RowRecord record)
		{
			this.book = book;
			this.sheet = sheet;
			this.row = record;
			this.RowNum = record.RowNumber;
			record.SetEmpty();
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x0005854A File Offset: 0x0005674A
		public global::NPOI.SS.UserModel.ICell CreateCell(int column)
		{
			return this.CreateCell(column, global::NPOI.SS.UserModel.CellType.Blank);
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00058554 File Offset: 0x00056754
		public global::NPOI.SS.UserModel.ICell CreateCell(int columnIndex, global::NPOI.SS.UserModel.CellType type)
		{
			global::NPOI.SS.UserModel.ICell cell = new global::NPOI.HSSF.UserModel.HSSFCell(this.book, this.sheet, this.RowNum, (short)columnIndex, type);
			this.AddCell(cell);
			this.sheet.Sheet.AddValueRecord(this.RowNum, ((global::NPOI.HSSF.UserModel.HSSFCell)cell).CellValueRecord);
			return cell;
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x000585AD File Offset: 0x000567AD
		public global::NPOI.SS.UserModel.IRow CopyRowTo(int targetIndex)
		{
			return this.sheet.CopyRow(this.RowNum, targetIndex);
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x000585C1 File Offset: 0x000567C1
		public global::NPOI.SS.UserModel.ICell CopyCell(int sourceIndex, int targetIndex)
		{
			return global::NPOI.SS.Util.CellUtil.CopyCell(this, sourceIndex, targetIndex);
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x000585CB File Offset: 0x000567CB
		public void RemoveCell(global::NPOI.SS.UserModel.ICell cell)
		{
			if (cell == null)
			{
				throw new global::System.ArgumentException("cell must not be null");
			}
			this.RemoveCell((global::NPOI.HSSF.UserModel.HSSFCell)cell, true);
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x000585E8 File Offset: 0x000567E8
		private void RemoveCell(global::NPOI.SS.UserModel.ICell cell, bool alsoRemoveRecords)
		{
			int columnIndex = cell.ColumnIndex;
			if (columnIndex < 0)
			{
				throw new global::System.Exception("Negative cell indexes not allowed");
			}
			if (!this.cells.ContainsKey(columnIndex) || cell != this.cells[columnIndex])
			{
				throw new global::System.Exception("Specified cell is not from this row");
			}
			if (cell.IsPartOfArrayFormulaGroup)
			{
				((global::NPOI.HSSF.UserModel.HSSFCell)cell).NotifyArrayFormulaChanging();
			}
			this.cells.Remove(columnIndex);
			if (alsoRemoveRecords)
			{
				global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecord = ((global::NPOI.HSSF.UserModel.HSSFCell)cell).CellValueRecord;
				this.sheet.Sheet.RemoveValueRecord(this.RowNum, cellValueRecord);
			}
			if (cell.ColumnIndex + 1 == this.row.LastCol)
			{
				this.row.LastCol = this.CalculateNewLastCellPlusOne(this.row.LastCol);
			}
			if (cell.ColumnIndex == this.row.FirstCol)
			{
				this.row.FirstCol = this.CalculateNewFirstCell(this.row.FirstCol);
			}
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000586DC File Offset: 0x000568DC
		private int CalculateNewLastCellPlusOne(int lastcell)
		{
			int num = lastcell - 1;
			for (global::NPOI.SS.UserModel.ICell cell = this.RetrieveCell(num); cell == null; cell = this.RetrieveCell(--num))
			{
				if (num < 0)
				{
					return 0;
				}
			}
			return num + 1;
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00058710 File Offset: 0x00056910
		private int CalculateNewFirstCell(int firstcell)
		{
			int num = firstcell + 1;
			global::NPOI.SS.UserModel.ICell cell = this.RetrieveCell(num);
			if (this.cells.Count == 0)
			{
				return 0;
			}
			while (cell == null)
			{
				if (num <= this.cells.Count)
				{
					return 0;
				}
				cell = this.RetrieveCell(++num);
			}
			return num;
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x00058758 File Offset: 0x00056958
		public global::NPOI.SS.UserModel.ICell CreateCellFromRecord(global::NPOI.HSSF.Record.CellValueRecordInterface cell)
		{
			global::NPOI.SS.UserModel.ICell cell2 = new global::NPOI.HSSF.UserModel.HSSFCell(this.book, this.sheet, cell);
			this.AddCell(cell2);
			int column = cell.Column;
			if (this.row.IsEmpty)
			{
				this.row.FirstCol = column;
				this.row.LastCol = column + 1;
			}
			else if (column < this.row.FirstCol)
			{
				this.row.FirstCol = column;
			}
			else if (column > this.row.LastCol)
			{
				this.row.LastCol = column + 1;
			}
			return cell2;
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x000587E8 File Offset: 0x000569E8
		// (set) Token: 0x06001D29 RID: 7465 RVA: 0x000587F0 File Offset: 0x000569F0
		public bool IsHidden
		{
			get
			{
				return this.ZeroHeight;
			}
			set
			{
				this.ZeroHeight = value;
			}
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x000587FC File Offset: 0x000569FC
		public void RemoveAllCells()
		{
			global::NPOI.SS.UserModel.ICell[] array = new global::NPOI.SS.UserModel.ICell[this.cells.Values.Count];
			this.cells.Values.CopyTo(array, 0);
			foreach (global::NPOI.SS.UserModel.ICell cell in array)
			{
				this.RemoveCell(cell, true);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x0005884D File Offset: 0x00056A4D
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x00058858 File Offset: 0x00056A58
		public int RowNum
		{
			get
			{
				return this.rowNum;
			}
			set
			{
				int lastRowIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastRowIndex;
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
				this.rowNum = value;
				if (this.row != null)
				{
					this.row.RowNumber = value;
				}
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x000588D0 File Offset: 0x00056AD0
		public int OutlineLevel
		{
			get
			{
				return (int)this.row.OutlineLevel;
			}
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x000588E0 File Offset: 0x00056AE0
		public void MoveCell(global::NPOI.SS.UserModel.ICell cell, int newColumn)
		{
			if (this.cells.ContainsKey(newColumn))
			{
				throw new global::System.ArgumentException("Asked to move cell to column " + newColumn.ToString() + " but there's already a cell there");
			}
			bool flag = false;
			using (global::System.Collections.Generic.SortedDictionary<int, global::NPOI.SS.UserModel.ICell>.ValueCollection.Enumerator enumerator = this.cells.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Equals(cell))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				throw new global::System.ArgumentException("Asked to move a cell, but it didn't belong to our row");
			}
			this.RemoveCell(cell, false);
			((global::NPOI.HSSF.UserModel.HSSFCell)cell).UpdateCellNum(newColumn);
			this.AddCell(cell);
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00058994 File Offset: 0x00056B94
		public global::NPOI.SS.UserModel.ISheet Sheet
		{
			get
			{
				return this.sheet;
			}
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x0005899C File Offset: 0x00056B9C
		private void AddCell(global::NPOI.SS.UserModel.ICell cell)
		{
			int columnIndex = cell.ColumnIndex;
			if (this.cells.ContainsKey(columnIndex))
			{
				this.cells.Remove(columnIndex);
			}
			this.cells.Add(columnIndex, cell);
			if (this.row.IsEmpty || columnIndex < this.row.FirstCol)
			{
				this.row.FirstCol = columnIndex;
			}
			if (this.row.IsEmpty || columnIndex >= this.row.LastCol)
			{
				this.row.LastCol = (int)((short)(columnIndex + 1));
			}
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00058A29 File Offset: 0x00056C29
		private global::NPOI.SS.UserModel.ICell RetrieveCell(int cellnum)
		{
			if (!this.cells.ContainsKey(cellnum))
			{
				return null;
			}
			return this.cells[cellnum];
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00058A47 File Offset: 0x00056C47
		public global::NPOI.SS.UserModel.ICell GetCell(int cellnum)
		{
			return this.GetCell(cellnum, this.book.MissingCellPolicy);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00058A5C File Offset: 0x00056C5C
		public global::NPOI.SS.UserModel.ICell GetCell(int cellnum, global::NPOI.SS.UserModel.MissingCellPolicy policy)
		{
			global::NPOI.SS.UserModel.ICell cell = this.RetrieveCell(cellnum);
			switch (policy)
			{
			case global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_NULL_AND_BLANK:
				return cell;
			case global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_BLANK_AS_NULL:
				if (cell == null || cell.CellType != global::NPOI.SS.UserModel.CellType.Blank)
				{
					return cell;
				}
				return null;
			case global::NPOI.SS.UserModel.MissingCellPolicy.CREATE_NULL_AS_BLANK:
				if (cell != null)
				{
					return cell;
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

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x00058AF4 File Offset: 0x00056CF4
		public short FirstCellNum
		{
			get
			{
				if (this.row.IsEmpty)
				{
					return -1;
				}
				return (short)this.row.FirstCol;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x00058B11 File Offset: 0x00056D11
		public short LastCellNum
		{
			get
			{
				if (this.row.IsEmpty)
				{
					return -1;
				}
				return (short)this.row.LastCol;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00058B2E File Offset: 0x00056D2E
		public int PhysicalNumberOfCells
		{
			get
			{
				return this.cells.Count;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00058B3B File Offset: 0x00056D3B
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x00058B48 File Offset: 0x00056D48
		public bool ZeroHeight
		{
			get
			{
				return this.row.ZeroHeight;
			}
			set
			{
				this.row.ZeroHeight = value;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x00058B58 File Offset: 0x00056D58
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x00058B97 File Offset: 0x00056D97
		public short Height
		{
			get
			{
				short num = this.row.Height;
				if (((int)num & 32768) != 0)
				{
					num = this.sheet.Sheet.DefaultRowHeight;
				}
				else
				{
					num &= short.MaxValue;
				}
				return num;
			}
			set
			{
				if (value == -1)
				{
					this.row.Height = -32513;
					this.row.BadFontHeight = false;
					return;
				}
				this.row.BadFontHeight = true;
				this.row.Height = value;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x00058BD2 File Offset: 0x00056DD2
		public bool IsFormatted
		{
			get
			{
				return this.row.Formatted;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x00058BE0 File Offset: 0x00056DE0
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00058C22 File Offset: 0x00056E22
		public global::NPOI.SS.UserModel.ICellStyle RowStyle
		{
			get
			{
				if (!this.IsFormatted)
				{
					return null;
				}
				short xfindex = this.row.XFIndex;
				global::NPOI.HSSF.Record.ExtendedFormatRecord exFormatAt = this.book.Workbook.GetExFormatAt((int)xfindex);
				return new global::NPOI.HSSF.UserModel.HSSFCellStyle(xfindex, exFormatAt, this.book);
			}
			set
			{
				this.row.Formatted = true;
				this.row.XFIndex = value.Index;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x00058C41 File Offset: 0x00056E41
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x00058C50 File Offset: 0x00056E50
		public float HeightInPoints
		{
			get
			{
				return (float)this.Height / 20f;
			}
			set
			{
				if (value == -1f)
				{
					this.row.Height = -32513;
					return;
				}
				this.row.BadFontHeight = true;
				this.row.Height = (short)(value * 20f);
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00058C8A File Offset: 0x00056E8A
		public global::NPOI.HSSF.Record.RowRecord RowRecord
		{
			get
			{
				return this.row;
			}
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00058C94 File Offset: 0x00056E94
		[global::System.Obsolete]
		private short FindFirstCell(int firstcell)
		{
			int num = firstcell + 1;
			global::NPOI.SS.UserModel.ICell cell = this.GetCell(num);
			while (cell == null && num <= (int)this.LastCellNum)
			{
				cell = this.GetCell(++num);
			}
			if (num > (int)this.LastCellNum)
			{
				return -1;
			}
			return (short)num;
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00058CD4 File Offset: 0x00056ED4
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.ICell> Cells
		{
			get
			{
				return new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.ICell>(this.cells.Values);
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x00008C75 File Offset: 0x00006E75
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x00008C75 File Offset: 0x00006E75
		public bool? Hidden
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

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x00008C75 File Offset: 0x00006E75
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x00008C75 File Offset: 0x00006E75
		public bool? Collapsed
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

		// Token: 0x06001D47 RID: 7495 RVA: 0x00058CE6 File Offset: 0x00056EE6
		public global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ICell> GetEnumerator()
		{
			return this.cells.Values.GetEnumerator();
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00058D00 File Offset: 0x00056F00
		public int CompareTo(global::NPOI.HSSF.UserModel.HSSFRow other)
		{
			if (this.Sheet != other.Sheet)
			{
				throw new global::System.ArgumentException("The compared rows must belong to the same sheet");
			}
			return this.RowNum.CompareTo(other.RowNum);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00058D3C File Offset: 0x00056F3C
		public override bool Equals(object obj)
		{
			if (!(obj is global::NPOI.HSSF.UserModel.HSSFRow))
			{
				return false;
			}
			global::NPOI.HSSF.UserModel.HSSFRow hssfrow = (global::NPOI.HSSF.UserModel.HSSFRow)obj;
			return this.RowNum == hssfrow.RowNum && this.Sheet == hssfrow.Sheet;
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00058D78 File Offset: 0x00056F78
		public override int GetHashCode()
		{
			return this.row.GetHashCode();
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00058D85 File Offset: 0x00056F85
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00008C75 File Offset: 0x00006E75
		public bool HasCustomHeight()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000B7E RID: 2942
		public const int INITIAL_CAPACITY = 5;

		// Token: 0x04000B7F RID: 2943
		private int rowNum;

		// Token: 0x04000B80 RID: 2944
		private global::System.Collections.Generic.SortedDictionary<int, global::NPOI.SS.UserModel.ICell> cells = new global::System.Collections.Generic.SortedDictionary<int, global::NPOI.SS.UserModel.ICell>();

		// Token: 0x04000B81 RID: 2945
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.RowRecord row;

		// Token: 0x04000B82 RID: 2946
		private global::NPOI.HSSF.UserModel.HSSFWorkbook book;

		// Token: 0x04000B83 RID: 2947
		private global::NPOI.HSSF.UserModel.HSSFSheet sheet;
	}
}
