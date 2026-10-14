using System;
using System.Globalization;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000140 RID: 320
	public class Fixed : global::NPOI.SS.Formula.Functions.Function1Arg, global::NPOI.SS.Formula.Functions.Function, global::NPOI.SS.Formula.Functions.Function2Arg, global::NPOI.SS.Formula.Functions.Function3Arg
	{
		// Token: 0x06000A4B RID: 2635 RVA: 0x0001B243 File Offset: 0x00019443
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			return this.doFixed(arg0, arg1, arg2, srcRowIndex, srcColumnIndex);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0001B252 File Offset: 0x00019452
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			return this.doFixed(arg0, arg1, global::NPOI.SS.Formula.Eval.BoolEval.FALSE, srcRowIndex, srcColumnIndex);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0001B264 File Offset: 0x00019464
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			return this.doFixed(arg0, new global::NPOI.SS.Formula.Eval.NumberEval(2.0), global::NPOI.SS.Formula.Eval.BoolEval.FALSE, srcRowIndex, srcColumnIndex);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0001B284 File Offset: 0x00019484
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			switch (args.Length)
			{
			case 1:
				return this.doFixed(args[0], new global::NPOI.SS.Formula.Eval.NumberEval(2.0), global::NPOI.SS.Formula.Eval.BoolEval.FALSE, srcRowIndex, srcColumnIndex);
			case 2:
				return this.doFixed(args[0], args[1], global::NPOI.SS.Formula.Eval.BoolEval.FALSE, srcRowIndex, srcColumnIndex);
			case 3:
				return this.doFixed(args[0], args[1], args[2], srcRowIndex, srcColumnIndex);
			default:
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0001B2F8 File Offset: 0x000194F8
		private global::NPOI.SS.Formula.Eval.ValueEval doFixed(global::NPOI.SS.Formula.Eval.ValueEval numberParam, global::NPOI.SS.Formula.Eval.ValueEval placesParam, global::NPOI.SS.Formula.Eval.ValueEval skipThousandsSeparatorParam, int srcRowIndex, int srcColumnIndex)
		{
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				decimal num = (decimal)global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(numberParam, srcRowIndex, srcColumnIndex));
				int num2 = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(placesParam, srcRowIndex, srcColumnIndex));
				bool? flag = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToBoolean(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(skipThousandsSeparatorParam, srcRowIndex, srcColumnIndex), false);
				if (num2 < 0)
				{
					num /= (decimal)global::System.Math.Pow(10.0, (double)(-(double)num2));
					num = global::System.Math.Round(num, 0);
					num *= (decimal)global::System.Math.Pow(10.0, (double)(-(double)num2));
				}
				else
				{
					num = global::System.Math.Round(num, num2);
				}
				result = new global::NPOI.SS.Formula.Eval.StringEval((flag != null && flag.Value) ? num.ToString((num2 > 0) ? ("F" + num2.ToString()) : "F0") : num.ToString((num2 > 0) ? ("N" + num2.ToString()) : "N0", global::System.Globalization.CultureInfo.InvariantCulture));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}
	}
}
