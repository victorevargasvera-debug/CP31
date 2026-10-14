using System;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming.Values
{
	// Token: 0x020000D5 RID: 213
	public abstract class FormulaValue : global::NPOI.XSSF.Streaming.Values.Value
	{
		// Token: 0x06000DDB RID: 3547 RVA: 0x00007BAC File Offset: 0x00005DAC
		public new global::NPOI.SS.UserModel.CellType GetType()
		{
			return global::NPOI.SS.UserModel.CellType.Formula;
		}

		// Token: 0x06000DDC RID: 3548
		public abstract global::NPOI.SS.UserModel.CellType GetFormulaType();

		// Token: 0x0400040C RID: 1036
		public string Value;
	}
}
