using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001C3 RID: 451
	public class Atanh : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000C06 RID: 3078 RVA: 0x00020E7B File Offset: 0x0001F07B
		public override double Evaluate(double d)
		{
			return global::NPOI.SS.Formula.Functions.MathX.Atanh(d);
		}
	}
}
