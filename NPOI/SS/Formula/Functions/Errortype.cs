using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200013D RID: 317
	public class Errortype : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000A37 RID: 2615 RVA: 0x0001AF50 File Offset: 0x00019150
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcRowIndex, srcColumnIndex);
				result = global::NPOI.SS.Formula.Eval.ErrorEval.NA;
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = new global::NPOI.SS.Formula.Eval.NumberEval((double)this.TranslateErrorCodeToErrorTypeValue(ex.GetErrorEval().ErrorCode));
			}
			return result;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0001AF9C File Offset: 0x0001919C
		private int TranslateErrorCodeToErrorTypeValue(int errorCode)
		{
			global::NPOI.SS.UserModel.FormulaErrorEnum formulaErrorEnum = (global::NPOI.SS.UserModel.FormulaErrorEnum)errorCode;
			if (formulaErrorEnum <= global::NPOI.SS.UserModel.FormulaErrorEnum.VALUE)
			{
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.NULL)
				{
					return 1;
				}
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.DIV_0)
				{
					return 2;
				}
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.VALUE)
				{
					return 3;
				}
			}
			else if (formulaErrorEnum <= global::NPOI.SS.UserModel.FormulaErrorEnum.NAME)
			{
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.REF)
				{
					return 4;
				}
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.NAME)
				{
					return 5;
				}
			}
			else
			{
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.NUM)
				{
					return 6;
				}
				if (formulaErrorEnum == global::NPOI.SS.UserModel.FormulaErrorEnum.NA)
				{
					return 7;
				}
			}
			throw new global::System.ArgumentException("Invalid error code (" + errorCode.ToString() + ")");
		}
	}
}
