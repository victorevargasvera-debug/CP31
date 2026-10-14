using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000169 RID: 361
	public class LargeSmall : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000AC8 RID: 2760 RVA: 0x0001D04D File Offset: 0x0001B24D
		protected LargeSmall(bool isLarge)
		{
			this._isLarge = isLarge;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0001D05C File Offset: 0x0001B25C
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
			if (num < 1.0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			int num2 = (int)global::System.Math.Ceiling(num);
			double num3;
			try
			{
				double[] array = global::NPOI.SS.Formula.Functions.AggregateFunction.ValueCollector.CollectValues(new global::NPOI.SS.Formula.Eval.ValueEval[]
				{
					arg0
				});
				if (num2 > array.Length)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
				}
				num3 = (this._isLarge ? global::NPOI.SS.Formula.Functions.StatsLib.kthLargest(array, num2) : global::NPOI.SS.Formula.Functions.StatsLib.kthSmallest(array, num2));
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num3);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num3);
		}

		// Token: 0x0400053B RID: 1339
		private bool _isLarge;
	}
}
