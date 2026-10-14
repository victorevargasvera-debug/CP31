using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000161 RID: 353
	public class MEDIAN : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000AB7 RID: 2743 RVA: 0x0001CF85 File Offset: 0x0001B185
		protected internal override double Evaluate(double[] values)
		{
			return global::NPOI.SS.Formula.Functions.StatsLib.median(values);
		}
	}
}
