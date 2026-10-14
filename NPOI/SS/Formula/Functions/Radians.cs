using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001DD RID: 477
	public class Radians : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000C50 RID: 3152 RVA: 0x000217AF File Offset: 0x0001F9AF
		public override double Evaluate(double d)
		{
			return d * 3.141592653589793 / 180.0;
		}
	}
}
