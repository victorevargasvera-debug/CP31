using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula
{
	// Token: 0x020000D0 RID: 208
	public interface IEvaluationListener
	{
		// Token: 0x060006FC RID: 1788
		void OnCacheHit(int sheetIndex, int rowIndex, int columnIndex, global::NPOI.SS.Formula.Eval.ValueEval result);

		// Token: 0x060006FD RID: 1789
		void OnReadPlainValue(int sheetIndex, int rowIndex, int columnIndex, global::NPOI.SS.Formula.ICacheEntry entry);

		// Token: 0x060006FE RID: 1790
		void OnStartEvaluate(global::NPOI.SS.Formula.IEvaluationCell cell, global::NPOI.SS.Formula.ICacheEntry entry);

		// Token: 0x060006FF RID: 1791
		void OnEndEvaluate(global::NPOI.SS.Formula.ICacheEntry entry, global::NPOI.SS.Formula.Eval.ValueEval result);

		// Token: 0x06000700 RID: 1792
		void OnClearWholeCache();

		// Token: 0x06000701 RID: 1793
		void OnClearCachedValue(global::NPOI.SS.Formula.ICacheEntry entry);

		// Token: 0x06000702 RID: 1794
		void SortDependentCachedValues(global::NPOI.SS.Formula.ICacheEntry[] formulaCells);

		// Token: 0x06000703 RID: 1795
		void OnClearDependentCachedValue(global::NPOI.SS.Formula.ICacheEntry formulaCell, int depth);

		// Token: 0x06000704 RID: 1796
		void OnChangeFromBlankValue(int sheetIndex, int rowIndex, int columnIndex, global::NPOI.SS.Formula.IEvaluationCell cell, global::NPOI.SS.Formula.ICacheEntry entry);
	}
}
