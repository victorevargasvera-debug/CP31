using System;
using System.Collections;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula
{
	// Token: 0x020000B5 RID: 181
	internal class CellEvaluationFrame
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
		public CellEvaluationFrame(global::NPOI.SS.Formula.FormulaCellCacheEntry cce)
		{
			this._cce = cce;
			this._sensitiveInputCells = new global::System.Collections.ArrayList();
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0000E4EA File Offset: 0x0000C6EA
		public global::NPOI.SS.Formula.CellCacheEntry GetCCE()
		{
			return this._cce;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0000E4F2 File Offset: 0x0000C6F2
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0000E528 File Offset: 0x0000C728
		public void AddSensitiveInputCell(global::NPOI.SS.Formula.CellCacheEntry inputCell)
		{
			this._sensitiveInputCells.Add(inputCell);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0000E538 File Offset: 0x0000C738
		private global::NPOI.SS.Formula.CellCacheEntry[] GetSensitiveInputCells()
		{
			int count = this._sensitiveInputCells.Count;
			if (count < 1)
			{
				return global::NPOI.SS.Formula.CellCacheEntry.EMPTY_ARRAY;
			}
			new global::NPOI.SS.Formula.CellCacheEntry[count];
			return (global::NPOI.SS.Formula.CellCacheEntry[])this._sensitiveInputCells.ToArray(typeof(global::NPOI.SS.Formula.CellCacheEntry));
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0000E57C File Offset: 0x0000C77C
		public void AddUsedBlankCell(int bookIndex, int sheetIndex, int rowIndex, int columnIndex)
		{
			if (this._usedBlankCellGroup == null)
			{
				this._usedBlankCellGroup = new global::NPOI.SS.Formula.FormulaUsedBlankCellSet();
			}
			this._usedBlankCellGroup.AddCell(bookIndex, sheetIndex, rowIndex, columnIndex);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0000E5A1 File Offset: 0x0000C7A1
		public void UpdateFormulaResult(global::NPOI.SS.Formula.Eval.ValueEval result)
		{
			this._cce.UpdateFormulaResult(result, this.GetSensitiveInputCells(), this._usedBlankCellGroup);
		}

		// Token: 0x04000396 RID: 918
		private global::NPOI.SS.Formula.FormulaCellCacheEntry _cce;

		// Token: 0x04000397 RID: 919
		private global::System.Collections.ArrayList _sensitiveInputCells;

		// Token: 0x04000398 RID: 920
		private global::NPOI.SS.Formula.FormulaUsedBlankCellSet _usedBlankCellGroup;
	}
}
