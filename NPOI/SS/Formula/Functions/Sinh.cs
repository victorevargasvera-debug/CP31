using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001D3 RID: 467
	public class Sinh : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000C34 RID: 3124 RVA: 0x000213DF File Offset: 0x0001F5DF
		public override double Evaluate(double d)
		{
			return global::NPOI.SS.Formula.Functions.MathX.Sinh(d);
		}
	}
}
