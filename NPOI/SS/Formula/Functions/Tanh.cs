using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001D6 RID: 470
	public class Tanh : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000C3A RID: 3130 RVA: 0x000213F7 File Offset: 0x0001F5F7
		public override double Evaluate(double d)
		{
			return global::System.Math.Tanh(d);
		}
	}
}
