using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001DB RID: 475
	public class Power : global::NPOI.SS.Formula.Functions.TwoArg
	{
		// Token: 0x06000C4C RID: 3148 RVA: 0x00021798 File Offset: 0x0001F998
		public override double Evaluate(double d0, double d1)
		{
			return global::System.Math.Pow(d0, d1);
		}
	}
}
