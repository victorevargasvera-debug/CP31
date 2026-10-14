using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200019B RID: 411
	public class Irr : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000B68 RID: 2920 RVA: 0x0001EFF8 File Offset: 0x0001D1F8
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			if (args.Length == 0 || args.Length > 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				double[] values = global::NPOI.SS.Formula.Functions.AggregateFunction.ValueCollector.CollectValues(new global::NPOI.SS.Formula.Eval.ValueEval[]
				{
					args[0]
				});
				double guess;
				if (args.Length == 2)
				{
					guess = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(args[1], srcRowIndex, srcColumnIndex);
				}
				else
				{
					guess = 0.1;
				}
				double num = global::NPOI.SS.Formula.Functions.Irr.irr(values, guess);
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num);
				result = new global::NPOI.SS.Formula.Eval.NumberEval(num);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0001F074 File Offset: 0x0001D274
		public static double irr(double[] income)
		{
			return global::NPOI.SS.Formula.Functions.Irr.irr(income, 0.1);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0001F088 File Offset: 0x0001D288
		public static double irr(double[] values, double guess)
		{
			int num = 20;
			double num2 = 1E-07;
			double num3 = guess;
			for (int i = 0; i < num; i++)
			{
				double num4 = 0.0;
				double num5 = 0.0;
				for (int j = 0; j < values.Length; j++)
				{
					num4 += values[j] / global::System.Math.Pow(1.0 + num3, (double)j);
					num5 += (double)(-(double)j) * values[j] / global::System.Math.Pow(1.0 + num3, (double)(j + 1));
				}
				double num6 = num3 - num4 / num5;
				if (global::System.Math.Abs(num6 - num3) <= num2)
				{
					return num6;
				}
				num3 = num6;
			}
			return double.NaN;
		}
	}
}
