using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001B3 RID: 435
	public abstract class MinaMaxa : global::NPOI.SS.Formula.Functions.MultiOperandNumericFunction
	{
		// Token: 0x06000BD5 RID: 3029 RVA: 0x000205FA File Offset: 0x0001E7FA
		protected MinaMaxa() : base(true, true)
		{
		}

		// Token: 0x04000580 RID: 1408
		public static readonly global::NPOI.SS.Formula.Functions.Function MAXA = new global::NPOI.SS.Formula.Functions.Maxa();

		// Token: 0x04000581 RID: 1409
		public static readonly global::NPOI.SS.Formula.Functions.Function MINA = new global::NPOI.SS.Formula.Functions.Mina();
	}
}
