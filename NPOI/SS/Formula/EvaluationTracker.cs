using System;
using System.Collections;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula
{
	// Token: 0x020000BC RID: 188
	public class EvaluationTracker
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x0000EEAE File Offset: 0x0000D0AE
		public EvaluationTracker(global::NPOI.SS.Formula.EvaluationCache cache)
		{
			this._cache = cache;
			this._evaluationFrames = new global::System.Collections.ArrayList();
			this._currentlyEvaluatingCells = new global::System.Collections.ArrayList();
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000EED3 File Offset: 0x0000D0D3
		public bool StartEvaluate(global::NPOI.SS.Formula.FormulaCellCacheEntry cce)
		{
			if (cce == null)
			{
				throw new global::System.ArgumentException("cellLoc must not be null");
			}
			if (this._currentlyEvaluatingCells.Contains(cce))
			{
				return false;
			}
			this._currentlyEvaluatingCells.Add(cce);
			this._evaluationFrames.Add(new global::NPOI.SS.Formula.CellEvaluationFrame(cce));
			return true;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0000EF14 File Offset: 0x0000D114
		public void UpdateCacheResult(global::NPOI.SS.Formula.Eval.ValueEval result)
		{
			int count = this._evaluationFrames.Count;
			if (count < 1)
			{
				throw new global::System.InvalidOperationException("Call To endEvaluate without matching call To startEvaluate");
			}
			((global::NPOI.SS.Formula.CellEvaluationFrame)this._evaluationFrames[count - 1]).UpdateFormulaResult(result);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0000EF58 File Offset: 0x0000D158
		public void EndEvaluate(global::NPOI.SS.Formula.CellCacheEntry cce)
		{
			int num = this._evaluationFrames.Count;
			if (num < 1)
			{
				throw new global::System.InvalidOperationException("Call To endEvaluate without matching call To startEvaluate");
			}
			num--;
			global::NPOI.SS.Formula.CellEvaluationFrame cellEvaluationFrame = (global::NPOI.SS.Formula.CellEvaluationFrame)this._evaluationFrames[num];
			if (cce != cellEvaluationFrame.GetCCE())
			{
				throw new global::System.InvalidOperationException("Wrong cell specified. ");
			}
			this._evaluationFrames.RemoveAt(num);
			this._currentlyEvaluatingCells.Remove(cce);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000EFC4 File Offset: 0x0000D1C4
		public void AcceptFormulaDependency(global::NPOI.SS.Formula.CellCacheEntry cce)
		{
			int num = this._evaluationFrames.Count - 1;
			if (num >= 0)
			{
				((global::NPOI.SS.Formula.CellEvaluationFrame)this._evaluationFrames[num]).AddSensitiveInputCell(cce);
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0000EFFC File Offset: 0x0000D1FC
		public void AcceptPlainValueDependency(int bookIndex, int sheetIndex, int rowIndex, int columnIndex, global::NPOI.SS.Formula.Eval.ValueEval value)
		{
			int num = this._evaluationFrames.Count - 1;
			if (num >= 0)
			{
				global::NPOI.SS.Formula.CellEvaluationFrame cellEvaluationFrame = (global::NPOI.SS.Formula.CellEvaluationFrame)this._evaluationFrames[num];
				if (value == global::NPOI.SS.Formula.Eval.BlankEval.instance)
				{
					cellEvaluationFrame.AddUsedBlankCell(bookIndex, sheetIndex, rowIndex, columnIndex);
					return;
				}
				global::NPOI.SS.Formula.PlainValueCellCacheEntry plainValueEntry = this._cache.GetPlainValueEntry(bookIndex, sheetIndex, rowIndex, columnIndex, value);
				cellEvaluationFrame.AddSensitiveInputCell(plainValueEntry);
			}
		}

		// Token: 0x040003A0 RID: 928
		private global::System.Collections.IList _evaluationFrames;

		// Token: 0x040003A1 RID: 929
		private global::System.Collections.IList _currentlyEvaluatingCells;

		// Token: 0x040003A2 RID: 930
		private global::NPOI.SS.Formula.EvaluationCache _cache;
	}
}
