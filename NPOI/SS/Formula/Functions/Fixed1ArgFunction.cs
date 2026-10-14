using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000189 RID: 393
	public abstract class Fixed1ArgFunction : global::NPOI.SS.Formula.Functions.Function1Arg, global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000B37 RID: 2871 RVA: 0x0001E6C7 File Offset: 0x0001C8C7
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			if (args.Length != 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(srcRowIndex, srcColumnIndex, args[0]);
		}

		// Token: 0x06000B38 RID: 2872
		public abstract global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0);
	}
}
