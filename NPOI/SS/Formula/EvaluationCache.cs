using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula
{
	// Token: 0x020000B8 RID: 184
	public class EvaluationCache
	{
		// Token: 0x06000641 RID: 1601 RVA: 0x0000EA9C File Offset: 0x0000CC9C
		public EvaluationCache(global::NPOI.SS.Formula.IEvaluationListener evaluationListener)
		{
			this._evaluationListener = evaluationListener;
			this._plainCellCache = new global::NPOI.SS.Formula.PlainCellCache();
			this._formulaCellCache = new global::NPOI.SS.Formula.FormulaCellCache();
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0000EAC4 File Offset: 0x0000CCC4
		public void NotifyUpdateCell(int bookIndex, int sheetIndex, global::NPOI.SS.Formula.IEvaluationCell cell)
		{
			global::NPOI.SS.Formula.FormulaCellCacheEntry formulaCellCacheEntry = this._formulaCellCache.Get(cell);
			int rowIndex = cell.RowIndex;
			int columnIndex = cell.ColumnIndex;
			global::NPOI.SS.Formula.Loc key = new global::NPOI.SS.Formula.Loc(bookIndex, sheetIndex, cell.RowIndex, cell.ColumnIndex);
			global::NPOI.SS.Formula.PlainValueCellCacheEntry plainValueCellCacheEntry = this._plainCellCache.Get(key);
			if (cell.CellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				if (formulaCellCacheEntry == null)
				{
					formulaCellCacheEntry = new global::NPOI.SS.Formula.FormulaCellCacheEntry();
					if (plainValueCellCacheEntry == null)
					{
						if (this._evaluationListener != null)
						{
							this._evaluationListener.OnChangeFromBlankValue(sheetIndex, rowIndex, columnIndex, cell, formulaCellCacheEntry);
						}
						this.UpdateAnyBlankReferencingFormulas(bookIndex, sheetIndex, rowIndex, columnIndex);
					}
					this._formulaCellCache.Put(cell, formulaCellCacheEntry);
				}
				else
				{
					formulaCellCacheEntry.RecurseClearCachedFormulaResults(this._evaluationListener);
					formulaCellCacheEntry.ClearFormulaEntry();
				}
				if (plainValueCellCacheEntry != null)
				{
					plainValueCellCacheEntry.RecurseClearCachedFormulaResults(this._evaluationListener);
					this._plainCellCache.Remove(key);
					return;
				}
			}
			else
			{
				global::NPOI.SS.Formula.Eval.ValueEval valueFromNonFormulaCell = global::NPOI.SS.Formula.WorkbookEvaluator.GetValueFromNonFormulaCell(cell);
				if (plainValueCellCacheEntry == null)
				{
					if (valueFromNonFormulaCell != global::NPOI.SS.Formula.Eval.BlankEval.instance)
					{
						plainValueCellCacheEntry = new global::NPOI.SS.Formula.PlainValueCellCacheEntry(valueFromNonFormulaCell);
						if (formulaCellCacheEntry == null)
						{
							if (this._evaluationListener != null)
							{
								this._evaluationListener.OnChangeFromBlankValue(sheetIndex, rowIndex, columnIndex, cell, plainValueCellCacheEntry);
							}
							this.UpdateAnyBlankReferencingFormulas(bookIndex, sheetIndex, rowIndex, columnIndex);
						}
						this._plainCellCache.Put(key, plainValueCellCacheEntry);
					}
				}
				else
				{
					if (plainValueCellCacheEntry.UpdateValue(valueFromNonFormulaCell))
					{
						plainValueCellCacheEntry.RecurseClearCachedFormulaResults(this._evaluationListener);
					}
					if (valueFromNonFormulaCell == global::NPOI.SS.Formula.Eval.BlankEval.instance)
					{
						this._plainCellCache.Remove(key);
					}
				}
				if (formulaCellCacheEntry != null)
				{
					this._formulaCellCache.Remove(cell);
					formulaCellCacheEntry.SetSensitiveInputCells(null);
					formulaCellCacheEntry.RecurseClearCachedFormulaResults(this._evaluationListener);
				}
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0000EC2C File Offset: 0x0000CE2C
		private void UpdateAnyBlankReferencingFormulas(int bookIndex, int sheetIndex, int rowIndex, int columnIndex)
		{
			global::NPOI.SS.Formula.BookSheetKey bsk = new global::NPOI.SS.Formula.BookSheetKey(bookIndex, sheetIndex);
			this._formulaCellCache.ApplyOperation(new global::NPOI.SS.Formula.EvaluationCache.EntryOperation(bsk, rowIndex, columnIndex, this._evaluationListener));
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0000EC5C File Offset: 0x0000CE5C
		public global::NPOI.SS.Formula.PlainValueCellCacheEntry GetPlainValueEntry(int bookIndex, int sheetIndex, int rowIndex, int columnIndex, global::NPOI.SS.Formula.Eval.ValueEval value)
		{
			global::NPOI.SS.Formula.Loc key = new global::NPOI.SS.Formula.Loc(bookIndex, sheetIndex, rowIndex, columnIndex);
			global::NPOI.SS.Formula.PlainValueCellCacheEntry plainValueCellCacheEntry = this._plainCellCache.Get(key);
			if (plainValueCellCacheEntry == null)
			{
				plainValueCellCacheEntry = new global::NPOI.SS.Formula.PlainValueCellCacheEntry(value);
				this._plainCellCache.Put(key, plainValueCellCacheEntry);
				if (this._evaluationListener != null)
				{
					this._evaluationListener.OnReadPlainValue(sheetIndex, rowIndex, columnIndex, plainValueCellCacheEntry);
				}
			}
			else
			{
				if (!this.AreValuesEqual(plainValueCellCacheEntry.GetValue(), value))
				{
					throw new global::System.InvalidOperationException("value changed");
				}
				if (this._evaluationListener != null)
				{
					this._evaluationListener.OnCacheHit(sheetIndex, rowIndex, columnIndex, value);
				}
			}
			return plainValueCellCacheEntry;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		private bool AreValuesEqual(global::NPOI.SS.Formula.Eval.ValueEval a, global::NPOI.SS.Formula.Eval.ValueEval b)
		{
			if (a == null)
			{
				return false;
			}
			global::System.Type type = a.GetType();
			if (type != b.GetType())
			{
				return false;
			}
			if (a == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return b == a;
			}
			if (type == typeof(global::NPOI.SS.Formula.Eval.NumberEval))
			{
				return ((global::NPOI.SS.Formula.Eval.NumberEval)a).NumberValue == ((global::NPOI.SS.Formula.Eval.NumberEval)b).NumberValue;
			}
			if (type == typeof(global::NPOI.SS.Formula.Eval.StringEval))
			{
				return ((global::NPOI.SS.Formula.Eval.StringEval)a).StringValue.Equals(((global::NPOI.SS.Formula.Eval.StringEval)b).StringValue);
			}
			if (type == typeof(global::NPOI.SS.Formula.Eval.BoolEval))
			{
				return ((global::NPOI.SS.Formula.Eval.BoolEval)a).BooleanValue == ((global::NPOI.SS.Formula.Eval.BoolEval)b).BooleanValue;
			}
			if (type == typeof(global::NPOI.SS.Formula.Eval.ErrorEval))
			{
				return ((global::NPOI.SS.Formula.Eval.ErrorEval)a).ErrorCode == ((global::NPOI.SS.Formula.Eval.ErrorEval)b).ErrorCode;
			}
			throw new global::System.InvalidOperationException("Unexpected value class (" + type.Name + ")");
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0000EDE8 File Offset: 0x0000CFE8
		public global::NPOI.SS.Formula.FormulaCellCacheEntry GetOrCreateFormulaCellEntry(global::NPOI.SS.Formula.IEvaluationCell cell)
		{
			global::NPOI.SS.Formula.FormulaCellCacheEntry formulaCellCacheEntry = this._formulaCellCache.Get(cell);
			if (formulaCellCacheEntry == null)
			{
				formulaCellCacheEntry = new global::NPOI.SS.Formula.FormulaCellCacheEntry();
				this._formulaCellCache.Put(cell, formulaCellCacheEntry);
			}
			return formulaCellCacheEntry;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0000EE19 File Offset: 0x0000D019
		public void Clear()
		{
			if (this._evaluationListener != null)
			{
				this._evaluationListener.OnClearWholeCache();
			}
			this._plainCellCache.Clear();
			this._formulaCellCache.Clear();
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0000EE44 File Offset: 0x0000D044
		public void NotifyDeleteCell(int bookIndex, int sheetIndex, global::NPOI.SS.Formula.IEvaluationCell cell)
		{
			if (cell.CellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				global::NPOI.SS.Formula.FormulaCellCacheEntry formulaCellCacheEntry = this._formulaCellCache.Remove(cell);
				if (formulaCellCacheEntry != null)
				{
					formulaCellCacheEntry.SetSensitiveInputCells(null);
					formulaCellCacheEntry.RecurseClearCachedFormulaResults(this._evaluationListener);
					return;
				}
			}
			else
			{
				global::NPOI.SS.Formula.Loc key = new global::NPOI.SS.Formula.Loc(bookIndex, sheetIndex, cell.RowIndex, cell.ColumnIndex);
				global::NPOI.SS.Formula.PlainValueCellCacheEntry plainValueCellCacheEntry = this._plainCellCache.Get(key);
				if (plainValueCellCacheEntry != null)
				{
					plainValueCellCacheEntry.RecurseClearCachedFormulaResults(this._evaluationListener);
				}
			}
		}

		// Token: 0x0400039D RID: 925
		private global::NPOI.SS.Formula.PlainCellCache _plainCellCache;

		// Token: 0x0400039E RID: 926
		private global::NPOI.SS.Formula.FormulaCellCache _formulaCellCache;

		// Token: 0x0400039F RID: 927
		private global::NPOI.SS.Formula.IEvaluationListener _evaluationListener;

		// Token: 0x02000561 RID: 1377
		public class EntryOperation : global::NPOI.SS.Formula.IEntryOperation
		{
			// Token: 0x060033AD RID: 13229 RVA: 0x000A1564 File Offset: 0x0009F764
			public EntryOperation(global::NPOI.SS.Formula.BookSheetKey bsk, int rowIndex, int columnIndex, global::NPOI.SS.Formula.IEvaluationListener evaluationListener)
			{
				this.bsk = bsk;
				this.evaluationListener = evaluationListener;
				this.rowIndex = rowIndex;
				this.columnIndex = columnIndex;
			}

			// Token: 0x060033AE RID: 13230 RVA: 0x000A1589 File Offset: 0x0009F789
			public void ProcessEntry(global::NPOI.SS.Formula.FormulaCellCacheEntry entry)
			{
				entry.NotifyUpdatedBlankCell(this.bsk, this.rowIndex, this.columnIndex, this.evaluationListener);
			}

			// Token: 0x04001886 RID: 6278
			private global::NPOI.SS.Formula.BookSheetKey bsk;

			// Token: 0x04001887 RID: 6279
			private int rowIndex;

			// Token: 0x04001888 RID: 6280
			private int columnIndex;

			// Token: 0x04001889 RID: 6281
			private global::NPOI.SS.Formula.IEvaluationListener evaluationListener;
		}
	}
}
