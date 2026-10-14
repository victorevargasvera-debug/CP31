using System;

namespace NPOI.SS.Formula
{
	// Token: 0x020000D1 RID: 209
	public abstract class IStabilityClassifier
	{
		// Token: 0x06000705 RID: 1797
		public abstract bool IsCellFinal(int sheetIndex, int rowIndex, int columnIndex);

		// Token: 0x040003CF RID: 975
		private static global::NPOI.SS.Formula.IStabilityClassifier TOTALLY_IMMUTABLE = new global::NPOI.SS.Formula.TotallyImmutable();
	}
}
