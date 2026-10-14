using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001BC RID: 444
	public class Abs : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000BF8 RID: 3064 RVA: 0x00020E1F File Offset: 0x0001F01F
		public override double Evaluate(double d)
		{
			return global::System.Math.Abs(d);
		}
	}
}
