using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x02000235 RID: 565
	public class NetworkdaysFunction : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DC9 RID: 3529 RVA: 0x000268C8 File Offset: 0x00024AC8
		private NetworkdaysFunction(global::NPOI.SS.Formula.Atp.ArgumentsEvaluator anEvaluator)
		{
			this.evaluator = anEvaluator;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x000268D8 File Offset: 0x00024AD8
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
				double num = this.evaluator.EvaluateDateArg(args[0], rowIndex, columnIndex);
				double num2 = this.evaluator.EvaluateDateArg(args[1], rowIndex, columnIndex);
				if (num > num2)
				{
					result = global::NPOI.SS.Formula.Eval.ErrorEval.NAME_INVALID;
				}
				else
				{
					global::NPOI.SS.Formula.Eval.ValueEval arg = (args.Length == 3) ? args[2] : null;
					double[] holidays = this.evaluator.EvaluateDatesArg(arg, rowIndex, columnIndex);
					result = new global::NPOI.SS.Formula.Eval.NumberEval((double)global::NPOI.SS.Formula.Atp.WorkdayCalculator.instance.CalculateWorkdays(num, num2, holidays));
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				result = global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return result;
		}

		// Token: 0x04000624 RID: 1572
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Atp.NetworkdaysFunction(global::NPOI.SS.Formula.Atp.ArgumentsEvaluator.instance);

		// Token: 0x04000625 RID: 1573
		private global::NPOI.SS.Formula.Atp.ArgumentsEvaluator evaluator;
	}
}
