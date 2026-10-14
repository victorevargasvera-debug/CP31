using System;
using NPOI.SS.Formula.Eval;
using NPOI.Util;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x0200022F RID: 559
	public class DateParser
	{
		// Token: 0x06000DB6 RID: 3510 RVA: 0x0000253E File Offset: 0x0000073E
		private DateParser()
		{
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0002643C File Offset: 0x0002463C
		public static global::System.DateTime ParseDate(string strVal)
		{
			string[] array = strVal.Split("-/".ToCharArray());
			if (array.Length != 3)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			string text = array[2];
			int num = text.IndexOf(' ');
			if (num > 0)
			{
				text = text.Substring(0, num);
			}
			int num2;
			int num3;
			int num4;
			try
			{
				num2 = int.Parse(array[0]);
				num3 = int.Parse(array[1]);
				num4 = int.Parse(text);
			}
			catch (global::System.FormatException)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			if (num2 < 0 || num3 < 0 || num4 < 0 || (num2 > 12 && num3 > 12 && num4 > 12))
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			if (num2 >= 1900 && num2 < 9999)
			{
				return global::NPOI.SS.Formula.Atp.DateParser.MakeDate(num2, num3, num4);
			}
			throw new global::NPOI.Util.RuntimeException("Unable to determine date format for text '" + strVal + "'");
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0002651C File Offset: 0x0002471C
		private static global::System.DateTime MakeDate(int year, int month, int day)
		{
			if (month < 1 || month > 12)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			global::System.DateTime dateTime = new global::System.DateTime(year, month, 1, 0, 0, 0);
			int day2 = dateTime.AddMonths(1).AddDays(-1.0).Day;
			if (day < 1 || day > day2)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			return new global::System.DateTime(year, month, day);
		}
	}
}
