using System;
using NPOI.SS.Formula;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200005D RID: 93
	public abstract class BaseXSSFFormulaEvaluator : global::NPOI.SS.Formula.BaseFormulaEvaluator
	{
		// Token: 0x06000434 RID: 1076 RVA: 0x00010C5A File Offset: 0x0000EE5A
		protected BaseXSSFFormulaEvaluator(global::NPOI.SS.Formula.WorkbookEvaluator bookEvaluator) : base(bookEvaluator)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00010C63 File Offset: 0x0000EE63
		protected override global::NPOI.SS.UserModel.IRichTextString CreateRichTextString(string str)
		{
			return new global::NPOI.XSSF.UserModel.XSSFRichTextString(str);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00010C6B File Offset: 0x0000EE6B
		public override void NotifySetFormula(global::NPOI.SS.UserModel.ICell cell)
		{
			this._bookEvaluator.NotifyUpdateCell(new global::NPOI.XSSF.UserModel.XSSFEvaluationCell((global::NPOI.XSSF.UserModel.XSSFCell)cell));
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00010C83 File Offset: 0x0000EE83
		public override void NotifyDeleteCell(global::NPOI.SS.UserModel.ICell cell)
		{
			this._bookEvaluator.NotifyDeleteCell(new global::NPOI.XSSF.UserModel.XSSFEvaluationCell((global::NPOI.XSSF.UserModel.XSSFCell)cell));
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00010C6B File Offset: 0x0000EE6B
		public override void NotifyUpdateCell(global::NPOI.SS.UserModel.ICell cell)
		{
			this._bookEvaluator.NotifyUpdateCell(new global::NPOI.XSSF.UserModel.XSSFEvaluationCell((global::NPOI.XSSF.UserModel.XSSFCell)cell));
		}

		// Token: 0x06000439 RID: 1081
		protected abstract global::NPOI.SS.Formula.IEvaluationCell ToEvaluationCell(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x0600043A RID: 1082 RVA: 0x00010C9C File Offset: 0x0000EE9C
		protected override global::NPOI.SS.UserModel.CellValue EvaluateFormulaCellValue(global::NPOI.SS.UserModel.ICell cell)
		{
			global::NPOI.SS.Formula.IEvaluationCell srcCell = this.ToEvaluationCell(cell);
			global::NPOI.SS.Formula.Eval.ValueEval valueEval = this._bookEvaluator.Evaluate(srcCell);
			if (valueEval is global::NPOI.SS.Formula.Eval.NumberEval)
			{
				return new global::NPOI.SS.UserModel.CellValue(((global::NPOI.SS.Formula.Eval.NumberEval)valueEval).NumberValue);
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.BoolEval)
			{
				return global::NPOI.SS.UserModel.CellValue.ValueOf(((global::NPOI.SS.Formula.Eval.BoolEval)valueEval).BooleanValue);
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.StringEval)
			{
				return new global::NPOI.SS.UserModel.CellValue(((global::NPOI.SS.Formula.Eval.StringEval)valueEval).StringValue);
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				return global::NPOI.SS.UserModel.CellValue.GetError(((global::NPOI.SS.Formula.Eval.ErrorEval)valueEval).ErrorCode);
			}
			throw new global::System.Exception("Unexpected eval class (" + valueEval.GetType().Name + ")");
		}
	}
}
