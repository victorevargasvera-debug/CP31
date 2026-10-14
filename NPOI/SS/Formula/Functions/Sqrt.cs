using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001D4 RID: 468
	public class Sqrt : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000C36 RID: 3126 RVA: 0x000213E7 File Offset: 0x0001F5E7
		public override double Evaluate(double d)
		{
			return global::System.Math.Sqrt(d);
		}
	}
}
