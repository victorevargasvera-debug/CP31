using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200015F RID: 351
	public class MAX : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000AB3 RID: 2739 RVA: 0x0001CF59 File Offset: 0x0001B159
		protected internal override double Evaluate(double[] values)
		{
			if (values.Length == 0)
			{
				return 0.0;
			}
			return global::NPOI.SS.Formula.Functions.MathX.Max(values);
		}
	}
}
