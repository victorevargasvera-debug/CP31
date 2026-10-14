using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200015D RID: 349
	public class SUM : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000AAF RID: 2735 RVA: 0x0001CF09 File Offset: 0x0001B109
		protected internal override double Evaluate(double[] values)
		{
			return global::NPOI.SS.Formula.Functions.MathX.Sum(values);
		}
	}
}
