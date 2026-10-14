using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Util;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000138 RID: 312
	public class Delta : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction, global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A20 RID: 2592 RVA: 0x0001A68C File Offset: 0x0001888C
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg1, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			double num = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(singleValue));
			if (double.IsNaN(num))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval singleValue2;
			try
			{
				singleValue2 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg2, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex2)
			{
				return ex2.GetErrorEval();
			}
			double num2 = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(singleValue2));
			if (double.IsNaN(num2))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (global::NPOI.SS.Util.NumberComparer.Compare(num, num2) != 0)
			{
				return global::NPOI.SS.Formula.Functions.Delta.ZERO;
			}
			return global::NPOI.SS.Formula.Functions.Delta.ONE;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0001A72C File Offset: 0x0001892C
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length == 2)
			{
				return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0], args[1]);
			}
			return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
		}

		// Token: 0x04000510 RID: 1296
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.Delta();

		// Token: 0x04000511 RID: 1297
		private static global::NPOI.SS.Formula.Eval.NumberEval ONE = new global::NPOI.SS.Formula.Eval.NumberEval(1.0);

		// Token: 0x04000512 RID: 1298
		private static global::NPOI.SS.Formula.Eval.NumberEval ZERO = new global::NPOI.SS.Formula.Eval.NumberEval(0.0);
	}
}
