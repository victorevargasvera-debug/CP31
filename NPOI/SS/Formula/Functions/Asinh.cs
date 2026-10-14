using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001C0 RID: 448
	public class Asinh : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000C00 RID: 3072 RVA: 0x00020E3F File Offset: 0x0001F03F
		public override double Evaluate(double d)
		{
			return global::NPOI.SS.Formula.Functions.MathX.Asinh(d);
		}
	}
}
