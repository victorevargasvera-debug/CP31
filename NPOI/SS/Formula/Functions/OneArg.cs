using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001C9 RID: 457
	public abstract class OneArg : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000C14 RID: 3092 RVA: 0x00020F64 File Offset: 0x0001F164
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			double num;
			try
			{
				double d = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				num = this.Evaluate(d);
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00020FAC File Offset: 0x0001F1AC
		protected double Eval(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, short srcCellCol)
		{
			if (args.Length != 1)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			double d = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(args[0], srcCellRow, (int)srcCellCol);
			return this.Evaluate(d);
		}

		// Token: 0x06000C16 RID: 3094
		public abstract double Evaluate(double d);
	}
}
