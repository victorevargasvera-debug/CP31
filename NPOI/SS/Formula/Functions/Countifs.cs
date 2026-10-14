using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000135 RID: 309
	public class Countifs : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A13 RID: 2579 RVA: 0x0001A274 File Offset: 0x00018474
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			double num = double.NaN;
			if (args.Length == 0 || args.Length % 2 > 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			int i = 0;
			while (i < args.Length)
			{
				global::NPOI.SS.Formula.Eval.ValueEval valueEval = args[i];
				global::NPOI.SS.Formula.Eval.ValueEval valueEval2 = args[i + 1];
				i += 2;
				global::NPOI.SS.Formula.Eval.NumberEval numberEval = (global::NPOI.SS.Formula.Eval.NumberEval)new global::NPOI.SS.Formula.Functions.Countif().Evaluate(new global::NPOI.SS.Formula.Eval.ValueEval[]
				{
					valueEval,
					valueEval2
				}, ec.RowIndex, ec.ColumnIndex);
				if (double.IsNaN(num))
				{
					num = numberEval.NumberValue;
				}
				else if (numberEval.NumberValue < num)
				{
					num = numberEval.NumberValue;
				}
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(double.IsNaN(num) ? 0.0 : num);
		}

		// Token: 0x04000507 RID: 1287
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.Countifs();
	}
}
