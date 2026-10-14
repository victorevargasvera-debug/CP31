using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200018A RID: 394
	public abstract class Fixed2ArgFunction : global::NPOI.SS.Formula.Functions.Function2Arg, global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000B3A RID: 2874 RVA: 0x0001E6E0 File Offset: 0x0001C8E0
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			if (args.Length != 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1]);
		}

		// Token: 0x06000B3B RID: 2875
		public abstract global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1);
	}
}
