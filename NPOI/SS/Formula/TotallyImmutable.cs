using System;

namespace NPOI.SS.Formula
{
	// Token: 0x020000D2 RID: 210
	public class TotallyImmutable : global::NPOI.SS.Formula.IStabilityClassifier
	{
		// Token: 0x06000708 RID: 1800 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsCellFinal(int sheetIndex, int rowIndex, int columnIndex)
		{
			return true;
		}
	}
}
