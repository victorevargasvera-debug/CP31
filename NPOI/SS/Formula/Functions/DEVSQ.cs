using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200015C RID: 348
	public class DEVSQ : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000AAD RID: 2733 RVA: 0x0001CF01 File Offset: 0x0001B101
		protected internal override double Evaluate(double[] values)
		{
			return global::NPOI.SS.Formula.Functions.StatsLib.devsq(values);
		}
	}
}
