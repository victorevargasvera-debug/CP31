using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000184 RID: 388
	public class Exp : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000B22 RID: 2850 RVA: 0x0001E243 File Offset: 0x0001C443
		public override double Evaluate(double d)
		{
			return global::System.Math.Pow(2.718281828459045, d);
		}
	}
}
