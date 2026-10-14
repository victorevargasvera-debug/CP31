using System;
using System.Text.RegularExpressions;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000144 RID: 324
	public class Imaginary : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction, global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A5A RID: 2650 RVA: 0x0001B498 File Offset: 0x00019698
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval inumberVE)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(inumberVE, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			string input = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(singleValue);
			global::System.Text.RegularExpressions.Match match = global::NPOI.SS.Formula.Functions.Imaginary.COMPLEX_NUMBER_PATTERN.Match(input);
			bool flag = match.Success && match.Groups[0].Length > 0;
			string value = "";
			if (!flag)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			string value2 = match.Groups[5].Value;
			bool flag2 = value2.Equals("i") || value2.Equals("j");
			if (value2.Length == 0)
			{
				return new global::NPOI.SS.Formula.Eval.StringEval(global::System.Convert.ToString(0));
			}
			if (flag2)
			{
				string str = "";
				string value3 = match.Groups[global::NPOI.SS.Formula.Functions.Imaginary.GROUP3_IMAGINARY_SIGN].Value;
				if (value3.Length != 0 && !value3.Equals("+"))
				{
					str = value3;
				}
				string value4 = match.Groups[global::NPOI.SS.Formula.Functions.Imaginary.GROUP4_IMAGINARY_INTEGER_OR_DOUBLE].Value;
				if (value4.Length != 0)
				{
					value = str + value4;
				}
				else
				{
					value = str + "1";
				}
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(value);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00019F68 File Offset: 0x00018168
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0]);
		}

		// Token: 0x0400051C RID: 1308
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.Imaginary();

		// Token: 0x0400051D RID: 1309
		public static string GROUP1_REAL_SIGN_REGEX = "([+-]?)";

		// Token: 0x0400051E RID: 1310
		public static string GROUP2_REAL_INTEGER_OR_DOUBLE_REGEX = "([0-9]+\\.[0-9]+|[0-9]*)";

		// Token: 0x0400051F RID: 1311
		public static string GROUP3_IMAGINARY_SIGN_REGEX = "([+-]?)";

		// Token: 0x04000520 RID: 1312
		public static string GROUP4_IMAGINARY_INTEGER_OR_DOUBLE_REGEX = "([0-9]+\\.[0-9]+|[0-9]*)";

		// Token: 0x04000521 RID: 1313
		public static string GROUP5_IMAGINARY_GROUP_REGEX = "([ij]?)";

		// Token: 0x04000522 RID: 1314
		public static global::System.Text.RegularExpressions.Regex COMPLEX_NUMBER_PATTERN = new global::System.Text.RegularExpressions.Regex(string.Concat(new string[]
		{
			global::NPOI.SS.Formula.Functions.Imaginary.GROUP1_REAL_SIGN_REGEX,
			global::NPOI.SS.Formula.Functions.Imaginary.GROUP2_REAL_INTEGER_OR_DOUBLE_REGEX,
			global::NPOI.SS.Formula.Functions.Imaginary.GROUP3_IMAGINARY_SIGN_REGEX,
			global::NPOI.SS.Formula.Functions.Imaginary.GROUP4_IMAGINARY_INTEGER_OR_DOUBLE_REGEX,
			global::NPOI.SS.Formula.Functions.Imaginary.GROUP5_IMAGINARY_GROUP_REGEX
		}));

		// Token: 0x04000523 RID: 1315
		public static int GROUP1_REAL_SIGN = 1;

		// Token: 0x04000524 RID: 1316
		public static int GROUP2_IMAGINARY_INTEGER_OR_DOUBLE = 2;

		// Token: 0x04000525 RID: 1317
		public static int GROUP3_IMAGINARY_SIGN = 3;

		// Token: 0x04000526 RID: 1318
		public static int GROUP4_IMAGINARY_INTEGER_OR_DOUBLE = 4;
	}
}
