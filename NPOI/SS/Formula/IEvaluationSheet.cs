using System;

namespace NPOI.SS.Formula
{
	// Token: 0x020000BB RID: 187
	public interface IEvaluationSheet
	{
		// Token: 0x06000659 RID: 1625
		global::NPOI.SS.Formula.IEvaluationCell GetCell(int rowIndex, int columnIndex);

		// Token: 0x0600065A RID: 1626
		void ClearAllCachedResultValues();
	}
}
