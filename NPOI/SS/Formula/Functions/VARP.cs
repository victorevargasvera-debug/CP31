using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000167 RID: 359
	public class VARP : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000AC3 RID: 2755 RVA: 0x0001D017 File Offset: 0x0001B217
		protected internal override double Evaluate(double[] values)
		{
			if (values.Length < 1)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.DIV_ZERO);
			}
			return global::NPOI.SS.Formula.Functions.StatsLib.varp(values);
		}
	}
}
