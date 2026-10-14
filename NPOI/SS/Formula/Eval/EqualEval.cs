using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000218 RID: 536
	public class EqualEval : global::NPOI.SS.Formula.Eval.RelationalOperationEval
	{
		// Token: 0x06000D55 RID: 3413 RVA: 0x00025601 File Offset: 0x00023801
		public override bool ConvertComparisonResult(int cmpResult)
		{
			return cmpResult == 0;
		}
	}
}
