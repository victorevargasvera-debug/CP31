using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001F5 RID: 501
	public abstract class SingleArgTextFunc : global::NPOI.SS.Formula.Functions.TextFunction
	{
		// Token: 0x06000CA2 RID: 3234 RVA: 0x000229D0 File Offset: 0x00020BD0
		public override global::NPOI.SS.Formula.Eval.ValueEval EvaluateFunc(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			if (args.Length != 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			string arg = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(args[0], srcCellRow, srcCellCol);
			return this.Evaluate(arg);
		}

		// Token: 0x06000CA3 RID: 3235
		public abstract global::NPOI.SS.Formula.Eval.ValueEval Evaluate(string arg);
	}
}
