using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000181 RID: 385
	public class Degrees : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000B1B RID: 2843 RVA: 0x0001E1BB File Offset: 0x0001C3BB
		public override double Evaluate(double d)
		{
			return d * 180.0 / 3.141592653589793;
		}
	}
}
