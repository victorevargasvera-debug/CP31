using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000185 RID: 389
	public class Fact : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000B24 RID: 2852 RVA: 0x0001E254 File Offset: 0x0001C454
		public override double Evaluate(double d)
		{
			return global::NPOI.SS.Formula.Functions.MathX.Factorial((int)d);
		}
	}
}
