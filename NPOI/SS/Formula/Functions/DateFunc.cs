using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200017F RID: 383
	public class DateFunc : global::NPOI.SS.Formula.Functions.Fixed3ArgFunction
	{
		// Token: 0x06000B0C RID: 2828 RVA: 0x0001DDD1 File Offset: 0x0001BFD1
		private DateFunc()
		{
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0001DDDC File Offset: 0x0001BFDC
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			double num3;
			try
			{
				double d = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				double num = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg1, srcRowIndex, srcColumnIndex);
				double num2 = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg2, srcRowIndex, srcColumnIndex);
				num3 = this.Evaluate(this.GetYear(d), (int)num, (int)num2);
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num3);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num3);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0001DE44 File Offset: 0x0001C044
		public double Evaluate(int year, int month, int pDay)
		{
			if (year < 0)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			while (month <= 0)
			{
				year--;
				month += 12;
			}
			if (year == 1900 && month == 2 && pDay == 29)
			{
				return 60.0;
			}
			int num = pDay;
			if (year == 1900 && ((month == 1 && num >= 60) || (month == 2 && num >= 30)))
			{
				num--;
			}
			bool use1904windowing = false;
			return global::NPOI.SS.UserModel.DateUtil.GetExcelDate(year, month, num, 0, 0, 0, use1904windowing);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0001DEB8 File Offset: 0x0001C0B8
		private int GetYear(double d)
		{
			int num = (int)d;
			if (num < 0)
			{
				return -1;
			}
			if (num >= 1900)
			{
				return num;
			}
			return 1900 + num;
		}

		// Token: 0x0400055F RID: 1375
		public static global::NPOI.SS.Formula.Functions.Function instance = new global::NPOI.SS.Formula.Functions.DateFunc();
	}
}
