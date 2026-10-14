using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000219 RID: 537
	public class GreaterEqualEval : global::NPOI.SS.Formula.Eval.RelationalOperationEval
	{
		// Token: 0x06000D57 RID: 3415 RVA: 0x0002560F File Offset: 0x0002380F
		public override bool ConvertComparisonResult(int cmpResult)
		{
			return cmpResult >= 0;
		}
	}
}
