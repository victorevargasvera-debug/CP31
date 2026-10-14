using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200014C RID: 332
	public class Quotient : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction, global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A74 RID: 2676 RVA: 0x0001BDB0 File Offset: 0x00019FB0
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval venumerator, global::NPOI.SS.Formula.Eval.ValueEval vedenominator)
		{
			double num = 0.0;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(venumerator, srcRowIndex, srcColumnIndex));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			double num2 = 0.0;
			try
			{
				num2 = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(vedenominator, srcRowIndex, srcColumnIndex));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (num2 == 0.0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.DIV_ZERO;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)((int)(num / num2)));
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0001BE40 File Offset: 0x0001A040
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0], args[1]);
		}

		// Token: 0x0400052D RID: 1325
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.Quotient();
	}
}
