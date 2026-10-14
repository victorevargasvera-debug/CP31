using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000197 RID: 407
	public class IfFunc : global::NPOI.SS.Formula.Functions.Var2or3ArgFunction
	{
		// Token: 0x06000B51 RID: 2897 RVA: 0x0001E828 File Offset: 0x0001CA28
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			bool flag;
			try
			{
				flag = global::NPOI.SS.Formula.Functions.IfFunc.EvaluateFirstArg(arg0, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			if (!flag)
			{
				return global::NPOI.SS.Formula.Eval.BoolEval.FALSE;
			}
			if (arg1 == global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
			{
				return global::NPOI.SS.Formula.Eval.BlankEval.instance;
			}
			return arg1;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0001E874 File Offset: 0x0001CA74
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			bool flag;
			try
			{
				flag = global::NPOI.SS.Formula.Functions.IfFunc.EvaluateFirstArg(arg0, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			if (flag)
			{
				if (arg1 == global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
				{
					return global::NPOI.SS.Formula.Eval.BlankEval.instance;
				}
				return arg1;
			}
			else
			{
				if (arg2 == global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
				{
					return global::NPOI.SS.Formula.Eval.BlankEval.instance;
				}
				return arg2;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			return result;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0001E8CC File Offset: 0x0001CACC
		public static bool EvaluateFirstArg(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			bool? flag = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToBoolean(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcCellRow, srcCellCol), false);
			return flag != null && flag.Value;
		}
	}
}
