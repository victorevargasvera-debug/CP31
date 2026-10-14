using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001F0 RID: 496
	public class Mid : global::NPOI.SS.Formula.Functions.TextFunction
	{
		// Token: 0x06000C92 RID: 3218 RVA: 0x000225B0 File Offset: 0x000207B0
		public override global::NPOI.SS.Formula.Eval.ValueEval EvaluateFunc(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			if (args.Length != 3)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			string text = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(args[0], srcCellRow, srcCellCol);
			int num = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateIntArg(args[1], srcCellRow, srcCellCol);
			int num2 = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateIntArg(args[2], srcCellRow, srcCellCol);
			int num3 = num - 1;
			if (num3 < 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (num2 < 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			int length = text.Length;
			if (num2 < 0 || num3 > length)
			{
				return new global::NPOI.SS.Formula.Eval.StringEval("");
			}
			int num4 = global::System.Math.Min(num3 + num2, length);
			return new global::NPOI.SS.Formula.Eval.StringEval(text.Substring(num3, num4 - num3));
		}
	}
}
