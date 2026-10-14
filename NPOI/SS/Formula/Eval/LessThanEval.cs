using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x0200021C RID: 540
	public class LessThanEval : global::NPOI.SS.Formula.Eval.RelationalOperationEval
	{
		// Token: 0x06000D5D RID: 3421 RVA: 0x00025627 File Offset: 0x00023827
		public override bool ConvertComparisonResult(int cmpResult)
		{
			return cmpResult < 0;
		}
	}
}
