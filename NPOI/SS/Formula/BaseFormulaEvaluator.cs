using System;
using System.Collections.Generic;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula
{
	// Token: 0x020000AB RID: 171
	public abstract class BaseFormulaEvaluator : global::NPOI.SS.UserModel.IFormulaEvaluator, global::NPOI.SS.Formula.IWorkbookEvaluatorProvider
	{
		// Token: 0x060005E8 RID: 1512 RVA: 0x0000DB4C File Offset: 0x0000BD4C
		protected BaseFormulaEvaluator(global::NPOI.SS.Formula.WorkbookEvaluator bookEvaluator)
		{
			this._bookEvaluator = bookEvaluator;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000DB5C File Offset: 0x0000BD5C
		public static void SetupEnvironment(string[] workbookNames, global::NPOI.SS.Formula.BaseFormulaEvaluator[] Evaluators)
		{
			global::NPOI.SS.Formula.WorkbookEvaluator[] array = new global::NPOI.SS.Formula.WorkbookEvaluator[Evaluators.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Evaluators[i]._bookEvaluator;
			}
			global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment.Setup(workbookNames, array);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0000DB92 File Offset: 0x0000BD92
		public virtual void SetupReferencedWorkbooks(global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.UserModel.IFormulaEvaluator> evaluators)
		{
			global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment.SetupFormulaEvaluator(evaluators);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0000DB9A File Offset: 0x0000BD9A
		public global::NPOI.SS.Formula.WorkbookEvaluator GetWorkbookEvaluator()
		{
			return this._bookEvaluator;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0000DBA2 File Offset: 0x0000BDA2
		public void ClearAllCachedResultValues()
		{
			this._bookEvaluator.ClearAllCachedResultValues();
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0000DBB0 File Offset: 0x0000BDB0
		public global::NPOI.SS.UserModel.CellValue Evaluate(global::NPOI.SS.UserModel.ICell cell)
		{
			if (cell == null)
			{
				return null;
			}
			switch (cell.CellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				return new global::NPOI.SS.UserModel.CellValue(cell.NumericCellValue);
			case global::NPOI.SS.UserModel.CellType.String:
				return new global::NPOI.SS.UserModel.CellValue(cell.RichStringCellValue.String);
			case global::NPOI.SS.UserModel.CellType.Formula:
				return this.EvaluateFormulaCellValue(cell);
			case global::NPOI.SS.UserModel.CellType.Blank:
				return null;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				return global::NPOI.SS.UserModel.CellValue.ValueOf(cell.BooleanCellValue);
			case global::NPOI.SS.UserModel.CellType.Error:
				return global::NPOI.SS.UserModel.CellValue.GetError((int)cell.ErrorCellValue);
			default:
				throw new global::System.InvalidOperationException("Bad cell type (" + cell.CellType.ToString() + ")");
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0000DC50 File Offset: 0x0000BE50
		public virtual global::NPOI.SS.UserModel.ICell EvaluateInCell(global::NPOI.SS.UserModel.ICell cell)
		{
			if (cell == null)
			{
				return null;
			}
			if (cell.CellType == global::NPOI.SS.UserModel.CellType.Formula)
			{
				global::NPOI.SS.UserModel.CellValue cv = this.EvaluateFormulaCellValue(cell);
				this.SetCellValue(cell, cv);
				global::NPOI.SS.Formula.BaseFormulaEvaluator.SetCellType(cell, cv);
			}
			return cell;
		}

		// Token: 0x060005EF RID: 1519
		protected abstract global::NPOI.SS.UserModel.CellValue EvaluateFormulaCellValue(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000DC83 File Offset: 0x0000BE83
		public global::NPOI.SS.UserModel.CellType EvaluateFormulaCell(global::NPOI.SS.UserModel.ICell cell)
		{
			return this.EvaluateFormulaCellEnum(cell);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0000DC8C File Offset: 0x0000BE8C
		public virtual global::NPOI.SS.UserModel.CellType EvaluateFormulaCellEnum(global::NPOI.SS.UserModel.ICell cell)
		{
			if (cell == null || cell.CellType != global::NPOI.SS.UserModel.CellType.Formula)
			{
				return global::NPOI.SS.UserModel.CellType.Unknown;
			}
			global::NPOI.SS.UserModel.CellValue cellValue = this.EvaluateFormulaCellValue(cell);
			this.SetCellValue(cell, cellValue);
			return cellValue.CellType;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000DCC0 File Offset: 0x0000BEC0
		protected static void SetCellType(global::NPOI.SS.UserModel.ICell cell, global::NPOI.SS.UserModel.CellValue cv)
		{
			global::NPOI.SS.UserModel.CellType cellType = cv.CellType;
			switch (cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
			case global::NPOI.SS.UserModel.CellType.String:
			case global::NPOI.SS.UserModel.CellType.Boolean:
			case global::NPOI.SS.UserModel.CellType.Error:
				cell.SetCellType(cellType);
				return;
			case global::NPOI.SS.UserModel.CellType.Formula:
				throw new global::System.ArgumentException("This should never happen. Formulas should have already been Evaluated.");
			case global::NPOI.SS.UserModel.CellType.Blank:
				throw new global::System.ArgumentException("This should never happen. Blanks eventually Get translated to zero.");
			default:
				throw new global::System.InvalidOperationException("Unexpected cell value type (" + cellType.ToString() + ")");
			}
		}

		// Token: 0x060005F3 RID: 1523
		protected abstract global::NPOI.SS.UserModel.IRichTextString CreateRichTextString(string str);

		// Token: 0x060005F4 RID: 1524 RVA: 0x0000DD34 File Offset: 0x0000BF34
		protected void SetCellValue(global::NPOI.SS.UserModel.ICell cell, global::NPOI.SS.UserModel.CellValue cv)
		{
			global::NPOI.SS.UserModel.CellType cellType = cv.CellType;
			switch (cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				cell.SetCellValue(cv.NumberValue);
				return;
			case global::NPOI.SS.UserModel.CellType.String:
				cell.SetCellValue(this.CreateRichTextString(cv.StringValue));
				return;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				cell.SetCellValue(cv.BooleanValue);
				return;
			case global::NPOI.SS.UserModel.CellType.Error:
				cell.SetCellErrorValue((byte)cv.ErrorValue);
				return;
			}
			throw new global::System.InvalidOperationException("Unexpected cell value type (" + cellType.ToString() + ")");
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0000DDC4 File Offset: 0x0000BFC4
		public static void EvaluateAllFormulaCells(global::NPOI.SS.UserModel.IWorkbook wb)
		{
			global::NPOI.SS.UserModel.IFormulaEvaluator evaluator = wb.GetCreationHelper().CreateFormulaEvaluator();
			global::NPOI.SS.Formula.BaseFormulaEvaluator.EvaluateAllFormulaCells(wb, evaluator);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
		protected static void EvaluateAllFormulaCells(global::NPOI.SS.UserModel.IWorkbook wb, global::NPOI.SS.UserModel.IFormulaEvaluator evaluator)
		{
			for (int i = 0; i < wb.NumberOfSheets; i++)
			{
				foreach (object obj in wb.GetSheetAt(i))
				{
					foreach (global::NPOI.SS.UserModel.ICell cell in ((global::NPOI.SS.UserModel.IRow)obj))
					{
						if (cell.CellType == global::NPOI.SS.UserModel.CellType.Formula)
						{
							evaluator.EvaluateFormulaCell(cell);
						}
					}
				}
			}
		}

		// Token: 0x060005F7 RID: 1527
		public abstract void NotifySetFormula(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x060005F8 RID: 1528
		public abstract void NotifyDeleteCell(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x060005F9 RID: 1529
		public abstract void NotifyUpdateCell(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x060005FA RID: 1530
		public abstract void EvaluateAll();

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0000DE8C File Offset: 0x0000C08C
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x0000DE99 File Offset: 0x0000C099
		public bool IgnoreMissingWorkbooks
		{
			get
			{
				return this._bookEvaluator.IgnoreMissingWorkbooks;
			}
			set
			{
				this._bookEvaluator.IgnoreMissingWorkbooks = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0000DEA7 File Offset: 0x0000C0A7
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x0000DEB4 File Offset: 0x0000C0B4
		public bool DebugEvaluationOutputForNextEval
		{
			get
			{
				return this._bookEvaluator.DebugEvaluationOutputForNextEval;
			}
			set
			{
				this._bookEvaluator.DebugEvaluationOutputForNextEval = value;
			}
		}

		// Token: 0x0400038A RID: 906
		protected global::NPOI.SS.Formula.WorkbookEvaluator _bookEvaluator;
	}
}
