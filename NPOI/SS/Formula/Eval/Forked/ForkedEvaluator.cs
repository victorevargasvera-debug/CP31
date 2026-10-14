using System;
using NPOI.HSSF.UserModel;
using NPOI.SS.Formula.UDF;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Eval.Forked
{
	// Token: 0x0200022D RID: 557
	public class ForkedEvaluator
	{
		// Token: 0x06000DAA RID: 3498 RVA: 0x00026104 File Offset: 0x00024304
		private ForkedEvaluator(global::NPOI.SS.Formula.IEvaluationWorkbook masterWorkbook, global::NPOI.SS.Formula.IStabilityClassifier stabilityClassifier, global::NPOI.SS.Formula.UDF.UDFFinder udfFinder)
		{
			this._sewb = new global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationWorkbook(masterWorkbook);
			this._evaluator = new global::NPOI.SS.Formula.WorkbookEvaluator(this._sewb, stabilityClassifier, udfFinder);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0002612C File Offset: 0x0002432C
		private static global::NPOI.SS.Formula.IEvaluationWorkbook CreateEvaluationWorkbook(global::NPOI.SS.UserModel.IWorkbook wb)
		{
			if (wb is global::NPOI.HSSF.UserModel.HSSFWorkbook)
			{
				return global::NPOI.HSSF.UserModel.HSSFEvaluationWorkbook.Create((global::NPOI.HSSF.UserModel.HSSFWorkbook)wb);
			}
			global::NPOI.SS.Formula.IEvaluationWorkbook result;
			try
			{
				global::System.Type type = global::System.Type.GetType("NPOI.XSSF.UserModel.XSSFEvaluationWorkbook");
				global::System.Type type2 = global::System.Type.GetType("NPOI.XSSF.UserMode.XSSFWorkbook");
				result = (global::NPOI.SS.Formula.IEvaluationWorkbook)type.GetMethod("create", new global::System.Type[]
				{
					type2
				}).Invoke(null, new object[]
				{
					wb
				});
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.ArgumentException("Unexpected workbook type (" + wb.GetType().Name + ") - check for poi-ooxml and poi-ooxml schemas jar in the classpath", innerException);
			}
			return result;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000261C4 File Offset: 0x000243C4
		public static global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluator Create(global::NPOI.SS.UserModel.IWorkbook wb, global::NPOI.SS.Formula.IStabilityClassifier stabilityClassifier, global::NPOI.SS.Formula.UDF.UDFFinder udfFinder)
		{
			return new global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluator(global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluator.CreateEvaluationWorkbook(wb), stabilityClassifier, udfFinder);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000261D4 File Offset: 0x000243D4
		public void UpdateCell(string sheetName, int rowIndex, int columnIndex, global::NPOI.SS.Formula.Eval.ValueEval value)
		{
			global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationCell orCreateUpdatableCell = this._sewb.GetOrCreateUpdatableCell(sheetName, rowIndex, columnIndex);
			orCreateUpdatableCell.SetValue(value);
			this._evaluator.NotifyUpdateCell(orCreateUpdatableCell);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00026204 File Offset: 0x00024404
		public void CopyUpdatedCells(global::NPOI.SS.UserModel.IWorkbook workbook)
		{
			this._sewb.CopyUpdatedCells(workbook);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00026214 File Offset: 0x00024414
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(string sheetName, int rowIndex, int columnIndex)
		{
			global::NPOI.SS.Formula.IEvaluationCell evaluationCell = this._sewb.GetEvaluationCell(sheetName, rowIndex, columnIndex);
			switch (evaluationCell.CellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				return new global::NPOI.SS.Formula.Eval.NumberEval(evaluationCell.NumericCellValue);
			case global::NPOI.SS.UserModel.CellType.String:
				return new global::NPOI.SS.Formula.Eval.StringEval(evaluationCell.StringCellValue);
			case global::NPOI.SS.UserModel.CellType.Formula:
				return this._evaluator.Evaluate(evaluationCell);
			case global::NPOI.SS.UserModel.CellType.Blank:
				return null;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				return global::NPOI.SS.Formula.Eval.BoolEval.ValueOf(evaluationCell.BooleanCellValue);
			case global::NPOI.SS.UserModel.CellType.Error:
				return global::NPOI.SS.Formula.Eval.ErrorEval.ValueOf(evaluationCell.ErrorCellValue);
			default:
				throw new global::System.InvalidOperationException("Bad cell type (" + evaluationCell.CellType.ToString() + ")");
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x000262C0 File Offset: 0x000244C0
		public static void SetupEnvironment(string[] workbookNames, global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluator[] Evaluators)
		{
			global::NPOI.SS.Formula.WorkbookEvaluator[] array = new global::NPOI.SS.Formula.WorkbookEvaluator[Evaluators.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Evaluators[i]._evaluator;
			}
			global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment.Setup(workbookNames, array);
		}

		// Token: 0x0400061C RID: 1564
		private global::NPOI.SS.Formula.WorkbookEvaluator _evaluator;

		// Token: 0x0400061D RID: 1565
		private global::NPOI.SS.Formula.Eval.Forked.ForkedEvaluationWorkbook _sewb;
	}
}
