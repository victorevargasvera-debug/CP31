using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001E0 RID: 480
	public class Sign : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000C58 RID: 3160 RVA: 0x0002188C File Offset: 0x0001FA8C
		public override double Evaluate(double d)
		{
			return (double)global::NPOI.SS.Formula.Functions.MathX.Sign(d);
		}
	}
}
