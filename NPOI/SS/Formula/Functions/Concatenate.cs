using System;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001EB RID: 491
	public class Concatenate : global::NPOI.SS.Formula.Functions.TextFunction
	{
		// Token: 0x06000C86 RID: 3206 RVA: 0x00022460 File Offset: 0x00020660
		public override global::NPOI.SS.Formula.Eval.ValueEval EvaluateFunc(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int i = 0;
			int num = args.Length;
			while (i < num)
			{
				stringBuilder.Append(global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(args[i], srcCellRow, srcCellCol));
				i++;
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(stringBuilder.ToString());
		}
	}
}
