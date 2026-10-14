using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200017D RID: 381
	public interface I_MatchAreaPredicate : global::NPOI.SS.Formula.Functions.IMatchPredicate
	{
		// Token: 0x06000B07 RID: 2823
		bool Matches(global::NPOI.SS.Formula.TwoDEval x, int rowIndex, int columnIndex);
	}
}
