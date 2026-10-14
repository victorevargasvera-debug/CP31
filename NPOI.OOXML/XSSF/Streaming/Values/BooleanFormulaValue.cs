using System;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming.Values
{
	// Token: 0x020000D1 RID: 209
	public class BooleanFormulaValue : global::NPOI.XSSF.Streaming.Values.FormulaValue
	{
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x000302E7 File Offset: 0x0002E4E7
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x000302EF File Offset: 0x0002E4EF
		public bool PreEvaluatedValue { get; set; }

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00007725 File Offset: 0x00005925
		public override global::NPOI.SS.UserModel.CellType GetFormulaType()
		{
			return global::NPOI.SS.UserModel.CellType.Boolean;
		}
	}
}
