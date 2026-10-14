using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001AB RID: 427
	public interface ValueVector
	{
		// Token: 0x06000BA6 RID: 2982
		global::NPOI.SS.Formula.Eval.ValueEval GetItem(int index);

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000BA7 RID: 2983
		int Size { get; }
	}
}
