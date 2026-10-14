using System;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming.Values
{
	// Token: 0x020000D6 RID: 214
	public class NumericFormulaValue : global::NPOI.XSSF.Streaming.Values.FormulaValue
	{
		// Token: 0x06000DDE RID: 3550 RVA: 0x00005008 File Offset: 0x00003208
		public override global::NPOI.SS.UserModel.CellType GetFormulaType()
		{
			return global::NPOI.SS.UserModel.CellType.Numeric;
		}

		// Token: 0x0400040D RID: 1037
		public double PreEvaluatedValue;
	}
}
