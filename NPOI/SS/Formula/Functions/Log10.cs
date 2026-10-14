using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001C8 RID: 456
	public class Log10 : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000C11 RID: 3089 RVA: 0x00020F54 File Offset: 0x0001F154
		public override double Evaluate(double d)
		{
			return global::System.Math.Log(d) / global::NPOI.SS.Formula.Functions.NumericFunction.LOG_10_TO_BASE_e;
		}
	}
}
