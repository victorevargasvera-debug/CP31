using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x0200021A RID: 538
	public class GreaterThanEval : global::NPOI.SS.Formula.Eval.RelationalOperationEval
	{
		// Token: 0x06000D59 RID: 3417 RVA: 0x00025618 File Offset: 0x00023818
		public override bool ConvertComparisonResult(int cmpResult)
		{
			return cmpResult > 0;
		}
	}
}
