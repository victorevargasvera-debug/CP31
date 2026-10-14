using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200015E RID: 350
	public class LARGE : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000AB1 RID: 2737 RVA: 0x0001CF14 File Offset: 0x0001B114
		protected internal override double Evaluate(double[] ops)
		{
			if (ops.Length < 2)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR);
			}
			double[] array = new double[ops.Length - 1];
			int k = (int)ops[ops.Length - 1];
			global::System.Array.Copy(ops, 0, array, 0, array.Length);
			return global::NPOI.SS.Formula.Functions.StatsLib.kthLargest(array, k);
		}
	}
}
