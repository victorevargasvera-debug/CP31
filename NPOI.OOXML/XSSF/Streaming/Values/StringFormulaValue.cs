using System;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming.Values
{
	// Token: 0x020000DA RID: 218
	public class StringFormulaValue : global::NPOI.XSSF.Streaming.Values.FormulaValue
	{
		// Token: 0x06000DE7 RID: 3559 RVA: 0x00006FBA File Offset: 0x000051BA
		public override global::NPOI.SS.UserModel.CellType GetFormulaType()
		{
			return global::NPOI.SS.UserModel.CellType.String;
		}

		// Token: 0x04000411 RID: 1041
		public string PreEvaluatedValue;
	}
}
