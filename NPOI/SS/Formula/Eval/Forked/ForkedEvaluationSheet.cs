using System;
using System.Collections.Generic;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.SS.Formula.Eval.Forked
{
	// Token: 0x0200022B RID: 555
	internal class ForkedEvaluationSheet : global::NPOI.SS.Formula.IEvaluationSheet
	{
		// Token: 0x06000D90 RID: 3472 RVA: 0x00025D42 File Offset: 0x00023F42
		public ForkedEvaluationSheet(global::NPOI.SS.Formula.IEvaluationSheet masterSheet)
		{
			this._masterSheet = masterSheet;
			this._sharedCellsByRowCol = new global::System.Collections.Generic.Dictionary<global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey, global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationCell>();
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00025D5C File Offset: 0x00023F5C
		public global::NPOI.SS.Formula.IEvaluationCell GetCell(int rowIndex, int columnIndex)
		{
			global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey key = new global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey(rowIndex, columnIndex);
			global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationCell forkedEvaluationCell = null;
			if (this._sharedCellsByRowCol.ContainsKey(key))
			{
				forkedEvaluationCell = this._sharedCellsByRowCol[key];
			}
			if (forkedEvaluationCell == null)
			{
				return this._masterSheet.GetCell(rowIndex, columnIndex);
			}
			return forkedEvaluationCell;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00025DA0 File Offset: 0x00023FA0
		public global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationCell GetOrCreateUpdatableCell(int rowIndex, int columnIndex)
		{
			global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey key = new global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey(rowIndex, columnIndex);
			global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationCell forkedEvaluationCell = null;
			if (this._sharedCellsByRowCol.ContainsKey(key))
			{
				forkedEvaluationCell = this._sharedCellsByRowCol[key];
			}
			if (forkedEvaluationCell == null)
			{
				global::NPOI.SS.Formula.IEvaluationCell cell = this._masterSheet.GetCell(rowIndex, columnIndex);
				if (cell == null)
				{
					global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(rowIndex, columnIndex);
					throw new global::System.InvalidOperationException("Underlying cell '" + cellReference.FormatAsString() + "' is missing in master sheet.");
				}
				forkedEvaluationCell = new global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationCell(this, cell);
				if (this._sharedCellsByRowCol.ContainsKey(key))
				{
					this._sharedCellsByRowCol[key] = forkedEvaluationCell;
				}
				else
				{
					this._sharedCellsByRowCol.Add(key, forkedEvaluationCell);
				}
			}
			return forkedEvaluationCell;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00025E3C File Offset: 0x0002403C
		public void CopyUpdatedCells(global::NPOI.SS.UserModel.ISheet sheet)
		{
			global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey[] array = new global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey[this._sharedCellsByRowCol.Count];
			this._sharedCellsByRowCol.Keys.CopyTo(array, 0);
			global::System.Array.Sort<global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey>(array);
			foreach (global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey rowColKey in array)
			{
				global::NPOI.SS.UserModel.IRow row = sheet.GetRow(rowColKey.RowIndex);
				if (row == null)
				{
					row = sheet.CreateRow(rowColKey.RowIndex);
				}
				global::NPOI.SS.UserModel.ICell cell = row.GetCell(rowColKey.ColumnIndex);
				if (cell == null)
				{
					cell = row.CreateCell(rowColKey.ColumnIndex);
				}
				this._sharedCellsByRowCol[rowColKey].CopyValue(cell);
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00025ED4 File Offset: 0x000240D4
		public int GetSheetIndex(global::NPOI.SS.Formula.IEvaluationWorkbook mewb)
		{
			return mewb.GetSheetIndex(this._masterSheet);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00025EE2 File Offset: 0x000240E2
		public void ClearAllCachedResultValues()
		{
			this._masterSheet.ClearAllCachedResultValues();
		}

		// Token: 0x04000618 RID: 1560
		private global::NPOI.SS.Formula.IEvaluationSheet _masterSheet;

		// Token: 0x04000619 RID: 1561
		private global::System.Collections.Generic.Dictionary<global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey, global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationCell> _sharedCellsByRowCol;

		// Token: 0x02000590 RID: 1424
		private class RowColKey : global::System.IComparable<global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey>
		{
			// Token: 0x06003446 RID: 13382 RVA: 0x000A2BE2 File Offset: 0x000A0DE2
			public RowColKey(int rowIndex, int columnIndex)
			{
				this._rowIndex = rowIndex;
				this._columnIndex = columnIndex;
			}

			// Token: 0x06003447 RID: 13383 RVA: 0x000A2BF8 File Offset: 0x000A0DF8
			public override bool Equals(object obj)
			{
				global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey rowColKey = (global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey)obj;
				return this._rowIndex == rowColKey._rowIndex && this._columnIndex == rowColKey._columnIndex;
			}

			// Token: 0x06003448 RID: 13384 RVA: 0x000A2C2A File Offset: 0x000A0E2A
			public override int GetHashCode()
			{
				return this._rowIndex ^ this._columnIndex;
			}

			// Token: 0x06003449 RID: 13385 RVA: 0x000A2C3C File Offset: 0x000A0E3C
			public int CompareTo(global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationSheet.RowColKey o)
			{
				int num = this._rowIndex - o._rowIndex;
				if (num != 0)
				{
					return num;
				}
				return this._columnIndex - o._columnIndex;
			}

			// Token: 0x17000DB3 RID: 3507
			// (get) Token: 0x0600344A RID: 13386 RVA: 0x000A2C69 File Offset: 0x000A0E69
			public int RowIndex
			{
				get
				{
					return this._rowIndex;
				}
			}

			// Token: 0x17000DB4 RID: 3508
			// (get) Token: 0x0600344B RID: 13387 RVA: 0x000A2C71 File Offset: 0x000A0E71
			public int ColumnIndex
			{
				get
				{
					return this._columnIndex;
				}
			}

			// Token: 0x040018FC RID: 6396
			private int _rowIndex;

			// Token: 0x040018FD RID: 6397
			private int _columnIndex;
		}
	}
}
