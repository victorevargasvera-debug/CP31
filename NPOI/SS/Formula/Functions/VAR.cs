using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000166 RID: 358
	public class VAR : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000AC1 RID: 2753 RVA: 0x0001CFFE File Offset: 0x0001B1FE
		protected internal override double Evaluate(double[] values)
		{
			if (values.Length < 1)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.DIV_ZERO);
			}
			return global::NPOI.SS.Formula.Functions.StatsLib.var(values);
		}
	}
}
