using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x0200021D RID: 541
	public class NotEqualEval : global::NPOI.SS.Formula.Eval.RelationalOperationEval
	{
		// Token: 0x06000D5F RID: 3423 RVA: 0x0002562D File Offset: 0x0002382D
		public override bool ConvertComparisonResult(int cmpResult)
		{
			return cmpResult != 0;
		}
	}
}
