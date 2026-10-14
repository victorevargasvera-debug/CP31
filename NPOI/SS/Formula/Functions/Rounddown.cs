using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001D0 RID: 464
	public class Rounddown : global::NPOI.SS.Formula.Functions.TwoArg
	{
		// Token: 0x06000C2E RID: 3118 RVA: 0x000213C3 File Offset: 0x0001F5C3
		public override double Evaluate(double d0, double d1)
		{
			return global::NPOI.SS.Formula.Functions.MathX.RoundDown(d0, (int)d1);
		}
	}
}
