using System;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming.Values
{
	// Token: 0x020000D3 RID: 211
	public class ErrorFormulaValue : global::NPOI.XSSF.Streaming.Values.FormulaValue
	{
		// Token: 0x06000DD7 RID: 3543 RVA: 0x0000EB2A File Offset: 0x0000CD2A
		public override global::NPOI.SS.UserModel.CellType GetFormulaType()
		{
			return global::NPOI.SS.UserModel.CellType.Error;
		}

		// Token: 0x0400040A RID: 1034
		public byte PreEvaluatedValue;
	}
}
