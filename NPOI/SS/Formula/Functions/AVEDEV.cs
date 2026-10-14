using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200015A RID: 346
	public class AVEDEV : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000AA9 RID: 2729 RVA: 0x0001CED8 File Offset: 0x0001B0D8
		protected internal override double Evaluate(double[] values)
		{
			return global::NPOI.SS.Formula.Functions.StatsLib.avedev(values);
		}
	}
}
