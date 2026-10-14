using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200015B RID: 347
	public class AVERAGE : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000AAB RID: 2731 RVA: 0x0001CEE8 File Offset: 0x0001B0E8
		protected internal override double Evaluate(double[] values)
		{
			if (values.Length < 1)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.DIV_ZERO);
			}
			return global::NPOI.SS.Formula.Functions.MathX.Average(values);
		}
	}
}
