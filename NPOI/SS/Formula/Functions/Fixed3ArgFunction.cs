using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200018B RID: 395
	public abstract class Fixed3ArgFunction : global::NPOI.SS.Formula.Functions.Function3Arg, global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000B3D RID: 2877 RVA: 0x0001E6FC File Offset: 0x0001C8FC
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			if (args.Length != 3)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1], args[2]);
		}

		// Token: 0x06000B3E RID: 2878
		public abstract global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2);
	}
}
