using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200013C RID: 316
	public class EOMonth : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A34 RID: 2612 RVA: 0x0001AE70 File Offset: 0x00019070
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				double num = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(args[0], ec.RowIndex, ec.ColumnIndex);
				int months = (int)global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(args[1], ec.RowIndex, ec.ColumnIndex);
				if (num >= 0.0 && num < 1.0)
				{
					num = 1.0;
				}
				global::System.DateTime date = global::NPOI.SS.UserModel.DateUtil.GetJavaDate(num, false).AddMonths(months);
				date = date.AddMonths(1);
				date = new global::System.DateTime(date.Year, date.Month, 1);
				date = date.AddDays(-1.0);
				result = new global::NPOI.SS.Formula.Eval.NumberEval(global::NPOI.SS.UserModel.DateUtil.GetExcelDate(date));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x04000516 RID: 1302
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.EOMonth();
	}
}
