using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001CF RID: 463
	public class Round : global::NPOI.SS.Formula.Functions.TwoArg
	{
		// Token: 0x06000C2C RID: 3116 RVA: 0x000213B9 File Offset: 0x0001F5B9
		public override double Evaluate(double d0, double d1)
		{
			return global::NPOI.SS.Formula.Functions.MathX.Round(d0, (int)d1);
		}
	}
}
