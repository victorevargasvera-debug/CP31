using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001B2 RID: 434
	public class Mina : global::NPOI.SS.Formula.Functions.MinaMaxa
	{
		// Token: 0x06000BD3 RID: 3027 RVA: 0x0001CF6F File Offset: 0x0001B16F
		protected internal override double Evaluate(double[] values)
		{
			if (values.Length == 0)
			{
				return 0.0;
			}
			return global::NPOI.SS.Formula.Functions.MathX.Min(values);
		}
	}
}
