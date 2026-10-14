using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200019A RID: 410
	public class Int : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000B66 RID: 2918 RVA: 0x0001EFC9 File Offset: 0x0001D1C9
		public override double Evaluate(double d)
		{
			if (d > 0.0)
			{
				return global::System.Math.Round(d - 0.49);
			}
			return global::System.Math.Round(d - 0.5);
		}
	}
}
