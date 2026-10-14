using System;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000227 RID: 551
	public class UnaryMinusEval : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000D7C RID: 3452 RVA: 0x00019F8B File Offset: 0x0001818B
		private UnaryMinusEval()
		{
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00025A20 File Offset: 0x00023C20
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			double num;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcRowIndex, srcColumnIndex));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			if (num == 0.0)
			{
				return global::NPOI.SS.Formula.Eval.NumberEval.ZERO;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(-num);
		}

		// Token: 0x0400060F RID: 1551
		public static global::NPOI.SS.Formula.Functions.Function instance = new global::NPOI.SS.Formula.Eval.UnaryMinusEval();
	}
}
