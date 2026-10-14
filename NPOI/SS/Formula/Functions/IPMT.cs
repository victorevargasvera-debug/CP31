using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000147 RID: 327
	public class IPMT : global::NPOI.SS.Formula.Functions.NumericFunction
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x0001B7D8 File Offset: 0x000199D8
		protected override double Eval(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			if (args.Length != 4)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[0], srcCellRow, srcCellCol);
			global::NPOI.SS.Formula.Eval.ValueEval singleValue2 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[1], srcCellRow, srcCellCol);
			global::NPOI.SS.Formula.Eval.ValueEval singleValue3 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[2], srcCellRow, srcCellCol);
			global::NPOI.SS.Formula.Eval.ValueEval singleValue4 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[3], srcCellRow, srcCellCol);
			double r = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(singleValue);
			int per = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(singleValue2);
			int nper = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(singleValue3);
			double pv = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(singleValue4);
			double result = global::NPOI.SS.Formula.Functions.Finance.IPMT(r, per, nper, pv);
			global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(result);
			return result;
		}
	}
}
