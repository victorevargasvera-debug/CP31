using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200016F RID: 367
	public class Not : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000AD9 RID: 2777 RVA: 0x0001D498 File Offset: 0x0001B698
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			bool flag2;
			try
			{
				bool? flag = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToBoolean(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcRowIndex, srcColumnIndex), false);
				flag2 = (flag != null && flag.Value);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return global::NPOI.SS.Formula.Eval.BoolEval.ValueOf(!flag2);
		}
	}
}
