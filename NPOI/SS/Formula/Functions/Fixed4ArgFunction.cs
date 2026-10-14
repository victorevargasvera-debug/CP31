using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200018C RID: 396
	public abstract class Fixed4ArgFunction : global::NPOI.SS.Formula.Functions.Function4Arg, global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000B40 RID: 2880 RVA: 0x0001E71B File Offset: 0x0001C91B
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			if (args.Length != 4)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1], args[2], args[3]);
		}

		// Token: 0x06000B41 RID: 2881
		public abstract global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2, global::NPOI.SS.Formula.Eval.ValueEval arg3);
	}
}
