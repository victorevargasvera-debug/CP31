using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001BE RID: 446
	public class Acosh : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000BFC RID: 3068 RVA: 0x00020E2F File Offset: 0x0001F02F
		public override double Evaluate(double d)
		{
			return global::NPOI.SS.Formula.Functions.MathX.Acosh(d);
		}
	}
}
