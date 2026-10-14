using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200016A RID: 362
	public class Percentile : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000ACA RID: 2762 RVA: 0x0001D10C File Offset: 0x0001B30C
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			double num;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg1, srcRowIndex, srcColumnIndex));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (num < 0.0 || num > 1.0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			double num4;
			try
			{
				double[] array = global::NPOI.SS.Formula.Functions.AggregateFunction.ValueCollector.CollectValues(new global::NPOI.SS.Formula.Eval.ValueEval[]
				{
					arg0
				});
				int num2 = array.Length;
				if (num2 == 0 || num2 > 8191)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
				}
				double num3 = (double)(num2 - 1) * num + 1.0;
				if (num3 == 1.0)
				{
					num4 = global::NPOI.SS.Formula.Functions.StatsLib.kthSmallest(array, 1);
				}
				else if (num3 == (double)num2)
				{
					num4 = global::NPOI.SS.Formula.Functions.StatsLib.kthLargest(array, 1);
				}
				else
				{
					int num5 = (int)num3;
					double num6 = num3 - (double)num5;
					num4 = global::NPOI.SS.Formula.Functions.StatsLib.kthSmallest(array, num5) + num6 * (global::NPOI.SS.Formula.Functions.StatsLib.kthSmallest(array, num5 + 1) - global::NPOI.SS.Formula.Functions.StatsLib.kthSmallest(array, num5));
				}
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num4);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num4);
		}
	}
}
