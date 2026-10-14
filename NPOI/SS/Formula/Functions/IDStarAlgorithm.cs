using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000143 RID: 323
	public interface IDStarAlgorithm
	{
		// Token: 0x06000A58 RID: 2648
		bool ProcessMatch(global::NPOI.SS.Formula.Eval.ValueEval Eval);

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000A59 RID: 2649
		global::NPOI.SS.Formula.Eval.ValueEval Result { get; }
	}
}
