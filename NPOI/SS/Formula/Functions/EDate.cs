using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000157 RID: 343
	public class EDate : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000AA1 RID: 2721 RVA: 0x0000253E File Offset: 0x0000073E
		internal EDate()
		{
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0001CC4C File Offset: 0x0001AE4C
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				double value = this.GetValue(args[0]);
				int months = (int)this.GetValue(args[1]);
				double excelDate = global::NPOI.SS.UserModel.DateUtil.GetExcelDate(global::NPOI.SS.UserModel.DateUtil.GetJavaDate(value).AddMonths(months));
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(excelDate);
				result = new global::NPOI.SS.Formula.Eval.NumberEval(excelDate);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0001CCB4 File Offset: 0x0001AEB4
		private double GetValue(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			if (arg is global::NPOI.SS.Formula.Eval.NumberEval)
			{
				return ((global::NPOI.SS.Formula.Eval.NumberEval)arg).NumberValue;
			}
			if (arg is global::NPOI.SS.Formula.Eval.BlankEval)
			{
				return 0.0;
			}
			if (arg is global::NPOI.SS.Formula.Eval.RefEval)
			{
				global::NPOI.SS.Formula.Eval.RefEval refEval = (global::NPOI.SS.Formula.Eval.RefEval)arg;
				if (refEval.NumberOfSheets > 1)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
				}
				global::NPOI.SS.Formula.Eval.ValueEval innerValueEval = refEval.GetInnerValueEval(refEval.FirstSheetIndex);
				if (innerValueEval is global::NPOI.SS.Formula.Eval.NumberEval)
				{
					return ((global::NPOI.SS.Formula.Eval.NumberEval)innerValueEval).NumberValue;
				}
				if (innerValueEval is global::NPOI.SS.Formula.Eval.BlankEval)
				{
					return 0.0;
				}
			}
			throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
		}

		// Token: 0x04000535 RID: 1333
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction Instance = new global::NPOI.SS.Formula.Functions.EDate();
	}
}
