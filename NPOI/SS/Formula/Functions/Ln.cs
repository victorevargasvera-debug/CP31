using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001C6 RID: 454
	public class Ln : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000C0C RID: 3084 RVA: 0x00020E93 File Offset: 0x0001F093
		public override double Evaluate(double d)
		{
			return global::System.Math.Log(d);
		}
	}
}
