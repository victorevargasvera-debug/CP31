using System;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming.Values
{
	// Token: 0x020000D7 RID: 215
	public class NumericValue : global::NPOI.XSSF.Streaming.Values.Value
	{
		// Token: 0x06000DE0 RID: 3552 RVA: 0x00005008 File Offset: 0x00003208
		public new global::NPOI.SS.UserModel.CellType GetType()
		{
			return global::NPOI.SS.UserModel.CellType.Numeric;
		}

		// Token: 0x0400040E RID: 1038
		public double Value;
	}
}
