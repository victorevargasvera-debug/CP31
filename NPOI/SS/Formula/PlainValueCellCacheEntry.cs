using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula
{
	// Token: 0x020000DB RID: 219
	public class PlainValueCellCacheEntry : global::NPOI.SS.Formula.CellCacheEntry
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x00013644 File Offset: 0x00011844
		public PlainValueCellCacheEntry(global::NPOI.SS.Formula.Eval.ValueEval value)
		{
			base.UpdateValue(value);
		}
	}
}
