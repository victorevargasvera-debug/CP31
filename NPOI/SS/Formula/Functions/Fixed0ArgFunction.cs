using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000188 RID: 392
	public abstract class Fixed0ArgFunction : global::NPOI.SS.Formula.Functions.Function0Arg, global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000B34 RID: 2868 RVA: 0x0001E6B3 File Offset: 0x0001C8B3
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			if (args.Length != 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(srcRowIndex, srcColumnIndex);
		}

		// Token: 0x06000B35 RID: 2869
		public abstract global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex);
	}
}
