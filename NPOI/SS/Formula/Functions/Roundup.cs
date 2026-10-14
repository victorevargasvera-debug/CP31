using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001D1 RID: 465
	public class Roundup : global::NPOI.SS.Formula.Functions.TwoArg
	{
		// Token: 0x06000C30 RID: 3120 RVA: 0x000213CD File Offset: 0x0001F5CD
		public override double Evaluate(double d0, double d1)
		{
			return global::NPOI.SS.Formula.Functions.MathX.RoundUp(d0, (int)d1);
		}
	}
}
