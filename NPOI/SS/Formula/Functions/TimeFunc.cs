using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001F9 RID: 505
	public class TimeFunc : global::NPOI.SS.Formula.Functions.Fixed3ArgFunction
	{
		// Token: 0x06000CB0 RID: 3248 RVA: 0x00022B28 File Offset: 0x00020D28
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			double value;
			try
			{
				value = this.Evaluate(this.EvalArg(arg0, srcRowIndex, srcColumnIndex), this.EvalArg(arg1, srcRowIndex, srcColumnIndex), this.EvalArg(arg2, srcRowIndex, srcColumnIndex));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(value);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00022B7C File Offset: 0x00020D7C
		private int EvalArg(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcRowIndex, int srcColumnIndex)
		{
			if (arg == global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
			{
				return 0;
			}
			return global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcRowIndex, srcColumnIndex));
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00022B98 File Offset: 0x00020D98
		private double Evaluate(int hours, int minutes, int seconds)
		{
			if (hours > 32767 || minutes > 32767 || seconds > 32767)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			int num = hours * 3600 + minutes * 60 + seconds;
			if (num < 0)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			return (double)(num % 86400) / 86400.0;
		}

		// Token: 0x040005CD RID: 1485
		private const int SECONDS_PER_MINUTE = 60;

		// Token: 0x040005CE RID: 1486
		private const int SECONDS_PER_HOUR = 3600;

		// Token: 0x040005CF RID: 1487
		private const int HOURS_PER_DAY = 24;

		// Token: 0x040005D0 RID: 1488
		private const int SECONDS_PER_DAY = 86400;
	}
}
