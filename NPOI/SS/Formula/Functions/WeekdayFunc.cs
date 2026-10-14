using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000155 RID: 341
	public class WeekdayFunc : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000A99 RID: 2713 RVA: 0x0000253E File Offset: 0x0000073E
		private WeekdayFunc()
		{
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0001CA78 File Offset: 0x0001AC78
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				if (args.Length < 1 || args.Length > 2)
				{
					result = global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				else
				{
					double num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[0], srcRowIndex, srcColumnIndex));
					if (!global::NPOI.SS.UserModel.DateUtil.IsValidExcelDate(num))
					{
						result = global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
					}
					else
					{
						int num2 = (int)(global::NPOI.SS.UserModel.DateUtil.GetJavaCalendar(num, false).DayOfWeek + 1);
						int num3 = 1;
						if (args.Length == 2)
						{
							global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[1], srcRowIndex, srcColumnIndex);
							if (singleValue == global::NPOI.SS.Formula.Eval.MissingArgEval.instance || singleValue == global::NPOI.SS.Formula.Eval.BlankEval.instance)
							{
								return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
							}
							num3 = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(singleValue);
							if (num3 == 2)
							{
								num3 = 11;
							}
						}
						double value;
						if (num3 == 1)
						{
							value = (double)num2;
						}
						else if (num3 == 3)
						{
							value = (double)((num2 + 6 - 1) % 7);
						}
						else
						{
							if (num3 < 11 || num3 > 17)
							{
								return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
							}
							value = (double)((num2 + 6 - (num3 - 10)) % 7 + 1);
						}
						result = new global::NPOI.SS.Formula.Eval.NumberEval(value);
					}
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x04000533 RID: 1331
		public static global::NPOI.SS.Formula.Functions.Function instance = new global::NPOI.SS.Formula.Functions.WeekdayFunc();
	}
}
