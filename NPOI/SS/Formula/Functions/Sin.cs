using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001D2 RID: 466
	public class Sin : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000C32 RID: 3122 RVA: 0x000213D7 File Offset: 0x0001F5D7
		public override double Evaluate(double d)
		{
			return global::System.Math.Sin(d);
		}
	}
}
