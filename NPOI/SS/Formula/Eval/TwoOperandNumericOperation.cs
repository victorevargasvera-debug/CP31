using System;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000226 RID: 550
	public abstract class TwoOperandNumericOperation : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000D77 RID: 3447 RVA: 0x00025956 File Offset: 0x00023B56
		protected double SingleOperandEvaluate(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			return global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcCellRow, srcCellCol));
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00025968 File Offset: 0x00023B68
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			double num;
			try
			{
				double d = this.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				double d2 = this.SingleOperandEvaluate(arg1, srcRowIndex, srcColumnIndex);
				num = this.Evaluate(d, d2);
				if (num == 0.0 && !(this is global::NPOI.SS.Formula.Eval.SubtractEval))
				{
					return global::NPOI.SS.Formula.Eval.NumberEval.ZERO;
				}
				if (double.IsNaN(num) || double.IsInfinity(num))
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num);
		}

		// Token: 0x06000D79 RID: 3449
		public abstract double Evaluate(double d0, double d1);

		// Token: 0x0400060A RID: 1546
		public static global::NPOI.SS.Formula.Functions.Function AddEval = new global::NPOI.SS.Formula.Eval.AddEval();

		// Token: 0x0400060B RID: 1547
		public static global::NPOI.SS.Formula.Functions.Function DivideEval = new global::NPOI.SS.Formula.Eval.DivideEval();

		// Token: 0x0400060C RID: 1548
		public static global::NPOI.SS.Formula.Functions.Function MultiplyEval = new global::NPOI.SS.Formula.Eval.MultiplyEval();

		// Token: 0x0400060D RID: 1549
		public static global::NPOI.SS.Formula.Functions.Function PowerEval = new global::NPOI.SS.Formula.Eval.PowerEval();

		// Token: 0x0400060E RID: 1550
		public static global::NPOI.SS.Formula.Functions.Function SubtractEval = new global::NPOI.SS.Formula.Eval.SubtractEval();
	}
}
