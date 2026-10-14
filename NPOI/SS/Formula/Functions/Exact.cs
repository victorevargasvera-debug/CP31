using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001EC RID: 492
	public class Exact : global::NPOI.SS.Formula.Functions.TextFunction
	{
		// Token: 0x06000C88 RID: 3208 RVA: 0x000224A8 File Offset: 0x000206A8
		public override global::NPOI.SS.Formula.Eval.ValueEval EvaluateFunc(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			if (args.Length != 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			string text = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(args[0], srcCellRow, srcCellCol);
			string value = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(args[1], srcCellRow, srcCellCol);
			return global::NPOI.SS.Formula.Eval.BoolEval.ValueOf(text.Equals(value));
		}
	}
}
