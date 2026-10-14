using System;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000228 RID: 552
	public class UnaryPlusEval : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000D7F RID: 3455 RVA: 0x00019F8B File Offset: 0x0001818B
		private UnaryPlusEval()
		{
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00025A7C File Offset: 0x00023C7C
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcCellRow, int srcCellCol, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			double value;
			try
			{
				global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcCellRow, srcCellCol);
				if (singleValue is global::NPOI.SS.Formula.Eval.BlankEval)
				{
					return global::NPOI.SS.Formula.Eval.NumberEval.ZERO;
				}
				if (singleValue is global::NPOI.SS.Formula.Eval.StringEval)
				{
					return singleValue;
				}
				value = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(singleValue);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(value);
		}

		// Token: 0x04000610 RID: 1552
		public static global::NPOI.SS.Formula.Functions.Function instance = new global::NPOI.SS.Formula.Eval.UnaryPlusEval();
	}
}
