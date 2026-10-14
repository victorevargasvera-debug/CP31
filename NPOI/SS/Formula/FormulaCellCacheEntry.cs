using System;
using System.Collections;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula
{
	// Token: 0x020000C5 RID: 197
	public class FormulaCellCacheEntry : global::NPOI.SS.Formula.CellCacheEntry
	{
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x0000F375 File Offset: 0x0000D575
		public bool IsInputSensitive
		{
			get
			{
				return (this._sensitiveInputCells != null && this._sensitiveInputCells.Length != 0) || (this._usedBlankCellGroup != null && !this._usedBlankCellGroup.IsEmpty);
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0000F3A2 File Offset: 0x0000D5A2
		public void SetSensitiveInputCells(global::NPOI.SS.Formula.CellCacheEntry[] sensitiveInputCells)
		{
			if (sensitiveInputCells == null)
			{
				this._sensitiveInputCells = null;
				this.ChangeConsumingCells(global::NPOI.SS.Formula.CellCacheEntry.EMPTY_ARRAY);
				return;
			}
			this._sensitiveInputCells = (global::NPOI.SS.Formula.CellCacheEntry[])sensitiveInputCells.Clone();
			this.ChangeConsumingCells(this._sensitiveInputCells);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		public void ClearFormulaEntry()
		{
			global::NPOI.SS.Formula.CellCacheEntry[] sensitiveInputCells = this._sensitiveInputCells;
			if (sensitiveInputCells != null)
			{
				for (int i = sensitiveInputCells.Length - 1; i >= 0; i--)
				{
					sensitiveInputCells[i].ClearConsumingCell(this);
				}
			}
			this._sensitiveInputCells = null;
			base.ClearValue();
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0000F418 File Offset: 0x0000D618
		private void ChangeConsumingCells(global::NPOI.SS.Formula.CellCacheEntry[] usedCells)
		{
			global::NPOI.SS.Formula.CellCacheEntry[] sensitiveInputCells = this._sensitiveInputCells;
			int num = usedCells.Length;
			for (int i = 0; i < num; i++)
			{
				usedCells[i].AddConsumingCell(this);
			}
			if (sensitiveInputCells == null)
			{
				return;
			}
			int num2 = sensitiveInputCells.Length;
			if (num2 < 1)
			{
				return;
			}
			global::System.Collections.ArrayList arrayList;
			if (num < 1)
			{
				arrayList = new global::System.Collections.ArrayList();
			}
			else
			{
				arrayList = new global::System.Collections.ArrayList(num * 3 / 2);
				for (int j = 0; j < num; j++)
				{
					arrayList.Add(usedCells[j]);
				}
			}
			for (int k = 0; k < num2; k++)
			{
				global::NPOI.SS.Formula.CellCacheEntry cellCacheEntry = sensitiveInputCells[k];
				if (!arrayList.Contains(cellCacheEntry))
				{
					cellCacheEntry.ClearConsumingCell(this);
				}
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0000F4B1 File Offset: 0x0000D6B1
		public void UpdateFormulaResult(global::NPOI.SS.Formula.Eval.ValueEval result, global::NPOI.SS.Formula.CellCacheEntry[] sensitiveInputCells, global::NPOI.SS.Formula.FormulaUsedBlankCellSet usedBlankAreas)
		{
			base.UpdateValue(result);
			this.SetSensitiveInputCells(sensitiveInputCells);
			this._usedBlankCellGroup = usedBlankAreas;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0000F4C9 File Offset: 0x0000D6C9
		public void NotifyUpdatedBlankCell(global::NPOI.SS.Formula.BookSheetKey bsk, int rowIndex, int columnIndex, global::NPOI.SS.Formula.IEvaluationListener evaluationListener)
		{
			if (this._usedBlankCellGroup != null && this._usedBlankCellGroup.ContainsCell(bsk, rowIndex, columnIndex))
			{
				this.ClearFormulaEntry();
				base.RecurseClearCachedFormulaResults(evaluationListener);
			}
		}

		// Token: 0x040003AD RID: 941
		public new static global::NPOI.SS.Formula.FormulaCellCacheEntry[] EMPTY_ARRAY = new global::NPOI.SS.Formula.FormulaCellCacheEntry[0];

		// Token: 0x040003AE RID: 942
		private global::NPOI.SS.Formula.CellCacheEntry[] _sensitiveInputCells;

		// Token: 0x040003AF RID: 943
		private global::NPOI.SS.Formula.FormulaUsedBlankCellSet _usedBlankCellGroup;
	}
}
