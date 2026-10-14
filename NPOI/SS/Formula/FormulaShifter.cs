using System;
using System.Text;
using NPOI.SS.Formula.PTG;

namespace NPOI.SS.Formula
{
	// Token: 0x020000DC RID: 220
	public class FormulaShifter
	{
		// Token: 0x0600075D RID: 1885 RVA: 0x00013654 File Offset: 0x00011854
		private FormulaShifter(int externSheetIndex, string sheetName, int firstMovedIndex, int lastMovedIndex, int amountToMove, global::NPOI.SS.Formula.FormulaShifter.ShiftMode mode, global::NPOI.SS.SpreadsheetVersion version)
		{
			if (amountToMove == 0)
			{
				throw new global::System.ArgumentException("amountToMove must not be zero");
			}
			if (firstMovedIndex > lastMovedIndex)
			{
				throw new global::System.ArgumentException("firstMovedIndex, lastMovedIndex out of order");
			}
			this._externSheetIndex = externSheetIndex;
			this._sheetName = sheetName;
			this._firstMovedIndex = firstMovedIndex;
			this._lastMovedIndex = lastMovedIndex;
			this._amountToMove = amountToMove;
			this._mode = mode;
			this._version = version;
			this._srcSheetIndex = (this._dstSheetIndex = -1);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000136CC File Offset: 0x000118CC
		private FormulaShifter(int srcSheetIndex, int dstSheetIndex)
		{
			this._externSheetIndex = (this._firstMovedIndex = (this._lastMovedIndex = (this._amountToMove = -1)));
			this._sheetName = null;
			this._version = null;
			this._srcSheetIndex = srcSheetIndex;
			this._dstSheetIndex = dstSheetIndex;
			this._mode = global::NPOI.SS.Formula.FormulaShifter.ShiftMode.SheetMove;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00013724 File Offset: 0x00011924
		[global::System.Obsolete("deprecated As of 3.14 beta 1 (November 2015), replaced by CreateForRowShift(int, String, int, int, int, SpreadsheetVersion)")]
		public static global::NPOI.SS.Formula.FormulaShifter CreateForRowShift(int externSheetIndex, string sheetName, int firstMovedRowIndex, int lastMovedRowIndex, int numberOfRowsToMove)
		{
			return global::NPOI.SS.Formula.FormulaShifter.CreateForRowShift(externSheetIndex, sheetName, firstMovedRowIndex, lastMovedRowIndex, numberOfRowsToMove, global::NPOI.SS.SpreadsheetVersion.EXCEL97);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00013736 File Offset: 0x00011936
		public static global::NPOI.SS.Formula.FormulaShifter CreateForRowShift(int externSheetIndex, string sheetName, int firstMovedRowIndex, int lastMovedRowIndex, int numberOfRowsToMove, global::NPOI.SS.SpreadsheetVersion version)
		{
			return new global::NPOI.SS.Formula.FormulaShifter(externSheetIndex, sheetName, firstMovedRowIndex, lastMovedRowIndex, numberOfRowsToMove, global::NPOI.SS.Formula.FormulaShifter.ShiftMode.RowMove, version);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00013746 File Offset: 0x00011946
		public static global::NPOI.SS.Formula.FormulaShifter CreateForRowCopy(int externSheetIndex, string sheetName, int firstMovedRowIndex, int lastMovedRowIndex, int numberOfRowsToMove, global::NPOI.SS.SpreadsheetVersion version)
		{
			return new global::NPOI.SS.Formula.FormulaShifter(externSheetIndex, sheetName, firstMovedRowIndex, lastMovedRowIndex, numberOfRowsToMove, global::NPOI.SS.Formula.FormulaShifter.ShiftMode.RowCopy, version);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00013756 File Offset: 0x00011956
		public static global::NPOI.SS.Formula.FormulaShifter CreateForSheetShift(int srcSheetIndex, int dstSheetIndex)
		{
			return new global::NPOI.SS.Formula.FormulaShifter(srcSheetIndex, dstSheetIndex);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00013760 File Offset: 0x00011960
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append(" [");
			stringBuilder.Append(this._firstMovedIndex);
			stringBuilder.Append(this._lastMovedIndex);
			stringBuilder.Append(this._amountToMove);
			return stringBuilder.ToString();
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000137BC File Offset: 0x000119BC
		public bool AdjustFormula(global::NPOI.SS.Formula.PTG.Ptg[] ptgs, int currentExternSheetIx)
		{
			bool result = false;
			for (int i = 0; i < ptgs.Length; i++)
			{
				global::NPOI.SS.Formula.PTG.Ptg ptg = this.AdjustPtg(ptgs[i], currentExternSheetIx);
				if (ptg != null)
				{
					result = true;
					ptgs[i] = ptg;
				}
			}
			return result;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000137F0 File Offset: 0x000119F0
		private global::NPOI.SS.Formula.PTG.Ptg AdjustPtg(global::NPOI.SS.Formula.PTG.Ptg ptg, int currentExternSheetIx)
		{
			switch (this._mode)
			{
			case global::NPOI.SS.Formula.FormulaShifter.ShiftMode.RowMove:
				return this.AdjustPtgDueToRowMove(ptg, currentExternSheetIx);
			case global::NPOI.SS.Formula.FormulaShifter.ShiftMode.RowCopy:
				return this.AdjustPtgDueToRowCopy(ptg);
			case global::NPOI.SS.Formula.FormulaShifter.ShiftMode.SheetMove:
				return this.AdjustPtgDueToSheetMove(ptg);
			default:
				throw new global::System.InvalidOperationException("Unsupported shift mode: " + this._mode.ToString());
			}
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00013854 File Offset: 0x00011A54
		private global::NPOI.SS.Formula.PTG.Ptg AdjustPtgDueToRowMove(global::NPOI.SS.Formula.PTG.Ptg ptg, int currentExternSheetIx)
		{
			if (ptg is global::NPOI.SS.Formula.PTG.RefPtg)
			{
				if (currentExternSheetIx != this._externSheetIndex)
				{
					return null;
				}
				global::NPOI.SS.Formula.PTG.RefPtg rptg = (global::NPOI.SS.Formula.PTG.RefPtg)ptg;
				return this.RowMoveRefPtg(rptg);
			}
			else if (ptg is global::NPOI.SS.Formula.PTG.Ref3DPtg)
			{
				global::NPOI.SS.Formula.PTG.Ref3DPtg ref3DPtg = (global::NPOI.SS.Formula.PTG.Ref3DPtg)ptg;
				if (this._externSheetIndex != ref3DPtg.ExternSheetIndex)
				{
					return null;
				}
				return this.RowMoveRefPtg(ref3DPtg);
			}
			else if (ptg is global::NPOI.SS.Formula.PTG.Ref3DPxg)
			{
				global::NPOI.SS.Formula.PTG.Ref3DPxg ref3DPxg = (global::NPOI.SS.Formula.PTG.Ref3DPxg)ptg;
				if (ref3DPxg.ExternalWorkbookNumber > 0 || !this._sheetName.Equals(ref3DPxg.SheetName))
				{
					return null;
				}
				return this.RowMoveRefPtg(ref3DPxg);
			}
			else if (ptg is global::NPOI.SS.Formula.PTG.Area2DPtgBase)
			{
				if (currentExternSheetIx != this._externSheetIndex)
				{
					return ptg;
				}
				return this.RowMoveAreaPtg((global::NPOI.SS.Formula.PTG.Area2DPtgBase)ptg);
			}
			else if (ptg is global::NPOI.SS.Formula.PTG.Area3DPtg)
			{
				global::NPOI.SS.Formula.PTG.Area3DPtg area3DPtg = (global::NPOI.SS.Formula.PTG.Area3DPtg)ptg;
				if (this._externSheetIndex != area3DPtg.ExternSheetIndex)
				{
					return null;
				}
				return this.RowMoveAreaPtg(area3DPtg);
			}
			else
			{
				if (!(ptg is global::NPOI.SS.Formula.PTG.Area3DPxg))
				{
					return null;
				}
				global::NPOI.SS.Formula.PTG.Area3DPxg area3DPxg = (global::NPOI.SS.Formula.PTG.Area3DPxg)ptg;
				if (area3DPxg.ExternalWorkbookNumber > 0 || !this._sheetName.Equals(area3DPxg.SheetName))
				{
					return null;
				}
				return this.RowMoveAreaPtg(area3DPxg);
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00013960 File Offset: 0x00011B60
		private global::NPOI.SS.Formula.PTG.Ptg AdjustPtgDueToRowCopy(global::NPOI.SS.Formula.PTG.Ptg ptg)
		{
			if (ptg is global::NPOI.SS.Formula.PTG.RefPtg)
			{
				global::NPOI.SS.Formula.PTG.RefPtg rptg = (global::NPOI.SS.Formula.PTG.RefPtg)ptg;
				return this.RowCopyRefPtg(rptg);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Ref3DPtg)
			{
				global::NPOI.SS.Formula.PTG.Ref3DPtg rptg2 = (global::NPOI.SS.Formula.PTG.Ref3DPtg)ptg;
				return this.RowCopyRefPtg(rptg2);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Ref3DPxg)
			{
				global::NPOI.SS.Formula.PTG.Ref3DPxg rptg3 = (global::NPOI.SS.Formula.PTG.Ref3DPxg)ptg;
				return this.RowCopyRefPtg(rptg3);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Area2DPtgBase)
			{
				return this.RowCopyAreaPtg((global::NPOI.SS.Formula.PTG.Area2DPtgBase)ptg);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Area3DPtg)
			{
				global::NPOI.SS.Formula.PTG.Area3DPtg aptg = (global::NPOI.SS.Formula.PTG.Area3DPtg)ptg;
				return this.RowCopyAreaPtg(aptg);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Area3DPxg)
			{
				global::NPOI.SS.Formula.PTG.Area3DPxg aptg2 = (global::NPOI.SS.Formula.PTG.Area3DPxg)ptg;
				return this.RowCopyAreaPtg(aptg2);
			}
			return null;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x000139F8 File Offset: 0x00011BF8
		private global::NPOI.SS.Formula.PTG.Ptg AdjustPtgDueToSheetMove(global::NPOI.SS.Formula.PTG.Ptg ptg)
		{
			if (ptg is global::NPOI.SS.Formula.PTG.Ref3DPtg)
			{
				global::NPOI.SS.Formula.PTG.Ref3DPtg ref3DPtg = (global::NPOI.SS.Formula.PTG.Ref3DPtg)ptg;
				int externSheetIndex = ref3DPtg.ExternSheetIndex;
				if (externSheetIndex < this._srcSheetIndex && externSheetIndex < this._dstSheetIndex)
				{
					return null;
				}
				if (externSheetIndex > this._srcSheetIndex && externSheetIndex > this._dstSheetIndex)
				{
					return null;
				}
				if (externSheetIndex == this._srcSheetIndex)
				{
					ref3DPtg.ExternSheetIndex = this._dstSheetIndex;
					return ref3DPtg;
				}
				if (this._dstSheetIndex < this._srcSheetIndex)
				{
					ref3DPtg.ExternSheetIndex = externSheetIndex + 1;
					return ref3DPtg;
				}
				if (this._dstSheetIndex > this._srcSheetIndex)
				{
					ref3DPtg.ExternSheetIndex = externSheetIndex - 1;
					return ref3DPtg;
				}
			}
			return null;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00013A90 File Offset: 0x00011C90
		private global::NPOI.SS.Formula.PTG.Ptg RowMoveRefPtg(global::NPOI.SS.Formula.PTG.RefPtgBase rptg)
		{
			int row = rptg.Row;
			if (this._firstMovedIndex <= row && row <= this._lastMovedIndex)
			{
				rptg.Row = row + this._amountToMove;
				return rptg;
			}
			int num = this._firstMovedIndex + this._amountToMove;
			int num2 = this._lastMovedIndex + this._amountToMove;
			if (num2 < row || row < num)
			{
				return null;
			}
			if (num <= row && row <= num2)
			{
				return global::NPOI.SS.Formula.FormulaShifter.CreateDeletedRef(rptg);
			}
			throw new global::System.InvalidOperationException(string.Concat(new string[]
			{
				"Situation not covered: (",
				this._firstMovedIndex.ToString(),
				", ",
				this._lastMovedIndex.ToString(),
				", ",
				this._amountToMove.ToString(),
				", ",
				row.ToString(),
				", ",
				row.ToString(),
				")"
			}));
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00013B7C File Offset: 0x00011D7C
		private global::NPOI.SS.Formula.PTG.Ptg RowMoveAreaPtg(global::NPOI.SS.Formula.PTG.AreaPtgBase aptg)
		{
			int firstRow = aptg.FirstRow;
			int lastRow = aptg.LastRow;
			if (this._firstMovedIndex <= firstRow && lastRow <= this._lastMovedIndex)
			{
				aptg.FirstRow = firstRow + this._amountToMove;
				aptg.LastRow = lastRow + this._amountToMove;
				return aptg;
			}
			int num = this._firstMovedIndex + this._amountToMove;
			int num2 = this._lastMovedIndex + this._amountToMove;
			if (firstRow < this._firstMovedIndex && this._lastMovedIndex < lastRow)
			{
				if (num < firstRow && firstRow <= num2)
				{
					aptg.FirstRow = num2 + 1;
					return aptg;
				}
				if (num <= lastRow && lastRow < num2)
				{
					aptg.LastRow = num - 1;
					return aptg;
				}
				return null;
			}
			else if (this._firstMovedIndex <= firstRow && firstRow <= this._lastMovedIndex)
			{
				if (this._amountToMove < 0)
				{
					aptg.FirstRow = firstRow + this._amountToMove;
					return aptg;
				}
				if (num > lastRow)
				{
					return null;
				}
				int firstRow2 = firstRow + this._amountToMove;
				if (num2 < lastRow)
				{
					aptg.FirstRow = firstRow2;
					return aptg;
				}
				int num3 = this._lastMovedIndex + 1;
				if (num > num3)
				{
					firstRow2 = num3;
				}
				aptg.FirstRow = firstRow2;
				aptg.LastRow = global::System.Math.Max(lastRow, num2);
				return aptg;
			}
			else if (this._firstMovedIndex <= lastRow && lastRow <= this._lastMovedIndex)
			{
				if (this._amountToMove > 0)
				{
					aptg.LastRow = lastRow + this._amountToMove;
					return aptg;
				}
				if (num2 < firstRow)
				{
					return null;
				}
				int lastRow2 = lastRow + this._amountToMove;
				if (num > firstRow)
				{
					aptg.LastRow = lastRow2;
					return aptg;
				}
				int num4 = this._firstMovedIndex - 1;
				if (num2 < num4)
				{
					lastRow2 = num4;
				}
				aptg.FirstRow = global::System.Math.Min(firstRow, num);
				aptg.LastRow = lastRow2;
				return aptg;
			}
			else
			{
				if (num2 < firstRow || lastRow < num)
				{
					return null;
				}
				if (num <= firstRow && lastRow <= num2)
				{
					return global::NPOI.SS.Formula.FormulaShifter.CreateDeletedRef(aptg);
				}
				if (firstRow <= num && num2 <= lastRow)
				{
					return null;
				}
				if (num < firstRow && firstRow <= num2)
				{
					aptg.FirstRow = num2 + 1;
					return aptg;
				}
				if (num <= lastRow && lastRow < num2)
				{
					aptg.LastRow = num - 1;
					return aptg;
				}
				throw new global::System.InvalidOperationException(string.Concat(new string[]
				{
					"Situation not covered: (",
					this._firstMovedIndex.ToString(),
					", ",
					this._lastMovedIndex.ToString(),
					", ",
					this._amountToMove.ToString(),
					", ",
					firstRow.ToString(),
					", ",
					lastRow.ToString(),
					")"
				}));
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00013DD0 File Offset: 0x00011FD0
		private global::NPOI.SS.Formula.PTG.Ptg RowCopyRefPtg(global::NPOI.SS.Formula.PTG.RefPtgBase rptg)
		{
			int row = rptg.Row;
			if (!rptg.IsRowRelative)
			{
				return null;
			}
			int num = this._firstMovedIndex + this._amountToMove;
			if (num < 0 || this._version.LastRowIndex < num)
			{
				return global::NPOI.SS.Formula.FormulaShifter.CreateDeletedRef(rptg);
			}
			rptg.Row = row + this._amountToMove;
			return rptg;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00013E24 File Offset: 0x00012024
		private global::NPOI.SS.Formula.PTG.Ptg RowCopyAreaPtg(global::NPOI.SS.Formula.PTG.AreaPtgBase aptg)
		{
			bool flag = false;
			int firstRow = aptg.FirstRow;
			int lastRow = aptg.LastRow;
			if (aptg.IsFirstRowRelative)
			{
				int num = firstRow + this._amountToMove;
				if (num < 0 || this._version.LastRowIndex < num)
				{
					return global::NPOI.SS.Formula.FormulaShifter.CreateDeletedRef(aptg);
				}
				aptg.FirstRow = num;
				flag = true;
			}
			if (aptg.IsLastRowRelative)
			{
				int num2 = lastRow + this._amountToMove;
				if (num2 < 0 || this._version.LastRowIndex < num2)
				{
					return global::NPOI.SS.Formula.FormulaShifter.CreateDeletedRef(aptg);
				}
				aptg.LastRow = num2;
				flag = true;
			}
			if (flag)
			{
				aptg.SortTopLeftToBottomRight();
			}
			if (!flag)
			{
				return null;
			}
			return aptg;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00013EBC File Offset: 0x000120BC
		private static global::NPOI.SS.Formula.PTG.Ptg CreateDeletedRef(global::NPOI.SS.Formula.PTG.Ptg ptg)
		{
			if (ptg is global::NPOI.SS.Formula.PTG.RefPtg)
			{
				return new global::NPOI.SS.Formula.PTG.RefErrorPtg();
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Ref3DPtg)
			{
				return new global::NPOI.SS.Formula.PTG.DeletedRef3DPtg(((global::NPOI.SS.Formula.PTG.Ref3DPtg)ptg).ExternSheetIndex);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.AreaPtg)
			{
				return new global::NPOI.SS.Formula.PTG.AreaErrPtg();
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Area3DPtg)
			{
				return new global::NPOI.SS.Formula.PTG.DeletedArea3DPtg(((global::NPOI.SS.Formula.PTG.Area3DPtg)ptg).ExternSheetIndex);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Ref3DPxg)
			{
				global::NPOI.SS.Formula.PTG.Ref3DPxg ref3DPxg = (global::NPOI.SS.Formula.PTG.Ref3DPxg)ptg;
				return new global::NPOI.SS.Formula.PTG.Deleted3DPxg(ref3DPxg.ExternalWorkbookNumber, ref3DPxg.SheetName);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Area3DPxg)
			{
				global::NPOI.SS.Formula.PTG.Area3DPxg area3DPxg = (global::NPOI.SS.Formula.PTG.Area3DPxg)ptg;
				return new global::NPOI.SS.Formula.PTG.Deleted3DPxg(area3DPxg.ExternalWorkbookNumber, area3DPxg.SheetName);
			}
			throw new global::System.ArgumentException("Unexpected ref ptg class (" + ptg.GetType().Name + ")");
		}

		// Token: 0x040003E4 RID: 996
		private int _externSheetIndex;

		// Token: 0x040003E5 RID: 997
		private string _sheetName;

		// Token: 0x040003E6 RID: 998
		private int _firstMovedIndex;

		// Token: 0x040003E7 RID: 999
		private int _lastMovedIndex;

		// Token: 0x040003E8 RID: 1000
		private int _amountToMove;

		// Token: 0x040003E9 RID: 1001
		private int _srcSheetIndex;

		// Token: 0x040003EA RID: 1002
		private int _dstSheetIndex;

		// Token: 0x040003EB RID: 1003
		private global::NPOI.SS.SpreadsheetVersion _version;

		// Token: 0x040003EC RID: 1004
		private global::NPOI.SS.Formula.FormulaShifter.ShiftMode _mode;

		// Token: 0x02000566 RID: 1382
		private enum ShiftMode
		{
			// Token: 0x04001898 RID: 6296
			RowMove,
			// Token: 0x04001899 RID: 6297
			RowCopy,
			// Token: 0x0400189A RID: 6298
			SheetMove
		}
	}
}
