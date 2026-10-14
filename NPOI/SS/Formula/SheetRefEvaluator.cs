using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula
{
	// Token: 0x020000DE RID: 222
	public class SheetRefEvaluator
	{
		// Token: 0x06000779 RID: 1913 RVA: 0x00014253 File Offset: 0x00012453
		public SheetRefEvaluator(global::NPOI.SS.Formula.WorkbookEvaluator bookEvaluator, global::NPOI.SS.Formula.EvaluationTracker tracker, int sheetIndex)
		{
			if (sheetIndex < 0)
			{
				throw new global::System.ArgumentException("Invalid sheetIndex: " + sheetIndex.ToString() + ".");
			}
			this._bookEvaluator = bookEvaluator;
			this._tracker = tracker;
			this._sheetIndex = sheetIndex;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00014290 File Offset: 0x00012490
		public string SheetName
		{
			get
			{
				return this._bookEvaluator.GetSheetName(this._sheetIndex);
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000142A3 File Offset: 0x000124A3
		public global::NPOI.SS.Formula.Eval.ValueEval GetEvalForCell(int rowIndex, int columnIndex)
		{
			return this._bookEvaluator.EvaluateReference(this.Sheet, this._sheetIndex, rowIndex, columnIndex, this._tracker);
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x000142C4 File Offset: 0x000124C4
		private global::NPOI.SS.Formula.IEvaluationSheet Sheet
		{
			get
			{
				if (this._sheet == null)
				{
					this._sheet = this._bookEvaluator.GetSheet(this._sheetIndex);
				}
				return this._sheet;
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000142EC File Offset: 0x000124EC
		public bool IsSubTotal(int rowIndex, int columnIndex)
		{
			bool result = false;
			global::NPOI.SS.Formula.IEvaluationCell cell = this.Sheet.GetCell(rowIndex, columnIndex);
			if (cell != null && cell.CellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in this._bookEvaluator.Workbook.GetFormulaTokens(cell))
				{
					if (ptg is global::NPOI.SS.Formula.PTG.FuncVarPtg)
					{
						global::NPOI.SS.Formula.PTG.FuncVarPtg funcVarPtg = (global::NPOI.SS.Formula.PTG.FuncVarPtg)ptg;
						if ("SUBTOTAL".Equals(funcVarPtg.Name))
						{
							result = true;
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x040003F3 RID: 1011
		private global::NPOI.SS.Formula.WorkbookEvaluator _bookEvaluator;

		// Token: 0x040003F4 RID: 1012
		private global::NPOI.SS.Formula.EvaluationTracker _tracker;

		// Token: 0x040003F5 RID: 1013
		private global::NPOI.SS.Formula.IEvaluationSheet _sheet;

		// Token: 0x040003F6 RID: 1014
		private int _sheetIndex;
	}
}
