using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x0200021B RID: 539
	public class LessEqualEval : global::NPOI.SS.Formula.Eval.RelationalOperationEval
	{
		// Token: 0x06000D5B RID: 3419 RVA: 0x0002561E File Offset: 0x0002381E
		public override bool ConvertComparisonResult(int cmpResult)
		{
			return cmpResult <= 0;
		}
	}
}
