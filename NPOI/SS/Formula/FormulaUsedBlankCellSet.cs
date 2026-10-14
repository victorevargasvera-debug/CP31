using System;
using System.Collections;
using System.Text;
using NPOI.SS.Util;

namespace NPOI.SS.Formula
{
	// Token: 0x020000CE RID: 206
	public class FormulaUsedBlankCellSet
	{
		// Token: 0x060006F6 RID: 1782 RVA: 0x00011F6A File Offset: 0x0001016A
		public FormulaUsedBlankCellSet()
		{
			this._sheetGroupsByBookSheet = new global::System.Collections.Hashtable();
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00011F7D File Offset: 0x0001017D
		public void AddCell(int bookIndex, int sheetIndex, int rowIndex, int columnIndex)
		{
			this.GetSheetGroup(bookIndex, sheetIndex).AddCell(rowIndex, columnIndex);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00011F90 File Offset: 0x00010190
		private global::NPOI.SS.Formula.FormulaUsedBlankCellSet.BlankCellSheetGroup GetSheetGroup(int bookIndex, int sheetIndex)
		{
			global::NPOI.SS.Formula.BookSheetKey key = new global::NPOI.SS.Formula.BookSheetKey(bookIndex, sheetIndex);
			global::NPOI.SS.Formula.FormulaUsedBlankCellSet.BlankCellSheetGroup blankCellSheetGroup = (global::NPOI.SS.Formula.FormulaUsedBlankCellSet.BlankCellSheetGroup)this._sheetGroupsByBookSheet[key];
			if (blankCellSheetGroup == null)
			{
				blankCellSheetGroup = new global::NPOI.SS.Formula.FormulaUsedBlankCellSet.BlankCellSheetGroup();
				this._sheetGroupsByBookSheet[key] = blankCellSheetGroup;
			}
			return blankCellSheetGroup;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00011FD0 File Offset: 0x000101D0
		public bool ContainsCell(global::NPOI.SS.Formula.BookSheetKey key, int rowIndex, int columnIndex)
		{
			global::NPOI.SS.Formula.FormulaUsedBlankCellSet.BlankCellSheetGroup blankCellSheetGroup = (global::NPOI.SS.Formula.FormulaUsedBlankCellSet.BlankCellSheetGroup)this._sheetGroupsByBookSheet[key];
			return blankCellSheetGroup != null && blankCellSheetGroup.ContainsCell(rowIndex, columnIndex);
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00011FFC File Offset: 0x000101FC
		public bool IsEmpty
		{
			get
			{
				return this._sheetGroupsByBookSheet.Count == 0;
			}
		}

		// Token: 0x040003CE RID: 974
		private global::System.Collections.Hashtable _sheetGroupsByBookSheet;

		// Token: 0x02000563 RID: 1379
		private class BlankCellSheetGroup
		{
			// Token: 0x060033B9 RID: 13241 RVA: 0x000A1692 File Offset: 0x0009F892
			public BlankCellSheetGroup()
			{
				this._rectangleGroups = new global::System.Collections.ArrayList();
				this._currentRowIndex = -1;
			}

			// Token: 0x060033BA RID: 13242 RVA: 0x000A16AC File Offset: 0x0009F8AC
			public void AddCell(int rowIndex, int columnIndex)
			{
				if (this._currentRowIndex == -1)
				{
					this._currentRowIndex = rowIndex;
					this._firstColumnIndex = columnIndex;
					this._lastColumnIndex = columnIndex;
					return;
				}
				if (this._currentRowIndex == rowIndex && this._lastColumnIndex + 1 == columnIndex)
				{
					this._lastColumnIndex = columnIndex;
					return;
				}
				if (this._currentRectangleGroup == null)
				{
					this._currentRectangleGroup = new global::NPOI.SS.Formula.FormulaUsedBlankCellSet.BlankCellRectangleGroup(this._currentRowIndex, this._firstColumnIndex, this._lastColumnIndex);
				}
				else if (!this._currentRectangleGroup.AcceptRow(this._currentRowIndex, this._firstColumnIndex, this._lastColumnIndex))
				{
					this._rectangleGroups.Add(this._currentRectangleGroup);
					this._currentRectangleGroup = new global::NPOI.SS.Formula.FormulaUsedBlankCellSet.BlankCellRectangleGroup(this._currentRowIndex, this._firstColumnIndex, this._lastColumnIndex);
				}
				this._currentRowIndex = rowIndex;
				this._firstColumnIndex = columnIndex;
				this._lastColumnIndex = columnIndex;
			}

			// Token: 0x060033BB RID: 13243 RVA: 0x000A1780 File Offset: 0x0009F980
			public bool ContainsCell(int rowIndex, int columnIndex)
			{
				for (int i = this._rectangleGroups.Count - 1; i >= 0; i--)
				{
					if (((global::NPOI.SS.Formula.FormulaUsedBlankCellSet.BlankCellRectangleGroup)this._rectangleGroups[i]).ContainsCell(rowIndex, columnIndex))
					{
						return true;
					}
				}
				return (this._currentRectangleGroup != null && this._currentRectangleGroup.ContainsCell(rowIndex, columnIndex)) || (this._currentRowIndex != -1 && this._currentRowIndex == rowIndex && this._firstColumnIndex <= columnIndex && columnIndex <= this._lastColumnIndex);
			}

			// Token: 0x0400188C RID: 6284
			private global::System.Collections.IList _rectangleGroups;

			// Token: 0x0400188D RID: 6285
			private int _currentRowIndex;

			// Token: 0x0400188E RID: 6286
			private int _firstColumnIndex;

			// Token: 0x0400188F RID: 6287
			private int _lastColumnIndex;

			// Token: 0x04001890 RID: 6288
			private global::NPOI.SS.Formula.FormulaUsedBlankCellSet.BlankCellRectangleGroup _currentRectangleGroup;
		}

		// Token: 0x02000564 RID: 1380
		private class BlankCellRectangleGroup
		{
			// Token: 0x060033BC RID: 13244 RVA: 0x000A1801 File Offset: 0x0009FA01
			public BlankCellRectangleGroup(int firstRowIndex, int firstColumnIndex, int lastColumnIndex)
			{
				this._firstRowIndex = firstRowIndex;
				this._firstColumnIndex = firstColumnIndex;
				this._lastColumnIndex = lastColumnIndex;
				this._lastRowIndex = firstRowIndex;
			}

			// Token: 0x060033BD RID: 13245 RVA: 0x000A1825 File Offset: 0x0009FA25
			public bool ContainsCell(int rowIndex, int columnIndex)
			{
				return columnIndex >= this._firstColumnIndex && columnIndex <= this._lastColumnIndex && rowIndex >= this._firstRowIndex && rowIndex <= this._lastRowIndex;
			}

			// Token: 0x060033BE RID: 13246 RVA: 0x000A1854 File Offset: 0x0009FA54
			public bool AcceptRow(int rowIndex, int firstColumnIndex, int lastColumnIndex)
			{
				if (firstColumnIndex != this._firstColumnIndex)
				{
					return false;
				}
				if (lastColumnIndex != this._lastColumnIndex)
				{
					return false;
				}
				if (rowIndex != this._lastRowIndex + 1)
				{
					return false;
				}
				this._lastRowIndex = rowIndex;
				return true;
			}

			// Token: 0x060033BF RID: 13247 RVA: 0x000A1884 File Offset: 0x0009FA84
			public override string ToString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
				global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(this._firstRowIndex, this._firstColumnIndex, false, false);
				global::NPOI.SS.Util.CellReference cellReference2 = new global::NPOI.SS.Util.CellReference(this._lastRowIndex, this._lastColumnIndex, false, false);
				stringBuilder.Append(base.GetType().Name);
				stringBuilder.Append(" [").Append(cellReference.FormatAsString()).Append(':').Append(cellReference2.FormatAsString()).Append("]");
				return stringBuilder.ToString();
			}

			// Token: 0x04001891 RID: 6289
			private int _firstRowIndex;

			// Token: 0x04001892 RID: 6290
			private int _firstColumnIndex;

			// Token: 0x04001893 RID: 6291
			private int _lastColumnIndex;

			// Token: 0x04001894 RID: 6292
			private int _lastRowIndex;
		}
	}
}
