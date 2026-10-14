using System;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001F1 RID: 497
	public class Replace : global::NPOI.SS.Formula.Functions.TextFunction
	{
		// Token: 0x06000C94 RID: 3220 RVA: 0x00022638 File Offset: 0x00020838
		public override global::NPOI.SS.Formula.Eval.ValueEval EvaluateFunc(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			if (args.Length != 4)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			string text = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(args[0], srcCellRow, srcCellCol);
			int num = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateIntArg(args[1], srcCellRow, srcCellCol);
			int num2 = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateIntArg(args[2], srcCellRow, srcCellCol);
			string value = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(args[3], srcCellRow, srcCellCol);
			if (num < 1 || num2 < 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(text);
			if (num <= text.Length && num2 != 0)
			{
				stringBuilder.Remove(num - 1, global::System.Math.Min(num2, text.Length - num + 1));
			}
			if (num > stringBuilder.Length)
			{
				stringBuilder.Append(value);
			}
			else
			{
				stringBuilder.Insert(num - 1, value);
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(stringBuilder.ToString());
		}
	}
}
