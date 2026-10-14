using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001FD RID: 509
	public abstract class Var2or3ArgFunction : global::NPOI.SS.Formula.Functions.Function2Arg, global::NPOI.SS.Formula.Functions.Function, global::NPOI.SS.Formula.Functions.Function3Arg
	{
		// Token: 0x06000CBD RID: 3261 RVA: 0x00022F24 File Offset: 0x00021124
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			int num = args.Length;
			if (num == 2)
			{
				return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1]);
			}
			if (num != 3)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1], args[2]);
		}

		// Token: 0x06000CBE RID: 3262
		public abstract global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1);

		// Token: 0x06000CBF RID: 3263
		public abstract global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2);
	}
}
