using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000165 RID: 357
	public class SUMSQ : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000ABF RID: 2751 RVA: 0x0001CFF6 File Offset: 0x0001B1F6
		protected internal override double Evaluate(double[] values)
		{
			return global::NPOI.SS.Formula.Functions.MathX.Sumsq(values);
		}
	}
}
