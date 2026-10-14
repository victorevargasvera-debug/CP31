using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000164 RID: 356
	public class STDEV : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000ABD RID: 2749 RVA: 0x0001CFDD File Offset: 0x0001B1DD
		protected internal override double Evaluate(double[] values)
		{
			if (values.Length < 1)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.DIV_ZERO);
			}
			return global::NPOI.SS.Formula.Functions.StatsLib.stdev(values);
		}
	}
}
