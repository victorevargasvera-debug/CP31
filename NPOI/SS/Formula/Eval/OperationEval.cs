using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000213 RID: 531
	public interface OperationEval : global::NPOI.SS.Formula.Eval.Eval
	{
		// Token: 0x06000D3C RID: 3388
		global::NPOI.SS.Formula.Eval.Eval Evaluate(global::NPOI.SS.Formula.Eval.Eval[] evals, int srcCellRow, short srcCellCol);

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000D3D RID: 3389
		int NumberOfOperands { get; }
	}
}
