using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x02000239 RID: 569
	internal class WorkdayFunction : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DDE RID: 3550 RVA: 0x00026F39 File Offset: 0x00025139
		private WorkdayFunction(global::NPOI.SS.Formula.Atp.ArgumentsEvaluator anEvaluator)
		{
			this.evaluator = anEvaluator;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00026F48 File Offset: 0x00025148
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length < 2 || args.Length > 3)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			int rowIndex = ec.RowIndex;
			int columnIndex = ec.ColumnIndex;
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				double start = this.evaluator.EvaluateDateArg(args[0], rowIndex, columnIndex);
				int workdays = (int)global::System.Math.Floor(this.evaluator.EvaluateNumberArg(args[1], rowIndex, columnIndex));
				global::NPOI.SS.Formula.Eval.ValueEval arg = (args.Length == 3) ? args[2] : null;
				double[] holidays = this.evaluator.EvaluateDatesArg(arg, rowIndex, columnIndex);
				result = new global::NPOI.SS.Formula.Eval.NumberEval(global::NPOI.SS.UserModel.DateUtil.GetExcelDate(global::NPOI.SS.Formula.Atp.WorkdayCalculator.instance.CalculateWorkdays(start, workdays, holidays)));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				result = global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return result;
		}

		// Token: 0x0400062A RID: 1578
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Atp.WorkdayFunction(global::NPOI.SS.Formula.Atp.ArgumentsEvaluator.instance);

		// Token: 0x0400062B RID: 1579
		private global::NPOI.SS.Formula.Atp.ArgumentsEvaluator evaluator;
	}
}
