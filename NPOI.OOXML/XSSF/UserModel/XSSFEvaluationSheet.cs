using System;
using System.Collections.Generic;
using NPOI.SS.Formula;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200007F RID: 127
	public class XSSFEvaluationSheet : global::NPOI.SS.Formula.IEvaluationSheet
	{
		// Token: 0x060006B2 RID: 1714 RVA: 0x00017302 File Offset: 0x00015502
		public XSSFEvaluationSheet(global::NPOI.SS.UserModel.ISheet sheet)
		{
			this._xs = (global::NPOI.XSSF.UserModel.XSSFSheet)sheet;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002FA4 File Offset: 0x000011A4
		public XSSFEvaluationSheet()
		{
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00017316 File Offset: 0x00015516
		public void ClearAllCachedResultValues()
		{
			this._cellCache = null;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0001731F File Offset: 0x0001551F
		public global::NPOI.XSSF.UserModel.XSSFSheet GetXSSFSheet()
		{
			return this._xs;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00017328 File Offset: 0x00015528
		public global::NPOI.SS.Formula.IEvaluationCell GetCell(int rowIndex, int columnIndex)
		{
			if (this._cellCache == null)
			{
				this._cellCache = new global::System.Collections.Generic.Dictionary<global::NPOI.XSSF.UserModel.XSSFEvaluationSheet.CellKey, global::NPOI.SS.Formula.IEvaluationCell>(this._xs.LastRowNum * 3);
				foreach (object obj in this._xs)
				{
					global::NPOI.SS.UserModel.IRow row = (global::NPOI.SS.UserModel.IRow)obj;
					int rowNum = row.RowNum;
					foreach (global::NPOI.SS.UserModel.ICell cell in row)
					{
						global::NPOI.XSSF.UserModel.XSSFEvaluationSheet.CellKey key = new global::NPOI.XSSF.UserModel.XSSFEvaluationSheet.CellKey(rowNum, cell.ColumnIndex);
						global::NPOI.SS.Formula.IEvaluationCell value = new global::NPOI.XSSF.UserModel.XSSFEvaluationCell((global::NPOI.XSSF.UserModel.XSSFCell)cell, this);
						this._cellCache.Add(key, value);
					}
				}
			}
			global::NPOI.XSSF.UserModel.XSSFEvaluationSheet.CellKey key2 = new global::NPOI.XSSF.UserModel.XSSFEvaluationSheet.CellKey(rowIndex, columnIndex);
			global::NPOI.SS.Formula.IEvaluationCell evaluationCell = null;
			if (this._cellCache.ContainsKey(key2))
			{
				evaluationCell = this._cellCache[key2];
			}
			if (evaluationCell == null)
			{
				global::NPOI.XSSF.UserModel.XSSFRow xssfrow = this._xs.GetRow(rowIndex) as global::NPOI.XSSF.UserModel.XSSFRow;
				if (xssfrow == null)
				{
					return null;
				}
				global::NPOI.XSSF.UserModel.XSSFCell xssfcell = xssfrow.GetCell(columnIndex) as global::NPOI.XSSF.UserModel.XSSFCell;
				if (xssfcell == null)
				{
					return null;
				}
				evaluationCell = new global::NPOI.XSSF.UserModel.XSSFEvaluationCell(xssfcell, this);
				this._cellCache[key2] = evaluationCell;
			}
			return evaluationCell;
		}

		// Token: 0x040002D6 RID: 726
		private global::NPOI.XSSF.UserModel.XSSFSheet _xs;

		// Token: 0x040002D7 RID: 727
		private global::System.Collections.Generic.Dictionary<global::NPOI.XSSF.UserModel.XSSFEvaluationSheet.CellKey, global::NPOI.SS.Formula.IEvaluationCell> _cellCache;

		// Token: 0x02000126 RID: 294
		private class CellKey
		{
			// Token: 0x06000FEB RID: 4075 RVA: 0x000383F2 File Offset: 0x000365F2
			protected internal CellKey(int row, int col)
			{
				this._row = row;
				this._col = col;
			}

			// Token: 0x06000FEC RID: 4076 RVA: 0x0003840F File Offset: 0x0003660F
			public override int GetHashCode()
			{
				if (this._hash == -1)
				{
					this._hash = (629 + this._row) * 37 + this._col;
				}
				return this._hash;
			}

			// Token: 0x06000FED RID: 4077 RVA: 0x0003843C File Offset: 0x0003663C
			public override bool Equals(object obj)
			{
				if (obj == null || !(obj is global::NPOI.XSSF.UserModel.XSSFEvaluationSheet.CellKey))
				{
					return false;
				}
				global::NPOI.XSSF.UserModel.XSSFEvaluationSheet.CellKey cellKey = (global::NPOI.XSSF.UserModel.XSSFEvaluationSheet.CellKey)obj;
				return this._row == cellKey._row && this._col == cellKey._col;
			}

			// Token: 0x04000506 RID: 1286
			private int _row;

			// Token: 0x04000507 RID: 1287
			private int _col;

			// Token: 0x04000508 RID: 1288
			private int _hash = -1;
		}
	}
}
